using System.Text.Json.Serialization;

namespace audits_.net_react_ramine.Requests;

public class AuditRequest
{
    [JsonPropertyName("q")]
    public FilterAudit Query { get; set; }
}
