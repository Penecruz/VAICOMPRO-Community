dofile('Scripts/World/Radio/ModulationTypes.lua')
dofile('Scripts/World/Radio/FrequencyBands.lua')

local gettext = require("i_18n")
local       _ = gettext.translate

--WORLD RADIO -- Appended by VaicomPro

radioTableFormat = 3
radio = {
	{
		radioId = '0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Sharqiyah"), "Sharqiyah"}}}; -- Where is this?
		frequency = {};
		sceneObjects = {'t:10379342'};
	};
	{
		radioId = 'airfield1_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("AbuSultan"), "AbuSultan"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 251200000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 11900000.000000}};
		sceneObjects = {'t:109969531'};
	};
	{
		radioId = 'airfield2_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("AbuSuwayr"), "AbuSuwayr"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 251100000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 118950000.000000}};
		sceneObjects = {'t:10118142'};
	};
	{
		radioId = 'airfield26_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("ABR"), "ABR"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 118500000.000000}};
		sceneObjects = {'t:98616690'};
	};
	{
		radioId = 'airfield4_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Ismailia"), "Ismailia"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 251050000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 118100000.000000}};
		sceneObjects = {'t:10118143'};
	};
	{
		radioId = 'airfield31_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("EKH"), "EKH"}}}; -- where is this?
		frequency = {};
		sceneObjects = {'t:9519232'};
	};
	{
		radioId = 'airfield32_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("ERH"), "ERH"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 251050000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 121000000.000000}};
		sceneObjects = {'t:122511554'};
	};
	{
		radioId = 'airfield14_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("AlMansurah"), "AlMansurah"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250250000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 118250000.000000}};
		sceneObjects = {'t:10961058'};
	};
	{
		radioId = 'airfield3_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Salihiyah"), "Salihiyah"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 251200000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 119000000.000000}};
		sceneObjects = {'t:10379343'};
	};
	{
		radioId = 'airfield15_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Zaqaziq"), "Zaqaziq"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250300000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 118300000.000000}};
		sceneObjects = {'t:10092992'};
	};
	{
		radioId = 'airfield27_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("BAZL"), "BAZL"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250950000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 118080000.000000}};
		sceneObjects = {'t:121029778'};
	};
	{
		radioId = 'airfield24_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("BGN"), "BGN"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250800000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 134600000.000000}};
		sceneObjects = {'t:4679656'};
	};
	{
		radioId = 'airfield33_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("BSF"), "BSF"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 251300000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 127100000.000000}};
		sceneObjects = {'t:7528699'};
	};
	{
		radioId = 'airfield16_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("BBES"), "BBES"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250350000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 118350000.000000}};
		sceneObjects = {'t:9847031'};
	};
	{
		radioId = 'airfield5_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Melez"), "Melez"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 251300000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 119050000.000000}};
		sceneObjects = {'t:9895986'};
	};
	{
		radioId = 'airfield28_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("HASH"), "HASH"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 251000000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 118250000.000000}};
		sceneObjects = {'t:106979330'};
	};
	{
		radioId = 'airfield34_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("BAR"), "BAR"}}}; -- Is this Birma Air Base??
		frequency = {};
		sceneObjects = {'t:117391687'};
	};
	{
		radioId = 'airfield35_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("BEAI"), "BEAI"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 251400000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 119150000.000000}};
		sceneObjects = {'t:10839433'};
	};
	{
		radioId = 'airfield17_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("CAI"), "CAI"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250400000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 118100000.000000}};
		sceneObjects = {'t:2918973'};
	};
	{
		radioId = 'airfield18_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("SPX"), "SPX"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250450000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 118400000.000000}};
		sceneObjects = {'t:105907182'};
	};
	{
		radioId = 'airfield36_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("EMY"), "EMY"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 251450000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 119200000.000000}};
		sceneObjects = {'t:19271119'};
	};
	{
		radioId = 'airfield29_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("RIH"), "RIH"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 121000000.000000}};
		sceneObjects = {'t:11067434'};
	};
	{
		radioId = 'airfield30_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("ELGO"), "ELGO"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 118200000.000000}};
		sceneObjects = {'t:11083801'};
	};
	{
		radioId = 'airfield6_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Fayed"), "Fayed"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 251350000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 119100000.000000}};
		sceneObjects = {'t:9675084'};
	};
	{
		radioId = 'airfield37_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("GEL"), "GEL"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 251500000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 119250000.000000}};
		sceneObjects = {'t:10027137'};
	};
	{
		radioId = 'airfield7_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Hatzerim"), "Hatzerim"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 251400000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 119150000.000000}};
		sceneObjects = {'t:11682044'};
	};
	{
		radioId = 'airfield12_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("HatzerimHeliBase"), "HatzerimHeliBase"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250150000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 118150000.000000}};
		sceneObjects = {'t:11682045'};
	};
	{
		radioId = 'airfield20_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("HATZ"), "HATZ"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 251400000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 119150000.000000}};
		sceneObjects = {'t:12207863'};
	};
	{
		radioId = 'airfield38_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Hurghada"), "Hurghada"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 119600000.000000}};
		sceneObjects = {'t:6054241'};
	};
	{
		radioId = 'airfield19_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("ISH"), "ISH"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250500000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 118450000.000000}};
		sceneObjects = {'t:9587264'};
	};
	{
		radioId = 'airfield39_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("JNAB"), "JNAB"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 251600000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 119300000.000000}};
		sceneObjects = {'t:10567737'};
	};
	{
		radioId = 'airfield11_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("KBT"), "KBT"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250100000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 118050000.000000}};
		sceneObjects = {'t:9682987'};
	};
	{
		radioId = 'airfield40_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("KAM"), "KAM"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 251700000.000000}, [VHF_HI] = {MODULATIONTYPE_AM, 119400000.000000}};
		sceneObjects = {'t:102204215'};
	};
	{
		radioId = 'airfield8_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Nevatim"), "Nevatim"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 251450000.000000}, [VHF_HI] = {MODULATIONTYPE_AM, 132400000.000000}};
		sceneObjects = {'t:11436154'};
	};
	{
		radioId = 'airfield10_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("OVD"), "OVD"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250050000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 129900000.000000}};
		sceneObjects = {'t:9412794'};
	};
	{
		radioId = 'airfield21_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("PALM"), "PALM"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250650000.000000}, [VHF_HI] = {MODULATIONTYPE_AM, 118650000.000000}};
		sceneObjects = {'t:12387342'};
	};
	{
		radioId = 'airfield45_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("QWN"), "QWN"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 119550000.000000}};
		sceneObjects = {'t:10069007'};
	};
	{
		radioId = 'airfield9_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("RAM"), "RAM"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 252250000.000000}, [VHF_HI] = {MODULATIONTYPE_AM, 119800000.000000}};
		sceneObjects = {'t:10453169'};
	};
	{
		radioId = 'airfield41_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("RAM"), "RAM"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 119000000.000000}}; --Ramon International
		sceneObjects = {'t:8101921'};
	};
	{
		radioId = 'airfield22_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("SDE"), "SDE"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250600000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 118600000.000000}};
		sceneObjects = {'t:12602785'};
	};
	{
		radioId = 'airfield42_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("SHM"), "SHM"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 118900000.000000}};
		sceneObjects = {'t:6561836'};
	};
	{
		radioId = 'airfield25_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("STC"), "STC"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 121900000.000000}};
		sceneObjects = {'t:97969376'};
	};
	{
		radioId = 'airfield23_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("TELN"), "TELN"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 270750000.000000}, [VHF_HI] = {MODULATIONTYPE_AM, 118750000.000000}};
		sceneObjects = {'t:12380500'};
	};
	{
		radioId = 'airfield43_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("WAR"), "WAR"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 2518500000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 119450000.000000}};
		sceneObjects = {'t:7258143'};
	};
	{
		radioId = 'airfield13_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("CCE"), "CCE"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250200000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 118900000.000000}};
		sceneObjects = {'t:9306927'};
	};
	{
		radioId = 'airfield44_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("WAS"), "WAS"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 251900000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 119500000.000000}};
		sceneObjects = {'t:92102886'};
	};
}
