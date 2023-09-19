/// <summary>
/// The entry point for the mod. This class must be named 'Entry' and must inherit from Module.
/// </summary>
public class Entry : Module{
    /// <summary>
    /// Override OnLoad() to add mod-related functionality.
    /// </summary>
    public override void OnLoad()
    {
        base.OnLoad();
        ModdedBehaviour mod = new ModdedBehaviour("Modded");
        Console.WriteLine($"Mod loaded!");
    }
}

/// <summary>
/// A modded version of Behaviour. You can modify any class in the game this way. Make sure that the base class has virtual methods that you can override.
/// </summary>
public class ModdedBehaviour : Behaviour{
    public ModdedBehaviour(string name) : base(name){}
    protected override void Start(){
        Console.WriteLine($"Calling modified Start() on Behaviour {(Name)}");
        EventManager.SomeEvent += OnSomeEvent;
        base.Start();
    }

    /// <summary>
    /// You can also run custom code using events
    /// </summary>
    private void OnSomeEvent(object sender, EventArgs e){
        Console.WriteLine("Some event was fired!");
        //Do something
    }
}