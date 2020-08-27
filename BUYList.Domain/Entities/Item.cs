using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BUYList.Domain.Entities
{
    public class Item
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
        [Required]
        public Guid UserId { get; set; }
    }
}
