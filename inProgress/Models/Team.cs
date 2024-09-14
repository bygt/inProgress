namespace inProgress.Models
{
    public class Team
    {
        public int Id { get; set; } // Takım tablosu için birincil anahtar
        public string Name { get; set; } // Takımın adı
        public string Description { get; set; } // Takımın açıklaması

        public ICollection<UserTeam> UserTeams { get; set; }
        public ICollection<TaskItem> Tasks { get; set; }
    }
}
