using System.ComponentModel.DataAnnotations;

namespace AdminDashboard_UI.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [MaxLength(40)]
        public string? Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
