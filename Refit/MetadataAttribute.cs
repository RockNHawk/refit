namespace System.Reflection;

public class MetadataAttribute : Attribute
{
    public string Name { get; set; }
    public string Value { get; set; }
}

/// <summary>
/// add MethodName metadata to avoid the API interface's method name obfuscated
/// </summary>
public class MethodNameAttribute : Attribute
{
    public MethodNameAttribute(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}
