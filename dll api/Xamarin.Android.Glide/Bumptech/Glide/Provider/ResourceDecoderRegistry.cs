using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Provider
{
	// Token: 0x02000063 RID: 99
	[Register("com/bumptech/glide/provider/ResourceDecoderRegistry", DoNotGenerateAcw = true)]
	public class ResourceDecoderRegistry : Java.Lang.Object
	{
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0000F084 File Offset: 0x0000D284
		internal static IntPtr class_ref
		{
			get
			{
				return ResourceDecoderRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ResourceDecoderRegistry._members;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0000F0B0 File Offset: 0x0000D2B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ResourceDecoderRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0000F0D4 File Offset: 0x0000D2D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ResourceDecoderRegistry._members.ManagedPeerType;
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0000F0E0 File Offset: 0x0000D2E0
		protected ResourceDecoderRegistry(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0000F0EC File Offset: 0x0000D2EC
		[Register(".ctor", "()V", "")]
		public ResourceDecoderRegistry() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ResourceDecoderRegistry._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ResourceDecoderRegistry._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000F15A File Offset: 0x0000D35A
		private static Delegate GetAppend_Ljava_lang_String_Lcom_bumptech_glide_load_ResourceDecoder_Ljava_lang_Class_Ljava_lang_Class_Handler()
		{
			if (ResourceDecoderRegistry.cb_append_Ljava_lang_String_Lcom_bumptech_glide_load_ResourceDecoder_Ljava_lang_Class_Ljava_lang_Class_ == null)
			{
				ResourceDecoderRegistry.cb_append_Ljava_lang_String_Lcom_bumptech_glide_load_ResourceDecoder_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(ResourceDecoderRegistry.n_Append_Ljava_lang_String_Lcom_bumptech_glide_load_ResourceDecoder_Ljava_lang_Class_Ljava_lang_Class_));
			}
			return ResourceDecoderRegistry.cb_append_Ljava_lang_String_Lcom_bumptech_glide_load_ResourceDecoder_Ljava_lang_Class_Ljava_lang_Class_;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0000F180 File Offset: 0x0000D380
		private static void n_Append_Ljava_lang_String_Lcom_bumptech_glide_load_ResourceDecoder_Ljava_lang_Class_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_bucket, IntPtr native_decoder, IntPtr native_dataClass, IntPtr native_resourceClass)
		{
			ResourceDecoderRegistry @object = Java.Lang.Object.GetObject<ResourceDecoderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_bucket, JniHandleOwnership.DoNotTransfer);
			IResourceDecoder object2 = Java.Lang.Object.GetObject<IResourceDecoder>(native_decoder, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			Class object4 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			@object.Append(@string, object2, object3, object4);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0000F1C0 File Offset: 0x0000D3C0
		[Register("append", "(Ljava/lang/String;Lcom/bumptech/glide/load/ResourceDecoder;Ljava/lang/Class;Ljava/lang/Class;)V", "GetAppend_Ljava_lang_String_Lcom_bumptech_glide_load_ResourceDecoder_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe virtual void Append(string bucket, IResourceDecoder decoder, Class dataClass, Class resourceClass)
		{
			IntPtr intPtr = JNIEnv.NewString(bucket);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((decoder == null) ? IntPtr.Zero : ((Java.Lang.Object)decoder).Handle);
				ptr[2] = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[3] = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ResourceDecoderRegistry._members.InstanceMethods.InvokeVirtualVoidMethod("append.(Ljava/lang/String;Lcom/bumptech/glide/load/ResourceDecoder;Ljava/lang/Class;Ljava/lang/Class;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(decoder);
				GC.KeepAlive(dataClass);
				GC.KeepAlive(resourceClass);
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0000F2A4 File Offset: 0x0000D4A4
		private static Delegate GetGetDecoders_Ljava_lang_Class_Ljava_lang_Class_Handler()
		{
			if (ResourceDecoderRegistry.cb_getDecoders_Ljava_lang_Class_Ljava_lang_Class_ == null)
			{
				ResourceDecoderRegistry.cb_getDecoders_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ResourceDecoderRegistry.n_GetDecoders_Ljava_lang_Class_Ljava_lang_Class_));
			}
			return ResourceDecoderRegistry.cb_getDecoders_Ljava_lang_Class_Ljava_lang_Class_;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0000F2C8 File Offset: 0x0000D4C8
		private static IntPtr n_GetDecoders_Ljava_lang_Class_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_dataClass, IntPtr native_resourceClass)
		{
			ResourceDecoderRegistry @object = Java.Lang.Object.GetObject<ResourceDecoderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			return JavaList.ToLocalJniHandle(@object.GetDecoders(object2, object3));
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0000F2FC File Offset: 0x0000D4FC
		[Register("getDecoders", "(Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/List;", "GetGetDecoders_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe virtual IList GetDecoders(Class dataClass, Class resourceClass)
		{
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[1] = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				result = JavaList.FromJniHandle(ResourceDecoderRegistry._members.InstanceMethods.InvokeVirtualObjectMethod("getDecoders.(Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(dataClass);
				GC.KeepAlive(resourceClass);
			}
			return result;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0000F398 File Offset: 0x0000D598
		private static Delegate GetGetResourceClasses_Ljava_lang_Class_Ljava_lang_Class_Handler()
		{
			if (ResourceDecoderRegistry.cb_getResourceClasses_Ljava_lang_Class_Ljava_lang_Class_ == null)
			{
				ResourceDecoderRegistry.cb_getResourceClasses_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ResourceDecoderRegistry.n_GetResourceClasses_Ljava_lang_Class_Ljava_lang_Class_));
			}
			return ResourceDecoderRegistry.cb_getResourceClasses_Ljava_lang_Class_Ljava_lang_Class_;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0000F3BC File Offset: 0x0000D5BC
		private static IntPtr n_GetResourceClasses_Ljava_lang_Class_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_dataClass, IntPtr native_resourceClass)
		{
			ResourceDecoderRegistry @object = Java.Lang.Object.GetObject<ResourceDecoderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			return JavaList<Class>.ToLocalJniHandle(@object.GetResourceClasses(object2, object3));
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		[Register("getResourceClasses", "(Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/List;", "GetGetResourceClasses_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe virtual IList<Class> GetResourceClasses(Class dataClass, Class resourceClass)
		{
			IList<Class> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[1] = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				result = JavaList<Class>.FromJniHandle(ResourceDecoderRegistry._members.InstanceMethods.InvokeVirtualObjectMethod("getResourceClasses.(Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(dataClass);
				GC.KeepAlive(resourceClass);
			}
			return result;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0000F48C File Offset: 0x0000D68C
		private static Delegate GetPrepend_Ljava_lang_String_Lcom_bumptech_glide_load_ResourceDecoder_Ljava_lang_Class_Ljava_lang_Class_Handler()
		{
			if (ResourceDecoderRegistry.cb_prepend_Ljava_lang_String_Lcom_bumptech_glide_load_ResourceDecoder_Ljava_lang_Class_Ljava_lang_Class_ == null)
			{
				ResourceDecoderRegistry.cb_prepend_Ljava_lang_String_Lcom_bumptech_glide_load_ResourceDecoder_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(ResourceDecoderRegistry.n_Prepend_Ljava_lang_String_Lcom_bumptech_glide_load_ResourceDecoder_Ljava_lang_Class_Ljava_lang_Class_));
			}
			return ResourceDecoderRegistry.cb_prepend_Ljava_lang_String_Lcom_bumptech_glide_load_ResourceDecoder_Ljava_lang_Class_Ljava_lang_Class_;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
		private static void n_Prepend_Ljava_lang_String_Lcom_bumptech_glide_load_ResourceDecoder_Ljava_lang_Class_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_bucket, IntPtr native_decoder, IntPtr native_dataClass, IntPtr native_resourceClass)
		{
			ResourceDecoderRegistry @object = Java.Lang.Object.GetObject<ResourceDecoderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_bucket, JniHandleOwnership.DoNotTransfer);
			IResourceDecoder object2 = Java.Lang.Object.GetObject<IResourceDecoder>(native_decoder, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			Class object4 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			@object.Prepend(@string, object2, object3, object4);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0000F4F0 File Offset: 0x0000D6F0
		[Register("prepend", "(Ljava/lang/String;Lcom/bumptech/glide/load/ResourceDecoder;Ljava/lang/Class;Ljava/lang/Class;)V", "GetPrepend_Ljava_lang_String_Lcom_bumptech_glide_load_ResourceDecoder_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe virtual void Prepend(string bucket, IResourceDecoder decoder, Class dataClass, Class resourceClass)
		{
			IntPtr intPtr = JNIEnv.NewString(bucket);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((decoder == null) ? IntPtr.Zero : ((Java.Lang.Object)decoder).Handle);
				ptr[2] = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[3] = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ResourceDecoderRegistry._members.InstanceMethods.InvokeVirtualVoidMethod("prepend.(Ljava/lang/String;Lcom/bumptech/glide/load/ResourceDecoder;Ljava/lang/Class;Ljava/lang/Class;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(decoder);
				GC.KeepAlive(dataClass);
				GC.KeepAlive(resourceClass);
			}
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0000F5D4 File Offset: 0x0000D7D4
		private static Delegate GetSetBucketPriorityList_Ljava_util_List_Handler()
		{
			if (ResourceDecoderRegistry.cb_setBucketPriorityList_Ljava_util_List_ == null)
			{
				ResourceDecoderRegistry.cb_setBucketPriorityList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ResourceDecoderRegistry.n_SetBucketPriorityList_Ljava_util_List_));
			}
			return ResourceDecoderRegistry.cb_setBucketPriorityList_Ljava_util_List_;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0000F5F8 File Offset: 0x0000D7F8
		private static void n_SetBucketPriorityList_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_buckets)
		{
			ResourceDecoderRegistry @object = Java.Lang.Object.GetObject<ResourceDecoderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<string> bucketPriorityList = JavaList<string>.FromJniHandle(native_buckets, JniHandleOwnership.DoNotTransfer);
			@object.SetBucketPriorityList(bucketPriorityList);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0000F61C File Offset: 0x0000D81C
		[Register("setBucketPriorityList", "(Ljava/util/List;)V", "GetSetBucketPriorityList_Ljava_util_List_Handler")]
		public unsafe virtual void SetBucketPriorityList(IList<string> buckets)
		{
			IntPtr intPtr = JavaList<string>.ToLocalJniHandle(buckets);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ResourceDecoderRegistry._members.InstanceMethods.InvokeVirtualVoidMethod("setBucketPriorityList.(Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(buckets);
			}
		}

		// Token: 0x040000EA RID: 234
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/provider/ResourceDecoderRegistry", typeof(ResourceDecoderRegistry));

		// Token: 0x040000EB RID: 235
		private static Delegate cb_append_Ljava_lang_String_Lcom_bumptech_glide_load_ResourceDecoder_Ljava_lang_Class_Ljava_lang_Class_;

		// Token: 0x040000EC RID: 236
		private static Delegate cb_getDecoders_Ljava_lang_Class_Ljava_lang_Class_;

		// Token: 0x040000ED RID: 237
		private static Delegate cb_getResourceClasses_Ljava_lang_Class_Ljava_lang_Class_;

		// Token: 0x040000EE RID: 238
		private static Delegate cb_prepend_Ljava_lang_String_Lcom_bumptech_glide_load_ResourceDecoder_Ljava_lang_Class_Ljava_lang_Class_;

		// Token: 0x040000EF RID: 239
		private static Delegate cb_setBucketPriorityList_Ljava_util_List_;
	}
}
