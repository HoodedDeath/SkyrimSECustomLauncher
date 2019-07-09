# Skyrim-SE-Custom-Launcher
-Description-
A simple application to replace the vanilla Skyrim Special Edition launcher, for easy access to launching with SKSE loaded as well as opening Vortex Mod Manager

-Installation-
1. Open your Skyrim SE installation folder (default is "C:\Program Files (x86)\Steam\steamapps\common\Skyrim Special Edition")
2. Rename "SkyrimSELauncher.exe" to "SkyrimSELauncher_VANILLA.exe" (You can rename it to anything, see notes)
3. Copy "SkyrimSECustomLauncher.exe" from this project to Skyrim SE's root folder
4. Rename "SkyrimSECustomLauncher.exe" to "SkyrimSELauncher.exe"
5. Launcher is now ready and will be started by Steam when starting Skyrim SE

-Uninstalling-
1. Open your Skyrim SE installation folder (default is "C:\Program Files (x86)\Steam\steamapps\common\Skyrim Special Edition")
2. Delete "SkyrimSELauncher.exe"
3. Rename "SkyrimSELauncher_VANILLA.exe" (or whatever you named it previously) to "SkyrimSELauncher.exe"
4. Done

-Notes-
- The executable must be in Skyrim Special Edition's root folder to function
- The executable must be named "SkyrimSELauncher.exe" to launch through Steam
- The custom launcher may need some configuration, depending on the names of the executables in the Skyrim SE directory
- The default file name used for SKSE is "skse64_loader.exe"
- The default file name used for the vanilla game is "SkyrimSE.exe"
- The default file name used for the vanilla launcher is "SkyrimSELauncher_VANILLA.exe"
- The default file path used for Vortex is "C:\\Program Files\\Black Tree Gaming Ltd\\Vortex\\Vortex.exe"
- If any of these differ from how your file system is set up, use the "Settings" button is the menu strip to configure file names/locations

-Help-
- Main window
  - "Launch SKSE" button - Launches Skyrim SE with SKSE loaded
  - "Launch Vanilla" button - Launches Skyrim SE through the vanilla executable
  - "Open Vortex" button - Opens Vortex Mod Manager
  - "Vanilla Launcher" button - Opens the vanilla Skyrim SE launcher, mainly only used for changing video settings
  - "Settings" button - Opens configuration window
  - "Cancel" button - Closes the application
- Configuration window
  - This window is only needed if a popup appears on start up, telling you one or more of the executables couldn't be found
  - Leave any text box blank to use the default value for that option
  - "SKSE Loader Name" - Name of the SKSE executable, default is "skse64_loader.exe"
  - "Vanilla Game Name" - Name of the vanilla Skyrim SE executable, default is "SkyrimSE.exe"
  - "Vanilla Launcher Name" - Name of the vanilla Skyrim SE Launcher, default is "SkyrimSELauncher_VANILLA.exe"
  - "Vortex Install Path" - Path to the Vortex executable, the only text box that uses a full file path, default is "C:\\Program Files\\Black Tree Gaming Ltd\\Vortex\\Vortex.exe"
