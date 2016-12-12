CREATE TABLE [dbo].[Combats] (
    [CombatId]        INT NOT NULL,
    [PlayerAdvantage] BIT NOT NULL,
    [Round]           INT DEFAULT ((0)) NOT NULL,
    [PlayerTurn]      BIT NOT NULL,
    PRIMARY KEY CLUSTERED ([CombatId] ASC)
);

