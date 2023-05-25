namespace WarpKez.Utilities.ConsoleUtilities;

public class MessageModel
{
    public char Decorator = '*';
    public string Message { get; set; } = "   Hello World   ";
    public Padding Pad { get; set; } = Padding.None;
}
