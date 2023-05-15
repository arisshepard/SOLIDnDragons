// See https://aka.ms/new-console-template for more information

// Single Reponsibility OK
using Lsp.Ok;
using SingleResponsibility.Ok;
using CharacterSingleR = SingleResponsibility.Ok.Character;
using CharacterOc = OpenClose.Ok.Character;
using OpenClose.Ok;
using Microsoft.Extensions.DependencyInjection;
using DependencyInversion.Ok;
using DragonDI = DependencyInversion.Ok.Dragon;
using IDragonDI = DependencyInversion.Ok.IDragon;
using FireDragonIs = InterfaceSegregation.Ok.FireDragon;

// Dependencies
var serviceProvider = new ServiceCollection()
            .AddSingleton<IDragonDI, DragonDI>()
            .AddTransient<Player>()
            .BuildServiceProvider();

var combat = new Combat();
var characterOne = new CharacterSingleR(){Name = "", Race = "", Class = ""};
var characterTwo = new CharacterSingleR(){Name = "", Race = "", Class = ""};

combat.Attack(characterOne, characterTwo);

// Lsp
var dragonController = new DragonController();
dragonController.UnleashDragons();

// OC
var character = new CharacterOc();
var weapon = new Sword();
character.Attack(weapon);

// IS
var fireDragon = new FireDragonIs();
fireDragon.BreathFire();

// DI
 var player = serviceProvider.GetService<Player>();
 player?.FightDragon();


