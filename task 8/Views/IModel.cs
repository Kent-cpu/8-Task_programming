namespace task_8.Views
{
    public interface IModel
    {
        string firstPathText { get; set; }
        string secondPathText { get; set; }
        string modifiedText { get; set; }
        string actionFile { get; set; }
        string dateInfo { get; }
        string timeInfo { get; }
        string fileNameText { get; set; }
    }
}
