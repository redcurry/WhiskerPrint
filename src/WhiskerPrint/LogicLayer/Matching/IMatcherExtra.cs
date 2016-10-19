namespace WhiskerPrint.LogicLayer.Matching
{
    public interface IMatcherExtra : IMatcher
    {
        IMatcher Matcher { get; set; }
    }
}
