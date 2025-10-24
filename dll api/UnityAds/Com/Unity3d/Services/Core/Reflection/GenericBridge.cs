using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Reflection
{
	// Token: 0x020000C6 RID: 198
	[Register("com/unity3d/services/core/reflection/GenericBridge", DoNotGenerateAcw = true)]
	public abstract class GenericBridge : Java.Lang.Object
	{
		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x000160A4 File Offset: 0x000142A4
		internal static IntPtr class_ref
		{
			get
			{
				return GenericBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x000160C8 File Offset: 0x000142C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GenericBridge._members;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x000160D0 File Offset: 0x000142D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GenericBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x000160F4 File Offset: 0x000142F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GenericBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000021E8 File Offset: 0x000003E8
		protected GenericBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00016100 File Offset: 0x00014300
		[Register(".ctor", "(Ljava/util/Map;)V", "")]
		public unsafe GenericBridge(IDictionary<string, Class[]> functionAndParameters) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaDictionary<string, Class[]>.ToLocalJniHandle(functionAndParameters);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(GenericBridge._members.InstanceMethods.StartCreateInstance("(Ljava/util/Map;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GenericBridge._members.InstanceMethods.FinishCreateInstance("(Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(functionAndParameters);
			}
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x000161AC File Offset: 0x000143AC
		private static Delegate GetGetClassNameHandler()
		{
			if (GenericBridge.cb_getClassName == null)
			{
				GenericBridge.cb_getClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GenericBridge.n_GetClassName));
			}
			return GenericBridge.cb_getClassName;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x000161D0 File Offset: 0x000143D0
		private static IntPtr n_GetClassName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<GenericBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassName);
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060007B4 RID: 1972
		protected abstract string ClassName { [Register("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")] get; }

		// Token: 0x060007B5 RID: 1973 RVA: 0x000161E4 File Offset: 0x000143E4
		private static Delegate GetGetFunctionMapHandler()
		{
			if (GenericBridge.cb_getFunctionMap == null)
			{
				GenericBridge.cb_getFunctionMap = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GenericBridge.n_GetFunctionMap));
			}
			return GenericBridge.cb_getFunctionMap;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00016208 File Offset: 0x00014408
		private static IntPtr n_GetFunctionMap(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Class[]>.ToLocalJniHandle(Java.Lang.Object.GetObject<GenericBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FunctionMap);
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x0001621C File Offset: 0x0001441C
		public virtual IDictionary<string, Class[]> FunctionMap
		{
			[Register("getFunctionMap", "()Ljava/util/Map;", "GetGetFunctionMapHandler")]
			get
			{
				return JavaDictionary<string, Class[]>.FromJniHandle(GenericBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getFunctionMap.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0001624E File Offset: 0x0001444E
		private static Delegate GetCallNonVoidMethod_Ljava_lang_String_Ljava_lang_Object_arrayLjava_lang_Object_Handler()
		{
			if (GenericBridge.cb_callNonVoidMethod_Ljava_lang_String_Ljava_lang_Object_arrayLjava_lang_Object_ == null)
			{
				GenericBridge.cb_callNonVoidMethod_Ljava_lang_String_Ljava_lang_Object_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(GenericBridge.n_CallNonVoidMethod_Ljava_lang_String_Ljava_lang_Object_arrayLjava_lang_Object_));
			}
			return GenericBridge.cb_callNonVoidMethod_Ljava_lang_String_Ljava_lang_Object_arrayLjava_lang_Object_;
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00016274 File Offset: 0x00014474
		private static IntPtr n_CallNonVoidMethod_Ljava_lang_String_Ljava_lang_Object_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_methodName, IntPtr native_callingObj, IntPtr native_parameters)
		{
			GenericBridge @object = Java.Lang.Object.GetObject<GenericBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_methodName, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_callingObj, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_parameters, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.CallNonVoidMethod(@string, object2, array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_parameters);
			}
			return result;
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x000162CC File Offset: 0x000144CC
		[Register("callNonVoidMethod", "(Ljava/lang/String;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", "GetCallNonVoidMethod_Ljava_lang_String_Ljava_lang_Object_arrayLjava_lang_Object_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe virtual Java.Lang.Object CallNonVoidMethod(string methodName, Java.Lang.Object callingObj, params Java.Lang.Object[] parameters)
		{
			IntPtr intPtr = JNIEnv.NewString(methodName);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(parameters);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callingObj == null) ? IntPtr.Zero : callingObj.Handle);
				ptr[2] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(GenericBridge._members.InstanceMethods.InvokeVirtualObjectMethod("callNonVoidMethod.(Ljava/lang/String;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (parameters != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, parameters);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(callingObj);
				GC.KeepAlive(parameters);
			}
			return @object;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00016394 File Offset: 0x00014594
		private static Delegate GetCallVoidMethod_Ljava_lang_String_Ljava_lang_Object_arrayLjava_lang_Object_Handler()
		{
			if (GenericBridge.cb_callVoidMethod_Ljava_lang_String_Ljava_lang_Object_arrayLjava_lang_Object_ == null)
			{
				GenericBridge.cb_callVoidMethod_Ljava_lang_String_Ljava_lang_Object_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(GenericBridge.n_CallVoidMethod_Ljava_lang_String_Ljava_lang_Object_arrayLjava_lang_Object_));
			}
			return GenericBridge.cb_callVoidMethod_Ljava_lang_String_Ljava_lang_Object_arrayLjava_lang_Object_;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x000163B8 File Offset: 0x000145B8
		private static void n_CallVoidMethod_Ljava_lang_String_Ljava_lang_Object_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_methodName, IntPtr native_callingObj, IntPtr native_parameters)
		{
			GenericBridge @object = Java.Lang.Object.GetObject<GenericBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_methodName, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_callingObj, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_parameters, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			@object.CallVoidMethod(@string, object2, array);
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_parameters);
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00016408 File Offset: 0x00014608
		[Register("callVoidMethod", "(Ljava/lang/String;Ljava/lang/Object;[Ljava/lang/Object;)V", "GetCallVoidMethod_Ljava_lang_String_Ljava_lang_Object_arrayLjava_lang_Object_Handler")]
		public unsafe virtual void CallVoidMethod(string methodName, Java.Lang.Object callingObj, params Java.Lang.Object[] parameters)
		{
			IntPtr intPtr = JNIEnv.NewString(methodName);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(parameters);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callingObj == null) ? IntPtr.Zero : callingObj.Handle);
				ptr[2] = new JniArgumentValue(intPtr2);
				GenericBridge._members.InstanceMethods.InvokeVirtualVoidMethod("callVoidMethod.(Ljava/lang/String;Ljava/lang/Object;[Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (parameters != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, parameters);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(callingObj);
				GC.KeepAlive(parameters);
			}
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x000164C0 File Offset: 0x000146C0
		private static Delegate GetClassForNameHandler()
		{
			if (GenericBridge.cb_classForName == null)
			{
				GenericBridge.cb_classForName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GenericBridge.n_ClassForName));
			}
			return GenericBridge.cb_classForName;
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000164E4 File Offset: 0x000146E4
		private static IntPtr n_ClassForName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GenericBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassForName());
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000164F8 File Offset: 0x000146F8
		[Register("classForName", "()Ljava/lang/Class;", "GetClassForNameHandler")]
		public virtual Class ClassForName()
		{
			return Java.Lang.Object.GetObject<Class>(GenericBridge._members.InstanceMethods.InvokeVirtualObjectMethod("classForName.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0001652A File Offset: 0x0001472A
		private static Delegate GetExistsHandler()
		{
			if (GenericBridge.cb_exists == null)
			{
				GenericBridge.cb_exists = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(GenericBridge.n_Exists));
			}
			return GenericBridge.cb_exists;
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0001654E File Offset: 0x0001474E
		private static bool n_Exists(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GenericBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Exists();
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0001655D File Offset: 0x0001475D
		[Register("exists", "()Z", "GetExistsHandler")]
		public virtual bool Exists()
		{
			return GenericBridge._members.InstanceMethods.InvokeVirtualBooleanMethod("exists.()Z", this, null);
		}

		// Token: 0x040001D9 RID: 473
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/reflection/GenericBridge", typeof(GenericBridge));

		// Token: 0x040001DA RID: 474
		private static Delegate cb_getClassName;

		// Token: 0x040001DB RID: 475
		private static Delegate cb_getFunctionMap;

		// Token: 0x040001DC RID: 476
		private static Delegate cb_callNonVoidMethod_Ljava_lang_String_Ljava_lang_Object_arrayLjava_lang_Object_;

		// Token: 0x040001DD RID: 477
		private static Delegate cb_callVoidMethod_Ljava_lang_String_Ljava_lang_Object_arrayLjava_lang_Object_;

		// Token: 0x040001DE RID: 478
		private static Delegate cb_classForName;

		// Token: 0x040001DF RID: 479
		private static Delegate cb_exists;
	}
}
