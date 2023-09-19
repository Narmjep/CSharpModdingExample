# Mod

The [mod.cs](mod.cs) defines the ```Entry``` class that inherits from the ```Module``` and the ```ModdedBheaviour``` class that inherits from the game's ```Behaviour``` class.

### Entry

Inside the Entry class, the ```OnLoad()``` method is overriden. Here you can add your own logic for initializing your mod.

### ModdedBehaviour

This class is a custom version of the game's ```Behaviour``` class. You can override virtual methods like ```Start()``` and add your own logic. Additionally you can also add custom logic using events such as in the ```OnSomeEvent``` method.