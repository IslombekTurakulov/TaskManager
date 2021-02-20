using System;

namespace ManagerLib.Entities
{
    internal class Comment : BaseEntity
    {
        public int TaskId { get; set; }

        public int UserId { get; set; }

        public string Text { get; set; }

        public DateTime CreateDate { get; set; }
    }
}