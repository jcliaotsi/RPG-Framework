CREATE TABLE [dbo].[Combats]
(
	[CombatId] INT NOT NULL PRIMARY KEY, 
    [PlayerAdvantage] BIT NOT NULL, 
    [Round] INT NOT NULL DEFAULT 0, 
    [PlayerTurn] BIT NOT NULL 
)
