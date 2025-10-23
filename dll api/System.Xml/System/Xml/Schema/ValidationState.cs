using System;
using System.Collections.Generic;

namespace System.Xml.Schema
{
	// Token: 0x020002BF RID: 703
	internal sealed class ValidationState
	{
		// Token: 0x04000F8D RID: 3981
		public bool IsNill;

		// Token: 0x04000F8E RID: 3982
		public bool IsDefault;

		// Token: 0x04000F8F RID: 3983
		public bool NeedValidateChildren;

		// Token: 0x04000F90 RID: 3984
		public bool CheckRequiredAttribute;

		// Token: 0x04000F91 RID: 3985
		public bool ValidationSkipped;

		// Token: 0x04000F92 RID: 3986
		public XmlSchemaContentProcessing ProcessContents;

		// Token: 0x04000F93 RID: 3987
		public XmlSchemaValidity Validity;

		// Token: 0x04000F94 RID: 3988
		public SchemaElementDecl ElementDecl;

		// Token: 0x04000F95 RID: 3989
		public SchemaElementDecl ElementDeclBeforeXsi;

		// Token: 0x04000F96 RID: 3990
		public string LocalName;

		// Token: 0x04000F97 RID: 3991
		public string Namespace;

		// Token: 0x04000F98 RID: 3992
		public ConstraintStruct[] Constr;

		// Token: 0x04000F99 RID: 3993
		public StateUnion CurrentState;

		// Token: 0x04000F9A RID: 3994
		public bool HasMatched;

		// Token: 0x04000F9B RID: 3995
		public BitSet[] CurPos = new BitSet[2];

		// Token: 0x04000F9C RID: 3996
		public BitSet AllElementsSet;

		// Token: 0x04000F9D RID: 3997
		public List<RangePositionInfo> RunningPositions;

		// Token: 0x04000F9E RID: 3998
		public bool TooComplex;
	}
}
