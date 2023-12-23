-- VAICOM PRO server-side script
-- VAICOMPRO.export.lua
-- www.vaicompro.com

package.path  = package.path..";.\\LuaSocket\\?.lua;"
package.cpath = package.cpath..";.\\LuaSocket\\?.dll;"

local socket = require("socket")

local purge

vaicom = {}

vaicom.config = {

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
			--if not vaicom.insert:Alt() then -- Pene debug Alt
				--LoSetCommand(179)
			--end
			purge = true
		else
			purge = false
		end
	end,
	
	AfterNextFrame = function(self)
		--if purge then
			--vaicom.insert:Flush()	-- Pene debug flush
		--end
		purge = false
	end,

	Stop = function(self)

		vaicom.sendtoclient:send(vaicom.config.beaconclose)

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