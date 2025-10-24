using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Preferences
{
	// Token: 0x020000D4 RID: 212
	[Register("com/unity3d/services/core/preferences/AndroidPreferences", DoNotGenerateAcw = true)]
	public class AndroidPreferences : Java.Lang.Object
	{
		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00017D60 File Offset: 0x00015F60
		internal static IntPtr class_ref
		{
			get
			{
				return AndroidPreferences._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x00017D84 File Offset: 0x00015F84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AndroidPreferences._members;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x00017D8C File Offset: 0x00015F8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AndroidPreferences._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x00017DB0 File Offset: 0x00015FB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AndroidPreferences._members.ManagedPeerType;
			}
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x000021E8 File Offset: 0x000003E8
		protected AndroidPreferences(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00017DBC File Offset: 0x00015FBC
		[Register(".ctor", "()V", "")]
		public AndroidPreferences() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AndroidPreferences._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AndroidPreferences._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00017E2C File Offset: 0x0001602C
		[Register("getBoolean", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Boolean;", "")]
		public unsafe static Java.Lang.Boolean GetBoolean(string name, string key)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			Java.Lang.Boolean @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Boolean>(AndroidPreferences._members.StaticMethods.InvokeObjectMethod("getBoolean.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Boolean;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00017EB8 File Offset: 0x000160B8
		[Register("getFloat", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Float;", "")]
		public unsafe static Float GetFloat(string name, string key)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			Float @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Float>(AndroidPreferences._members.StaticMethods.InvokeObjectMethod("getFloat.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Float;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00017F44 File Offset: 0x00016144
		[Register("getInteger", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Integer;", "")]
		public unsafe static Integer GetInteger(string name, string key)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			Integer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Integer>(AndroidPreferences._members.StaticMethods.InvokeObjectMethod("getInteger.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Integer;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00017FD0 File Offset: 0x000161D0
		[Register("getLong", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Long;", "")]
		public unsafe static Long GetLong(string name, string key)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			Long @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Long>(AndroidPreferences._members.StaticMethods.InvokeObjectMethod("getLong.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Long;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0001805C File Offset: 0x0001625C
		[Register("getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string GetString(string name, string key)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(AndroidPreferences._members.StaticMethods.InvokeObjectMethod("getString.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @string;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x000180E8 File Offset: 0x000162E8
		[Register("hasKey", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public unsafe static bool HasKey(string name, string key)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = AndroidPreferences._members.StaticMethods.InvokeBooleanMethod("hasKey.(Ljava/lang/String;Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return result;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00018164 File Offset: 0x00016364
		[Register("removeKey", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe static void RemoveKey(string name, string key)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				AndroidPreferences._members.StaticMethods.InvokeVoidMethod("removeKey.(Ljava/lang/String;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x000181E0 File Offset: 0x000163E0
		[Register("setBoolean", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Boolean;)V", "")]
		public unsafe static void SetBoolean(string name, string key, Java.Lang.Boolean value)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				AndroidPreferences._members.StaticMethods.InvokeVoidMethod("setBoolean.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Boolean;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00018288 File Offset: 0x00016488
		[Register("setFloat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Double;)V", "")]
		public unsafe static void SetFloat(string name, string key, Java.Lang.Double value)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				AndroidPreferences._members.StaticMethods.InvokeVoidMethod("setFloat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Double;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00018330 File Offset: 0x00016530
		[Register("setInteger", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;)V", "")]
		public unsafe static void SetInteger(string name, string key, Integer value)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				AndroidPreferences._members.StaticMethods.InvokeVoidMethod("setInteger.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x000183D8 File Offset: 0x000165D8
		[Register("setLong", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;)V", "")]
		public unsafe static void SetLong(string name, string key, Long value)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				AndroidPreferences._members.StaticMethods.InvokeVoidMethod("setLong.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00018480 File Offset: 0x00016680
		[Register("setString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe static void SetString(string name, string key, string value)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			IntPtr intPtr3 = JNIEnv.NewString(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				AndroidPreferences._members.StaticMethods.InvokeVoidMethod("setString.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
		}

		// Token: 0x040001F5 RID: 501
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/preferences/AndroidPreferences", typeof(AndroidPreferences));
	}
}
