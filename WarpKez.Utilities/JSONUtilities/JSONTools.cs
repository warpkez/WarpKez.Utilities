using Newtonsoft.Json;

namespace WarpKez.Utilities.JSONUtilities;

public static class JSONTools
{
    /// <summary>
    /// Convert a model to JSON
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="model"></param>
    /// <returns></returns>
    public static string ToJson<T>(T model) => JsonConvert.SerializeObject(model, Formatting.Indented);

    /// <summary>
    /// Convert from JSON to model
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="json"></param>
    /// <returns></returns>
    public static T FromJson<T>(string json)
    {
        T? model = JsonConvert.DeserializeObject<T>(json);

        return model!;
    }
}

