using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Database;
using Android.Graphics;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Sdk
{
	// Token: 0x0200012F RID: 303
	[Register("com/applovin/impl/sdk/AppLovinContentProviderUtils", DoNotGenerateAcw = true)]
	public class AppLovinContentProviderUtils : Java.Lang.Object
	{
		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x000254D8 File Offset: 0x000236D8
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinContentProviderUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x000254FC File Offset: 0x000236FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinContentProviderUtils._members;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x00025504 File Offset: 0x00023704
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinContentProviderUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x00025528 File Offset: 0x00023728
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinContentProviderUtils._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AppLovinContentProviderUtils(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00025534 File Offset: 0x00023734
		[Register(".ctor", "()V", "")]
		public AppLovinContentProviderUtils() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AppLovinContentProviderUtils._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AppLovinContentProviderUtils._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x000255A4 File Offset: 0x000237A4
		[Register("cacheJPEGImageWithFileName", "(Landroid/graphics/Bitmap;Ljava/lang/String;)Landroid/net/Uri;", "")]
		public unsafe static Android.Net.Uri CacheJPEGImageWithFileName(Bitmap p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			Android.Net.Uri @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Android.Net.Uri>(AppLovinContentProviderUtils._members.StaticMethods.InvokeObjectMethod("cacheJPEGImageWithFileName.(Landroid/graphics/Bitmap;Ljava/lang/String;)Landroid/net/Uri;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00025638 File Offset: 0x00023838
		[Register("cacheTextWithFileName", "(Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri;", "")]
		public unsafe static Android.Net.Uri CacheTextWithFileName(string p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			Android.Net.Uri @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Android.Net.Uri>(AppLovinContentProviderUtils._members.StaticMethods.InvokeObjectMethod("cacheTextWithFileName.(Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x000256C4 File Offset: 0x000238C4
		[Register("getType", "(Landroid/net/Uri;)Ljava/lang/String;", "")]
		public unsafe static string GetType(Android.Net.Uri p0)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@string = JNIEnv.GetString(AppLovinContentProviderUtils._members.StaticMethods.InvokeObjectMethod("getType.(Landroid/net/Uri;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @string;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00025738 File Offset: 0x00023938
		[Register("openFile", "(Landroid/net/Uri;)Landroid/os/ParcelFileDescriptor;", "")]
		public unsafe static ParcelFileDescriptor OpenFile(Android.Net.Uri p0)
		{
			ParcelFileDescriptor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<ParcelFileDescriptor>(AppLovinContentProviderUtils._members.StaticMethods.InvokeObjectMethod("openFile.(Landroid/net/Uri;)Landroid/os/ParcelFileDescriptor;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x000257AC File Offset: 0x000239AC
		[Register("query", "(Landroid/net/Uri;)Landroid/database/Cursor;", "")]
		public unsafe static ICursor Query(Android.Net.Uri p0)
		{
			ICursor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<ICursor>(AppLovinContentProviderUtils._members.StaticMethods.InvokeObjectMethod("query.(Landroid/net/Uri;)Landroid/database/Cursor;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x040004C9 RID: 1225
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/AppLovinContentProviderUtils", typeof(AppLovinContentProviderUtils));
	}
}
