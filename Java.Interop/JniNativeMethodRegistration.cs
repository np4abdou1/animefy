using System;

namespace Java.Interop
{
	// Token: 0x0200006A RID: 106
	public struct JniNativeMethodRegistration
	{
		// Token: 0x06000395 RID: 917 RVA: 0x0000DBE8 File Offset: 0x0000BDE8
		public JniNativeMethodRegistration(string name, string signature, Delegate marshaler)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			this.Name = name;
			if (signature == null)
			{
				throw new ArgumentNullException("signature");
			}
			this.Signature = signature;
			if (marshaler == null)
			{
				throw new ArgumentNullException("marshaler");
			}
			this.Marshaler = marshaler;
		}

		// Token: 0x040000F1 RID: 241
		public string Name;

		// Token: 0x040000F2 RID: 242
		public string Signature;

		// Token: 0x040000F3 RID: 243
		public Delegate Marshaler;
	}
}
