using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Database;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000057 RID: 87
	[Register("com/applovin/sdk/AppLovinInitProvider", DoNotGenerateAcw = true)]
	public class AppLovinInitProvider : ContentProvider
	{
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000708C File Offset: 0x0000528C
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinInitProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002AA RID: 682 RVA: 0x000070B0 File Offset: 0x000052B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinInitProvider._members;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002AB RID: 683 RVA: 0x000070B8 File Offset: 0x000052B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinInitProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002AC RID: 684 RVA: 0x000070DC File Offset: 0x000052DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinInitProvider._members.ManagedPeerType;
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000070E8 File Offset: 0x000052E8
		protected AppLovinInitProvider(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000070F4 File Offset: 0x000052F4
		[Register(".ctor", "()V", "")]
		public AppLovinInitProvider() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AppLovinInitProvider._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AppLovinInitProvider._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00007162 File Offset: 0x00005362
		private static Delegate GetDelete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_Handler()
		{
			if (AppLovinInitProvider.cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ == null)
			{
				AppLovinInitProvider.cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_I(AppLovinInitProvider.n_Delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_));
			}
			return AppLovinInitProvider.cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00007188 File Offset: 0x00005388
		private static int n_Delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			ContentProvider @object = Java.Lang.Object.GetObject<AppLovinInitProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_p2, JniHandleOwnership.DoNotTransfer, typeof(string));
			int result = @object.Delete(object2, @string, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_p2);
			}
			return result;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000071D8 File Offset: 0x000053D8
		[Register("delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", "GetDelete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public unsafe override int Delete(Android.Net.Uri p0, string p1, string[] p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			IntPtr intPtr2 = JNIEnv.NewArray(p2);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				result = AppLovinInitProvider._members.InstanceMethods.InvokeVirtualInt32Method("delete.(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (p2 != null)
				{
					JNIEnv.CopyArray(intPtr2, p2);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
			return result;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00007290 File Offset: 0x00005490
		private static Delegate GetGetType_Landroid_net_Uri_Handler()
		{
			if (AppLovinInitProvider.cb_getType_Landroid_net_Uri_ == null)
			{
				AppLovinInitProvider.cb_getType_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppLovinInitProvider.n_GetType_Landroid_net_Uri_));
			}
			return AppLovinInitProvider.cb_getType_Landroid_net_Uri_;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000072B4 File Offset: 0x000054B4
		private static IntPtr n_GetType_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ContentProvider @object = Java.Lang.Object.GetObject<AppLovinInitProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetType(object2));
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000072DC File Offset: 0x000054DC
		[Register("getType", "(Landroid/net/Uri;)Ljava/lang/String;", "GetGetType_Landroid_net_Uri_Handler")]
		public unsafe override string GetType(Android.Net.Uri p0)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@string = JNIEnv.GetString(AppLovinInitProvider._members.InstanceMethods.InvokeVirtualObjectMethod("getType.(Landroid/net/Uri;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @string;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00007350 File Offset: 0x00005550
		private static Delegate GetInsert_Landroid_net_Uri_Landroid_content_ContentValues_Handler()
		{
			if (AppLovinInitProvider.cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_ == null)
			{
				AppLovinInitProvider.cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AppLovinInitProvider.n_Insert_Landroid_net_Uri_Landroid_content_ContentValues_));
			}
			return AppLovinInitProvider.cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00007374 File Offset: 0x00005574
		private static IntPtr n_Insert_Landroid_net_Uri_Landroid_content_ContentValues_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			ContentProvider @object = Java.Lang.Object.GetObject<AppLovinInitProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
			ContentValues object3 = Java.Lang.Object.GetObject<ContentValues>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Insert(object2, object3));
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000073A8 File Offset: 0x000055A8
		[Register("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", "GetInsert_Landroid_net_Uri_Landroid_content_ContentValues_Handler")]
		public unsafe override Android.Net.Uri Insert(Android.Net.Uri p0, ContentValues p1)
		{
			Android.Net.Uri @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<Android.Net.Uri>(AppLovinInitProvider._members.InstanceMethods.InvokeVirtualObjectMethod("insert.(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00007444 File Offset: 0x00005644
		private static Delegate GetOnCreateHandler()
		{
			if (AppLovinInitProvider.cb_onCreate == null)
			{
				AppLovinInitProvider.cb_onCreate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AppLovinInitProvider.n_OnCreate));
			}
			return AppLovinInitProvider.cb_onCreate;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00007468 File Offset: 0x00005668
		private static bool n_OnCreate(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinInitProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnCreate();
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00007477 File Offset: 0x00005677
		[Register("onCreate", "()Z", "GetOnCreateHandler")]
		public override bool OnCreate()
		{
			return AppLovinInitProvider._members.InstanceMethods.InvokeVirtualBooleanMethod("onCreate.()Z", this, null);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00007490 File Offset: 0x00005690
		private static Delegate GetQuery_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler()
		{
			if (AppLovinInitProvider.cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ == null)
			{
				AppLovinInitProvider.cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLLL_L(AppLovinInitProvider.n_Query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_));
			}
			return AppLovinInitProvider.cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000074B4 File Offset: 0x000056B4
		private static IntPtr n_Query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			ContentProvider @object = Java.Lang.Object.GetObject<AppLovinInitProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_p1, JniHandleOwnership.DoNotTransfer, typeof(string));
			string @string = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
			string[] array2 = (string[])JNIEnv.GetArray(native_p3, JniHandleOwnership.DoNotTransfer, typeof(string));
			string string2 = JNIEnv.GetString(native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Query(object2, array, @string, array2, string2));
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_p1);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray(array2, native_p3);
			}
			return result;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00007538 File Offset: 0x00005738
		[Register("query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", "GetQuery_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler")]
		public unsafe override ICursor Query(Android.Net.Uri p0, string[] p1, string p2, string[] p3, string p4)
		{
			IntPtr intPtr = JNIEnv.NewArray(p1);
			IntPtr intPtr2 = JNIEnv.NewString(p2);
			IntPtr intPtr3 = JNIEnv.NewArray(p3);
			IntPtr intPtr4 = JNIEnv.NewString(p4);
			ICursor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue(intPtr3);
				ptr[4] = new JniArgumentValue(intPtr4);
				@object = Java.Lang.Object.GetObject<ICursor>(AppLovinInitProvider._members.InstanceMethods.InvokeVirtualObjectMethod("query.(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (p1 != null)
				{
					JNIEnv.CopyArray(intPtr, p1);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				JNIEnv.DeleteLocalRef(intPtr2);
				if (p3 != null)
				{
					JNIEnv.CopyArray(intPtr3, p3);
					JNIEnv.DeleteLocalRef(intPtr3);
				}
				JNIEnv.DeleteLocalRef(intPtr4);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p3);
			}
			return @object;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00007664 File Offset: 0x00005864
		private static Delegate GetUpdate_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler()
		{
			if (AppLovinInitProvider.cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == null)
			{
				AppLovinInitProvider.cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_I(AppLovinInitProvider.n_Update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_));
			}
			return AppLovinInitProvider.cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00007688 File Offset: 0x00005888
		private static int n_Update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			ContentProvider @object = Java.Lang.Object.GetObject<AppLovinInitProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
			ContentValues object3 = Java.Lang.Object.GetObject<ContentValues>(native_p1, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_p3, JniHandleOwnership.DoNotTransfer, typeof(string));
			int result = @object.Update(object2, object3, @string, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_p3);
			}
			return result;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000076E4 File Offset: 0x000058E4
		[Register("update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I", "GetUpdate_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public unsafe override int Update(Android.Net.Uri p0, ContentValues p1, string p2, string[] p3)
		{
			IntPtr intPtr = JNIEnv.NewString(p2);
			IntPtr intPtr2 = JNIEnv.NewArray(p3);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue(intPtr2);
				result = AppLovinInitProvider._members.InstanceMethods.InvokeVirtualInt32Method("update.(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (p3 != null)
				{
					JNIEnv.CopyArray(intPtr2, p3);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p3);
			}
			return result;
		}

		// Token: 0x0400009B RID: 155
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinInitProvider", typeof(AppLovinInitProvider));

		// Token: 0x0400009C RID: 156
		private static Delegate cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_;

		// Token: 0x0400009D RID: 157
		private static Delegate cb_getType_Landroid_net_Uri_;

		// Token: 0x0400009E RID: 158
		private static Delegate cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_;

		// Token: 0x0400009F RID: 159
		private static Delegate cb_onCreate;

		// Token: 0x040000A0 RID: 160
		private static Delegate cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;

		// Token: 0x040000A1 RID: 161
		private static Delegate cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
	}
}
