using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Cache
{
	// Token: 0x0200017B RID: 379
	[Register("com/unity3d/services/core/cache/CacheDirectory", DoNotGenerateAcw = true)]
	public class CacheDirectory : Java.Lang.Object
	{
		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x0002D8F8 File Offset: 0x0002BAF8
		internal static IntPtr class_ref
		{
			get
			{
				return CacheDirectory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x0002D91C File Offset: 0x0002BB1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CacheDirectory._members;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x0002D924 File Offset: 0x0002BB24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CacheDirectory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060010FC RID: 4348 RVA: 0x0002D948 File Offset: 0x0002BB48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CacheDirectory._members.ManagedPeerType;
			}
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x000021E8 File Offset: 0x000003E8
		protected CacheDirectory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x0002D954 File Offset: 0x0002BB54
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe CacheDirectory(string cacheDirName) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(cacheDirName);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(CacheDirectory._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CacheDirectory._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x0002D9F8 File Offset: 0x0002BBF8
		private static Delegate GetGetTypeHandler()
		{
			if (CacheDirectory.cb_getType == null)
			{
				CacheDirectory.cb_getType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CacheDirectory.n_GetType));
			}
			return CacheDirectory.cb_getType;
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x0002DA1C File Offset: 0x0002BC1C
		private static IntPtr n_GetType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CacheDirectory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Type);
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x0002DA30 File Offset: 0x0002BC30
		public virtual CacheDirectoryType Type
		{
			[Register("getType", "()Lcom/unity3d/services/core/cache/CacheDirectoryType;", "GetGetTypeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<CacheDirectoryType>(CacheDirectory._members.InstanceMethods.InvokeVirtualObjectMethod("getType.()Lcom/unity3d/services/core/cache/CacheDirectoryType;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x0002DA62 File Offset: 0x0002BC62
		private static Delegate GetCreateCacheDirectory_Ljava_io_File_Ljava_lang_String_Handler()
		{
			if (CacheDirectory.cb_createCacheDirectory_Ljava_io_File_Ljava_lang_String_ == null)
			{
				CacheDirectory.cb_createCacheDirectory_Ljava_io_File_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CacheDirectory.n_CreateCacheDirectory_Ljava_io_File_Ljava_lang_String_));
			}
			return CacheDirectory.cb_createCacheDirectory_Ljava_io_File_Ljava_lang_String_;
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x0002DA88 File Offset: 0x0002BC88
		private static IntPtr n_CreateCacheDirectory_Ljava_io_File_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_baseDir, IntPtr native_newDir)
		{
			CacheDirectory @object = Java.Lang.Object.GetObject<CacheDirectory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			File object2 = Java.Lang.Object.GetObject<File>(native_baseDir, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_newDir, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CreateCacheDirectory(object2, @string));
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x0002DABC File Offset: 0x0002BCBC
		[Register("createCacheDirectory", "(Ljava/io/File;Ljava/lang/String;)Ljava/io/File;", "GetCreateCacheDirectory_Ljava_io_File_Ljava_lang_String_Handler")]
		public unsafe virtual File CreateCacheDirectory(File baseDir, string newDir)
		{
			IntPtr intPtr = JNIEnv.NewString(newDir);
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((baseDir == null) ? IntPtr.Zero : baseDir.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<File>(CacheDirectory._members.InstanceMethods.InvokeVirtualObjectMethod("createCacheDirectory.(Ljava/io/File;Ljava/lang/String;)Ljava/io/File;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(baseDir);
			}
			return @object;
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x0002DB50 File Offset: 0x0002BD50
		private static Delegate GetGetCacheDirectory_Landroid_content_Context_Handler()
		{
			if (CacheDirectory.cb_getCacheDirectory_Landroid_content_Context_ == null)
			{
				CacheDirectory.cb_getCacheDirectory_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CacheDirectory.n_GetCacheDirectory_Landroid_content_Context_));
			}
			return CacheDirectory.cb_getCacheDirectory_Landroid_content_Context_;
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x0002DB74 File Offset: 0x0002BD74
		private static IntPtr n_GetCacheDirectory_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			CacheDirectory @object = Java.Lang.Object.GetObject<CacheDirectory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetCacheDirectory(object2));
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x0002DB9C File Offset: 0x0002BD9C
		[Register("getCacheDirectory", "(Landroid/content/Context;)Ljava/io/File;", "GetGetCacheDirectory_Landroid_content_Context_Handler")]
		public unsafe virtual File GetCacheDirectory(Context context)
		{
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<File>(CacheDirectory._members.InstanceMethods.InvokeVirtualObjectMethod("getCacheDirectory.(Landroid/content/Context;)Ljava/io/File;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x0002DC10 File Offset: 0x0002BE10
		private static Delegate GetTestCacheDirectory_Ljava_io_File_Handler()
		{
			if (CacheDirectory.cb_testCacheDirectory_Ljava_io_File_ == null)
			{
				CacheDirectory.cb_testCacheDirectory_Ljava_io_File_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(CacheDirectory.n_TestCacheDirectory_Ljava_io_File_));
			}
			return CacheDirectory.cb_testCacheDirectory_Ljava_io_File_;
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x0002DC34 File Offset: 0x0002BE34
		private static bool n_TestCacheDirectory_Ljava_io_File_(IntPtr jnienv, IntPtr native__this, IntPtr native_directory)
		{
			CacheDirectory @object = Java.Lang.Object.GetObject<CacheDirectory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			File object2 = Java.Lang.Object.GetObject<File>(native_directory, JniHandleOwnership.DoNotTransfer);
			return @object.TestCacheDirectory(object2);
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0002DC58 File Offset: 0x0002BE58
		[Register("testCacheDirectory", "(Ljava/io/File;)Z", "GetTestCacheDirectory_Ljava_io_File_Handler")]
		public unsafe virtual bool TestCacheDirectory(File directory)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((directory == null) ? IntPtr.Zero : directory.Handle);
				result = CacheDirectory._members.InstanceMethods.InvokeVirtualBooleanMethod("testCacheDirectory.(Ljava/io/File;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(directory);
			}
			return result;
		}

		// Token: 0x04000438 RID: 1080
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/cache/CacheDirectory", typeof(CacheDirectory));

		// Token: 0x04000439 RID: 1081
		private static Delegate cb_getType;

		// Token: 0x0400043A RID: 1082
		private static Delegate cb_createCacheDirectory_Ljava_io_File_Ljava_lang_String_;

		// Token: 0x0400043B RID: 1083
		private static Delegate cb_getCacheDirectory_Landroid_content_Context_;

		// Token: 0x0400043C RID: 1084
		private static Delegate cb_testCacheDirectory_Ljava_io_File_;
	}
}
