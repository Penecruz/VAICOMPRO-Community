local DbOption = require('Options.DbOption')

return
{
	VAICOMDebugModeEnabled				= DbOption.new():setValue(false):checkbox(),
	VAICOMClientIP						= DbOption.new():setValue('127.0.0.1'):editbox(),
	AIRIODisableWheel					= DbOption.new():setValue(false):checkbox(),

}