using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Services.Core.Misc;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Ads.Metadata
{
	// Token: 0x020002E1 RID: 737
	[Register("com/unity3d/ads/metadata/MetaData", DoNotGenerateAcw = true)]
	public class MetaData : JsonStorage
	{
		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x060028E3 RID: 10467 RVA: 0x00069D30 File Offset: 0x00067F30
		// (set) Token: 0x060028E4 RID: 10468 RVA: 0x00069D60 File Offset: 0x00067F60
		[Register("_context")]
		protected Context Context
		{
			get
			{
				return Java.Lang.Object.GetObject<Context>(MetaData._members.InstanceFields.GetObjectValue("_context.Landroid/content/Context;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					MetaData._members.InstanceFields.SetValue("_context.Landroid/content/Context;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x060028E5 RID: 10469 RVA: 0x00069DAC File Offset: 0x00067FAC
		internal new static IntPtr class_ref
		{
			get
			{
				return MetaData._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x060028E6 RID: 10470 RVA: 0x00069DD0 File Offset: 0x00067FD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MetaData._members;
			}
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x00069DD8 File Offset: 0x00067FD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MetaData._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x060028E8 RID: 10472 RVA: 0x00069DFC File Offset: 0x00067FFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MetaData._members.ManagedPeerType;
			}
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x00020638 File Offset: 0x0001E838
		protected MetaData(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x00069E08 File Offset: 0x00068008
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MetaData(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(MetaData._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MetaData._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x00069EB8 File Offset: 0x000680B8
		private static Delegate GetGetCategoryHandler()
		{
			if (MetaData.cb_getCategory == null)
			{
				MetaData.cb_getCategory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MetaData.n_GetCategory));
			}
			return MetaData.cb_getCategory;
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x00069EDC File Offset: 0x000680DC
		private static IntPtr n_GetCategory(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MetaData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Category);
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x00069EF0 File Offset: 0x000680F0
		private static Delegate GetSetCategory_Ljava_lang_String_Handler()
		{
			if (MetaData.cb_setCategory_Ljava_lang_String_ == null)
			{
				MetaData.cb_setCategory_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MetaData.n_SetCategory_Ljava_lang_String_));
			}
			return MetaData.cb_setCategory_Ljava_lang_String_;
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x00069F14 File Offset: 0x00068114
		private static void n_SetCategory_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_category)
		{
			MetaData @object = Java.Lang.Object.GetObject<MetaData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_category, JniHandleOwnership.DoNotTransfer);
			@object.Category = @string;
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x00069F38 File Offset: 0x00068138
		// (set) Token: 0x060028F0 RID: 10480 RVA: 0x00069F6C File Offset: 0x0006816C
		public unsafe virtual string Category
		{
			[Register("getCategory", "()Ljava/lang/String;", "GetGetCategoryHandler")]
			get
			{
				return JNIEnv.GetString(MetaData._members.InstanceMethods.InvokeVirtualObjectMethod("getCategory.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setCategory", "(Ljava/lang/String;)V", "GetSetCategory_Ljava_lang_String_Handler")]
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					MetaData._members.InstanceMethods.InvokeVirtualVoidMethod("setCategory.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x00069FC8 File Offset: 0x000681C8
		private static Delegate GetCommitHandler()
		{
			if (MetaData.cb_commit == null)
			{
				MetaData.cb_commit = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MetaData.n_Commit));
			}
			return MetaData.cb_commit;
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x00069FEC File Offset: 0x000681EC
		private static void n_Commit(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MetaData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Commit();
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x00069FFB File Offset: 0x000681FB
		[Register("commit", "()V", "GetCommitHandler")]
		public virtual void Commit()
		{
			MetaData._members.InstanceMethods.InvokeVirtualVoidMethod("commit.()V", this, null);
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x0006A014 File Offset: 0x00068214
		private static Delegate GetSetRaw_Ljava_lang_String_Ljava_lang_Object_Handler()
		{
			if (MetaData.cb_setRaw_Ljava_lang_String_Ljava_lang_Object_ == null)
			{
				MetaData.cb_setRaw_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(MetaData.n_SetRaw_Ljava_lang_String_Ljava_lang_Object_));
			}
			return MetaData.cb_setRaw_Ljava_lang_String_Ljava_lang_Object_;
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x0006A038 File Offset: 0x00068238
		private static bool n_SetRaw_Ljava_lang_String_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			MetaData @object = Java.Lang.Object.GetObject<MetaData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.SetRaw(@string, object2);
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x0006A064 File Offset: 0x00068264
		[Register("setRaw", "(Ljava/lang/String;Ljava/lang/Object;)Z", "GetSetRaw_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected unsafe virtual bool SetRaw(string key, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				result = MetaData._members.InstanceMethods.InvokeVirtualBooleanMethod("setRaw.(Ljava/lang/String;Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
			return result;
		}

		// Token: 0x0400085B RID: 2139
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/ads/metadata/MetaData", typeof(MetaData));

		// Token: 0x0400085C RID: 2140
		private static Delegate cb_getCategory;

		// Token: 0x0400085D RID: 2141
		private static Delegate cb_setCategory_Ljava_lang_String_;

		// Token: 0x0400085E RID: 2142
		private static Delegate cb_commit;

		// Token: 0x0400085F RID: 2143
		private static Delegate cb_setRaw_Ljava_lang_String_Ljava_lang_Object_;
	}
}
