using System;
using System.Data;
using System.IO;
using AnimalsTable = WhiskerPrint.DataLayer.AnimalsDataSet.AnimalsDataTable;
using PhotosTable = WhiskerPrint.DataLayer.AnimalsDataSet.PhotosDataTable;

namespace WhiskerPrint.DataLayer
{
    public class Library
    {
        public Library()
        {
            // Create a new data set
            animalsDataSet = new AnimalsDataSet();
        }

        public static Library FromFile(string path)
        {
            // Create a new data set
            Library library = new Library();

            // Initialize table adapters
            library.InitTableAdapters(path);

            // Library is not new (it comes from an existing file)
            library.isNew = false;

            // Load data into data set
            library.Load();

            // Set the name of the library
            library.name = Path.GetFileName(path);

            // Return opened library
            return library;
        }

        public void Save(string path)
        {
            try
            {
                // Copy Empty.mdb (a blank database file) to specified file
                string appDir = AppDomain.CurrentDomain.BaseDirectory;
                File.Copy(appDir + @"\Empty.mdb", path, true);
            }
            catch (Exception e)
            {
                throw e;
            }

            // Initialize table adapters for reading/writing
            InitTableAdapters(path);

            // Library is not new (it was saved to a file)
            isNew = false;

            // Save data
            Save();

            // Set the name of the library
            name = Path.GetFileName(path);
        }

        public void Save()
        {
            if (isNew)
            {
                throw new Exception("Library is new, no file specified");
            }
            else
            {
                try
                {
                    // Save added/edited animals
                    AnimalsTable animalsChanges = animalsDataSet.Animals.GetChanges
                        (DataRowState.Added | DataRowState.Modified) as AnimalsTable;
                    if (animalsChanges != null)
                    {
                        animalsTableAdapter.Update(animalsChanges);
                    }

                    // Save added/edited photos
                    PhotosTable photosChanges = animalsDataSet.Photos.GetChanges
                        (DataRowState.Added | DataRowState.Modified) as PhotosTable;
                    if (photosChanges != null)
                    {
                        photosTableAdapter.Update(photosChanges);
                    }

                    // Save added/edited/deleted anchors
                    anchorsTableAdapter.Update(animalsDataSet.Anchors);

                    // Save added/edited/deleted features
                    featuresTableAdapter.Update(animalsDataSet.Features);

                    // Save deleted photos
                    PhotosTable photosDeletes = animalsDataSet.Photos.GetChanges
                        (DataRowState.Deleted) as PhotosTable;
                    if (photosDeletes != null)
                    {
                        photosTableAdapter.Update(photosDeletes);
                    }

                    // Save deleted animals
                    AnimalsTable animalsDeletes = animalsDataSet.Animals.GetChanges
                        (DataRowState.Deleted) as AnimalsTable;
                    if (animalsDeletes != null)
                    {
                        animalsTableAdapter.Update(animalsDeletes);
                    }

                    // Accept data set changes
                    animalsDataSet.AcceptChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        private void Load()
        {
            try
            {
                // Load data (using table adapters)
                animalsTableAdapter.Fill(animalsDataSet.Animals);
                photosTableAdapter.Fill(animalsDataSet.Photos);
                anchorsTableAdapter.Fill(animalsDataSet.Anchors);
                featuresTableAdapter.Fill(animalsDataSet.Features);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void InitTableAdapters(string path)
        {
            // Create table adapter to read/write data
            animalsTableAdapter = new AnimalsTableAdapter();
            photosTableAdapter = new PhotosTableAdapter();
            anchorsTableAdapter = new AnchorsTableAdapter();
            featuresTableAdapter = new FeaturesTableAdapter();

            // Create connection string to indicate filename to read from
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path;

            // Set table adapters' connection string
            animalsTableAdapter.Connection.ConnectionString = connectionString;
            photosTableAdapter.Connection.ConnectionString = connectionString;
            anchorsTableAdapter.Connection.ConnectionString = connectionString;
            featuresTableAdapter.Connection.ConnectionString = connectionString;
        }

        public AnimalsDataSet AnimalsDataSet
        {
            get
            {
                return animalsDataSet;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        
        public bool IsNew
        {
            get
            {
                return isNew;
            }
        }

        public bool HasChanges
        {
            get
            {
                return animalsDataSet.HasChanges();
            }
        }

        private AnimalsDataSet animalsDataSet = null;

        private AnimalsTableAdapter animalsTableAdapter = null;
        private PhotosTableAdapter photosTableAdapter = null;
        private AnchorsTableAdapter anchorsTableAdapter = null;
        private FeaturesTableAdapter featuresTableAdapter = null;

        private string name = "(New Library)";
        private bool isNew = true;
    }
}
