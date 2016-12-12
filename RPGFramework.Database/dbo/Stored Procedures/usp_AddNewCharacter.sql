-- =============================================
-- Author:		Thomas Hanby
-- Create date: 12/1/16
-- Description:	Add a new character
-- =============================================
CREATE PROCEDURE usp_AddNewCharacter 
	-- Add the parameters for the stored procedure here
	@name varchar(50)
	, @class varchar(50)
	, @health int
	, @spirit int
	, @physical int
	, @grit int
	, @magick int
	, @dexterity int
	, @focus int
	, @primaryAttack int
	, @secondaryAttack int
	, @primaryAttackType varchar(50)
	, @secondaryAttackType varchar(50)
	, @gender varchar(50)
	, @humour varchar(50)
	, @damageTaken int = 0
	, @alive bit = 1
	, @encounter int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Characters (
		Name
		, Class
		, Health
		, Spirit
		, Physical
		, Grit
		, Magick
		, Dexterity
		, Focus
		, PrimaryAttack
		, SecondaryAttack
		, PrimaryAttackType
		, SecondaryAttackType
		, Gender
		, Humour
		, DamageTaken
		, Alive
		, Encounter
	)
	VALUES (
		@name
		, @class
		, @health
		, @spirit
		, @physical
		, @grit
		, @magick
		, @dexterity
		, @focus
		, @primaryAttack
		, @secondaryAttack
		, @primaryAttackType
		, @secondaryAttackType
		, @gender
		, @humour
		, @damageTaken
		, @alive
		, @encounter
	)
END