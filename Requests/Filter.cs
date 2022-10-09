namespace audits_.net_react_ramine.Requests;

public class Filters
{
    public string Message { get; set; }

    internal bool Valid() => Message != null && Message != string.Empty;
}