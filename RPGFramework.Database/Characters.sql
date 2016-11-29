CREATE TABLE [dbo].[Characters]
(
	[CharacterId] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL DEFAULT 'Newbie', 
    [Class] VARCHAR(50) NOT NULL, 
    [Health] INT NOT NULL, 
    [Spirit] INT NOT NULL, 
    [Physical] INT NOT NULL, 
    [Grit] INT NOT NULL, 
    [Magick] INT NOT NULL, 
    [Dexterity] INT NOT NULL, 
    [Focus] INT NOT NULL, 
    [PrimaryAttack] INT NOT NULL, 
    [SecondaryAttack] INT NOT NULL, 
    [PrimaryAttackType] VARCHAR(50) NOT NULL, 
    [SecondaryAttackType] VARCHAR(50) NOT NULL, 
    [Gender] VARCHAR(50) NOT NULL, 
    [Humour] VARCHAR(50) NULL, 
    [LastAction] VARCHAR(50) NOT NULL, 
    [DamageTaken] INT NOT NULL DEFAULT 0, 
    [Alive] BIT NOT NULL DEFAULT 1, 
    [Encounter] INT NULL, 
    CONSTRAINT [FK_Characters_Encounters] FOREIGN KEY ([Encounter]) REFERENCES [Encounters]([EncounterId])
)
