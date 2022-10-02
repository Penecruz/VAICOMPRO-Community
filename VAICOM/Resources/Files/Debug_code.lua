base = _G

local dev = 38
local arg = 3676
local val = 1

--local value = base.GetDevice(dev):get_argument_value(arg)
local value = base.GetDevice(dev):performClickableAction(arg,val)

base.trigger.action.outText("arg "..arg.." = "..base.tostring(value),5)



--[[

base = _G
local lfs = require("lfs")
local io = require("io")
dumpfile = io.open(lfs.writedir()..[[crawl-x.csv]], "w")

if dumpfile then
listtables = function (offset, maxdepth, tablename, filtertype)
if base.type(tablename) == "table" then
for n,v in base.pairs(tablename) do
	local function spacing()
		for i = 0, offset do
		dumpfile:write(";") 
		end
	end
	spacing()
	if base.tostring(n) ~= "_M" and base.tostring(n) ~= "__index" and filtertype == nil or base.type(v) == filtertype then
		if base.type(v) == "table" then
			dumpfile:write(base.tostring(n)..";"..base.tostring(base.type(v)).."\n")
			newoffset = offset + 1
			if newoffset < maxdepth then
				listtables(newoffset,maxdepth,v, filtertype)
			end
		else
			if base.type(v) == "function" or base.type(v) == "userdata" then
				dumpfile:write(base.tostring(n)..";"..base.tostring(base.type(v))..";"..base.tostring(base.debug.getinfo(v).what).."\n")
			else
				dumpfile:write(base.tostring(n)..";"..base.tostring(base.type(v))..";"..base.tostring(v).."\n")
			end
		end
	end
end
else
	dumpfile:write(base.tostring(base.type(tablename))..";"..base.tostring(tablename).."\n")
end
end 
listtables(0,6,base.speech)
dumpfile:close()
end
]]--