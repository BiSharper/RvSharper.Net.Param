namespace BiSharper.Rv.Param.Models.Value;

public interface IParamValue
{
    public string ToText();

    public bool SupportsOperator(ParamOperatorType op) =>
        (this.GetMetadata().SupportedOperators & op) == op;
}

public static class ParamValueExtension
{
    private static readonly Dictionary<Type, ParamValueAttribute> ValueMeta = new();

    internal static ParamValueAttribute GetMetadata(this IParamValue value)
    {
        var valueType = value.GetType();
        var attribute = ValueMeta.GetValueOrDefault(valueType);
        if (attribute is not null) return attribute;
        var metadata = Attribute.GetCustomAttributes(valueType).OfType<ParamValueAttribute>().FirstOrDefault() ?? throw new Exception("Class must have the ParamValueAttribute.");
        ValueMeta[valueType] = attribute = metadata;
        return attribute;
    }
}