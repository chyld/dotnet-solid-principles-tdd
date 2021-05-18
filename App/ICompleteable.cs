namespace App
{
    public interface ICompletable
    {
        string TextToDisplay { get; }
        bool isComplete { get; }
        void markComplete();
        void markIncomplete();
    }
}
