using System;

namespace Java.Interop
{
	// Token: 0x02000088 RID: 136
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JniTypeSignatureAttribute : Attribute
	{
		// Token: 0x06000470 RID: 1136 RVA: 0x000107CF File Offset: 0x0000E9CF
		public JniTypeSignatureAttribute(string simpleReference)
		{
			JniRuntime.JniTypeManager.AssertSimpleReference(simpleReference, "simpleReference");
			this.SimpleReference = simpleReference;
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x000107E9 File Offset: 0x0000E9E9
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x000107F1 File Offset: 0x0000E9F1
		public bool IsKeyword { get; set; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x000107FA File Offset: 0x0000E9FA
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00010802 File Offset: 0x0000EA02
		public string SimpleReference { get; private set; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0001080B File Offset: 0x0000EA0B
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00010813 File Offset: 0x0000EA13
		public int ArrayRank
		{
			get
			{
				return this.arrayRank;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("ArrayRank cannot be less than zero.", "value");
				}
				this.arrayRank = value;
			}
		}

		// Token: 0x0400013D RID: 317
		private int arrayRank;
	}
}
