using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Core.Misc
{
	// Token: 0x020000E5 RID: 229
	[Register("com/unity3d/services/core/misc/Utilities", DoNotGenerateAcw = true)]
	public class Utilities : Java.Lang.Object
	{
		// Token: 0x170002DF RID: 735
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x0001A2D0 File Offset: 0x000184D0
		internal static IntPtr class_ref
		{
			get
			{
				return Utilities._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x0001A2F4 File Offset: 0x000184F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Utilities._members;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x0001A2FC File Offset: 0x000184FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Utilities._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x0001A320 File Offset: 0x00018520
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Utilities._members.ManagedPeerType;
			}
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Utilities(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0001A32C File Offset: 0x0001852C
		[Register(".ctor", "()V", "")]
		public Utilities() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Utilities._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Utilities._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0001A39C File Offset: 0x0001859C
		[Register("Sha256", "([B)Ljava/lang/String;", "")]
		public unsafe static string Sha256(byte[] input)
		{
			IntPtr intPtr = JNIEnv.NewArray(input);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(Utilities._members.StaticMethods.InvokeObjectMethod("Sha256.([B)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (input != null)
				{
					JNIEnv.CopyArray(intPtr, input);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(input);
			}
			return @string;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0001A418 File Offset: 0x00018618
		[Register("Sha256", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public unsafe static string Sha256(Stream inputStream)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(inputStream);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(Utilities._members.StaticMethods.InvokeObjectMethod("Sha256.(Ljava/io/InputStream;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(inputStream);
			}
			return @string;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0001A488 File Offset: 0x00018688
		[Register("Sha256", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string Sha256(string input)
		{
			IntPtr intPtr = JNIEnv.NewString(input);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(Utilities._members.StaticMethods.InvokeObjectMethod("Sha256.(Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0001A4F4 File Offset: 0x000186F4
		[Register("combineJsonIntoMap", "(Ljava/util/Map;Lorg/json/JSONObject;)Ljava/util/Map;", "")]
		public unsafe static IDictionary<string, Java.Lang.Object> CombineJsonIntoMap(IDictionary<string, Java.Lang.Object> inputMap, JSONObject jsonObject)
		{
			IntPtr intPtr = JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(inputMap);
			IDictionary<string, Java.Lang.Object> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((jsonObject == null) ? IntPtr.Zero : jsonObject.Handle);
				result = JavaDictionary<string, Java.Lang.Object>.FromJniHandle(Utilities._members.StaticMethods.InvokeObjectMethod("combineJsonIntoMap.(Ljava/util/Map;Lorg/json/JSONObject;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(inputMap);
				GC.KeepAlive(jsonObject);
			}
			return result;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0001A58C File Offset: 0x0001878C
		[Register("combineJsonIntoMap", "(Ljava/util/Map;Lorg/json/JSONObject;Ljava/lang/String;)Ljava/util/Map;", "")]
		public unsafe static IDictionary<string, Java.Lang.Object> CombineJsonIntoMap(IDictionary<string, Java.Lang.Object> outputMap, JSONObject jsonObject, string prependToKey)
		{
			IntPtr intPtr = JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(outputMap);
			IntPtr intPtr2 = JNIEnv.NewString(prependToKey);
			IDictionary<string, Java.Lang.Object> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((jsonObject == null) ? IntPtr.Zero : jsonObject.Handle);
				ptr[2] = new JniArgumentValue(intPtr2);
				result = JavaDictionary<string, Java.Lang.Object>.FromJniHandle(Utilities._members.StaticMethods.InvokeObjectMethod("combineJsonIntoMap.(Ljava/util/Map;Lorg/json/JSONObject;Ljava/lang/String;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(outputMap);
				GC.KeepAlive(jsonObject);
			}
			return result;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0001A64C File Offset: 0x0001884C
		[Register("convertJsonToMap", "(Lorg/json/JSONObject;)Ljava/util/Map;", "")]
		public unsafe static IDictionary<string, Java.Lang.Object> ConvertJsonToMap(JSONObject jsonObject)
		{
			IDictionary<string, Java.Lang.Object> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((jsonObject == null) ? IntPtr.Zero : jsonObject.Handle);
				result = JavaDictionary<string, Java.Lang.Object>.FromJniHandle(Utilities._members.StaticMethods.InvokeObjectMethod("convertJsonToMap.(Lorg/json/JSONObject;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(jsonObject);
			}
			return result;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0001A6C0 File Offset: 0x000188C0
		[Register("mergeJsonObjects", "(Lorg/json/JSONObject;Lorg/json/JSONObject;)Lorg/json/JSONObject;", "")]
		public unsafe static JSONObject MergeJsonObjects(JSONObject primary, JSONObject secondary)
		{
			JSONObject @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((primary == null) ? IntPtr.Zero : primary.Handle);
				ptr[1] = new JniArgumentValue((secondary == null) ? IntPtr.Zero : secondary.Handle);
				@object = Java.Lang.Object.GetObject<JSONObject>(Utilities._members.StaticMethods.InvokeObjectMethod("mergeJsonObjects.(Lorg/json/JSONObject;Lorg/json/JSONObject;)Lorg/json/JSONObject;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(primary);
				GC.KeepAlive(secondary);
			}
			return @object;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0001A75C File Offset: 0x0001895C
		[Register("readFileBytes", "(Ljava/io/File;)[B", "")]
		public unsafe static byte[] ReadFileBytes(Java.IO.File file)
		{
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((file == null) ? IntPtr.Zero : file.Handle);
				result = (byte[])JNIEnv.GetArray(Utilities._members.StaticMethods.InvokeObjectMethod("readFileBytes.(Ljava/io/File;)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				GC.KeepAlive(file);
			}
			return result;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0001A7E0 File Offset: 0x000189E0
		[Register("runOnUiThread", "(Ljava/lang/Runnable;)V", "")]
		public unsafe static void RunOnUiThread(IRunnable runnable)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((runnable == null) ? IntPtr.Zero : ((Java.Lang.Object)runnable).Handle);
				Utilities._members.StaticMethods.InvokeVoidMethod("runOnUiThread.(Ljava/lang/Runnable;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(runnable);
			}
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0001A848 File Offset: 0x00018A48
		[Register("runOnUiThread", "(Ljava/lang/Runnable;J)V", "")]
		public unsafe static void RunOnUiThread(IRunnable runnable, long delay)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((runnable == null) ? IntPtr.Zero : ((Java.Lang.Object)runnable).Handle);
				ptr[1] = new JniArgumentValue(delay);
				Utilities._members.StaticMethods.InvokeVoidMethod("runOnUiThread.(Ljava/lang/Runnable;J)V", ptr);
			}
			finally
			{
				GC.KeepAlive(runnable);
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0001A8C4 File Offset: 0x00018AC4
		[Register("toHexString", "([B)Ljava/lang/String;", "")]
		public unsafe static string ToHexString(byte[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray(array);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(Utilities._members.StaticMethods.InvokeObjectMethod("toHexString.([B)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(array);
			}
			return @string;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0001A940 File Offset: 0x00018B40
		[Register("writeFile", "(Ljava/io/File;Ljava/lang/String;)Z", "")]
		public unsafe static bool WriteFile(Java.IO.File fileToWrite, string content)
		{
			IntPtr intPtr = JNIEnv.NewString(content);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fileToWrite == null) ? IntPtr.Zero : fileToWrite.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = Utilities._members.StaticMethods.InvokeBooleanMethod("writeFile.(Ljava/io/File;Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(fileToWrite);
			}
			return result;
		}

		// Token: 0x04000227 RID: 551
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/misc/Utilities", typeof(Utilities));
	}
}
