# WarpKez.Utilities

## A set of utlity classes to make some repetitive tasks easier

### Console Utilities

#### Banner

```
Padding
```

Options are:
- None
- Before
- After
- Both

If set, will add a blank line above, below or both a banner message.

```
public static string FormatedMessage(...)
```

Returns the formated banner message.

```
public static string Decorator(int Length, char Deco)
```

Returns a decorator string of a defined length.

---

### GUID Utilities

#### GUIDConvert

```
public static string GUIDtoShortURL(Guid guid)
```

Returns a BASE64 string shortened that can be used for URLS or where string length and contents have restrictions.

```
public static Guid ShortURLtoGUID(string url)
```

Converts the BASE64 shorted string back to a GUID.

```
public static List<Guid> GenerateGUIDs(int Amount=1)
public static List<GUIDModel> GenerateGUIDModels(int Amount =1)
```

Generates an amount of GUIDs.  Default is 1.

---

### JSON Utilities

#### JSON Tools

```
public static string ToJson<T>(T model)
```

Essentially a wrapper for JsonConvert.SerializeObject(..) because I cannot remember which one to use.

```
public static T FromJson<T>(string json)
```

Like above, it is a wrapper for JsonConvert.DeserializeObject because I cannot remember.