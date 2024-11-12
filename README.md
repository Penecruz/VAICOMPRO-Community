# VAICOMPRO-Community

[![Downloads](https://img.shields.io/github/downloads/Penecruz/VAICOMPRO-Community/total?logo=GitHub)](https://github.com/Penecruz/VAICOMPRO-Community/releases/latest)
[![Discord](https://img.shields.io/discord/736032844274728961?logo=Discord)](https://discord.gg/7c22BHNSCS)
[![Latest Release](https://img.shields.io/github/v/release/Penecruz/VAICOMPRO-Community?logo=GitHub)](https://github.com/Penecruz/VAICOMPRO-Community/releases/latest)

VAICOM PRO Community Edition for DCS World

## Overview - Community Edition

On 31 OCT 2022 Hollywood_315 open sourced his awesome AI communications software for DCS Word. VAICOMPRO has been the launch pad for VR flyers in DCS to create a
immersive environment free from the constraints of keyboard or mouse-controlled radio menus.

A group of community members have patched his work to make it compatible with DCS 2.8.XXXXX and later. This is a standalone installer that will replace your previous version of VAICOMPRO. It will not work with DCS 2.7.XXXXX or erlier.

We now have VAICOMPRO Community Edition running well with DCS 2.8.X.X and are looking where we can take it going forward with lots of new modules coming to DCS World.
We continue to develop VAICOMPRO to keep it functioning with changes to DCS. That said, there will be issues from time to time. So please use the issues register here on GitHub to report them.

Remember this is a community group, a group that donates their time to keep this awesome software alive. Be respectful and patient, we all have real jobs too. Join our Discord Server (link Below) and become part of our community.

## Important Information

VAICOMPRO Community is 100% free and includes all modules (Chatter, AIRIO, Kneeboard, Realistic ATC) that were available with the last paid release.

Use of this software is at your risk, we accept no liability for stuffing up your Voice Attack installation, DCS World installation, Windows installation, or any other action.

The VAICOMPRO Community Team

## Known Issues

VAICOMPRO Community 2.8.X.X is not designed to be backwards compatible with DCS 2.7.X If you wish to continue using VAICOMPRO for DCS 2.7, please use Hollywood_315's final release and not VAICOMPRO Community.

VAICOMPRO Community Edition will not pass the Integrity Check on Multiplayer Servers that require Pure Client Scripts unless the AIRIO and Kneeboard extensions are deactivated via the VAICOMPRO UI.
This is because VAICOMPRO adds lines to some of DCS World's core LUA files to enable it to function. Multiplayer Server administrators must enable Pure Client Scripts as an option as it is off by default. Very few Servers require Pure Client Scripts. This is something that only ED can change.

DiCE: DCS Integrated Countermeasure Editor creates many functionality issues with VAICOMPRO Community, and it is recommended this be uninstalled before using VAICOMPRO Community.

Flashing Comms Menu after DCS World update is a known issue and can be resolved with a lua reset, closing DCS and voiceAttack then launching VoiceAttack again prior to launching DCS to generate DCS side files.

## Installation Instructions

#### NOTE: If this is a new VAICOMPRO installation, you should follow the install instructions in the VAICOMPRO manual found in the VAICOMPRO/Documentation folder.
	
#### To update from an older version of VAICOMPRO


1. Ensure DCS is not Running

2. Backup your current VoiceAttack profile by clicking "More Profile Actions" (button right of the edit in VoiceAttack) and exporting your profile to a known location (this avoids tears in the event of an issue).

3. If you are using the MSI Installer, you will need to uninstall via the Windows process It will retain your config and profile settings (You will be propted if you try running the installer)

4. If you are using the Zip file just unzip over the top of you existing VAICOMPRO folder in Program Files/ VoiceAttack /Apps folder

5. Launch VoiceAttack and exit VoiceAttack (this allows VAICOMPRO to build the required DCS files).
	
6. Launch VoiceAttack and launch the VAICOM config menu (L CTRL+L ALT+C) Check that your settings have been retained and the DCS Path details are correct.

7. Launch DCS and confirm 

8. Join our Discord at https://discord.gg/7c22BHNSCS if you have any questions or issues with the install.

## Patch Notes


**VAICOM PRO plugin 2.9.9.3**

This update adds Kola terrain to the new file patching routine that allows Vaicom Pro to append individual
terrain modules radio.lua files. This will pick up Bodo and add some UHF frequencies to other military fields
for use with Easy Comms and in turn the use of the "Select" command in Vaicom Pro. It also adds the new Syrian airfields expansion to the recipients list. There are some small bug fixes.

-	Kola radio.lua patching routine.
-	Fix error in recipients database.
-	CH-47 Chinook WIP radio changes.
-	Add new Syrian airfields to ATC recipient’s database.

**Known Issues**

-	Rearming Request with Ground Crew will not open Rearming UI, only rearms last selection (Use Options Command to access menu for now).There have been changes in DCS Version 2.9.6.X that adds new rearm routine to support Dynamic Spawn Client Slots, Users have reported issues when jumping between Dynamic slots and Vaicom not recognising the new module.

## Community Team

Pene, Special K, D3adCy11nd3r, Folgers, Hornblower793, Liam8, MAXsenna, MisterOutofTime, Raskit and stag1975

#### Beta Team
104th_Aeons, GSG-3|Turbine|202, DrChainsaw, Jaeger, Nicola, Padinn, SPAZ-505, tomeye, Virus, Bonz RexExGSR, LawnBoy and Scotia
