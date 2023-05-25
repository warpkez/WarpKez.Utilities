namespace WarpKez.Utilities.ConsoleUtilities;

public enum Padding
{
    None,
    Before,
    After,
    Both
}

public class Banner
{
    /// <summary>
    /// Returns a formated message
    /// </summary>
    /// <param name="Message"></param>
    /// <param name="Pad"></param>
    /// <returns></returns>
    public static string FormatedMessage(string Message, Padding Pad)
    {
        return FormatMessage(Message, Pad, false);
    }

    /// <summary>
    /// Returns a formated message
    /// </summary>
    /// <param name="Message"></param>
    /// <param name="Pad"></param>
    /// <param name="UseDecorator"></param>
    /// <returns></returns>
    public static string FormatedMessage(string Message, Padding Pad, bool UseDecorator)
    {
        char Decorator = '*';

        return FormatMessage(Message, Pad, UseDecorator, Decorator);
    }

    /// <summary>
    /// Returns a formated message
    /// </summary>
    /// <param name="Message"></param>
    /// <param name="Pad"></param>
    /// <param name="UseDecorator"></param>
    /// <param name="Decorator"></param>
    /// <returns></returns>
    public static string FormatedMessage(string Message, Padding Pad, bool UseDecorator, char Decorator)
    {
        return FormatMessage(Message, Pad, UseDecorator, Decorator);
    }

    /// <summary>
    /// Returns a formated message
    /// </summary>
    /// <param name="Message"></param>
    /// <returns></returns>
    public static string FormatedMessage(MessageModel Message)
    {
        return FormatMessage(Message.Message, Message.Pad, false);
    }

    /// <summary>
    /// Returns a formated message
    /// </summary>
    /// <param name="Message"></param>
    /// <param name="UseDecorator"></param>
    /// <returns></returns>
    public static string FormatedMessage(MessageModel Message, bool UseDecorator)
    {
        return FormatMessage(Message.Message, Message.Pad, UseDecorator, Message.Decorator);
    }

    /// <summary>
    /// Create a simple decorator of defined length.
    /// </summary>
    /// <param name="Length"></param>
    /// <param name="Deco"></param>
    /// <returns></returns>
    public static string Decorator(int Length, char Deco)
    {
        string DecoString = string.Empty;
        for (int i = 0; i < Length; i++)
        {
            DecoString += Deco;
        }
        //DecoString += "\r\n";

        return DecoString;
    }

    /// <summary>
    /// Displays a message with/without padding and with/without a decorator.
    /// </summary>
    /// <param name="TheMessage"></param>
    /// <param name="padding"></param>
    /// <param name="UseDecorator"></param>
    /// <param name="Decorator"></param>
    /// <returns></returns>
    private static string FormatMessage(string TheMessage, Padding padding = Padding.None, bool UseDecorator = true, char Deco = '*')
    {
        int MessageLength = TheMessage.Length;
        string banner = "";

        if (UseDecorator)
        {
            banner  += Decorator(MessageLength,Deco) + "\r\n";
        }

        banner += TheMessage;

        if (UseDecorator)
        {
            banner += "\r\n" + Decorator(MessageLength, Deco);
        }

        switch (padding)
        {
            case Padding.None: break;
            case Padding.Before: banner = "\r\n" + banner; break;
            case Padding.After: banner += "\r\n"; break;
            case Padding.Both: banner = "\r\n" + banner + "\r\n"; break;
        }

        return banner;
    }
}