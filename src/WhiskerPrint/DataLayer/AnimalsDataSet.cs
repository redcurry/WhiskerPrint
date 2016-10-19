using System.Data;

namespace WhiskerPrint.DataLayer
{
    partial class AnimalsDataSet
    {
        public int GetNextId(DataTable table)
        {
            int maxId = 0;

            // Consider rows in library data set
            foreach (DataRow row in table.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    int id = (int)row[0];
                    if (id > maxId)
                    {
                        maxId = id;
                    }
                }
            }

            // Next id is maxId + 1
            return maxId + 1;
        }

        partial class AnimalsDataTable
        {
            public AnimalsRow AddValidAnimalsRow()
            {
                return AddAnimalsRow(GetNextId(), null, null);
            }

            public int GetNextId()
            {
                return ((AnimalsDataSet)this.DataSet).GetNextId(this);
            }
        }

        partial class PhotosDataTable
        {
            public PhotosRow AddValidPhotosRow(AnimalsRow animalsRow)
            {
                return AddPhotosRow(this.GetNextId(), animalsRow, null, null);
            }

            public int GetNextId()
            {
                return ((AnimalsDataSet)this.DataSet).GetNextId(this);
            }
        }

        partial class AnchorsDataTable
        {
            public AnchorsRow AddValidAnchorsRow(PhotosRow photosRow)
            {
                return AddAnchorsRow(this.GetNextId(), photosRow, 0, 0, 0);
            }

            public int GetNextId()
            {
                return ((AnimalsDataSet)this.DataSet).GetNextId(this);
            }
        }

        partial class FeaturesDataTable
        {
            public FeaturesRow AddValidFeaturesRow(PhotosRow photosRow)
            {
                return AddFeaturesRow(this.GetNextId(), photosRow, null);
            }

            public int GetNextId()
            {
                return ((AnimalsDataSet)this.DataSet).GetNextId(this);
            }
        }
    }
}
