using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Shape
{
	// Token: 0x02000039 RID: 57
	[Register("com/google/android/material/shape/CornerSize", DoNotGenerateAcw = true)]
	internal class ICornerSizeInvoker : Java.Lang.Object, ICornerSize, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002740 File Offset: 0x00000940
		private static IntPtr java_class_ref
		{
			get
			{
				return ICornerSizeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00002764 File Offset: 0x00000964
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICornerSizeInvoker._members;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000276B File Offset: 0x0000096B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00002773 File Offset: 0x00000973
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICornerSizeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000277F File Offset: 0x0000097F
		public static ICornerSize GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICornerSize>(handle, transfer);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002788 File Offset: 0x00000988
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICornerSizeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.material.shape.CornerSize'.");
			}
			return handle;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000027B3 File Offset: 0x000009B3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000027E4 File Offset: 0x000009E4
		public ICornerSizeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICornerSizeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000281C File Offset: 0x00000A1C
		private static Delegate GetGetCornerSize_Landroid_graphics_RectF_Handler()
		{
			if (ICornerSizeInvoker.cb_getCornerSize_Landroid_graphics_RectF_ == null)
			{
				ICornerSizeInvoker.cb_getCornerSize_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_F(ICornerSizeInvoker.n_GetCornerSize_Landroid_graphics_RectF_));
			}
			return ICornerSizeInvoker.cb_getCornerSize_Landroid_graphics_RectF_;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002840 File Offset: 0x00000A40
		private static float n_GetCornerSize_Landroid_graphics_RectF_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ICornerSize @object = Java.Lang.Object.GetObject<ICornerSize>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RectF object2 = Java.Lang.Object.GetObject<RectF>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.GetCornerSize(object2);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002864 File Offset: 0x00000A64
		public unsafe float GetCornerSize(RectF p0)
		{
			if (this.id_getCornerSize_Landroid_graphics_RectF_ == IntPtr.Zero)
			{
				this.id_getCornerSize_Landroid_graphics_RectF_ = JNIEnv.GetMethodID(this.class_ref, "getCornerSize", "(Landroid/graphics/RectF;)F");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return JNIEnv.CallFloatMethod(base.Handle, this.id_getCornerSize_Landroid_graphics_RectF_, ptr);
		}

		// Token: 0x0400000A RID: 10
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/shape/CornerSize", typeof(ICornerSizeInvoker));

		// Token: 0x0400000B RID: 11
		private IntPtr class_ref;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_getCornerSize_Landroid_graphics_RectF_;

		// Token: 0x0400000D RID: 13
		private IntPtr id_getCornerSize_Landroid_graphics_RectF_;
	}
}
