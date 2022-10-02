-- VAICOM PRO server-side script
-- TabSheetBar.lua (append)
-- www.vaicompro.com

function construct(self)
	self.skin = {
		container = {},
		item = Skin.staticSkin(),
		selectedItem = Skin.staticSkin(),
		arrows = Skin.staticSkin(),
		spacing = 0,        
	}

    self.window = Window.new(0,0,1280,30)
    self.window:setHasCursor(false)
    self.window:setVisible(false)
    
	self.container = Panel.new()
	self.container:setSkin(self.skin.container)
	local x, y, width, height = self.container:getBounds()

    self.window:insertWidget(self.container)	
    
	local left = Static.new('...')
	left:setSkin(self.skin.arrows)
	local leftItemWidth, leftItemHeight = left:calcSize()
	left:setBounds(0, 0, leftItemWidth, leftItemHeight)
	self.container:insertWidget(left)	
	left:setVisible(false)
	self.left = left
	
	local right = Static.new('...')
	right:setSkin(self.skin.arrows)
	local rightItemWidth, rightItemHeight = right:calcSize()
	right:setBounds(width - rightItemWidth, 0, rightItemWidth, rightItemHeight)
	self.container:insertWidget(right)	
	right:setVisible(false)
	self.right = right

	self.currentTabIndex = 0
	self.firstTabIndex = 0
	self.lastTabIndex = 0
	self.tabsWidth = 0
	self.tabs = {}
end