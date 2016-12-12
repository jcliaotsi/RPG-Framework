CREATE TABLE [dbo].[Encounters] (
    [EncounterId] INT          NOT NULL,
    [Type]        VARCHAR (50) NULL,
    [PlayerCount] INT          NULL,
    [NpcCount]    INT          NULL,
    [Combat]      INT          NULL,
    PRIMARY KEY CLUSTERED ([EncounterId] ASC),
    CONSTRAINT [FK_Encounters_Combats] FOREIGN KEY ([Combat]) REFERENCES [dbo].[Combats] ([CombatId])
);

