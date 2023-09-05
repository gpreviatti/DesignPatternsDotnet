using System.Diagnostics;
using ChainOfResponsibility;
using Commons.Models;

var keyboard = new Item
{
    Id = 1,
    Value = 250
};

var resultKeyboard = new CalculateDiscount().Execute(keyboard.Value);
Console.WriteLine(resultKeyboard);
Debug.Assert(resultKeyboard.Equals(200));

var computer = new Item
{
    Id = 2,
    Value = 1000
};

var resultComputer = new CalculateDiscount().Execute(computer.Value);
Console.WriteLine(resultComputer);
Debug.Assert(resultComputer.Equals(500));