using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Android.Runtime;
using Java.Interop.Tools.TypeNameMappings;
using Java.Lang;

namespace Java.Interop
{
	// Token: 0x0200043D RID: 1085
	public static class TypeManager
	{
		// Token: 0x06002F2D RID: 12077 RVA: 0x00083660 File Offset: 0x00081860
		internal static string GetClassName(IntPtr class_ptr)
		{
			IntPtr ptr = RuntimeNativeMethods.monodroid_TypeManager_get_java_class_name(class_ptr);
			string result = Marshal.PtrToStringAnsi(ptr);
			RuntimeNativeMethods.monodroid_free(ptr);
			return result;
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x00083680 File Offset: 0x00081880
		internal static string GetJniTypeName(Type type)
		{
			object accessLock = TypeManagerMapDictionaries.AccessLock;
			lock (accessLock)
			{
				string result;
				if (TypeManagerMapDictionaries.ManagedToJni.TryGetValue(type, out result))
				{
					return result;
				}
			}
			return null;
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x000836D0 File Offset: 0x000818D0
		public static string LookupTypeMapping(string[] mappings, string javaType)
		{
			int num = Array.BinarySearch<string>(mappings, javaType, TypeManager.JavaNameComparer);
			if (num < 0)
			{
				return null;
			}
			int num2 = mappings[num].IndexOf(':');
			return mappings[num].Substring(num2 + 1);
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x00083706 File Offset: 0x00081906
		internal static Delegate GetActivateHandler()
		{
			if (TypeManager.cb_activate == null)
			{
				_JniMarshal_PPLLLL_V dlg;
				if ((dlg = TypeManager.<>O.<0>__n_Activate) == null)
				{
					dlg = (TypeManager.<>O.<0>__n_Activate = new _JniMarshal_PPLLLL_V(TypeManager.n_Activate));
				}
				TypeManager.cb_activate = (_JniMarshal_PPLLLL_V)JNINativeWrapper.CreateDelegate(dlg);
			}
			return TypeManager.cb_activate;
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06002F31 RID: 12081 RVA: 0x0008373E File Offset: 0x0008193E
		internal static bool ActivationEnabled
		{
			get
			{
				return !JniEnvironment.WithinNewObjectScope;
			}
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x00083748 File Offset: 0x00081948
		private static Type[] GetParameterTypes(string signature)
		{
			if (string.IsNullOrEmpty(signature))
			{
				return Array.Empty<Type>();
			}
			string[] array = signature.Split(':', StringSplitOptions.None);
			Type[] array2 = new Type[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = Type.GetType(array[i], true);
			}
			return array2;
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x00083794 File Offset: 0x00081994
		private static void n_Activate(IntPtr jnienv, IntPtr jclass, IntPtr typename_ptr, IntPtr signature_ptr, IntPtr jobject, IntPtr parameters_ptr)
		{
			IJavaPeerable javaPeerable = Java.Lang.Object.PeekObject(jobject, null);
			IJavaObjectEx javaObjectEx = javaPeerable as IJavaObjectEx;
			if (javaObjectEx != null && !javaObjectEx.NeedsActivation && !javaObjectEx.IsProxy)
			{
				return;
			}
			if (!TypeManager.ActivationEnabled)
			{
				if (Logger.LogGlobalRef)
				{
					Logger.Log(LogLevel.Info, "monodroid-gref", string.Format("warning: Skipping managed constructor invocation for handle 0x{0} (key_handle 0x{1}). Please use JNIEnv.StartCreateInstance() + JNIEnv.FinishCreateInstance() instead of JNIEnv.NewObject() and/or JNIEnv.CreateInstance().", jobject.ToString("x"), JNIEnv.IdentityHash(jobject).ToString("x")));
				}
				return;
			}
			Type type = Type.GetType(JNIEnv.GetString(typename_ptr, JniHandleOwnership.DoNotTransfer), true);
			if (type.IsGenericTypeDefinition)
			{
				throw new NotSupportedException("Constructing instances of generic types from Java is not supported, as the type parameters cannot be determined.", TypeManager.CreateJavaLocationException());
			}
			Type[] parameterTypes = TypeManager.GetParameterTypes(JNIEnv.GetString(signature_ptr, JniHandleOwnership.DoNotTransfer));
			object[] objectArray = JNIEnv.GetObjectArray(parameters_ptr, parameterTypes);
			ConstructorInfo constructor = type.GetConstructor(parameterTypes);
			if (constructor == null)
			{
				throw TypeManager.CreateMissingConstructorException(type, parameterTypes);
			}
			if (javaPeerable != null)
			{
				constructor.Invoke(javaPeerable, objectArray);
				return;
			}
			TypeManager.Activate(jobject, constructor, objectArray);
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x0008387C File Offset: 0x00081A7C
		internal static void Activate(IntPtr jobject, ConstructorInfo cinfo, object[] parms)
		{
			try
			{
				object uninitializedObject = RuntimeHelpers.GetUninitializedObject(cinfo.DeclaringType);
				Java.Lang.Object @object = uninitializedObject as Java.Lang.Object;
				if (@object != null)
				{
					@object.handle = jobject;
				}
				else
				{
					Throwable throwable = uninitializedObject as Throwable;
					if (throwable == null)
					{
						throw new InvalidOperationException(string.Format("Unsupported type: '{0}'", uninitializedObject));
					}
					throwable.handle = jobject;
				}
				cinfo.Invoke(uninitializedObject, parms);
			}
			catch (System.Exception innerException)
			{
				string text = string.Format("Could not activate JNI Handle 0x{0} (key_handle 0x{1}) of Java type '{2}' as managed type '{3}'.", new object[]
				{
					jobject.ToString("x"),
					JNIEnv.IdentityHash(jobject).ToString("x"),
					JNIEnv.GetClassNameFromInstance(jobject),
					cinfo.DeclaringType.FullName
				});
				Logger.Log(LogLevel.Warn, "monodroid", text);
				Logger.Log(LogLevel.Warn, "monodroid", TypeManager.CreateJavaLocationException().ToString());
				throw new NotSupportedException(text, innerException);
			}
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x00083964 File Offset: 0x00081B64
		private static System.Exception CreateMissingConstructorException(Type type, Type[] ptypes)
		{
			System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
			stringBuilder.Append("Unable to find ");
			if (ptypes.Length == 0)
			{
				stringBuilder.Append("the default constructor");
			}
			else
			{
				stringBuilder.Append("a constructor with signature (").Append(ptypes[0].FullName);
				for (int i = 1; i < ptypes.Length; i++)
				{
					stringBuilder.Append(", ").Append(ptypes[i].FullName);
				}
				stringBuilder.Append(")");
			}
			stringBuilder.Append(" on type ").Append(type.FullName).Append(".  Please provide the missing constructor.");
			return new NotSupportedException(stringBuilder.ToString(), TypeManager.CreateJavaLocationException());
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x00083A14 File Offset: 0x00081C14
		private static System.Exception CreateJavaLocationException()
		{
			System.Exception result;
			using (Error error = new Error("Java callstack:"))
			{
				result = new JavaLocationException(error.ToString());
			}
			return result;
		}

		// Token: 0x06002F37 RID: 12087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Type monodroid_typemap_java_to_managed(string java_type_name);

		// Token: 0x06002F38 RID: 12088 RVA: 0x00083A58 File Offset: 0x00081C58
		internal static Type GetJavaToManagedType(string class_name)
		{
			Type type = TypeManager.monodroid_typemap_java_to_managed(class_name);
			if (type != null)
			{
				return type;
			}
			if (!JNIEnvInit.IsRunningOnDesktop)
			{
				if (JNIEnvInit.LogAssemblyCategory)
				{
					JNIEnv.LogTypemapTrace(new StackTrace(true));
				}
				return null;
			}
			if (AndroidEnvironment.VSAndroidDesignerIsEnabled)
			{
				return TypeManager.TypeRegistrationFallback(class_name);
			}
			return null;
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x00083AA4 File Offset: 0x00081CA4
		internal static Type TypeRegistrationFallback(string class_name)
		{
			__TypeRegistrations.RegisterPackages();
			int num = class_name.LastIndexOf('/');
			string key = (num >= 0) ? class_name.Substring(0, num) : "";
			List<Converter<string, Type>> list;
			Type type;
			if (TypeManager.packageLookup.TryGetValue(key, out list))
			{
				foreach (Converter<string, Type> converter in list)
				{
					type = converter(class_name);
					if (!(type == null))
					{
						return type;
					}
				}
			}
			if ((type = Type.GetType(JavaNativeTypeManager.ToCliType(class_name))) != null)
			{
				return type;
			}
			return null;
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x00083B50 File Offset: 0x00081D50
		internal static IJavaPeerable CreateInstance(IntPtr handle, JniHandleOwnership transfer)
		{
			return TypeManager.CreateInstance(handle, transfer, null);
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x00083B5C File Offset: 0x00081D5C
		internal static IJavaPeerable CreateInstance(IntPtr handle, JniHandleOwnership transfer, Type targetType)
		{
			Type type = null;
			IntPtr intPtr = JNIEnv.GetObjectClass(handle);
			string className = TypeManager.GetClassName(intPtr);
			object accessLock = TypeManagerMapDictionaries.AccessLock;
			lock (accessLock)
			{
				while (intPtr != IntPtr.Zero && !TypeManagerMapDictionaries.JniToManaged.TryGetValue(className, out type))
				{
					type = TypeManager.GetJavaToManagedType(className);
					if (type != null)
					{
						TypeManagerMapDictionaries.JniToManaged.Add(className, type);
						break;
					}
					IntPtr superclass = JNIEnv.GetSuperclass(intPtr);
					JNIEnv.DeleteLocalRef(intPtr);
					intPtr = superclass;
					className = TypeManager.GetClassName(intPtr);
				}
			}
			JNIEnv.DeleteLocalRef(intPtr);
			if (type == null)
			{
				JNIEnv.DeleteRef(handle, transfer);
				throw new NotSupportedException(string.Format("Internal error finding wrapper class for '{0}'. (Where is the Java.Lang.Object wrapper?!)", JNIEnv.GetClassNameFromInstance(handle)), TypeManager.CreateJavaLocationException());
			}
			if (targetType != null && !targetType.IsAssignableFrom(type))
			{
				type = targetType;
			}
			if (type.IsInterface || type.IsAbstract)
			{
				Type invokerType = JavaObjectExtensions.GetInvokerType(type);
				if (invokerType == null)
				{
					throw new NotSupportedException("Unable to find Invoker for type '" + type.FullName + "'. Was it linked away?", TypeManager.CreateJavaLocationException());
				}
				type = invokerType;
			}
			IJavaPeerable javaPeerable = null;
			try
			{
				javaPeerable = (IJavaPeerable)TypeManager.CreateProxy(type, handle, transfer);
				if (Runtime.IsGCUserPeer(javaPeerable.PeerReference.Handle))
				{
					javaPeerable.SetJniManagedPeerState(JniManagedPeerStates.Replaceable);
				}
			}
			catch (MissingMethodException innerException)
			{
				IntPtr intPtr2 = JNIEnv.IdentityHash(handle);
				JNIEnv.DeleteRef(handle, transfer);
				throw new NotSupportedException(string.Format("Unable to activate instance of type {0} from native handle 0x{1} (key_handle 0x{2}).", type, handle.ToString("x"), intPtr2.ToString("x")), innerException);
			}
			return javaPeerable;
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x00083CFC File Offset: 0x00081EFC
		internal static object CreateProxy(Type type, IntPtr handle, JniHandleOwnership transfer)
		{
			BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
			ConstructorInfo constructor = type.GetConstructor(bindingAttr, null, TypeManager.XAConstructorSignature, null);
			if (constructor != null)
			{
				return constructor.Invoke(new object[]
				{
					handle,
					transfer
				});
			}
			constructor = type.GetConstructor(bindingAttr, null, TypeManager.JIConstructorSignature, null);
			if (constructor != null)
			{
				JniObjectReference jniObjectReference = new JniObjectReference(handle, JniObjectReferenceType.Invalid);
				JniObjectReferenceOptions jniObjectReferenceOptions = JniObjectReferenceOptions.Copy;
				IJavaPeerable javaPeerable = (IJavaPeerable)constructor.Invoke(new object[]
				{
					jniObjectReference,
					jniObjectReferenceOptions
				});
				JNIEnv.DeleteRef(handle, transfer);
				javaPeerable.SetJniManagedPeerState(javaPeerable.JniManagedPeerState | JniManagedPeerStates.Replaceable);
				return javaPeerable;
			}
			throw new MissingMethodException("No constructor found for " + type.FullName + "::.ctor(System.IntPtr, Android.Runtime.JniHandleOwnership)", TypeManager.CreateJavaLocationException());
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x00083DC0 File Offset: 0x00081FC0
		public static void RegisterType(string java_class, Type t)
		{
			string jniName = JNIEnv.GetJniName(t);
			object accessLock = TypeManagerMapDictionaries.AccessLock;
			lock (accessLock)
			{
				Type type;
				if (!TypeManagerMapDictionaries.JniToManaged.TryGetValue(java_class, out type))
				{
					TypeManagerMapDictionaries.JniToManaged.Add(java_class, t);
					if (string.Compare(jniName, java_class, StringComparison.OrdinalIgnoreCase) != 0)
					{
						TypeManagerMapDictionaries.ManagedToJni.Add(t, java_class);
					}
				}
				else if (!JNIEnvInit.IsRunningOnDesktop || t != typeof(TypeManager))
				{
					Logger.Log(LogLevel.Warn, "monodroid", string.Format("Type Registration Skipped for {0} to {1} ", java_class, t.ToString()));
				}
			}
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x00083E68 File Offset: 0x00082068
		private static void LazyInitPackageLookup()
		{
			if (TypeManager.packageLookup == null)
			{
				TypeManager.packageLookup = new Dictionary<string, List<Converter<string, Type>>>(StringComparer.Ordinal);
			}
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x00083E80 File Offset: 0x00082080
		public static void RegisterPackage(string package, Converter<string, Type> lookup)
		{
			TypeManager.LazyInitPackageLookup();
			Dictionary<string, List<Converter<string, Type>>> obj = TypeManager.packageLookup;
			lock (obj)
			{
				List<Converter<string, Type>> list;
				if (!TypeManager.packageLookup.TryGetValue(package, out list))
				{
					TypeManager.packageLookup.Add(package, list = new List<Converter<string, Type>>());
				}
				list.Add(lookup);
			}
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x00083EE8 File Offset: 0x000820E8
		public static void RegisterPackages(string[] packages, Converter<string, Type>[] lookups)
		{
			TypeManager.LazyInitPackageLookup();
			if (packages == null)
			{
				throw new ArgumentNullException("packages");
			}
			if (lookups == null)
			{
				throw new ArgumentNullException("lookups");
			}
			if (packages.Length != lookups.Length)
			{
				throw new ArgumentException("`packages` and `lookups` arrays must have same number of elements.");
			}
			Dictionary<string, List<Converter<string, Type>>> obj = TypeManager.packageLookup;
			lock (obj)
			{
				for (int i = 0; i < packages.Length; i++)
				{
					string key = packages[i];
					Converter<string, Type> item = lookups[i];
					List<Converter<string, Type>> list;
					if (!TypeManager.packageLookup.TryGetValue(key, out list))
					{
						TypeManager.packageLookup.Add(key, list = new List<Converter<string, Type>>());
					}
					list.Add(item);
				}
			}
		}

		// Token: 0x040012C5 RID: 4805
		private static readonly TypeManager.TypeNameComparer JavaNameComparer = new TypeManager.TypeNameComparer();

		// Token: 0x040012C6 RID: 4806
		private static _JniMarshal_PPLLLL_V cb_activate;

		// Token: 0x040012C7 RID: 4807
		private static readonly Type[] XAConstructorSignature = new Type[]
		{
			typeof(IntPtr),
			typeof(JniHandleOwnership)
		};

		// Token: 0x040012C8 RID: 4808
		private static readonly Type[] JIConstructorSignature = new Type[]
		{
			typeof(JniObjectReference).MakeByRefType(),
			typeof(JniObjectReferenceOptions)
		};

		// Token: 0x040012C9 RID: 4809
		private static Dictionary<string, List<Converter<string, Type>>> packageLookup;

		// Token: 0x0200043E RID: 1086
		private class TypeNameComparer : IComparer<string>
		{
			// Token: 0x06002F42 RID: 12098 RVA: 0x00084000 File Offset: 0x00082200
			public int Compare(string x, string y)
			{
				if (x == y)
				{
					return 0;
				}
				if (x == null)
				{
					return -1;
				}
				if (y == null)
				{
					return 1;
				}
				int num = x.IndexOf(':');
				int num2 = y.IndexOf(':');
				int num3 = string.CompareOrdinal(x, 0, y, 0, System.Math.Max(num, num2));
				if (num3 != 0)
				{
					return num3;
				}
				if (num >= 0 && num2 >= 0)
				{
					return num - num2;
				}
				if (num < 0)
				{
					return x.Length - num2;
				}
				return num - y.Length;
			}
		}

		// Token: 0x0200043F RID: 1087
		[Register("mono/android/TypeManager", DoNotGenerateAcw = true)]
		internal class JavaTypeManager : Java.Lang.Object
		{
			// Token: 0x06002F44 RID: 12100 RVA: 0x00084066 File Offset: 0x00082266
			[Register("activate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;[Ljava/lang/Object;)V", "")]
			private static void n_Activate(IntPtr jnienv, IntPtr jclass, IntPtr typename_ptr, IntPtr signature_ptr, IntPtr jobject, IntPtr parameters_ptr)
			{
				TypeManager.n_Activate(jnienv, jclass, typename_ptr, signature_ptr, jobject, parameters_ptr);
			}

			// Token: 0x06002F45 RID: 12101 RVA: 0x00084075 File Offset: 0x00082275
			internal static Delegate GetActivateHandler()
			{
				return TypeManager.GetActivateHandler();
			}
		}

		// Token: 0x02000440 RID: 1088
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040012CA RID: 4810
			public static _JniMarshal_PPLLLL_V <0>__n_Activate;
		}
	}
}
