-- VAICOM PRO server-side script
-- VAICOMPRO.export.lua
-- www.vaicompro.com

package.path  = package.path..";.\\LuaSocket\\?.lua;"
package.cpath = package.cpath..";.\\LuaSocket\\?.dll;"

local socket = require("socket")

local purge

vaicom = {}

vaicom.config = {

		receivefromradio =	{ -- do not edit
							address	= "127.0.0.1",
							port	= 33333,
							timeout = 0,
							},
							
		sendtoradio =		{ -- do not edit
							address	= "127.0.0.1",
							port	= 33334,
							timeout = 0,
							},
							
		receivefromclient =	{ -- do not edit
							address	= "*",
							port	= 33491,
							timeout = 0,
							},
							
		sendtoclient =		{ -- if VA runs on a different PC change address to the IP address of VA host
							address	= "127.0.0.1", 
							port	= 33492,
							timeout = 0,
							},
		
		beaconclose	=		"missiondata.update.beacon.unlock",
							
}
vaicom.insert = {

	Start = function(self) 
	
		vaicom.receivefromradio = socket.try(socket.udp()) 
		socket.try(vaicom.receivefromradio:setsockname(vaicom.config.receivefromradio.address,vaicom.config.receivefromradio.port))
		socket.try(vaicom.receivefromradio:settimeout(vaicom.config.receivefromradio.timeout))
		
		vaicom.sendtoradio = socket.try(socket.udp()) 
		socket.try(vaicom.sendtoradio:setpeername(vaicom.config.sendtoradio.address,vaicom.config.sendtoradio.port))
		socket.try(vaicom.sendtoradio:settimeout(vaicom.config.sendtoradio.timeout))
		
		vaicom.receivefromclient = socket.try(socket.udp()) 
		socket.try(vaicom.receivefromclient:setsockname(vaicom.config.receivefromclient.address,vaicom.config.receivefromclient.port))
		socket.try(vaicom.receivefromclient:settimeout(vaicom.config.receivefromclient.timeout))
		
		vaicom.sendtoclient = socket.try(socket.udp()) 
		socket.try(vaicom.sendtoclient:setpeername(vaicom.config.sendtoclient.address,vaicom.config.sendtoclient.port))
		socket.try(vaicom.sendtoclient:settimeout(vaicom.config.sendtoclient.timeout))

	end,

	BeforeNextFrame = function(self)		
		local newdata = false
		newdata = vaicom.receivefromclient:receive()
		if newdata then
			vaicom.sendtoradio:send(newdata)
			if not vaicom.insert:Alt() then
				LoSetCommand(179)
			end
			purge = true
		else
			purge = false
		end
	end,
	
	AfterNextFrame = function(self)		
		local newdata = false
		newdata = vaicom.receivefromradio:receive()		
		if newdata then
			vaicom.sendtoclient:send(newdata)
		else	
			if purge then
				vaicom.insert:Flush()	
			end
			purge = false
		end			
	end,

	Stop = function(self)

		vaicom.sendtoclient:send(vaicom.config.beaconclose)

		if vaicom.receivefromradio then
			socket.try(vaicom.receivefromradio:close())
			vaicom.receivefromradio = nil
		end	
		if vaicom.sendtoradio then
			socket.try(vaicom.sendtoradio:close())
			vaicom.sendtoradio = nil
		end	
		if vaicom.receivefromclient then
			socket.try(vaicom.receivefromclient:close())
			vaicom.receivefromclient = nil
		end	
		if vaicom.sendtoclient then
			socket.try(vaicom.sendtoclient:close())
			vaicom.sendtoclient = nil
		end
		
	end,

	Mod = function(self)
		return (LoGetSelfData() and LoGetSelfData().Name) or nil	
	end,

	Alt = function(self)
		local mod = vaicom.insert:Mod()
		if mod == "MiG-21Bis" then
			GetDevice(55):performClickableAction(3046,1)
			return true
		end
		return false
	end, 

	Flush = function(self)	
		local mod = vaicom.insert:Mod() or ""
		if mod == "F-16C_50" then 
			GetDevice(16):performClickableAction(3024,1)	
			return 
		end				
		if mod == "FA-18C_hornet" then 
			GetDevice(13):performClickableAction(3027,0.2)	
			return 
		end			
		if mod == "F-5E-3" then
			GetDevice(24):performClickableAction(3001,1)
			return 
		end												 
		if mod == "F-86F Sabre" then 	
			GetDevice(26):performClickableAction(3004,1)
			GetDevice(26):performClickableAction(3004,1)			
			return 
		end
		if mod == "MiG-15bis" then
			GetDevice(30):performClickableAction(3002,1)
			GetDevice(30):performClickableAction(3002,1)			
			return 
		end	
		if mod == "AJS37" then
			GetDevice(30):performClickableAction(3011,1)	
			return 
		end	
		if mod == "Ka-50" then
			GetDevice(50):performClickableAction(1589,1)
			GetDevice(50):performClickableAction(1589,1)			
			return 
		end	
		if mod == "MiG-21Bis" then
			GetDevice(55):performClickableAction(3046,1)	
			return 
		end	
		if mod == "UH-1H" then
			GetDevice(21):performClickableAction(3009,1)
			GetDevice(21):performClickableAction(3009,0)
			return 
		end
		if mod == "Mi-8MT" then
			GetDevice(36):performClickableAction(3025,1)			
			return 
		end
		if mod == "Yak-52" then 
			LoSetCommand(1591)
			LoSetCommand(1592) 
			return 
		end	
		if string.find(mod, "L-39") then
			GetDevice(34):performClickableAction(1188,1)
			return
		end	
		if string.find(mod, "109") or string.find(mod, "190") then
			LoSetCommand(1591)
			LoSetCommand(1592) 													 		
			return 
		end	
		if string.find(mod, "Spitfire") then
			LoSetCommand(1591)
			LoSetCommand(1591) 													 		
			return 
		end	
		if string.find(mod, "P-51") or string.find(mod, "TF-51") then
			LoSetCommand(1592)
			LoSetCommand(1591)
			LoSetCommand(1591)			
			return 
		end	
		if string.find(mod, "P-47") then
			LoSetCommand(1592)
			LoSetCommand(1591)                                         
			return
		end	
		if string.find(mod, "Mi-24") then
			GetDevice(55):performClickableAction(3026,1) 
			GetDevice(55):performClickableAction(3026,0) 
			return
		end	
		if string.find(mod, "Mosquito") then
			LoSetCommand(1592)			
			LoSetCommand(1591) 					
			return 
		end	
		if string.find(mod, "AH-64") then
			GetDevice(25):performClickableAction(3017,-1)
			GetDevice(25):performClickableAction(3017,-1)
			return 
		end	
	end,
	
}

do
	local OtherLuaExportStart=LuaExportStart
	LuaExportStart=function()
		vaicom.insert:Start()	
		if OtherLuaExportStart then
			OtherLuaExportStart()
		end		
	end
end
do
	local OtherLuaExportBeforeNextFrame=LuaExportBeforeNextFrame
	LuaExportBeforeNextFrame=function()		
		vaicom.insert:BeforeNextFrame()
		if OtherLuaExportBeforeNextFrame then
			OtherLuaExportBeforeNextFrame()
		end						
	end
end
do
	local OtherLuaExportAfterNextFrame=LuaExportAfterNextFrame
	LuaExportAfterNextFrame=function()		
		vaicom.insert:AfterNextFrame()
		if OtherLuaExportAfterNextFrame then
			OtherLuaExportAfterNextFrame()
		end								
	end
end
do
	local OtherLuaExportStop=LuaExportStop
	LuaExportStop=function()				
		vaicom.insert:Stop()					
		if OtherLuaExportStop then
			OtherLuaExportStop()
		end						
	end
end