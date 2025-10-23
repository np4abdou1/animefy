using System;
using System.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x0200034C RID: 844
	internal class Axis : AstNode
	{
		// Token: 0x06001D52 RID: 7506 RVA: 0x000AB8B1 File Offset: 0x000A9AB1
		public Axis(Axis.AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype)
		{
			this._axisType = axisType;
			this._input = input;
			this._prefix = prefix;
			this._name = name;
			this._nodeType = nodetype;
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x000AB8E9 File Offset: 0x000A9AE9
		public Axis(Axis.AxisType axisType, AstNode input) : this(axisType, input, string.Empty, string.Empty, XPathNodeType.All)
		{
			this.abbrAxis = true;
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x0000A216 File Offset: 0x00008416
		public override AstNode.AstType Type
		{
			get
			{
				return AstNode.AstType.Axis;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x0004E85B File Offset: 0x0004CA5B
		public override XPathResultType ReturnType
		{
			get
			{
				return XPathResultType.NodeSet;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x000AB906 File Offset: 0x000A9B06
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x000AB90E File Offset: 0x000A9B0E
		public AstNode Input
		{
			get
			{
				return this._input;
			}
			set
			{
				this._input = value;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x000AB917 File Offset: 0x000A9B17
		public string Prefix
		{
			get
			{
				return this._prefix;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x000AB91F File Offset: 0x000A9B1F
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x000AB927 File Offset: 0x000A9B27
		public XPathNodeType NodeType
		{
			get
			{
				return this._nodeType;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x000AB92F File Offset: 0x000A9B2F
		public Axis.AxisType TypeOfAxis
		{
			get
			{
				return this._axisType;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x000AB937 File Offset: 0x000A9B37
		public bool AbbrAxis
		{
			get
			{
				return this.abbrAxis;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x000AB93F File Offset: 0x000A9B3F
		// (set) Token: 0x06001D5E RID: 7518 RVA: 0x000AB947 File Offset: 0x000A9B47
		public string Urn
		{
			get
			{
				return this._urn;
			}
			set
			{
				this._urn = value;
			}
		}

		// Token: 0x04001313 RID: 4883
		private Axis.AxisType _axisType;

		// Token: 0x04001314 RID: 4884
		private AstNode _input;

		// Token: 0x04001315 RID: 4885
		private string _prefix;

		// Token: 0x04001316 RID: 4886
		private string _name;

		// Token: 0x04001317 RID: 4887
		private XPathNodeType _nodeType;

		// Token: 0x04001318 RID: 4888
		protected bool abbrAxis;

		// Token: 0x04001319 RID: 4889
		private string _urn = string.Empty;

		// Token: 0x0200034D RID: 845
		public enum AxisType
		{
			// Token: 0x0400131B RID: 4891
			Ancestor,
			// Token: 0x0400131C RID: 4892
			AncestorOrSelf,
			// Token: 0x0400131D RID: 4893
			Attribute,
			// Token: 0x0400131E RID: 4894
			Child,
			// Token: 0x0400131F RID: 4895
			Descendant,
			// Token: 0x04001320 RID: 4896
			DescendantOrSelf,
			// Token: 0x04001321 RID: 4897
			Following,
			// Token: 0x04001322 RID: 4898
			FollowingSibling,
			// Token: 0x04001323 RID: 4899
			Namespace,
			// Token: 0x04001324 RID: 4900
			Parent,
			// Token: 0x04001325 RID: 4901
			Preceding,
			// Token: 0x04001326 RID: 4902
			PrecedingSibling,
			// Token: 0x04001327 RID: 4903
			Self,
			// Token: 0x04001328 RID: 4904
			None
		}
	}
}
