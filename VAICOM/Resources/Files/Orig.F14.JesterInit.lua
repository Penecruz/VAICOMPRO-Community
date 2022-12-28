dofile(LockOn_Options.common_script_path.."devices_defs.lua")
dofile(LockOn_Options.script_path.."materials.lua")

indicator_type       = indicator_types.COMMON
purposes 	 = {render_purpose.SCREENSPACE_INSIDE_COCKPIT,render_purpose.SCREENSPACE_OUTSIDE_COCKPIT,render_purpose.HUD_ONLY_VIEW}
screenspace_scale    = 4;

-------PAGE IDs-------
id_Page =
{
	MAIN = 0,
}

id_pagesubset =
{
	COMMON   = 0,
}

page_subsets = {}
page_subsets[id_pagesubset.COMMON] = LockOn_Options.script_path.."Scripts/JesterAI/JesterAI_Page.lua"
  	
----------------------
pages = {}
pages[id_Page.MAIN] = { id_pagesubset.COMMON}
init_pageID     = id_Page.MAIN


opacity_sensitive_materials =
{
"font_ROSE",
}

color_sensitive_materials =
{
"font_ROSE",
}

brightness_sensitive_materials =
{
"font_ROSE",
}

-- USE VIEWPORT: F14_JESTER_MENU
