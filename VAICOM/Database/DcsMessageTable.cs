using System;
using System.Collections.Generic;
using System.Linq;
using VAICOM.Static;

namespace VAICOM
{

    namespace Database
    {

        public static partial class Dcs
        {
            public static SortedDictionary<int, string> DcsMessageTable;
            public static void CreateDcsMessagesTable()
            {

                /// <summary>
                /// generated directly from dump .csv / .xlxs file
                /// dump lua code see below (use UI * tab in deep debug mode)
                /// updated list for DCS 2.7
                /// </summary> 

                //--dump Lua code:
                //base = _G
                //local lfs = require("lfs")
                //local io = require("io")
                //dumpfile = io.open(lfs.writedir()..[[DcsDump.csv]], "w")
                
                //if dumpfile then
                //  listtables = function(offset, maxdepth, tablename, filtertype)
                //      if base.type(tablename) == "table" then
                //      for n, v in base.pairs(tablename) do
                //        local function spacing()
                //        for i = 0, offset do
                //    dumpfile: write(";")
                //        end
                //    end
                //    spacing()
                //    if base.tostring(n) ~= "_M" and base.tostring(n) ~= "__index" and filtertype == nil or base.type(v) == filtertype then
                //        if base.type(v) == "table" then
                //            dumpfile:write(base.tostring(n)..";"..base.tostring(base.type(v)).."\n")
                //            newoffset = offset + 1
                //            if newoffset < maxdepth then
                //                listtables(newoffset, maxdepth, v, filtertype)
                //            end
                //        else
                //            if base.type(v) == "function" or base.type(v) == "userdata" then
                //                dumpfile:write(base.tostring(n)..";"..base.tostring(base.type(v))..";"..base.tostring(base.debug.getinfo(v).what).."\n")
                //            else
                //dumpfile: write(base.tostring(n)..";"..base.tostring(base.type(v))..";"..base.tostring(v).."\n")
                //            end
                //        end
                //    end
                //end
                //else
                //dumpfile: write(base.tostring(base.type(tablename))..";"..base.tostring(tablename).."\n")
                //end
                //end


                //listtables(0, 2, base.Message)
                //dumpfile: close()
                //end

                DcsMessageTable = new SortedDictionary<int, string>();

                DcsMessageTable.Add(4000, "wMsgNull");
                DcsMessageTable.Add(4001, "wMsgLeaderNull");
                DcsMessageTable.Add(4002, "wMsgLeaderToWingmenNull");
                DcsMessageTable.Add(4003, "wMsgLeaderEngageMyTarget");
                DcsMessageTable.Add(4004, "wMsgLeaderEngageBandits");
                DcsMessageTable.Add(4005, "wMsgLeaderEngageGroundTargets");
                DcsMessageTable.Add(4006, "wMsgLeaderEngageArmor");
                DcsMessageTable.Add(4007, "wMsgLeaderEngageArtillery");
                DcsMessageTable.Add(4008, "wMsgLeaderEngageAirDefenses");
                DcsMessageTable.Add(4009, "wMsgLeaderEngageUtilityVehicles");
                DcsMessageTable.Add(4010, "wMsgLeaderEngageInfantry");
                DcsMessageTable.Add(4011, "wMsgLeaderEngageNavalTargets");
                DcsMessageTable.Add(4012, "wMsgLeaderEngageDlinkTarget");
                DcsMessageTable.Add(4013, "wMsgLeaderEngageDlinkTargets");
                DcsMessageTable.Add(4014, "wMsgLeaderEngageDlinkTargetByType");
                DcsMessageTable.Add(4015, "wMsgLeaderEngageDlinkTargetsByType");
                DcsMessageTable.Add(4016, "wMsgLeaderFulfilTheTaskAndJoinUp");
                DcsMessageTable.Add(4017, "wMsgLeaderFulfilTheTaskAndReturnToBase");
                DcsMessageTable.Add(4018, "wMsgLeaderRayTarget");
                DcsMessageTable.Add(4019, "wMsgLeaderMyEnemyAttack");
                DcsMessageTable.Add(4020, "wMsgLeaderCoverMe");
                DcsMessageTable.Add(4021, "wMsgLeaderFlightCheckIn");
                DcsMessageTable.Add(4022, "wMsgLeaderPincerRight");
                DcsMessageTable.Add(4023, "wMsgLeaderPincerLeft");
                DcsMessageTable.Add(4024, "wMsgLeaderPincerHigh");
                DcsMessageTable.Add(4025, "wMsgLeaderPincerLow");
                DcsMessageTable.Add(4026, "wMsgLeaderBreakRight");
                DcsMessageTable.Add(4027, "wMsgLeaderBreakLeft");
                DcsMessageTable.Add(4028, "wMsgLeaderBreakHigh");
                DcsMessageTable.Add(4029, "wMsgLeaderBreakLow");
                DcsMessageTable.Add(4030, "wMsgLeaderClearRight");
                DcsMessageTable.Add(4031, "wMsgLeaderClearLeft");
                DcsMessageTable.Add(4032, "wMsgLeaderPump");
                DcsMessageTable.Add(4033, "wMsgLeaderAnchorHere");
                DcsMessageTable.Add(4034, "wMsgLeaderFlyAndOrbitAtSteerPoint");
                DcsMessageTable.Add(4035, "wMsgLeaderFlyAndOrbitAtSPI");
                DcsMessageTable.Add(4036, "wMsgLeaderFlyAndOrbitAtPoint");
                DcsMessageTable.Add(4037, "wMsgLeaderReturnToBase");
                DcsMessageTable.Add(4038, "wMsgLeaderGoRefueling");
                DcsMessageTable.Add(4039, "wMsgLeaderJoinUp");
                DcsMessageTable.Add(4040, "wMsgLeaderFlyRoute");
                DcsMessageTable.Add(4041, "wMsgLeaderMakeRecon");
                DcsMessageTable.Add(4042, "wMsgLeaderMakeReconAtPoint");
                DcsMessageTable.Add(4043, "wMsgLeaderRadarOn");
                DcsMessageTable.Add(4044, "wMsgLeaderRadarOff");
                DcsMessageTable.Add(4045, "wMsgLeaderDisturberOn");
                DcsMessageTable.Add(4046, "wMsgLeaderDisturberOff");
                DcsMessageTable.Add(4047, "wMsgLeaderSmokeOn");
                DcsMessageTable.Add(4048, "wMsgLeaderSmokeOff");
                DcsMessageTable.Add(4049, "wMsgLeaderJettisonWeapons");
                DcsMessageTable.Add(4050, "wMsgLeaderFenceIn");
                DcsMessageTable.Add(4051, "wMsgLeaderFenceOut");
                DcsMessageTable.Add(4052, "wMsgLeaderOut");
                DcsMessageTable.Add(4053, "wMsgLeaderLineAbreast");
                DcsMessageTable.Add(4054, "wMsgLeaderGoTrail");
                DcsMessageTable.Add(4055, "wMsgLeaderWedge");
                DcsMessageTable.Add(4056, "wMsgLeaderEchelonRight");
                DcsMessageTable.Add(4057, "wMsgLeaderEchelonLeft");
                DcsMessageTable.Add(4058, "wMsgLeaderFingerFour");
                DcsMessageTable.Add(4059, "wMsgLeaderSpreadFour");
                DcsMessageTable.Add(4060, "wMsgLeaderCloseFormation");
                DcsMessageTable.Add(4061, "wMsgLeaderOpenFormation");
                DcsMessageTable.Add(4062, "wMsgLeaderCloseGroupFormation");
                DcsMessageTable.Add(4063, "wMsgLeaderHelGoHeavy");
                DcsMessageTable.Add(4064, "wMsgLeaderHelGoEchelon");
                DcsMessageTable.Add(4065, "wMsgLeaderHelGoSpread");
                DcsMessageTable.Add(4066, "wMsgLeaderHelGoTrail");
                DcsMessageTable.Add(4067, "wMsgLeaderHelGoOverwatch");
                DcsMessageTable.Add(4068, "wMsgLeaderHelGoLeft");
                DcsMessageTable.Add(4069, "wMsgLeaderHelGoRight");
                DcsMessageTable.Add(4070, "wMsgLeaderHelGoTight");
                DcsMessageTable.Add(4071, "wMsgLeaderHelGoCruise");
                DcsMessageTable.Add(4072, "wMsgLeaderHelGoCombat");
                DcsMessageTable.Add(4073, "wMsgLeaderToWingmenMaximum");
                DcsMessageTable.Add(4074, "wMsgLeaderToServiceNull");
                DcsMessageTable.Add(4075, "wMsgLeaderToATCNull");
                DcsMessageTable.Add(4076, "wMsgLeaderRequestEnginesLaunch");
                DcsMessageTable.Add(4077, "wMsgLeaderRequestControlHover");
                DcsMessageTable.Add(4078, "wMsgLeaderRequestTaxiToRunway");
                DcsMessageTable.Add(4079, "wMsgLeaderRequestTakeOff");
                DcsMessageTable.Add(4080, "wMsgLeaderAbortTakeoff");
                DcsMessageTable.Add(4081, "wMsgLeaderRequestAzimuth");
                DcsMessageTable.Add(4082, "wMsgLeaderInbound");
                DcsMessageTable.Add(4083, "wMsgLeaderAbortInbound");
                DcsMessageTable.Add(4084, "wMsgLeaderRequestLanding");
                DcsMessageTable.Add(4085, "wMsgLeaderRequestTaxiForTakeoff");
                DcsMessageTable.Add(4086, "wMsgLeaderRequestTaxiToParking");
                DcsMessageTable.Add(4087, "wMsgLeaderTowerRequestTakeOff");
                DcsMessageTable.Add(4088, "wMsgLeaderInboundStraight");
                DcsMessageTable.Add(4089, "wMsgLeaderApproachOverhead");
                DcsMessageTable.Add(4090, "wMsgLeaderApproachStraight");
                DcsMessageTable.Add(4091, "wMsgLeaderApproachInstrument");
                DcsMessageTable.Add(4092, "wMsgLeaderToATCMaximum");
                DcsMessageTable.Add(4093, "wMsgLeaderToAWACSNull");
                DcsMessageTable.Add(4094, "wMsgLeaderVectorToBullseye");
                DcsMessageTable.Add(4095, "wMsgLeaderVectorToNearestBandit");
                DcsMessageTable.Add(4096, "wMsgLeaderVectorToHomeplate");
                DcsMessageTable.Add(4097, "wMsgLeaderVectorToTanker");
                DcsMessageTable.Add(4098, "wMsgLeaderDeclare");
                DcsMessageTable.Add(4099, "wMsgLeaderPicture");
                DcsMessageTable.Add(4100, "wMsgLeaderToAWACSMaximum");
                DcsMessageTable.Add(4101, "wMsgLeaderToTankerNull");
                DcsMessageTable.Add(4102, "wMsgLeaderIntentToRefuel");
                DcsMessageTable.Add(4103, "wMsgLeaderAbortRefueling");
                DcsMessageTable.Add(4104, "wMsgLeaderReadyPreContact");
                DcsMessageTable.Add(4105, "wMsgLeaderStopRefueling");
                DcsMessageTable.Add(4106, "wMsgLeaderToTankerMaximum");
                DcsMessageTable.Add(4107, "wMsgLeaderToFACNull");
                DcsMessageTable.Add(4108, "wMsgLeaderCheckIn");
                DcsMessageTable.Add(4109, "wMsgLeaderCheckOut");
                DcsMessageTable.Add(4110, "wMsgLeaderReadyToCopy");
                DcsMessageTable.Add(4111, "wMsgLeaderReadyToCopyRemarks");
                DcsMessageTable.Add(4112, "wMsgLeader9LineReadback");
                DcsMessageTable.Add(4113, "wMsgLeaderRequestTasking");
                DcsMessageTable.Add(4114, "wMsgLeaderRequestBDA");
                DcsMessageTable.Add(4115, "wMsgLeaderRequestTargetDescription");
                DcsMessageTable.Add(4116, "wMsgLeaderUnableToComply");
                DcsMessageTable.Add(4117, "wMsgLeaderFACRepeat");
                DcsMessageTable.Add(4118, "wMsgLeader_IP_INBOUND");
                DcsMessageTable.Add(4119, "wMsgLeader_ONE_MINUTE");
                DcsMessageTable.Add(4120, "wMsgLeader_IN");
                DcsMessageTable.Add(4121, "wMsgLeader_OFF");
                DcsMessageTable.Add(4122, "wMsgLeader_ATTACK_COMPLETE");
                DcsMessageTable.Add(4123, "wMsgLeaderAdviseWhenReadyToCopyBDA");
                DcsMessageTable.Add(4124, "wMsgLeaderContact");
                DcsMessageTable.Add(4125, "wMsgLeader_NO_JOY");
                DcsMessageTable.Add(4126, "wMsgLeader_CONTACT_the_mark");
                DcsMessageTable.Add(4127, "wMsgLeader_SPARKLE");
                DcsMessageTable.Add(4128, "wMsgLeader_SNAKE");
                DcsMessageTable.Add(4129, "wMsgLeader_PULSE");
                DcsMessageTable.Add(4130, "wMsgLeader_STEADY");
                DcsMessageTable.Add(4131, "wMsgLeader_ROPE");
                DcsMessageTable.Add(4132, "wMsgLeader_CONTACT_SPARKLE");
                DcsMessageTable.Add(4133, "wMsgLeader_STOP");
                DcsMessageTable.Add(4134, "wMsgLeader_TEN_SECONDS");
                DcsMessageTable.Add(4135, "wMsgLeader_LASER_ON");
                DcsMessageTable.Add(4136, "wMsgLeader_SHIFT");
                DcsMessageTable.Add(4137, "wMsgLeader_SPOT");
                DcsMessageTable.Add(4138, "wMsgLeader_TERMINATE");
                DcsMessageTable.Add(4139, "wMsgLeaderGuns");
                DcsMessageTable.Add(4140, "wMsgLeaderBombsAway");
                DcsMessageTable.Add(4141, "wMsgLeaderRIFLE");
                DcsMessageTable.Add(4142, "wMsgLeaderRockets");
                DcsMessageTable.Add(4143, "wMsgLeaderBDA");
                DcsMessageTable.Add(4144, "wMsgLeaderINFLIGHTREP");
                DcsMessageTable.Add(4145, "wMsgLeaderToFACMaximum");
                DcsMessageTable.Add(4146, "wMsgLeaderToGroundCrewNull");
                DcsMessageTable.Add(4147, "wMsgLeaderSpecialCommand");
                DcsMessageTable.Add(4148, "wMsgLeaderRequestRefueling");
                DcsMessageTable.Add(4149, "wMsgLeaderRequestCannonReloading");
                DcsMessageTable.Add(4150, "wMsgLeaderRequestRearming");
                DcsMessageTable.Add(4151, "wMsgLeaderGroundToggleElecPower");
                DcsMessageTable.Add(4152, "wMsgLeaderGroundToggleWheelChocks");
                DcsMessageTable.Add(4153, "wMsgLeaderGroundToggleCanopy");
                DcsMessageTable.Add(4154, "wMsgLeaderGroundToggleAir");
                DcsMessageTable.Add(4155, "wMsgLeaderGroundApplyAir");
                DcsMessageTable.Add(4156, "wMsgLeaderGroundRepair");
                DcsMessageTable.Add(4157, "wMsgLeaderGroundGestureSalut");
                DcsMessageTable.Add(4158, "wMsgLeaderGroundRequestLaunch");
                DcsMessageTable.Add(4159, "wMsgLeaderToGroundCrewMaximum");
                DcsMessageTable.Add(4160, "wMsgLeaderToServiceMaximum");
                DcsMessageTable.Add(4161, "wMsgLeaderMaximum");
                DcsMessageTable.Add(4162, "wMsgLeaderToNavyATCNull");
                DcsMessageTable.Add(4163, "wMsgLeaderInboundCarrier");
                DcsMessageTable.Add(4164, "wMsgLeaderConfirm");
                DcsMessageTable.Add(4165, "wMsgLeaderConfirmRemainingFuel");
                DcsMessageTable.Add(4166, "wMsgLeaderInboundMarshallRespond");
                DcsMessageTable.Add(4167, "wMsgLeaderEstablished");
                DcsMessageTable.Add(4168, "wMsgLeaderCommencing");
                DcsMessageTable.Add(4169, "wMsgLeaderCheckingIn");
                DcsMessageTable.Add(4170, "wMsgLeaderPlatform");
                DcsMessageTable.Add(4171, "wMsgLeaderSayNeedle");
                DcsMessageTable.Add(4172, "wMsgLeaderSeeYouAtTen");
                DcsMessageTable.Add(4173, "wMsgLeaderHornetBall");
                DcsMessageTable.Add(4174, "wMsgLeaderCLARA");
                DcsMessageTable.Add(4175, "wMsgLeaderBall");
                DcsMessageTable.Add(4176, "wMsgLeaderTowerOverhead");
                DcsMessageTable.Add(4177, "wMsgLeaderFlightKissOff");
                DcsMessageTable.Add(4178, "wMsgLeaderAirborn");
                DcsMessageTable.Add(4179, "wMsgLeaderPassing2_5Kilo");
                DcsMessageTable.Add(4180, "wMsgLeaderToNavyATCMaximum");
                DcsMessageTable.Add(4181, "wMsgWingmenNull");
                DcsMessageTable.Add(4182, "wMsgWingmenCopy");
                DcsMessageTable.Add(4183, "wMsgWingmenNegative");
                DcsMessageTable.Add(4184, "wMsgWingmenFlightCheckInPositive");
                DcsMessageTable.Add(4185, "wMsgWingmenHelReconBearing");
                DcsMessageTable.Add(4186, "wMsgWingmenHelReconEndFound");
                DcsMessageTable.Add(4187, "wMsgWingmenHelReconEndNotFound");
                DcsMessageTable.Add(4188, "wMsgWingmenHelLaunchAbortTask");
                DcsMessageTable.Add(4189, "wMsgWingmenRadarContact");
                DcsMessageTable.Add(4190, "wMsgWingmenContact");
                DcsMessageTable.Add(4191, "wMsgWingmenTallyBandit");
                DcsMessageTable.Add(4192, "wMsgWingmenNails");
                DcsMessageTable.Add(4193, "wMsgWingmenSpike");
                DcsMessageTable.Add(4194, "wMsgWingmenMudSpike");
                DcsMessageTable.Add(4195, "wMsgWingmenIamHit");
                DcsMessageTable.Add(4196, "wMsgWingmenIveTakenDamage");
                DcsMessageTable.Add(4197, "wMsgWingmenEjecting");
                DcsMessageTable.Add(4198, "wMsgWingmenBailOut");
                DcsMessageTable.Add(4199, "wMsgWingmenWheelsUp");
                DcsMessageTable.Add(4200, "wMsgWingmenHelOccupFormLeft");
                DcsMessageTable.Add(4201, "wMsgWingmenHelOccupFormRight");
                DcsMessageTable.Add(4202, "wMsgWingmenHelOccupFormBehind");
                DcsMessageTable.Add(4203, "wMsgWingmenOnPosition");
                DcsMessageTable.Add(4204, "wMsgWingmenGuns");
                DcsMessageTable.Add(4205, "wMsgWingmenFoxFrom");
                DcsMessageTable.Add(4206, "wMsgWingmenFox1");
                DcsMessageTable.Add(4207, "wMsgWingmenFox2");
                DcsMessageTable.Add(4208, "wMsgWingmenFox3");
                DcsMessageTable.Add(4209, "wMsgWingmenBombsAway");
                DcsMessageTable.Add(4210, "wMsgWingmenGBUAway");
                DcsMessageTable.Add(4211, "wMsgWingmenMagnum");
                DcsMessageTable.Add(4212, "wMsgWingmenMissileAway");
                DcsMessageTable.Add(4213, "wMsgWingmenRifle");
                DcsMessageTable.Add(4214, "wMsgWingmenBruiser");
                DcsMessageTable.Add(4215, "wMsgWingmenRockets");
                DcsMessageTable.Add(4216, "wMsgWingmenSmoke");
                DcsMessageTable.Add(4217, "wMsgWingmenRadarOff");
                DcsMessageTable.Add(4218, "wMsgWingmenRadarOn");
                DcsMessageTable.Add(4219, "wMsgWingmenMusicOff");
                DcsMessageTable.Add(4220, "wMsgWingmenMusicOn");
                DcsMessageTable.Add(4221, "wMsgWingmenBingo");
                DcsMessageTable.Add(4222, "wMsgWingmenKansas");
                DcsMessageTable.Add(4223, "wMsgWingmenWinchester");
                DcsMessageTable.Add(4224, "wMsgWingmenRolling");
                DcsMessageTable.Add(4225, "wMsgWingmenRollingTaxi");
                DcsMessageTable.Add(4226, "wMsgWingmenRTB");
                DcsMessageTable.Add(4227, "wMsgWingmenBugout");
                DcsMessageTable.Add(4228, "wMsgWingmenRejoin");
                DcsMessageTable.Add(4229, "wMsgWingmenFollowScanMode");
                DcsMessageTable.Add(4230, "wMsgWingmenAttackingPrimary");
                DcsMessageTable.Add(4231, "wMsgWingmenEngagingBandit");
                DcsMessageTable.Add(4232, "wMsgWingmenEngagingHelicopter");
                DcsMessageTable.Add(4233, "wMsgWingmenEngagingSAM");
                DcsMessageTable.Add(4234, "wMsgWingmenEngagingAAA");
                DcsMessageTable.Add(4235, "wMsgWingmenEngagingArmor");
                DcsMessageTable.Add(4236, "wMsgWingmenEngagingArtillery");
                DcsMessageTable.Add(4237, "wMsgWingmenEngagingVehicle");
                DcsMessageTable.Add(4238, "wMsgWingmenEngagingShip");
                DcsMessageTable.Add(4239, "wMsgWingmenEngagingBunker");
                DcsMessageTable.Add(4240, "wMsgWingmenEngagingStructure");
                DcsMessageTable.Add(4241, "wMsgWingmenRunningIn");
                DcsMessageTable.Add(4242, "wMsgWingmenRunningOff");
                DcsMessageTable.Add(4243, "wMsgWingmenBanditDestroyed");
                DcsMessageTable.Add(4244, "wMsgWingmenTargetDestroyed");
                DcsMessageTable.Add(4245, "wMsgWingmenEngagedDefensive");
                DcsMessageTable.Add(4246, "wMsgWingmenRequestPermissionToAttack");
                DcsMessageTable.Add(4247, "wMsgWingmenSplashMyBandit");
                DcsMessageTable.Add(4248, "wMsgWingmenSAMLaunch");
                DcsMessageTable.Add(4249, "wMsgWingmenMissileLaunch");
                DcsMessageTable.Add(4250, "wMsgWingmenCheckYourSix");
                DcsMessageTable.Add(4251, "wMsgWingmenMaximum");
                DcsMessageTable.Add(4252, "wMsgFlightNull");
                DcsMessageTable.Add(4253, "wMsgFlightAirbone");
                DcsMessageTable.Add(4254, "wMsgFlightPassingWaypoint");
                DcsMessageTable.Add(4255, "wMsgFlightOnStation");
                DcsMessageTable.Add(4256, "wMsgFlightDepartingStation");
                DcsMessageTable.Add(4257, "wMsgFlightRTB");
                DcsMessageTable.Add(4258, "wMsgFlightTallyBandit");
                DcsMessageTable.Add(4259, "wMsgFlightTally");
                DcsMessageTable.Add(4260, "wMsgFlightEngagingBandit");
                DcsMessageTable.Add(4261, "wMsgFlightEngaging");
                DcsMessageTable.Add(4262, "wMsgFlightSplashBandit");
                DcsMessageTable.Add(4263, "wMsgFlightTargetDestroyed");
                DcsMessageTable.Add(4264, "wMsgFlightDefensive");
                DcsMessageTable.Add(4265, "wMsgFlightMemberDown");
                DcsMessageTable.Add(4266, "wMsgFlightAerobaticTurnPreStart");
                DcsMessageTable.Add(4267, "wMsgFlightAerobaticTurnStart");
                DcsMessageTable.Add(4268, "wMsgFlightAerobaticTurnStop");
                DcsMessageTable.Add(4269, "wMsgFlightMaximum");
                DcsMessageTable.Add(4270, "wMsgServiceNull");
                DcsMessageTable.Add(4271, "wMsgATCNull");
                DcsMessageTable.Add(4272, "wMsgATCClearedForEngineStartUp");
                DcsMessageTable.Add(4273, "wMsgATCEngineStartUpDenied");
                DcsMessageTable.Add(4274, "wMsgATCClearedToTaxiRunWay");
                DcsMessageTable.Add(4275, "wMsgATCTaxiDenied");
                DcsMessageTable.Add(4276, "wMsgATCHoldPosition");
                DcsMessageTable.Add(4277, "wMsgATCYouAreClearedForTO");
                DcsMessageTable.Add(4278, "wMsgATCTakeoffDenied");
                DcsMessageTable.Add(4279, "wMsgATCYouHadTakenOffWithNoPermission");
                DcsMessageTable.Add(4280, "wMsgATCTrafficBearing");
                DcsMessageTable.Add(4281, "wMsgATCYouAreClearedForLanding");
                DcsMessageTable.Add(4282, "wMsgATCYouAreAboveGlidePath");
                DcsMessageTable.Add(4283, "wMsgATCYouAreOnGlidePath");
                DcsMessageTable.Add(4284, "wMsgATCYouAreBelowGlidePath");
                DcsMessageTable.Add(4285, "wMsgATCTaxiToParkingArea");
                DcsMessageTable.Add(4286, "wMsgATCGoAround");
                DcsMessageTable.Add(4287, "wMsgATCContinueTaxi");
                DcsMessageTable.Add(4288, "wMsgATCOrbitForSpacing");
                DcsMessageTable.Add(4289, "wMsgATCClearedForVisual");
                DcsMessageTable.Add(4290, "wMsgATCFlyHeading");
                DcsMessageTable.Add(4291, "wMsgATCAzimuth");
                DcsMessageTable.Add(4292, "wMsgATCGoSecondary");
                DcsMessageTable.Add(4293, "wMsgATCClearedControlHover");
                DcsMessageTable.Add(4294, "wMsgATCControlHoverDenied");
                DcsMessageTable.Add(4295, "wMsgATCCheckLandingGear");
                DcsMessageTable.Add(4296, "wMsgATCFlightCheckIn");
                DcsMessageTable.Add(4297, "wMsgATCMaximum");
                DcsMessageTable.Add(4298, "wMsgATCNAVYDepartureNull");
                DcsMessageTable.Add(4299, "wMsgATCDepartureRadarContact");
                DcsMessageTable.Add(4300, "wMsgATCDepartureClearedToSwitch");
                DcsMessageTable.Add(4301, "wMsgATCNAVYDepartureMaximum");
                DcsMessageTable.Add(4302, "wMsgATCNAVYMarshalNull");
                DcsMessageTable.Add(4303, "wMsgATCMarshallCopyInbound");
                DcsMessageTable.Add(4304, "wMsgATCMarshallCopyTen");
                DcsMessageTable.Add(4305, "wMsgATCMarshallCopyInbound2and3");
                DcsMessageTable.Add(4306, "wMsgATCMarshallReadbackCorrect");
                DcsMessageTable.Add(4307, "wMsgATCMarshallRogerState");
                DcsMessageTable.Add(4308, "wMsgATCMarshallCopyCommencing");
                DcsMessageTable.Add(4309, "wMsgATCMarshallSwitchApproach");
                DcsMessageTable.Add(4310, "wMsgATCNAVYMarshalMaximum");
                DcsMessageTable.Add(4311, "wMsgATCNAVYApproachTowerNull");
                DcsMessageTable.Add(4312, "wMsgATCTowerCopyOverhead");
                DcsMessageTable.Add(4313, "wMsgATCTowerFinalBearing");
                DcsMessageTable.Add(4314, "wMsgATCTowerRoger");
                DcsMessageTable.Add(4315, "wMsgATCTowerFlyBullseye");
                DcsMessageTable.Add(4316, "wMsgATCTowerFinalContact");
                DcsMessageTable.Add(4317, "wMsgATCTowerSayNeedles");
                DcsMessageTable.Add(4318, "wMsgATCTowerConcurFlyMode2");
                DcsMessageTable.Add(4319, "wMsgATCTowerApproachGlidepath");
                DcsMessageTable.Add(4320, "wMsgATCTowerCallTheBall");
                DcsMessageTable.Add(4321, "wMsgATCTowerSwitchMenu");
                DcsMessageTable.Add(4322, "wMsgATCNAVYApproachTowerMaximum");
                DcsMessageTable.Add(4323, "wMsgATCNAVYLSONull");
                DcsMessageTable.Add(4324, "wMsgATCLSORogerBall");
                DcsMessageTable.Add(4325, "wMsgATCLSOInGlideslopeBall");
                DcsMessageTable.Add(4326, "wMsgATCLSOOutOfGlideslopeClara");
                DcsMessageTable.Add(4327, "wMsgATCLSOWaveOFFGear");
                DcsMessageTable.Add(4328, "wMsgATCLSOWaveOFFFlaps");
                DcsMessageTable.Add(4329, "wMsgATCLSOWaveOFFWaveOFFWaveOFF");
                DcsMessageTable.Add(4330, "wMsgATCLSOYoureHigh");
                DcsMessageTable.Add(4331, "wMsgATCLSOYoureLow");
                DcsMessageTable.Add(4332, "wMsgATCLSOYoureGoingHigh");
                DcsMessageTable.Add(4333, "wMsgATCLSOYoureGoingLow");
                DcsMessageTable.Add(4334, "wMsgATCLSOLinedUpLeft");
                DcsMessageTable.Add(4335, "wMsgATCLSOLinedUpRight");
                DcsMessageTable.Add(4336, "wMsgATCLSODriftingLeft");
                DcsMessageTable.Add(4337, "wMsgATCLSODriftingRight");
                DcsMessageTable.Add(4338, "wMsgATCLSOYoureFast");
                DcsMessageTable.Add(4339, "wMsgATCLSOYoureSlow");
                DcsMessageTable.Add(4340, "wMsgATCLSOEasyNose");
                DcsMessageTable.Add(4341, "wMsgATCLSOEasyWings");
                DcsMessageTable.Add(4342, "wMsgATCLSOEasyIt");
                DcsMessageTable.Add(4343, "wMsgATCLSOYoureHighClose");
                DcsMessageTable.Add(4344, "wMsgATCLSOPower");
                DcsMessageTable.Add(4345, "wMsgATCLSOPowerX2");
                DcsMessageTable.Add(4346, "wMsgATCLSOPowerX3");
                DcsMessageTable.Add(4347, "wMsgATCLSOEasyItX2");
                DcsMessageTable.Add(4348, "wMsgATCLSORight4LineUp");
                DcsMessageTable.Add(4349, "wMsgATCLSOLeft4LineUp");
                DcsMessageTable.Add(4350, "wMsgATCLSOFoulDeck");
                DcsMessageTable.Add(4351, "wMsgATCLSOBolterX3");
                DcsMessageTable.Add(4352, "wMsgATCLSOYoureLittleHigh");
                DcsMessageTable.Add(4353, "wMsgATCLSOYoureLittleLow");
                DcsMessageTable.Add(4354, "wMsgATCLSOLittleRight4LineUp");
                DcsMessageTable.Add(4355, "wMsgATCLSOLittleLeft4LineUp");
                DcsMessageTable.Add(4356, "wMsgATCLSOFlyTheBall");
                DcsMessageTable.Add(4357, "wMsgATCLSOOnGlideslope");
                DcsMessageTable.Add(4358, "wMsgATCLSOOnCenterLine");
                DcsMessageTable.Add(4359, "wMsgATCLSOEaseGuns");
                DcsMessageTable.Add(4360, "wMsgATCYouAreNotAuthorised");
                DcsMessageTable.Add(4361, "wMsgATCNAVYLSOMaximum");
                DcsMessageTable.Add(4362, "wMsgAWACSNull");
                DcsMessageTable.Add(4363, "wMsgAWACSVectorToBullseye");
                DcsMessageTable.Add(4364, "wMsgAWACSBanditBearingForMiles");
                DcsMessageTable.Add(4365, "wMsgAWACSVectorToNearestBandit");
                DcsMessageTable.Add(4366, "wMsgAWACSPopUpGroup");
                DcsMessageTable.Add(4367, "wMsgAWACSHomeBearing");
                DcsMessageTable.Add(4368, "wMsgAWACSTankerBearing");
                DcsMessageTable.Add(4369, "wMsgAWACSContactIsFriendly");
                DcsMessageTable.Add(4370, "wMsgAWACSContactIsHostile");
                DcsMessageTable.Add(4371, "wMsgAWACSClean");
                DcsMessageTable.Add(4372, "wMsgAWACSMerged");
                DcsMessageTable.Add(4373, "wMsgAWACSNoTankerAvailable");
                DcsMessageTable.Add(4374, "wMsgAWACSPicture");
                DcsMessageTable.Add(4375, "wMsgAWACSMaximum");
                DcsMessageTable.Add(4376, "wMsgTankerNull");
                DcsMessageTable.Add(4377, "wMsgTankerClearedPreContact");
                DcsMessageTable.Add(4378, "wMsgTankerClearedContact");
                DcsMessageTable.Add(4379, "wMsgTankerContact");
                DcsMessageTable.Add(4380, "wMsgTankerReturnPreContact");
                DcsMessageTable.Add(4381, "wMsgTankerChicksInTow");
                DcsMessageTable.Add(4382, "wMsgTankerFuelFlow");
                DcsMessageTable.Add(4383, "wMsgTankerRefuelingComplete");
                DcsMessageTable.Add(4384, "wMsgTankerDisconnectNow");
                DcsMessageTable.Add(4385, "wMsgTankerBreakawayBreakaway");
                DcsMessageTable.Add(4386, "wMsgTankerMaximum");
                DcsMessageTable.Add(4387, "wMsgFACNull");
                DcsMessageTable.Add(4388, "wMsgFAC_CONTINUE");
                DcsMessageTable.Add(4389, "wMsgFAC_ABORT");
                DcsMessageTable.Add(4390, "wMsgFAC_ABORT_ATTACK");
                DcsMessageTable.Add(4391, "wMsgFAC_CLERED_HOT");
                DcsMessageTable.Add(4392, "wMsgFAC_CLEARED_TO_ENGAGE");
                DcsMessageTable.Add(4393, "wMsgFAC_CLEARED_TO_DEPART");
                DcsMessageTable.Add(4394, "wMsgFACNoTaskingAvailableStandBy");
                DcsMessageTable.Add(4395, "wMsgFACNoTaskingAvailable");
                DcsMessageTable.Add(4396, "wMsgFACType1InEffectAdviseWhenReadyFor9Line");
                DcsMessageTable.Add(4397, "wMsgFACType2InEffectAdviseWhenReadyFor9Line");
                DcsMessageTable.Add(4398, "wMsgFACType3InEffectAdviseWhenReadyFor9Line");
                DcsMessageTable.Add(4399, "wMsgFACAdviseWhenReadyForRemarksAndFutherTalkOn");
                DcsMessageTable.Add(4400, "wMsgFACStandbyForData");
                DcsMessageTable.Add(4401, "wMsgFACReadBackCorrect");
                DcsMessageTable.Add(4402, "wMsgFACNoTaskingAvailableClearedToDepart");
                DcsMessageTable.Add(4403, "wMsgFACReport_IP_INBOUND");
                DcsMessageTable.Add(4404, "wMsgFACReportWhenAttackComplete");
                DcsMessageTable.Add(4405, "wMsgFACThatIsYourTarget");
                DcsMessageTable.Add(4406, "wMsgFACThatIsNotYourTarget");
                DcsMessageTable.Add(4407, "wMsgFACThatIsFriendly");
                DcsMessageTable.Add(4408, "wMsgFACYourTarget");
                DcsMessageTable.Add(4409, "wMsgFAC9lineBrief");
                DcsMessageTable.Add(4410, "wMsgFAC9lineBriefWP");
                DcsMessageTable.Add(4411, "wMsgFAC9lineBriefWPLaser");
                DcsMessageTable.Add(4412, "wMsgFAC9lineBriefIRPointer");
                DcsMessageTable.Add(4413, "wMsgFAC9lineBriefLaser");
                DcsMessageTable.Add(4414, "wMsgFAC9lineRemarks");
                DcsMessageTable.Add(4415, "wMsgFACTargetDescription");
                DcsMessageTable.Add(4416, "wMsgFACTargetHit");
                DcsMessageTable.Add(4417, "wMsgFACTargetDestroyed");
                DcsMessageTable.Add(4418, "wMsgFACTargetPartiallyDestroyed");
                DcsMessageTable.Add(4419, "wMsgFACTargetNotDestroyed");
                DcsMessageTable.Add(4420, "wMsgUseWeapon");
                DcsMessageTable.Add(4421, "wMsgFACMarkOnDeck");
                DcsMessageTable.Add(4422, "wMsgFACFromTheMark");
                DcsMessageTable.Add(4423, "wMsgFAC_SPARKLE");
                DcsMessageTable.Add(4424, "wMsgFAC_SNAKE");
                DcsMessageTable.Add(4425, "wMsgFAC_PULSE");
                DcsMessageTable.Add(4426, "wMsgFAC_STEADY");
                DcsMessageTable.Add(4427, "wMsgFAC_STOP");
                DcsMessageTable.Add(4428, "wMsgFAC_ROPE");
                DcsMessageTable.Add(4429, "wMsgFAC_LASER_ON");
                DcsMessageTable.Add(4430, "wMsgFAC_LASING");
                DcsMessageTable.Add(4431, "wMsgFAC_SHIFT");
                DcsMessageTable.Add(4432, "wMsgFAC_TERMINATE");
                DcsMessageTable.Add(4433, "wMsgFAC_NoMark");
                DcsMessageTable.Add(4434, "wMsgFAC_SAM_launch");
                DcsMessageTable.Add(4435, "wMsgFACAreYouReadyToCopy");
                DcsMessageTable.Add(4436, "wMsgFACWhereAreYouGoing");
                DcsMessageTable.Add(4437, "wMsgFACDoYouSeeTheMark");
                DcsMessageTable.Add(4438, "wMsgFACMaximum");
                DcsMessageTable.Add(4439, "wMsgCCCNull");
                DcsMessageTable.Add(4440, "wMsgCCCFollowTo");
                DcsMessageTable.Add(4441, "wMsgCCCTasking");
                DcsMessageTable.Add(4442, "wMsgCCCResume");
                DcsMessageTable.Add(4443, "wMsgCCCRTB");
                DcsMessageTable.Add(4444, "wMsgCCCMaximum");
                DcsMessageTable.Add(4445, "wMsgGroundCrewNull");
                DcsMessageTable.Add(4446, "wMsgGroundCrewCopy");
                DcsMessageTable.Add(4447, "wMsgGroundCrewNegative");
                DcsMessageTable.Add(4448, "wMsgGroundCrewReloadDone");
                DcsMessageTable.Add(4449, "wMsgGroundCrewRefuelDone");
                DcsMessageTable.Add(4450, "wMsgGroundCrewHMSDone");
                DcsMessageTable.Add(4451, "wMsgGroundCrewNVGDone");
                DcsMessageTable.Add(4452, "wMsgGroundCrewGroundPowerOn");
                DcsMessageTable.Add(4453, "wMsgGroundCrewGroundPowerOff");
                DcsMessageTable.Add(4454, "wMsgGroundCrewWheelChocksOn");
                DcsMessageTable.Add(4455, "wMsgGroundCrewWheelChocksOff");
                DcsMessageTable.Add(4456, "wMsgGroundCrewCanopyOpenes");
                DcsMessageTable.Add(4457, "wMsgGroundCrewCanopyCloses");
                DcsMessageTable.Add(4458, "wMsgGroundCrewGroundAirOn");
                DcsMessageTable.Add(4459, "wMsgGroundCrewGroundAirOff");
                DcsMessageTable.Add(4460, "wMsgGroundCrewGroundAirDone");
                DcsMessageTable.Add(4461, "wMsgGroundCrewGroundAirFailed");
                DcsMessageTable.Add(4462, "wMsgGroundCrewTurboGearOn");
                DcsMessageTable.Add(4463, "wMsgGroundCrewTurboGearOff");
                DcsMessageTable.Add(4464, "wMsgGroundDone");
                DcsMessageTable.Add(4465, "wMsgGroundCrewStop");
                DcsMessageTable.Add(4466, "wMsgGroundCrewClear");
                DcsMessageTable.Add(4467, "wMsgGroundCrewNegativeAircraftOnTheMove");
                DcsMessageTable.Add(4468, "wMsgGroundCrewNegativeShutDownAircraft");
                DcsMessageTable.Add(4469, "wMsgGroundCrewNegativeBringDownEngines");
                DcsMessageTable.Add(4470, "wMsgGroundCrewNegativeShutDownEngines");
                DcsMessageTable.Add(4471, "wMsgGroundCrewNegativeFireHazard");
                DcsMessageTable.Add(4472, "wMsgGroundCrewNegativeSystemDamaged");
                DcsMessageTable.Add(4473, "wMsgGroundCrewNegativeNoAccessToCabin");
                DcsMessageTable.Add(4474, "wMsgGroundCrewNegativeNoAccessToSystem");
                DcsMessageTable.Add(4475, "wMsgGroundCrewNegativeNoResources");
                DcsMessageTable.Add(4476, "wMsgGroundCrewNegativeAlreadyDone");
                DcsMessageTable.Add(4477, "wMsgGroundCrewNegativeCrewUnderFire");
                DcsMessageTable.Add(4478, "wMsgGroundCrewNegativeUnfeasibleConfiguration");
                DcsMessageTable.Add(4479, "wMsgGroundCrewMaximum");
                DcsMessageTable.Add(4480, "wMsgServiceMaximum");
                DcsMessageTable.Add(4481, "wMsgBettyNull");
                DcsMessageTable.Add(4482, "wMsgBettyLeftEngineFire");
                DcsMessageTable.Add(4483, "wMsgBettyRightEngineFire");
                DcsMessageTable.Add(4484, "wMsgBettyMaximumAOA");
                DcsMessageTable.Add(4485, "wMsgBettyAOAOverLimit");
                DcsMessageTable.Add(4486, "wMsgBettyMaximumG");
                DcsMessageTable.Add(4487, "wMsgBettyGearDown");
                DcsMessageTable.Add(4488, "wMsgBettyGearUp");
                DcsMessageTable.Add(4489, "wMsgBettyMaximumSpeed");
                DcsMessageTable.Add(4490, "wMsgBettyMinimumSpeed");
                DcsMessageTable.Add(4491, "wMsgBettyMissile3Low");
                DcsMessageTable.Add(4492, "wMsgBettyMissile3High");
                DcsMessageTable.Add(4493, "wMsgBettyMissile6Low");
                DcsMessageTable.Add(4494, "wMsgBettyMissile6High");
                DcsMessageTable.Add(4495, "wMsgBettyMissile9Low");
                DcsMessageTable.Add(4496, "wMsgBettyMissile9High");
                DcsMessageTable.Add(4497, "wMsgBettyMissile12Low");
                DcsMessageTable.Add(4498, "wMsgBettyMissile12High");
                DcsMessageTable.Add(4499, "wMsgBettyBingoFuel");
                DcsMessageTable.Add(4500, "wMsgBettyAttitudeIndicatorFailure");
                DcsMessageTable.Add(4501, "wMsgBettyRadarFailure");
                DcsMessageTable.Add(4502, "wMsgBettyEOSFailure");
                DcsMessageTable.Add(4503, "wMsgBettySystemsFailure");
                DcsMessageTable.Add(4504, "wMsgBettyTWSFailure");
                DcsMessageTable.Add(4505, "wMsgBettyMLWSFailure");
                DcsMessageTable.Add(4506, "wMsgBettyECMFailure");
                DcsMessageTable.Add(4507, "wMsgBettyNCSFailure");
                DcsMessageTable.Add(4508, "wMsgBettyACSFailure");
                DcsMessageTable.Add(4509, "wMsgBettyThrottleBackLeftEngine");
                DcsMessageTable.Add(4510, "wMsgBettyThrottleBackRightEngine");
                DcsMessageTable.Add(4511, "wMsgBettyPower");
                DcsMessageTable.Add(4512, "wMsgBettyHydrolicsFailure");
                DcsMessageTable.Add(4513, "wMsgBettyEject");
                DcsMessageTable.Add(4514, "wMsgBettyGOverLimit");
                DcsMessageTable.Add(4515, "wMsgBettyFuel1500");
                DcsMessageTable.Add(4516, "wMsgBettyFuel800");
                DcsMessageTable.Add(4517, "wMsgBettyFuel500");
                DcsMessageTable.Add(4518, "wMsgBettyPullUp");
                DcsMessageTable.Add(4519, "wMsgBettyLaunchAuthorised");
                DcsMessageTable.Add(4520, "wMsgBettyMissileMissile");
                DcsMessageTable.Add(4521, "wMsgBettyShootShoot");
                DcsMessageTable.Add(4522, "wMsgBettyFlightControls");
                DcsMessageTable.Add(4523, "wMsgBettyWarningWarning");
                DcsMessageTable.Add(4524, "wMsgBettyMessageBegin");
                DcsMessageTable.Add(4525, "wMsgBettyMessageEnd");
                DcsMessageTable.Add(4526, "wMsgBettyGearDownSingle");
                DcsMessageTable.Add(4527, "wMsgBettyCancel");
                DcsMessageTable.Add(4528, "wMsgBettyTakeManualControl");
                DcsMessageTable.Add(4529, "wMsgBettyMaximum");
                DcsMessageTable.Add(4530, "wMsgALMAZ_Null");
                DcsMessageTable.Add(4531, "wMsgALMAZ_IS_READY");
                DcsMessageTable.Add(4532, "wMsgALMAZ_WATCH_EKRAN");
                DcsMessageTable.Add(4533, "wMsgALMAZ_THREAT");
                DcsMessageTable.Add(4534, "wMsgALMAZ_CHECK_OIL_PRESS_LEFT_TRANSM");
                DcsMessageTable.Add(4535, "wMsgALMAZ_CHECK_OIL_PRESS_RIGHT_TRANSM");
                DcsMessageTable.Add(4536, "wMsgALMAZ_LEFT_ENG_FIRE");
                DcsMessageTable.Add(4537, "wMsgALMAZ_RIGHT_ENG_FIRE");
                DcsMessageTable.Add(4538, "wMsgALMAZ_APU_FIRE");
                DcsMessageTable.Add(4539, "wMsgALMAZ_HYDRO_FIRE");
                DcsMessageTable.Add(4540, "wMsgALMAZ_FAN_FIRE");
                DcsMessageTable.Add(4541, "wMsgALMAZ_LEFT_ENG_TORQUE");
                DcsMessageTable.Add(4542, "wMsgALMAZ_RIGHT_ENG_TORQUE");
                DcsMessageTable.Add(4543, "wMsgALMAZ_DANGER_ENG_VIBR");
                DcsMessageTable.Add(4544, "wMsgALMAZ_DATA");
                DcsMessageTable.Add(4545, "wMsgALMAZ_MAIN_HYDRO");
                DcsMessageTable.Add(4546, "wMsgALMAZ_COMMON_HYDRO");
                DcsMessageTable.Add(4547, "wMsgALMAZ_LOWER_GEAR");
                DcsMessageTable.Add(4548, "wMsgALMAZ_CHECK_MAIN_TRANSM");
                DcsMessageTable.Add(4549, "wMsgALMAZ_TURN_ON_BACKUP_TRANSP");
                DcsMessageTable.Add(4550, "wMsgALMAZ_ELEC_ON_ACCUM");
                DcsMessageTable.Add(4551, "wMsgALMAZ_USE_TV");
                DcsMessageTable.Add(4552, "wMsgALMAZ_USE_MANUAL_ATTACK_KI_TV");
                DcsMessageTable.Add(4553, "wMsgALMAZ_FAILURE_WCS_ROCKET");
                DcsMessageTable.Add(4554, "wMsgALMAZ_GUN_ACTUATOR_FAILURE");
                DcsMessageTable.Add(4555, "wMsgALMAZ_MIN_FUEL");
                DcsMessageTable.Add(4556, "wMsgALMAZ_TURN_ON_ROTOR_ANTIICE");
                DcsMessageTable.Add(4557, "wMsgALMAZ_RADIO_ALT");
                DcsMessageTable.Add(4558, "wMsgALMAZ_INS");
                DcsMessageTable.Add(4559, "wMsgALMAZ_TURN_ON_GRID_USE_FIXED_GUN");
                DcsMessageTable.Add(4560, "wMsgALMAZ_TURN_ON_DC_AC_CONVERT");
                DcsMessageTable.Add(4561, "wMsgALMAZ_CHECK_LEFT_TRANSM");
                DcsMessageTable.Add(4562, "wMsgALMAZ_CHECK_RIGHT_TRANSM");
                DcsMessageTable.Add(4563, "wMsgALMAZ_ACTUATOR_OIL_PRESSURE");
                DcsMessageTable.Add(4564, "wMsgALMAZ_FAILURE_LEFT_PROBE_HEATER");
                DcsMessageTable.Add(4565, "wMsgALMAZ_FAILURE_RIGHT_PROBE_HEATER");
                DcsMessageTable.Add(4566, "wMsgALMAZ_DNS");
                DcsMessageTable.Add(4567, "wMsgALMAZ_FAILURE_NAV_POSITION");
                DcsMessageTable.Add(4568, "wMsgALMAZ_GENERATOR_FAILURE");
                DcsMessageTable.Add(4569, "wMsgALMAZ_DC_RECTIF_FAILURE");
                DcsMessageTable.Add(4570, "wMsgALMAZ_ENG_DIGITAL_CONTROL_FAILURE");
                DcsMessageTable.Add(4571, "wMsgALMAZ_LOW_COCKPIT_PRESSURE");
                DcsMessageTable.Add(4572, "wMsgALMAZ_NO_HYDRO_PRESSURE");
                DcsMessageTable.Add(4573, "wMsgALMAZ_FAILURE_AIRCOND");
                DcsMessageTable.Add(4574, "wMsgALMAZ_FAILURE_ROTOR_ANTIICE");
                DcsMessageTable.Add(4575, "wMsgALMAZ_NO_MOV_GUN_STOP");
                DcsMessageTable.Add(4576, "wMsgALMAZ_Maximum");
                DcsMessageTable.Add(4577, "wMsgRI65_Null");
                DcsMessageTable.Add(4578, "wMsgRI65_IS_READY");
                DcsMessageTable.Add(4579, "wMsgRI65_LEFT_ENGINE_FIRE");
                DcsMessageTable.Add(4580, "wMsgRI65_RIGHT_ENGINE_FIRE");
                DcsMessageTable.Add(4581, "wMsgRI65_MAIN_TRANSMISSION_FIRE");
                DcsMessageTable.Add(4582, "wMsgRI65_HEATER_FIRE");
                DcsMessageTable.Add(4583, "wMsgRI65_SWITCH_OFF_LEFT_ENGINE");
                DcsMessageTable.Add(4584, "wMsgRI65_SWITCH_OFF_RIGHT_ENGINE");
                DcsMessageTable.Add(4585, "wMsgRI65_LEFT_ENGINE_VIBRATION");
                DcsMessageTable.Add(4586, "wMsgRI65_RIGHT_ENGINE_VIBRATION");
                DcsMessageTable.Add(4587, "wMsgRI65_MAIN_HYDRO_FAILURE");
                DcsMessageTable.Add(4588, "wMsgRI65_EMERGENCY_FUEL");
                DcsMessageTable.Add(4589, "wMsgRI65_ICING");
                DcsMessageTable.Add(4590, "wMsgRI65_TRANSMISSION_MALFUNCTION");
                DcsMessageTable.Add(4591, "wMsgRI65_GENERATOR1_FAILURE");
                DcsMessageTable.Add(4592, "wMsgRI65_GENERATOR2_FAILURE");
                DcsMessageTable.Add(4593, "wMsgRI65_PUMP_FEEDER_FUEL_TANK_FAILURE");
                DcsMessageTable.Add(4594, "wMsgRI65_PUMPS_MAIN_FUEL_TANKS_FAILURE");
                DcsMessageTable.Add(4595, "wMsgRI65_BOARD");
                DcsMessageTable.Add(4596, "wMsgRI65_0_BEGIN");
                DcsMessageTable.Add(4597, "wMsgRI65_0_END");
                DcsMessageTable.Add(4598, "wMsgRI65_1_BEGIN");
                DcsMessageTable.Add(4599, "wMsgRI65_1_END");
                DcsMessageTable.Add(4600, "wMsgRI65_2_BEGIN");
                DcsMessageTable.Add(4601, "wMsgRI65_2_END");
                DcsMessageTable.Add(4602, "wMsgRI65_3_BEGIN");
                DcsMessageTable.Add(4603, "wMsgRI65_3_END");
                DcsMessageTable.Add(4604, "wMsgRI65_4_BEGIN");
                DcsMessageTable.Add(4605, "wMsgRI65_4_END");
                DcsMessageTable.Add(4606, "wMsgRI65_5_BEGIN");
                DcsMessageTable.Add(4607, "wMsgRI65_5_END");
                DcsMessageTable.Add(4608, "wMsgRI65_6_BEGIN");
                DcsMessageTable.Add(4609, "wMsgRI65_6_END");
                DcsMessageTable.Add(4610, "wMsgRI65_7_BEGIN");
                DcsMessageTable.Add(4611, "wMsgRI65_7_END");
                DcsMessageTable.Add(4612, "wMsgRI65_8_BEGIN");
                DcsMessageTable.Add(4613, "wMsgRI65_8_END");
                DcsMessageTable.Add(4614, "wMsgRI65_9_BEGIN");
                DcsMessageTable.Add(4615, "wMsgRI65_9_END");
                DcsMessageTable.Add(4616, "wMsgRI65_Maximum");
                DcsMessageTable.Add(4617, "wMsgAutopilotAdjustment_Null");
                DcsMessageTable.Add(4618, "wMsgAutopilotAdjustment_AdjustingPitchChannel");
                DcsMessageTable.Add(4619, "wMsgAutopilotAdjustment_AdjustingRollChannel");
                DcsMessageTable.Add(4620, "wMsgAutopilotAdjustment_Maximum");
                DcsMessageTable.Add(4621, "wMsgExternalCargo_Null");
                DcsMessageTable.Add(4622, "wMsgExternalCargo_meter");
                DcsMessageTable.Add(4623, "wMsgExternalCargo_two");
                DcsMessageTable.Add(4624, "wMsgExternalCargo_three");
                DcsMessageTable.Add(4625, "wMsgExternalCargo_five");
                DcsMessageTable.Add(4626, "wMsgExternalCargo_ten");
                DcsMessageTable.Add(4627, "wMsgExternalCargo_fifteen");
                DcsMessageTable.Add(4628, "wMsgExternalCargo_twenty");
                DcsMessageTable.Add(4629, "wMsgExternalCargo_thirty");
                DcsMessageTable.Add(4630, "wMsgExternalCargo_fifty");
                DcsMessageTable.Add(4631, "wMsgExternalCargo_sixty");
                DcsMessageTable.Add(4632, "wMsgExternalCargo_one_hundred");
                DcsMessageTable.Add(4633, "wMsgExternalCargo_one_hundred_and_fifty");
                DcsMessageTable.Add(4634, "wMsgExternalCargo_above");
                DcsMessageTable.Add(4635, "wMsgExternalCargo_below");
                DcsMessageTable.Add(4636, "wMsgExternalCargo_back");
                DcsMessageTable.Add(4637, "wMsgExternalCargo_forward");
                DcsMessageTable.Add(4638, "wMsgExternalCargo_right");
                DcsMessageTable.Add(4639, "wMsgExternalCargo_left");
                DcsMessageTable.Add(4640, "wMsgExternalCargo_end");
                DcsMessageTable.Add(4641, "wMsgExternalCargo_start");
                DcsMessageTable.Add(4642, "wMsgExternalCargo_above_cargo");
                DcsMessageTable.Add(4643, "wMsgExternalCargo_hold_height");
                DcsMessageTable.Add(4644, "wMsgExternalCargo_at_height");
                DcsMessageTable.Add(4645, "wMsgExternalCargo_lock_closed");
                DcsMessageTable.Add(4646, "wMsgExternalCargo_cargo_hooked");
                DcsMessageTable.Add(4647, "wMsgExternalCargo_taut_of_rope");
                DcsMessageTable.Add(4648, "wMsgExternalCargo_rope_was_taut");
                DcsMessageTable.Add(4649, "wMsgExternalCargo_meter_ground");
                DcsMessageTable.Add(4650, "wMsgExternalCargo_three_ground");
                DcsMessageTable.Add(4651, "wMsgExternalCargo_five_ground");
                DcsMessageTable.Add(4652, "wMsgExternalCargo_ten_ground");
                DcsMessageTable.Add(4653, "wMsgExternalCargo_fifteen_ground");
                DcsMessageTable.Add(4654, "wMsgExternalCargo_cargo_ropes_normal");
                DcsMessageTable.Add(4655, "wMsgExternalCargo_cargo_ropes_normal_2");
                DcsMessageTable.Add(4656, "wMsgExternalCargo_longitudinal_swing");
                DcsMessageTable.Add(4657, "wMsgExternalCargo_transverse_swing");
                DcsMessageTable.Add(4658, "wMsgExternalCargo_sixty_to_ground");
                DcsMessageTable.Add(4659, "wMsgExternalCargo_thirty_to_ground");
                DcsMessageTable.Add(4660, "wMsgExternalCargo_twenty_to_ground");
                DcsMessageTable.Add(4661, "wMsgExternalCargo_ten_to_ground");
                DcsMessageTable.Add(4662, "wMsgExternalCargo_three_to_ground");
                DcsMessageTable.Add(4663, "wMsgExternalCargo_one_to_ground");
                DcsMessageTable.Add(4664, "wMsgExternalCargo_over_the_zone");
                DcsMessageTable.Add(4665, "wMsgExternalCargo_cargo_ground_reset");
                DcsMessageTable.Add(4666, "wMsgExternalCargo_cargo_is_unhooked");
                DcsMessageTable.Add(4667, "wMsgExternalCargo_rope_is_torn");
                DcsMessageTable.Add(4668, "wMsgExternalCargo_rope_near_luke");
                DcsMessageTable.Add(4669, "wMsgExternalCargo_Maximum");
                DcsMessageTable.Add(4670, "wMsgMi8_Checklist_Null");
                DcsMessageTable.Add(4671, "wMsgMi8_Checklist_CM_BeforeAPU");
                DcsMessageTable.Add(4672, "wMsgMi8_Checklist_ITEM_Accums");
                DcsMessageTable.Add(4673, "wMsgMi8_Checklist_ANSWER_Accums_On_VoltageNorm");
                DcsMessageTable.Add(4674, "wMsgMi8_Checklist_ITEM_Recorder");
                DcsMessageTable.Add(4675, "wMsgMi8_Checklist_ANSWER_Recorder_On_Works");
                DcsMessageTable.Add(4676, "wMsgMi8_Checklist_ITEM_CommHearing");
                DcsMessageTable.Add(4677, "wMsgMi8_Checklist_ANSWER_CommHearing_Good_1");
                DcsMessageTable.Add(4678, "wMsgMi8_Checklist_ANSWER_CommHearing_Good_2");
                DcsMessageTable.Add(4679, "wMsgMi8_Checklist_ANSWER_CommHearing_Good_3");
                DcsMessageTable.Add(4680, "wMsgMi8_Checklist_ITEM_CollectiveLock");
                DcsMessageTable.Add(4681, "wMsgMi8_Checklist_ANSWER_CollectiveLock_Opened");
                DcsMessageTable.Add(4682, "wMsgMi8_Checklist_ITEM_SPUU");
                DcsMessageTable.Add(4683, "wMsgMi8_Checklist_ANSWER_SPUU_On_OK");
                DcsMessageTable.Add(4684, "wMsgMi8_Checklist_ITEM_Stick");
                DcsMessageTable.Add(4685, "wMsgMi8_Checklist_ANSWER_Stick_Neutral");
                DcsMessageTable.Add(4686, "wMsgMi8_Checklist_ITEM_StartCB");
                DcsMessageTable.Add(4687, "wMsgMi8_Checklist_ANSWER_StartCB_On_1");
                DcsMessageTable.Add(4688, "wMsgMi8_Checklist_ANSWER_StartCB_On_2");
                DcsMessageTable.Add(4689, "wMsgMi8_Checklist_ITEM_Doors");
                DcsMessageTable.Add(4690, "wMsgMi8_Checklist_ANSWER_Doors_Closed");
                DcsMessageTable.Add(4691, "wMsgMi8_Checklist_ITEM_WheelBrakesCheck");
                DcsMessageTable.Add(4692, "wMsgMi8_Checklist_ANSWER_WheelBrakesCheck_OK_1");
                DcsMessageTable.Add(4693, "wMsgMi8_Checklist_ANSWER_WheelBrakesCheck_OK_2");
                DcsMessageTable.Add(4694, "wMsgMi8_Checklist_ITEM_RotorBrake");
                DcsMessageTable.Add(4695, "wMsgMi8_Checklist_ANSWER_RotorBrake_Off");
                DcsMessageTable.Add(4696, "wMsgMi8_Checklist_ITEM_Throttles");
                DcsMessageTable.Add(4697, "wMsgMi8_Checklist_ANSWER_Throttles_Middle_Locked");
                DcsMessageTable.Add(4698, "wMsgMi8_Checklist_ITEM_CollectiveCorrection");
                DcsMessageTable.Add(4699, "wMsgMi8_Checklist_ANSWER_CollectiveCorrection_Min_Left");
                DcsMessageTable.Add(4700, "wMsgMi8_Checklist_ITEM_Lamps");
                DcsMessageTable.Add(4701, "wMsgMi8_Checklist_ANSWER_Lamps_OK_1");
                DcsMessageTable.Add(4702, "wMsgMi8_Checklist_ANSWER_Lamps_OK_2");
                DcsMessageTable.Add(4703, "wMsgMi8_Checklist_ANSWER_Lamps_OK_3");
                DcsMessageTable.Add(4704, "wMsgMi8_Checklist_ITEM_RI");
                DcsMessageTable.Add(4705, "wMsgMi8_Checklist_ANSWER_RI_OK");
                DcsMessageTable.Add(4706, "wMsgMi8_Checklist_ITEM_Vibro");
                DcsMessageTable.Add(4707, "wMsgMi8_Checklist_ANSWER_Vibro_OK");
                DcsMessageTable.Add(4708, "wMsgMi8_Checklist_ITEM_SARPP");
                DcsMessageTable.Add(4709, "wMsgMi8_Checklist_ANSWER_SARPP_On_Manual");
                DcsMessageTable.Add(4710, "wMsgMi8_Checklist_ITEM_FireExt");
                DcsMessageTable.Add(4711, "wMsgMi8_Checklist_ANSWER_FireExt_OK");
                DcsMessageTable.Add(4712, "wMsgMi8_Checklist_ITEM_FlowSw");
                DcsMessageTable.Add(4713, "wMsgMi8_Checklist_ANSWER_FlowSw_On");
                DcsMessageTable.Add(4714, "wMsgMi8_Checklist_ITEM_FuelMeter");
                DcsMessageTable.Add(4715, "wMsgMi8_Checklist_ANSWER_FuelMeter_OK");
                DcsMessageTable.Add(4716, "wMsgMi8_Checklist_ITEM_Generators");
                DcsMessageTable.Add(4717, "wMsgMi8_Checklist_ANSWER_Generators_Off");
                DcsMessageTable.Add(4718, "wMsgMi8_Checklist_ITEM_FuelPumps");
                DcsMessageTable.Add(4719, "wMsgMi8_Checklist_ANSWER_FuelPumps_On");
                DcsMessageTable.Add(4720, "wMsgMi8_Checklist_ITEM_FuelShutoffValves");
                DcsMessageTable.Add(4721, "wMsgMi8_Checklist_ANSWER_FuelShutoffValves_Opened");
                DcsMessageTable.Add(4722, "wMsgMi8_Checklist_ITEM_EngineShutoffValves");
                DcsMessageTable.Add(4723, "wMsgMi8_Checklist_ANSWER_EngineShutoffValves_RearPos_1");
                DcsMessageTable.Add(4724, "wMsgMi8_Checklist_ANSWER_EngineShutoffValves_RearPos_2");
                DcsMessageTable.Add(4725, "wMsgMi8_Checklist_CM_WithAPU");
                DcsMessageTable.Add(4726, "wMsgMi8_Checklist_ITEM_ParamsAPU");
                DcsMessageTable.Add(4727, "wMsgMi8_Checklist_ANSWER_ParamsAPU_Norm");
                DcsMessageTable.Add(4728, "wMsgMi8_Checklist_ITEM_GeneratorAPU");
                DcsMessageTable.Add(4729, "wMsgMi8_Checklist_ANSWER_GeneratorAPU_On");
                DcsMessageTable.Add(4730, "wMsgMi8_Checklist_ITEM_HydraulicSw");
                DcsMessageTable.Add(4731, "wMsgMi8_Checklist_ANSWER_HydraulicSw_On");
                DcsMessageTable.Add(4732, "wMsgMi8_Checklist_ITEM_BeaconLight");
                DcsMessageTable.Add(4733, "wMsgMi8_Checklist_ANSWER_BeaconLight_On");
                DcsMessageTable.Add(4734, "wMsgMi8_Checklist_ITEM_Inverter115");
                DcsMessageTable.Add(4735, "wMsgMi8_Checklist_ANSWER_Inverter115_Manual");
                DcsMessageTable.Add(4736, "wMsgMi8_Checklist_ITEM_EnginesStartReady");
                DcsMessageTable.Add(4737, "wMsgMi8_Checklist_ANSWER_EnginesStartReady_Ready_1");
                DcsMessageTable.Add(4738, "wMsgMi8_Checklist_ANSWER_EnginesStartReady_Ready_2");
                DcsMessageTable.Add(4739, "wMsgMi8_Checklist_ANSWER_EnginesStartReady_Ready_3");
                DcsMessageTable.Add(4740, "wMsgMi8_Checklist_CM_EnginesIdle");
                DcsMessageTable.Add(4741, "wMsgMi8_Checklist_ITEM_EnginesParams");
                DcsMessageTable.Add(4742, "wMsgMi8_Checklist_ANSWER_EnginesParams_Norm");
                DcsMessageTable.Add(4743, "wMsgMi8_Checklist_ITEM_HeatPZU");
                DcsMessageTable.Add(4744, "wMsgMi8_Checklist_ANSWER_HeatPZU_On");
                DcsMessageTable.Add(4745, "wMsgMi8_Checklist_ITEM_Reductors");
                DcsMessageTable.Add(4746, "wMsgMi8_Checklist_ANSWER_Reductors_Heated_OK");
                DcsMessageTable.Add(4747, "wMsgMi8_Checklist_ITEM_Hydraulics");
                DcsMessageTable.Add(4748, "wMsgMi8_Checklist_ANSWER_Hydraulics_On_OK");
                DcsMessageTable.Add(4749, "wMsgMi8_Checklist_ITEM_Radio");
                DcsMessageTable.Add(4750, "wMsgMi8_Checklist_ANSWER_Radio_On_Checked_1");
                DcsMessageTable.Add(4751, "wMsgMi8_Checklist_ANSWER_Radio_On_Checked_2");
                DcsMessageTable.Add(4752, "wMsgMi8_Checklist_CM_CorrectionRight");
                DcsMessageTable.Add(4753, "wMsgMi8_Checklist_ITEM_GensAndRects");
                DcsMessageTable.Add(4754, "wMsgMi8_Checklist_ANSWER_GensAndRects_On");
                DcsMessageTable.Add(4755, "wMsgMi8_Checklist_ITEM_ResGenAndAPU");
                DcsMessageTable.Add(4756, "wMsgMi8_Checklist_ANSWER_ResGenAndAPU_Off");
                DcsMessageTable.Add(4757, "wMsgMi8_Checklist_ITEM_Inverters");
                DcsMessageTable.Add(4758, "wMsgMi8_Checklist_ANSWER_Inverters_Auto");
                DcsMessageTable.Add(4759, "wMsgMi8_Checklist_ITEM_SARPP12");
                DcsMessageTable.Add(4760, "wMsgMi8_Checklist_ANSWER_SARPP12_On_Manual");
                DcsMessageTable.Add(4761, "wMsgMi8_Checklist_ITEM_RotorRate");
                DcsMessageTable.Add(4762, "wMsgMi8_Checklist_ANSWER_RotorRate_Reached");
                DcsMessageTable.Add(4763, "wMsgMi8_Checklist_ITEM_AGBs");
                DcsMessageTable.Add(4764, "wMsgMi8_Checklist_ANSWER_AGBs_On_Norm_1");
                DcsMessageTable.Add(4765, "wMsgMi8_Checklist_ANSWER_AGBs_On_Norm_2");
                DcsMessageTable.Add(4766, "wMsgMi8_Checklist_ITEM_GMK");
                DcsMessageTable.Add(4767, "wMsgMi8_Checklist_ANSWER_GMK_On_Slaved_1");
                DcsMessageTable.Add(4768, "wMsgMi8_Checklist_ANSWER_GMK_On_Slaved_2");
                DcsMessageTable.Add(4769, "wMsgMi8_Checklist_ITEM_ADF");
                DcsMessageTable.Add(4770, "wMsgMi8_Checklist_ANSWER_ADF_On_1");
                DcsMessageTable.Add(4771, "wMsgMi8_Checklist_ANSWER_ADF_On_2");
                DcsMessageTable.Add(4772, "wMsgMi8_Checklist_ITEM_DISS");
                DcsMessageTable.Add(4773, "wMsgMi8_Checklist_ANSWER_DISS_On_Ready");
                DcsMessageTable.Add(4774, "wMsgMi8_Checklist_ITEM_IFF");
                DcsMessageTable.Add(4775, "wMsgMi8_Checklist_ANSWER_IFF_On");
                DcsMessageTable.Add(4776, "wMsgMi8_Checklist_ITEM_RA");
                DcsMessageTable.Add(4777, "wMsgMi8_Checklist_ANSWER_RA_On");
                DcsMessageTable.Add(4778, "wMsgMi8_Checklist_ITEM_P0");
                DcsMessageTable.Add(4779, "wMsgMi8_Checklist_ANSWER_P0_Set_1");
                DcsMessageTable.Add(4780, "wMsgMi8_Checklist_ANSWER_P0_Set_2");
                DcsMessageTable.Add(4781, "wMsgMi8_Checklist_ITEM_ERD_CHR");
                DcsMessageTable.Add(4782, "wMsgMi8_Checklist_ANSWER_ERD_CHR_OK_CHR_On");
                DcsMessageTable.Add(4783, "wMsgMi8_Checklist_ITEM_PowerPlantParams");
                DcsMessageTable.Add(4784, "wMsgMi8_Checklist_ANSWER_PowerPlantParams_Norm");
                DcsMessageTable.Add(4785, "wMsgMi8_Checklist_ITEM_LampsDanger");
                DcsMessageTable.Add(4786, "wMsgMi8_Checklist_ANSWER_LampsDanger_Off_1");
                DcsMessageTable.Add(4787, "wMsgMi8_Checklist_ANSWER_LampsDanger_Off_2");
                DcsMessageTable.Add(4788, "wMsgMi8_Checklist_ANSWER_LampsDanger_Off_3");
                DcsMessageTable.Add(4789, "wMsgMi8_Checklist_ITEM_WheelBrakes");
                DcsMessageTable.Add(4790, "wMsgMi8_Checklist_ANSWER_WheelBrakes_OK");
                DcsMessageTable.Add(4791, "wMsgMi8_Checklist_CM_BeforeTakeOff");
                DcsMessageTable.Add(4792, "wMsgMi8_Checklist_ITEM_Obstacle");
                DcsMessageTable.Add(4793, "wMsgMi8_Checklist_ANSWER_Obstacle_No_1");
                DcsMessageTable.Add(4794, "wMsgMi8_Checklist_ANSWER_Obstacle_No_2");
                DcsMessageTable.Add(4795, "wMsgMi8_Checklist_ITEM_TakeOffCourse");
                DcsMessageTable.Add(4796, "wMsgMi8_Checklist_ANSWER_TakeOffCourse_Set_1");
                DcsMessageTable.Add(4797, "wMsgMi8_Checklist_ANSWER_TakeOffCourse_Set_2");
                DcsMessageTable.Add(4798, "wMsgMi8_Checklist_ITEM_AGBsEqual");
                DcsMessageTable.Add(4799, "wMsgMi8_Checklist_ANSWER_AGBsEqual_ReadingsEqual");
                DcsMessageTable.Add(4800, "wMsgMi8_Checklist_ITEM_AutopilotPitchRoll");
                DcsMessageTable.Add(4801, "wMsgMi8_Checklist_ANSWER_AutopilotPitchRoll_On");
                DcsMessageTable.Add(4802, "wMsgMi8_Checklist_ITEM_WheelBrakesOff");
                DcsMessageTable.Add(4803, "wMsgMi8_Checklist_ANSWER_WheelBrakesOff_Off");
                DcsMessageTable.Add(4804, "wMsgMi8_Checklist_ITEM_ReadyToFlight");
                DcsMessageTable.Add(4805, "wMsgMi8_Checklist_ANSWER_ReadyToFlight_1");
                DcsMessageTable.Add(4806, "wMsgMi8_Checklist_ANSWER_ReadyToFlight_2");
                DcsMessageTable.Add(4807, "wMsgMi8_Checklist_ANSWER_ReadyToFlight_3");
                DcsMessageTable.Add(4808, "wMsgMi8_Checklist_CM_BeforeLanding");
                DcsMessageTable.Add(4809, "wMsgMi8_Checklist_ITEM_LandingConditions");
                DcsMessageTable.Add(4810, "wMsgMi8_Checklist_ANSWER_LandingConditions_OK_1");
                DcsMessageTable.Add(4811, "wMsgMi8_Checklist_ANSWER_LandingConditions_OK_2");
                DcsMessageTable.Add(4812, "wMsgMi8_Checklist_ITEM_AutopilotAlt");
                DcsMessageTable.Add(4813, "wMsgMi8_Checklist_ANSWER_AutopilotAlt_On_AltOff");
                DcsMessageTable.Add(4814, "wMsgMi8_Checklist_ITEM_SystemsCheck");
                DcsMessageTable.Add(4815, "wMsgMi8_Checklist_ANSWER_SystemsCheck_OK");
                DcsMessageTable.Add(4816, "wMsgMi8_Checklist_ITEM_RAlt");
                DcsMessageTable.Add(4817, "wMsgMi8_Checklist_ANSWER_RAlt_AltSet");
                DcsMessageTable.Add(4818, "wMsgMi8_Checklist_ITEM_SlavedGMK");
                DcsMessageTable.Add(4819, "wMsgMi8_Checklist_ANSWER_SlavedGMK_Slaved");
                DcsMessageTable.Add(4820, "wMsgMi8_Checklist_ITEM_PZU");
                DcsMessageTable.Add(4821, "wMsgMi8_Checklist_ANSWER_PZU_On");
                DcsMessageTable.Add(4822, "wMsgMi8_Checklist_ITEM_LandingCourse");
                DcsMessageTable.Add(4823, "wMsgMi8_Checklist_ANSWER_LandingCourse_Set_1");
                DcsMessageTable.Add(4824, "wMsgMi8_Checklist_ANSWER_LandingCourse_Set_2");
                DcsMessageTable.Add(4825, "wMsgMi8_Checklist_ITEM_ReadyToLanding");
                DcsMessageTable.Add(4826, "wMsgMi8_Checklist_ANSWER_ReadyToLanding_1");
                DcsMessageTable.Add(4827, "wMsgMi8_Checklist_ANSWER_ReadyToLanding_2");
                DcsMessageTable.Add(4828, "wMsgMi8_Checklist_ANSWER_ReadyToLanding_3");
                DcsMessageTable.Add(4829, "wMsgMi8_Checklist_WindDir_Front");
                DcsMessageTable.Add(4830, "wMsgMi8_Checklist_WindDir_FrontLeft");
                DcsMessageTable.Add(4831, "wMsgMi8_Checklist_WindDir_FrontRight");
                DcsMessageTable.Add(4832, "wMsgMi8_Checklist_WindDir_Back");
                DcsMessageTable.Add(4833, "wMsgMi8_Checklist_WindDir_BackLeft");
                DcsMessageTable.Add(4834, "wMsgMi8_Checklist_WindDir_BackRight");
                DcsMessageTable.Add(4835, "wMsgMi8_Checklist_WindDir_Left");
                DcsMessageTable.Add(4836, "wMsgMi8_Checklist_WindDir_Right");
                DcsMessageTable.Add(4837, "wMsgMi8_Checklist_WindStr_Calm");
                DcsMessageTable.Add(4838, "wMsgMi8_Checklist_WindStr_Light");
                DcsMessageTable.Add(4839, "wMsgMi8_Checklist_WindStr_Average");
                DcsMessageTable.Add(4840, "wMsgMi8_Checklist_WindStr_Stiff");
                DcsMessageTable.Add(4841, "wMsgMi8_Checklist_Completed");
                DcsMessageTable.Add(4842, "wMsgMi8_Checklist_Maximum");
                DcsMessageTable.Add(4843, "wMsgMi8_CrewProcedures_Null");
                DcsMessageTable.Add(4844, "wMsgMi8_CrewProcedures_OpenDoor");
                DcsMessageTable.Add(4845, "wMsgMi8_CrewProcedures_DoorOpened");
                DcsMessageTable.Add(4846, "wMsgMi8_CrewProcedures_CloseDoor");
                DcsMessageTable.Add(4847, "wMsgMi8_CrewProcedures_DoorClosed");
                DcsMessageTable.Add(4849, "wMsgMi8_CrewProcedures_LeafOpened");
                DcsMessageTable.Add(4850, "wMsgMi8_CrewProcedures_CloseLeaf");
                DcsMessageTable.Add(4851, "wMsgMi8_CrewProcedures_LeafClosed");
                DcsMessageTable.Add(4852, "wMsgMi8_CrewProcedures_StartAPU_Command");
                DcsMessageTable.Add(4853, "wMsgMi8_CrewProcedures_StartAPU_Answer");
                DcsMessageTable.Add(4854, "wMsgMi8_CrewProcedures_StartAPU_AutoOn");
                DcsMessageTable.Add(4855, "wMsgMi8_CrewProcedures_StartAPU_VoltageNorm");
                DcsMessageTable.Add(4856, "wMsgMi8_CrewProcedures_StartAPU_TemprGrowsPressNorm");
                DcsMessageTable.Add(4857, "wMsgMi8_CrewProcedures_StartAPU_ApuRunningReadingsNorm");
                DcsMessageTable.Add(4858, "wMsgMi8_CrewProcedures_StartEngines_StartLeftEngine_Command");
                DcsMessageTable.Add(4859, "wMsgMi8_CrewProcedures_StartEngines_ClearPropLeft");
                DcsMessageTable.Add(4860, "wMsgMi8_CrewProcedures_StartEngines_StartLeftEngine_Answer");
                DcsMessageTable.Add(4861, "wMsgMi8_CrewProcedures_StartEngines_StartRightEngine_Command");
                DcsMessageTable.Add(4862, "wMsgMi8_CrewProcedures_StartEngines_ClearPropRight");
                DcsMessageTable.Add(4863, "wMsgMi8_CrewProcedures_StartEngines_StartRightEngine_Answer");
                DcsMessageTable.Add(4864, "wMsgMi8_CrewProcedures_StartEngines_SpeedGrows");
                DcsMessageTable.Add(4865, "wMsgMi8_CrewProcedures_StartEngines_OilPressureGrows");
                DcsMessageTable.Add(4866, "wMsgMi8_CrewProcedures_StartEngines_TemperatureGrows");
                DcsMessageTable.Add(4867, "wMsgMi8_CrewProcedures_StartEngines_LeftIdleParamsNormal");
                DcsMessageTable.Add(4868, "wMsgMi8_CrewProcedures_StartEngines_RightIdleParamsNormal");
                DcsMessageTable.Add(4869, "wMsgMi8_CrewProcedures_TurnDevicesOn");
                DcsMessageTable.Add(4870, "wMsgMi8_CrewProcedures_CheckDevices");
                DcsMessageTable.Add(4871, "wMsgMi8_CrewProcedures_TurnAutopilotOn");
                DcsMessageTable.Add(4872, "wMsgMi8_CrewProcedures_AutopilotPitchRollOn");
                DcsMessageTable.Add(4873, "wMsgMi8_CrewProcedures_PerformControlHover");
                DcsMessageTable.Add(4874, "wMsgMi8_CrewProcedures_CrewTakeOff");
                DcsMessageTable.Add(4875, "wMsgMi8_CrewProcedures_IcingZoneEndedTurnAntiIceOff");
                DcsMessageTable.Add(4876, "wMsgMi8_CrewProcedures_RotorsAntiIcingOff");
                DcsMessageTable.Add(4877, "wMsgMi8_CrewProcedures_TurnDustProofDeviceOn");
                DcsMessageTable.Add(4878, "wMsgMi8_CrewProcedures_DustProofDeviceOn");
                DcsMessageTable.Add(4879, "wMsgMi8_CrewProcedures_TurnDustProofDeviceOff");
                DcsMessageTable.Add(4880, "wMsgMi8_CrewProcedures_DustProofDeviceOff");
                DcsMessageTable.Add(4881, "wMsgMi8_CrewProcedures_Descent_H60Decision");
                DcsMessageTable.Add(4882, "wMsgMi8_CrewProcedures_Descent_CrewLanding");
                DcsMessageTable.Add(4883, "wMsgMi8_CrewProcedures_Descent_H40Speed");
                DcsMessageTable.Add(4884, "wMsgMi8_CrewProcedures_Descent_H30Speed");
                DcsMessageTable.Add(4885, "wMsgMi8_CrewProcedures_Descent_H20Speed");
                DcsMessageTable.Add(4886, "wMsgMi8_CrewProcedures_Descent_H10Speed");
                DcsMessageTable.Add(4887, "wMsgMi8_CrewProcedures_Descent_Speed120");
                DcsMessageTable.Add(4888, "wMsgMi8_CrewProcedures_Descent_Speed110");
                DcsMessageTable.Add(4889, "wMsgMi8_CrewProcedures_Descent_Speed100");
                DcsMessageTable.Add(4890, "wMsgMi8_CrewProcedures_Descent_Speed90");
                DcsMessageTable.Add(4891, "wMsgMi8_CrewProcedures_Descent_Speed80");
                DcsMessageTable.Add(4892, "wMsgMi8_CrewProcedures_Descent_Speed70");
                DcsMessageTable.Add(4893, "wMsgMi8_CrewProcedures_Descent_Speed60");
                DcsMessageTable.Add(4894, "wMsgMi8_CrewProcedures_Descent_Speed50");
                DcsMessageTable.Add(4895, "wMsgMi8_CrewProcedures_Descent_Speed40");
                DcsMessageTable.Add(4896, "wMsgMi8_CrewProcedures_Descent_Speed30");
                DcsMessageTable.Add(4897, "wMsgMi8_CrewProcedures_Descent_Speed20");
                DcsMessageTable.Add(4898, "wMsgMi8_CrewProcedures_Descent_Speed10");
                DcsMessageTable.Add(4899, "wMsgMi8_CrewProcedures_CheckFuel_20min");
                DcsMessageTable.Add(4900, "wMsgMi8_CrewProcedures_CheckFuel_40min");
                DcsMessageTable.Add(4901, "wMsgMi8_CrewProcedures_CheckFuel_60min");
                DcsMessageTable.Add(4902, "wMsgMi8_CrewProcedures_CheckFuel");
                DcsMessageTable.Add(4903, "wMsgMi8_CrewProcedures_CrewLanding");
                DcsMessageTable.Add(4904, "wMsgMi8_CrewProcedures_TurnOffConsumers_GetReadyToStopEngines");
                DcsMessageTable.Add(4905, "wMsgMi8_CrewProcedures_CoolingTimeWasOver_ReadyToShutdown");
                DcsMessageTable.Add(4906, "wMsgMi8_CrewProcedures_ReadyToShutdown_StopEngines");
                DcsMessageTable.Add(4907, "wMsgMi8_CrewProcedures_ReadyToShutdown");
                DcsMessageTable.Add(4908, "wMsgMi8_CrewProcedures_RunningOutTimeOfEngineTurbinesNormal");
                DcsMessageTable.Add(4909, "wMsgMi8_CrewProcedures_FlightIsOver");
                DcsMessageTable.Add(4910, "wMsgMi8_CrewProcedures_Maximum");
                DcsMessageTable.Add(4911, "wMsgA10_VMU_Null");
                DcsMessageTable.Add(4912, "wMsgA10_VMU_Alert");
                DcsMessageTable.Add(4913, "wMsgA10_VMU_Altitude");
                DcsMessageTable.Add(4914, "wMsgA10_VMU_WarningAutopilot");
                DcsMessageTable.Add(4915, "wMsgA10_VMU_Ceiling");
                DcsMessageTable.Add(4916, "wMsgA10_VMU_IFF");
                DcsMessageTable.Add(4917, "wMsgA10_VMU_Obstacle");
                DcsMessageTable.Add(4918, "wMsgA10_VMU_Pullup");
                DcsMessageTable.Add(4919, "wMsgA10_VMU_Speedbreak");
                DcsMessageTable.Add(4920, "wMsgA10_VMU_Maximum");
                DcsMessageTable.Add(4921, "wMsgBeacon");
                DcsMessageTable.Add(4922, "wMsgBroadcast");
                DcsMessageTable.Add(4923, "wMsgDatalinkDatagram");
                DcsMessageTable.Add(4924, "wMsgPlayerVoIP");
                DcsMessageTable.Add(4925, "wMsgGroundNull");
                DcsMessageTable.Add(4926, "wMsgGroundROE");
                DcsMessageTable.Add(4927, "wMsgGroundROEFire");
                DcsMessageTable.Add(4928, "wMsgGroundROEReturnFire");
                DcsMessageTable.Add(4929, "wMsgGroundROEHoldFire");
                DcsMessageTable.Add(4930, "wMsgGroundAlarmState");
                DcsMessageTable.Add(4931, "wMsgGroundAlarmStateAuto");
                DcsMessageTable.Add(4932, "wMsgGroundAlarmStateRed");
                DcsMessageTable.Add(4933, "wMsgGroundAlarmStateGreen");
                DcsMessageTable.Add(4934, "wMsgGroundMaximum");
                DcsMessageTable.Add(4935, "wMsgNavyNull");
                DcsMessageTable.Add(4936, "wMsgLeaderStop");
                DcsMessageTable.Add(4937, "wMsgLeaderMoving");
                DcsMessageTable.Add(4938, "wMsgNavyMaximum");
                DcsMessageTable.Add(4939, "wMsgMaximum");

            }

