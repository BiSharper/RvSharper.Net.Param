﻿using System.Collections;
using System.Collections.Concurrent;
using BiSharper.Rv.Param.Models.Statement;

namespace BiSharper.Rv.Param.Models.Value;

[ParamValue(
    ParamValueType.Array, ParamOperatorType.ArrayOperations)]
public readonly struct ParamArray : IEnumerable<IParamValue>
{

    public required ConcurrentBag<IParamValue> Values { get; init; } = new();
    public required IParamContext ParentContext { get; init; }

    public ParamArray()
    {
    }
    
    public static implicit operator ConcurrentBag<IParamValue>(ParamArray self) => self.Values;
    
    public IEnumerator<IParamValue> GetEnumerator() => Values.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public string ToText() =>
        '{' + string.Join(", ", this.Select(s => s.ToText())) + '}';
}