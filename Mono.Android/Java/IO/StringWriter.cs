using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.IO
{
	// Token: 0x02000425 RID: 1061
	[Register("java/io/StringWriter", DoNotGenerateAcw = true)]
	public class StringWriter : Writer
	{
		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06002E57 RID: 11863 RVA: 0x0007EB02 File Offset: 0x0007CD02
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StringWriter._members;
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06002E58 RID: 11864 RVA: 0x0007EB0C File Offset: 0x0007CD0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StringWriter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06002E59 RID: 11865 RVA: 0x0007EB30 File Offset: 0x0007CD30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StringWriter._members.ManagedPeerType;
			}
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x0007E814 File Offset: 0x0007CA14
		protected StringWriter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x0007EB3C File Offset: 0x0007CD3C
		public StringWriter() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(StringWriter._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			StringWriter._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x0007EBAA File Offset: 0x0007CDAA
		private static Delegate GetCloseHandler()
		{
			if (StringWriter.cb_close == null)
			{
				StringWriter.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(StringWriter.n_Close));
			}
			return StringWriter.cb_close;
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x0007EBCE File Offset: 0x0007CDCE
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<StringWriter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x0007EBDD File Offset: 0x0007CDDD
		public override void Close()
		{
			StringWriter._members.InstanceMethods.InvokeVirtualVoidMethod("close.()V", this, null);
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x0007EBF6 File Offset: 0x0007CDF6
		private static Delegate GetFlushHandler()
		{
			if (StringWriter.cb_flush == null)
			{
				StringWriter.cb_flush = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(StringWriter.n_Flush));
			}
			return StringWriter.cb_flush;
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x0007EC1A File Offset: 0x0007CE1A
		private static void n_Flush(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<StringWriter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Flush();
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x0007EC29 File Offset: 0x0007CE29
		public override void Flush()
		{
			StringWriter._members.InstanceMethods.InvokeVirtualVoidMethod("flush.()V", this, null);
		}

		// Token: 0x0400122D RID: 4653
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/StringWriter", typeof(StringWriter));

		// Token: 0x0400122E RID: 4654
		private static Delegate cb_close;

		// Token: 0x0400122F RID: 4655
		private static Delegate cb_flush;
	}
}
