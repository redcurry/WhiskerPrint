using WhiskerPrint.DataLayer;

namespace WhiskerPrint.PresentationLayer
{
    partial class FeaturePrintForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeaturePrintForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.libraryDataGridView = new System.Windows.Forms.DataGridView();
            this.animalsAnimalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalsScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new WhiskerPrint.DataLayer.AnimalsDataSet();
            this.libraryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.libraryBindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.libraryBindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.animalsPhotosSplit = new System.Windows.Forms.SplitContainer();
            this.animalsToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.scoresDataGridView = new System.Windows.Forms.DataGridView();
            this.scoresResultsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreResultsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreResultsScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comparisonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsTitlePanel = new System.Windows.Forms.Panel();
            this.libraryTitleLabel = new System.Windows.Forms.Label();
            this.photosPhotoSplit = new System.Windows.Forms.SplitContainer();
            this.photosFeatureSplit = new System.Windows.Forms.SplitContainer();
            this.photoTitlePanel = new System.Windows.Forms.Panel();
            this.photoTitleLabel = new System.Windows.Forms.Label();
            this.photoToolStrip = new System.Windows.Forms.ToolStrip();
            this.anchorsToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.anchor1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.anchor2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.anchor3ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showAnchorsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.photoViewModeToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.normalSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitToWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.featureToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.photoPanel = new System.Windows.Forms.Panel();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.photosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.thresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.radiusTrackBar = new System.Windows.Forms.TrackBar();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.smoothingLabel = new System.Windows.Forms.Label();
            this.smoothingTrackBar = new System.Windows.Forms.TrackBar();
            this.featurePanel = new System.Windows.Forms.Panel();
            this.featurePictureBox = new System.Windows.Forms.PictureBox();
            this.featuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.featureTitlePanel = new System.Windows.Forms.Panel();
            this.featureTitleLabel = new System.Windows.Forms.Label();
            this.photosTitlePanel = new System.Windows.Forms.Panel();
            this.photosTitleLabel = new System.Windows.Forms.Label();
            this.photosPanel = new System.Windows.Forms.Panel();
            this.photoNullPictureBox = new System.Windows.Forms.PictureBox();
            this.photosDataGridView = new System.Windows.Forms.DataGridView();
            this.photosPhotoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photosAnimalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photosPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.photosSide = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.photosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.photosBindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.photosBindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.openPhotoDialog = new System.Windows.Forms.OpenFileDialog();
            this.anchorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.timeRemainingLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.libraryToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.candidateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.matchToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.matchCandidateWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchCandidateWithLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchCandidateWithAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchCandidateWithPhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchPhotoWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchPhotoWithLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchPhotoWithAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchPhotoWithPhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openLibraryDialog = new System.Windows.Forms.OpenFileDialog();
            this.matcherBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.candidateDataSet = new WhiskerPrint.DataLayer.AnimalsDataSet();
            this.candidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingNavigator)).BeginInit();
            this.libraryBindingNavigator.SuspendLayout();
            this.animalsPhotosSplit.Panel1.SuspendLayout();
            this.animalsPhotosSplit.Panel2.SuspendLayout();
            this.animalsPhotosSplit.SuspendLayout();
            this.animalsToolStripContainer.ContentPanel.SuspendLayout();
            this.animalsToolStripContainer.TopToolStripPanel.SuspendLayout();
            this.animalsToolStripContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparisonsBindingSource)).BeginInit();
            this.animalsTitlePanel.SuspendLayout();
            this.photosPhotoSplit.Panel1.SuspendLayout();
            this.photosPhotoSplit.Panel2.SuspendLayout();
            this.photosPhotoSplit.SuspendLayout();
            this.photosFeatureSplit.Panel1.SuspendLayout();
            this.photosFeatureSplit.Panel2.SuspendLayout();
            this.photosFeatureSplit.SuspendLayout();
            this.photoTitlePanel.SuspendLayout();
            this.photoToolStrip.SuspendLayout();
            this.photoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoothingTrackBar)).BeginInit();
            this.featurePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.featurePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featuresBindingSource)).BeginInit();
            this.featureTitlePanel.SuspendLayout();
            this.photosTitlePanel.SuspendLayout();
            this.photosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoNullPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingNavigator)).BeginInit();
            this.photosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anchorsBindingSource)).BeginInit();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryDataGridView
            // 
            this.libraryDataGridView.AllowUserToAddRows = false;
            this.libraryDataGridView.AllowUserToDeleteRows = false;
            this.libraryDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.libraryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.libraryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.libraryDataGridView.AutoGenerateColumns = false;
            this.libraryDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.libraryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.libraryDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.libraryDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.libraryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.libraryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.libraryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animalsAnimalId,
            this.animalsId,
            this.animalsName,
            this.animalsScore});
            this.libraryDataGridView.DataSource = this.libraryBindingSource;
            this.libraryDataGridView.Location = new System.Drawing.Point(-1, 0);
            this.libraryDataGridView.Name = "libraryDataGridView";
            this.libraryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.libraryDataGridView.RowHeadersWidth = 32;
            this.libraryDataGridView.Size = new System.Drawing.Size(260, 470);
            this.libraryDataGridView.TabIndex = 0;
            // 
            // animalsAnimalId
            // 
            this.animalsAnimalId.DataPropertyName = "AnimalId";
            this.animalsAnimalId.HeaderText = "AnimalId";
            this.animalsAnimalId.Name = "animalsAnimalId";
            this.animalsAnimalId.Visible = false;
            // 
            // animalsId
            // 
            this.animalsId.DataPropertyName = "Id";
            this.animalsId.HeaderText = "Id";
            this.animalsId.Name = "animalsId";
            this.animalsId.Width = 60;
            // 
            // animalsName
            // 
            this.animalsName.DataPropertyName = "Name";
            this.animalsName.HeaderText = "Name";
            this.animalsName.Name = "animalsName";
            // 
            // animalsScore
            // 
            dataGridViewCellStyle2.Format = "N4";
            dataGridViewCellStyle2.NullValue = null;
            this.animalsScore.DefaultCellStyle = dataGridViewCellStyle2;
            this.animalsScore.HeaderText = "Score";
            this.animalsScore.Name = "animalsScore";
            this.animalsScore.Visible = false;
            // 
            // libraryBindingSource
            // 
            this.libraryBindingSource.DataMember = "Animals";
            this.libraryBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryBindingNavigator
            // 
            this.libraryBindingNavigator.AddNewItem = null;
            this.libraryBindingNavigator.BindingSource = this.libraryBindingSource;
            this.libraryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.libraryBindingNavigator.DeleteItem = null;
            this.libraryBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.libraryBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.libraryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.libraryBindingNavigatorAddNewItem,
            this.libraryBindingNavigatorDeleteItem});
            this.libraryBindingNavigator.Location = new System.Drawing.Point(3, 0);
            this.libraryBindingNavigator.MoveFirstItem = null;
            this.libraryBindingNavigator.MoveLastItem = null;
            this.libraryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.libraryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.libraryBindingNavigator.Name = "libraryBindingNavigator";
            this.libraryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.libraryBindingNavigator.Size = new System.Drawing.Size(171, 25);
            this.libraryBindingNavigator.TabIndex = 1;
            this.libraryBindingNavigator.RefreshItems += new System.EventHandler(this.libraryBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(32, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // libraryBindingNavigatorAddNewItem
            // 
            this.libraryBindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.libraryBindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("libraryBindingNavigatorAddNewItem.Image")));
            this.libraryBindingNavigatorAddNewItem.Name = "libraryBindingNavigatorAddNewItem";
            this.libraryBindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.libraryBindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.libraryBindingNavigatorAddNewItem.Text = "Add new";
            this.libraryBindingNavigatorAddNewItem.Click += new System.EventHandler(this.libraryBindingNavigatorAddNewItem_Click);
            // 
            // libraryBindingNavigatorDeleteItem
            // 
            this.libraryBindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.libraryBindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("libraryBindingNavigatorDeleteItem.Image")));
            this.libraryBindingNavigatorDeleteItem.Name = "libraryBindingNavigatorDeleteItem";
            this.libraryBindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.libraryBindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.libraryBindingNavigatorDeleteItem.Text = "Delete";
            this.libraryBindingNavigatorDeleteItem.Click += new System.EventHandler(this.libraryBindingNavigatorDeleteItem_Click);
            // 
            // animalsPhotosSplit
            // 
            this.animalsPhotosSplit.BackColor = System.Drawing.SystemColors.Control;
            this.animalsPhotosSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animalsPhotosSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animalsPhotosSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.animalsPhotosSplit.Location = new System.Drawing.Point(0, 0);
            this.animalsPhotosSplit.Name = "animalsPhotosSplit";
            // 
            // animalsPhotosSplit.Panel1
            // 
            this.animalsPhotosSplit.Panel1.Controls.Add(this.animalsToolStripContainer);
            this.animalsPhotosSplit.Panel1.Controls.Add(this.animalsTitlePanel);
            // 
            // animalsPhotosSplit.Panel2
            // 
            this.animalsPhotosSplit.Panel2.Controls.Add(this.photosPhotoSplit);
            this.animalsPhotosSplit.Size = new System.Drawing.Size(826, 517);
            this.animalsPhotosSplit.SplitterDistance = 258;
            this.animalsPhotosSplit.SplitterWidth = 5;
            this.animalsPhotosSplit.TabIndex = 4;
            this.animalsPhotosSplit.TabStop = false;
            this.animalsPhotosSplit.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.animalsPhotosSplit_SplitterMoved);
            // 
            // animalsToolStripContainer
            // 
            this.animalsToolStripContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // animalsToolStripContainer.ContentPanel
            // 
            this.animalsToolStripContainer.ContentPanel.Controls.Add(this.scoresDataGridView);
            this.animalsToolStripContainer.ContentPanel.Controls.Add(this.libraryDataGridView);
            this.animalsToolStripContainer.ContentPanel.Size = new System.Drawing.Size(257, 468);
            this.animalsToolStripContainer.Location = new System.Drawing.Point(0, 23);
            this.animalsToolStripContainer.Name = "animalsToolStripContainer";
            this.animalsToolStripContainer.Size = new System.Drawing.Size(257, 493);
            this.animalsToolStripContainer.TabIndex = 3;
            this.animalsToolStripContainer.Text = "toolStripContainer1";
            // 
            // animalsToolStripContainer.TopToolStripPanel
            // 
            this.animalsToolStripContainer.TopToolStripPanel.Controls.Add(this.libraryBindingNavigator);
            // 
            // scoresDataGridView
            // 
            this.scoresDataGridView.AllowUserToAddRows = false;
            this.scoresDataGridView.AllowUserToDeleteRows = false;
            this.scoresDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.scoresDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.scoresDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.scoresDataGridView.AutoGenerateColumns = false;
            this.scoresDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.scoresDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoresDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.scoresDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.scoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scoresResultsId,
            this.scoreResultsName,
            this.scoreResultsScore});
            this.scoresDataGridView.DataSource = this.comparisonsBindingSource;
            this.scoresDataGridView.Location = new System.Drawing.Point(-1, 0);
            this.scoresDataGridView.Name = "scoresDataGridView";
            this.scoresDataGridView.ReadOnly = true;
            this.scoresDataGridView.RowHeadersVisible = false;
            this.scoresDataGridView.Size = new System.Drawing.Size(260, 470);
            this.scoresDataGridView.TabIndex = 1;
            this.scoresDataGridView.Visible = false;
            // 
            // scoresResultsId
            // 
            this.scoresResultsId.DataPropertyName = "Id";
            this.scoresResultsId.HeaderText = "Id";
            this.scoresResultsId.Name = "scoresResultsId";
            this.scoresResultsId.ReadOnly = true;
            this.scoresResultsId.Width = 50;
            // 
            // scoreResultsName
            // 
            this.scoreResultsName.DataPropertyName = "Name";
            this.scoreResultsName.HeaderText = "Name";
            this.scoreResultsName.Name = "scoreResultsName";
            this.scoreResultsName.ReadOnly = true;
            // 
            // scoreResultsScore
            // 
            this.scoreResultsScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.scoreResultsScore.DataPropertyName = "Score";
            dataGridViewCellStyle4.Format = "N4";
            dataGridViewCellStyle4.NullValue = null;
            this.scoreResultsScore.DefaultCellStyle = dataGridViewCellStyle4;
            this.scoreResultsScore.HeaderText = "Score";
            this.scoreResultsScore.Name = "scoreResultsScore";
            this.scoreResultsScore.ReadOnly = true;
            // 
            // animalsTitlePanel
            // 
            this.animalsTitlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.animalsTitlePanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.animalsTitlePanel.Controls.Add(this.libraryTitleLabel);
            this.animalsTitlePanel.Location = new System.Drawing.Point(-1, -1);
            this.animalsTitlePanel.Name = "animalsTitlePanel";
            this.animalsTitlePanel.Size = new System.Drawing.Size(258, 24);
            this.animalsTitlePanel.TabIndex = 0;
            // 
            // libraryTitleLabel
            // 
            this.libraryTitleLabel.AutoSize = true;
            this.libraryTitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.libraryTitleLabel.Location = new System.Drawing.Point(4, 4);
            this.libraryTitleLabel.Name = "libraryTitleLabel";
            this.libraryTitleLabel.Size = new System.Drawing.Size(44, 15);
            this.libraryTitleLabel.TabIndex = 0;
            this.libraryTitleLabel.Text = "Library";
            // 
            // photosPhotoSplit
            // 
            this.photosPhotoSplit.BackColor = System.Drawing.SystemColors.Control;
            this.photosPhotoSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photosPhotoSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photosPhotoSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.photosPhotoSplit.Location = new System.Drawing.Point(0, 0);
            this.photosPhotoSplit.Name = "photosPhotoSplit";
            // 
            // photosPhotoSplit.Panel1
            // 
            this.photosPhotoSplit.Panel1.Controls.Add(this.photosFeatureSplit);
            // 
            // photosPhotoSplit.Panel2
            // 
            this.photosPhotoSplit.Panel2.Controls.Add(this.photosTitlePanel);
            this.photosPhotoSplit.Panel2.Controls.Add(this.photosPanel);
            this.photosPhotoSplit.Size = new System.Drawing.Size(563, 517);
            this.photosPhotoSplit.SplitterDistance = 268;
            this.photosPhotoSplit.SplitterWidth = 5;
            this.photosPhotoSplit.TabIndex = 0;
            this.photosPhotoSplit.TabStop = false;
            this.photosPhotoSplit.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.photosPhotoSplit_SplitterMoved);
            // 
            // photosFeatureSplit
            // 
            this.photosFeatureSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photosFeatureSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photosFeatureSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.photosFeatureSplit.Location = new System.Drawing.Point(0, 0);
            this.photosFeatureSplit.Name = "photosFeatureSplit";
            this.photosFeatureSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // photosFeatureSplit.Panel1
            // 
            this.photosFeatureSplit.Panel1.Controls.Add(this.photoTitlePanel);
            this.photosFeatureSplit.Panel1.Controls.Add(this.photoToolStrip);
            this.photosFeatureSplit.Panel1.Controls.Add(this.photoPanel);
            // 
            // photosFeatureSplit.Panel2
            // 
            this.photosFeatureSplit.Panel2.Controls.Add(this.panel1);
            this.photosFeatureSplit.Panel2.Controls.Add(this.featurePanel);
            this.photosFeatureSplit.Panel2.Controls.Add(this.featureTitlePanel);
            this.photosFeatureSplit.Size = new System.Drawing.Size(268, 517);
            this.photosFeatureSplit.SplitterDistance = 299;
            this.photosFeatureSplit.SplitterWidth = 5;
            this.photosFeatureSplit.TabIndex = 0;
            this.photosFeatureSplit.TabStop = false;
            this.photosFeatureSplit.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.photosFeatureSplit_SplitterMoved);
            // 
            // photoTitlePanel
            // 
            this.photoTitlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.photoTitlePanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.photoTitlePanel.Controls.Add(this.photoTitleLabel);
            this.photoTitlePanel.Location = new System.Drawing.Point(-1, -1);
            this.photoTitlePanel.Name = "photoTitlePanel";
            this.photoTitlePanel.Size = new System.Drawing.Size(269, 24);
            this.photoTitlePanel.TabIndex = 0;
            // 
            // photoTitleLabel
            // 
            this.photoTitleLabel.AutoSize = true;
            this.photoTitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.photoTitleLabel.Location = new System.Drawing.Point(4, 4);
            this.photoTitleLabel.Name = "photoTitleLabel";
            this.photoTitleLabel.Size = new System.Drawing.Size(122, 15);
            this.photoTitleLabel.TabIndex = 0;
            this.photoTitleLabel.Text = "Selected Photograph";
            // 
            // photoToolStrip
            // 
            this.photoToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.photoToolStrip.AutoSize = false;
            this.photoToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.photoToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.photoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anchorsToolStripLabel,
            this.anchor1ToolStripButton,
            this.anchor2ToolStripButton,
            this.anchor3ToolStripButton,
            this.toolStripSeparator1,
            this.showAnchorsToolStripButton,
            this.photoViewModeToolStripDropDownButton,
            this.toolStripSeparator2,
            this.featureToolStripButton});
            this.photoToolStrip.Location = new System.Drawing.Point(0, 23);
            this.photoToolStrip.Name = "photoToolStrip";
            this.photoToolStrip.Size = new System.Drawing.Size(267, 25);
            this.photoToolStrip.TabIndex = 1;
            // 
            // anchorsToolStripLabel
            // 
            this.anchorsToolStripLabel.Name = "anchorsToolStripLabel";
            this.anchorsToolStripLabel.Size = new System.Drawing.Size(50, 22);
            this.anchorsToolStripLabel.Text = "Anchors:";
            // 
            // anchor1ToolStripButton
            // 
            this.anchor1ToolStripButton.CheckOnClick = true;
            this.anchor1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.anchor1ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("anchor1ToolStripButton.Image")));
            this.anchor1ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.anchor1ToolStripButton.Name = "anchor1ToolStripButton";
            this.anchor1ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.anchor1ToolStripButton.Text = "1";
            this.anchor1ToolStripButton.ToolTipText = "Select anchor 1";
            this.anchor1ToolStripButton.CheckedChanged += new System.EventHandler(this.anchor1ToolStripButton_CheckedChanged);
            // 
            // anchor2ToolStripButton
            // 
            this.anchor2ToolStripButton.CheckOnClick = true;
            this.anchor2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.anchor2ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("anchor2ToolStripButton.Image")));
            this.anchor2ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.anchor2ToolStripButton.Name = "anchor2ToolStripButton";
            this.anchor2ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.anchor2ToolStripButton.Text = "2";
            this.anchor2ToolStripButton.ToolTipText = "Select anchor 2";
            this.anchor2ToolStripButton.CheckedChanged += new System.EventHandler(this.anchor2ToolStripButton_CheckedChanged);
            // 
            // anchor3ToolStripButton
            // 
            this.anchor3ToolStripButton.CheckOnClick = true;
            this.anchor3ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.anchor3ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("anchor3ToolStripButton.Image")));
            this.anchor3ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.anchor3ToolStripButton.Name = "anchor3ToolStripButton";
            this.anchor3ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.anchor3ToolStripButton.Text = "3";
            this.anchor3ToolStripButton.ToolTipText = "Select anchor 3";
            this.anchor3ToolStripButton.CheckedChanged += new System.EventHandler(this.anchor3ToolStripButton_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // showAnchorsToolStripButton
            // 
            this.showAnchorsToolStripButton.Checked = true;
            this.showAnchorsToolStripButton.CheckOnClick = true;
            this.showAnchorsToolStripButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAnchorsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showAnchorsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("showAnchorsToolStripButton.Image")));
            this.showAnchorsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showAnchorsToolStripButton.Name = "showAnchorsToolStripButton";
            this.showAnchorsToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.showAnchorsToolStripButton.Text = "Show Anchors";
            this.showAnchorsToolStripButton.ToolTipText = "Show anchors";
            this.showAnchorsToolStripButton.CheckedChanged += new System.EventHandler(this.showAnchorsToolStripButton_CheckedChanged);
            // 
            // photoViewModeToolStripDropDownButton
            // 
            this.photoViewModeToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.photoViewModeToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalSizeToolStripMenuItem,
            this.fitToWindowToolStripMenuItem});
            this.photoViewModeToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("photoViewModeToolStripDropDownButton.Image")));
            this.photoViewModeToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.photoViewModeToolStripDropDownButton.Name = "photoViewModeToolStripDropDownButton";
            this.photoViewModeToolStripDropDownButton.Size = new System.Drawing.Size(42, 22);
            this.photoViewModeToolStripDropDownButton.Text = "View";
            this.photoViewModeToolStripDropDownButton.ToolTipText = "Change the viewing mode";
            // 
            // normalSizeToolStripMenuItem
            // 
            this.normalSizeToolStripMenuItem.Checked = true;
            this.normalSizeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normalSizeToolStripMenuItem.Name = "normalSizeToolStripMenuItem";
            this.normalSizeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.normalSizeToolStripMenuItem.Text = "Normal size";
            this.normalSizeToolStripMenuItem.Click += new System.EventHandler(this.normalSizeToolStripMenuItem_Click);
            // 
            // fitToWindowToolStripMenuItem
            // 
            this.fitToWindowToolStripMenuItem.Name = "fitToWindowToolStripMenuItem";
            this.fitToWindowToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.fitToWindowToolStripMenuItem.Text = "Fit to window";
            this.fitToWindowToolStripMenuItem.Click += new System.EventHandler(this.fitToWindowToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // featureToolStripButton
            // 
            this.featureToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.featureToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("featureToolStripButton.Image")));
            this.featureToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.featureToolStripButton.Name = "featureToolStripButton";
            this.featureToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.featureToolStripButton.Text = "Extract Feature";
            this.featureToolStripButton.ToolTipText = "Extract feature from photograph";
            this.featureToolStripButton.Click += new System.EventHandler(this.featureToolStripButton_Click);
            // 
            // photoPanel
            // 
            this.photoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.photoPanel.AutoScroll = true;
            this.photoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoPanel.Controls.Add(this.photoPictureBox);
            this.photoPanel.Location = new System.Drawing.Point(-1, 48);
            this.photoPanel.Name = "photoPanel";
            this.photoPanel.Size = new System.Drawing.Size(268, 250);
            this.photoPanel.TabIndex = 2;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photosBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.photoPictureBox.TabIndex = 1;
            this.photoPictureBox.TabStop = false;
            this.photoPictureBox.Click += new System.EventHandler(this.photoPictureBox_Click);
            this.photoPictureBox.Resize += new System.EventHandler(this.photoPictureBox_Resize);
            this.photoPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.photoPictureBox_Paint);
            // 
            // photosBindingSource
            // 
            this.photosBindingSource.AllowNew = true;
            this.photosBindingSource.DataMember = "PhotosAnimalsRelation";
            this.photosBindingSource.DataSource = this.libraryBindingSource;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.thresholdLabel);
            this.panel1.Controls.Add(this.thresholdTrackBar);
            this.panel1.Controls.Add(this.radiusTrackBar);
            this.panel1.Controls.Add(this.radiusLabel);
            this.panel1.Controls.Add(this.smoothingLabel);
            this.panel1.Controls.Add(this.smoothingTrackBar);
            this.panel1.Location = new System.Drawing.Point(158, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 189);
            this.panel1.TabIndex = 2;
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Location = new System.Drawing.Point(3, 103);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(65, 15);
            this.thresholdLabel.TabIndex = 5;
            this.thresholdLabel.Text = "Threshold:";
            // 
            // thresholdTrackBar
            // 
            this.thresholdTrackBar.Location = new System.Drawing.Point(3, 120);
            this.thresholdTrackBar.Maximum = 100;
            this.thresholdTrackBar.Name = "thresholdTrackBar";
            this.thresholdTrackBar.Size = new System.Drawing.Size(102, 45);
            this.thresholdTrackBar.TabIndex = 4;
            this.thresholdTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.thresholdTrackBar.Scroll += new System.EventHandler(this.thresholdTrackBar_Scroll);
            // 
            // radiusTrackBar
            // 
            this.radiusTrackBar.Location = new System.Drawing.Point(3, 72);
            this.radiusTrackBar.Name = "radiusTrackBar";
            this.radiusTrackBar.Size = new System.Drawing.Size(102, 45);
            this.radiusTrackBar.TabIndex = 3;
            this.radiusTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.radiusTrackBar.Scroll += new System.EventHandler(this.radiusTrackBar_Scroll);
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(3, 55);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(49, 15);
            this.radiusLabel.TabIndex = 2;
            this.radiusLabel.Text = "Radius:";
            // 
            // smoothingLabel
            // 
            this.smoothingLabel.AutoSize = true;
            this.smoothingLabel.Location = new System.Drawing.Point(3, 3);
            this.smoothingLabel.Name = "smoothingLabel";
            this.smoothingLabel.Size = new System.Drawing.Size(70, 15);
            this.smoothingLabel.TabIndex = 1;
            this.smoothingLabel.Text = "Smoothing:";
            // 
            // smoothingTrackBar
            // 
            this.smoothingTrackBar.Location = new System.Drawing.Point(3, 21);
            this.smoothingTrackBar.Maximum = 5;
            this.smoothingTrackBar.Name = "smoothingTrackBar";
            this.smoothingTrackBar.Size = new System.Drawing.Size(102, 45);
            this.smoothingTrackBar.TabIndex = 0;
            this.smoothingTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.smoothingTrackBar.Scroll += new System.EventHandler(this.smoothingTrackBar_Scroll);
            // 
            // featurePanel
            // 
            this.featurePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.featurePanel.AutoScroll = true;
            this.featurePanel.Controls.Add(this.featurePictureBox);
            this.featurePanel.Location = new System.Drawing.Point(-1, 23);
            this.featurePanel.Name = "featurePanel";
            this.featurePanel.Size = new System.Drawing.Size(156, 189);
            this.featurePanel.TabIndex = 1;
            // 
            // featurePictureBox
            // 
            this.featurePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.featuresBindingSource, "Feature", true));
            this.featurePictureBox.Location = new System.Drawing.Point(0, 0);
            this.featurePictureBox.Name = "featurePictureBox";
            this.featurePictureBox.Size = new System.Drawing.Size(100, 100);
            this.featurePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.featurePictureBox.TabIndex = 0;
            this.featurePictureBox.TabStop = false;
            // 
            // featuresBindingSource
            // 
            this.featuresBindingSource.AllowNew = true;
            this.featuresBindingSource.DataMember = "FeaturesPhotosRelation";
            this.featuresBindingSource.DataSource = this.photosBindingSource;
            // 
            // featureTitlePanel
            // 
            this.featureTitlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.featureTitlePanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.featureTitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.featureTitlePanel.Controls.Add(this.featureTitleLabel);
            this.featureTitlePanel.Location = new System.Drawing.Point(-1, -1);
            this.featureTitlePanel.Name = "featureTitlePanel";
            this.featureTitlePanel.Size = new System.Drawing.Size(268, 24);
            this.featureTitlePanel.TabIndex = 0;
            // 
            // featureTitleLabel
            // 
            this.featureTitleLabel.AutoSize = true;
            this.featureTitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.featureTitleLabel.Location = new System.Drawing.Point(3, 3);
            this.featureTitleLabel.Name = "featureTitleLabel";
            this.featureTitleLabel.Size = new System.Drawing.Size(180, 15);
            this.featureTitleLabel.TabIndex = 0;
            this.featureTitleLabel.Text = "Feature of Selected Photograph";
            // 
            // photosTitlePanel
            // 
            this.photosTitlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.photosTitlePanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.photosTitlePanel.Controls.Add(this.photosTitleLabel);
            this.photosTitlePanel.Location = new System.Drawing.Point(-1, -1);
            this.photosTitlePanel.Name = "photosTitlePanel";
            this.photosTitlePanel.Size = new System.Drawing.Size(290, 24);
            this.photosTitlePanel.TabIndex = 0;
            // 
            // photosTitleLabel
            // 
            this.photosTitleLabel.AutoSize = true;
            this.photosTitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.photosTitleLabel.Location = new System.Drawing.Point(4, 4);
            this.photosTitleLabel.Name = "photosTitleLabel";
            this.photosTitleLabel.Size = new System.Drawing.Size(77, 15);
            this.photosTitleLabel.TabIndex = 0;
            this.photosTitleLabel.Text = "Photographs";
            // 
            // photosPanel
            // 
            this.photosPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.photosPanel.Controls.Add(this.photoNullPictureBox);
            this.photosPanel.Controls.Add(this.photosDataGridView);
            this.photosPanel.Controls.Add(this.photosBindingNavigator);
            this.photosPanel.Location = new System.Drawing.Point(-1, 23);
            this.photosPanel.Name = "photosPanel";
            this.photosPanel.Size = new System.Drawing.Size(290, 493);
            this.photosPanel.TabIndex = 3;
            // 
            // photoNullPictureBox
            // 
            this.photoNullPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("photoNullPictureBox.Image")));
            this.photoNullPictureBox.Location = new System.Drawing.Point(51, 62);
            this.photoNullPictureBox.Name = "photoNullPictureBox";
            this.photoNullPictureBox.Size = new System.Drawing.Size(110, 90);
            this.photoNullPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.photoNullPictureBox.TabIndex = 6;
            this.photoNullPictureBox.TabStop = false;
            this.photoNullPictureBox.Visible = false;
            // 
            // photosDataGridView
            // 
            this.photosDataGridView.AllowUserToAddRows = false;
            this.photosDataGridView.AllowUserToDeleteRows = false;
            this.photosDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            this.photosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.photosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.photosDataGridView.AutoGenerateColumns = false;
            this.photosDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.photosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.photosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.photosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.photosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.photosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.photosPhotoId,
            this.photosAnimalId,
            this.photosPhoto,
            this.photosSide});
            this.photosDataGridView.DataSource = this.photosBindingSource;
            this.photosDataGridView.Location = new System.Drawing.Point(0, 25);
            this.photosDataGridView.Name = "photosDataGridView";
            this.photosDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.photosDataGridView.RowHeadersWidth = 32;
            this.photosDataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.photosDataGridView.RowTemplate.Height = 100;
            this.photosDataGridView.Size = new System.Drawing.Size(290, 468);
            this.photosDataGridView.TabIndex = 0;
            this.photosDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.photosDataGridView_CellDoubleClick);
            // 
            // photosPhotoId
            // 
            this.photosPhotoId.DataPropertyName = "PhotoId";
            this.photosPhotoId.HeaderText = "PhotoId";
            this.photosPhotoId.Name = "photosPhotoId";
            this.photosPhotoId.Visible = false;
            // 
            // photosAnimalId
            // 
            this.photosAnimalId.DataPropertyName = "AnimalId";
            this.photosAnimalId.HeaderText = "AnimalId";
            this.photosAnimalId.Name = "photosAnimalId";
            this.photosAnimalId.Visible = false;
            // 
            // photosPhoto
            // 
            this.photosPhoto.DataPropertyName = "Photo";
            this.photosPhoto.HeaderText = "Photo";
            this.photosPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.photosPhoto.Name = "photosPhoto";
            this.photosPhoto.Width = 150;
            // 
            // photosSide
            // 
            this.photosSide.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.photosSide.DataPropertyName = "Side";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.photosSide.DefaultCellStyle = dataGridViewCellStyle6;
            this.photosSide.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.photosSide.DisplayStyleForCurrentCellOnly = true;
            this.photosSide.HeaderText = "Side";
            this.photosSide.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.photosSide.Name = "photosSide";
            this.photosSide.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.photosSide.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // photosBindingNavigator
            // 
            this.photosBindingNavigator.AddNewItem = null;
            this.photosBindingNavigator.AutoSize = false;
            this.photosBindingNavigator.BindingSource = this.photosBindingSource;
            this.photosBindingNavigator.CountItem = this.bindingNavigatorCountItem1;
            this.photosBindingNavigator.DeleteItem = null;
            this.photosBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.photosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorSeparator5,
            this.photosBindingNavigatorAddNewItem,
            this.photosBindingNavigatorDeleteItem});
            this.photosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.photosBindingNavigator.MoveFirstItem = null;
            this.photosBindingNavigator.MoveLastItem = null;
            this.photosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.photosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.photosBindingNavigator.Name = "photosBindingNavigator";
            this.photosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem1;
            this.photosBindingNavigator.Size = new System.Drawing.Size(290, 25);
            this.photosBindingNavigator.TabIndex = 1;
            this.photosBindingNavigator.RefreshItems += new System.EventHandler(this.photosBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(32, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // photosBindingNavigatorAddNewItem
            // 
            this.photosBindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.photosBindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("photosBindingNavigatorAddNewItem.Image")));
            this.photosBindingNavigatorAddNewItem.Name = "photosBindingNavigatorAddNewItem";
            this.photosBindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.photosBindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.photosBindingNavigatorAddNewItem.Text = "Add new";
            this.photosBindingNavigatorAddNewItem.Click += new System.EventHandler(this.photosBindingNavigatorAddNewItem_Click);
            // 
            // photosBindingNavigatorDeleteItem
            // 
            this.photosBindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.photosBindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("photosBindingNavigatorDeleteItem.Image")));
            this.photosBindingNavigatorDeleteItem.Name = "photosBindingNavigatorDeleteItem";
            this.photosBindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.photosBindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.photosBindingNavigatorDeleteItem.Text = "Delete";
            this.photosBindingNavigatorDeleteItem.Click += new System.EventHandler(this.photosBindingNavigatorDeleteItem_Click);
            // 
            // openPhotoDialog
            // 
            this.openPhotoDialog.Filter = "Photographs (*.jpg)|*.jpg|All files (*.*)|*.*";
            // 
            // anchorsBindingSource
            // 
            this.anchorsBindingSource.AllowNew = true;
            this.anchorsBindingSource.DataMember = "AnchorsPhotosRelation";
            this.anchorsBindingSource.DataSource = this.photosBindingSource;
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.animalsPhotosSplit);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(826, 517);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(826, 588);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel,
            this.progressBar,
            this.timeRemainingLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(826, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(38, 17);
            this.statusBarLabel.Text = "Ready";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 16);
            this.progressBar.Step = 1;
            this.progressBar.Visible = false;
            // 
            // timeRemainingLabel
            // 
            this.timeRemainingLabel.Name = "timeRemainingLabel";
            this.timeRemainingLabel.Size = new System.Drawing.Size(0, 17);
            this.timeRemainingLabel.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator6,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator7,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator8,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.newToolStripMenuItem.Text = "&New Library";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.openToolStripMenuItem.Text = "&Open Library...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(196, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.saveToolStripMenuItem.Text = "&Save Library";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.saveAsToolStripMenuItem.Text = "Save Library &As...";
            this.saveAsToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(196, 6);
            this.toolStripSeparator7.Visible = false;
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Visible = false;
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            this.printPreviewToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(196, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator9,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator10,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Visible = false;
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(147, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(147, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.optionsToolStripMenuItem.Text = "&Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator11,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Visible = false;
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(126, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator3,
            this.libraryToolStripButton,
            this.candidateToolStripButton,
            this.toolStripSeparator4,
            this.matchToolStripSplitButton,
            this.toolStripSeparator5,
            this.helpToolStripButton,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(547, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.newToolStripButton.Text = "&New Library";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(89, 22);
            this.openToolStripButton.Text = "&Open Library";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(87, 22);
            this.saveToolStripButton.Text = "&Save Library";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // libraryToolStripButton
            // 
            this.libraryToolStripButton.Checked = true;
            this.libraryToolStripButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.libraryToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("libraryToolStripButton.Image")));
            this.libraryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.libraryToolStripButton.Name = "libraryToolStripButton";
            this.libraryToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.libraryToolStripButton.Text = "Library";
            this.libraryToolStripButton.ToolTipText = "Show Library";
            this.libraryToolStripButton.Click += new System.EventHandler(this.libraryToolStripButton_Click);
            // 
            // candidateToolStripButton
            // 
            this.candidateToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("candidateToolStripButton.Image")));
            this.candidateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.candidateToolStripButton.Name = "candidateToolStripButton";
            this.candidateToolStripButton.Size = new System.Drawing.Size(76, 22);
            this.candidateToolStripButton.Text = "Candidate";
            this.candidateToolStripButton.ToolTipText = "Show Candidate";
            this.candidateToolStripButton.Click += new System.EventHandler(this.candidateToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // matchToolStripSplitButton
            // 
            this.matchToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.matchToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matchCandidateWithToolStripMenuItem,
            this.matchPhotoWithToolStripMenuItem});
            this.matchToolStripSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("matchToolStripSplitButton.Image")));
            this.matchToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matchToolStripSplitButton.Name = "matchToolStripSplitButton";
            this.matchToolStripSplitButton.Size = new System.Drawing.Size(32, 22);
            this.matchToolStripSplitButton.Text = "toolStripSplitButton1";
            this.matchToolStripSplitButton.ToolTipText = "Match candidate against reference library";
            this.matchToolStripSplitButton.ButtonClick += new System.EventHandler(this.matchToolStripSplitButton_ButtonClick);
            // 
            // matchCandidateWithToolStripMenuItem
            // 
            this.matchCandidateWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matchCandidateWithLibraryToolStripMenuItem,
            this.matchCandidateWithAnimalToolStripMenuItem,
            this.matchCandidateWithPhotoToolStripMenuItem});
            this.matchCandidateWithToolStripMenuItem.Name = "matchCandidateWithToolStripMenuItem";
            this.matchCandidateWithToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.matchCandidateWithToolStripMenuItem.Text = "Match Candidate With";
            // 
            // matchCandidateWithLibraryToolStripMenuItem
            // 
            this.matchCandidateWithLibraryToolStripMenuItem.Checked = true;
            this.matchCandidateWithLibraryToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.matchCandidateWithLibraryToolStripMenuItem.Name = "matchCandidateWithLibraryToolStripMenuItem";
            this.matchCandidateWithLibraryToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.matchCandidateWithLibraryToolStripMenuItem.Text = "Library";
            this.matchCandidateWithLibraryToolStripMenuItem.Click += new System.EventHandler(this.matchCandidateWithLibraryToolStripMenuItem_Click);
            // 
            // matchCandidateWithAnimalToolStripMenuItem
            // 
            this.matchCandidateWithAnimalToolStripMenuItem.Name = "matchCandidateWithAnimalToolStripMenuItem";
            this.matchCandidateWithAnimalToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.matchCandidateWithAnimalToolStripMenuItem.Text = "Selected Animal";
            this.matchCandidateWithAnimalToolStripMenuItem.Visible = false;
            this.matchCandidateWithAnimalToolStripMenuItem.Click += new System.EventHandler(this.matchCandidateWithAnimalToolStripMenuItem_Click);
            // 
            // matchCandidateWithPhotoToolStripMenuItem
            // 
            this.matchCandidateWithPhotoToolStripMenuItem.Name = "matchCandidateWithPhotoToolStripMenuItem";
            this.matchCandidateWithPhotoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.matchCandidateWithPhotoToolStripMenuItem.Text = "Selected Photo of Animal";
            this.matchCandidateWithPhotoToolStripMenuItem.Visible = false;
            this.matchCandidateWithPhotoToolStripMenuItem.Click += new System.EventHandler(this.matchCandidateWithPhotoToolStripMenuItem_Click);
            // 
            // matchPhotoWithToolStripMenuItem
            // 
            this.matchPhotoWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matchPhotoWithLibraryToolStripMenuItem,
            this.matchPhotoWithAnimalToolStripMenuItem,
            this.matchPhotoWithPhotoToolStripMenuItem});
            this.matchPhotoWithToolStripMenuItem.Name = "matchPhotoWithToolStripMenuItem";
            this.matchPhotoWithToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.matchPhotoWithToolStripMenuItem.Text = "Match Selected Photo of Candidate With";
            this.matchPhotoWithToolStripMenuItem.Visible = false;
            // 
            // matchPhotoWithLibraryToolStripMenuItem
            // 
            this.matchPhotoWithLibraryToolStripMenuItem.Name = "matchPhotoWithLibraryToolStripMenuItem";
            this.matchPhotoWithLibraryToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.matchPhotoWithLibraryToolStripMenuItem.Text = "Library";
            this.matchPhotoWithLibraryToolStripMenuItem.Click += new System.EventHandler(this.matchPhotoWithLibraryToolStripMenuItem_Click);
            // 
            // matchPhotoWithAnimalToolStripMenuItem
            // 
            this.matchPhotoWithAnimalToolStripMenuItem.Name = "matchPhotoWithAnimalToolStripMenuItem";
            this.matchPhotoWithAnimalToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.matchPhotoWithAnimalToolStripMenuItem.Text = "Selected Animal";
            this.matchPhotoWithAnimalToolStripMenuItem.Click += new System.EventHandler(this.matchPhotoWithAnimalToolStripMenuItem_Click);
            // 
            // matchPhotoWithPhotoToolStripMenuItem
            // 
            this.matchPhotoWithPhotoToolStripMenuItem.Name = "matchPhotoWithPhotoToolStripMenuItem";
            this.matchPhotoWithPhotoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.matchPhotoWithPhotoToolStripMenuItem.Text = "Selected Photo of Animal";
            this.matchPhotoWithPhotoToolStripMenuItem.Click += new System.EventHandler(this.matchPhotoWithPhotoToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Visible = false;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "mdb";
            this.saveFileDialog.Filter = "MS Access (*.mdb)|*.mdb";
            // 
            // openLibraryDialog
            // 
            this.openLibraryDialog.DefaultExt = "mdb";
            this.openLibraryDialog.Filter = "MS Access (*.mdb)|*.mdb";
            // 
            // matcherBackgroundWorker
            // 
            this.matcherBackgroundWorker.WorkerReportsProgress = true;
            this.matcherBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.matcherBackgroundWorker_DoWork);
            this.matcherBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.matcherBackgroundWorker_RunWorkerCompleted);
            this.matcherBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.matcherBackgroundWorker_ProgressChanged);
            // 
            // candidateDataSet
            // 
            this.candidateDataSet.DataSetName = "CandidateDataSet";
            this.candidateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidateBindingSource
            // 
            this.candidateBindingSource.DataMember = "Animals";
            this.candidateBindingSource.DataSource = this.candidateDataSet;
            // 
            // FeaturePrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 588);
            this.Controls.Add(this.toolStripContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FeaturePrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeaturePrint";
            this.Load += new System.EventHandler(this.FeaturePrintForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FeaturePrintForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingNavigator)).EndInit();
            this.libraryBindingNavigator.ResumeLayout(false);
            this.libraryBindingNavigator.PerformLayout();
            this.animalsPhotosSplit.Panel1.ResumeLayout(false);
            this.animalsPhotosSplit.Panel2.ResumeLayout(false);
            this.animalsPhotosSplit.ResumeLayout(false);
            this.animalsToolStripContainer.ContentPanel.ResumeLayout(false);
            this.animalsToolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.animalsToolStripContainer.TopToolStripPanel.PerformLayout();
            this.animalsToolStripContainer.ResumeLayout(false);
            this.animalsToolStripContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparisonsBindingSource)).EndInit();
            this.animalsTitlePanel.ResumeLayout(false);
            this.animalsTitlePanel.PerformLayout();
            this.photosPhotoSplit.Panel1.ResumeLayout(false);
            this.photosPhotoSplit.Panel2.ResumeLayout(false);
            this.photosPhotoSplit.ResumeLayout(false);
            this.photosFeatureSplit.Panel1.ResumeLayout(false);
            this.photosFeatureSplit.Panel2.ResumeLayout(false);
            this.photosFeatureSplit.ResumeLayout(false);
            this.photoTitlePanel.ResumeLayout(false);
            this.photoTitlePanel.PerformLayout();
            this.photoToolStrip.ResumeLayout(false);
            this.photoToolStrip.PerformLayout();
            this.photoPanel.ResumeLayout(false);
            this.photoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoothingTrackBar)).EndInit();
            this.featurePanel.ResumeLayout(false);
            this.featurePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.featurePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.featuresBindingSource)).EndInit();
            this.featureTitlePanel.ResumeLayout(false);
            this.featureTitlePanel.PerformLayout();
            this.photosTitlePanel.ResumeLayout(false);
            this.photosTitlePanel.PerformLayout();
            this.photosPanel.ResumeLayout(false);
            this.photosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoNullPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingNavigator)).EndInit();
            this.photosBindingNavigator.ResumeLayout(false);
            this.photosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anchorsBindingSource)).EndInit();
            this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView libraryDataGridView;
        private System.Windows.Forms.BindingNavigator libraryBindingNavigator;
        private System.Windows.Forms.ToolStripButton libraryBindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.SplitContainer animalsPhotosSplit;
        private System.Windows.Forms.Panel animalsTitlePanel;
        private System.Windows.Forms.Label libraryTitleLabel;
        private System.Windows.Forms.SplitContainer photosPhotoSplit;
        private System.Windows.Forms.SplitContainer photosFeatureSplit;
        private System.Windows.Forms.Panel photosTitlePanel;
        private System.Windows.Forms.Label photosTitleLabel;
        private System.Windows.Forms.BindingSource photosBindingSource;
        private System.Windows.Forms.Panel photosPanel;
        private System.Windows.Forms.BindingNavigator photosBindingNavigator;
        private System.Windows.Forms.ToolStripButton photosBindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton photosBindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.Panel featureTitlePanel;
        private System.Windows.Forms.Label featureTitleLabel;
        private System.Windows.Forms.Panel photoTitlePanel;
        private System.Windows.Forms.Label photoTitleLabel;
        private System.Windows.Forms.Panel photoPanel;
        private System.Windows.Forms.OpenFileDialog openPhotoDialog;
        private System.Windows.Forms.ToolStrip photoToolStrip;
        private System.Windows.Forms.ToolStripButton anchor1ToolStripButton;
        private System.Windows.Forms.ToolStripButton anchor2ToolStripButton;
        private System.Windows.Forms.ToolStripButton anchor3ToolStripButton;
        private System.Windows.Forms.ToolStripLabel anchorsToolStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton featureToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton showAnchorsToolStripButton;
        private System.Windows.Forms.PictureBox photoNullPictureBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.BindingSource anchorsBindingSource;
        private System.Windows.Forms.ToolStripDropDownButton photoViewModeToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem normalSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitToWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripContainer animalsToolStripContainer;
        private System.Windows.Forms.OpenFileDialog openLibraryDialog;
        private System.Windows.Forms.DataGridView photosDataGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.Panel featurePanel;
        private System.Windows.Forms.PictureBox featurePictureBox;
        private System.Windows.Forms.BindingSource featuresBindingSource;
        private AnimalsDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private AnimalsDataSet candidateDataSet;
        private System.Windows.Forms.ToolStripButton libraryBindingNavigatorDeleteItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn photosPhotoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn photosAnimalId;
        private System.Windows.Forms.DataGridViewImageColumn photosPhoto;
        private System.Windows.Forms.DataGridViewComboBoxColumn photosSide;
        private System.Windows.Forms.BindingSource candidateBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton libraryToolStripButton;
        private System.Windows.Forms.ToolStripButton candidateToolStripButton;
        private System.Windows.Forms.ToolStripSplitButton matchToolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem matchCandidateWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchCandidateWithLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchCandidateWithAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchCandidateWithPhotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchPhotoWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchPhotoWithLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchPhotoWithAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchPhotoWithPhotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar smoothingTrackBar;
        private System.Windows.Forms.Label smoothingLabel;
        private System.Windows.Forms.TrackBar radiusTrackBar;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.TrackBar thresholdTrackBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker matcherBackgroundWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalsAnimalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalsScore;
        private System.Windows.Forms.DataGridView scoresDataGridView;
        private System.Windows.Forms.BindingSource comparisonsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoresResultsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreResultsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreResultsScore;
        private System.Windows.Forms.ToolStripStatusLabel timeRemainingLabel;
    }
}