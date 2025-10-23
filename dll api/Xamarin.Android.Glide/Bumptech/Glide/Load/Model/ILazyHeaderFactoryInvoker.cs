using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000137 RID: 311
	[Register("com/bumptech/glide/load/model/LazyHeaderFactory", DoNotGenerateAcw = true)]
	internal class ILazyHeaderFactoryInvoker : Java.Lang.Object, ILazyHeaderFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x00032D3C File Offset: 0x00030F3C
		private static IntPtr java_class_ref
		{
			get
			{
				return ILazyHeaderFactoryInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x00032D60 File Offset: 0x00030F60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ILazyHeaderFactoryInvoker._members;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x00032D67 File Offset: 0x00030F67
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x00032D6F File Offset: 0x00030F6F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ILazyHeaderFactoryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00032D7B File Offset: 0x00030F7B
		public static ILazyHeaderFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ILazyHeaderFactory>(handle, transfer);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00032D84 File Offset: 0x00030F84
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ILazyHeaderFactoryInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.model.LazyHeaderFactory'.");
			}
			return handle;
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00032DAF File Offset: 0x00030FAF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00032DE0 File Offset: 0x00030FE0
		public ILazyHeaderFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ILazyHeaderFactoryInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00032E18 File Offset: 0x00031018
		private static Delegate GetBuildHeaderHandler()
		{
			if (ILazyHeaderFactoryInvoker.cb_buildHeader == null)
			{
				ILazyHeaderFactoryInvoker.cb_buildHeader = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILazyHeaderFactoryInvoker.n_BuildHeader));
			}
			return ILazyHeaderFactoryInvoker.cb_buildHeader;
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00032E3C File Offset: 0x0003103C
		private static IntPtr n_BuildHeader(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ILazyHeaderFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BuildHeader());
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00032E50 File Offset: 0x00031050
		public string BuildHeader()
		{
			if (this.id_buildHeader == IntPtr.Zero)
			{
				this.id_buildHeader = JNIEnv.GetMethodID(this.class_ref, "buildHeader", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_buildHeader), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040003A2 RID: 930
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/LazyHeaderFactory", typeof(ILazyHeaderFactoryInvoker));

		// Token: 0x040003A3 RID: 931
		private IntPtr class_ref;

		// Token: 0x040003A4 RID: 932
		private static Delegate cb_buildHeader;

		// Token: 0x040003A5 RID: 933
		private IntPtr id_buildHeader;
	}
}
