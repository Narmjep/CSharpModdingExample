
# Game

### [Behaviour](Behaviour.cs)

The **Behaviour** class is supposed to immitate Unity's MonoBehaviour class. The main purpose is to provide a ```Start()``` method that will be called when the game starts.

### [EventManager](EventManager.cs)

The **EventManager** provides an event called ```SomeEvent``` that gets fired after the game starts. You can subscribe to this event in your mod and add your own logic.

### [ModManager](ModManager.cs)

The **ModManger** is responsible for providing the base class for the mod to inherit from, and for loading the mods.

In this example, every mod must have a class called ```Entry``` that inherits from the ```Module``` class. When the game starts, the ModManager loads all the mods and calls the ```OnLoad()``` method of the ```Entry``` class, that can be overriden by the mod.