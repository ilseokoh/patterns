// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Models;

var url = "http://microsoft.com";
var broadcast = new FileBroadcastBuilder(url)
                        .BuildStartChime()
                        .BuildEndChime()
                        .BuildDisplayText("Builder pattern")
                        .BuildRepeat(1, 2)
                        .Builder();
Console.WriteLine(broadcast.ToString());

Console.ReadLine();