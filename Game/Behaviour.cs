using System;
/// <summary>
/// Base class similar to Unity's MonoBehaviour
/// </summary>
public class Behaviour{
    public static readonly List<Behaviour> Behaviours = new List<Behaviour>();
    protected string Name;
    /// <summary>
    /// Calls Start() on all behaviours
    /// </summary>
    public static void StartAll(){
        foreach(Behaviour behaviour in Behaviours){
            behaviour.Start();
        }
    }

    public Behaviour(string name){
        this.Name = name;
        Behaviours.Add(this);
    }

    protected virtual void Start(){
        Console.WriteLine($"Calling regular Start() on Behaviour {(Name)}");
    }
}
