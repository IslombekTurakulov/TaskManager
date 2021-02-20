using System;

namespace ManagerLib.Entities
{
    public class Task : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int WorkingHours { get; set; }

        public string CreatorId { get; set; }

        public string ResponsibleId { get; set; }

        public int CountTask { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastEditDate { get; set; }

        public StatusEnum Status { get; set; }
    }

    public enum StatusEnum
    {
        Opened,
        InProgress,
        Finished
    }

    public enum TaskStatusEnum
    {
        Epic,
        Task,
        Bug,
        Story
    }
}