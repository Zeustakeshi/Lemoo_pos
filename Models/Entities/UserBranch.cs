using System.ComponentModel.DataAnnotations;

namespace Lemoo_pos.Models.Entities
{
    public class UserBranch
    {
        [Key]
        public long UserId { get; set; }

        [Key]
        public long BranchId { get; set; }

        public  long RoleId { get; set; }

        [Required]
        public required User User { get; set; }

        [Required]
        public required Branch Branch { get; set; }

        [Required]
        public required Role Role { get; set; }
    }
}
