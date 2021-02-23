using System;

namespace ManagerLib.Entities
{
    public class SubTask : BaseEntity
    { 
        public int SubTaskId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int WorkingHours { get; set; }

        public string CreatorId { get; set; }

        public string ResponsibleId { get; set; }

        public int IdCreator { get; set; }

        public DateTime LastEditDate { get; set; }

        public SubTaskStatus Status { get; set; }

        public TaskStatusEnum TaskStatus { get; set; }
    }

    public enum SubTaskStatus
    {
        Opened,
        InProgress,
        Finished
    }
}
