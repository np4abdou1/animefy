using System;
using Java.Interop;

namespace Android.Runtime
{
	// Token: 0x020002B6 RID: 694
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
	public sealed class RegisterAttribute : Attribute, IJniNameProviderAttribute
	{
		// Token: 0x06001A79 RID: 6777 RVA: 0x000448B8 File Offset: 0x00042AB8
		public RegisterAttribute(string name)
		{
			this.name = name;
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x000448C7 File Offset: 0x00042AC7
		public RegisterAttribute(string name, string signature, string connector) : this(name)
		{
			this.connector = connector;
			this.signature = signature;
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x000448DE File Offset: 0x00042ADE
		// (set) Token: 0x06001A7C RID: 6780 RVA: 0x000448E6 File Offset: 0x00042AE6
		public string Connector
		{
			get
			{
				return this.connector;
			}
			set
			{
				this.connector = value;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001A7D RID: 6781 RVA: 0x000448EF File Offset: 0x00042AEF
		// (set) Token: 0x06001A7E RID: 6782 RVA: 0x000448F7 File Offset: 0x00042AF7
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001A7F RID: 6783 RVA: 0x00044900 File Offset: 0x00042B00
		// (set) Token: 0x06001A80 RID: 6784 RVA: 0x00044908 File Offset: 0x00042B08
		public string Signature
		{
			get
			{
				return this.signature;
			}
			set
			{
				this.signature = value;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001A81 RID: 6785 RVA: 0x00044911 File Offset: 0x00042B11
		// (set) Token: 0x06001A82 RID: 6786 RVA: 0x00044919 File Offset: 0x00042B19
		public bool DoNotGenerateAcw { get; set; }

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001A83 RID: 6787 RVA: 0x00044922 File Offset: 0x00042B22
		// (set) Token: 0x06001A84 RID: 6788 RVA: 0x0004492A File Offset: 0x00042B2A
		public int ApiSince { get; set; }

		// Token: 0x04000B60 RID: 2912
		private string connector;

		// Token: 0x04000B61 RID: 2913
		private string name;

		// Token: 0x04000B62 RID: 2914
		private string signature;
	}
}
