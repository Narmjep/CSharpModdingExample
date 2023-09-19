public class EventManager{
    public static event EventHandler? SomeEvent;

    public void FireEvent(){
        SomeEvent?.Invoke(this, System.EventArgs.Empty);
    }
}