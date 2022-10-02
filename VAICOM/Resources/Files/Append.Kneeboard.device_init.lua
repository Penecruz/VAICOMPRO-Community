--------------------------------------

local file_exists = function(filename)
   local f=io.open(filename,"r")
   if f~=nil then 
	io.close(f) 
	return true 
   else 
	return false 
   end
end

local file = LockOn_Options.common_script_path.."VAICOMPRO/declare_VAICOMPRO_device.lua"

if file_exists(file) then
	dofile(file)
end