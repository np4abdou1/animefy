using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000139 RID: 313
	[Register("com/bumptech/glide/load/model/Model", DoNotGenerateAcw = true)]
	internal class IModelInvoker : Java.Lang.Object, IModel, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00032EBC File Offset: 0x000310BC
		private static IntPtr java_class_ref
		{
			get
			{
				return IModelInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x00032EE0 File Offset: 0x000310E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IModelInvoker._members;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x00032EE7 File Offset: 0x000310E7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x00032EEF File Offset: 0x000310EF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IModelInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00032EFB File Offset: 0x000310FB
		public static IModel GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IModel>(handle, transfer);
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00032F04 File Offset: 0x00031104
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IModelInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.model.Model'.");
			}
			return handle;
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00032F2F File Offset: 0x0003112F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00032F60 File Offset: 0x00031160
		public IModelInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IModelInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00032F98 File Offset: 0x00031198
		private static Delegate GetIsEquivalentTo_Ljava_lang_Object_Handler()
		{
			if (IModelInvoker.cb_isEquivalentTo_Ljava_lang_Object_ == null)
			{
				IModelInvoker.cb_isEquivalentTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IModelInvoker.n_IsEquivalentTo_Ljava_lang_Object_));
			}
			return IModelInvoker.cb_isEquivalentTo_Ljava_lang_Object_;
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00032FBC File Offset: 0x000311BC
		private static bool n_IsEquivalentTo_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IModel @object = Java.Lang.Object.GetObject<IModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.IsEquivalentTo(object2);
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00032FE0 File Offset: 0x000311E0
		public unsafe bool IsEquivalentTo(Java.Lang.Object p0)
		{
			if (this.id_isEquivalentTo_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_isEquivalentTo_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "isEquivalentTo", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_isEquivalentTo_Ljava_lang_Object_, ptr);
		}

		// Token: 0x040003A6 RID: 934
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/Model", typeof(IModelInvoker));

		// Token: 0x040003A7 RID: 935
		private IntPtr class_ref;

		// Token: 0x040003A8 RID: 936
		private static Delegate cb_isEquivalentTo_Ljava_lang_Object_;

		// Token: 0x040003A9 RID: 937
		private IntPtr id_isEquivalentTo_Ljava_lang_Object_;
	}
}
