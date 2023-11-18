namespace BiSharper.Rv.Param.Models.Value;

[AttributeUsage(AttributeTargets.Struct)]
public class ParamValueAttribute(ParamValueType type, ParamOperatorType supportedOperators = ParamOperatorType.Assign) : Attribute
{
    public ParamValueType ValueType { get; } = type;
    public ParamOperatorType SupportedOperators { get; } = supportedOperators;
}