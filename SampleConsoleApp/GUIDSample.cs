
using WarpKez.Utilities.GUIDUtilities;

namespace SampleConsoleApp;

public static class GUIDSample
{
    public static void Example ()
    {
        var myListofGUIDS = GuidConvert.GenerateGUIDModels(5);

        Console.WriteLine($"Obtained {myListofGUIDS.Count} GUIDS");
        foreach ( var guid in myListofGUIDS )
        { Console.WriteLine($"{guid.Id,5}   {guid.GUID}   {guid.ShortURL}" ); }
    }
}
