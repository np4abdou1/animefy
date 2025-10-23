using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Java.Lang
{
	// Token: 0x020003C7 RID: 967
	[Register("java/lang/Enum", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E extends java.lang.Enum<E>"
	})]
	public abstract class Enum : Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable, IComparable
	{
		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06002ABB RID: 10939 RVA: 0x000774F4 File Offset: 0x000756F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Enum._members;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06002ABC RID: 10940 RVA: 0x000774FC File Offset: 0x000756FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Enum._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06002ABD RID: 10941 RVA: 0x00077520 File Offset: 0x00075720
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Enum._members.ManagedPeerType;
			}
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Enum(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x0007752C File Offset: 0x0007572C
		public unsafe int CompareTo(Object o)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(o);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = Enum._members.InstanceMethods.InvokeNonvirtualInt32Method("compareTo.(Ljava/lang/Enum;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(o);
			}
			return result;
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x00077590 File Offset: 0x00075790
		public unsafe sealed override bool Equals(Object other)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : other.Handle);
				result = Enum._members.InstanceMethods.InvokeNonvirtualBooleanMethod("equals.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x000775F8 File Offset: 0x000757F8
		public sealed override int GetHashCode()
		{
			return Enum._members.InstanceMethods.InvokeNonvirtualInt32Method("hashCode.()I", this, null);
		}

		// Token: 0x04001139 RID: 4409
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Enum", typeof(Enum));
	}
}
