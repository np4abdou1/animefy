using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x0200006C RID: 108
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/Lazy", DoNotGenerateAcw = true)]
	internal class ILazyInvoker : Java.Lang.Object, ILazy, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00005874 File Offset: 0x00003A74
		private static IntPtr java_class_ref
		{
			get
			{
				return ILazyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00005898 File Offset: 0x00003A98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ILazyInvoker._members;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0000589F File Offset: 0x00003A9F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600025A RID: 602 RVA: 0x000058A7 File Offset: 0x00003AA7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ILazyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000058B3 File Offset: 0x00003AB3
		[NullableContext(2)]
		public static ILazy GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ILazy>(handle, transfer);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000058BC File Offset: 0x00003ABC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ILazyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.Lazy'.");
			}
			return handle;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000058E7 File Offset: 0x00003AE7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00005918 File Offset: 0x00003B18
		public ILazyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ILazyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00005950 File Offset: 0x00003B50
		private static Delegate GetIsInitializedHandler()
		{
			if (ILazyInvoker.cb_isInitialized == null)
			{
				ILazyInvoker.cb_isInitialized = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ILazyInvoker.n_IsInitialized));
			}
			return ILazyInvoker.cb_isInitialized;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00005974 File Offset: 0x00003B74
		private static bool n_IsInitialized(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ILazy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInitialized;
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00005983 File Offset: 0x00003B83
		public bool IsInitialized
		{
			get
			{
				if (this.id_isInitialized == IntPtr.Zero)
				{
					this.id_isInitialized = JNIEnv.GetMethodID(this.class_ref, "isInitialized", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isInitialized);
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000059C3 File Offset: 0x00003BC3
		private static Delegate GetGetValueHandler()
		{
			if (ILazyInvoker.cb_getValue == null)
			{
				ILazyInvoker.cb_getValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILazyInvoker.n_GetValue));
			}
			return ILazyInvoker.cb_getValue;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000059E7 File Offset: 0x00003BE7
		private static IntPtr n_GetValue(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ILazy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value);
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000264 RID: 612 RVA: 0x000059FC File Offset: 0x00003BFC
		[Nullable(2)]
		public Java.Lang.Object Value
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getValue == IntPtr.Zero)
				{
					this.id_getValue = JNIEnv.GetMethodID(this.class_ref, "getValue", "()Ljava/lang/Object;");
				}
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getValue), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000094 RID: 148
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/Lazy", typeof(ILazyInvoker));

		// Token: 0x04000095 RID: 149
		private IntPtr class_ref;

		// Token: 0x04000096 RID: 150
		[Nullable(2)]
		private static Delegate cb_isInitialized;

		// Token: 0x04000097 RID: 151
		private IntPtr id_isInitialized;

		// Token: 0x04000098 RID: 152
		[Nullable(2)]
		private static Delegate cb_getValue;

		// Token: 0x04000099 RID: 153
		private IntPtr id_getValue;
	}
}
