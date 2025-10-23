using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x0200030B RID: 779
	[Register("java/util/Enumeration", DoNotGenerateAcw = true)]
	internal class IEnumerationInvoker : Java.Lang.Object, IEnumeration, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x00056200 File Offset: 0x00054400
		private static IntPtr java_class_ref
		{
			get
			{
				return IEnumerationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x00056224 File Offset: 0x00054424
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IEnumerationInvoker._members;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001F88 RID: 8072 RVA: 0x0005622B File Offset: 0x0005442B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x00056233 File Offset: 0x00054433
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IEnumerationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x0005623F File Offset: 0x0005443F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IEnumerationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.Enumeration'.");
			}
			return handle;
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x0005626A File Offset: 0x0005446A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x0005629C File Offset: 0x0005449C
		public IEnumerationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IEnumerationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x000562D4 File Offset: 0x000544D4
		private static Delegate GetHasMoreElementsHandler()
		{
			if (IEnumerationInvoker.cb_hasMoreElements == null)
			{
				IEnumerationInvoker.cb_hasMoreElements = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IEnumerationInvoker.n_HasMoreElements));
			}
			return IEnumerationInvoker.cb_hasMoreElements;
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x000562F8 File Offset: 0x000544F8
		private static bool n_HasMoreElements(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IEnumeration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasMoreElements;
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x00056307 File Offset: 0x00054507
		public bool HasMoreElements
		{
			get
			{
				if (this.id_hasMoreElements == IntPtr.Zero)
				{
					this.id_hasMoreElements = JNIEnv.GetMethodID(this.class_ref, "hasMoreElements", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasMoreElements);
			}
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x00056347 File Offset: 0x00054547
		private static Delegate GetNextElementHandler()
		{
			if (IEnumerationInvoker.cb_nextElement == null)
			{
				IEnumerationInvoker.cb_nextElement = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IEnumerationInvoker.n_NextElement));
			}
			return IEnumerationInvoker.cb_nextElement;
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x0005636B File Offset: 0x0005456B
		private static IntPtr n_NextElement(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IEnumeration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextElement());
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x00056380 File Offset: 0x00054580
		public Java.Lang.Object NextElement()
		{
			if (this.id_nextElement == IntPtr.Zero)
			{
				this.id_nextElement = JNIEnv.GetMethodID(this.class_ref, "nextElement", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_nextElement), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000CE7 RID: 3303
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Enumeration", typeof(IEnumerationInvoker));

		// Token: 0x04000CE8 RID: 3304
		private IntPtr class_ref;

		// Token: 0x04000CE9 RID: 3305
		private static Delegate cb_hasMoreElements;

		// Token: 0x04000CEA RID: 3306
		private IntPtr id_hasMoreElements;

		// Token: 0x04000CEB RID: 3307
		private static Delegate cb_nextElement;

		// Token: 0x04000CEC RID: 3308
		private IntPtr id_nextElement;
	}
}
