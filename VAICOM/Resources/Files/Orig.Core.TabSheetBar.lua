--Upper bar of tab sheet widget

local base = _G

module('TabSheetBar')
mtab = { __index = _M}

local Factory = base.require('Factory')
local Static = base.require("Static")
local Panel = base.require("Panel")
local Window = base.require("Window")
local Skin = base.require("Skin")

local function getTabWidth(self, index)
	local width, height = self.tabs[index]:calcSize()
	return width
end

local function getTabAreaWidth(self)
	local x, y, width, height = self.container:getBounds()
	return width
end

local function clearBar(self)
	self.container:removeAllWidgets()
	while #self.tabs > 0 do
		self.tabs[1]:destroy()
		base.table.remove(self.tabs, 1)
	end
	self.currentTabIndex = 0
	self.firstTabIndex = 0
	self.lastTabIndex = 0		
end

--Sets first tab index in the scope
local function setFirstTabIndex(self, index)
	base.assert(self:getTabCount() > 0)
	base.assert(index > 0 and index <= self:getTabCount())
	self.container:removeAllWidgets()
	local tabsWidth = 0
	if index > 1 then
		local leftItemWidth, leftItemHeight = self.left:calcSize()
		self.left:setVisible(true)
		self.container:insertWidget(self.left)
		tabsWidth = tabsWidth + leftItemWidth
	else
		self.left:setVisible(false)
	end
	local rightItemWidth, rightItemHeight = self.right:calcSize()
	self.firstTabIndex = index
	self.lastTabIndex = index
	local tabAreaWidth = getTabAreaWidth(self)
	while 	self.lastTabIndex <= self:getTabCount() and
			tabsWidth + getTabWidth(self, self.lastTabIndex) + (self.lastTabIndex < self:getTabCount() and rightItemHeight or 0) < tabAreaWidth do
		local tabWidth, tabHeight = self.tabs[self.lastTabIndex]:calcSize()
		self.tabs[self.lastTabIndex]:setBounds(tabsWidth, 0, tabWidth, tabHeight)
		self.container:insertWidget(self.tabs[self.lastTabIndex])
		tabsWidth = tabsWidth + tabWidth + self.skin.spacing
		self.lastTabIndex = self.lastTabIndex + 1
	end
	if self.lastTabIndex <= self:getTabCount() then
		local rightItemWidth, rightItemHeight = self.right:calcSize()
		self.right:setBounds(tabsWidth, 0, rightItemWidth, rightItemHeight)
		self.right:setVisible(true)
		self.container:insertWidget(self.right)
		tabsWidth = tabsWidth + rightItemWidth
	else
		self.right:setVisible(false)
	end	
end

--Sets last tab index in the scope
local function setLastTabIndex(self, index)
	base.assert(self:getTabCount() > 0)
	base.assert(index > 0 and index <= self:getTabCount())
	self.container:removeAllWidgets()
	local tabsWidth = 0
	if self.lastTabIndex <= self:getTabCount() then
		local rightItemWidth, rightItemHeight = self.right:calcSize()
		tabsWidth = tabsWidth + rightItemWidth
	end
	self.lastTabIndex = index + 1
	self.firstTabIndex = self.lastTabIndex
	local tabAreaWidth = getTabAreaWidth(self)
	while 	self.firstTabIndex > 1 and
			tabsWidth + getTabWidth(self, self.firstTabIndex - 1) < tabAreaWidth do
		local tabWidth, tabHeight = self.tabs[self.firstTabIndex - 1]:calcSize()
		tabsWidth = tabsWidth + tabWidth + self.skin.spacing
		self.firstTabIndex = self.firstTabIndex - 1
	end
	
	local tabsWidth = 0
	if self.firstTabIndex > 1 then
		local leftItemWidth, leftItemHeight = self.left:calcSize()
		self.left:setVisible(true)
		self.container:insertWidget(self.left)
		tabsWidth = tabsWidth + leftItemWidth
	else
		self.left:setVisible(false)
	end	
	for i = self.firstTabIndex, self.lastTabIndex - 1 do
		local tabWidth, tabHeight = self.tabs[i]:calcSize()
		self.tabs[i]:setBounds(tabsWidth, 0, tabWidth, tabHeight)
		self.container:insertWidget(self.tabs[i])
		tabsWidth = tabsWidth + tabWidth + self.skin.spacing		
	end
	if self.lastTabIndex <= self:getTabCount() then
		local rightItemWidth, rightItemHeight = self.right:calcSize()
		self.right:setBounds(tabsWidth, 0, rightItemWidth, rightItemHeight)
		self.right:setVisible(true)
		self.container:insertWidget(self.right)
		tabsWidth = tabsWidth + rightItemWidth
	else
		self.right:setVisible(false)
	end
