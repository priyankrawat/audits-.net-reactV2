using System.Text.Json.Serialization;

namespace audits_.net_react_ramine.Models;

public class Setting
{
    [JsonPropertyName("daily_email_updates")]
    public bool DailyEmailUpdates { get; set; }
}
