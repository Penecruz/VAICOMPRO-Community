local self_ID = "VAICOM PRO Community Edition"

declare_plugin(self_ID,
{
	installed	 = true,
	dirName		 = current_mod_path,
	binaries	 = {'VAICOMPRO.dll'},

	displayName	 = "VAICOM PRO Community Edition",
	shortName	 = "VAICOM PRO",
	fileMenuName = "VAICOM PRO Community Edition",

	version		 = "2.8.1",
	state		 = "installed", 	
	developerName= "DCS Community",
	info		 = _("VAICOM PRO Community Edition is a professional-grade voice communications interface. The plugin uses VoiceAttack as client host for advanced speech recognition, enabling true-to-life radio communications with all AI units in the mission."),

	Skins	=
	{
		{
			name	= "VAICOM PRO Community Edition",
			dir		= "Theme"
		},
	},

	Options =
	{
		{
			name		= "VAICOM PRO Commnuity Edition",
			nameId		= "VAICOM",
			dir			= "Options",
			CLSID		= "{VAICOM options}"
		},
	},
})

plugin_done()
