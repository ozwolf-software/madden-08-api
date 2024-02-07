# Installation

To install and use the API DLL, use the following steps in your Visual Studio project:

1. Download the `Madden08.API.dll` file from its project site along with the matched `tdbaccess.dll` made available there.
2. Place them both physically into your project.
3. Set both files to:
	a. **Build Action** - Content
	b. **Copy to Output Directory** - If Newer
4. If you place the DLL files in a subdirectory of your project, edit your project file and add `<TargetPath>tdbaccess.dll</TargetPath>` and `<TargetPath>Madden08.API.dll</TargetPath>` properties to the `<Content Include="...">` nodes for each file respectively.
5. Right-click on your projects **Dependencies** and click "Add COM Reference...".  Use "Browse" to navigate to where you placed the `Madden08.API.dll` file in (2) and import it.
6. You should now be able to instantiate a `MaddenAPI` instance via a call like `MaddenAPI api = new MaddenAPI("path/to/file.fra");`

## Namespace

All classes and objects under this project live in the `Madden08.API` namespace.