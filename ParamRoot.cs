using System.Collections.Concurrent;
using BiSharper.Rv.Param.Models;
using BiSharper.Rv.Param.Models.Statement;
using BiSharper.Rv.Param.Models.Value;

namespace BiSharper.Rv.Param;

public partial class ParamRoot(string name) : BaseParamContext(name);