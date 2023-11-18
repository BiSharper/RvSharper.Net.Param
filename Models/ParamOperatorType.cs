﻿namespace BiSharper.Rv.Param.Models;

[Flags]
public enum ParamOperatorType : byte
{
    Assign,
    AdditiveAssign,
    SubtractiveAssign,

    ArrayOperations = Assign | AdditiveAssign | SubtractiveAssign
}