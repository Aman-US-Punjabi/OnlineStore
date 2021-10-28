using System;
namespace OnlineStore.Core.Entities.BaseEntities
{
    public class AuditableEntity : BaseEntity
    {
        public int CreatedByUserID { get; set; }
        public int LastModifiedByUserId { get; set; }

        public AuditableEntity()
        {
        }
    }
}
