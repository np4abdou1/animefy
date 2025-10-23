using System;
using System.Runtime.InteropServices;

namespace System.Xml.Schema
{
	// Token: 0x020002BE RID: 702
	[StructLayout(2)]
	internal struct StateUnion
	{
		// Token: 0x04000F89 RID: 3977
		[FieldOffset(0)]
		public int State;

		// Token: 0x04000F8A RID: 3978
		[FieldOffset(0)]
		public int AllElementsRequired;

		// Token: 0x04000F8B RID: 3979
		[FieldOffset(0)]
		public int CurPosIndex;

		// Token: 0x04000F8C RID: 3980
		[FieldOffset(0)]
		public int NumberOfRunningPos;
	}
}
