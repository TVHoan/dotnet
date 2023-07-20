namespace dotnetbase.Data;

public class DataSeedContext
{
    public DataSeedContext()
    {
        Properties = new Dictionary<string, object>();
    }

    public Dictionary<string,object> Properties { get; }
    
    public object this[string name] {
        get => Properties[name];
        set => Properties[name] = value;
    }
    // Set propertiy
    public virtual DataSeedContext WithProperty(string key, object value)
    {
        Properties[key] = value;
        return this;
    }
}