using WarpKez.Utilities.ConsoleUtilities;
namespace SampleConsoleApp;

public static class BannerSample
{
    public static void Example()
    {
        Console.WriteLine("Banner Message with no padding, no decorator:");
        Console.WriteLine(Banner.Decorator(Console.WindowWidth,'='));
        var myMessage = Banner.FormatedMessage("Testing", Padding.None);
        Console.WriteLine(myMessage);
        Console.WriteLine(Banner.Decorator(Console.WindowWidth, '='));

        Console.WriteLine();

        Console.WriteLine("Banner Message with padding above and below with default decorator:");
        Console.WriteLine(Banner.Decorator(Console.WindowWidth, '='));
        var myMessage2 = Banner.FormatedMessage(" Testing ", Padding.Both, true);
        Console.WriteLine(myMessage2);
        Console.WriteLine(Banner.Decorator(Console.WindowWidth, '='));

        Console.WriteLine();

        MessageModel MyOtherMessage = new()
        {
            Decorator = '#',
            Pad = Padding.Both
        };

        Console.WriteLine("Prepared banner Message with padding above and below, no decorator:");
        Console.WriteLine(Banner.Decorator(Console.WindowWidth, '='));
        var myMessage3 = Banner.FormatedMessage(MyOtherMessage);
        Console.WriteLine(myMessage3);
        Console.WriteLine(Banner.Decorator(Console.WindowWidth, '='));

        Console.WriteLine();

        Console.WriteLine("Prepared banner Message with padding above and below with defined decorator:");
        Console.WriteLine(Banner.Decorator(Console.WindowWidth, '='));
        var myMessage4 = Banner.FormatedMessage(MyOtherMessage, true);
        Console.WriteLine(myMessage4);
        Console.WriteLine(Banner.Decorator(Console.WindowWidth, '='));

        Console.WriteLine();
    }
}
