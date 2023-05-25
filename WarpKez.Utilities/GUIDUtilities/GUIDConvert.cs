namespace WarpKez.Utilities.GUIDUtilities;

public static class GuidConvert
{
    /// <summary>
    /// Generate a Base64 string from GUID
    /// </summary>
    /// <param name="guid"></param>
    /// <returns></returns>
    public static string GUIDtoShortURL(Guid guid) => Convert.ToBase64String(guid.ToByteArray())
        .Replace("/", "-")
        .Replace("+", "_")
        .Replace("=", string.Empty);

    /// <summary>
    /// Generate GUID from Base64
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static Guid ShortURLtoGUID(string url) => new(Convert.FromBase64String(url
        .Replace("-", "/")
        .Replace("_", "+") + "=="));

    /// <summary>
    /// Generate a new GUID
    /// </summary>
    /// <returns></returns>
    public static Guid GenerateGUID() => Guid.NewGuid();

    /// <summary>
    /// Return a List of Generated GUIDs
    /// </summary>
    /// <param name="Amount"></param>
    /// <returns></returns>
    public static List<Guid> GenerateGUIDs(int Amount = 1)
    {
        Amount = Amount < 0 ? -Amount : Amount;

        var list = new List<Guid>();
        for (int i = 0; i < Amount; i++)
        {
            list.Add(GenerateGUID());
        }
        return list;
    }

    /// <summary>
    /// Return a List of Generated GUIDs
    /// </summary>
    /// <param name="Amount"></param>
    /// <returns></returns>
    public static List<GUIDModel> GenerateGUIDModels(int Amount =1)
    {
        Amount = Amount < 0 ? -Amount : Amount;

        var list = new List<GUIDModel>();
        for (int i = 0;i < Amount;i++)
        {
            var _guid = GenerateGUID();
            GUIDModel model = new()
            {
                Id = i,
                GUID = _guid,
                ShortURL = GUIDtoShortURL(_guid)
            };

            list.Add(model);
        }

        return list;
    }
}