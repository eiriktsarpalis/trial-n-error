namespace ClassLibrary1;

public static class ClassLibrary
{
    public static object CreateMetadata() => new System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<int> { ObjectCreator = () => 42 };
}