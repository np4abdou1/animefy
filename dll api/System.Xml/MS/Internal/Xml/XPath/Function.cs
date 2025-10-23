using System;
using System.Collections.Generic;
using System.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x0200034F RID: 847
	internal class Function : AstNode
	{
		// Token: 0x06001D62 RID: 7522 RVA: 0x000AB966 File Offset: 0x000A9B66
		public Function(Function.FunctionType ftype, List<AstNode> argumentList)
		{
			this._functionType = ftype;
			this._argumentList = new List<AstNode>(argumentList);
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x000AB981 File Offset: 0x000A9B81
		public Function(string prefix, string name, List<AstNode> argumentList)
		{
			this._functionType = Function.FunctionType.FuncUserDefined;
			this._prefix = prefix;
			this._name = name;
			this._argumentList = new List<AstNode>(argumentList);
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x000AB9AB File Offset: 0x000A9BAB
		public Function(Function.FunctionType ftype, AstNode arg)
		{
			this._functionType = ftype;
			this._argumentList = new List<AstNode>();
			this._argumentList.Add(arg);
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x00046FFF File Offset: 0x000451FF
		public override AstNode.AstType Type
		{
			get
			{
				return AstNode.AstType.Function;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x000AB9D1 File Offset: 0x000A9BD1
		public override XPathResultType ReturnType
		{
			get
			{
				return Function.ReturnTypes[(int)this._functionType];
			}
		}

		// Token: 0x0400132B RID: 4907
		private Function.FunctionType _functionType;

		// Token: 0x0400132C RID: 4908
		private List<AstNode> _argumentList;

		// Token: 0x0400132D RID: 4909
		private string _name;

		// Token: 0x0400132E RID: 4910
		private string _prefix;

		// Token: 0x0400132F RID: 4911
		internal static XPathResultType[] ReturnTypes = new XPathResultType[]
		{
			XPathResultType.Number,
			XPathResultType.Number,
			XPathResultType.Number,
			XPathResultType.NodeSet,
			XPathResultType.String,
			XPathResultType.String,
			XPathResultType.String,
			XPathResultType.String,
			XPathResultType.Boolean,
			XPathResultType.Number,
			XPathResultType.Boolean,
			XPathResultType.Boolean,
			XPathResultType.Boolean,
			XPathResultType.String,
			XPathResultType.Boolean,
			XPathResultType.Boolean,
			XPathResultType.String,
			XPathResultType.String,
			XPathResultType.String,
			XPathResultType.Number,
			XPathResultType.String,
			XPathResultType.String,
			XPathResultType.Boolean,
			XPathResultType.Number,
			XPathResultType.Number,
			XPathResultType.Number,
			XPathResultType.Number,
			XPathResultType.Any
		};

		// Token: 0x02000350 RID: 848
		public enum FunctionType
		{
			// Token: 0x04001331 RID: 4913
			FuncLast,
			// Token: 0x04001332 RID: 4914
			FuncPosition,
			// Token: 0x04001333 RID: 4915
			FuncCount,
			// Token: 0x04001334 RID: 4916
			FuncID,
			// Token: 0x04001335 RID: 4917
			FuncLocalName,
			// Token: 0x04001336 RID: 4918
			FuncNameSpaceUri,
			// Token: 0x04001337 RID: 4919
			FuncName,
			// Token: 0x04001338 RID: 4920
			FuncString,
			// Token: 0x04001339 RID: 4921
			FuncBoolean,
			// Token: 0x0400133A RID: 4922
			FuncNumber,
			// Token: 0x0400133B RID: 4923
			FuncTrue,
			// Token: 0x0400133C RID: 4924
			FuncFalse,
			// Token: 0x0400133D RID: 4925
			FuncNot,
			// Token: 0x0400133E RID: 4926
			FuncConcat,
			// Token: 0x0400133F RID: 4927
			FuncStartsWith,
			// Token: 0x04001340 RID: 4928
			FuncContains,
			// Token: 0x04001341 RID: 4929
			FuncSubstringBefore,
			// Token: 0x04001342 RID: 4930
			FuncSubstringAfter,
			// Token: 0x04001343 RID: 4931
			FuncSubstring,
			// Token: 0x04001344 RID: 4932
			FuncStringLength,
			// Token: 0x04001345 RID: 4933
			FuncNormalize,
			// Token: 0x04001346 RID: 4934
			FuncTranslate,
			// Token: 0x04001347 RID: 4935
			FuncLang,
			// Token: 0x04001348 RID: 4936
			FuncSum,
			// Token: 0x04001349 RID: 4937
			FuncFloor,
			// Token: 0x0400134A RID: 4938
			FuncCeiling,
			// Token: 0x0400134B RID: 4939
			FuncRound,
			// Token: 0x0400134C RID: 4940
			FuncUserDefined
		}
	}
}
