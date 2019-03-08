
-- if GreedDataBase exists, destroy it first
Create Database GreedDataBase;
Go

Create Table Characters(
	CharID		int Primary key,
	[Name]		varchar(20) not null,
	Class		varchar(7)	not null,
	Gender		varchar(6)	not null,
	MaxHealth	int			not null,
	CurrHealth	int			not null,
	MaxMana		int			not null,
	CurrMana	int			not null,
	IsDead		int			not null,
	TimesDied	int			not null,
	EquipedWeaponID int		not null,
	EquipedArmorID int		not null
);

Create Table Loot(
	LootID int Primary key,
	[Name]			varchar(20) not null,
	LootCategory	varchar(6)	not null,
	LootType		varchar(10)	not null,
	[Level]			int			null,
	MagicStat		varchar(10)	null,
	MagicStatIncre	int			null,
	Quality			int			null,
);

Create Table Enemy(
	EnemyID int Primary key,
	[Name] varchar(20) not null,
	MaxHealth	int	   not null,
	Attack		int    not null,
	Defence		int    not null,
	Speed		int    not null,
	LootChance	int    not null,
	Dificulty	int    not null,
	AreaType	varchar(10) not null
);

Create Table SaveFile(
	PartyName varchar(25) Primary key,
	Char1ID		int not null,
	Char2ID		int not null,
	Char3ID		int not null,
	Char4ID		int not null,
	[Money]		int not null,
	SHealPotion int not null,
	MHealPotion int not null,
	LHealPotion int not null,
	SManaPotion int not null,
	LManaPotion int not null,
	KillScroll	int not null,
	DoomScroll	int not null,
	WhiteFlag	int not null,
	BagSize		bit not null,
	Lanturn		bit not null,
	Area2Item	bit not null,
	Area3Item	bit not null
);