using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WhiskerPrint.DataLayer;
using WhiskerPrint.LogicLayer;
using WhiskerPrint.LogicLayer.Matching;
using AnimalsRow = WhiskerPrint.DataLayer.AnimalsDataSet.AnimalsRow;
using PhotosRow = WhiskerPrint.DataLayer.AnimalsDataSet.PhotosRow;
using AnchorsRow = WhiskerPrint.DataLayer.AnimalsDataSet.AnchorsRow;
using Chamfer = WhiskerPrint.LogicLayer.Matching.Chamfer;
using FeaturesRow = WhiskerPrint.DataLayer.AnimalsDataSet.FeaturesRow;

namespace WhiskerPrint.PresentationLayer
{
    public partial class FeaturePrintForm : Form
    {
        private int actualImageWidth;
        private int actualImageHeight;

        private Color anchor1Color = Color.RoyalBlue;
        private Color anchor2Color = Color.Red;
        private Color anchor3Color = Color.Yellow;

        private Color libraryTitlePanelColor = Color.LightSteelBlue;
        private Color candidateTitlePanelColor = Color.PaleGoldenrod;

        private Library library = null;

        private AnchorDrawer anchorDrawer = new AnchorDrawer();
        private FeatureExtractor featureExtractor = new FeatureExtractor();
        private IMatcher matcher = new Shifter(new Cascader(new Chamfer()));
        //private IMatcher matcher = new RecursiveShifter(new Cascader(new Chamfer()));
        //Search for RecursiveShifter and change accordingly

        private ComparisonsDataSet comparisonsDataSet = new ComparisonsDataSet();
        private IDictionary<int, double> comparisons = new Dictionary<int, double>();

        private OptionsSettings optionsSettings;
        private OptionsDialog optionsDialog;

        public FeaturePrintForm()
        {
            InitializeComponent();

            // Add a single animal to the candidate date set
            candidateDataSet.Animals.AddAnimalsRow(0, "0", "Candidate");

            // Display the "Double-click" message when adding a new photo row
            photosPhoto.DefaultCellStyle.NullValue = photoNullPictureBox.Image;

            // Initialize options settings/dialog
            optionsSettings = new OptionsSettings();
            optionsDialog = new OptionsDialog(optionsSettings);

            InitMatcher();

            comparisonsBindingSource.DataSource = comparisonsDataSet;
            comparisonsBindingSource.DataMember = "Comparisons";

            // Change size of window
            Size = new Size(1024, 768);
        }

