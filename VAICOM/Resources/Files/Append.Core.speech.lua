-- VAICOM PRO server-side script
-- speech.lua (append)
-- www.vaicompro.com

function make(message)
	if message.type == base.Message.type.TYPE_MORZE then
		return p.morze(message.string, message.parameters.type)
	else
		base.assert(message.sender ~= nil)
		local country = getCountry(message)
		local stateProtocol = nil
		if country then
			stateProtocol = protocolByCountry[country] or defaultProtocol
		else
			stateProtocol = 'common'
		end	
		local protocol = protocols[stateProtocol]
		base.assert(protocol ~= nil)
		local result = protocol:make(message) or { duration = 0 }
		if (base.vaicom.settings.playervoicedisabled and (message.sender == base.world.getPlayer())) then
			result.duration = 1.4
		else
			result.duration = result.duration + finalPause
		end
		base.vaicom.state.currentspeech = result
		if dummySound ~= nil then
			if not morze then
				result.files = { dummySound }
				result.directory = 'Sounds/Speech'
				result.duration = 1.0
			end
		end
		return result
	end
end