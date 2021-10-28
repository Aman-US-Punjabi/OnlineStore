using System;
namespace OnlineStore.Core.Entities.BaseEntities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedUtc { get; set; }
        public DateTime? LastModifiedUtc { get; set; }

        public BaseEntity()
        {
        }
    }
}
