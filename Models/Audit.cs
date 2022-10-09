using System.ComponentModel.DataAnnotations.Schema;

namespace audits_.net_react_ramine.Models;

public class Audit
{
    public int Id { get; set; }
    public string Event { get; set; }
    public string Status { get; set; }
    public string Message { get; set; }
    [Column(TypeName = "jsonb")]
    public string Context { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}