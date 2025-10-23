using System;
using System.Runtime.CompilerServices;

namespace Java.Interop
{
	// Token: 0x0200006D RID: 109
	public struct JniObjectReference : IEquatable<JniObjectReference>
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000397 RID: 919 RVA: 0x0000DC56 File Offset: 0x0000BE56
		// (set) Token: 0x06000398 RID: 920 RVA: 0x0000DC5E File Offset: 0x0000BE5E
		public IntPtr Handle { [MethodImpl(MethodImplOptions.AggressiveInlining)] readonly get; private set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000399 RID: 921 RVA: 0x0000DC67 File Offset: 0x0000BE67
		public JniObjectReferenceType Type
		{
			get
			{
				return (JniObjectReferenceType)(this.referenceInfo & 65535U);
			}
		}

		// Token: 0x17000073 RID: 115
		// (set) Token: 0x0600039A RID: 922 RVA: 0x0000DC75 File Offset: 0x0000BE75
		internal JniObjectReferenceFlags Flags
		{
			set
			{
				this.referenceInfo |= (uint)(value & (JniObjectReferenceFlags)4294901760U);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0000DC8B File Offset: 0x0000BE8B
		public bool IsValid
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this.Handle != IntPtr.Zero;
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000DC9D File Offset: 0x0000BE9D
		public JniObjectReference(IntPtr handle, JniObjectReferenceType type = JniObjectReferenceType.Invalid)
		{
			this.referenceInfo = (uint)type;
			this.Handle = handle;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
		public override int GetHashCode()
		{
			return this.Handle.GetHashCode();
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000DCCC File Offset: 0x0000BECC
		public override bool Equals(object obj)
		{
			JniObjectReference? jniObjectReference = obj as JniObjectReference?;
			return jniObjectReference != null && this.Equals(jniObjectReference.Value);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000DCFD File Offset: 0x0000BEFD
		public bool Equals(JniObjectReference other)
		{
			return this.Handle == other.Handle;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000DD11 File Offset: 0x0000BF11
		public JniObjectReference NewGlobalRef()
		{
			return JniEnvironment.Runtime.ObjectReferenceManager.CreateGlobalReference(this);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000DD28 File Offset: 0x0000BF28
		public JniObjectReference NewLocalRef()
		{
			return JniEnvironment.Runtime.ObjectReferenceManager.CreateLocalReference(JniEnvironment.CurrentInfo, this);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000DD44 File Offset: 0x0000BF44
		internal void Invalidate()
		{
			this.Handle = IntPtr.Zero;
			this.referenceInfo = 0U;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000DD58 File Offset: 0x0000BF58
		public override string ToString()
		{
			return "0x" + this.Handle.ToString("x") + "/" + JniObjectReference.ToString(this.Type);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000DD92 File Offset: 0x0000BF92
		private static string ToString(JniObjectReferenceType type)
		{
			switch (type)
			{
			case JniObjectReferenceType.Invalid:
				return "I";
			case JniObjectReferenceType.Local:
				return "L";
			case JniObjectReferenceType.Global:
				return "G";
			case JniObjectReferenceType.WeakGlobal:
				return "W";
			default:
				return type.ToString();
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000DDD4 File Offset: 0x0000BFD4
		public static void Dispose(ref JniObjectReference reference)
		{
			if (!reference.IsValid)
			{
				return;
			}
			switch (reference.Type)
			{
			case JniObjectReferenceType.Local:
				JniEnvironment.Runtime.ObjectReferenceManager.DeleteLocalReference(JniEnvironment.CurrentInfo, ref reference);
				break;
			case JniObjectReferenceType.Global:
				JniEnvironment.Runtime.ObjectReferenceManager.DeleteGlobalReference(ref reference);
				break;
			case JniObjectReferenceType.WeakGlobal:
				JniEnvironment.Runtime.ObjectReferenceManager.DeleteWeakGlobalReference(ref reference);
				break;
			default:
				throw new NotImplementedException("Do not know how to dispose: " + reference.Type.ToString() + ".");
			}
			reference.Invalidate();
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000DE71 File Offset: 0x0000C071
		public static void Dispose(ref JniObjectReference reference, JniObjectReferenceOptions options)
		{
			if (options == JniObjectReferenceOptions.None)
			{
				return;
			}
			if (!reference.IsValid)
			{
				return;
			}
			if ((options & (JniObjectReferenceOptions)2) == JniObjectReferenceOptions.None)
			{
				return;
			}
			JniObjectReference.Dispose(ref reference);
		}

		// Token: 0x040000FA RID: 250
		private uint referenceInfo;
	}
}
