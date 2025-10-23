using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content.Res;
using Android.Database;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x0200027F RID: 639
	[Register("android/content/ContentProvider", DoNotGenerateAcw = true)]
	public abstract class ContentProvider : Java.Lang.Object, IComponentCallbacks, IJavaObject, IDisposable, IJavaPeerable, IComponentCallbacks2
	{
		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x0003E9DD File Offset: 0x0003CBDD
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ContentProvider._members;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x0003E9E4 File Offset: 0x0003CBE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ContentProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001836 RID: 6198 RVA: 0x0003EA08 File Offset: 0x0003CC08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ContentProvider._members.ManagedPeerType;
			}
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x000021E0 File Offset: 0x000003E0
		protected ContentProvider(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x0003EA14 File Offset: 0x0003CC14
		private static Delegate GetDelete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_Handler()
		{
			if (ContentProvider.cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ == null)
			{
				ContentProvider.cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_I(ContentProvider.n_Delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_));
			}
			return ContentProvider.cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_;
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x0003EA38 File Offset: 0x0003CC38
		private static int n_Delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_selection, IntPtr native_selectionArgs)
		{
			ContentProvider @object = Java.Lang.Object.GetObject<ContentProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_uri, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_selection, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_selectionArgs, JniHandleOwnership.DoNotTransfer, typeof(string));
			int result = @object.Delete(object2, @string, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_selectionArgs);
			}
			return result;
		}

		// Token: 0x0600183A RID: 6202
		public abstract int Delete(Android.Net.Uri uri, string selection, string[] selectionArgs);

		// Token: 0x0600183B RID: 6203 RVA: 0x0003EA88 File Offset: 0x0003CC88
		private static Delegate GetGetType_Landroid_net_Uri_Handler()
		{
			if (ContentProvider.cb_getType_Landroid_net_Uri_ == null)
			{
				ContentProvider.cb_getType_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ContentProvider.n_GetType_Landroid_net_Uri_));
			}
			return ContentProvider.cb_getType_Landroid_net_Uri_;
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x0003EAAC File Offset: 0x0003CCAC
		private static IntPtr n_GetType_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			ContentProvider @object = Java.Lang.Object.GetObject<ContentProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_uri, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetType(object2));
		}

		// Token: 0x0600183D RID: 6205
		public abstract string GetType(Android.Net.Uri uri);

		// Token: 0x0600183E RID: 6206 RVA: 0x0003EAD4 File Offset: 0x0003CCD4
		private static Delegate GetInsert_Landroid_net_Uri_Landroid_content_ContentValues_Handler()
		{
			if (ContentProvider.cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_ == null)
			{
				ContentProvider.cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ContentProvider.n_Insert_Landroid_net_Uri_Landroid_content_ContentValues_));
			}
			return ContentProvider.cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_;
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x0003EAF8 File Offset: 0x0003CCF8
		private static IntPtr n_Insert_Landroid_net_Uri_Landroid_content_ContentValues_(IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_values)
		{
			ContentProvider @object = Java.Lang.Object.GetObject<ContentProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_uri, JniHandleOwnership.DoNotTransfer);
			ContentValues object3 = Java.Lang.Object.GetObject<ContentValues>(native_values, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Insert(object2, object3));
		}

		// Token: 0x06001840 RID: 6208
		public abstract Android.Net.Uri Insert(Android.Net.Uri uri, ContentValues values);

		// Token: 0x06001841 RID: 6209 RVA: 0x0003EB29 File Offset: 0x0003CD29
		private static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler()
		{
			if (ContentProvider.cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
			{
				ContentProvider.cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ContentProvider.n_OnConfigurationChanged_Landroid_content_res_Configuration_));
			}
			return ContentProvider.cb_onConfigurationChanged_Landroid_content_res_Configuration_;
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0003EB50 File Offset: 0x0003CD50
		private static void n_OnConfigurationChanged_Landroid_content_res_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_newConfig)
		{
			ContentProvider @object = Java.Lang.Object.GetObject<ContentProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_newConfig, JniHandleOwnership.DoNotTransfer);
			@object.OnConfigurationChanged(object2);
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0003EB74 File Offset: 0x0003CD74
		public unsafe virtual void OnConfigurationChanged(Configuration newConfig)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((newConfig == null) ? IntPtr.Zero : newConfig.Handle);
				ContentProvider._members.InstanceMethods.InvokeVirtualVoidMethod("onConfigurationChanged.(Landroid/content/res/Configuration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(newConfig);
			}
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x0003EBD8 File Offset: 0x0003CDD8
		private static Delegate GetOnCreateHandler()
		{
			if (ContentProvider.cb_onCreate == null)
			{
				ContentProvider.cb_onCreate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ContentProvider.n_OnCreate));
			}
			return ContentProvider.cb_onCreate;
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x0003EBFC File Offset: 0x0003CDFC
		private static bool n_OnCreate(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ContentProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnCreate();
		}

		// Token: 0x06001846 RID: 6214
		public abstract bool OnCreate();

		// Token: 0x06001847 RID: 6215 RVA: 0x0003EC0B File Offset: 0x0003CE0B
		private static Delegate GetOnLowMemoryHandler()
		{
			if (ContentProvider.cb_onLowMemory == null)
			{
				ContentProvider.cb_onLowMemory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ContentProvider.n_OnLowMemory));
			}
			return ContentProvider.cb_onLowMemory;
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x0003EC2F File Offset: 0x0003CE2F
		private static void n_OnLowMemory(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ContentProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLowMemory();
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x0003EC3E File Offset: 0x0003CE3E
		public virtual void OnLowMemory()
		{
			ContentProvider._members.InstanceMethods.InvokeVirtualVoidMethod("onLowMemory.()V", this, null);
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x0003EC57 File Offset: 0x0003CE57
		private static Delegate GetOnTrimMemory_IHandler()
		{
			if (ContentProvider.cb_onTrimMemory_I == null)
			{
				ContentProvider.cb_onTrimMemory_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ContentProvider.n_OnTrimMemory_I));
			}
			return ContentProvider.cb_onTrimMemory_I;
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x0003EC7C File Offset: 0x0003CE7C
		private static void n_OnTrimMemory_I(IntPtr jnienv, IntPtr native__this, int native_level)
		{
			Java.Lang.Object.GetObject<ContentProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTrimMemory((TrimMemory)native_level);
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x0003EC9C File Offset: 0x0003CE9C
		public unsafe virtual void OnTrimMemory([GeneratedEnum] TrimMemory level)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((int)level);
			ContentProvider._members.InstanceMethods.InvokeVirtualVoidMethod("onTrimMemory.(I)V", this, ptr);
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x0003ECD7 File Offset: 0x0003CED7
		private static Delegate GetQuery_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler()
		{
			if (ContentProvider.cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ == null)
			{
				ContentProvider.cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLLL_L(ContentProvider.n_Query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_));
			}
			return ContentProvider.cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x0003ECFC File Offset: 0x0003CEFC
		private static IntPtr n_Query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_projection, IntPtr native_selection, IntPtr native_selectionArgs, IntPtr native_sortOrder)
		{
			ContentProvider @object = Java.Lang.Object.GetObject<ContentProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_uri, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_projection, JniHandleOwnership.DoNotTransfer, typeof(string));
			string @string = JNIEnv.GetString(native_selection, JniHandleOwnership.DoNotTransfer);
			string[] array2 = (string[])JNIEnv.GetArray(native_selectionArgs, JniHandleOwnership.DoNotTransfer, typeof(string));
			string string2 = JNIEnv.GetString(native_sortOrder, JniHandleOwnership.DoNotTransfer);
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Query(object2, array, @string, array2, string2));
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_projection);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray(array2, native_selectionArgs);
			}
			return result;
		}

		// Token: 0x0600184F RID: 6223
		public abstract ICursor Query(Android.Net.Uri uri, string[] projection, string selection, string[] selectionArgs, string sortOrder);

		// Token: 0x06001850 RID: 6224 RVA: 0x0003ED80 File Offset: 0x0003CF80
		private static Delegate GetUpdate_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler()
		{
			if (ContentProvider.cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == null)
			{
				ContentProvider.cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_I(ContentProvider.n_Update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_));
			}
			return ContentProvider.cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x0003EDA4 File Offset: 0x0003CFA4
		private static int n_Update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_values, IntPtr native_selection, IntPtr native_selectionArgs)
		{
			ContentProvider @object = Java.Lang.Object.GetObject<ContentProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_uri, JniHandleOwnership.DoNotTransfer);
			ContentValues object3 = Java.Lang.Object.GetObject<ContentValues>(native_values, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_selection, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_selectionArgs, JniHandleOwnership.DoNotTransfer, typeof(string));
			int result = @object.Update(object2, object3, @string, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_selectionArgs);
			}
			return result;
		}

		// Token: 0x06001852 RID: 6226
		public abstract int Update(Android.Net.Uri uri, ContentValues values, string selection, string[] selectionArgs);

		// Token: 0x04000A49 RID: 2633
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/ContentProvider", typeof(ContentProvider));

		// Token: 0x04000A4A RID: 2634
		private static Delegate cb_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_;

		// Token: 0x04000A4B RID: 2635
		private static Delegate cb_getType_Landroid_net_Uri_;

		// Token: 0x04000A4C RID: 2636
		private static Delegate cb_insert_Landroid_net_Uri_Landroid_content_ContentValues_;

		// Token: 0x04000A4D RID: 2637
		private static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;

		// Token: 0x04000A4E RID: 2638
		private static Delegate cb_onCreate;

		// Token: 0x04000A4F RID: 2639
		private static Delegate cb_onLowMemory;

		// Token: 0x04000A50 RID: 2640
		private static Delegate cb_onTrimMemory_I;

		// Token: 0x04000A51 RID: 2641
		private static Delegate cb_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;

		// Token: 0x04000A52 RID: 2642
		private static Delegate cb_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
	}
}
