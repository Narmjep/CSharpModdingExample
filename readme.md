# C# Modding Example

This is an example of how to implement mods in your C# game, to allow modders to run their own code in your game. This example can be applied to your Unity game.

The project consists of two csharp projects:

- [Game](Game/readme.md) : This is the main executable that respresents the game or the unity environment.

- [Mod](Mod/readme.md) : The mod is a dll that will be loaded by the game.


## How it works

To run custom code, the game provides classes that can be **inherited** from and **overriden**. Furthermore, you can implement an event system in your game, that will allow modders to subscribe to **events** and run their own code.

The game also has to implement a [ModManager](Game/ModManager.cs) that will load the compiled mods at runtime and initialize them.

Modders will need to have access to the game code. For unity games, the code can usually be found in the [game name]_Data/Managed/Assembly-CSharp.dll. You can use tools such as [dnSpy](https://github.com/dnSpy/dnSpy) to view the code. <span style="color:red">Make sure your **Terms of Service** allow modders to view your code. </span>
Modders can also use [Harmony](https://github.com/pardeike/Harmony) to access and modify the game code at runtime.

## Building

To build the project, you need the .NET SDK. The projects are configured to use the .NET 7.0 SDK, however you can change the version in the corresponding .csproj file [Game.csproj](Game/Game.csproj) and [Mod.csproj](Mod/Mod.csproj).

You can build and run the projects using the scripts [build.bat](build.bat) (cmd) and [build.ps1](build.ps1) (powershell).

---
## Important!
Allowing modders to run their own code in your game can be dangerous. Players who use those mods can potentially harm their computer. Make sure to inform your players about the risks of using mods and how to use them safely.