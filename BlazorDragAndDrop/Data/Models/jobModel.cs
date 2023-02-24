namespace BlazorDragAndDrop.Data.Models
{
    public class JobModel
    {
        public int Id { get; set; }    
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
        public JobStatuses Status { get; set; }
    }

    public enum JobStatuses
    {
        Todo,
        Started,
        Progress,
        Completed
    }
}
