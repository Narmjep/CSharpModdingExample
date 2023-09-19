using System.Reflection;

/// <summary>
/// Manages mods. Each mod is a dll that must conaint an 'Entry' class.
/// </summary>
class ModManager{
    private static readonly List<Module> Modules = new List<Module>();
    /// <summary>
    /// The path to the dll is hardcoded for simplicity. In a real game, you would probably want to get the path differently (i.e. load all dlls from a 'Mods' folder).
    /// </summary>
    private const string modname = "../Mod/bin/Debug/net7.0/mod.dll";

    /// <summary>
    /// Loads the mod's dll
    /// </summary>
    public static void LoadMods(){
        //Load Files
        var file = new FileInfo(modname);
        Assembly mod = Assembly.LoadFile(file.FullName);
        //Look for Entry class
        Type? entry = mod.GetType("Entry");
        if(entry == null){
            Console.WriteLine("Couldn't find mod entry!");
            return;
        }
        Module module = (Module) Activator.CreateInstance(entry);
        Modules.Add(module);
    }

    /// <summary>
    /// Calls OnLoad() on all mods
    /// </summary>
    public static void InitMods(){
        foreach(Module module in Modules){
            Console.WriteLine("Added a mod");
            module.OnLoad();
        }
    }
}

/// <summary>
/// Base class for mods. Each mod must have an 'Entry' class that inherits from this class.
/// </summary>
public abstract class Module{
    /// <summary>
    /// Called when the mod is loaded. Here you can add mod-related 
    /// </summary>
    public virtual void OnLoad(){
        Console.WriteLine("Loading mod...");
    }
}

