using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Nio;

namespace Java.IO
{
	// Token: 0x02000423 RID: 1059
	[Register("java/io/Reader", DoNotGenerateAcw = true)]
	public abstract class Reader : Java.Lang.Object, ICloseable, IJavaObject, IDisposable, IJavaPeerable, IReadable
	{
		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06002E47 RID: 11847 RVA: 0x0007E983 File Offset: 0x0007CB83
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Reader._members;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06002E48 RID: 11848 RVA: 0x0007E98C File Offset: 0x0007CB8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Reader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06002E49 RID: 11849 RVA: 0x0007E9B0 File Offset: 0x0007CBB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Reader._members.ManagedPeerType;
			}
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Reader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x0007E9BC File Offset: 0x0007CBBC
		private static Delegate GetCloseHandler()
		{
			if (Reader.cb_close == null)
			{
				Reader.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Reader.n_Close));
			}
			return Reader.cb_close;
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x0007E9E0 File Offset: 0x0007CBE0
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Reader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x06002E4D RID: 11853
		public abstract void Close();

		// Token: 0x06002E4E RID: 11854 RVA: 0x0007E9EF File Offset: 0x0007CBEF
		private static Delegate GetRead_Ljava_nio_CharBuffer_Handler()
		{
			if (Reader.cb_read_Ljava_nio_CharBuffer_ == null)
			{
				Reader.cb_read_Ljava_nio_CharBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(Reader.n_Read_Ljava_nio_CharBuffer_));
			}
			return Reader.cb_read_Ljava_nio_CharBuffer_;
		}

		// Token: 0x06002E4F RID: 11855 RVA: 0x0007EA14 File Offset: 0x0007CC14
		private static int n_Read_Ljava_nio_CharBuffer_(IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			Reader @object = Java.Lang.Object.GetObject<Reader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CharBuffer object2 = Java.Lang.Object.GetObject<CharBuffer>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.Read(object2);
		}

		// Token: 0x06002E50 RID: 11856 RVA: 0x0007EA38 File Offset: 0x0007CC38
		public unsafe virtual int Read(CharBuffer target)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				result = Reader._members.InstanceMethods.InvokeVirtualInt32Method("read.(Ljava/nio/CharBuffer;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(target);
			}
			return result;
		}

		// Token: 0x04001229 RID: 4649
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/Reader", typeof(Reader));

		// Token: 0x0400122A RID: 4650
		private static Delegate cb_close;

		// Token: 0x0400122B RID: 4651
		private static Delegate cb_read_Ljava_nio_CharBuffer_;
	}
}
