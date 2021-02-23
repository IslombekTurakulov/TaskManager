using System;

namespace ManagerLib.Entities
{
    public class EpicTask : BaseEntity
    {
        public int SubTaskId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int WorkingHours { get; set; }

        public string CreatorId { get; set; }

        public string ResponsibleId { get; set; }

        public int IdCreator { get; set; }

        public DateTime LastEditDate { get; set; }

        public EpicTaskStatus Status { get; set; }

        public EpicTaskPriority Priority { get; set; }

    }
    public enum EpicTaskStatus
    {
        Opened,
        InProgress,
        Finished
    }

    public enum EpicTaskPriority
    {
        Task,
        Story
    }
}