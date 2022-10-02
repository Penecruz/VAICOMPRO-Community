local count = 2999
local function counter()
	count = count + 1
	return count
end

device_commands =
{
	Master_Reset					= counter(),

    Select_Page_01                  = counter(),
    Select_Page_02                  = counter(),
    Select_Page_03                  = counter(),
    Select_Page_04                  = counter(),
    Select_Page_05                  = counter(),
    Select_Page_06                  = counter(),
    Select_Page_07                  = counter(),
    Select_Page_08                  = counter(),

}
