using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using VAICOM.Static;

namespace VAICOM {

    namespace Database {

        [SupportedOSPlatform("windows")]
        public static partial class Appendices {

            public static Dictionary<string, Command> Weapon = new Dictionary<string, Command>(StringComparer.OrdinalIgnoreCase)
            {
            { "withmissile" ,   new Command { dcsid = "wApxEngageUseWeaponMissile",  displayname = Labels.aiappendiceswpn["withmissile"], useweapon = true, weapon = Weapons.Missile }},
            { "withunguided" ,  new Command { dcsid = "wApxEngageUseWeaponUnguided", displayname = Labels.aiappendiceswpn["withunguided"],useweapon = true, weapon = Weapons.Unguided }},
            { "withguided" ,    new Command { dcsid = "wApxEngageUseWeaponGuided",   displayname = Labels.aiappendiceswpn["withguided"],  useweapon = true, weapon = Weapons.Guided }},
            { "withrocket" ,    new Command { dcsid = "wApxEngageUseWeaponRocket",   displayname = Labels.aiappendiceswpn["withrocket"],  useweapon = true, weapon = Weapons.Rocket }},
            { "withmarker" ,    new Command { dcsid = "wApxEngageUseWeaponMarker",   displayname = Labels.aiappendiceswpn["withmarker"],  useweapon = true, weapon = Weapons.Marker }},
            { "withgun" ,       new Command { dcsid = "wApxEngageUseWeaponGun",      displayname = Labels.aiappendiceswpn["withgun"],     useweapon = true, weapon = Weapons.Gun }},
            };

            public static Dictionary<string, Command> Direction = new Dictionary<string, Command>(StringComparer.OrdinalIgnoreCase)
            {
            { "fromthenorth" ,      new Command { dcsid = "wApxEngageUseDirectionNorth",     displayname = Labels.aiappendicesdir["fromthenorth"],      usedirection = true, direction = Directions.North }},
            { "fromthenortheast" ,  new Command { dcsid = "wApxEngageUseDirectionNorthEast", displayname = Labels.aiappendicesdir["fromthenortheast"],  usedirection = true, direction = Directions.NorthEast }},
            { "fromtheeast" ,       new Command { dcsid = "wApxEngageUseDirectionEast",      displayname = Labels.aiappendicesdir["fromtheeast"],       usedirection = true, direction = Directions.East }},
            { "fromthesoutheast" ,  new Command { dcsid = "wApxEngageUseDirectionSouthEast", displayname = Labels.aiappendicesdir["fromthesoutheast"],  usedirection = true, direction = Directions.SouthEast }},
            { "fromthesouth" ,      new Command { dcsid = "wApxEngageUseDirectionSouth",     displayname = Labels.aiappendicesdir["fromthesouth"],      usedirection = true, direction = Directions.South }},
            { "fromthesouthwest" ,  new Command { dcsid = "wApxEngageUseDirectionSouthWest", displayname = Labels.aiappendicesdir["fromthesouthwest"],  usedirection = true, direction = Directions.SouthWest }},
            { "fromthewest" ,       new Command { dcsid = "wApxEngageUseDirectionWest",      displayname = Labels.aiappendicesdir["fromthewest"],       usedirection = true, direction = Directions.West }},
            { "fromthenorthwest" ,  new Command { dcsid = "wApxEngageUseDirectionNorthWest", displayname = Labels.aiappendicesdir["fromthenorthwest"],  usedirection = true, direction = Directions.NorthWest }},
            };

        }
    }
}
