using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.Charset
{
	// Token: 0x02000395 RID: 917
	[Register("java/nio/charset/Charset", DoNotGenerateAcw = true)]
	public abstract class Charset : Java.Lang.Object, Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x00072F80 File Offset: 0x00071180
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Charset._members;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x00072F88 File Offset: 0x00071188
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Charset._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x00072FAC File Offset: 0x000711AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Charset._members.ManagedPeerType;
			}
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Charset(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x00072FB8 File Offset: 0x000711B8
		public unsafe int CompareTo(Charset that)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((that == null) ? IntPtr.Zero : that.Handle);
				result = Charset._members.InstanceMethods.InvokeNonvirtualInt32Method("compareTo.(Ljava/nio/charset/Charset;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(that);
			}
			return result;
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x00073020 File Offset: 0x00071220
		public unsafe sealed override bool Equals(Java.Lang.Object ob)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ob == null) ? IntPtr.Zero : ob.Handle);
				result = Charset._members.InstanceMethods.InvokeNonvirtualBooleanMethod("equals.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ob);
			}
			return result;
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x00073088 File Offset: 0x00071288
		public sealed override int GetHashCode()
		{
			return Charset._members.InstanceMethods.InvokeNonvirtualInt32Method("hashCode.()I", this, null);
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x000730A4 File Offset: 0x000712A4
		public sealed override string ToString()
		{
			return JNIEnv.GetString(Charset._members.InstanceMethods.InvokeNonvirtualObjectMethod("toString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x000730D6 File Offset: 0x000712D6
		int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
		{
			return this.CompareTo(o.JavaCast<Charset>());
		}

		// Token: 0x040010B3 RID: 4275
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/charset/Charset", typeof(Charset));
	}
}
