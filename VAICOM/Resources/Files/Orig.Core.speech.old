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

protocolByCountry = {
	[base.country.id.RUSSIA] 		= 'USSR',
	[base.country.id.UKRAINE] 		= 'USSR',
	[base.country.id.INSURGENTS] 	= 'USSR',
	[base.country.id.ABKHAZIA] 		= 'USSR',
	[base.country.id.SOUTH_OSETIA] 	= 'USSR',
	[base.country.id.KAZAKHSTAN] 	= 'USSR',
	[base.country.id.USSR] 			= 'USSR',
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
	['Ka-50']	  = base.country.id.RUSSIA,
	['Su-27']	  = base.country.id.RUSSIA,
	['Su-33']	  = base.country.id.RUSSIA,
	['MiG-29A']   = base.country.id.RUSSIA,
	['MiG-29S']   = base.country.id.RUSSIA,
	['MiG-29G']   = base.country.id.GERMANY,
	['Su-25'] 	  = base.country.id.RUSSIA,
	['Su-25T']	  = base.country.id.RUSSIA,
	['Mi-8MT']	  = base.country.id.RUSSIA,
	['L-39C'] 	  = base.country.id.RUSSIA,
	['L-39ZA'] 	  = base.country.id.RUSSIA,
	['MiG-15bis'] = base.country.id.RUSSIA,
	['MiG-21Bis'] = base.country.id.RUSSIA,
	['Bf-109K-4'] = base.country.id.GERMANY,
	['FW-190D9']  = base.country.id.GERMANY,
	['MiG-19P']   = base.country.id.RUSSIA,
	['I-16']   	  = base.country.id.RUSSIA,
	['Yak-52']    = base.country.id.RUSSIA,
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
			return aircraftNativeCountry[message.sender:getUnit():getTypeName()] or base.country.id.USA
		else
			return base.country.id.USA
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