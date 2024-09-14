namespace inProgress.Models
{
    public class User
    {
        public int Id { get; set; } // User tablosu için birincil anahtar
        public string FirstName { get; set; } // Kullanıcının adı
        public string LastName { get; set; } // Kullanıcının soyadı
        public string Email { get; set; } // Kullanıcının e-posta adresi
        public string PasswordHash { get; set; } // Kullanıcının şifre hash'i

        public ICollection<UserTeam> UserTeams { get; set; }
        public ICollection<TaskAssignment> TaskAssignments { get; set; }
    }
}
