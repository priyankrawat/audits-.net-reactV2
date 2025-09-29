using System.Text.Json.Serialization;

namespace audits_.net_react_ramine.Models;

public class Setting
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("daily_email_updates")]
    public bool DailyEmailUpdates { get; set; }
    [JsonPropertyName("audit_table_default_rows")]
    public int AuditTableDefaultRows { get; set; }
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }
}