# Area and Perimeter Calculator

Windows Forms application that calculates area and perimeter for a few basic shapes (rectangle, circle, triangle, etc.). This project targets .NET 10 and is intended for learning GUI programming with WinForms.

![App screenshot](Capture.PNG)

## Features
- Calculate area and perimeter for common shapes (rectangle, circle, triangle)
- Simple, easy-to-use Windows Forms UI

## Requirements
- .NET 10 SDK
- Visual Studio 2022/2026 or later (or the dotnet CLI)

## Run locally
1. Open the solution in Visual Studio and press F5, or
2. From a command line (PowerShell) run:

   dotnet run --project ./AreaAndPerimeterCalculator/AreaAndPerimeterCalculator.csproj

Replace the project path if your solution layout is different.

## Screenshot
Place a PNG image named `Capture.PNG` inside the `docs/docs` folder so the README references `./docs/docs/Capture.PNG`. This path is sometimes used by documentation generators and GitHub will still render it.

We've created a placeholder `.gitkeep` in `docs/` to keep the folder in the repository. You can add the screenshot like this:

1. Run the application.
2. Press Alt+PrtSc (copies the active window to clipboard).
3. Open Paint or another image editor, paste (Ctrl+V) and save as `docs/docs/Capture.PNG`.

Recommended screenshot settings:
- File name: `Capture.PNG`
- Recommended size: 1280×720 or 1024×768
- Use PNG for best results

To add the screenshot file from PowerShell (example):

   mkdir -Force .\docs\docs
   # Copy an existing screenshot into the docs/docs folder
   Copy-Item -Path 'C:\path\to\your\screenshot.png' -Destination .\docs\docs\Capture.PNG

Or from File Explorer drag-and-drop the PNG into the `docs/docs` folder in your project directory.

## Contributing
Feel free to open issues or pull requests. Add tests and ensure the project builds on the CI used by this repository.

## License
Add a license file (LICENSE) to this repository if you want to publish under a specific license.

