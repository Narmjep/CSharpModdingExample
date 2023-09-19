@echo off
echo "Building game..."
cd .\Game
dotnet build

echo "Building mod..."
cd ../Mod
dotnet build

echo "Running game..."
echo ""
cd ../Game
dotnet run

cd ..