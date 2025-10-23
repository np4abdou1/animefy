using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Applovin.Impl.Sdk.Utils
{
	// Token: 0x0200013A RID: 314
	[Register("com/applovin/impl/sdk/utils/JsonUtils", DoNotGenerateAcw = true)]
	public class JsonUtils : Java.Lang.Object
	{
		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x00028E3C File Offset: 0x0002703C
		internal static IntPtr class_ref
		{
			get
			{
				return JsonUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x00028E60 File Offset: 0x00027060
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JsonUtils._members;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x00028E68 File Offset: 0x00027068
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JsonUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x00028E8C File Offset: 0x0002708C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JsonUtils._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x000021F0 File Offset: 0x000003F0
		protected JsonUtils(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00028E98 File Offset: 0x00027098
		[Register(".ctor", "()V", "")]
		public JsonUtils() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(JsonUtils._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			JsonUtils._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00028F08 File Offset: 0x00027108
		[Register("containsCaseInsensitiveString", "(Ljava/lang/String;Lorg/json/JSONArray;)Z", "")]
		public unsafe static bool ContainsCaseInsensitiveString(string p0, JSONArray p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				result = JsonUtils._members.StaticMethods.InvokeBooleanMethod("containsCaseInsensitiveString.(Ljava/lang/String;Lorg/json/JSONArray;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
			return result;
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00028F8C File Offset: 0x0002718C
		[Register("deepCopy", "(Lorg/json/JSONArray;)Lorg/json/JSONArray;", "")]
		public unsafe static JSONArray DeepCopy(JSONArray p0)
		{
			JSONArray @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<JSONArray>(JsonUtils._members.StaticMethods.InvokeObjectMethod("deepCopy.(Lorg/json/JSONArray;)Lorg/json/JSONArray;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00029000 File Offset: 0x00027200
		[Register("deepCopy", "(Lorg/json/JSONObject;)Lorg/json/JSONObject;", "")]
		public unsafe static JSONObject DeepCopy(JSONObject p0)
		{
			JSONObject @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<JSONObject>(JsonUtils._members.StaticMethods.InvokeObjectMethod("deepCopy.(Lorg/json/JSONObject;)Lorg/json/JSONObject;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00029074 File Offset: 0x00027274
		[Register("deserialize", "(Ljava/lang/String;)Lorg/json/JSONObject;", "")]
		public unsafe static JSONObject Deserialize(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			JSONObject @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<JSONObject>(JsonUtils._members.StaticMethods.InvokeObjectMethod("deserialize.(Ljava/lang/String;)Lorg/json/JSONObject;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x000290E0 File Offset: 0x000272E0
		[Register("getBoolean", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/Boolean;)Ljava/lang/Boolean;", "")]
		public unsafe static Java.Lang.Boolean GetBoolean(JSONObject p0, string p1, Java.Lang.Boolean p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			Java.Lang.Boolean @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Boolean>(JsonUtils._members.StaticMethods.InvokeObjectMethod("getBoolean.(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/Boolean;)Ljava/lang/Boolean;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x000291A0 File Offset: 0x000273A0
		[Register("getDouble", "(Lorg/json/JSONObject;Ljava/lang/String;D)D", "")]
		public unsafe static double GetDouble(JSONObject p0, string p1, double p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(p2);
				result = JsonUtils._members.StaticMethods.InvokeDoubleMethod("getDouble.(Lorg/json/JSONObject;Ljava/lang/String;D)D", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0002923C File Offset: 0x0002743C
		[Register("getFloat", "(Lorg/json/JSONObject;Ljava/lang/String;F)F", "")]
		public unsafe static float GetFloat(JSONObject p0, string p1, float p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			float result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(p2);
				result = JsonUtils._members.StaticMethods.InvokeSingleMethod("getFloat.(Lorg/json/JSONObject;Ljava/lang/String;F)F", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x000292D8 File Offset: 0x000274D8
		[Register("getFloat", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/Float;)Ljava/lang/Float;", "")]
		public unsafe static Float GetFloat(JSONObject p0, string p1, Float p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			Float @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				@object = Java.Lang.Object.GetObject<Float>(JsonUtils._members.StaticMethods.InvokeObjectMethod("getFloat.(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/Float;)Ljava/lang/Float;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00029398 File Offset: 0x00027598
		[Register("getInt", "(Lorg/json/JSONObject;Ljava/lang/String;I)I", "")]
		public unsafe static int GetInt(JSONObject p0, string p1, int p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(p2);
				result = JsonUtils._members.StaticMethods.InvokeInt32Method("getInt.(Lorg/json/JSONObject;Ljava/lang/String;I)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00029434 File Offset: 0x00027634
		[Register("getIntegerList", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/util/List;)Ljava/util/List;", "")]
		public unsafe static IList<Integer> GetIntegerList(JSONObject p0, string p1, IList<Integer> p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			IntPtr intPtr2 = JavaList<Integer>.ToLocalJniHandle(p2);
			IList<Integer> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				result = JavaList<Integer>.FromJniHandle(JsonUtils._members.StaticMethods.InvokeObjectMethod("getIntegerList.(Lorg/json/JSONObject;Ljava/lang/String;Ljava/util/List;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
			return result;
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x000294F4 File Offset: 0x000276F4
		[Register("getJSONArray", "(Ljava/lang/Object;)Lorg/json/JSONArray;", "")]
		public unsafe static JSONArray GetJSONArray(Java.Lang.Object p0)
		{
			JSONArray @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<JSONArray>(JsonUtils._members.StaticMethods.InvokeObjectMethod("getJSONArray.(Ljava/lang/Object;)Lorg/json/JSONArray;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00029568 File Offset: 0x00027768
		[Register("getJSONArray", "(Lorg/json/JSONObject;Ljava/lang/String;Lorg/json/JSONArray;)Lorg/json/JSONArray;", "")]
		public unsafe static JSONArray GetJSONArray(JSONObject p0, string p1, JSONArray p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			JSONArray @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				@object = Java.Lang.Object.GetObject<JSONArray>(JsonUtils._members.StaticMethods.InvokeObjectMethod("getJSONArray.(Lorg/json/JSONObject;Ljava/lang/String;Lorg/json/JSONArray;)Lorg/json/JSONArray;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00029628 File Offset: 0x00027828
		[Register("getJSONObject", "(Lorg/json/JSONArray;ILorg/json/JSONObject;)Lorg/json/JSONObject;", "")]
		public unsafe static JSONObject GetJSONObject(JSONArray p0, int p1, JSONObject p2)
		{
			JSONObject @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(p1);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				@object = Java.Lang.Object.GetObject<JSONObject>(JsonUtils._members.StaticMethods.InvokeObjectMethod("getJSONObject.(Lorg/json/JSONArray;ILorg/json/JSONObject;)Lorg/json/JSONObject;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x000296D8 File Offset: 0x000278D8
		[Register("getJSONObject", "(Lorg/json/JSONObject;Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;", "")]
		public unsafe static JSONObject GetJSONObject(JSONObject p0, string p1, JSONObject p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			JSONObject @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				@object = Java.Lang.Object.GetObject<JSONObject>(JsonUtils._members.StaticMethods.InvokeObjectMethod("getJSONObject.(Lorg/json/JSONObject;Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00029798 File Offset: 0x00027998
		[Register("getList", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/util/List;)Ljava/util/List;", "")]
		public unsafe static IList GetList(JSONObject p0, string p1, IList p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			IntPtr intPtr2 = JavaList.ToLocalJniHandle(p2);
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				result = JavaList.FromJniHandle(JsonUtils._members.StaticMethods.InvokeObjectMethod("getList.(Lorg/json/JSONObject;Ljava/lang/String;Ljava/util/List;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
			return result;
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00029858 File Offset: 0x00027A58
		[Register("getLong", "(Lorg/json/JSONObject;Ljava/lang/String;J)J", "")]
		public unsafe static long GetLong(JSONObject p0, string p1, long p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(p2);
				result = JsonUtils._members.StaticMethods.InvokeInt64Method("getLong.(Lorg/json/JSONObject;Ljava/lang/String;J)J", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x000298F4 File Offset: 0x00027AF4
		[Register("getObject", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public unsafe static Java.Lang.Object GetObject(JSONObject p0, string p1, Java.Lang.Object p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(JsonUtils._members.StaticMethods.InvokeObjectMethod("getObject.(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x000299B4 File Offset: 0x00027BB4
		[Register("getObjectAtIndex", "(Lorg/json/JSONArray;ILjava/lang/Object;)Ljava/lang/Object;", "")]
		public unsafe static Java.Lang.Object GetObjectAtIndex(JSONArray p0, int p1, Java.Lang.Object p2)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(p1);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(JsonUtils._members.StaticMethods.InvokeObjectMethod("getObjectAtIndex.(Lorg/json/JSONArray;ILjava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00029A64 File Offset: 0x00027C64
		[Register("getString", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string GetString(JSONObject p0, string p1, string p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			IntPtr intPtr2 = JNIEnv.NewString(p2);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(JsonUtils._members.StaticMethods.InvokeObjectMethod("getString.(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p0);
			}
			return @string;
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x00029B1C File Offset: 0x00027D1C
		[Register("jsonObjectFromJsonString", "(Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;", "")]
		public unsafe static JSONObject JsonObjectFromJsonString(string p0, JSONObject p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			JSONObject @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<JSONObject>(JsonUtils._members.StaticMethods.InvokeObjectMethod("jsonObjectFromJsonString.(Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00029BB0 File Offset: 0x00027DB0
		[Register("maybeConvertToIndentedString", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public unsafe static string MaybeConvertToIndentedString(string p0, int p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				@string = JNIEnv.GetString(JsonUtils._members.StaticMethods.InvokeObjectMethod("maybeConvertToIndentedString.(Ljava/lang/String;I)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00029C30 File Offset: 0x00027E30
		[Register("maybeConvertToIndentedString", "(Lorg/json/JSONObject;)Ljava/lang/String;", "")]
		public unsafe static string MaybeConvertToIndentedString(JSONObject p0)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@string = JNIEnv.GetString(JsonUtils._members.StaticMethods.InvokeObjectMethod("maybeConvertToIndentedString.(Lorg/json/JSONObject;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @string;
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00029CA4 File Offset: 0x00027EA4
		[Register("optList", "(Lorg/json/JSONArray;Ljava/util/List;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IList OptList(JSONArray p0, IList p1)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(p1);
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(JsonUtils._members.StaticMethods.InvokeObjectMethod("optList.(Lorg/json/JSONArray;Ljava/util/List;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return result;
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00029D3C File Offset: 0x00027F3C
		[Register("putAll", "(Lorg/json/JSONObject;Lorg/json/JSONObject;)V", "")]
		public unsafe static void PutAll(JSONObject p0, JSONObject p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				JsonUtils._members.StaticMethods.InvokeVoidMethod("putAll.(Lorg/json/JSONObject;Lorg/json/JSONObject;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00029DC8 File Offset: 0x00027FC8
		[Register("putBoolean", "(Lorg/json/JSONObject;Ljava/lang/String;Z)V", "")]
		public unsafe static void PutBoolean(JSONObject p0, string p1, bool p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(p2);
				JsonUtils._members.StaticMethods.InvokeVoidMethod("putBoolean.(Lorg/json/JSONObject;Ljava/lang/String;Z)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00029E60 File Offset: 0x00028060
		[Register("putDouble", "(Lorg/json/JSONObject;Ljava/lang/String;D)V", "")]
		public unsafe static void PutDouble(JSONObject p0, string p1, double p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(p2);
				JsonUtils._members.StaticMethods.InvokeVoidMethod("putDouble.(Lorg/json/JSONObject;Ljava/lang/String;D)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00029EF8 File Offset: 0x000280F8
		[Register("putInt", "(Lorg/json/JSONObject;Ljava/lang/String;I)V", "")]
		public unsafe static void PutInt(JSONObject p0, string p1, int p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(p2);
				JsonUtils._members.StaticMethods.InvokeVoidMethod("putInt.(Lorg/json/JSONObject;Ljava/lang/String;I)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00029F90 File Offset: 0x00028190
		[Register("putJSONObject", "(Lorg/json/JSONObject;Ljava/lang/String;Lorg/json/JSONObject;)V", "")]
		public unsafe static void PutJSONObject(JSONObject p0, string p1, JSONObject p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				JsonUtils._members.StaticMethods.InvokeVoidMethod("putJSONObject.(Lorg/json/JSONObject;Ljava/lang/String;Lorg/json/JSONObject;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x0002A040 File Offset: 0x00028240
		[Register("putJsonArray", "(Lorg/json/JSONObject;Ljava/lang/String;Lorg/json/JSONArray;)V", "")]
		public unsafe static void PutJsonArray(JSONObject p0, string p1, JSONArray p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				JsonUtils._members.StaticMethods.InvokeVoidMethod("putJsonArray.(Lorg/json/JSONObject;Ljava/lang/String;Lorg/json/JSONArray;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0002A0F0 File Offset: 0x000282F0
		[Register("putLong", "(Lorg/json/JSONObject;Ljava/lang/String;J)V", "")]
		public unsafe static void PutLong(JSONObject p0, string p1, long p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(p2);
				JsonUtils._members.StaticMethods.InvokeVoidMethod("putLong.(Lorg/json/JSONObject;Ljava/lang/String;J)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x0002A188 File Offset: 0x00028388
		[Register("putObject", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public unsafe static void PutObject(JSONObject p0, string p1, Java.Lang.Object p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				JsonUtils._members.StaticMethods.InvokeVoidMethod("putObject.(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/Object;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0002A238 File Offset: 0x00028438
		[Register("putString", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe static void PutString(JSONObject p0, string p1, string p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			IntPtr intPtr2 = JNIEnv.NewString(p2);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				JsonUtils._members.StaticMethods.InvokeVoidMethod("putString.(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0002A2E0 File Offset: 0x000284E0
		[Register("removeObjectsForKeys", "(Lorg/json/JSONObject;[Ljava/lang/String;)V", "")]
		public unsafe static void RemoveObjectsForKeys(JSONObject p0, string[] p1)
		{
			IntPtr intPtr = JNIEnv.NewArray(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				JsonUtils._members.StaticMethods.InvokeVoidMethod("removeObjectsForKeys.(Lorg/json/JSONObject;[Ljava/lang/String;)V", ptr);
			}
			finally
			{
				if (p1 != null)
				{
					JNIEnv.CopyArray(intPtr, p1);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x0002A374 File Offset: 0x00028574
		[Register("shallowCopy", "(Lorg/json/JSONObject;)Lorg/json/JSONObject;", "")]
		public unsafe static JSONObject ShallowCopy(JSONObject p0)
		{
			JSONObject @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<JSONObject>(JsonUtils._members.StaticMethods.InvokeObjectMethod("shallowCopy.(Lorg/json/JSONObject;)Lorg/json/JSONObject;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x0002A3E8 File Offset: 0x000285E8
		[Register("toBundle", "(Ljava/lang/Object;)Landroid/os/Bundle;", "")]
		public unsafe static Bundle ToBundle(Java.Lang.Object p0)
		{
			Bundle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<Bundle>(JsonUtils._members.StaticMethods.InvokeObjectMethod("toBundle.(Ljava/lang/Object;)Landroid/os/Bundle;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x0002A45C File Offset: 0x0002865C
		[Register("toBundle", "(Lorg/json/JSONArray;)Ljava/util/ArrayList;", "")]
		public unsafe static IList<Bundle> ToBundle(JSONArray p0)
		{
			IList<Bundle> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = JavaList<Bundle>.FromJniHandle(JsonUtils._members.StaticMethods.InvokeObjectMethod("toBundle.(Lorg/json/JSONArray;)Ljava/util/ArrayList;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0002A4D0 File Offset: 0x000286D0
		[Register("toBundle", "(Lorg/json/JSONObject;)Landroid/os/Bundle;", "")]
		public unsafe static Bundle ToBundle(JSONObject p0)
		{
			Bundle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<Bundle>(JsonUtils._members.StaticMethods.InvokeObjectMethod("toBundle.(Lorg/json/JSONObject;)Landroid/os/Bundle;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x0002A544 File Offset: 0x00028744
		[Register("toIntegerList", "(Lorg/json/JSONArray;)Ljava/util/List;", "")]
		public unsafe static IList<Integer> ToIntegerList(JSONArray p0)
		{
			IList<Integer> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = JavaList<Integer>.FromJniHandle(JsonUtils._members.StaticMethods.InvokeObjectMethod("toIntegerList.(Lorg/json/JSONArray;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x0002A5B8 File Offset: 0x000287B8
		[Register("toList", "(Lorg/json/JSONArray;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IList ToList(JSONArray p0)
		{
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = JavaList.FromJniHandle(JsonUtils._members.StaticMethods.InvokeObjectMethod("toList.(Lorg/json/JSONArray;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x0002A62C File Offset: 0x0002882C
		[Register("toStringMap", "(Lorg/json/JSONObject;)Ljava/util/Map;", "")]
		public unsafe static IDictionary<string, string> ToStringMap(JSONObject p0)
		{
			IDictionary<string, string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = JavaDictionary<string, string>.FromJniHandle(JsonUtils._members.StaticMethods.InvokeObjectMethod("toStringMap.(Lorg/json/JSONObject;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x0002A6A0 File Offset: 0x000288A0
		[Register("toStringObjectMap", "(Ljava/lang/String;Ljava/util/Map;)Ljava/util/Map;", "")]
		public unsafe static IDictionary<string, Java.Lang.Object> ToStringObjectMap(string p0, IDictionary<string, Java.Lang.Object> p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(p1);
			IDictionary<string, Java.Lang.Object> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaDictionary<string, Java.Lang.Object>.FromJniHandle(JsonUtils._members.StaticMethods.InvokeObjectMethod("toStringObjectMap.(Ljava/lang/String;Ljava/util/Map;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p1);
			}
			return result;
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x0002A734 File Offset: 0x00028934
		[Register("toStringObjectMap", "(Lorg/json/JSONObject;)Ljava/util/Map;", "")]
		public unsafe static IDictionary<string, Java.Lang.Object> ToStringObjectMap(JSONObject p0)
		{
			IDictionary<string, Java.Lang.Object> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = JavaDictionary<string, Java.Lang.Object>.FromJniHandle(JsonUtils._members.StaticMethods.InvokeObjectMethod("toStringObjectMap.(Lorg/json/JSONObject;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x0002A7A8 File Offset: 0x000289A8
		[Register("valueExists", "(Lorg/json/JSONArray;Ljava/lang/Object;)Z", "")]
		public unsafe static bool ValueExists(JSONArray p0, Java.Lang.Object p1)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				result = JsonUtils._members.StaticMethods.InvokeBooleanMethod("valueExists.(Lorg/json/JSONArray;Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return result;
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x0002A834 File Offset: 0x00028A34
		[Register("valueExists", "(Lorg/json/JSONObject;Ljava/lang/String;)Z", "")]
		public unsafe static bool ValueExists(JSONObject p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = JsonUtils._members.StaticMethods.InvokeBooleanMethod("valueExists.(Lorg/json/JSONObject;Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x040004EE RID: 1262
		[Register("EMPTY_JSON")]
		public const string EmptyJson = "{}";

		// Token: 0x040004EF RID: 1263
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/utils/JsonUtils", typeof(JsonUtils));
	}
}
