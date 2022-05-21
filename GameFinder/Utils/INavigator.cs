namespace GameFinder.Utils
{
    public interface INavigator
    {
        void Navigate(Destination destination);
    }

    public enum Destination { Search, Storage };
}
