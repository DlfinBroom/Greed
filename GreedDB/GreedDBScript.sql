
use master;
if EXISTS(select * from sys.databases where name='GreedDB')
drop database GreedDB;
go

Create Database GreedDB;
Go

use GreedDB
go

Create Table Loot(
	LootID			int Primary key,
	LootName		varchar(20) not null,
	LootCategory	varchar(6)	not null,
	LootType		varchar(10)	not null,
	[Level]			int			null,
	MagicStat		varchar(10)	null,
	MagicStatIncre	int			null,
	Quality			int			null,
);

Create Table Characters(
	CharID			int Primary key,
	[Name]			varchar(20) not null,
	Class			varchar(7)	not null,
	Gender			varchar(6)	not null,
	MaxHealth		int			not null,
	CurrHealth		int			not null,
	MaxMana			int			not null,
	CurrMana		int			not null,
	IsDead			int			not null,
	TimesDied		int			not null,
	EquipArmorID	int foreign key references Loot(LootID) not null,
	EquipWeaponID	int foreign key references Loot(LootID) not null
);

Create Table Enemy(
	EnemyID int Primary key,
	[Name] varchar(20)		not null,
	MaxHealth	int			not null,
	Attack		int			not null,
	Defence		int			not null,
	Speed		int			not null,
	LootChance	int			not null,
	Dificulty	int			not null,
	AreaType	varchar(10) not null
);

Create Table SaveFile(
	PartyName varchar(25) Primary key,
	Char1ID		int foreign key references [Character](CharID),
	Char2ID		int foreign key references [Character](CharID),
	Char3ID		int foreign key references [Character](CharID),
	Char4ID		int foreign key references [Character](CharID),
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

Insert into Loot
(
	LootID, LootName, LootCategory, LootType
)
Values
	(1, 'Sages Scroll', 'Weapon', 'SpellBook'),
	(2, 'Grimoire', 'Weapon', 'SpellBook'),
	(3, 'Necronomicon', 'Weapon', 'SpellBook'),
	(4, 'Diary', 'Weapon', 'SpellBook'),
	(5, 'Old Oak Wand', 'Weapon', 'Wand'),
	(6, 'Magic Deak Snake', 'Weapon', 'Wand'),
	(7, 'Powerfull Sparkler', 'Weapon', 'Wand'),
	(8, 'WandName', 'Weapon', 'Wand'),
	(9,  'Walking Stick', 'Weapon', 'Staff'),
	(10, '[Staff1]', 'Weapon', 'Staff'),
	(11, '[Staff2]', 'Weapon', 'Staff'),
	(12, '[Staff3]', 'Weapon', 'Staff'),
	(13, '[Staff4]', 'Weapon', 'Staff'),
	(14, '[Talisman1]', 'Weapon', 'Talisman'),
	(15, '[Talisman2]', 'Weapon', 'Talisman'),
	(16, '[Talisman3]', 'Weapon', 'Talisman'),
	(17, '[Talisman4]', 'Weapon', 'Talisman'),
	(18, 'Club', 'Weapon', 'Mace'),
	(19, 'Morningstar', 'Weapon', 'Mace'),
	(20, 'Flail', 'Weapon', 'Mace'),
	(21, 'Shark-on-a-stick', 'Weapon', 'Mace'),
	(22, '[Mace2]', 'Weapon', 'Mace'),
	(23, 'Lucerne', 'Weapon', 'WarHammer'),
	(24, 'Blacksmith Hammer', 'Weapon', 'WarHammer'),
	(25, 'Warpick', 'Weapon', 'WarHammer'),
	(26, '[Warhammer1]', 'Weapon', 'WarHammer'),
	(27, 'Fire Poker', 'Weapon', 'Spear'),
	(28, 'Lance', 'Weapon', 'Spear'),
	(29, 'Trident', 'Weapon', 'Spear'),
	(30, 'Pike', 'Weapon', 'Spear'),
	(31, 'Javelin', 'Weapon', 'Spear'),
	(32, '[Axe1]', 'Weapon', 'Axe'),
	(33, '[Axe2]', 'Weapon', 'Axe'),
	(34, '[Axe3]', 'Weapon', 'Axe'),
	(35, '[Axe4]', 'Weapon', 'Axe'),
	(36, 'Long Sword', 'Weapon', 'Sword'),
	(37, 'Scimitar', 'Weapon', 'Sword'),
	(38, 'Falchin', 'Weapon', 'Sword'),
	(39, 'Gladius', 'Weapon', 'Sword'),
	(40, '[Sword1]', 'Weapon', 'Sword'),
	(41, 'Kitchen Knife', 'Weapon', 'Knife'),
	(42, 'Sacrifical Dagger', 'Weapon', 'Knife'),
	(43, 'Harpe', 'Weapon', 'Knife'),
	(44, 'Bandits Knife', 'Weapon', 'Knife'),
	(45, '[Crossbow1]', 'Weapon', 'Crossbow'),
	(46, '[Crossbow2]', 'Weapon', 'Crossbow'),
	(47, '[Crossbow3]', 'Weapon', 'Crossbow'),
	(48, '[Crossbow4]', 'Weapon', 'Crossbow'),
	(49, '[Crossbow5]', 'Weapon', 'Crossbow'),
	(50, 'Longbow', 'Weapon', 'Bow'),
	(51, '[Bow1]', 'Weapon', 'Bow'),
	(52, '[Bow2]', 'Weapon', 'Bow'),
	(53, '[Bow3]', 'Weapon', 'Bow'),
	(54, 'Dart Gun', 'Weapon', 'Blowgun'),
	(55, 'Bendy Straw', 'Weapon', 'Blowgun'),
	(56, '[Blowgun1]', 'Weapon', 'Blowgun'),
	(57, '[Blowgun2]', 'Weapon', 'Blowgun')