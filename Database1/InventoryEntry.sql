CREATE TABLE [dbo].[InventoryEntry]
(
	[Id] INT IDENTITY NOT NULL PRIMARY KEY,
	[ItemId] INT FOREIGN KEY REFERENCES [InventoryItem]([Id])
)
