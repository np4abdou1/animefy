using System;
using System.Runtime.CompilerServices;

namespace Java.Interop
{
	// Token: 0x02000069 RID: 105
	public sealed class JniMethodInfo
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0000DAF4 File Offset: 0x0000BCF4
		// (set) Token: 0x0600038D RID: 909 RVA: 0x0000DAFC File Offset: 0x0000BCFC
		public IntPtr ID { get; private set; }

		// Token: 0x1700006D RID: 109
		// (set) Token: 0x0600038E RID: 910 RVA: 0x0000DB05 File Offset: 0x0000BD05
		private bool IsStatic
		{
			[CompilerGenerated]
			set
			{
				this.<IsStatic>k__BackingField = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0000DB0E File Offset: 0x0000BD0E
		internal bool IsValid
		{
			get
			{
				return this.ID != IntPtr.Zero;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0000256C File Offset: 0x0000076C
		public string Name
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000391 RID: 913 RVA: 0x0000256C File Offset: 0x0000076C
		public string Signature
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000DB20 File Offset: 0x0000BD20
		public JniMethodInfo(IntPtr methodID, bool isStatic)
		{
			this.ID = methodID;
			this.IsStatic = isStatic;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000DB36 File Offset: 0x0000BD36
		public JniMethodInfo(string name, string signature, IntPtr methodID, bool isStatic)
		{
			this.ID = methodID;
			this.IsStatic = isStatic;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000DB50 File Offset: 0x0000BD50
		public override string ToString()
		{
			bool flag = false;
			bool flag2 = false;
			return string.Format("JniMethodInfo({0}{1}{2}{3}ID=0x{4})", new object[]
			{
				flag ? ("Name=" + this.Name) : string.Empty,
				flag ? ", " : string.Empty,
				flag2 ? ("Signature=" + this.Signature) : string.Empty,
				(flag || flag2) ? ", " : string.Empty,
				this.ID.ToString("x")
			});
		}
	}
}
