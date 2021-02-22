using Chapter_02___The_Observer_Pattern.Observers;

namespace Chapter_02___The_Observer_Pattern.Subjects
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}