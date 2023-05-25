// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using SampleConsoleApp;
using WarpKez.Utilities.ConsoleUtilities;

BannerSample.Example();

Console.WriteLine();
Console.WriteLine(Banner.Decorator(Console.WindowWidth*2, '+'));
Console.WriteLine();

GUIDSample.Example();