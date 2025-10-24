using System;

namespace System.Data
{
	// Token: 0x02000067 RID: 103
	internal sealed class Function
	{
		// Token: 0x0600074D RID: 1869 RVA: 0x00023ADC File Offset: 0x00021CDC
		internal Function(string name, FunctionId id, Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, Type a1, Type a2, Type a3)
		{
			this._name = name;
			this._id = id;
			this._result = result;
			this._isValidateArguments = IsValidateArguments;
			this._isVariantArgumentList = IsVariantArgumentList;
			this._argumentCount = argumentCount;
			if (a1 != null)
			{
				this._parameters[0] = a1;
			}
			if (a2 != null)
			{
				this._parameters[1] = a2;
			}
			if (a3 != null)
			{
				this._parameters[2] = a3;
			}
		}

		// Token: 0x04000244 RID: 580
		internal readonly string _name;

		// Token: 0x04000245 RID: 581
		internal readonly FunctionId _id;

		// Token: 0x04000246 RID: 582
		internal readonly Type _result;

		// Token: 0x04000247 RID: 583
		internal readonly bool _isValidateArguments;

		// Token: 0x04000248 RID: 584
		internal readonly bool _isVariantArgumentList;

		// Token: 0x04000249 RID: 585
		internal readonly int _argumentCount;

		// Token: 0x0400024A RID: 586
		internal readonly Type[] _parameters = new Type[3];

		// Token: 0x0400024B RID: 587
		internal static string[] s_functionName = new string[]
		{
			"Unknown",
			"Ascii",
			"Char",
			"CharIndex",
			"Difference",
			"Len",
			"Lower",
			"LTrim",
			"Patindex",
			"Replicate",
			"Reverse",
			"Right",
			"RTrim",
			"Soundex",
			"Space",
			"Str",
			"Stuff",
			"Substring",
			"Upper",
			"IsNull",
			"Iif",
			"Convert",
			"cInt",
			"cBool",
			"cDate",
			"cDbl",
			"cStr",
			"Abs",
			"Acos",
			"In",
			"Trim",
			"Sum",
			"Avg",
			"Min",
			"Max",
			"Count",
			"StDev",
			"Var",
			"DateTimeOffset"
		};
	}
}