            public static List<int> DcsAutoEventIDs;
            public static void InitAutoGeneratedEventIDs()
            {
                try
                {

                    DcsAutoEventIDs = new List<int>();

                    DcsAutoEventIDs.Add(DcsMessageTable.FirstOrDefault(x => x.Value == "wMsgLeaderConfirm").Key);
                    DcsAutoEventIDs.Add(DcsMessageTable.FirstOrDefault(x => x.Value == "wMsgLeaderConfirmRemainingFuel").Key);
                    DcsAutoEventIDs.Add(DcsMessageTable.FirstOrDefault(x => x.Value == "wMsgLeaderInboundMarshallRespond").Key);
                    DcsAutoEventIDs.Add(DcsMessageTable.FirstOrDefault(x => x.Value == "wMsgLeaderTowerOverhead").Key);

                }
                catch (Exception e)
                {
                    Log.Write(e.Message + e.StackTrace, Colors.Inline);
                }

            }

            public static string SenderCatByString(string dcsid)
            {
                try
                {

                    if (dcsid.StartsWith("wMsgLeader")) { return "Player"; }
                    if (dcsid.StartsWith("wMsgWingmen")) { return "Flight"; }
                    if (dcsid.StartsWith("wMsgFlight")) { return "Allies"; }
                    if (dcsid.StartsWith("wMsgATC")) { return "ATC"; }
                    if (dcsid.StartsWith("wMsgAWACS")) { return "AWACS"; }
                    if (dcsid.StartsWith("wMsgTanker")) { return "Tanker"; }
                    if (dcsid.StartsWith("wMsgFAC")) { return "JTAC"; }
                    if (dcsid.StartsWith("wMsgGround")) { return "Crew"; }
                    if (dcsid.StartsWith("wMsgExternalCargo")) { return "Cargo"; }

                    return "Undefined";

                }
                catch (Exception e)
                {
                    Log.Write(e.Message + e.StackTrace, Colors.Inline);
                    return "Undefined";
                }
            }

            public static int GetEventNumber(string dcsid)
            {
                int result = 4000;

                try
                {
                    result = DcsMessageTable.First(x => x.Value == dcsid).Key;
                }
                catch (Exception e)
                {
                    Log.Write(e.Message + e.StackTrace, Colors.Inline);
                }

                return result;

            }

        }
    }
}