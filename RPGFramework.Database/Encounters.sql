CREATE TABLE [dbo].[Encounters]
(
	[EncounterId] INT NOT NULL PRIMARY KEY, 
    [Type] VARCHAR(50) NULL, 
    [PlayerCount] INT NULL, 
    [NpcCount] INT NULL, 
    [Combat] INT NULL, 
    CONSTRAINT [FK_Encounters_Combats] FOREIGN KEY ([Combat]) REFERENCES [Combats]([CombatId])
)
