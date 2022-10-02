local VAICOM_id = 255

if not creators then 
	creators = {}
end

creators[VAICOM_id] = {"avLuaDevice",LockOn_Options.common_script_path.."VAICOMPRO/device/VAICOMPRO_Device.lua"}

if not devices then
	devices = {}
end

devices["VAICOMPRO"] = VAICOM_id






