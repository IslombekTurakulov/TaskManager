using System;

namespace ManagerLib.Entities
{
    public class Record : BaseEntity
    {
        public int TaskId { get; set; }

        public int UserId { get; set; }

        public int IDTaskRecord { get; set; }

        public int WorkingHours { get; set; }

        public DateTime CreateDate { get; set; }
    }
}