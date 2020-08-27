using System;

namespace BUYList.Application.DTOs
{
    public class ItemDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid UserId { get; set; }
    }
}
