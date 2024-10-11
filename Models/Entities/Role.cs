using System.ComponentModel.DataAnnotations;

namespace Lemoo_pos.Models.Entities
{
    public class Role : BaseEntity
    {
        [Required]
        [StringLength(100, ErrorMessage ="Tên vai trò quá dài.")]
        public required string Name { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "Mô tả vai trò quá dài.")]
        public required string Description { get; set; }

        [Required]
        public required Store Store { get; set; }

        [Required]
        public required  ICollection<Permission> Permissions { get; set;}
    }
}
