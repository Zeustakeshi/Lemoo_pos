using System.ComponentModel.DataAnnotations;

namespace Lemoo_pos.Models.Entities
{
    public class Branch : BaseEntity
    {
        [Required]
        [StringLength(100, ErrorMessage = "Tên chi nhánh quá dài.")]
        public required string Name { get; set;}

        [Required]
        public required Store Store { get; set; }

        [Required]
        public required ICollection<UserBranch> Users { get; set; }
    }
}
