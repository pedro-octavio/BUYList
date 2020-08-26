using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BUYList.Domain.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(25)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(200)]
        public string Password { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
