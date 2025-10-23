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
	// Token: 0x02000139 RID: 313
	[Register("com/applovin/impl/sdk/utils/CollectionUtils", DoNotGenerateAcw = true)]
	public class CollectionUtils : Java.Lang.Object
	{
		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x000286AC File Offset: 0x000268AC
		internal static IntPtr class_ref
		{
			get
			{
				return CollectionUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x000286D0 File Offset: 0x000268D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CollectionUtils._members;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x000286D8 File Offset: 0x000268D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CollectionUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x000286FC File Offset: 0x000268FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CollectionUtils._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x000021F0 File Offset: 0x000003F0
		protected CollectionUtils(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00028708 File Offset: 0x00026908
		[Register(".ctor", "()V", "")]
		public CollectionUtils() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(CollectionUtils._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			CollectionUtils._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00028778 File Offset: 0x00026978
		[Register("explode", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public unsafe static IList<string> Explode(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IList<string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<string>.FromJniHandle(CollectionUtils._members.StaticMethods.InvokeObjectMethod("explode.(Ljava/lang/String;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x000287E4 File Offset: 0x000269E4
		[Register("explode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "")]
		public unsafe static IList<string> Explode(string p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			IList<string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaList<string>.FromJniHandle(CollectionUtils._members.StaticMethods.InvokeObjectMethod("explode.(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return result;
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00028870 File Offset: 0x00026A70
		[Register("getBoolean", "(Ljava/util/Map;Ljava/lang/String;)Z", "")]
		public unsafe static bool GetBoolean(IDictionary<string, Java.Lang.Object> p0, string p1)
		{
			IntPtr intPtr = JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = CollectionUtils._members.StaticMethods.InvokeBooleanMethod("getBoolean.(Ljava/util/Map;Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x000288F4 File Offset: 0x00026AF4
		[Register("getBoolean", "(Ljava/util/Map;Ljava/lang/String;Z)Z", "")]
		public unsafe static bool GetBoolean(IDictionary<string, Java.Lang.Object> p0, string p1, bool p2)
		{
			IntPtr intPtr = JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(p2);
				result = CollectionUtils._members.StaticMethods.InvokeBooleanMethod("getBoolean.(Ljava/util/Map;Ljava/lang/String;Z)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0002898C File Offset: 0x00026B8C
		[Register("implode", "(Ljava/util/Collection;I)Ljava/lang/String;", "")]
		public unsafe static string Implode(ICollection<string> p0, int p1)
		{
			IntPtr intPtr = JavaCollection<string>.ToLocalJniHandle(p0);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				@string = JNIEnv.GetString(CollectionUtils._members.StaticMethods.InvokeObjectMethod("implode.(Ljava/util/Collection;I)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return @string;
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x00028A10 File Offset: 0x00026C10
		[Register("implode", "(Ljava/util/Collection;Ljava/lang/String;I)Ljava/lang/String;", "")]
		public unsafe static string Implode(ICollection<string> p0, string p1, int p2)
		{
			IntPtr intPtr = JavaCollection<string>.ToLocalJniHandle(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(p2);
				@string = JNIEnv.GetString(CollectionUtils._members.StaticMethods.InvokeObjectMethod("implode.(Ljava/util/Collection;Ljava/lang/String;I)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p0);
			}
			return @string;
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00028AB8 File Offset: 0x00026CB8
		[Register("map", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IDictionary Map(Java.Lang.Object p0, Java.Lang.Object p1)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(p1);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaDictionary.FromJniHandle(CollectionUtils._members.StaticMethods.InvokeObjectMethod("map.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return result;
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00028B50 File Offset: 0x00026D50
		[Register("removeTrimmedEmptyStrings", "(Ljava/util/List;)Ljava/util/List;", "")]
		public unsafe static IList<string> RemoveTrimmedEmptyStrings(IList<string> p0)
		{
			IntPtr intPtr = JavaList<string>.ToLocalJniHandle(p0);
			IList<string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<string>.FromJniHandle(CollectionUtils._members.StaticMethods.InvokeObjectMethod("removeTrimmedEmptyStrings.(Ljava/util/List;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00028BC0 File Offset: 0x00026DC0
		[Register("synchronizedList", "()Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public static IList SynchronizedList()
		{
			return JavaList.FromJniHandle(CollectionUtils._members.StaticMethods.InvokeObjectMethod("synchronizedList.()Ljava/util/List;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00028BF4 File Offset: 0x00026DF4
		[Register("synchronizedList", "(I)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IList SynchronizedList(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			return JavaList.FromJniHandle(CollectionUtils._members.StaticMethods.InvokeObjectMethod("synchronizedList.(I)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00028C3C File Offset: 0x00026E3C
		[Register("toBundle", "(Ljava/util/Map;)Landroid/os/Bundle;", "")]
		public unsafe static Bundle ToBundle(IDictionary<string, object> p0)
		{
			IntPtr intPtr = JavaDictionary<string, object>.ToLocalJniHandle(p0);
			Bundle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Bundle>(CollectionUtils._members.StaticMethods.InvokeObjectMethod("toBundle.(Ljava/util/Map;)Landroid/os/Bundle;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00028CAC File Offset: 0x00026EAC
		[Register("toJSONArray", "(Ljava/util/List;)Lorg/json/JSONArray;", "")]
		public unsafe static JSONArray ToJSONArray(IList<string> p0)
		{
			IntPtr intPtr = JavaList<string>.ToLocalJniHandle(p0);
			JSONArray @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<JSONArray>(CollectionUtils._members.StaticMethods.InvokeObjectMethod("toJSONArray.(Ljava/util/List;)Lorg/json/JSONArray;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00028D1C File Offset: 0x00026F1C
		[Register("toJson", "(Ljava/util/Map;)Lorg/json/JSONObject;", "")]
		public unsafe static JSONObject ToJson(IDictionary<string, object> p0)
		{
			IntPtr intPtr = JavaDictionary<string, object>.ToLocalJniHandle(p0);
			JSONObject @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<JSONObject>(CollectionUtils._members.StaticMethods.InvokeObjectMethod("toJson.(Ljava/util/Map;)Lorg/json/JSONObject;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00028D8C File Offset: 0x00026F8C
		[Register("toJsonString", "(Ljava/util/Map;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string ToJsonString(IDictionary<string, Java.Lang.Object> p0, string p1)
		{
			IntPtr intPtr = JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(CollectionUtils._members.StaticMethods.InvokeObjectMethod("toJsonString.(Ljava/util/Map;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p0);
			}
			return @string;
		}

		// Token: 0x040004ED RID: 1261
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/utils/CollectionUtils", typeof(CollectionUtils));
	}
}
