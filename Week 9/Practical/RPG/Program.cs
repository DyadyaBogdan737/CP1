// See https://aka.ms/new-console-template for more information
using RPG;

Console.WriteLine("Hello, World!");

GameCharacter me = new();

me.CharState = CharacterState.Dead;
me.CharState = CharacterState.Alive;
Console.WriteLine($"The state of the character is {me.CharState}");

