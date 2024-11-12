dofile('Scripts/World/Radio/ModulationTypes.lua')
dofile('Scripts/World/Radio/FrequencyBands.lua')

local gettext = require("i_18n")
local       _ = gettext.translate

--WORLD RADIO -- Appended by VaicomPro

radioTableFormat = 3
radio = {
	{
		radioId = 'airfield4_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("BAS100"), "BAS100"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 257100000.000000}};
		sceneObjects = {'t:6021123'};
	};
	{
		radioId = 'EFIV_Ivalo1';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Ivalo"), "Ivalo"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 118000000.000000}};
		sceneObjects = {'t:22684906'};
	};
	{
		radioId = 'airfield18_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Ivalo"), "Ivalo"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 118000000.000000}};
		sceneObjects = {'t:1622016'};
	};
	{
		radioId = 'EFKE_Kemi_Tornio1';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Kemi"), "Kemi"}}};
		frequency = {};
		sceneObjects = {'t:16712064'};
	};
	{
		radioId = 'airfield3_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("KemiTornio"), "KemiTornio"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250700000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 119400000.000000}};
		sceneObjects = {'t:3648316'};
	};
	{
		radioId = 'airfield16_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Kuusamo"), "Kuusamo"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 118650000.000000}};
		sceneObjects = {'t:17752941'};
	};
	{
		radioId = 'airfield2_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Rovaniemi"), "Rovaniemi"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250650000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 118700000.000000}};
		sceneObjects = {'t:18924077'};
	};
	{
		radioId = 'airfield20_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Andoya"), "Andoya"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250600000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 118200000.000000}};
		sceneObjects = {'t:24140313'};
	};
	{
		radioId = 'airfield7_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Bodo"), "Bodo"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250850000.000000}, [VHF_HI] = {MODULATIONTYPE_AM, 118400000.000000}};
		sceneObjects = {'t:16384'};
	};
	{
		radioId = 'airfield14_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Kirkenes"), "Kirkenes"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 120350000.000000}};
		sceneObjects = {'t:25570104'};
	};
	{
		radioId = 'airfield1_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Lakselv"), "Lakselv"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250550000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 118050000.000000}};
		sceneObjects = {'t:10076811'};
	};
	{
		radioId = 'airfield11_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Jokkmokk"), "Jokkmokk"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 123300000.000000}};
		sceneObjects = {'t:4669441'};
	};
	{
		radioId = 'airfield5_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Kiruna"), "Kiruna"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 130150000.000000}};
		sceneObjects = {'t:1318912'};
	};
	{
		radioId = 'airfield15_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Kallax"), "Kallax"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 250300000.000000},[VHF_HI] = {MODULATIONTYPE_AM, 128200000.000000}};
		sceneObjects = {'t:13321038'};
	};
	{
		radioId = 'airfield17_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Vidsel"), "Vidsel"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 119200000.000000}};
		sceneObjects = {'t:15885667'};
	};
	{
		radioId = 'airfield13_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Kalixfors"), "Kalixfors"}}};
		frequency = {[UHF] = {MODULATIONTYPE_AM, 301100000.000000}, [VHF_HI] = {MODULATIONTYPE_AM, 118250000.000000}};
		sceneObjects = {'t:191848500'};
	};
	{
		radioId = 'airfield19_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("alakourtti"), "alakourtti"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 118300000.000000}};
		sceneObjects = {'t:20136502'};
	};
	{
		radioId = 'airfield8_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Severomorsk-1"), "Severomorsk-1"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 127800000.000000}};
		sceneObjects = {'t:24678929'};
	};
	{
		radioId = 'airfield12_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Murmansk"), "Murmansk"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 127300000.000000}};
		sceneObjects = {'t:1875995'};
	};
	{
		radioId = 'airfield10_0';
		role = {"ground", "tower", "approach"};
		callsign = {};
		frequency = {};
		sceneObjects = {'t:7717465'};
	};
	{
		radioId = 'airfield6_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Severomorsk-3"), "Severomorsk-3"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 124300000.000000}};
		sceneObjects = {'t:24373839'};
	};
	{
		radioId = 'airfield9_0';
		role = {"ground", "tower", "approach"};
		callsign = {{["common"] = {_("Olenya"), "Olenya"}}};
		frequency = {[VHF_HI] = {MODULATIONTYPE_AM, 131400000.000000}};
		sceneObjects = {'t:22577494'};
	};
}
