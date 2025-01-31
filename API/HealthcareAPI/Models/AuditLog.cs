//This model tracks actions performed by users in the system.

using System;

public class AuditLog
{
    public int Id { get; set; }
    public int? UserId { get; set; }
    public User User { get; set; }
    public string Action { get; set; }
    public DateTime Timestamp { get; set; }
}
