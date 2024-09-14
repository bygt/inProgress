using inProgress.Models;

// relationship between User and Group
public class UserTeam
{
    public int UserId { get; set; }
    public User User { get; set; }

    public int TeamId { get; set; }
    public Team Team { get; set; }
}
