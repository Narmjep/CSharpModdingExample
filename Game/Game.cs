using System;


class Program{
    public static void Main(String[] args){
        //Load mods
        ModManager.LoadMods();
        ModManager.InitMods();
        //Setup events
        EventManager eventManager = new EventManager();        
        //Create a normal behaviour
        Behaviour camera = new Behaviour("Camera");
        Behaviour.StartAll();
        eventManager.FireEvent();
        //....
    }

}