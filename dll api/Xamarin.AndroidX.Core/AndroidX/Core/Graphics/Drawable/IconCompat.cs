using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Net;
using Android.OS;
using Android.Runtime;
using AndroidX.VersionedParcelable;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.Graphics.Drawable
{
	// Token: 0x02000056 RID: 86
	[Register("androidx/core/graphics/drawable/IconCompat", DoNotGenerateAcw = true)]
	public class IconCompat : CustomVersionedParcelable
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00006ADC File Offset: 0x00004CDC
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00006B0C File Offset: 0x00004D0C
		[Register("mData")]
		public IList<byte> MData
		{
			get
			{
				return Android.Runtime.JavaArray<byte>.FromJniHandle(IconCompat._members.InstanceFields.GetObjectValue("mData.[B", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = Android.Runtime.JavaArray<byte>.ToLocalJniHandle(value);
				try
				{
					IconCompat._members.InstanceFields.SetValue("mData.[B", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00006B58 File Offset: 0x00004D58
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00006B6F File Offset: 0x00004D6F
		[Register("mInt1")]
		public int MInt1
		{
			get
			{
				return IconCompat._members.InstanceFields.GetInt32Value("mInt1.I", this);
			}
			set
			{
				IconCompat._members.InstanceFields.SetValue("mInt1.I", this, value);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00006B87 File Offset: 0x00004D87
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00006B9E File Offset: 0x00004D9E
		[Register("mInt2")]
		public int MInt2
		{
			get
			{
				return IconCompat._members.InstanceFields.GetInt32Value("mInt2.I", this);
			}
			set
			{
				IconCompat._members.InstanceFields.SetValue("mInt2.I", this, value);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00006BB8 File Offset: 0x00004DB8
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x00006BE8 File Offset: 0x00004DE8
		[Register("mParcelable")]
		public IParcelable MParcelable
		{
			get
			{
				return Java.Lang.Object.GetObject<IParcelable>(IconCompat._members.InstanceFields.GetObjectValue("mParcelable.Landroid/os/Parcelable;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					IconCompat._members.InstanceFields.SetValue("mParcelable.Landroid/os/Parcelable;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00006C34 File Offset: 0x00004E34
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00006C64 File Offset: 0x00004E64
		[Register("mString1")]
		public string MString1
		{
			get
			{
				return JNIEnv.GetString(IconCompat._members.InstanceFields.GetObjectValue("mString1.Ljava/lang/String;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					IconCompat._members.InstanceFields.SetValue("mString1.Ljava/lang/String;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00006CB0 File Offset: 0x00004EB0
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x00006CE0 File Offset: 0x00004EE0
		[Register("mTintList")]
		public ColorStateList MTintList
		{
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(IconCompat._members.InstanceFields.GetObjectValue("mTintList.Landroid/content/res/ColorStateList;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					IconCompat._members.InstanceFields.SetValue("mTintList.Landroid/content/res/ColorStateList;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x00006D2C File Offset: 0x00004F2C
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00006D5C File Offset: 0x00004F5C
		[Register("mTintModeStr")]
		public string MTintModeStr
		{
			get
			{
				return JNIEnv.GetString(IconCompat._members.InstanceFields.GetObjectValue("mTintModeStr.Ljava/lang/String;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					IconCompat._members.InstanceFields.SetValue("mTintModeStr.Ljava/lang/String;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00006DA8 File Offset: 0x00004FA8
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00006DBF File Offset: 0x00004FBF
		[Register("mType")]
		public int MType
		{
			get
			{
				return IconCompat._members.InstanceFields.GetInt32Value("mType.I", this);
			}
			set
			{
				IconCompat._members.InstanceFields.SetValue("mType.I", this, value);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00006DD8 File Offset: 0x00004FD8
		internal static IntPtr class_ref
		{
			get
			{
				return IconCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060002AB RID: 683 RVA: 0x00006DFC File Offset: 0x00004FFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IconCompat._members;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00006E04 File Offset: 0x00005004
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IconCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060002AD RID: 685 RVA: 0x00006E28 File Offset: 0x00005028
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IconCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00006E34 File Offset: 0x00005034
		protected IconCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00006E40 File Offset: 0x00005040
		[Register(".ctor", "()V", "")]
		public IconCompat() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(IconCompat._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			IconCompat._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00006EAE File Offset: 0x000050AE
		private static Delegate GetGetBitmapHandler()
		{
			if (IconCompat.cb_getBitmap == null)
			{
				IconCompat.cb_getBitmap = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IconCompat.n_GetBitmap));
			}
			return IconCompat.cb_getBitmap;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00006ED2 File Offset: 0x000050D2
		private static IntPtr n_GetBitmap(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IconCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Bitmap);
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x00006EE8 File Offset: 0x000050E8
		public virtual Bitmap Bitmap
		{
			[Register("getBitmap", "()Landroid/graphics/Bitmap;", "GetGetBitmapHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Bitmap>(IconCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getBitmap.()Landroid/graphics/Bitmap;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00006F1A File Offset: 0x0000511A
		private static Delegate GetGetResIdHandler()
		{
			if (IconCompat.cb_getResId == null)
			{
				IconCompat.cb_getResId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IconCompat.n_GetResId));
			}
			return IconCompat.cb_getResId;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00006F3E File Offset: 0x0000513E
		private static int n_GetResId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IconCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResId;
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00006F4D File Offset: 0x0000514D
		public virtual int ResId
		{
			[Register("getResId", "()I", "GetGetResIdHandler")]
			get
			{
				return IconCompat._members.InstanceMethods.InvokeVirtualInt32Method("getResId.()I", this, null);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00006F66 File Offset: 0x00005166
		private static Delegate GetGetResPackageHandler()
		{
			if (IconCompat.cb_getResPackage == null)
			{
				IconCompat.cb_getResPackage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IconCompat.n_GetResPackage));
			}
			return IconCompat.cb_getResPackage;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00006F8A File Offset: 0x0000518A
		private static IntPtr n_GetResPackage(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IconCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResPackage);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00006FA0 File Offset: 0x000051A0
		public virtual string ResPackage
		{
			[Register("getResPackage", "()Ljava/lang/String;", "GetGetResPackageHandler")]
			get
			{
				return JNIEnv.GetString(IconCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getResPackage.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00006FD2 File Offset: 0x000051D2
		private static Delegate GetGetTypeHandler()
		{
			if (IconCompat.cb_getType == null)
			{
				IconCompat.cb_getType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IconCompat.n_GetType));
			}
			return IconCompat.cb_getType;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00006FF6 File Offset: 0x000051F6
		private static int n_GetType(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IconCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Type;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00007005 File Offset: 0x00005205
		public virtual int Type
		{
			[Register("getType", "()I", "GetGetTypeHandler")]
			get
			{
				return IconCompat._members.InstanceMethods.InvokeVirtualInt32Method("getType.()I", this, null);
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000701E File Offset: 0x0000521E
		private static Delegate GetGetUriHandler()
		{
			if (IconCompat.cb_getUri == null)
			{
				IconCompat.cb_getUri = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IconCompat.n_GetUri));
			}
			return IconCompat.cb_getUri;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00007042 File Offset: 0x00005242
		private static IntPtr n_GetUri(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IconCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Uri);
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00007058 File Offset: 0x00005258
		public virtual Android.Net.Uri Uri
		{
			[Register("getUri", "()Landroid/net/Uri;", "GetGetUriHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Android.Net.Uri>(IconCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getUri.()Landroid/net/Uri;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000708A File Offset: 0x0000528A
		private static Delegate GetAddToShortcutIntent_Landroid_content_Intent_Landroid_graphics_drawable_Drawable_Landroid_content_Context_Handler()
		{
			if (IconCompat.cb_addToShortcutIntent_Landroid_content_Intent_Landroid_graphics_drawable_Drawable_Landroid_content_Context_ == null)
			{
				IconCompat.cb_addToShortcutIntent_Landroid_content_Intent_Landroid_graphics_drawable_Drawable_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IconCompat.n_AddToShortcutIntent_Landroid_content_Intent_Landroid_graphics_drawable_Drawable_Landroid_content_Context_));
			}
			return IconCompat.cb_addToShortcutIntent_Landroid_content_Intent_Landroid_graphics_drawable_Drawable_Landroid_content_Context_;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000070B0 File Offset: 0x000052B0
		private static void n_AddToShortcutIntent_Landroid_content_Intent_Landroid_graphics_drawable_Drawable_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_outIntent, IntPtr native_badge, IntPtr native_c)
		{
			IconCompat @object = Java.Lang.Object.GetObject<IconCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_outIntent, JniHandleOwnership.DoNotTransfer);
			Drawable object3 = Java.Lang.Object.GetObject<Drawable>(native_badge, JniHandleOwnership.DoNotTransfer);
			Context object4 = Java.Lang.Object.GetObject<Context>(native_c, JniHandleOwnership.DoNotTransfer);
			@object.AddToShortcutIntent(object2, object3, object4);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000070E8 File Offset: 0x000052E8
		[Register("addToShortcutIntent", "(Landroid/content/Intent;Landroid/graphics/drawable/Drawable;Landroid/content/Context;)V", "GetAddToShortcutIntent_Landroid_content_Intent_Landroid_graphics_drawable_Drawable_Landroid_content_Context_Handler")]
		public unsafe virtual void AddToShortcutIntent(Intent outIntent, Drawable badge, Context c)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((outIntent == null) ? IntPtr.Zero : outIntent.Handle);
				ptr[1] = new JniArgumentValue((badge == null) ? IntPtr.Zero : badge.Handle);
				ptr[2] = new JniArgumentValue((c == null) ? IntPtr.Zero : c.Handle);
				IconCompat._members.InstanceMethods.InvokeVirtualVoidMethod("addToShortcutIntent.(Landroid/content/Intent;Landroid/graphics/drawable/Drawable;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(outIntent);
				GC.KeepAlive(badge);
				GC.KeepAlive(c);
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x000071A0 File Offset: 0x000053A0
		private static Delegate GetCheckResource_Landroid_content_Context_Handler()
		{
			if (IconCompat.cb_checkResource_Landroid_content_Context_ == null)
			{
				IconCompat.cb_checkResource_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IconCompat.n_CheckResource_Landroid_content_Context_));
			}
			return IconCompat.cb_checkResource_Landroid_content_Context_;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000071C4 File Offset: 0x000053C4
		private static void n_CheckResource_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			IconCompat @object = Java.Lang.Object.GetObject<IconCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			@object.CheckResource(object2);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000071E8 File Offset: 0x000053E8
		[Register("checkResource", "(Landroid/content/Context;)V", "GetCheckResource_Landroid_content_Context_Handler")]
		public unsafe virtual void CheckResource(Context context)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				IconCompat._members.InstanceMethods.InvokeVirtualVoidMethod("checkResource.(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000724C File Offset: 0x0000544C
		[Register("createFromBundle", "(Landroid/os/Bundle;)Landroidx/core/graphics/drawable/IconCompat;", "")]
		public unsafe static IconCompat CreateFromBundle(Bundle bundle)
		{
			IconCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bundle == null) ? IntPtr.Zero : bundle.Handle);
				@object = Java.Lang.Object.GetObject<IconCompat>(IconCompat._members.StaticMethods.InvokeObjectMethod("createFromBundle.(Landroid/os/Bundle;)Landroidx/core/graphics/drawable/IconCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(bundle);
			}
			return @object;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000072C0 File Offset: 0x000054C0
		[Register("createFromIcon", "(Landroid/content/Context;Landroid/graphics/drawable/Icon;)Landroidx/core/graphics/drawable/IconCompat;", "")]
		public unsafe static IconCompat CreateFromIcon(Context context, Icon icon)
		{
			IconCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
				@object = Java.Lang.Object.GetObject<IconCompat>(IconCompat._members.StaticMethods.InvokeObjectMethod("createFromIcon.(Landroid/content/Context;Landroid/graphics/drawable/Icon;)Landroidx/core/graphics/drawable/IconCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(icon);
			}
			return @object;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000735C File Offset: 0x0000555C
		[Register("createFromIcon", "(Landroid/graphics/drawable/Icon;)Landroidx/core/graphics/drawable/IconCompat;", "")]
		public unsafe static IconCompat CreateFromIcon(Icon icon)
		{
			IconCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
				@object = Java.Lang.Object.GetObject<IconCompat>(IconCompat._members.StaticMethods.InvokeObjectMethod("createFromIcon.(Landroid/graphics/drawable/Icon;)Landroidx/core/graphics/drawable/IconCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(icon);
			}
			return @object;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000073D0 File Offset: 0x000055D0
		[Register("createFromIconOrNullIfZeroResId", "(Landroid/graphics/drawable/Icon;)Landroidx/core/graphics/drawable/IconCompat;", "")]
		public unsafe static IconCompat CreateFromIconOrNullIfZeroResId(Icon icon)
		{
			IconCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
				@object = Java.Lang.Object.GetObject<IconCompat>(IconCompat._members.StaticMethods.InvokeObjectMethod("createFromIconOrNullIfZeroResId.(Landroid/graphics/drawable/Icon;)Landroidx/core/graphics/drawable/IconCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(icon);
			}
			return @object;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00007444 File Offset: 0x00005644
		[Register("createWithAdaptiveBitmap", "(Landroid/graphics/Bitmap;)Landroidx/core/graphics/drawable/IconCompat;", "")]
		public unsafe static IconCompat CreateWithAdaptiveBitmap(Bitmap bits)
		{
			IconCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bits == null) ? IntPtr.Zero : bits.Handle);
				@object = Java.Lang.Object.GetObject<IconCompat>(IconCompat._members.StaticMethods.InvokeObjectMethod("createWithAdaptiveBitmap.(Landroid/graphics/Bitmap;)Landroidx/core/graphics/drawable/IconCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(bits);
			}
			return @object;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000074B8 File Offset: 0x000056B8
		[Register("createWithAdaptiveBitmapContentUri", "(Landroid/net/Uri;)Landroidx/core/graphics/drawable/IconCompat;", "")]
		public unsafe static IconCompat CreateWithAdaptiveBitmapContentUri(Android.Net.Uri uri)
		{
			IconCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				@object = Java.Lang.Object.GetObject<IconCompat>(IconCompat._members.StaticMethods.InvokeObjectMethod("createWithAdaptiveBitmapContentUri.(Landroid/net/Uri;)Landroidx/core/graphics/drawable/IconCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(uri);
			}
			return @object;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000752C File Offset: 0x0000572C
		[Register("createWithAdaptiveBitmapContentUri", "(Ljava/lang/String;)Landroidx/core/graphics/drawable/IconCompat;", "")]
		public unsafe static IconCompat CreateWithAdaptiveBitmapContentUri(string uri)
		{
			IntPtr intPtr = JNIEnv.NewString(uri);
			IconCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IconCompat>(IconCompat._members.StaticMethods.InvokeObjectMethod("createWithAdaptiveBitmapContentUri.(Ljava/lang/String;)Landroidx/core/graphics/drawable/IconCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00007598 File Offset: 0x00005798
		[Register("createWithBitmap", "(Landroid/graphics/Bitmap;)Landroidx/core/graphics/drawable/IconCompat;", "")]
		public unsafe static IconCompat CreateWithBitmap(Bitmap bits)
		{
			IconCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bits == null) ? IntPtr.Zero : bits.Handle);
				@object = Java.Lang.Object.GetObject<IconCompat>(IconCompat._members.StaticMethods.InvokeObjectMethod("createWithBitmap.(Landroid/graphics/Bitmap;)Landroidx/core/graphics/drawable/IconCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(bits);
			}
			return @object;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000760C File Offset: 0x0000580C
		[Register("createWithContentUri", "(Landroid/net/Uri;)Landroidx/core/graphics/drawable/IconCompat;", "")]
		public unsafe static IconCompat CreateWithContentUri(Android.Net.Uri uri)
		{
			IconCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				@object = Java.Lang.Object.GetObject<IconCompat>(IconCompat._members.StaticMethods.InvokeObjectMethod("createWithContentUri.(Landroid/net/Uri;)Landroidx/core/graphics/drawable/IconCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(uri);
			}
			return @object;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00007680 File Offset: 0x00005880
		[Register("createWithContentUri", "(Ljava/lang/String;)Landroidx/core/graphics/drawable/IconCompat;", "")]
		public unsafe static IconCompat CreateWithContentUri(string uri)
		{
			IntPtr intPtr = JNIEnv.NewString(uri);
			IconCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IconCompat>(IconCompat._members.StaticMethods.InvokeObjectMethod("createWithContentUri.(Ljava/lang/String;)Landroidx/core/graphics/drawable/IconCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000076EC File Offset: 0x000058EC
		[Register("createWithData", "([BII)Landroidx/core/graphics/drawable/IconCompat;", "")]
		public unsafe static IconCompat CreateWithData(byte[] data, int offset, int length)
		{
			IntPtr intPtr = JNIEnv.NewArray(data);
			IconCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(offset);
				ptr[2] = new JniArgumentValue(length);
				@object = Java.Lang.Object.GetObject<IconCompat>(IconCompat._members.StaticMethods.InvokeObjectMethod("createWithData.([BII)Landroidx/core/graphics/drawable/IconCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (data != null)
				{
					JNIEnv.CopyArray(intPtr, data);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(data);
			}
			return @object;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00007790 File Offset: 0x00005990
		[Register("createWithResource", "(Landroid/content/Context;I)Landroidx/core/graphics/drawable/IconCompat;", "")]
		public unsafe static IconCompat CreateWithResource(Context context, int resId)
		{
			IconCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(resId);
				@object = Java.Lang.Object.GetObject<IconCompat>(IconCompat._members.StaticMethods.InvokeObjectMethod("createWithResource.(Landroid/content/Context;I)Landroidx/core/graphics/drawable/IconCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00007818 File Offset: 0x00005A18
		[Register("createWithResource", "(Landroid/content/res/Resources;Ljava/lang/String;I)Landroidx/core/graphics/drawable/IconCompat;", "")]
		public unsafe static IconCompat CreateWithResource(Resources r, string pkg, int resId)
		{
			IntPtr intPtr = JNIEnv.NewString(pkg);
			IconCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((r == null) ? IntPtr.Zero : r.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(resId);
				@object = Java.Lang.Object.GetObject<IconCompat>(IconCompat._members.StaticMethods.InvokeObjectMethod("createWithResource.(Landroid/content/res/Resources;Ljava/lang/String;I)Landroidx/core/graphics/drawable/IconCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(r);
			}
			return @object;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x000078C0 File Offset: 0x00005AC0
		private static Delegate GetGetUriInputStream_Landroid_content_Context_Handler()
		{
			if (IconCompat.cb_getUriInputStream_Landroid_content_Context_ == null)
			{
				IconCompat.cb_getUriInputStream_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IconCompat.n_GetUriInputStream_Landroid_content_Context_));
			}
			return IconCompat.cb_getUriInputStream_Landroid_content_Context_;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000078E4 File Offset: 0x00005AE4
		private static IntPtr n_GetUriInputStream_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			IconCompat @object = Java.Lang.Object.GetObject<IconCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			return InputStreamAdapter.ToLocalJniHandle(@object.GetUriInputStream(object2));
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000790C File Offset: 0x00005B0C
		[Register("getUriInputStream", "(Landroid/content/Context;)Ljava/io/InputStream;", "GetGetUriInputStream_Landroid_content_Context_Handler")]
		public unsafe virtual Stream GetUriInputStream(Context context)
		{
			Stream result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				result = InputStreamInvoker.FromJniHandle(IconCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getUriInputStream.(Landroid/content/Context;)Ljava/io/InputStream;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return result;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00007980 File Offset: 0x00005B80
		private static Delegate GetLoadDrawable_Landroid_content_Context_Handler()
		{
			if (IconCompat.cb_loadDrawable_Landroid_content_Context_ == null)
			{
				IconCompat.cb_loadDrawable_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IconCompat.n_LoadDrawable_Landroid_content_Context_));
			}
			return IconCompat.cb_loadDrawable_Landroid_content_Context_;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x000079A4 File Offset: 0x00005BA4
		private static IntPtr n_LoadDrawable_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			IconCompat @object = Java.Lang.Object.GetObject<IconCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.LoadDrawable(object2));
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000079CC File Offset: 0x00005BCC
		[Register("loadDrawable", "(Landroid/content/Context;)Landroid/graphics/drawable/Drawable;", "GetLoadDrawable_Landroid_content_Context_Handler")]
		public unsafe virtual Drawable LoadDrawable(Context context)
		{
			Drawable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<Drawable>(IconCompat._members.InstanceMethods.InvokeVirtualObjectMethod("loadDrawable.(Landroid/content/Context;)Landroid/graphics/drawable/Drawable;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00007A40 File Offset: 0x00005C40
		private static Delegate GetSetTint_IHandler()
		{
			if (IconCompat.cb_setTint_I == null)
			{
				IconCompat.cb_setTint_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IconCompat.n_SetTint_I));
			}
			return IconCompat.cb_setTint_I;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00007A64 File Offset: 0x00005C64
		private static IntPtr n_SetTint_I(IntPtr jnienv, IntPtr native__this, int tint)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IconCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTint(tint));
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00007A7C File Offset: 0x00005C7C
		[Register("setTint", "(I)Landroidx/core/graphics/drawable/IconCompat;", "GetSetTint_IHandler")]
		public unsafe virtual IconCompat SetTint(int tint)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(tint);
			return Java.Lang.Object.GetObject<IconCompat>(IconCompat._members.InstanceMethods.InvokeVirtualObjectMethod("setTint.(I)Landroidx/core/graphics/drawable/IconCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00007AC5 File Offset: 0x00005CC5
		private static Delegate GetSetTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (IconCompat.cb_setTintList_Landroid_content_res_ColorStateList_ == null)
			{
				IconCompat.cb_setTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IconCompat.n_SetTintList_Landroid_content_res_ColorStateList_));
			}
			return IconCompat.cb_setTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00007AEC File Offset: 0x00005CEC
		private static IntPtr n_SetTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tintList)
		{
			IconCompat @object = Java.Lang.Object.GetObject<IconCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tintList, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetTintList(object2));
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00007B14 File Offset: 0x00005D14
		[Register("setTintList", "(Landroid/content/res/ColorStateList;)Landroidx/core/graphics/drawable/IconCompat;", "GetSetTintList_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual IconCompat SetTintList(ColorStateList tintList)
		{
			IconCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tintList == null) ? IntPtr.Zero : tintList.Handle);
				@object = Java.Lang.Object.GetObject<IconCompat>(IconCompat._members.InstanceMethods.InvokeVirtualObjectMethod("setTintList.(Landroid/content/res/ColorStateList;)Landroidx/core/graphics/drawable/IconCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(tintList);
			}
			return @object;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00007B88 File Offset: 0x00005D88
		private static Delegate GetSetTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (IconCompat.cb_setTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				IconCompat.cb_setTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IconCompat.n_SetTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return IconCompat.cb_setTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00007BAC File Offset: 0x00005DAC
		private static IntPtr n_SetTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			IconCompat @object = Java.Lang.Object.GetObject<IconCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_mode, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetTintMode(object2));
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00007BD4 File Offset: 0x00005DD4
		[Register("setTintMode", "(Landroid/graphics/PorterDuff$Mode;)Landroidx/core/graphics/drawable/IconCompat;", "GetSetTintMode_Landroid_graphics_PorterDuff_Mode_Handler")]
		public unsafe virtual IconCompat SetTintMode(PorterDuff.Mode mode)
		{
			IconCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((mode == null) ? IntPtr.Zero : mode.Handle);
				@object = Java.Lang.Object.GetObject<IconCompat>(IconCompat._members.InstanceMethods.InvokeVirtualObjectMethod("setTintMode.(Landroid/graphics/PorterDuff$Mode;)Landroidx/core/graphics/drawable/IconCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(mode);
			}
			return @object;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00007C48 File Offset: 0x00005E48
		private static Delegate GetToBundleHandler()
		{
			if (IconCompat.cb_toBundle == null)
			{
				IconCompat.cb_toBundle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IconCompat.n_ToBundle));
			}
			return IconCompat.cb_toBundle;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00007C6C File Offset: 0x00005E6C
		private static IntPtr n_ToBundle(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IconCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToBundle());
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00007C80 File Offset: 0x00005E80
		[Register("toBundle", "()Landroid/os/Bundle;", "GetToBundleHandler")]
		public virtual Bundle ToBundle()
		{
			return Java.Lang.Object.GetObject<Bundle>(IconCompat._members.InstanceMethods.InvokeVirtualObjectMethod("toBundle.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00007CB2 File Offset: 0x00005EB2
		private static Delegate GetToIconHandler()
		{
			if (IconCompat.cb_toIcon == null)
			{
				IconCompat.cb_toIcon = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IconCompat.n_ToIcon));
			}
			return IconCompat.cb_toIcon;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00007CD6 File Offset: 0x00005ED6
		private static IntPtr n_ToIcon(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IconCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToIcon());
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00007CEC File Offset: 0x00005EEC
		[Register("toIcon", "()Landroid/graphics/drawable/Icon;", "GetToIconHandler")]
		public virtual Icon ToIcon()
		{
			return Java.Lang.Object.GetObject<Icon>(IconCompat._members.InstanceMethods.InvokeVirtualObjectMethod("toIcon.()Landroid/graphics/drawable/Icon;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00007D1E File Offset: 0x00005F1E
		private static Delegate GetToIcon_Landroid_content_Context_Handler()
		{
			if (IconCompat.cb_toIcon_Landroid_content_Context_ == null)
			{
				IconCompat.cb_toIcon_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IconCompat.n_ToIcon_Landroid_content_Context_));
			}
			return IconCompat.cb_toIcon_Landroid_content_Context_;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00007D44 File Offset: 0x00005F44
		private static IntPtr n_ToIcon_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			IconCompat @object = Java.Lang.Object.GetObject<IconCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ToIcon(object2));
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00007D6C File Offset: 0x00005F6C
		[Register("toIcon", "(Landroid/content/Context;)Landroid/graphics/drawable/Icon;", "GetToIcon_Landroid_content_Context_Handler")]
		public unsafe virtual Icon ToIcon(Context context)
		{
			Icon @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<Icon>(IconCompat._members.InstanceMethods.InvokeVirtualObjectMethod("toIcon.(Landroid/content/Context;)Landroid/graphics/drawable/Icon;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x040000BB RID: 187
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/graphics/drawable/IconCompat", typeof(IconCompat));

		// Token: 0x040000BC RID: 188
		private static Delegate cb_getBitmap;

		// Token: 0x040000BD RID: 189
		private static Delegate cb_getResId;

		// Token: 0x040000BE RID: 190
		private static Delegate cb_getResPackage;

		// Token: 0x040000BF RID: 191
		private static Delegate cb_getType;

		// Token: 0x040000C0 RID: 192
		private static Delegate cb_getUri;

		// Token: 0x040000C1 RID: 193
		private static Delegate cb_addToShortcutIntent_Landroid_content_Intent_Landroid_graphics_drawable_Drawable_Landroid_content_Context_;

		// Token: 0x040000C2 RID: 194
		private static Delegate cb_checkResource_Landroid_content_Context_;

		// Token: 0x040000C3 RID: 195
		private static Delegate cb_getUriInputStream_Landroid_content_Context_;

		// Token: 0x040000C4 RID: 196
		private static Delegate cb_loadDrawable_Landroid_content_Context_;

		// Token: 0x040000C5 RID: 197
		private static Delegate cb_setTint_I;

		// Token: 0x040000C6 RID: 198
		private static Delegate cb_setTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x040000C7 RID: 199
		private static Delegate cb_setTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x040000C8 RID: 200
		private static Delegate cb_toBundle;

		// Token: 0x040000C9 RID: 201
		private static Delegate cb_toIcon;

		// Token: 0x040000CA RID: 202
		private static Delegate cb_toIcon_Landroid_content_Context_;
	}
}
