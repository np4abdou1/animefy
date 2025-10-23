using System;
using System.Runtime.CompilerServices;

namespace Java.Interop
{
	// Token: 0x02000066 RID: 102
	public sealed class JniFieldInfo
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0000D952 File Offset: 0x0000BB52
		// (set) Token: 0x06000383 RID: 899 RVA: 0x0000D95A File Offset: 0x0000BB5A
		public IntPtr ID { get; private set; }

		// Token: 0x17000068 RID: 104
		// (set) Token: 0x06000384 RID: 900 RVA: 0x0000D963 File Offset: 0x0000BB63
		private bool IsStatic
		{
			[CompilerGenerated]
			set
			{
				this.<IsStatic>k__BackingField = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0000D96C File Offset: 0x0000BB6C
		internal bool IsValid
		{
			get
			{
				return this.ID != IntPtr.Zero;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0000256C File Offset: 0x0000076C
		public string Name
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0000256C File Offset: 0x0000076C
		public string Signature
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000D97E File Offset: 0x0000BB7E
		public JniFieldInfo(IntPtr fieldID, bool isStatic)
		{
			this.ID = fieldID;
			this.IsStatic = isStatic;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000D994 File Offset: 0x0000BB94
		public JniFieldInfo(string name, string signature, IntPtr fieldID, bool isStatic)
		{
			this.ID = fieldID;
			this.IsStatic = isStatic;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000D9AC File Offset: 0x0000BBAC
		public override string ToString()
		{
			bool flag = false;
			bool flag2 = false;
			return string.Format("JniFieldInfo({0}{1}{2}{3}ID=0x{4})", new object[]
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
