using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Util.Concurrent;

namespace AndroidX.Core.Content
{
	// Token: 0x02000057 RID: 87
	[Register("androidx/core/content/ContextCompat", DoNotGenerateAcw = true)]
	public class ContextCompat : Java.Lang.Object
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00007DFC File Offset: 0x00005FFC
		internal static IntPtr class_ref
		{
			get
			{
				return ContextCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00007E20 File Offset: 0x00006020
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ContextCompat._members;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00007E28 File Offset: 0x00006028
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ContextCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00007E4C File Offset: 0x0000604C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ContextCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002384 File Offset: 0x00000584
		protected ContextCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00007E58 File Offset: 0x00006058
		[Register(".ctor", "()V", "")]
		protected ContextCompat() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ContextCompat._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ContextCompat._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00007EC8 File Offset: 0x000060C8
		[Register("checkSelfPermission", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		[return: GeneratedEnum]
		public unsafe static Permission CheckSelfPermission(Context context, string permission)
		{
			IntPtr intPtr = JNIEnv.NewString(permission);
			Permission result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = (Permission)ContextCompat._members.StaticMethods.InvokeInt32Method("checkSelfPermission.(Landroid/content/Context;Ljava/lang/String;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
			}
			return result;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00007F4C File Offset: 0x0000614C
		[Register("createDeviceProtectedStorageContext", "(Landroid/content/Context;)Landroid/content/Context;", "")]
		public unsafe static Context CreateDeviceProtectedStorageContext(Context context)
		{
			Context @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<Context>(ContextCompat._members.StaticMethods.InvokeObjectMethod("createDeviceProtectedStorageContext.(Landroid/content/Context;)Landroid/content/Context;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00007FC0 File Offset: 0x000061C0
		[Register("getAttributionTag", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public unsafe static string GetAttributionTag(Context context)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@string = JNIEnv.GetString(ContextCompat._members.StaticMethods.InvokeObjectMethod("getAttributionTag.(Landroid/content/Context;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @string;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00008034 File Offset: 0x00006234
		[Register("getCodeCacheDir", "(Landroid/content/Context;)Ljava/io/File;", "")]
		public unsafe static File GetCodeCacheDir(Context context)
		{
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<File>(ContextCompat._members.StaticMethods.InvokeObjectMethod("getCodeCacheDir.(Landroid/content/Context;)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000080A8 File Offset: 0x000062A8
		[Register("getColor", "(Landroid/content/Context;I)I", "")]
		public unsafe static int GetColor(Context context, int id)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(id);
				result = ContextCompat._members.StaticMethods.InvokeInt32Method("getColor.(Landroid/content/Context;I)I", ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return result;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00008120 File Offset: 0x00006320
		[Register("getColorStateList", "(Landroid/content/Context;I)Landroid/content/res/ColorStateList;", "")]
		public unsafe static ColorStateList GetColorStateList(Context context, int id)
		{
			ColorStateList @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(id);
				@object = Java.Lang.Object.GetObject<ColorStateList>(ContextCompat._members.StaticMethods.InvokeObjectMethod("getColorStateList.(Landroid/content/Context;I)Landroid/content/res/ColorStateList;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000081A8 File Offset: 0x000063A8
		[Register("getContextForLanguage", "(Landroid/content/Context;)Landroid/content/Context;", "")]
		public unsafe static Context GetContextForLanguage(Context context)
		{
			Context @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<Context>(ContextCompat._members.StaticMethods.InvokeObjectMethod("getContextForLanguage.(Landroid/content/Context;)Landroid/content/Context;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000821C File Offset: 0x0000641C
		[Register("getDataDir", "(Landroid/content/Context;)Ljava/io/File;", "")]
		public unsafe static File GetDataDir(Context context)
		{
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<File>(ContextCompat._members.StaticMethods.InvokeObjectMethod("getDataDir.(Landroid/content/Context;)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00008290 File Offset: 0x00006490
		[Register("getDisplayOrDefault", "(Landroid/content/Context;)Landroid/view/Display;", "")]
		public unsafe static Display GetDisplayOrDefault(Context context)
		{
			Display @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<Display>(ContextCompat._members.StaticMethods.InvokeObjectMethod("getDisplayOrDefault.(Landroid/content/Context;)Landroid/view/Display;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00008304 File Offset: 0x00006504
		[Register("getDrawable", "(Landroid/content/Context;I)Landroid/graphics/drawable/Drawable;", "")]
		public unsafe static Drawable GetDrawable(Context context, int id)
		{
			Drawable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(id);
				@object = Java.Lang.Object.GetObject<Drawable>(ContextCompat._members.StaticMethods.InvokeObjectMethod("getDrawable.(Landroid/content/Context;I)Landroid/graphics/drawable/Drawable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000838C File Offset: 0x0000658C
		[Register("getExternalCacheDirs", "(Landroid/content/Context;)[Ljava/io/File;", "")]
		public unsafe static File[] GetExternalCacheDirs(Context context)
		{
			File[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				result = (File[])JNIEnv.GetArray(ContextCompat._members.StaticMethods.InvokeObjectMethod("getExternalCacheDirs.(Landroid/content/Context;)[Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(File));
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return result;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00008410 File Offset: 0x00006610
		[Register("getExternalFilesDirs", "(Landroid/content/Context;Ljava/lang/String;)[Ljava/io/File;", "")]
		public unsafe static File[] GetExternalFilesDirs(Context context, string type)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			File[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = (File[])JNIEnv.GetArray(ContextCompat._members.StaticMethods.InvokeObjectMethod("getExternalFilesDirs.(Landroid/content/Context;Ljava/lang/String;)[Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(File));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
			}
			return result;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x000084B4 File Offset: 0x000066B4
		[Register("getMainExecutor", "(Landroid/content/Context;)Ljava/util/concurrent/Executor;", "")]
		public unsafe static IExecutor GetMainExecutor(Context context)
		{
			IExecutor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<IExecutor>(ContextCompat._members.StaticMethods.InvokeObjectMethod("getMainExecutor.(Landroid/content/Context;)Ljava/util/concurrent/Executor;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00008528 File Offset: 0x00006728
		[Register("getNoBackupFilesDir", "(Landroid/content/Context;)Ljava/io/File;", "")]
		public unsafe static File GetNoBackupFilesDir(Context context)
		{
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<File>(ContextCompat._members.StaticMethods.InvokeObjectMethod("getNoBackupFilesDir.(Landroid/content/Context;)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000859C File Offset: 0x0000679C
		[Register("getObbDirs", "(Landroid/content/Context;)[Ljava/io/File;", "")]
		public unsafe static File[] GetObbDirs(Context context)
		{
			File[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				result = (File[])JNIEnv.GetArray(ContextCompat._members.StaticMethods.InvokeObjectMethod("getObbDirs.(Landroid/content/Context;)[Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(File));
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return result;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00008620 File Offset: 0x00006820
		[Register("getString", "(Landroid/content/Context;I)Ljava/lang/String;", "")]
		public unsafe static string GetString(Context context, int resId)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(resId);
				@string = JNIEnv.GetString(ContextCompat._members.StaticMethods.InvokeObjectMethod("getString.(Landroid/content/Context;I)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @string;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000086A8 File Offset: 0x000068A8
		[Register("getSystemService", "(Landroid/content/Context;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object GetSystemService(Context context, Class serviceClass)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((serviceClass == null) ? IntPtr.Zero : serviceClass.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ContextCompat._members.StaticMethods.InvokeObjectMethod("getSystemService.(Landroid/content/Context;Ljava/lang/Class;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(serviceClass);
			}
			return @object;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00008744 File Offset: 0x00006944
		[Register("getSystemServiceName", "(Landroid/content/Context;Ljava/lang/Class;)Ljava/lang/String;", "")]
		public unsafe static string GetSystemServiceName(Context context, Class serviceClass)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((serviceClass == null) ? IntPtr.Zero : serviceClass.Handle);
				@string = JNIEnv.GetString(ContextCompat._members.StaticMethods.InvokeObjectMethod("getSystemServiceName.(Landroid/content/Context;Ljava/lang/Class;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(serviceClass);
			}
			return @string;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x000087E0 File Offset: 0x000069E0
		[Register("isDeviceProtectedStorage", "(Landroid/content/Context;)Z", "")]
		public unsafe static bool IsDeviceProtectedStorage(Context context)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				result = ContextCompat._members.StaticMethods.InvokeBooleanMethod("isDeviceProtectedStorage.(Landroid/content/Context;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return result;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00008844 File Offset: 0x00006A44
		[Register("registerReceiver", "(Landroid/content/Context;Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;I)Landroid/content/Intent;", "")]
		public unsafe static Intent RegisterReceiver(Context context, BroadcastReceiver receiver, IntentFilter filter, int flags)
		{
			Intent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				ptr[2] = new JniArgumentValue((filter == null) ? IntPtr.Zero : filter.Handle);
				ptr[3] = new JniArgumentValue(flags);
				@object = Java.Lang.Object.GetObject<Intent>(ContextCompat._members.StaticMethods.InvokeObjectMethod("registerReceiver.(Landroid/content/Context;Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;I)Landroid/content/Intent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(receiver);
				GC.KeepAlive(filter);
			}
			return @object;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00008920 File Offset: 0x00006B20
		[Register("registerReceiver", "(Landroid/content/Context;Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;I)Landroid/content/Intent;", "")]
		public unsafe static Intent RegisterReceiver(Context context, BroadcastReceiver receiver, IntentFilter filter, string broadcastPermission, Handler scheduler, int flags)
		{
			IntPtr intPtr = JNIEnv.NewString(broadcastPermission);
			Intent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				ptr[2] = new JniArgumentValue((filter == null) ? IntPtr.Zero : filter.Handle);
				ptr[3] = new JniArgumentValue(intPtr);
				ptr[4] = new JniArgumentValue((scheduler == null) ? IntPtr.Zero : scheduler.Handle);
				ptr[5] = new JniArgumentValue(flags);
				@object = Java.Lang.Object.GetObject<Intent>(ContextCompat._members.StaticMethods.InvokeObjectMethod("registerReceiver.(Landroid/content/Context;Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;I)Landroid/content/Intent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(receiver);
				GC.KeepAlive(filter);
				GC.KeepAlive(scheduler);
			}
			return @object;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00008A50 File Offset: 0x00006C50
		[Register("startActivities", "(Landroid/content/Context;[Landroid/content/Intent;)Z", "")]
		public unsafe static bool StartActivities(Context context, Intent[] intents)
		{
			IntPtr intPtr = JNIEnv.NewArray<Intent>(intents);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ContextCompat._members.StaticMethods.InvokeBooleanMethod("startActivities.(Landroid/content/Context;[Landroid/content/Intent;)Z", ptr);
			}
			finally
			{
				if (intents != null)
				{
					JNIEnv.CopyArray<Intent>(intPtr, intents);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(context);
				GC.KeepAlive(intents);
			}
			return result;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00008AE4 File Offset: 0x00006CE4
		[Register("startActivities", "(Landroid/content/Context;[Landroid/content/Intent;Landroid/os/Bundle;)Z", "")]
		public unsafe static bool StartActivities(Context context, Intent[] intents, Bundle options)
		{
			IntPtr intPtr = JNIEnv.NewArray<Intent>(intents);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = ContextCompat._members.StaticMethods.InvokeBooleanMethod("startActivities.(Landroid/content/Context;[Landroid/content/Intent;Landroid/os/Bundle;)Z", ptr);
			}
			finally
			{
				if (intents != null)
				{
					JNIEnv.CopyArray<Intent>(intPtr, intents);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(context);
				GC.KeepAlive(intents);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00008BA4 File Offset: 0x00006DA4
		[Register("startActivity", "(Landroid/content/Context;Landroid/content/Intent;Landroid/os/Bundle;)V", "")]
		public unsafe static void StartActivity(Context context, Intent intent, Bundle options)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[2] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				ContextCompat._members.StaticMethods.InvokeVoidMethod("startActivity.(Landroid/content/Context;Landroid/content/Intent;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(intent);
				GC.KeepAlive(options);
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00008C5C File Offset: 0x00006E5C
		[Register("startForegroundService", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public unsafe static void StartForegroundService(Context context, Intent intent)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ContextCompat._members.StaticMethods.InvokeVoidMethod("startForegroundService.(Landroid/content/Context;Landroid/content/Intent;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(intent);
			}
		}

		// Token: 0x040000CB RID: 203
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/content/ContextCompat", typeof(ContextCompat));
	}
}
