# VAICOMPRO-Community
VAICOM PRO for DCS World

## Overview of the State of Play

On 31 OCT 2022 Hollywood_315 open sourced his awesome AI communications software for DCS Word. VAICOMPRO has been the launch pad for VR flyers in DCS to create a
immersive environment free from the constraints of keyboard or mouse controlled radio menus.

A group of community members have patched his work to make it compatible with DCS 2.8.XXXXX. This is a standalone installer that will replace your previous version of VAICOMPRO.

We have tested this version and have not noticed any behaviours that were not present in the previous version. That said, there may be issues. Please use the issues register here on GitHub to report them.

The plan is to get VAICOMPRO Community running well with DCS 2.8 and then look where we can take it with lots of new modules coming to DCS World.

## Important Information

Please backup your previous installation and backup your current .vap profile from Voice Attack so you can move it across, this will save you a lot of work as it is compatible with this version.
Use of this software is at your risk, we accept no liability for stuffing up your Voice Attack installation, DCS World installation, Windows installation, or any other action.

VAICOMPRO Community 2.8 is not designed to be backwards compatible with DCS 2.7. If you wish to continue using VAICOMPRO for DCS 2.7, please use Hollywood_315's final release and not VAICOMPRO Community.

The VAICOMPRO Community Team

## Installation Instructions

1. Backup your current VAICOMPRO folder found in your VoiceAttack/Apps folder.

2. Backup your current VoiceAttack profile by clicking "More Profile Actions" (button right of the edit in VoiceAttack) and exporting your profile to a known location.

3. Delete the VAICOMPRO folder in your VoiceAttack/Apps folder.

4. Launch VoiceAttack and exit VoiceAttack.

5. Unzip the contents of the zip file and move the VAICOMPRO folder into your VoiceAttack/Apps folder.
	
6. Launch VoiceAttack and exit VoiceAttack. This generates the necessary file structure within the VAICOMPRO folder.

7. If you wish to restore your VAICOM settings, copy your backed up Config folder to your new VAICOMPRO folder in VoiceAttack/Apps. 
   Your profile should remain in VoiceAttack as it is stored in the VoiceAttack.dat file. If your profile somehow gets changed, import your backed up profile.
	
8. Launch VoiceAttack and launch the VAICOM config menu (L CTRL+L ALT+C) and open the “Config” tab. 
   If this does not work, check your VoiceAttack profile and ensure the command "Configuration" exists and is enabled with the proper shortcut.

9. Next to “Use Custom DCS Path” click the SET button and direct it to your DCS World install folder (i. e. Program Files/Eagle Dynamics/DCS World OpenBeta).
	
10. Move the sliders to match your DCS World version (i. e. openbeta / standalone).

11. Open the “Reset” tab and uncheck all of the boxes.

12. Check only the "Lua code" box and click “Master Zero”.

12. Restart VoiceAttack and check the log that comes up, to make sure it finds your DCS 2.8 installation.
	
13. Join our Discord at https://discord.gg/7c22BHNSCS if you have any questions or issues with the install.
