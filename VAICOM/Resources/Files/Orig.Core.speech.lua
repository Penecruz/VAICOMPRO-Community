--Speech construction module

local base = _G

local function clean()
	base.utils = nil
	base.package.loaded['utils'] = nil
	base.common = nil
	base.package.loaded['common'] = nil
	base.NATO = nil
	base.package.loaded['NATO'] = nil
	base.USSR = nil
	base.package.loaded['USSR'] = nil
	base.speech = nil
	base.package.loaded['speech'] = nil
	base.phrase = nil
	base.package.loaded['phrase'] = nil
end

clean()

module('speech')

--Protocol determines how message content (sound files + subtitle string) must be buildt from message data

--Protocol by country

--[DCSCORE-6483: A-10C speech error](https://jira.eagle.ru/browse/DCSCORE-6483)
--by some reason at mission execution  time  table coutry is chnaged in format , save  original  as reference

local  nations  = base.country.id

protocolByCountry = {
	[nations.RUSSIA] 		= 'USSR',
	[nations.UKRAINE] 		= 'USSR',
	[nations.INSURGENTS] 	= 'USSR',
	[nations.ABKHAZIA] 		= 'USSR',
	[nations.SOUTH_OSETIA] 	= 'USSR',
	[nations.KAZAKHSTAN] 	= 'USSR',
	[nations.USSR] 			= 'USSR',
	[nations.GDR] 			= 'USSR',
}
defaultProtocol = 'NATO'

nativeCockpitLanguage = true

local p = base.require('phrase')
local u = base.require('utils')

protocols = {
	['common']	= base.require('common'),
	['NATO']	= base.require('NATO'),
	['USSR']	= base.require('USSR')
}

--Aircraft native country used to select VMS language and unit system
aircraftNativeCountry = {
	['Ka-50']	  = nations.RUSSIA,
	['Su-27']	  = nations.RUSSIA,
	['Su-33']	  = nations.RUSSIA,
	['MiG-29A']   = nations.RUSSIA,
	['MiG-29S']   = nations.RUSSIA,
	['MiG-29G']   = nations.GERMANY,
	['Su-25'] 	  = nations.RUSSIA,
	['Su-25T']	  = nations.RUSSIA,
	['Mi-8MT']	  = nations.RUSSIA,
	['L-39C'] 	  = nations.RUSSIA,
	['L-39ZA'] 	  = nations.RUSSIA,
	['MiG-15bis'] = nations.RUSSIA,
	['MiG-21Bis'] = nations.RUSSIA,
	['Bf-109K-4'] = nations.GERMANY,
	['FW-190D9']  = nations.GERMANY,
	['MiG-19P']   = nations.RUSSIA,
	['I-16']   	  = nations.RUSSIA,
	['Yak-52']    = nations.RUSSIA,
	['J-11A'] 	  = nations.CHINA,
	['Mi-24P'] 	  = nations.RUSSIA,
}

if not ED_FINAL_VERSION then

function reload()
	local airdromeNames = u.createTableCopy(protocols.common.airdromeNames)
	clean()
	base.dofile('Scripts/Speech/speech.lua')
	for moduleName, moduleAirdromeNames in base.pairs(airdromeNames) do
		u.copyTable(base.speech.protocols.common.airdromeNames[moduleName], moduleAirdromeNames)
	end
end

end

local dummySound-- = 'BlaBlaBla.ogg'

--Returns country for the message. The country will be used to select protocol
local function getCountry(message)
	if message.event > base.Message.wMsgATCNull and message.event < base.Message.wMsgATCMaximum then		
		return message.receiver:getUnit():getCountry()
	elseif message.event > base.Message.wMsgGroundCrewNull and message.event < base.Message.wMsgGroundCrewMaximum then
		local player = base.world.getPlayer()
		return player ~= nil and player:getCountry() or message.sender:getUnit():getCountry()
	elseif message.event > base.Message.wMsgLeaderToATCNull and message.event < base.Message.wMsgLeaderToATCMaximum then
		return message.sender:getUnit():getCountry()		
	elseif message.event > base.Message.wMsgLeaderToServiceNull and message.event < base.Message.wMsgLeaderToFACMaximum then
		return message.receiver:getUnit():getCountry()
	elseif message.event > base.Message.wMsgAutopilotAdjustment_Null and message.event < base.Message.wMsgAutopilotAdjustment_Maximum then
		return message.sender:getUnit():getCountry()
	elseif message.event > base.Message.wMsgExternalCargo_Null and message.event < base.Message.wMsgExternalCargo_Maximum then
		return message.sender:getUnit():getCountry()	
	elseif message.event > base.Message.wMsgBettyNull and message.event < base.Message.wMsgA10_VMU_Maximum then
		if nativeCockpitLanguage then
			return aircraftNativeCountry[message.sender:getUnit():getTypeName()] or nations.USA
		else
			return nations.USA
		end
	else
		return message.sender:getUnit():getCountry()
	end
end

for protocolIndex, protocol in base.pairs(protocols) do
	protocol.getCountry = getCountry
	protocol.aircraftNativeCountry = aircraftNativeCountry
end

local finalPause = 1.0

--The function is to be called from wMessage::buildContent_()
function make(message)
	
	if message.type == base.Message.type.TYPE_MORZE then
		--Morze string
		return p.morze(message.string, message.parameters.type)
	else
		--Message for speech construction
		
		base.assert(message.sender ~= nil)
		local country = getCountry(message)
		
		--Protocols
		local stateProtocol = nil
		if country then
			stateProtocol = protocolByCountry[country] or defaultProtocol
		else
			stateProtocol = 'common'
		end
		
		local protocol = protocols[stateProtocol]
		base.assert(protocol ~= nil)
		local result = protocol:make(message)
		if  result then 
			result.duration = result.duration + finalPause
			if dummySound ~= nil then
				if not morze then
					result.files = { dummySound }
					result.directory = 'Sounds/Speech'
					result.duration = 1.0
				end
			end
			--base.traverseTable("make:",result.files[1] )
			--base.print("make:",result.files[1])
			--base.print("make:",result.directory )
		end
		return result
	end

end

base.print('Speech module loaded')