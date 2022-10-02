
--deep debug stuff ---------------------------------------------------------------------------

local function basic_dump (o)
  if base.type(o) == "number" then
    return base.tostring(o)
  elseif base.type(o) == "string" then
    return base.string.format("%q", o)
  else -- nil, boolean, function, userdata, thread; assume it can be converted to a string
    return base.tostring(o)
  end
end

local function dumptables (name, value, saved, result)
  seen = seen or {}       -- initial value
  result = result or ""
  result=result..name.." = "
  if base.type(value) ~= "table" then
    result=result..basic_dump(value).."\n"
  elseif base.type(value) == "table" then
    if seen[value] then    -- value already saved?
      result=result.."->"..seen[value].."\n"  -- use its previous name
    else
      seen[value] = name   -- save name for next time
      result=result.."{}\n"     -- create a new table
      for k,v in base.pairs(value) do      -- save its fields
        local fieldname = base.string.format("%s[%s]", name,
                                        basic_dump(k))
        if fieldname~="_G[\"seen\"]" then
          result= dumptables(fieldname, v, seen, result)
        end
      end
    end
  end
  return result
end

local function strsplit(delimiter, text)
  local list = {}
  local pos = 1
  if base.string.find("", delimiter, 1) then
    return {}
  end
  while 1 do
    local first, last = base.string.find(text, delimiter, pos)
    if first then -- found?
      base.table.insert(list, base.string.sub(text, pos, first-1))
      pos = last+1
    else
      base.table.insert(list, base.string.sub(text, pos))
      break
    end
  end
  return list
end

local function dumpdata()

	if not base.vcprcp.log then 
	base.vcprcp.log = base.io.open(base.lfs.writedir()..[[Logs\VAICOM_Data_Dump.csv]], "w")
	end

	str= dumptables ("_G",_G) -- determine what to dump here
	
	local lines = strsplit("\n",str)
	
	for i,j in base.ipairs(lines) do
		base.vcprcp.log:write(base.tostring(i)..";"..base.tostring(j).."\n")
		base.vcprcp.log:flush()
	end
	
	base.vcprcp.log:close()
	base.vcprcp.log = nil

end

dumpdata()

-- end debug -----------------------------------------------------------------------------------

local lfs = require("lfs")
local io = require("io")
f = io.open(lfs.writedir()..[[Logs\inputenum.txt]], "w")
if f then
 f:write("\n\n*** fenv:\n")
 for k, v in pairs(getfenv()) do
  f:write(tostring(k))
  f:write("\t")
  f:write(tostring(v))
  f:write("\n")
 end 
 f:close()
end

	
--[[if (base.vcprcp.state.activemessage.mode == "debug") then

	if not base.vcprcp.log then 
	base.vcprcp.log = base.io.open(base.lfs.writedir()..[[Logs\VAICOM_TEST.csv]], "w")
	end
	for i, j in base.pairs(base.Message) do
		base.vcprcp.log:write(base.tostring(i)..";"..base.tostring(j).."\n")
		base.vcprcp.log:flush()
	end
	base.vcprcp.log:close()
	base.vcprcp.log = nil

end --]]
	
--[[
Function to recursively dump a table to a string:
Usage (e.g. to gain introspection into _G table):
str=dump("_G",_G)
local lines=strsplit("\n",str)
for k,v in ipairs(lines) do
    log.alert(v)
end
--]]

-- Can also dump metatable of any Lua device from inside to find functions that device exposes, e.g.
--[[
local dev = GetSelf()
m=getmetatable(dev)
str=dump("GetSelf meta",m)
local lines=strsplit("\n",str)
for k,v in ipairs(lines) do
   log.alert(v)
end ]]--