        #region Event Handlers
        #region Form
        private void FeaturePrintForm_Load(object sender, EventArgs e)
        {
        }
        private void FeaturePrintForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CloseLibrary(library))
            {
                e.Cancel = true;
            }
        }
        #endregion
        #region Menu Bar
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditOptions();
        }
        #endregion
        #region Toolbar
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            NewLibrary();
        }
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenLibrary();
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveLibrary(library);
        }
        private void libraryToolStripButton_Click(object sender, EventArgs e)
        {
            if (libraryToolStripButton.Checked)
            {
                // Do nothing; already checked
            }
            else
            {
                // Switch mode to viewing active library
                SwitchToLibraryMode();
            }
        }
        private void candidateToolStripButton_Click(object sender, EventArgs e)
        {
            if (candidateToolStripButton.Checked)
            {
                // Do nothing; already checked
            }
            else
            {
                // Switch mode to matching new animal
                SwitchToCandidateMode();
            }
        }
        private void matchToolStripSplitButton_ButtonClick(object sender, EventArgs e)
        {
            if (libraryDataSet == null)
            {
                return;
            }

            // Set up progress bar
            int count = CountStepsInMatchingCandidateWithLibrary();
            StatusProgress(count);

            comparisonsDataSet.Clear();

            comparisonsBindingSource.DataSource = null;
            matcherBackgroundWorker.RunWorkerAsync();
        }
        private void matchCandidateWithLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (matchCandidateWithLibraryToolStripMenuItem.Checked)
            {
                // Do nothing; already checked
            }
            else
            {
                // Update matching option buttons
                matchCandidateWithLibraryToolStripMenuItem.Checked = true;
                matchCandidateWithAnimalToolStripMenuItem.Checked = false;
                matchCandidateWithPhotoToolStripMenuItem.Checked = false;
                matchPhotoWithLibraryToolStripMenuItem.Checked = false;
                matchPhotoWithAnimalToolStripMenuItem.Checked = false;
                matchPhotoWithPhotoToolStripMenuItem.Checked = false;
            }
        }
        private void matchCandidateWithAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (matchCandidateWithAnimalToolStripMenuItem.Checked)
            {
                // Do nothing; already checked
            }
            else
            {
                // Update matching option buttons
                matchCandidateWithLibraryToolStripMenuItem.Checked = false;
                matchCandidateWithAnimalToolStripMenuItem.Checked = true;
                matchCandidateWithPhotoToolStripMenuItem.Checked = false;
                matchPhotoWithLibraryToolStripMenuItem.Checked = false;
                matchPhotoWithAnimalToolStripMenuItem.Checked = false;
                matchPhotoWithPhotoToolStripMenuItem.Checked = false;
            }
        }
        private void matchCandidateWithPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (matchCandidateWithPhotoToolStripMenuItem.Checked)
            {
                // Do nothing; already checked
            }
            else
            {
                // Update matching option buttons
                matchCandidateWithLibraryToolStripMenuItem.Checked = false;
                matchCandidateWithAnimalToolStripMenuItem.Checked = false;
                matchCandidateWithPhotoToolStripMenuItem.Checked = true;
                matchPhotoWithLibraryToolStripMenuItem.Checked = false;
                matchPhotoWithAnimalToolStripMenuItem.Checked = false;
                matchPhotoWithPhotoToolStripMenuItem.Checked = false;
            }
        }
        private void matchPhotoWithLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (matchPhotoWithLibraryToolStripMenuItem.Checked)
            {
                // Do nothing; already checked
            }
            else
            {
                // Update matching option buttons
                matchCandidateWithLibraryToolStripMenuItem.Checked = false;
                matchCandidateWithAnimalToolStripMenuItem.Checked = false;
                matchCandidateWithPhotoToolStripMenuItem.Checked = false;
                matchPhotoWithLibraryToolStripMenuItem.Checked = true;
                matchPhotoWithAnimalToolStripMenuItem.Checked = false;
                matchPhotoWithPhotoToolStripMenuItem.Checked = false;
            }
        }
        private void matchPhotoWithAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (matchPhotoWithAnimalToolStripMenuItem.Checked)
            {
                // Do nothing; already checked
            }
            else
            {
                // Update matching option buttons
                matchCandidateWithLibraryToolStripMenuItem.Checked = false;
                matchCandidateWithAnimalToolStripMenuItem.Checked = false;
                matchCandidateWithPhotoToolStripMenuItem.Checked = false;
                matchPhotoWithLibraryToolStripMenuItem.Checked = false;
                matchPhotoWithAnimalToolStripMenuItem.Checked = true;
                matchPhotoWithPhotoToolStripMenuItem.Checked = false;
            }

        }
        private void matchPhotoWithPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (matchPhotoWithPhotoToolStripMenuItem.Checked)
            {
                // Do nothing; already checked
            }
            else
            {
                // Update matching option buttons
                matchCandidateWithLibraryToolStripMenuItem.Checked = false;
                matchCandidateWithAnimalToolStripMenuItem.Checked = false;
                matchCandidateWithPhotoToolStripMenuItem.Checked = false;
                matchPhotoWithLibraryToolStripMenuItem.Checked = false;
                matchPhotoWithAnimalToolStripMenuItem.Checked = false;
                matchPhotoWithPhotoToolStripMenuItem.Checked = true;
            }
        }
        #endregion
        #region Library Binding Navigator
        private void libraryBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            RefreshLibraryBindingNavigator();
        }
        private void libraryBindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AddNewAnimalsRow();
        }
        private void libraryBindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteCurrentAnimalsRow();
        }
        #endregion
        #region Photo Toolbar
        private void anchor1ToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            // If checked, uncheck other anchor buttons
            if (anchor1ToolStripButton.Checked)
            {
                anchor2ToolStripButton.Checked = false;
                anchor3ToolStripButton.Checked = false;
            }
        }
        private void anchor2ToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            // If checked, uncheck other anchor buttons
            if (anchor2ToolStripButton.Checked)
            {
                anchor1ToolStripButton.Checked = false;
                anchor3ToolStripButton.Checked = false;
            }
        }
        private void anchor3ToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            // If checked, uncheck other anchor buttons
            if (anchor3ToolStripButton.Checked)
            {
                anchor1ToolStripButton.Checked = false;
                anchor2ToolStripButton.Checked = false;
            }
        }
        private void showAnchorsToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            // Redraw photo (with or without anchors)
            photoPictureBox.Invalidate();
        }
        private void normalSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (normalSizeToolStripMenuItem.Checked)
            {
                // Do nothing; already checked
            }
            else
            {
                SwitchToNormalPhotoView();
            }
        }
        private void fitToWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fitToWindowToolStripMenuItem.Checked)
            {
                // Do nothing; already checked
            }
            else
            {
                SwitchToFitToWindowPhotoView();
            }
        }
        private void featureToolStripButton_Click(object sender, EventArgs e)
        {
            ExtractFeature();
        }
        #endregion
        #region Photo Picture Box
        private void photoPictureBox_Click(object sender, EventArgs e)
        {
            // Finish editing any data-bound controls
            this.Validate();

            MouseEventArgs me = e as MouseEventArgs;
            if (me.Button == MouseButtons.Left)
            {
                // Modify the location of the selected anchor
                Point anchorLocation = GetNormalPhotoClickLocation(me.Location);
                int anchorNumber = GetCurrentAnchorNumber();
                SetAnchorLocation(anchorNumber, anchorLocation);

                // Automatically allow the user select the next anchor
                CheckNextAnchorNumber();

                // Repaint photo picture box
                photoPictureBox.Invalidate();
            }
        }
        private void photoPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (photoPictureBox.Image == null)
            {
                photoToolStrip.Enabled = false;
            }
            else
            {
                photoToolStrip.Enabled = true;

                if (normalSizeToolStripMenuItem.Checked)
                {
                    // Draw the three anchors normally
                    if (showAnchorsToolStripButton.Checked)
                    {
                        anchorDrawer.DrawAnchor(e.Graphics, GetAnchorLocation(1), anchor1Color);
                        anchorDrawer.DrawAnchor(e.Graphics, GetAnchorLocation(2), anchor2Color);
                        anchorDrawer.DrawAnchor(e.Graphics, GetAnchorLocation(3), anchor3Color);
                    }
                }
                else if (fitToWindowToolStripMenuItem.Checked)
                {
                    // Calculate picture box and image width-to-height rations
                    double pictureBoxWidthToHeightRatio = (double)photoPictureBox.Width / photoPictureBox.Height;
                    double imageWidthToHeightRatio = (double)photoPictureBox.Image.Width / photoPictureBox.Image.Height;

                    // Properly adjust new image dimensions
                    if (pictureBoxWidthToHeightRatio > imageWidthToHeightRatio)
                    {
                        actualImageHeight = photoPictureBox.Height;
                        actualImageWidth = (int)(actualImageHeight * imageWidthToHeightRatio);
                    }
                    else
                    {
                        actualImageWidth = photoPictureBox.Width;
                        actualImageHeight = (int)(actualImageWidth / imageWidthToHeightRatio);
                    }

                    // Clear graphics background and draw image
                    e.Graphics.Clear(photoPictureBox.BackColor);
                    e.Graphics.DrawImage(photoPictureBox.Image, 0, 0, actualImageWidth, actualImageHeight);

                    // Draw the three anchors scaled
                    if (showAnchorsToolStripButton.Checked)
                    {
                        double xScale = (double)actualImageWidth / photoPictureBox.Image.Width;
                        double yScale = (double)actualImageHeight / photoPictureBox.Image.Height;
                        anchorDrawer.DrawAnchor(e.Graphics, GetAnchorLocation(1), xScale, yScale, anchor1Color);
                        anchorDrawer.DrawAnchor(e.Graphics, GetAnchorLocation(2), xScale, yScale, anchor2Color);
                        anchorDrawer.DrawAnchor(e.Graphics, GetAnchorLocation(3), xScale, yScale, anchor3Color);
                    }
                }
            }
        }
        private void photoPictureBox_Resize(object sender, EventArgs e)
        {
            // Repaint picture box if it's resized
            // (gets rid of strange artifacts when resized)
            photoPictureBox.Invalidate();
        }
        #endregion
        #region Photos Binding Navigator
        private void photosBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            if (photosBindingSource.Count > 0)
            {
                photosBindingNavigatorDeleteItem.Enabled = true;
            }
            else
            {
                photosBindingNavigatorDeleteItem.Enabled = false;
            }
        }
        private void photosBindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AddNewPhoto();
        }
        private void photosBindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteCurrentPhoto();
        }
        #endregion
        #region Photo Data Grid View
        private void photosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure the photo cell was double-clicked
            if (e.ColumnIndex == photosDataGridView.Columns["photosPhoto"].Index)
            {
                LoadPhotosDataGridViewPhoto(photosDataGridView[e.ColumnIndex, e.RowIndex]);
            }
        }
        #endregion
        #region Splitters
        private void animalsPhotosSplit_SplitterMoved(object sender, SplitterEventArgs e)
        {
            // Take the focus away from the splitter
            menuStrip1.Focus();
        }
        private void photosFeatureSplit_SplitterMoved(object sender, SplitterEventArgs e)
        {
            // Take the focus away from the splitter
            menuStrip1.Focus();
        }
        private void photosPhotoSplit_SplitterMoved(object sender, SplitterEventArgs e)
        {
            // Take the focus away from the splitter
            menuStrip1.Focus();
        }
        #endregion
        #region Status Bar
        private void matcher_Progress(object sender, EventArgs e)
        {
            matcherBackgroundWorker.ReportProgress(0);
        }
        #endregion
        #endregion
        #region Process Functions
        #region Modes
        private void SwitchToLibraryMode()
        {
            // Update context control buttons
            libraryToolStripButton.Checked = true;
            candidateToolStripButton.Checked = false;

            RefreshTitlePanelColors();

            libraryBindingNavigator.Enabled = true;
            //RefreshLibraryBindingNavigator();

            // Hide score data grid view
            scoresDataGridView.Visible = false;
            
            RefreshPhotosBindingSource();
        }
        private void SwitchToCandidateMode()
        {
            // Update context control buttons
            libraryToolStripButton.Checked = false;
            candidateToolStripButton.Checked = true;

            RefreshTitlePanelColors();

            libraryBindingNavigator.Enabled = false;
            //RefreshLibraryBindingNavigator();

            // Show score data grid view
            scoresDataGridView.Visible = true;
            
            RefreshPhotosBindingSource();
        }
        private void RefreshTitlePanelColors()
        {
            Color titlePanelColor = Color.Black;
            if (libraryToolStripButton.Checked)
            {
                titlePanelColor = libraryTitlePanelColor;
            }
            else if (candidateToolStripButton.Checked)
            {
                titlePanelColor = candidateTitlePanelColor;
            }
            photoTitlePanel.BackColor = titlePanelColor;
            featureTitlePanel.BackColor = titlePanelColor;
            photosTitlePanel.BackColor = titlePanelColor;
        }
        private void RefreshLibraryBindingNavigator()
        {
            if (libraryToolStripButton.Checked)
            {
                libraryBindingNavigatorAddNewItem.Enabled = true;
                if (libraryBindingSource.Count > 0)
                {
                    libraryBindingNavigatorDeleteItem.Enabled = true;
                }
                else
                {
                    libraryBindingNavigatorDeleteItem.Enabled = false;
                }
            }
            else
            {
                libraryBindingNavigatorAddNewItem.Enabled = false;
                libraryBindingNavigatorDeleteItem.Enabled = false;
            }
        }
        private void RefreshPhotosBindingSource()
        {
            photosBindingSource.SuspendBinding();
            photosBindingSource.DataSource = GetActiveBindingSource();
            photosBindingSource.ResumeBinding();
        }
        #endregion
        #region Library
        private void NewLibrary()
        {
            // Load a new library
            LoadLibrary(new Library());
        }
        private void OpenLibrary()
        {
            if (openLibraryDialog.ShowDialog() == DialogResult.OK)
            {
                // Load a library from specified file
                LoadLibrary(Library.FromFile(openLibraryDialog.FileName));
            }
        }
        private void LoadLibrary(Library newLibrary)
        {
            if (newLibrary == null)
            {
                return;
            }

            if (library == null)
            {
                SetLibrary(newLibrary);
            }
            else
            {
                // Try to close the library before loading new one
                if (CloseLibrary(library))
                {
                    SetLibrary(newLibrary);
                }
            }
        }
        private void SetLibrary(Library newLibrary)
        {
            library = newLibrary;

            if (library != null)
            {
                libraryDataSet = newLibrary.AnimalsDataSet;
            }
            else
            {
                libraryDataSet = null;
            }

            libraryBindingSource.SuspendBinding();
            libraryBindingSource.DataSource = libraryDataSet;
            libraryBindingSource.ResumeBinding();

            RefreshPhotosBindingSource();
        }
        private bool CloseLibrary(Library library)
        {
            // Successful close if there is no library
            if (library == null)
            {
                return true;
            }

            // Attempt to save only if library has changes
            if (library.HasChanges)
            {
                // Ask user if library should be saved
                DialogResult saveResult = MessageBox.Show("Do you want to save changes to " +
                    library.Name + "?", "WhiskerPrint", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3);

                if (saveResult == DialogResult.Yes)
                {
                    SaveLibrary(library);
                }
                else if (saveResult == DialogResult.Cancel)
                {
                    return false;
                }
            }

            return true;
        }
        private void SaveLibrary(Library library)
        {
            // Apply pending changes to data
            libraryBindingSource.EndEdit();
            photosBindingSource.EndEdit();
            anchorsBindingSource.EndEdit();
            featuresBindingSource.EndEdit();

            // If data file is new, open a save dialog box
            // to get a file name; otherwise, just save it
            if (library.IsNew)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save data file with specified file name
                    library.Save(saveFileDialog.FileName);
                }
            }
            else
            {
                // Save data file with known file name
                library.Save();
            }
        }
        #endregion
        #region Animals
        private void AddNewAnimalsRow()
        {
            if (libraryDataSet != null)
            {
                libraryDataSet.Animals.AddValidAnimalsRow();
            }
        }
        private void DeleteCurrentAnimalsRow()
        {
            AnimalsRow currentAnimalsRow = GetCurrentAnimalsRow();
            if (currentAnimalsRow != null)
            {
                currentAnimalsRow.Delete();
            }
            currentAnimalsRow.EndEdit();
        }
        private AnimalsRow GetCurrentAnimalsRow()
        {
            BindingSource activeBindingSource = GetActiveBindingSource();
            if (activeBindingSource != null && activeBindingSource.Count > 0)
            {
                return (activeBindingSource.Current as DataRowView).Row as AnimalsRow;
            }
            else
            {
                return null;
            }
        }
        private BindingSource GetActiveBindingSource()
        {
            if (libraryToolStripButton.Checked)
            {
                return libraryBindingSource;
            }
            else if (candidateToolStripButton.Checked)
            {
                return candidateBindingSource;
            }
            else
            {
                return null;
            }
        }
        private AnimalsDataSet GetActiveDataSet()
        {
            BindingSource activeBindingSource = GetActiveBindingSource();
            if (activeBindingSource != null)
            {
                return activeBindingSource.DataSource as AnimalsDataSet;
            }
            else
            {
                return null;
            }
        }
        #endregion
        #region Photos
        private void AddNewPhoto()
        {
            AnimalsDataSet activeDataSet = GetActiveDataSet();
            if (activeDataSet != null)
            {
                AnimalsRow currentAnimalsRow = GetCurrentAnimalsRow();
                if (currentAnimalsRow != null)
                {
                    activeDataSet.Photos.AddValidPhotosRow(GetCurrentAnimalsRow());
                }
            }
        }
        private void DeleteCurrentPhoto()
        {
            PhotosRow currentPhotosRow = GetCurrentPhotosRow();
            if (currentPhotosRow != null)
            {
                currentPhotosRow.Delete();
            }
        }
        private PhotosRow GetCurrentPhotosRow()
        {
            if (photosBindingSource.Count > 0)
            {
                return (photosBindingSource.Current as DataRowView).Row as PhotosRow;
            }
            else
            {
                return null;
            }
        }
        private Image GetPhotoFromUser()
        {
            if (openPhotoDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    return Image.FromFile(openPhotoDialog.FileName);
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        private void LoadPhotosDataGridViewPhoto(DataGridViewCell photoCell)
        {
            // Get photo from user
            Image photo = GetPhotoFromUser();

            if (photo != null)
            {
                // Set cell and photo picture box to selected photo
                photoCell.Value = photoPictureBox.Image = photo;
            }
        }
        #endregion
        #region Anchors
        private void CheckNextAnchorNumber()
        {
            if (anchor1ToolStripButton.Checked)
            {
                anchor2ToolStripButton.Checked = true;
            }
            else if (anchor2ToolStripButton.Checked)
            {
                anchor3ToolStripButton.Checked = true;
            }
            else if (anchor3ToolStripButton.Checked)
            {
                anchor3ToolStripButton.Checked = false;
            }
        }
        private int GetCurrentAnchorNumber()
        {
            if (anchor1ToolStripButton.Checked)
            {
                return 1;
            }
            else if (anchor2ToolStripButton.Checked)
            {
                return 2;
            }
            else if (anchor3ToolStripButton.Checked)
            {
                return 3;
            }
            else
            {
                return -1;
            }
        }
        private Point GetAnchorLocation(int n)
        {
            // Find anchor with specified number (if it exists)
            AnchorsRow anchorRow = FindAnchorByNumber(n);

            // If not found, return Point.Empty;
            // otherwise, return its location
            if (anchorRow == null)
            {
                return Point.Empty;
            }
            else
            {
                return new Point(anchorRow.X, anchorRow.Y);
            }
        }
        private void SetAnchorLocation(int n, Point location)
        {
            if (n < 0)
            {
                return;
            }

            // Find anchor with specified number (if it exists)
            AnchorsRow anchorRow = FindAnchorByNumber(n);

            // If not found, create it and add it;
            // otherwise, just change the location
            if (anchorRow == null)
            {
                AnimalsDataSet activeDataSet = GetActiveDataSet();
                if (activeDataSet != null)
                {
                    int anchorId = activeDataSet.Anchors.GetNextId();
                    PhotosRow photoRow = GetCurrentPhotosRow();
                    if (photoRow != null)
                    {
                        activeDataSet.Anchors.AddAnchorsRow(anchorId, photoRow, n, location.X, location.Y);
                    }
                }
            }
            else
            {
                anchorRow.X = location.X;
                anchorRow.Y = location.Y;
            }
        }
        private AnchorsRow FindAnchorByNumber(int n)
        {
            // Search in anchors binding source
            foreach (DataRowView dataRowView in anchorsBindingSource)
            {
                // Convert current row to an anchor row
                AnchorsRow anchorRow = dataRowView.Row as AnchorsRow;

                // If numbers match, return anchor row
                if (anchorRow.Number == n)
                {
                    return anchorRow;
                }
            }

            // No match found, return null
            return null;
        }
        private Point GetNormalPhotoClickLocation(Point location)
        {
            if (normalSizeToolStripMenuItem.Checked)
            {
                return location;
            }
            else if (fitToWindowToolStripMenuItem.Checked)
            {
                double xScale = (double)actualImageWidth / photoPictureBox.Image.Width;
                double yScale = (double)actualImageHeight / photoPictureBox.Image.Height;

                return new Point((int)(location.X / xScale), (int)(location.Y / yScale));
            }
            else
            {
                return Point.Empty;
            }
        }
        #endregion
        #region Feature
        private void ExtractFeature()
        {
            // Get selected photo as a Bitmap
            Bitmap photo = photoPictureBox.Image as Bitmap;

            // Get photo anchors
            Point[] anchors = new Point[3];
            anchors[0] = GetAnchorLocation(1);
            anchors[1] = GetAnchorLocation(2);
            anchors[2] = GetAnchorLocation(3);

            // Extract feature
            Image feature = featureExtractor.GetFeature(photo, anchors);

            // Update track bars with auto-settings
            smoothingTrackBar.Value = featureExtractor.Smoothing;
            radiusTrackBar.Value = featureExtractor.Radius;
            thresholdTrackBar.Value = featureExtractor.Threshold;

            // Make sure featureBindingSource is ready to bind to feature
            if (GetCurrentFeaturesRow() == null)
            {
                AddNewFeature();
            }

            // Display feature (and bind to data source)
            featurePictureBox.Image = feature;

            // Commit feature to binding source
            featuresBindingSource.EndEdit();
        }
        private void ExtractManualFeature()
        {
            // Get selected photo as a Bitmap
            Bitmap photo = photoPictureBox.Image as Bitmap;

            // Get photo anchors
            Point[] anchors = new Point[3];
            anchors[0] = GetAnchorLocation(1);
            anchors[1] = GetAnchorLocation(2);
            anchors[2] = GetAnchorLocation(3);

            // Extract feature
            Image feature = featureExtractor.GetManualFeature(photo, anchors);

            // Make sure featureBindingSource is ready to bind to feature
            if (GetCurrentFeaturesRow() == null)
            {
                AddNewFeature();
            }

            // Display feature (and bind to data source)
            featurePictureBox.Image = feature;

            // Commit feature to binding source
            featuresBindingSource.EndEdit();
        }
        private void AddNewFeature()
        {
            AnimalsDataSet activeDataSet = GetActiveDataSet();
            if (activeDataSet != null)
            {
                PhotosRow currentPhotosRow = GetCurrentPhotosRow();
                if (currentPhotosRow != null)
                {
                    activeDataSet.Features.AddValidFeaturesRow(GetCurrentPhotosRow());
                }
            }
        }
        private object GetCurrentFeaturesRow()
        {
            if (featuresBindingSource.Count > 0)
            {
                return (featuresBindingSource.Current as DataRowView).Row as FeaturesRow;
            }
            else
            {
                return null;
            }
        }
        #endregion
        #region Photo View Modes
        private void SwitchToNormalPhotoView()
        {
            // Update view check buttons
            normalSizeToolStripMenuItem.Checked = true;
            fitToWindowToolStripMenuItem.Checked = false;

            // Set picture box to auto-size to get scroll bars
            // (only left and top anchors should be on)
            photoPictureBox.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            photoPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

            // Repaint picture box to apply option
            photoPictureBox.Invalidate();
        }
        private void SwitchToFitToWindowPhotoView()
        {
            // Update view check buttons
            normalSizeToolStripMenuItem.Checked = false;
            fitToWindowToolStripMenuItem.Checked = true;

            // Set picture box to normal and resize to get rid of scroll bars
            // (turn on all anchors to automatically resize picture box)
            photoPictureBox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            photoPictureBox.SizeMode = PictureBoxSizeMode.Normal;
            photoPictureBox.Width = photoPanel.Width - 2;
            photoPictureBox.Height = photoPanel.Height - 2;

            // Re-paint picture box to apply option
            photoPictureBox.Invalidate();
        }
        #endregion
        #region Matching
        private void Match()
        {
            if (matchCandidateWithLibraryToolStripMenuItem.Checked)
            {
                MatchCandidateWithLibrary();
            }
            else if (matchCandidateWithAnimalToolStripMenuItem.Checked)
            {
                //MatchCandidateWithAnimal();
            }
        }
        private void MatchCandidateWithLibrary()
        {
            // Get the candidate features (and side)
            IDictionary<Image, int> candidateFeatures = GetAnimalFeaturesAndSide(GetCandidateAnimalsRow());

            comparisonsDataSet.Clear();
            comparisons.Clear();
                        
            foreach (AnimalsRow animalRow in libraryDataSet.Animals)
            {
                if (animalRow.RowState != DataRowState.Deleted)
                {
                    // Get the current animal features
                    IDictionary<Image, int> animalFeatures = GetAnimalFeaturesAndSide(animalRow);

                    // Compute score between features
                    double score = GetScore(candidateFeatures, animalFeatures);
                    //double score = matcher.GetScore(candidateFeatures, animalFeatures);

                    // Create a comparison object and add to binding source
                    //Comparison comparison = new Comparison(animalRow.AnimalId, animalRow.Name, score);
                    string id = "";
                    string name = "";
                    if (!animalRow.IsIdNull())
                    {
                        id = animalRow.Id;
                    }
                    if (!animalRow.IsNameNull())
                    {
                        name = animalRow.Name;
                    }
                    comparisonsDataSet.Comparisons.AddComparisonsRow(id, name, score);
                    comparisons.Add(animalRow.AnimalId, score);
                }
            }
        }
        private double GetScore(IDictionary<Image, int> images1, IDictionary<Image, int> images2)
        {
            double minScore = 1500;// double.PositiveInfinity;

            foreach (KeyValuePair<Image, int> image1 in images1)
            {
                foreach (KeyValuePair<Image, int> image2 in images2)
                {
                    // Compare sides (left or right)
                    if (image1.Value == image2.Value)
                    {
                        double score = matcher.GetScore(image1.Key, image2.Key);
                        if (score < minScore)
                        {
                            minScore = score;
                        }
                    }
                }
            }

            return minScore;
        }
        private int CountStepsInMatchingCandidateWithLibrary()
        {
            if (libraryDataSet == null)
            {
                return 0;
            }

            int steps = 0;

            // Get the candidate features and side
            IDictionary<Image, int> candidateFeatures = GetAnimalFeaturesAndSide(GetCandidateAnimalsRow());
            foreach (AnimalsRow animalRow in libraryDataSet.Animals)
            {
                if (animalRow.RowState != DataRowState.Deleted)
                {
                    // Get the current animal features and side
                    IDictionary<Image, int> animalFeatures = GetAnimalFeaturesAndSide(animalRow);

                    foreach (KeyValuePair<Image, int> image1 in candidateFeatures)
                    {
                        foreach (KeyValuePair<Image, int> image2 in animalFeatures)
                        {
                            if (image1.Value == image2.Value)
                            {
                                // Compute score between features
                                steps += matcher.CountSteps();
                                //MessageBox.Show(steps.ToString()); // Debug
                            }
                        }
                    }
                }
            }

            return steps;
        }
        private void RefreshScores()
        {
            // Clear results from scores data grid view
            scoresDataGridView.Rows.Clear();

            foreach (DataGridViewRow row in libraryDataGridView.Rows)
            {
                int id = Int32.Parse(row.Cells["animalsAnimalId"].Value.ToString());

                if (comparisons.ContainsKey(id))
                {
                    // Create and fill row
                    int scoresRowIndex = scoresDataGridView.Rows.Add();
                    DataGridViewRow scoresRow = scoresDataGridView.Rows[scoresRowIndex];
                    scoresRow.Cells[0].Value = row.Cells["animalsId"].Value;
                    scoresRow.Cells[1].Value = row.Cells["animalsName"].Value;
                    scoresRow.Cells[2].Value = comparisons[id];
                }
            }
        }
        //private void MatchCandidateWithAnimal()
        //{
        //    // Get the candidate features (and side)
        //    IDictionary<Image, int> candidateFeatures = GetAnimalFeaturesAndSide(GetCandidate());

        //    // Get the selected animal row
        //    AnimalsRow animalRow = GetCurrentResultsAnimalsRow();

        //    if (animalRow != null)
        //    {
        //        // Get the current animal features
        //        IDictionary<Image, int> animalFeatures = GetAnimalFeaturesAndSide(animalRow);

        //        // Compute score between features
        //        double score = matcher.GetScore(candidateFeatures, animalFeatures);

        //        // Create a comparison object and add to binding source
        //        Comparison comparison = new Comparison(animalRow.AnimalId, animalRow.Name, score);
        //        //comparisonsBindingSource.Add(comparison);
        //    }
        //}

        //private AnimalsRow GetCurrentResultsAnimalsRow()
        //{
        //    // Get current comparison
        //    Comparison comparison = GetCurrentComparison();

        //    if (comparison != null)
        //    {
        //        // Get animal row by id
        //        return libraryDataSet.Animals.FindByAnimalId(comparison.Id);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //private Comparison GetCurrentComparison()
        //{
        //    if (comparisonsBindingSource.Count > 0)
        //    {
        //        return comparisonsBindingSource.Current as Comparison;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        private IDictionary<Image, int> GetAnimalFeaturesAndSide(AnimalsRow animalRow)
        {
            IDictionary<Image, int> featuresAndSide = new Dictionary<Image, int>();

            if (animalRow == null)
            {
                return featuresAndSide;
            }

            foreach (PhotosRow photoRow in animalRow.GetPhotosRows())
            {
                // Note: There should only be one feature per photo
                foreach (FeaturesRow featureRow in photoRow.GetFeaturesRows())
                {
                    if (featureRow.IsFeatureNull() || photoRow.IsSideNull())
                    {
                        // Skip feature quietly
                    }
                    else
                    {
                        featuresAndSide.Add(ImageFromBytes(featureRow.Feature),
                            IntFromSide(photoRow.Side));
                    }
                }
            }

            return featuresAndSide;
        }
        private Image ImageFromBytes(byte[] bytes)
        {
            return TypeDescriptor.GetConverter(typeof(Image)).ConvertFrom(bytes) as Image;
        }
        private int IntFromSide(string side)
        {
            if (side == "Left")
            {
                return 0;
            }
            else if (side == "Right")
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        private AnimalsRow GetCandidateAnimalsRow()
        {
            if (candidateDataSet != null && candidateDataSet.Animals.Count > 0)
            {
                return candidateDataSet.Animals[0];
            }
            else
            {
                return null;
            }
        }
        #endregion
        #region Status
        private void StatusReady()
        {
            HideStatusBarItems();

            // Show "Ready" label
            statusBarLabel.Text = "Ready";
            statusBarLabel.Visible = true;
        }
        private void StatusProgress(int maximum)
        {
            HideStatusBarItems();

            // Show progress bar
            progressBar.Minimum = 0;
            progressBar.Maximum = maximum;
            progressBar.Value = 0;
            progressBar.Step = 1;
            progressBar.Visible = true;

            // Make time remaining label visible
            timeRemainingLabel.Visible = true;
        }
        private void HideStatusBarItems()
        {
            // Hide all status bar items
            foreach (ToolStripItem item in statusStrip1.Items)
            {
                item.Visible = false;
            }
        }
        #endregion
        private void EditOptions()
        {
            if (optionsDialog.ShowDialog() == DialogResult.OK)
            {
                InitMatcher();
            }
        }

        private void InitMatcher()
        {
            Cascader cascader = null;
            //RecursiveShifter shifter = null;
            Shifter shifter = null;

            matcher = new Chamfer();

            if (optionsSettings.UseCascader)
            {
                cascader = new Cascader(matcher);
                cascader.Threshold = optionsSettings.CascaderThreshold;
                cascader.QualityCount = optionsSettings.CascaderQualityLevelCount;
                cascader.SkipsPerQuality = optionsSettings.CascaderSkipsPerQualityLevel;
                matcher = cascader;
            }

            if (optionsSettings.UseShifter)
            {
                shifter = new Shifter(matcher);
                //shifter = new RecursiveShifter(matcher);
                shifter.Offset = optionsSettings.ShifterOffset;
                shifter.Step = optionsSettings.ShifterSteps;
                matcher = shifter;
            }

            matcher.Progress += new EventHandler(matcher_Progress);
        }
        #endregion

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            IDictionary<string, double> allComparisons = new Dictionary<string, double>();

            for(int i = 0; i < libraryDataSet.Animals.Count; i++)
            {
                AnimalsRow animalRow1 = libraryDataSet.Animals[i];
                IDictionary<Image, int> animal1Features = GetAnimalFeaturesAndSide(animalRow1);

                for (int j = i + 1; j < libraryDataSet.Animals.Count; j++)
                {
                    AnimalsRow animalRow2 = libraryDataSet.Animals[j];
                    IDictionary<Image, int> animal2Features = GetAnimalFeaturesAndSide(animalRow2);

                    // Compute score between features
                    double score = GetScore(animal1Features, animal2Features);

                    allComparisons.Add(animalRow1.Name + "\t" + animalRow2.Name, score);
                }
            }

            // Write results to a file
            using (StreamWriter writer = new StreamWriter("temp_output.txt"))
            {
                foreach (KeyValuePair<string, double> keyValuePair in allComparisons)
                {
                    writer.WriteLine(keyValuePair.Key + "\t" + keyValuePair.Value.ToString());
                }
            }
        }

        private void smoothingTrackBar_Scroll(object sender, EventArgs e)
        {
            featureExtractor.Smoothing = smoothingTrackBar.Value;
            ExtractManualFeature();
        }

        private void radiusTrackBar_Scroll(object sender, EventArgs e)
        {
            featureExtractor.Radius = radiusTrackBar.Value;
            ExtractManualFeature();
        }

        private void thresholdTrackBar_Scroll(object sender, EventArgs e)
        {
            featureExtractor.Threshold = thresholdTrackBar.Value;
            ExtractManualFeature();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLibrary();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLibrary();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveLibrary(library);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (libraryToolStripButton.Checked)
            {
                Clipboard.SetDataObject(libraryDataGridView.GetClipboardContent());
            }
            else if(candidateToolStripButton.Checked)
            {
                Clipboard.SetDataObject(scoresDataGridView.GetClipboardContent());
            }
        }

        private void matcherBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Match();
        }

        private void matcherBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.PerformStep();
            updateTimeLeft();
        }

        private void updateTimeLeft()
        {
            if (prevTime != DateTime.MinValue)
            {
                // A comparison was performed
                comparisonsDone++;

                // Compute amount of time last comparison took
                TimeSpan deltaSec = DateTime.Now - prevTime;

                // Update mean seconds a comparison takes
                meanDeltaSecComparison = (meanDeltaSecComparison * (comparisonsDone - 1) +
                    deltaSec.TotalSeconds) / comparisonsDone;

                // Update time left label
                int comparisonsLeft = progressBar.Maximum - comparisonsDone;
                int millisecondsLeft = (int)(meanDeltaSecComparison * comparisonsLeft * 1000);
                TimeSpan timeLeft = new TimeSpan(0, 0, 0, 0, millisecondsLeft);
                timeRemainingLabel.Text = "Time left: " + timeLeft.Hours + " h " + timeLeft.Minutes + " m " + timeLeft.Seconds + "s";

                // Update previous time
                prevTime = DateTime.Now;
            }
            else
            {
                prevTime = DateTime.Now;
            }
        }

        private void matcherBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Go to Ready status
            StatusReady();

            // No previous time for next matching attempt
            comparisonsDone = 0;
            meanDeltaSecComparison = 0;
            prevTime = DateTime.MinValue;

            comparisonsBindingSource.DataSource = comparisonsDataSet;
            comparisonsBindingSource.DataMember = "Comparisons";
            scoresDataGridView.Invalidate();
        }

        private int comparisonsDone = 0;         // Number of comparisons done to estimate time left
        private double meanDeltaSecComparison = 0;  // Number of seconds a comparison takes
        private DateTime prevTime = DateTime.MinValue;

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(sender, e);
        }
    }
}