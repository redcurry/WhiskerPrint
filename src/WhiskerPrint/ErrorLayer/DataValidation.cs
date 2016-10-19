using PhotosRow = WhiskerPrint.DataLayer.AnimalsDataSet.PhotosRow;
using FeaturesRow = WhiskerPrint.DataLayer.AnimalsDataSet.FeaturesRow;

namespace WhiskerPrint.ErrorLayer
{
    public class DataValidation
    {
        public static bool ValidatePhotosRow(PhotosRow photoRow)
        {
            if (photoRow.IsPhotoNull())
            {
                ErrorMessages.PhotoNullError();
                return false;
            }
            else if (photoRow.IsSideNull())
            {
                ErrorMessages.SideNullError();
                return false;
            }
            else
            {
                FeaturesRow[] featureRows = photoRow.GetFeaturesRows();
                if (featureRows.Length > 0)
                {
                    return ValidateFeaturesRow(featureRows[0]);
                }
                else
                {
                    ErrorMessages.FeatureNotFoundError();
                    return false;
                }
            }
        }

        public static bool ValidateFeaturesRow(FeaturesRow featureRow)
        {
            if (featureRow.IsFeatureNull())
            {
                ErrorMessages.FeatureNullError();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
