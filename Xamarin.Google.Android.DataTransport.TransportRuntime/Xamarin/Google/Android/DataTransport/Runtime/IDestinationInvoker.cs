using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime
{
	// Token: 0x02000023 RID: 35
	[Register("com/google/android/datatransport/runtime/Destination", DoNotGenerateAcw = true)]
	internal class IDestinationInvoker : Java.Lang.Object, IDestination, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000039B4 File Offset: 0x00001BB4
		private static IntPtr java_class_ref
		{
			get
			{
				return IDestinationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000EA RID: 234 RVA: 0x000039D8 File Offset: 0x00001BD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDestinationInvoker._members;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000039DF File Offset: 0x00001BDF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000039E7 File Offset: 0x00001BE7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDestinationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000039F3 File Offset: 0x00001BF3
		public static IDestination GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDestination>(handle, transfer);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000039FC File Offset: 0x00001BFC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDestinationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.Destination'.");
			}
			return handle;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00003A27 File Offset: 0x00001C27
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003A58 File Offset: 0x00001C58
		public IDestinationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDestinationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00003A90 File Offset: 0x00001C90
		private static Delegate GetGetNameHandler()
		{
			if (IDestinationInvoker.cb_getName == null)
			{
				IDestinationInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDestinationInvoker.n_GetName));
			}
			return IDestinationInvoker.cb_getName;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00003AB4 File Offset: 0x00001CB4
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IDestination>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00003AC8 File Offset: 0x00001CC8
		public string Name
		{
			get
			{
				if (this.id_getName == IntPtr.Zero)
				{
					this.id_getName = JNIEnv.GetMethodID(this.class_ref, "getName", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00003B19 File Offset: 0x00001D19
		private static Delegate GetGetExtrasHandler()
		{
			if (IDestinationInvoker.cb_getExtras == null)
			{
				IDestinationInvoker.cb_getExtras = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDestinationInvoker.n_GetExtras));
			}
			return IDestinationInvoker.cb_getExtras;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00003B3D File Offset: 0x00001D3D
		private static IntPtr n_GetExtras(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<IDestination>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetExtras());
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003B54 File Offset: 0x00001D54
		public byte[] GetExtras()
		{
			if (this.id_getExtras == IntPtr.Zero)
			{
				this.id_getExtras = JNIEnv.GetMethodID(this.class_ref, "getExtras", "()[B");
			}
			return (byte[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getExtras), JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x04000029 RID: 41
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/Destination", typeof(IDestinationInvoker));

		// Token: 0x0400002A RID: 42
		private IntPtr class_ref;

		// Token: 0x0400002B RID: 43
		private static Delegate cb_getName;

		// Token: 0x0400002C RID: 44
		private IntPtr id_getName;

		// Token: 0x0400002D RID: 45
		private static Delegate cb_getExtras;

		// Token: 0x0400002E RID: 46
		private IntPtr id_getExtras;
	}
}
