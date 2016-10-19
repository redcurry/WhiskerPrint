using System.Drawing;

namespace WhiskerPrint.LogicLayer.Matching
{
    public interface IMatcher : IProgressible
    {
        double GetScore(Image image1, Image image2);
    }
}
