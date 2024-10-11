using System.ComponentModel.DataAnnotations;

namespace Lemoo_pos.Models.Entities
{
    public class Store : BaseEntity
    {
        [Required]
        [StringLength(100, ErrorMessage ="Tên cửa hàng quá dài.")]
        public required string Name { get; set; }

        public string? Image { get; set; }


    }
}
