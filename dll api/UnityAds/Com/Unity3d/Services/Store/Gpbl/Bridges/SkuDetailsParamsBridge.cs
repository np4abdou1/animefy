using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Reflection;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges
{
	// Token: 0x02000059 RID: 89
	[Register("com/unity3d/services/store/gpbl/bridges/SkuDetailsParamsBridge", DoNotGenerateAcw = true)]
	public class SkuDetailsParamsBridge : GenericBridge
	{
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00006544 File Offset: 0x00004744
		internal new static IntPtr class_ref
		{
			get
			{
				return SkuDetailsParamsBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00006568 File Offset: 0x00004768
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SkuDetailsParamsBridge._members;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00006570 File Offset: 0x00004770
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SkuDetailsParamsBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00006594 File Offset: 0x00004794
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SkuDetailsParamsBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000058C0 File Offset: 0x00003AC0
		protected SkuDetailsParamsBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000065A0 File Offset: 0x000047A0
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe SkuDetailsParamsBridge(Java.Lang.Object skuDetailsParamsInternalInstance) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((skuDetailsParamsInternalInstance == null) ? IntPtr.Zero : skuDetailsParamsInternalInstance.Handle);
				base.SetHandle(SkuDetailsParamsBridge._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SkuDetailsParamsBridge._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(skuDetailsParamsInternalInstance);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00006650 File Offset: 0x00004850
		public static Class ClassForBridge
		{
			[Register("getClassForBridge", "()Ljava/lang/Class;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(SkuDetailsParamsBridge._members.StaticMethods.InvokeObjectMethod("getClassForBridge.()Ljava/lang/Class;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00006681 File Offset: 0x00004881
		private static Delegate GetGetClassNameHandler()
		{
			if (SkuDetailsParamsBridge.cb_getClassName == null)
			{
				SkuDetailsParamsBridge.cb_getClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SkuDetailsParamsBridge.n_GetClassName));
			}
			return SkuDetailsParamsBridge.cb_getClassName;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000066A5 File Offset: 0x000048A5
		private static IntPtr n_GetClassName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<SkuDetailsParamsBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassName);
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000254 RID: 596 RVA: 0x000066BC File Offset: 0x000048BC
		protected override string ClassName
		{
			[Register("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get
			{
				return JNIEnv.GetString(SkuDetailsParamsBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000066EE File Offset: 0x000048EE
		private static Delegate GetGetInternalInstanceHandler()
		{
			if (SkuDetailsParamsBridge.cb_getInternalInstance == null)
			{
				SkuDetailsParamsBridge.cb_getInternalInstance = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SkuDetailsParamsBridge.n_GetInternalInstance));
			}
			return SkuDetailsParamsBridge.cb_getInternalInstance;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00006712 File Offset: 0x00004912
		private static IntPtr n_GetInternalInstance(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SkuDetailsParamsBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InternalInstance);
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00006728 File Offset: 0x00004928
		public virtual Java.Lang.Object InternalInstance
		{
			[Register("getInternalInstance", "()Ljava/lang/Object;", "GetGetInternalInstanceHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(SkuDetailsParamsBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getInternalInstance.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000675C File Offset: 0x0000495C
		[Register("callNonVoidStaticMethod", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public unsafe static Java.Lang.Object CallNonVoidStaticMethod(string methodName, params Java.Lang.Object[] parameters)
		{
			IntPtr intPtr = JNIEnv.NewString(methodName);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(parameters);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SkuDetailsParamsBridge._members.StaticMethods.InvokeObjectMethod("callNonVoidStaticMethod.(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (parameters != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, parameters);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(parameters);
			}
			return @object;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000067F8 File Offset: 0x000049F8
		[Register("newBuilder", "()Lcom/unity3d/services/store/gpbl/bridges/SkuDetailsParamsBridge$BuilderBridge;", "")]
		public static SkuDetailsParamsBridge.BuilderBridge NewBuilder()
		{
			return Java.Lang.Object.GetObject<SkuDetailsParamsBridge.BuilderBridge>(SkuDetailsParamsBridge._members.StaticMethods.InvokeObjectMethod("newBuilder.()Lcom/unity3d/services/store/gpbl/bridges/SkuDetailsParamsBridge$BuilderBridge;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400005B RID: 91
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/SkuDetailsParamsBridge", typeof(SkuDetailsParamsBridge));

		// Token: 0x0400005C RID: 92
		private static Delegate cb_getClassName;

		// Token: 0x0400005D RID: 93
		private static Delegate cb_getInternalInstance;

		// Token: 0x0200005A RID: 90
		[Register("com/unity3d/services/store/gpbl/bridges/SkuDetailsParamsBridge$BuilderBridge", DoNotGenerateAcw = true)]
		public class BuilderBridge : GenericBridge
		{
			// Token: 0x170000BF RID: 191
			// (get) Token: 0x0600025B RID: 603 RVA: 0x00006844 File Offset: 0x00004A44
			internal new static IntPtr class_ref
			{
				get
				{
					return SkuDetailsParamsBridge.BuilderBridge._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x0600025C RID: 604 RVA: 0x00006868 File Offset: 0x00004A68
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return SkuDetailsParamsBridge.BuilderBridge._members;
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x0600025D RID: 605 RVA: 0x00006870 File Offset: 0x00004A70
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return SkuDetailsParamsBridge.BuilderBridge._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x0600025E RID: 606 RVA: 0x00006894 File Offset: 0x00004A94
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return SkuDetailsParamsBridge.BuilderBridge._members.ManagedPeerType;
				}
			}

			// Token: 0x0600025F RID: 607 RVA: 0x000058C0 File Offset: 0x00003AC0
			protected BuilderBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000260 RID: 608 RVA: 0x000068A0 File Offset: 0x00004AA0
			[Register(".ctor", "(Ljava/lang/Object;)V", "")]
			public unsafe BuilderBridge(Java.Lang.Object skuDetailsParamsBuilderInternalInstance) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((skuDetailsParamsBuilderInternalInstance == null) ? IntPtr.Zero : skuDetailsParamsBuilderInternalInstance.Handle);
					base.SetHandle(SkuDetailsParamsBridge.BuilderBridge._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					SkuDetailsParamsBridge.BuilderBridge._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(skuDetailsParamsBuilderInternalInstance);
				}
			}

			// Token: 0x06000261 RID: 609 RVA: 0x00006950 File Offset: 0x00004B50
			private static Delegate GetGetClassNameHandler()
			{
				if (SkuDetailsParamsBridge.BuilderBridge.cb_getClassName == null)
				{
					SkuDetailsParamsBridge.BuilderBridge.cb_getClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SkuDetailsParamsBridge.BuilderBridge.n_GetClassName));
				}
				return SkuDetailsParamsBridge.BuilderBridge.cb_getClassName;
			}

			// Token: 0x06000262 RID: 610 RVA: 0x00006974 File Offset: 0x00004B74
			private static IntPtr n_GetClassName(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<SkuDetailsParamsBridge.BuilderBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassName);
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x06000263 RID: 611 RVA: 0x00006988 File Offset: 0x00004B88
			protected override string ClassName
			{
				[Register("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
				get
				{
					return JNIEnv.GetString(SkuDetailsParamsBridge.BuilderBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000264 RID: 612 RVA: 0x000069BA File Offset: 0x00004BBA
			private static Delegate GetBuildHandler()
			{
				if (SkuDetailsParamsBridge.BuilderBridge.cb_build == null)
				{
					SkuDetailsParamsBridge.BuilderBridge.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SkuDetailsParamsBridge.BuilderBridge.n_Build));
				}
				return SkuDetailsParamsBridge.BuilderBridge.cb_build;
			}

			// Token: 0x06000265 RID: 613 RVA: 0x000069DE File Offset: 0x00004BDE
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SkuDetailsParamsBridge.BuilderBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x06000266 RID: 614 RVA: 0x000069F4 File Offset: 0x00004BF4
			[Register("build", "()Lcom/unity3d/services/store/gpbl/bridges/SkuDetailsParamsBridge;", "GetBuildHandler")]
			public virtual SkuDetailsParamsBridge Build()
			{
				return Java.Lang.Object.GetObject<SkuDetailsParamsBridge>(SkuDetailsParamsBridge.BuilderBridge._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Lcom/unity3d/services/store/gpbl/bridges/SkuDetailsParamsBridge;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000267 RID: 615 RVA: 0x00006A26 File Offset: 0x00004C26
			private static Delegate GetSetSkuList_Ljava_util_List_Handler()
			{
				if (SkuDetailsParamsBridge.BuilderBridge.cb_setSkuList_Ljava_util_List_ == null)
				{
					SkuDetailsParamsBridge.BuilderBridge.cb_setSkuList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(SkuDetailsParamsBridge.BuilderBridge.n_SetSkuList_Ljava_util_List_));
				}
				return SkuDetailsParamsBridge.BuilderBridge.cb_setSkuList_Ljava_util_List_;
			}

			// Token: 0x06000268 RID: 616 RVA: 0x00006A4C File Offset: 0x00004C4C
			private static IntPtr n_SetSkuList_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_skusList)
			{
				SkuDetailsParamsBridge.BuilderBridge @object = Java.Lang.Object.GetObject<SkuDetailsParamsBridge.BuilderBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IList<string> skuList = JavaList<string>.FromJniHandle(native_skusList, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetSkuList(skuList));
			}

			// Token: 0x06000269 RID: 617 RVA: 0x00006A74 File Offset: 0x00004C74
			[Register("setSkuList", "(Ljava/util/List;)Lcom/unity3d/services/store/gpbl/bridges/SkuDetailsParamsBridge$BuilderBridge;", "GetSetSkuList_Ljava_util_List_Handler")]
			public unsafe virtual SkuDetailsParamsBridge.BuilderBridge SetSkuList(IList<string> skusList)
			{
				IntPtr intPtr = JavaList<string>.ToLocalJniHandle(skusList);
				SkuDetailsParamsBridge.BuilderBridge @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<SkuDetailsParamsBridge.BuilderBridge>(SkuDetailsParamsBridge.BuilderBridge._members.InstanceMethods.InvokeVirtualObjectMethod("setSkuList.(Ljava/util/List;)Lcom/unity3d/services/store/gpbl/bridges/SkuDetailsParamsBridge$BuilderBridge;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(skusList);
				}
				return @object;
			}

			// Token: 0x0600026A RID: 618 RVA: 0x00006AE8 File Offset: 0x00004CE8
			private static Delegate GetSetType_Ljava_lang_String_Handler()
			{
				if (SkuDetailsParamsBridge.BuilderBridge.cb_setType_Ljava_lang_String_ == null)
				{
					SkuDetailsParamsBridge.BuilderBridge.cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(SkuDetailsParamsBridge.BuilderBridge.n_SetType_Ljava_lang_String_));
				}
				return SkuDetailsParamsBridge.BuilderBridge.cb_setType_Ljava_lang_String_;
			}

			// Token: 0x0600026B RID: 619 RVA: 0x00006B0C File Offset: 0x00004D0C
			private static IntPtr n_SetType_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_skuType)
			{
				SkuDetailsParamsBridge.BuilderBridge @object = Java.Lang.Object.GetObject<SkuDetailsParamsBridge.BuilderBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_skuType, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetType(@string));
			}

			// Token: 0x0600026C RID: 620 RVA: 0x00006B34 File Offset: 0x00004D34
			[Register("setType", "(Ljava/lang/String;)Lcom/unity3d/services/store/gpbl/bridges/SkuDetailsParamsBridge$BuilderBridge;", "GetSetType_Ljava_lang_String_Handler")]
			public unsafe virtual SkuDetailsParamsBridge.BuilderBridge SetType(string skuType)
			{
				IntPtr intPtr = JNIEnv.NewString(skuType);
				SkuDetailsParamsBridge.BuilderBridge @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<SkuDetailsParamsBridge.BuilderBridge>(SkuDetailsParamsBridge.BuilderBridge._members.InstanceMethods.InvokeVirtualObjectMethod("setType.(Ljava/lang/String;)Lcom/unity3d/services/store/gpbl/bridges/SkuDetailsParamsBridge$BuilderBridge;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0400005E RID: 94
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/SkuDetailsParamsBridge$BuilderBridge", typeof(SkuDetailsParamsBridge.BuilderBridge));

			// Token: 0x0400005F RID: 95
			private static Delegate cb_getClassName;

			// Token: 0x04000060 RID: 96
			private static Delegate cb_build;

			// Token: 0x04000061 RID: 97
			private static Delegate cb_setSkuList_Ljava_util_List_;

			// Token: 0x04000062 RID: 98
			private static Delegate cb_setType_Ljava_lang_String_;
		}
	}
}
