using System.Windows.Forms;

namespace WhiskerPrint.ErrorLayer
{
    public class ErrorMessages
    {
        private static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void PhotoNullError()
        {
            ShowError("Please load a photograph.");
        }

        public static void SideNullError()
        {
            ShowError("Please specify a side to the photograph.");
        }

        public static void FeatureNotFoundError()
        {
            ShowError("Please extract a feature for the photograph.");
        }

        public static void FeatureNullError()
        {
            ShowError("Please extract a feature for the photograph.");
        }
    }
}
