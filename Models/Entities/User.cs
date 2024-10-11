using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Lemoo_pos.Enums;

namespace Lemoo_pos.Models.Entities
{
    public class User : BaseEntity
    {
        [Required]
        [StringLength(50, ErrorMessage = "Tên người dùng không vượt quá 50 kí tự.")]
        public required string Name { get; set; }


        [Required]
        [EmailAddress(ErrorMessage ="Địa chỉ email không đúng định dạng.")]
        public required string Email { get; set; }

        [Phone(ErrorMessage ="Số điện thoại không đúng định dạng.")]
        public string? Phone { get; set; }

        public string? Avatar { get; set; }

        public DateTime? Birthdate { get; set; }

        public string? Address { get; set; }

        [Required]
        public required EmployeeStatus Status { get; set; }

        [Required]
        public required string Password { get; set; }

        [Required]
        public required ICollection<UserBranch> Branchs { get; set;}
    }
}