end

function new(...)
  return Factory.create(_M, ...)
end

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
    self.window:setVisible(true)
    
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

function destroy(self)
	clearBar(self)
	self.left:destroy()
	self.right:destroy()
end

function setSkin(self, skin)
	self.skin = skin
	self.container:setSkin(self.skin.container)
    self.window:setSkin(self.skin.window)
	
	self.left:setSkin(self.skin.arrows)
	self.right:setSkin(self.skin.arrows)
	for index, tab in base.pairs(self.tabs) do
		tab:setSkin(self.skin.item)
	end
	if self.currentTabIndex > 0 then
		self.tabs[self.currentTabIndex]:setSkin(self.skin.selectedItem)
	end
	if self.firstTabIndex > 0 then
		setFirstTabIndex(self, self.firstTabIndex)
	end	
end

function getContainer(self)
  return self.container
end

function setBounds(self, x, y, w, h)
	self.container:setBounds(x, y, w, h)
    self.window:setBounds(x, y, w, h)
		
	local leftItemWidth, leftItemHeight = self.left:calcSize()
	self.left:setBounds(0, 0, leftItemWidth, leftItemHeight)	
	
	local rightItemWidth, rightItemHeight = self.right:calcSize()
	self.right:setBounds(w - rightItemWidth, 0, rightItemWidth, rightItemHeight)
	
	self.container:setBounds(leftItemWidth, 0, w - 2 * leftItemWidth, h)
end

function clear(self)
	clearBar(self)
end

--Adds new tab
function addTab(self, text)
	local item = Static.new(text)
	local tabWidth, tabHeight = item:calcSize()
	item:setBounds(0, 0, tabWidth, tabHeight)	
	base.table.insert(self.tabs, item)
	base.assert(self.tabs[1] ~= nil)
	local index = self:getTabCount()
	self:setCurrentTabIndex(index)
	return index
end

--Removes tab by index
function removeTab(self, index)
	self.tabs[index]:destroy()
	base.table.remove(self.tabs, index)
	if self.currentTabIndex > index then
		self.currentTabIndex = self.currentTabIndex - 1
	end
	if self.currentTabIndex > self:getTabCount() then
		self.currentTabIndex = self:getTabCount()
	end
	if self.firstTabIndex > self:getTabCount() then
		self.firstTabIndex = self:getTabCount()
	end	
	if self.currentTabIndex > 0 then
		setFirstTabIndex(self, self.firstTabIndex)
		self:setCurrentTabIndex(self.currentTabIndex)
	else
		clearBar(self)
	end
end

--Sets current tab index
function setCurrentTabIndex(self, index)
	base.assert(self:getTabCount() > 0)
	base.assert(index > 0 and index <= self:getTabCount())
	if self.currentTabIndex > 0 then
		self.tabs[self.currentTabIndex]:setSkin(self.skin.item)
	end
	self.currentTabIndex = index
	self.tabs[self.currentTabIndex]:setSkin(self.skin.selectedItem)
	if self.currentTabIndex < self.firstTabIndex then
		setFirstTabIndex(self, self.currentTabIndex)
	elseif self.currentTabIndex >= self.lastTabIndex then
		setLastTabIndex(self, self.currentTabIndex)
	else 
		setFirstTabIndex(self, self.firstTabIndex)
	end
end

function getCurrentTabIndex(self)
	return self.currentTabIndex
end

function getTabCount(self)
	return #self.tabs
end

function setTabText(self, index, text)
	self.tabs[index]:setText(text)
	setFirstTabIndex(self, self.firstTabIndex)
end

function getTabText(self, index)
	return self.tabs[index]:getText()
end

function next(self)
	if self.currentTabIndex < self:getTabCount() then
		self:setCurrentTabIndex(self.currentTabIndex + 1)
	end
end

function prev(self)
	if self.currentTabIndex > 1 then
		self:setCurrentTabIndex(self.currentTabIndex - 1)
	end	
end