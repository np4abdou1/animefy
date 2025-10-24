using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Android.Graphics;
using Java.Interop;
using Java.Interop.Tools.TypeNameMappings;
using Java.Lang;

namespace Android.Runtime
{
	// Token: 0x020002E1 RID: 737
	public static class JNIEnv
	{
		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001C11 RID: 7185 RVA: 0x0004B630 File Offset: 0x00049830
		public static IntPtr Handle
		{
			get
			{
				return JniEnvironment.EnvironmentPointer;
			}
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x0004B637 File Offset: 0x00049837
		internal static IntPtr IdentityHash(IntPtr v)
		{
			if (!JNIEnvInit.LocalRefsAreIndirect)
			{
				return v;
			}
			return RuntimeNativeMethods._monodroid_get_identity_hash_code(JNIEnv.Handle, v);
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x0004B650 File Offset: 0x00049850
		public static void CheckHandle(IntPtr jnienv)
		{
			new JniTransition(jnienv).Dispose();
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x0004B66B File Offset: 0x0004986B
		internal static bool IsGCUserPeer(IntPtr value)
		{
			return !(value == IntPtr.Zero) && JNIEnv.IsInstanceOf(value, JNIEnvInit.grefIGCUserPeer_class);
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0004B688 File Offset: 0x00049888
		internal static bool ShouldWrapJavaException(Throwable t, [CallerMemberName] string caller = null)
		{
			if (t == null)
			{
				RuntimeNativeMethods.monodroid_log(LogLevel.Warn, LogCategories.Default, "ShouldWrapJavaException was not passed a valid `Java.Lang.Throwable` instance. Called from method `" + caller + "`");
				return false;
			}
			bool flag = JNIEnvInit.BoundExceptionType == BoundExceptionType.System;
			if (!flag)
			{
				RuntimeNativeMethods.monodroid_log(LogLevel.Warn, LogCategories.Default, string.Concat(new string[]
				{
					"Not wrapping exception of type ",
					t.GetType().FullName,
					" from method `",
					caller,
					"`. This will change in a future release."
				}));
			}
			return flag;
		}

		// Token: 0x06001C16 RID: 7190
		[DllImport("libc")]
		private static extern int gettid();

		// Token: 0x06001C17 RID: 7191 RVA: 0x0004B6FC File Offset: 0x000498FC
		internal static void Exit()
		{
			foreach (WeakReference weakReference in Runtime.GetSurfacedObjects())
			{
				try
				{
					IDisposable disposable = weakReference.Target as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
					continue;
				}
				catch (System.Exception arg)
				{
					RuntimeNativeMethods.monodroid_log(LogLevel.Warn, LogCategories.Default, string.Format("Couldn't dispose object: {0}", arg));
				}
				Java.Lang.Object @object = weakReference.Target as Java.Lang.Object;
				if (@object != null)
				{
					JNIEnv.ManualJavaObjectDispose(@object);
				}
			}
			JniEnvironment.Runtime.Dispose();
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x0004B7A0 File Offset: 0x000499A0
		private static void ManualJavaObjectDispose(Java.Lang.Object obj)
		{
			JniObjectReference peerReference = obj.PeerReference;
			IntPtr handle = peerReference.Handle;
			IntPtr keyHandle = ((IJavaObjectEx)obj).KeyHandle;
			Java.Lang.Object.Dispose(obj, ref handle, keyHandle, (JObjectRefType)peerReference.Type);
			GC.SuppressFinalize(obj);
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x0004B7DC File Offset: 0x000499DC
		private static void Initialize()
		{
			AndroidRuntimeInternal.InitializeUnhandledExceptionMethod();
			if (JNIEnv.AppDomain_DoUnhandledException == null)
			{
				MethodInfo method = typeof(AppDomain).GetMethod("DoUnhandledException", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
				{
					typeof(UnhandledExceptionEventArgs)
				}, null);
				if (method != null)
				{
					JNIEnv.AppDomain_DoUnhandledException = (Action<AppDomain, UnhandledExceptionEventArgs>)Delegate.CreateDelegate(typeof(Action<AppDomain, UnhandledExceptionEventArgs>), method);
				}
			}
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x0004B844 File Offset: 0x00049A44
		internal static void PropagateUncaughtException(IntPtr env, IntPtr javaThreadPtr, IntPtr javaExceptionPtr)
		{
			if (!JNIEnvInit.PropagateExceptions)
			{
				return;
			}
			try
			{
				JNIEnv.Initialize();
			}
			catch (System.Exception arg)
			{
				AndroidEnvironment.FailFast(string.Format("Unable to initialize UncaughtExceptionHandler. Nested exception caught: {0}", arg));
			}
			Throwable @object = Java.Lang.Object.GetObject<Throwable>(env, javaExceptionPtr, JniHandleOwnership.DoNotTransfer);
			if (Debugger.IsAttached)
			{
				Action<System.Exception> mono_unhandled_exception = AndroidRuntimeInternal.mono_unhandled_exception;
				if (mono_unhandled_exception != null)
				{
					mono_unhandled_exception(@object);
				}
			}
			try
			{
				JavaProxyThrowable javaProxyThrowable = @object as JavaProxyThrowable;
				object obj = (javaProxyThrowable != null) ? javaProxyThrowable.InnerException : null;
				Logger.Log(LogLevel.Info, "MonoDroid", "UNHANDLED EXCEPTION:");
				Logger.Log(LogLevel.Info, "MonoDroid", @object.ToString());
				UnhandledExceptionEventArgs arg2 = new UnhandledExceptionEventArgs(obj ?? @object, true);
				Action<AppDomain, UnhandledExceptionEventArgs> appDomain_DoUnhandledException = JNIEnv.AppDomain_DoUnhandledException;
				if (appDomain_DoUnhandledException != null)
				{
					appDomain_DoUnhandledException(AppDomain.CurrentDomain, arg2);
				}
			}
			catch (System.Exception ex)
			{
				Logger.Log(LogLevel.Error, "monodroid", "Exception thrown while raising AppDomain.UnhandledException event: " + ex.ToString());
			}
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x0004B928 File Offset: 0x00049B28
		public static void WaitForBridgeProcessing()
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0004B930 File Offset: 0x00049B30
		public static IntPtr AllocObject(string jniClassName)
		{
			IntPtr intPtr = JNIEnv.FindClass(jniClassName);
			IntPtr result;
			try
			{
				result = JNIEnv.AllocObject(intPtr);
			}
			finally
			{
				JNIEnv.DeleteGlobalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0004B968 File Offset: 0x00049B68
		public static IntPtr AllocObject(Type type)
		{
			IntPtr intPtr = JNIEnv.FindClass(type);
			IntPtr result;
			try
			{
				result = JNIEnv.AllocObject(intPtr);
			}
			finally
			{
				JNIEnv.DeleteGlobalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0004B9A0 File Offset: 0x00049BA0
		public unsafe static IntPtr StartCreateInstance(IntPtr jclass, IntPtr constructorId, JValue* constructorParameters)
		{
			if (JNIEnvInit.AllocObjectSupported)
			{
				return JNIEnv.AllocObject(jclass);
			}
			return JNIEnv.NewObject(jclass, constructorId, constructorParameters);
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0004B9B8 File Offset: 0x00049BB8
		public unsafe static IntPtr StartCreateInstance(IntPtr jclass, IntPtr constructorId, params JValue[] constructorParameters)
		{
			JValue* constructorParameters2;
			if (constructorParameters == null || constructorParameters.Length == 0)
			{
				constructorParameters2 = null;
			}
			else
			{
				constructorParameters2 = &constructorParameters[0];
			}
			return JNIEnv.StartCreateInstance(jclass, constructorId, constructorParameters2);
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x0004B9E5 File Offset: 0x00049BE5
		public unsafe static void FinishCreateInstance(IntPtr instance, IntPtr jclass, IntPtr constructorId, JValue* constructorParameters)
		{
			if (!JNIEnvInit.AllocObjectSupported)
			{
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(instance, jclass, constructorId, constructorParameters);
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x0004B9F8 File Offset: 0x00049BF8
		public unsafe static void FinishCreateInstance(IntPtr instance, IntPtr jclass, IntPtr constructorId, params JValue[] constructorParameters)
		{
			fixed (JValue[] array = constructorParameters)
			{
				JValue* constructorParameters2;
				if (constructorParameters == null || array.Length == 0)
				{
					constructorParameters2 = null;
				}
				else
				{
					constructorParameters2 = &array[0];
				}
				JNIEnv.FinishCreateInstance(instance, jclass, constructorId, constructorParameters2);
			}
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x0004BA28 File Offset: 0x00049C28
		public unsafe static IntPtr StartCreateInstance(Type type, string jniCtorSignature, JValue* constructorParameters)
		{
			if (JNIEnvInit.AllocObjectSupported)
			{
				return JNIEnv.AllocObject(type);
			}
			return JNIEnv.CreateInstance(type, jniCtorSignature, constructorParameters);
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0004BA40 File Offset: 0x00049C40
		public unsafe static IntPtr StartCreateInstance(Type type, string jniCtorSignature, params JValue[] constructorParameters)
		{
			JValue* constructorParameters2;
			if (constructorParameters == null || constructorParameters.Length == 0)
			{
				constructorParameters2 = null;
			}
			else
			{
				constructorParameters2 = &constructorParameters[0];
			}
			return JNIEnv.StartCreateInstance(type, jniCtorSignature, constructorParameters2);
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0004BA6D File Offset: 0x00049C6D
		public unsafe static IntPtr StartCreateInstance(string jniClassName, string jniCtorSignature, JValue* constructorParameters)
		{
			if (JNIEnvInit.AllocObjectSupported)
			{
				return JNIEnv.AllocObject(jniClassName);
			}
			return JNIEnv.CreateInstance(jniClassName, jniCtorSignature, constructorParameters);
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x0004BA88 File Offset: 0x00049C88
		public unsafe static IntPtr StartCreateInstance(string jniClassName, string jniCtorSignature, params JValue[] constructorParameters)
		{
			JValue* constructorParameters2;
			if (constructorParameters == null || constructorParameters.Length == 0)
			{
				constructorParameters2 = null;
			}
			else
			{
				constructorParameters2 = &constructorParameters[0];
			}
			return JNIEnv.StartCreateInstance(jniClassName, jniCtorSignature, constructorParameters2);
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x0004BAB5 File Offset: 0x00049CB5
		public unsafe static void FinishCreateInstance(IntPtr instance, string jniCtorSignature, JValue* constructorParameters)
		{
			if (!JNIEnvInit.AllocObjectSupported)
			{
				return;
			}
			JNIEnv.InvokeConstructor(instance, jniCtorSignature, constructorParameters);
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x0004BAC8 File Offset: 0x00049CC8
		public unsafe static void FinishCreateInstance(IntPtr instance, string jniCtorSignature, params JValue[] constructorParameters)
		{
			fixed (JValue[] array = constructorParameters)
			{
				JValue* constructorParameters2;
				if (constructorParameters == null || array.Length == 0)
				{
					constructorParameters2 = null;
				}
				else
				{
					constructorParameters2 = &array[0];
				}
				JNIEnv.FinishCreateInstance(instance, jniCtorSignature, constructorParameters2);
			}
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x0004BAF8 File Offset: 0x00049CF8
		public unsafe static void InvokeConstructor(IntPtr instance, string jniCtorSignature, JValue* constructorParameters)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(instance);
			try
			{
				IntPtr methodID = JNIEnv.GetMethodID(objectClass, "<init>", jniCtorSignature);
				if (methodID == IntPtr.Zero)
				{
					throw new ArgumentException(string.Format("Could not find constructor JNI signature '{0}' on type '{1}'.", jniCtorSignature, TypeManager.GetClassName(objectClass)));
				}
				JNIEnv.CallNonvirtualVoidMethod(instance, objectClass, methodID, constructorParameters);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(objectClass);
			}
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x0004BB60 File Offset: 0x00049D60
		public unsafe static void InvokeConstructor(IntPtr instance, string jniCtorSignature, params JValue[] constructorParameters)
		{
			fixed (JValue[] array = constructorParameters)
			{
				JValue* constructorParameters2;
				if (constructorParameters == null || array.Length == 0)
				{
					constructorParameters2 = null;
				}
				else
				{
					constructorParameters2 = &array[0];
				}
				JNIEnv.InvokeConstructor(instance, jniCtorSignature, constructorParameters2);
			}
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x0004BB90 File Offset: 0x00049D90
		public unsafe static IntPtr CreateInstance(IntPtr jniClass, string signature, JValue* constructorParameters)
		{
			IntPtr methodID = JNIEnv.GetMethodID(jniClass, "<init>", signature);
			if (methodID == IntPtr.Zero)
			{
				throw new ArgumentException(string.Format("Could not find constructor JNI signature '{0}' on type '{1}'.", signature, TypeManager.GetClassName(jniClass)));
			}
			return JNIEnv.NewObject(jniClass, methodID, constructorParameters);
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x0004BBD8 File Offset: 0x00049DD8
		public unsafe static IntPtr CreateInstance(IntPtr jniClass, string signature, params JValue[] constructorParameters)
		{
			JValue* constructorParameters2;
			if (constructorParameters == null || constructorParameters.Length == 0)
			{
				constructorParameters2 = null;
			}
			else
			{
				constructorParameters2 = &constructorParameters[0];
			}
			return JNIEnv.CreateInstance(jniClass, signature, constructorParameters2);
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x0004BC08 File Offset: 0x00049E08
		public unsafe static IntPtr CreateInstance(string jniClassName, string signature, JValue* constructorParameters)
		{
			IntPtr intPtr = JNIEnv.FindClass(jniClassName);
			IntPtr result;
			try
			{
				result = JNIEnv.CreateInstance(intPtr, signature, constructorParameters);
			}
			finally
			{
				JNIEnv.DeleteGlobalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x0004BC40 File Offset: 0x00049E40
		public unsafe static IntPtr CreateInstance(string jniClassName, string signature, params JValue[] constructorParameters)
		{
			JValue* constructorParameters2;
			if (constructorParameters == null || constructorParameters.Length == 0)
			{
				constructorParameters2 = null;
			}
			else
			{
				constructorParameters2 = &constructorParameters[0];
			}
			return JNIEnv.CreateInstance(jniClassName, signature, constructorParameters2);
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x0004BC70 File Offset: 0x00049E70
		public unsafe static IntPtr CreateInstance(Type type, string signature, JValue* constructorParameters)
		{
			IntPtr intPtr = JNIEnv.FindClass(type);
			IntPtr result;
			try
			{
				result = JNIEnv.CreateInstance(intPtr, signature, constructorParameters);
			}
			finally
			{
				JNIEnv.DeleteGlobalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x0004BCA8 File Offset: 0x00049EA8
		public unsafe static IntPtr CreateInstance(Type type, string signature, params JValue[] constructorParameters)
		{
			JValue* constructorParameters2;
			if (constructorParameters == null || constructorParameters.Length == 0)
			{
				constructorParameters2 = null;
			}
			else
			{
				constructorParameters2 = &constructorParameters[0];
			}
			return JNIEnv.CreateInstance(type, signature, constructorParameters2);
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x0004BCD8 File Offset: 0x00049ED8
		public static IntPtr FindClass(Type type)
		{
			int arrayInfo = JavaNativeTypeManager.GetArrayInfo(type, out type);
			IntPtr result;
			try
			{
				result = JNIEnv.FindClass(JavaNativeTypeManager.ToJniName(JNIEnv.GetJniName(type), arrayInfo));
			}
			catch (Throwable throwable)
			{
				if (!(throwable is NoClassDefFoundError) && !(throwable is ClassNotFoundException))
				{
					throw;
				}
				RuntimeNativeMethods.monodroid_log(LogLevel.Warn, LogCategories.Default, string.Format("JNIEnv.FindClass(Type) caught unexpected exception: {0}", throwable));
				string text = TypeManager.GetJniTypeName(type);
				if (text != null)
				{
					throwable.Dispose();
					result = JNIEnv.FindClass(JavaNativeTypeManager.ToJniName(text, arrayInfo));
				}
				else
				{
					text = JavaNativeTypeManager.ToJniNameFromAttributes(type);
					if (text == null)
					{
						throw;
					}
					throwable.Dispose();
					result = JNIEnv.FindClass(JavaNativeTypeManager.ToJniName(text, arrayInfo));
				}
			}
			return result;
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x0004BD78 File Offset: 0x00049F78
		private unsafe static IntPtr BinaryName(string classname)
		{
			if (classname.IndexOf('/') == -1)
			{
				return JNIEnv.NewString(classname);
			}
			int length = classname.Length;
			if (length > 1024)
			{
				return JNIEnv.NewString(classname.Replace('/', '.'));
			}
			if (JNIEnv.nameBuffer == null)
			{
				JNIEnv.nameBuffer = new char[1024];
			}
			char[] array;
			fixed (string text = classname)
			{
				char* ptr = text;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				char* ptr2;
				if ((array = JNIEnv.nameBuffer) == null || array.Length == 0)
				{
					ptr2 = null;
				}
				else
				{
					ptr2 = &array[0];
				}
				char* ptr3 = ptr;
				char* ptr4 = ptr2;
				char* ptr5 = ptr + length;
				while (ptr3 < ptr5)
				{
					*ptr4 = ((*ptr3 == '/') ? '.' : (*ptr3));
					ptr3++;
					ptr4++;
				}
			}
			array = null;
			return JNIEnv.NewString(JNIEnv.nameBuffer, length);
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x0004BE40 File Offset: 0x0004A040
		public unsafe static IntPtr FindClass(string classname)
		{
			IntPtr intPtr = JNIEnv.BinaryName(classname);
			JniObjectReference jniObjectReference;
			try
			{
				IntPtr intPtr2 = stackalloc byte[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*intPtr2 = new JniArgumentValue(intPtr);
				*(intPtr2 + (IntPtr)sizeof(JniArgumentValue)) = new JniArgumentValue(true);
				*(intPtr2 + (IntPtr)2 * (IntPtr)sizeof(JniArgumentValue)) = new JniArgumentValue(JNIEnvInit.java_class_loader);
				JniArgumentValue* args = intPtr2;
				jniObjectReference = JniEnvironment.StaticMethods.CallStaticObjectMethod(Class.Members.JniPeerType.PeerReference, JNIEnvInit.mid_Class_forName, args);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			IntPtr result = JNIEnv.NewGlobalRef(jniObjectReference.Handle);
			JniObjectReference.Dispose(ref jniObjectReference);
			return result;
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x0004BEE0 File Offset: 0x0004A0E0
		public static IntPtr FindClass(string className, ref IntPtr cachedJniClassHandle)
		{
			if (cachedJniClassHandle != IntPtr.Zero)
			{
				return cachedJniClassHandle;
			}
			IntPtr intPtr = JNIEnv.FindClass(className);
			if (Interlocked.CompareExchange(ref cachedJniClassHandle, intPtr, IntPtr.Zero) != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(intPtr);
			}
			return cachedJniClassHandle;
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x0004BF25 File Offset: 0x0004A125
		public static void Throw(IntPtr obj)
		{
			if (obj == IntPtr.Zero)
			{
				throw new ArgumentException("'obj' must not be IntPtr.Zero.", "obj");
			}
			JniEnvironment.Exceptions.Throw(new JniObjectReference(obj, JniObjectReferenceType.Invalid));
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x0004BF50 File Offset: 0x0004A150
		public static void ThrowNew(IntPtr clazz, string message)
		{
			if (message == null)
			{
				throw new ArgumentNullException("message");
			}
			JniEnvironment.Exceptions.ThrowNew(new JniObjectReference(clazz, JniObjectReferenceType.Invalid), message);
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x0004BF6D File Offset: 0x0004A16D
		public static void PushLocalFrame(int capacity)
		{
			JniEnvironment.References.PushLocalFrame(capacity);
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x0004BF75 File Offset: 0x0004A175
		public static void EnsureLocalCapacity(int capacity)
		{
			JniEnvironment.References.EnsureLocalCapacity(capacity);
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x0004BF7D File Offset: 0x0004A17D
		internal static void DeleteRef(IntPtr handle, JniHandleOwnership transfer)
		{
			switch (transfer)
			{
			case JniHandleOwnership.DoNotTransfer:
				break;
			case JniHandleOwnership.TransferLocalRef:
				JNIEnv.DeleteLocalRef(handle);
				return;
			case JniHandleOwnership.TransferGlobalRef:
				JNIEnv.DeleteGlobalRef(handle);
				break;
			default:
				return;
			}
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x0004BFA0 File Offset: 0x0004A1A0
		public static IntPtr NewGlobalRef(IntPtr jobject)
		{
			JniObjectReference jniObjectReference = new JniObjectReference(jobject, JniObjectReferenceType.Invalid);
			return jniObjectReference.NewGlobalRef().Handle;
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x0004BFC8 File Offset: 0x0004A1C8
		public static void DeleteGlobalRef(IntPtr jobject)
		{
			JniObjectReference jniObjectReference = new JniObjectReference(jobject, JniObjectReferenceType.Global);
			JniObjectReference.Dispose(ref jniObjectReference);
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x0004BFE8 File Offset: 0x0004A1E8
		public static IntPtr NewLocalRef(IntPtr jobject)
		{
			return new JniObjectReference(jobject, JniObjectReferenceType.Invalid).NewLocalRef().Handle;
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x0004C00C File Offset: 0x0004A20C
		public static void DeleteLocalRef(IntPtr jobject)
		{
			JniObjectReference jniObjectReference = new JniObjectReference(jobject, JniObjectReferenceType.Local);
			JniObjectReference.Dispose(ref jniObjectReference);
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x0004C02C File Offset: 0x0004A22C
		public static void DeleteWeakGlobalRef(IntPtr jobject)
		{
			JniObjectReference jniObjectReference = new JniObjectReference(jobject, JniObjectReferenceType.WeakGlobal);
			JniObjectReference.Dispose(ref jniObjectReference);
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x0004C04C File Offset: 0x0004A24C
		public static IntPtr NewObject(IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.Object.NewObject(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false)).Handle;
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x0004C074 File Offset: 0x0004A274
		public unsafe static IntPtr NewObject(IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.Object.NewObject(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms).Handle;
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x0004C0A0 File Offset: 0x0004A2A0
		public unsafe static IntPtr NewObject(IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.NewObject(jclass, jmethod, parms2);
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x0004C0D0 File Offset: 0x0004A2D0
		public static string GetClassNameFromInstance(IntPtr jobject)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(jobject);
			string className;
			try
			{
				className = TypeManager.GetClassName(objectClass);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(objectClass);
			}
			return className;
		}

		// Token: 0x06001C42 RID: 7234
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr monodroid_typemap_managed_to_java(Type type, byte* mvid);

		// Token: 0x06001C43 RID: 7235 RVA: 0x0004C108 File Offset: 0x0004A308
		internal static void LogTypemapTrace(StackTrace st)
		{
			string text = st.ToString();
			string text2 = (text != null) ? text.Trim() : null;
			if (string.IsNullOrEmpty(text2))
			{
				return;
			}
			RuntimeNativeMethods.monodroid_log(LogLevel.Warn, LogCategories.Assembly, "typemap: called from");
			foreach (string message in text2.Split('\n', StringSplitOptions.None))
			{
				RuntimeNativeMethods.monodroid_log(LogLevel.Warn, LogCategories.Assembly, message);
			}
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x0004C164 File Offset: 0x0004A364
		internal unsafe static string TypemapManagedToJava(Type type)
		{
			if (JNIEnv.mvid_bytes == null)
			{
				JNIEnv.mvid_bytes = new byte[16];
			}
			Span<byte> destination = new Span<byte>(JNIEnv.mvid_bytes);
			byte[] array;
			if (!type.Module.ModuleVersionId.TryWriteBytes(destination))
			{
				RuntimeNativeMethods.monodroid_log(LogLevel.Warn, LogCategories.Default, "Failed to obtain module MVID using the fast method, falling back to the slow one");
				array = type.Module.ModuleVersionId.ToByteArray();
			}
			else
			{
				array = JNIEnv.mvid_bytes;
			}
			byte[] array2;
			byte* mvid;
			if ((array2 = array) == null || array2.Length == 0)
			{
				mvid = null;
			}
			else
			{
				mvid = &array2[0];
			}
			IntPtr intPtr = JNIEnv.monodroid_typemap_managed_to_java(type, mvid);
			array2 = null;
			if (intPtr == IntPtr.Zero)
			{
				if (JNIEnvInit.LogAssemblyCategory)
				{
					RuntimeNativeMethods.monodroid_log(LogLevel.Warn, LogCategories.Default, string.Format("typemap: failed to map managed type to Java type: {0} (Module ID: {1}; Type token: {2})", type.AssemblyQualifiedName, type.Module.ModuleVersionId, type.MetadataToken));
					JNIEnv.LogTypemapTrace(new StackTrace(true));
				}
				return null;
			}
			return Marshal.PtrToStringAnsi(intPtr);
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x0004C254 File Offset: 0x0004A454
		public static string GetJniName(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			string text = JNIEnv.TypemapManagedToJava(type);
			if (text != null)
			{
				return text;
			}
			return JavaNativeTypeManager.ToJniName(type);
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x0004C287 File Offset: 0x0004A487
		public static IntPtr ToJniHandle(IJavaObject value)
		{
			if (value == null)
			{
				return IntPtr.Zero;
			}
			return value.Handle;
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x0004C298 File Offset: 0x0004A498
		public static IntPtr ToLocalJniHandle(IJavaObject value)
		{
			if (value == null)
			{
				return IntPtr.Zero;
			}
			IJavaObjectEx javaObjectEx = value as IJavaObjectEx;
			if (javaObjectEx != null)
			{
				return javaObjectEx.ToLocalJniHandle();
			}
			return JNIEnv.NewLocalRef(value.Handle);
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x0004C2CC File Offset: 0x0004A4CC
		public static string GetCharSequence(IntPtr jobject, JniHandleOwnership transfer)
		{
			if (jobject == IntPtr.Zero)
			{
				return null;
			}
			JniObjectReference jniObjectReference = JniEnvironment.Object.ToString(new JniObjectReference(jobject, JniObjectReferenceType.Invalid));
			return JniEnvironment.Strings.ToString(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose);
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x0004C2FD File Offset: 0x0004A4FD
		public static string GetString(IntPtr value, JniHandleOwnership transfer)
		{
			if (value == IntPtr.Zero)
			{
				return null;
			}
			string result = JniEnvironment.Strings.ToString(new JniObjectReference(value, JniObjectReferenceType.Invalid));
			JNIEnv.DeleteRef(value, transfer);
			return result;
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x0004C324 File Offset: 0x0004A524
		public static IntPtr NewString(string text)
		{
			if (text == null)
			{
				return IntPtr.Zero;
			}
			return JniEnvironment.Strings.NewString(text).Handle;
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x0004C348 File Offset: 0x0004A548
		public unsafe static IntPtr NewString(char[] text, int length)
		{
			if (text == null)
			{
				return IntPtr.Zero;
			}
			char* unicodeChars;
			if (text == null || text.Length == 0)
			{
				unicodeChars = null;
			}
			else
			{
				unicodeChars = &text[0];
			}
			return JniEnvironment.Strings.NewString(unicodeChars, length).Handle;
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0004C388 File Offset: 0x0004A588
		private static void AssertCompatibleArrayTypes(Type sourceType, IntPtr destArray)
		{
			IntPtr intPtr = JNIEnv.FindClass(sourceType);
			IntPtr objectClass = JNIEnv.GetObjectClass(destArray);
			try
			{
				if (!JNIEnv.IsAssignableFrom(intPtr, objectClass))
				{
					throw new InvalidCastException(string.Format("Unable to cast from '{0}' to '{1}'.", TypeManager.GetClassName(intPtr), TypeManager.GetClassName(objectClass)));
				}
			}
			finally
			{
				JNIEnv.DeleteGlobalRef(intPtr);
				JNIEnv.DeleteLocalRef(objectClass);
			}
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x0004C3E8 File Offset: 0x0004A5E8
		private static void AssertCompatibleArrayTypes(IntPtr sourceArray, Type destType)
		{
			IntPtr intPtr = JNIEnv.FindClass(destType);
			IntPtr objectClass = JNIEnv.GetObjectClass(sourceArray);
			try
			{
				if (!JNIEnv.IsAssignableFrom(objectClass, intPtr))
				{
					throw new InvalidCastException(string.Format("Unable to cast from '{0}' to '{1}'.", TypeManager.GetClassName(objectClass), TypeManager.GetClassName(intPtr)));
				}
			}
			finally
			{
				JNIEnv.DeleteGlobalRef(intPtr);
				JNIEnv.DeleteLocalRef(objectClass);
			}
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x0004C448 File Offset: 0x0004A648
		public static void CopyArray(IntPtr src, bool[] dest)
		{
			if (dest == null)
			{
				throw new ArgumentNullException("dest");
			}
			JNIEnv.AssertCompatibleArrayTypes(src, typeof(bool[]));
			JNIEnv._GetBooleanArrayRegion(src, 0, dest.Length, dest);
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x0004C474 File Offset: 0x0004A674
		public static void CopyArray(IntPtr src, string[] dest)
		{
			if (dest == null)
			{
				throw new ArgumentNullException("dest");
			}
			for (int i = 0; i < dest.Length; i++)
			{
				dest[i] = JNIEnv.GetString(JNIEnv.GetObjectArrayElement(src, i), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x0004C4B0 File Offset: 0x0004A6B0
		private static Dictionary<Type, Func<Type, IntPtr, int, object>> NativeArrayElementToManaged
		{
			get
			{
				if (JNIEnv.nativeArrayElementToManaged != null)
				{
					return JNIEnv.nativeArrayElementToManaged;
				}
				Dictionary<Type, Func<Type, IntPtr, int, object>> value = JNIEnv.CreateNativeArrayElementToManaged();
				Interlocked.CompareExchange<Dictionary<Type, Func<Type, IntPtr, int, object>>>(ref JNIEnv.nativeArrayElementToManaged, value, null);
				return JNIEnv.nativeArrayElementToManaged;
			}
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0004C4E4 File Offset: 0x0004A6E4
		private static Dictionary<Type, Func<Type, IntPtr, int, object>> CreateNativeArrayElementToManaged()
		{
			Dictionary<Type, Func<Type, IntPtr, int, object>> dictionary = new Dictionary<Type, Func<Type, IntPtr, int, object>>();
			dictionary.Add(typeof(bool), delegate(Type type, IntPtr source, int index)
			{
				bool[] array = new bool[1];
				JNIEnv._GetBooleanArrayRegion(source, index, 1, array);
				return array[0];
			});
			dictionary.Add(typeof(byte), delegate(Type type, IntPtr source, int index)
			{
				byte[] array = new byte[1];
				JNIEnv._GetByteArrayRegion(source, index, 1, array);
				return array[0];
			});
			dictionary.Add(typeof(char), delegate(Type type, IntPtr source, int index)
			{
				char[] array = new char[1];
				JNIEnv._GetCharArrayRegion(source, index, 1, array);
				return array[0];
			});
			dictionary.Add(typeof(short), delegate(Type type, IntPtr source, int index)
			{
				short[] array = new short[1];
				JNIEnv._GetShortArrayRegion(source, index, 1, array);
				return array[0];
			});
			dictionary.Add(typeof(int), delegate(Type type, IntPtr source, int index)
			{
				int[] array = new int[1];
				JNIEnv._GetIntArrayRegion(source, index, 1, array);
				return array[0];
			});
			dictionary.Add(typeof(long), delegate(Type type, IntPtr source, int index)
			{
				long[] array = new long[1];
				JNIEnv._GetLongArrayRegion(source, index, 1, array);
				return array[0];
			});
			dictionary.Add(typeof(float), delegate(Type type, IntPtr source, int index)
			{
				float[] array = new float[1];
				JNIEnv._GetFloatArrayRegion(source, index, 1, array);
				return array[0];
			});
			dictionary.Add(typeof(double), delegate(Type type, IntPtr source, int index)
			{
				double[] array = new double[1];
				JNIEnv._GetDoubleArrayRegion(source, index, 1, array);
				return array[0];
			});
			dictionary.Add(typeof(string), delegate(Type type, IntPtr source, int index)
			{
				IntPtr objectArrayElement = JNIEnv.GetObjectArrayElement(source, index);
				if (type == typeof(Java.Lang.String))
				{
					return new Java.Lang.String(objectArrayElement, JniHandleOwnership.TransferLocalRef);
				}
				return JNIEnv.GetString(objectArrayElement, JniHandleOwnership.TransferLocalRef);
			});
			dictionary.Add(typeof(IJavaObject), delegate(Type type, IntPtr source, int index)
			{
				JNIEnv.AssertIsJavaObject(type);
				return Java.Lang.Object.GetObject(JNIEnv.GetObjectArrayElement(source, index), JniHandleOwnership.TransferLocalRef, type);
			});
			dictionary.Add(typeof(Array), (Type type, IntPtr source, int index) => JNIEnv.GetArray(JNIEnv.GetObjectArrayElement(source, index), JniHandleOwnership.TransferLocalRef, type));
			return dictionary;
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x0004C6FC File Offset: 0x0004A8FC
		private static TValue GetConverter<TValue>(Dictionary<Type, TValue> dict, Type elementType, IntPtr array)
		{
			if (elementType != null)
			{
				if (elementType.IsEnum)
				{
					elementType = System.Enum.GetUnderlyingType(elementType);
				}
				TValue result;
				if (dict.TryGetValue(elementType, out result))
				{
					return result;
				}
			}
			if (array != IntPtr.Zero)
			{
				string classNameFromInstance = JNIEnv.GetClassNameFromInstance(array);
				if (classNameFromInstance == null || classNameFromInstance.Length < 1 || classNameFromInstance[0] != '[')
				{
					throw new InvalidOperationException("Unsupported java array type: " + classNameFromInstance);
				}
				char c = classNameFromInstance[1];
				if (c <= 'S')
				{
					switch (c)
					{
					case 'B':
						return dict[typeof(byte)];
					case 'C':
						return dict[typeof(char)];
					case 'D':
						return dict[typeof(double)];
					case 'E':
					case 'G':
					case 'H':
						break;
					case 'F':
						return dict[typeof(float)];
					case 'I':
						return dict[typeof(int)];
					case 'J':
						return dict[typeof(long)];
					default:
						if (c == 'S')
						{
							return dict[typeof(short)];
						}
						break;
					}
				}
				else
				{
					if (c == 'Z')
					{
						return dict[typeof(bool)];
					}
					if (c == '[')
					{
						if (elementType == null || elementType.IsArray)
						{
							return dict[typeof(Array)];
						}
					}
				}
				if (classNameFromInstance == "[Ljava/lang/String;")
				{
					return dict[typeof(string)];
				}
			}
			if (elementType != null && elementType.IsArray)
			{
				return dict[typeof(Array)];
			}
			JNIEnv.AssertIsJavaObject(elementType);
			return dict[typeof(IJavaObject)];
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x0004C8CC File Offset: 0x0004AACC
		private unsafe static void _GetBooleanArrayRegion(IntPtr array, int start, int length, bool[] buffer)
		{
			fixed (bool[] array2 = buffer)
			{
				bool* buffer2;
				if (buffer == null || array2.Length == 0)
				{
					buffer2 = null;
				}
				else
				{
					buffer2 = &array2[0];
				}
				JniEnvironment.Arrays.GetBooleanArrayRegion(new JniObjectReference(array, JniObjectReferenceType.Invalid), start, length, buffer2);
			}
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x0004C904 File Offset: 0x0004AB04
		private unsafe static void _GetByteArrayRegion(IntPtr array, int start, int length, byte[] buffer)
		{
			fixed (byte[] array2 = buffer)
			{
				byte* buffer2;
				if (buffer == null || array2.Length == 0)
				{
					buffer2 = null;
				}
				else
				{
					buffer2 = &array2[0];
				}
				JniEnvironment.Arrays.GetByteArrayRegion(new JniObjectReference(array, JniObjectReferenceType.Invalid), start, length, (sbyte*)buffer2);
			}
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x0004C93C File Offset: 0x0004AB3C
		private unsafe static void _GetCharArrayRegion(IntPtr array, int start, int length, char[] buffer)
		{
			fixed (char[] array2 = buffer)
			{
				char* buffer2;
				if (buffer == null || array2.Length == 0)
				{
					buffer2 = null;
				}
				else
				{
					buffer2 = &array2[0];
				}
				JniEnvironment.Arrays.GetCharArrayRegion(new JniObjectReference(array, JniObjectReferenceType.Invalid), start, length, buffer2);
			}
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x0004C974 File Offset: 0x0004AB74
		private unsafe static void _GetShortArrayRegion(IntPtr array, int start, int length, short[] buffer)
		{
			fixed (short[] array2 = buffer)
			{
				short* buffer2;
				if (buffer == null || array2.Length == 0)
				{
					buffer2 = null;
				}
				else
				{
					buffer2 = &array2[0];
				}
				JniEnvironment.Arrays.GetShortArrayRegion(new JniObjectReference(array, JniObjectReferenceType.Invalid), start, length, buffer2);
			}
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x0004C9AC File Offset: 0x0004ABAC
		private unsafe static void _GetIntArrayRegion(IntPtr array, int start, int length, int[] buffer)
		{
			fixed (int[] array2 = buffer)
			{
				int* buffer2;
				if (buffer == null || array2.Length == 0)
				{
					buffer2 = null;
				}
				else
				{
					buffer2 = &array2[0];
				}
				JniEnvironment.Arrays.GetIntArrayRegion(new JniObjectReference(array, JniObjectReferenceType.Invalid), start, length, buffer2);
			}
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x0004C9E4 File Offset: 0x0004ABE4
		private unsafe static void _GetLongArrayRegion(IntPtr array, int start, int length, long[] buffer)
		{
			fixed (long[] array2 = buffer)
			{
				long* buffer2;
				if (buffer == null || array2.Length == 0)
				{
					buffer2 = null;
				}
				else
				{
					buffer2 = &array2[0];
				}
				JniEnvironment.Arrays.GetLongArrayRegion(new JniObjectReference(array, JniObjectReferenceType.Invalid), start, length, buffer2);
			}
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x0004CA1C File Offset: 0x0004AC1C
		private unsafe static void _GetFloatArrayRegion(IntPtr array, int start, int length, float[] buffer)
		{
			fixed (float[] array2 = buffer)
			{
				float* buffer2;
				if (buffer == null || array2.Length == 0)
				{
					buffer2 = null;
				}
				else
				{
					buffer2 = &array2[0];
				}
				JniEnvironment.Arrays.GetFloatArrayRegion(new JniObjectReference(array, JniObjectReferenceType.Invalid), start, length, buffer2);
			}
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x0004CA54 File Offset: 0x0004AC54
		private unsafe static void _GetDoubleArrayRegion(IntPtr array, int start, int length, double[] buffer)
		{
			fixed (double[] array2 = buffer)
			{
				double* buffer2;
				if (buffer == null || array2.Length == 0)
				{
					buffer2 = null;
				}
				else
				{
					buffer2 = &array2[0];
				}
				JniEnvironment.Arrays.GetDoubleArrayRegion(new JniObjectReference(array, JniObjectReferenceType.Invalid), start, length, buffer2);
			}
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x0004CA8C File Offset: 0x0004AC8C
		public static void CopyArray(IntPtr src, Array dest, Type elementType = null)
		{
			if (dest == null)
			{
				throw new ArgumentNullException("dest");
			}
			if (elementType != null && elementType.IsValueType)
			{
				JNIEnv.AssertCompatibleArrayTypes(src, elementType.MakeArrayType());
			}
			if (elementType != null && elementType.IsArray)
			{
				for (int i = 0; i < dest.Length; i++)
				{
					IntPtr objectArrayElement = JNIEnv.GetObjectArrayElement(src, i);
					try
					{
						Array array = (Array)dest.GetValue(i);
						if (array == null)
						{
							dest.SetValue(JNIEnv.GetArray(objectArrayElement, JniHandleOwnership.DoNotTransfer, elementType.GetElementType()), i);
						}
						else
						{
							JNIEnv.CopyArray(objectArrayElement, array, elementType.GetElementType());
						}
					}
					finally
					{
						JNIEnv.DeleteLocalRef(objectArrayElement);
					}
				}
				return;
			}
			Func<Type, IntPtr, int, object> converter = JNIEnv.GetConverter<Func<Type, IntPtr, int, object>>(JNIEnv.NativeArrayElementToManaged, elementType, src);
			for (int j = 0; j < dest.Length; j++)
			{
				dest.SetValue(converter(elementType, src, j), j);
			}
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x0004CB70 File Offset: 0x0004AD70
		private static void AssertIsJavaObject(Type targetType)
		{
			if (targetType != null && !typeof(IJavaObject).IsAssignableFrom(targetType))
			{
				throw new NotSupportedException("Don't know how to convert type '" + targetType.FullName + "' to an Android.Runtime.IJavaObject.");
			}
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x0004CBA8 File Offset: 0x0004ADA8
		public static void CopyArray<T>(IntPtr src, T[] dest)
		{
			if (dest == null)
			{
				throw new ArgumentNullException("dest");
			}
			if (typeof(T).IsValueType)
			{
				JNIEnv.AssertCompatibleArrayTypes(src, typeof(T[]));
			}
			if (typeof(T).IsArray)
			{
				JNIEnv.CopyArray(src, dest, typeof(T));
				return;
			}
			Func<Type, IntPtr, int, object> converter = JNIEnv.GetConverter<Func<Type, IntPtr, int, object>>(JNIEnv.NativeArrayElementToManaged, typeof(T), src);
			for (int i = 0; i < dest.Length; i++)
			{
				dest[i] = (T)((object)converter(typeof(T), src, i));
			}
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x0004CC4C File Offset: 0x0004AE4C
		public unsafe static void CopyArray(bool[] src, IntPtr dest)
		{
			if (src == null)
			{
				throw new ArgumentNullException("src");
			}
			JNIEnv.AssertCompatibleArrayTypes(typeof(bool[]), dest);
			fixed (bool[] array = src)
			{
				bool* buffer;
				if (src == null || array.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array[0];
				}
				JniEnvironment.Arrays.SetBooleanArrayRegion(new JniObjectReference(dest, JniObjectReferenceType.Invalid), 0, src.Length, buffer);
			}
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x0004CCA4 File Offset: 0x0004AEA4
		public static void CopyArray(string[] src, IntPtr dest)
		{
			if (src == null)
			{
				throw new ArgumentNullException("src");
			}
			for (int i = 0; i < src.Length; i++)
			{
				IntPtr intPtr = JNIEnv.NewString(src[i]);
				JniEnvironment.Arrays.SetObjectArrayElement(new JniObjectReference(dest, JniObjectReferenceType.Invalid), i, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x0004CCF0 File Offset: 0x0004AEF0
		public static void CopyArray(IJavaObject[] src, IntPtr dest)
		{
			if (src == null)
			{
				throw new ArgumentNullException("src");
			}
			for (int i = 0; i < src.Length; i++)
			{
				IJavaObject javaObject = src[i];
				JniEnvironment.Arrays.SetObjectArrayElement(new JniObjectReference(dest, JniObjectReferenceType.Invalid), i, new JniObjectReference((javaObject == null) ? IntPtr.Zero : javaObject.Handle, JniObjectReferenceType.Invalid));
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x0004CD40 File Offset: 0x0004AF40
		private static Dictionary<Type, Action<Array, IntPtr>> CopyManagedToNativeArray
		{
			get
			{
				if (JNIEnv.copyManagedToNativeArray != null)
				{
					return JNIEnv.copyManagedToNativeArray;
				}
				Dictionary<Type, Action<Array, IntPtr>> value = JNIEnv.CreateCopyManagedToNativeArray();
				Interlocked.CompareExchange<Dictionary<Type, Action<Array, IntPtr>>>(ref JNIEnv.copyManagedToNativeArray, value, null);
				return JNIEnv.copyManagedToNativeArray;
			}
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x0004CD74 File Offset: 0x0004AF74
		private static Dictionary<Type, Action<Array, IntPtr>> CreateCopyManagedToNativeArray()
		{
			Dictionary<Type, Action<Array, IntPtr>> dictionary = new Dictionary<Type, Action<Array, IntPtr>>();
			dictionary.Add(typeof(bool), delegate(Array source, IntPtr dest)
			{
				JNIEnv.CopyArray((bool[])source, dest);
			});
			dictionary.Add(typeof(byte), delegate(Array source, IntPtr dest)
			{
				JNIEnv.CopyArray((byte[])source, dest);
			});
			dictionary.Add(typeof(char), delegate(Array source, IntPtr dest)
			{
				JNIEnv.CopyArray((char[])source, dest);
			});
			dictionary.Add(typeof(short), delegate(Array source, IntPtr dest)
			{
				JNIEnv.CopyArray((short[])source, dest);
			});
			dictionary.Add(typeof(int), delegate(Array source, IntPtr dest)
			{
				JNIEnv.CopyArray((int[])source, dest);
			});
			dictionary.Add(typeof(long), delegate(Array source, IntPtr dest)
			{
				JNIEnv.CopyArray((long[])source, dest);
			});
			dictionary.Add(typeof(float), delegate(Array source, IntPtr dest)
			{
				JNIEnv.CopyArray((float[])source, dest);
			});
			dictionary.Add(typeof(double), delegate(Array source, IntPtr dest)
			{
				JNIEnv.CopyArray((double[])source, dest);
			});
			dictionary.Add(typeof(string), delegate(Array source, IntPtr dest)
			{
				string[] array = source as string[];
				if (array != null)
				{
					JNIEnv.CopyArray(array, dest);
					return;
				}
				IJavaObject[] array2 = source as IJavaObject[];
				if (array2 != null)
				{
					JNIEnv.CopyArray(array2, dest);
					return;
				}
				throw new NotSupportedException(string.Concat(new string[]
				{
					"Don't know how to copy '",
					source.GetType().FullName,
					"' to '",
					JNIEnv.GetClassNameFromInstance(dest),
					"'."
				}));
			});
			dictionary.Add(typeof(IJavaObject), delegate(Array source, IntPtr dest)
			{
				JNIEnv.CopyArray((IJavaObject[])source, dest);
			});
			dictionary.Add(typeof(Array), delegate(Array source, IntPtr dest)
			{
				int length = source.GetLength(0);
				for (int i = 0; i < length; i++)
				{
					IntPtr objectArrayElement = JNIEnv.GetObjectArrayElement(dest, i);
					Array array = (Array)source.GetValue(i);
					JNIEnv.CopyArray(array, array.GetType().GetElementType(), objectArrayElement);
					JNIEnv.DeleteLocalRef(objectArrayElement);
				}
			});
			return dictionary;
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x0004CF8C File Offset: 0x0004B18C
		public static void CopyArray(Array source, Type elementType, IntPtr dest)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (elementType == null)
			{
				throw new ArgumentNullException("elementType");
			}
			if (elementType.IsValueType)
			{
				JNIEnv.AssertCompatibleArrayTypes(elementType.MakeArrayType(), dest);
			}
			JNIEnv.GetConverter<Action<Array, IntPtr>>(JNIEnv.CopyManagedToNativeArray, elementType, dest)(source, dest);
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x0004CFE2 File Offset: 0x0004B1E2
		public static void CopyArray<T>(T[] src, IntPtr dest)
		{
			if (src == null)
			{
				throw new ArgumentNullException("src");
			}
			JNIEnv.CopyArray(src, typeof(T), dest);
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x0004D004 File Offset: 0x0004B204
		public static Array GetArray(IntPtr array_ptr, JniHandleOwnership transfer, Type element_type = null)
		{
			Array result;
			try
			{
				result = JNIEnv._GetArray(array_ptr, element_type);
			}
			finally
			{
				JNIEnv.DeleteRef(array_ptr, transfer);
			}
			return result;
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x0004D034 File Offset: 0x0004B234
		private static Dictionary<Type, Func<Type, IntPtr, int, Array>> NativeArrayToManaged
		{
			get
			{
				if (JNIEnv.nativeArrayToManaged != null)
				{
					return JNIEnv.nativeArrayToManaged;
				}
				Dictionary<Type, Func<Type, IntPtr, int, Array>> value = JNIEnv.CreateNativeArrayToManaged();
				Interlocked.CompareExchange<Dictionary<Type, Func<Type, IntPtr, int, Array>>>(ref JNIEnv.nativeArrayToManaged, value, null);
				return JNIEnv.nativeArrayToManaged;
			}
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x0004D068 File Offset: 0x0004B268
		private static Dictionary<Type, Func<Type, IntPtr, int, Array>> CreateNativeArrayToManaged()
		{
			Dictionary<Type, Func<Type, IntPtr, int, Array>> dictionary = new Dictionary<Type, Func<Type, IntPtr, int, Array>>();
			dictionary.Add(typeof(bool), delegate(Type type, IntPtr source, int len)
			{
				bool[] array = new bool[len];
				JNIEnv.CopyArray(source, array);
				return array;
			});
			dictionary.Add(typeof(byte), delegate(Type type, IntPtr source, int len)
			{
				byte[] array = new byte[len];
				JNIEnv.CopyArray(source, array);
				return array;
			});
			dictionary.Add(typeof(char), delegate(Type type, IntPtr source, int len)
			{
				char[] array = new char[len];
				JNIEnv.CopyArray(source, array);
				return array;
			});
			dictionary.Add(typeof(short), delegate(Type type, IntPtr source, int len)
			{
				short[] array = new short[len];
				JNIEnv.CopyArray(source, array);
				return array;
			});
			dictionary.Add(typeof(ushort), delegate(Type type, IntPtr source, int len)
			{
				ushort[] array = new ushort[len];
				JNIEnv.CopyArray(source, array);
				return array;
			});
			dictionary.Add(typeof(int), delegate(Type type, IntPtr source, int len)
			{
				int[] array = new int[len];
				JNIEnv.CopyArray(source, array);
				return array;
			});
			dictionary.Add(typeof(uint), delegate(Type type, IntPtr source, int len)
			{
				uint[] array = new uint[len];
				JNIEnv.CopyArray(source, array);
				return array;
			});
			dictionary.Add(typeof(long), delegate(Type type, IntPtr source, int len)
			{
				long[] array = new long[len];
				JNIEnv.CopyArray(source, array);
				return array;
			});
			dictionary.Add(typeof(ulong), delegate(Type type, IntPtr source, int len)
			{
				ulong[] array = new ulong[len];
				JNIEnv.CopyArray(source, array);
				return array;
			});
			dictionary.Add(typeof(float), delegate(Type type, IntPtr source, int len)
			{
				float[] array = new float[len];
				JNIEnv.CopyArray(source, array);
				return array;
			});
			dictionary.Add(typeof(double), delegate(Type type, IntPtr source, int len)
			{
				double[] array = new double[len];
				JNIEnv.CopyArray(source, array);
				return array;
			});
			dictionary.Add(typeof(string), delegate(Type type, IntPtr source, int len)
			{
				if (type != null && typeof(Java.Lang.Object).IsAssignableFrom(type))
				{
					Java.Lang.String[] array = new Java.Lang.String[len];
					JNIEnv.CopyArray<Java.Lang.String>(source, array);
					return array;
				}
				string[] array2 = new string[len];
				JNIEnv.CopyArray(source, array2);
				return array2;
			});
			dictionary.Add(typeof(IJavaObject), delegate(Type type, IntPtr source, int len)
			{
				Array array = Array.CreateInstance(type, len);
				JNIEnv.CopyArray(source, array, type);
				return array;
			});
			dictionary.Add(typeof(Array), delegate(Type type, IntPtr source, int len)
			{
				Array array = Array.CreateInstance(type, len);
				JNIEnv.CopyArray(source, array, type);
				return array;
			});
			return dictionary;
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0004D30C File Offset: 0x0004B50C
		private static Array _GetArray(IntPtr array_ptr, Type element_type)
		{
			if (array_ptr == IntPtr.Zero)
			{
				return null;
			}
			if (element_type != null && element_type.IsValueType)
			{
				JNIEnv.AssertCompatibleArrayTypes(array_ptr, element_type.MakeArrayType());
			}
			int arg = JNIEnv._GetArrayLength(array_ptr);
			return JNIEnv.GetConverter<Func<Type, IntPtr, int, Array>>(JNIEnv.NativeArrayToManaged, element_type, array_ptr)(element_type, array_ptr, arg);
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x0004D360 File Offset: 0x0004B560
		private static int _GetArrayLength(IntPtr array_ptr)
		{
			return JniEnvironment.Arrays.GetArrayLength(new JniObjectReference(array_ptr, JniObjectReferenceType.Invalid));
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0004D370 File Offset: 0x0004B570
		public static object[] GetObjectArray(IntPtr array_ptr, Type[] element_types)
		{
			if (array_ptr == IntPtr.Zero)
			{
				return null;
			}
			int num = JNIEnv._GetArrayLength(array_ptr);
			if (num == 0)
			{
				return Array.Empty<object>();
			}
			Func<Type, IntPtr, int, object> converter = JNIEnv.GetConverter<Func<Type, IntPtr, int, object>>(JNIEnv.NativeArrayElementToManaged, null, array_ptr);
			object[] array = new object[num];
			for (int i = 0; i < num; i++)
			{
				Type type = (element_types != null && i < element_types.Length) ? element_types[i] : null;
				object obj = converter((type == null || type.IsValueType) ? null : type, array_ptr, i);
				array[i] = obj;
				array[i] = ((type == null || type.IsInstanceOfType(obj)) ? obj : Convert.ChangeType(obj, type));
			}
			return array;
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x0004D41C File Offset: 0x0004B61C
		public static T[] GetArray<T>(IntPtr array_ptr)
		{
			if (array_ptr == IntPtr.Zero)
			{
				return null;
			}
			if (typeof(T).IsValueType)
			{
				JNIEnv.AssertCompatibleArrayTypes(array_ptr, typeof(T[]));
			}
			T[] array = new T[JNIEnv._GetArrayLength(array_ptr)];
			JNIEnv.CopyArray<T>(array_ptr, array);
			return array;
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x0004D470 File Offset: 0x0004B670
		public static T[] GetArray<T>(Java.Lang.Object[] array)
		{
			if (array == null)
			{
				return null;
			}
			T[] array2 = new T[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = JavaConvert.FromJavaObject<T>(array[i]);
			}
			return array2;
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x0004D4AC File Offset: 0x0004B6AC
		public static T GetArrayItem<T>(IntPtr array_ptr, int index)
		{
			if (array_ptr == IntPtr.Zero)
			{
				throw new ArgumentException("array_ptr");
			}
			if (index < 0 || index >= JNIEnv.GetArrayLength(array_ptr))
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return (T)((object)JNIEnv.GetConverter<Func<Type, IntPtr, int, object>>(JNIEnv.NativeArrayElementToManaged, typeof(T), array_ptr)(typeof(T), array_ptr, index));
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0004D514 File Offset: 0x0004B714
		public static int GetArrayLength(IntPtr array_ptr)
		{
			if (array_ptr == IntPtr.Zero)
			{
				return 0;
			}
			return JNIEnv._GetArrayLength(array_ptr);
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x0004D52C File Offset: 0x0004B72C
		public unsafe static IntPtr NewArray(bool[] array)
		{
			if (array == null)
			{
				return IntPtr.Zero;
			}
			JniObjectReference array2 = JniEnvironment.Arrays.NewBooleanArray(array.Length);
			fixed (bool[] array3 = array)
			{
				bool* buffer;
				if (array == null || array3.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array3[0];
				}
				JniEnvironment.Arrays.SetBooleanArrayRegion(array2, 0, array.Length, buffer);
			}
			return array2.Handle;
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x0004D578 File Offset: 0x0004B778
		public static IntPtr NewArray(string[] array)
		{
			if (array == null)
			{
				return IntPtr.Zero;
			}
			IntPtr intPtr = JNIEnv.NewObjectArray(array.Length, Class.String, IntPtr.Zero);
			JNIEnv.CopyArray(array, intPtr);
			return intPtr;
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x0004D5A9 File Offset: 0x0004B7A9
		public static IntPtr NewArray(uint[] array)
		{
			return JNIEnv.NewArray((int[])array);
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x0004D5B6 File Offset: 0x0004B7B6
		public static IntPtr NewArray(ushort[] array)
		{
			return JNIEnv.NewArray((short[])array);
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0004D5C3 File Offset: 0x0004B7C3
		public static IntPtr NewArray(ulong[] array)
		{
			return JNIEnv.NewArray((long[])array);
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0004D5D0 File Offset: 0x0004B7D0
		public static IntPtr NewObjectArray(int length, IntPtr elementClass)
		{
			return JNIEnv.NewObjectArray(length, elementClass, IntPtr.Zero);
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x0004D5E0 File Offset: 0x0004B7E0
		public static IntPtr NewObjectArray(int length, IntPtr elementClass, IntPtr initialElement)
		{
			return JniEnvironment.Arrays.NewObjectArray(length, new JniObjectReference(elementClass, JniObjectReferenceType.Invalid), new JniObjectReference(initialElement, JniObjectReferenceType.Invalid)).Handle;
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0004D60C File Offset: 0x0004B80C
		public static IntPtr NewObjectArray<T>(params T[] values)
		{
			if (values == null)
			{
				return IntPtr.Zero;
			}
			IntPtr intPtr = JNIEnv.GetArrayElementClass<T>(values);
			if (TypeManager.GetClassName(intPtr) == "mono/android/runtime/JavaObject")
			{
				JNIEnv.DeleteGlobalRef(intPtr);
				intPtr = JNIEnv.NewGlobalRef(Class.Object);
			}
			IntPtr lrefArray2;
			try
			{
				IntPtr lrefArray = JNIEnv.NewObjectArray(values.Length, intPtr, IntPtr.Zero);
				int j;
				int i;
				Func<IntPtr, IntPtr> <>9__0;
				for (i = 0; i < values.Length; i = j)
				{
					T value = values[i];
					Func<IntPtr, IntPtr> action;
					if ((action = <>9__0) == null)
					{
						action = (<>9__0 = delegate(IntPtr lref)
						{
							JNIEnv.SetObjectArrayElement(lrefArray, i, lref);
							return IntPtr.Zero;
						});
					}
					JavaConvert.WithLocalJniHandle<T, IntPtr>(value, action);
					j = i + 1;
				}
				lrefArray2 = lrefArray;
			}
			finally
			{
				JNIEnv.DeleteGlobalRef(intPtr);
			}
			return lrefArray2;
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0004D6E0 File Offset: 0x0004B8E0
		private static IntPtr GetArrayElementClass<T>(T[] values)
		{
			Type typeFromHandle = typeof(T);
			string jniClassForType = JavaConvert.GetJniClassForType(typeFromHandle);
			if (jniClassForType != null)
			{
				return JNIEnv.FindClass(jniClassForType);
			}
			if (typeFromHandle.IsValueType)
			{
				return JNIEnv.NewGlobalRef(Class.Object);
			}
			return JNIEnv.FindClass(typeFromHandle);
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x0004D724 File Offset: 0x0004B924
		public static void CopyObjectArray<T>(IntPtr source, T[] destination)
		{
			if (source == IntPtr.Zero)
			{
				return;
			}
			if (destination == null)
			{
				throw new ArgumentNullException("destination");
			}
			int num = System.Math.Min(JNIEnv.GetArrayLength(source), destination.Length);
			for (int i = 0; i < num; i++)
			{
				IntPtr objectArrayElement = JNIEnv.GetObjectArrayElement(source, i);
				destination[i] = JavaConvert.FromJniHandle<T>(objectArrayElement, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x0004D780 File Offset: 0x0004B980
		public static void CopyObjectArray<T>(T[] source, IntPtr destination)
		{
			if (source == null)
			{
				return;
			}
			if (destination == IntPtr.Zero)
			{
				throw new ArgumentException("Destination is a null JNI handle!", "destination");
			}
			int num = System.Math.Min(source.Length, JNIEnv.GetArrayLength(destination));
			int i;
			Func<IntPtr, IntPtr> <>9__0;
			int j;
			for (i = 0; i < num; i = j)
			{
				T value = source[i];
				Func<IntPtr, IntPtr> action;
				if ((action = <>9__0) == null)
				{
					action = (<>9__0 = delegate(IntPtr lref)
					{
						JNIEnv.SetObjectArrayElement(destination, i, lref);
						return IntPtr.Zero;
					});
				}
				JavaConvert.WithLocalJniHandle<T, IntPtr>(value, action);
				j = i + 1;
			}
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x0004D828 File Offset: 0x0004BA28
		public static IntPtr NewArray(IJavaObject[] array)
		{
			if (array == null)
			{
				return IntPtr.Zero;
			}
			IntPtr intPtr = JNIEnv.FindClass(array.GetType().GetElementType());
			IntPtr intPtr2;
			try
			{
				intPtr2 = JNIEnv.NewObjectArray(array.Length, intPtr, IntPtr.Zero);
			}
			finally
			{
				JNIEnv.DeleteGlobalRef(intPtr);
			}
			JNIEnv.CopyArray(array, intPtr2);
			return intPtr2;
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x0004D880 File Offset: 0x0004BA80
		private static Dictionary<Type, Func<Array, IntPtr>> CreateManagedToNativeArray
		{
			get
			{
				if (JNIEnv.createManagedToNativeArray != null)
				{
					return JNIEnv.createManagedToNativeArray;
				}
				Dictionary<Type, Func<Array, IntPtr>> value = JNIEnv.CreateCreateManagedToNativeArray();
				Interlocked.CompareExchange<Dictionary<Type, Func<Array, IntPtr>>>(ref JNIEnv.createManagedToNativeArray, value, null);
				return JNIEnv.createManagedToNativeArray;
			}
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x0004D8B4 File Offset: 0x0004BAB4
		private static Dictionary<Type, Func<Array, IntPtr>> CreateCreateManagedToNativeArray()
		{
			Dictionary<Type, Func<Array, IntPtr>> dictionary = new Dictionary<Type, Func<Array, IntPtr>>();
			dictionary.Add(typeof(bool), (Array source) => JNIEnv.NewArray((bool[])source));
			dictionary.Add(typeof(byte), (Array source) => JNIEnv.NewArray((byte[])source));
			dictionary.Add(typeof(char), (Array source) => JNIEnv.NewArray((char[])source));
			dictionary.Add(typeof(short), (Array source) => JNIEnv.NewArray((short[])source));
			dictionary.Add(typeof(int), (Array source) => JNIEnv.NewArray((int[])source));
			dictionary.Add(typeof(long), (Array source) => JNIEnv.NewArray((long[])source));
			dictionary.Add(typeof(float), (Array source) => JNIEnv.NewArray((float[])source));
			dictionary.Add(typeof(double), (Array source) => JNIEnv.NewArray((double[])source));
			dictionary.Add(typeof(string), (Array source) => JNIEnv.NewArray((string[])source));
			dictionary.Add(typeof(IJavaObject), (Array source) => JNIEnv.NewArray((IJavaObject[])source));
			dictionary.Add(typeof(Array), (Array source) => JNIEnv.NewArray(source, null));
			return dictionary;
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x0004DACC File Offset: 0x0004BCCC
		public static IntPtr NewArray(Array value, Type elementType = null)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (elementType == null)
			{
				elementType = value.GetType().GetElementType();
			}
			if (elementType.IsArray)
			{
				IntPtr intPtr = JNIEnv.FindClass(elementType);
				try
				{
					return JNIEnv.NewArray(value, elementType, intPtr);
				}
				finally
				{
					JNIEnv.DeleteGlobalRef(intPtr);
				}
			}
			return JNIEnv.GetConverter<Func<Array, IntPtr>>(JNIEnv.CreateManagedToNativeArray, elementType, IntPtr.Zero)(value);
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0004DB40 File Offset: 0x0004BD40
		public static IntPtr NewArray<T>(T[] array)
		{
			if (array == null)
			{
				return IntPtr.Zero;
			}
			if (typeof(T).IsArray)
			{
				IntPtr intPtr = JNIEnv.FindClass(typeof(T));
				try
				{
					return JNIEnv.NewArray(array, typeof(T), intPtr);
				}
				finally
				{
					JNIEnv.DeleteGlobalRef(intPtr);
				}
			}
			return JNIEnv.GetConverter<Func<Array, IntPtr>>(JNIEnv.CreateManagedToNativeArray, typeof(T), IntPtr.Zero)(array);
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x0004DBC4 File Offset: 0x0004BDC4
		private static IntPtr NewArray(Array value, Type elementType, IntPtr elementClass)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr intPtr = IntPtr.Zero;
			IntPtr result;
			try
			{
				intPtr = JNIEnv.NewObjectArray(value.Length, elementClass, IntPtr.Zero);
				for (int i = 0; i < value.Length; i++)
				{
					IntPtr intPtr2 = JNIEnv.NewArray((Array)value.GetValue(i), elementType.GetElementType());
					JNIEnv.SetObjectArrayElement(intPtr, i, intPtr2);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				result = intPtr;
			}
			catch
			{
				JNIEnv.DeleteLocalRef(intPtr);
				throw;
			}
			return result;
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x0004DC4C File Offset: 0x0004BE4C
		private static Dictionary<Type, Action<IntPtr, int, object>> SetNativeArrayElement
		{
			get
			{
				if (JNIEnv.setNativeArrayElement != null)
				{
					return JNIEnv.setNativeArrayElement;
				}
				Dictionary<Type, Action<IntPtr, int, object>> value = JNIEnv.CreateSetNativeArrayElement();
				Interlocked.CompareExchange<Dictionary<Type, Action<IntPtr, int, object>>>(ref JNIEnv.setNativeArrayElement, value, null);
				return JNIEnv.setNativeArrayElement;
			}
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x0004DC80 File Offset: 0x0004BE80
		private static Dictionary<Type, Action<IntPtr, int, object>> CreateSetNativeArrayElement()
		{
			Dictionary<Type, Action<IntPtr, int, object>> dictionary = new Dictionary<Type, Action<IntPtr, int, object>>();
			dictionary.Add(typeof(bool), delegate(IntPtr dest, int index, object value)
			{
				bool[] array = new bool[]
				{
					(bool)value
				};
				JNIEnv._SetBooleanArrayRegion(dest, index, array.Length, array);
			});
			dictionary.Add(typeof(byte), delegate(IntPtr dest, int index, object value)
			{
				byte[] array = new byte[]
				{
					(byte)value
				};
				JNIEnv._SetByteArrayRegion(dest, index, array.Length, array);
			});
			dictionary.Add(typeof(char), delegate(IntPtr dest, int index, object value)
			{
				char[] array = new char[]
				{
					(char)value
				};
				JNIEnv._SetCharArrayRegion(dest, index, array.Length, array);
			});
			dictionary.Add(typeof(short), delegate(IntPtr dest, int index, object value)
			{
				short[] array = new short[]
				{
					(short)value
				};
				JNIEnv._SetShortArrayRegion(dest, index, array.Length, array);
			});
			dictionary.Add(typeof(int), delegate(IntPtr dest, int index, object value)
			{
				int[] array = new int[]
				{
					(int)value
				};
				JNIEnv._SetIntArrayRegion(dest, index, array.Length, array);
			});
			dictionary.Add(typeof(long), delegate(IntPtr dest, int index, object value)
			{
				long[] array = new long[]
				{
					(long)value
				};
				JNIEnv._SetLongArrayRegion(dest, index, array.Length, array);
			});
			dictionary.Add(typeof(float), delegate(IntPtr dest, int index, object value)
			{
				float[] array = new float[]
				{
					(float)value
				};
				JNIEnv._SetFloatArrayRegion(dest, index, array.Length, array);
			});
			dictionary.Add(typeof(double), delegate(IntPtr dest, int index, object value)
			{
				double[] array = new double[]
				{
					(double)value
				};
				JNIEnv._SetDoubleArrayRegion(dest, index, array.Length, array);
			});
			dictionary.Add(typeof(string), delegate(IntPtr dest, int index, object value)
			{
				IntPtr intPtr = JNIEnv.NewString(value.ToString());
				try
				{
					JNIEnv.SetObjectArrayElement(dest, index, intPtr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			});
			dictionary.Add(typeof(IJavaObject), delegate(IntPtr dest, int index, object value)
			{
				JNIEnv.SetObjectArrayElement(dest, index, (value == null) ? IntPtr.Zero : ((IJavaObject)value).Handle);
			});
			dictionary.Add(typeof(Array), delegate(IntPtr dest, int index, object value)
			{
				IntPtr intPtr = JNIEnv.NewArray((Array)value, null);
				JNIEnv.SetObjectArrayElement(dest, index, intPtr);
				JNIEnv.DeleteLocalRef(intPtr);
			});
			return dictionary;
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0004DE98 File Offset: 0x0004C098
		private unsafe static void _SetBooleanArrayRegion(IntPtr array, int start, int length, bool[] buffer)
		{
			fixed (bool[] array2 = buffer)
			{
				bool* buffer2;
				if (buffer == null || array2.Length == 0)
				{
					buffer2 = null;
				}
				else
				{
					buffer2 = &array2[0];
				}
				JniEnvironment.Arrays.SetBooleanArrayRegion(new JniObjectReference(array, JniObjectReferenceType.Invalid), start, length, buffer2);
			}
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x0004DED0 File Offset: 0x0004C0D0
		private unsafe static void _SetByteArrayRegion(IntPtr array, int start, int length, byte[] buffer)
		{
			fixed (byte[] array2 = buffer)
			{
				byte* buffer2;
				if (buffer == null || array2.Length == 0)
				{
					buffer2 = null;
				}
				else
				{
					buffer2 = &array2[0];
				}
				JniEnvironment.Arrays.SetByteArrayRegion(new JniObjectReference(array, JniObjectReferenceType.Invalid), start, length, (sbyte*)buffer2);
			}
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x0004DF08 File Offset: 0x0004C108
		private unsafe static void _SetCharArrayRegion(IntPtr array, int start, int length, char[] buffer)
		{
			fixed (char[] array2 = buffer)
			{
				char* buffer2;
				if (buffer == null || array2.Length == 0)
				{
					buffer2 = null;
				}
				else
				{
					buffer2 = &array2[0];
				}
				JniEnvironment.Arrays.SetCharArrayRegion(new JniObjectReference(array, JniObjectReferenceType.Invalid), start, length, buffer2);
			}
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x0004DF40 File Offset: 0x0004C140
		private unsafe static void _SetShortArrayRegion(IntPtr array, int start, int length, short[] buffer)
		{
			fixed (short[] array2 = buffer)
			{
				short* buffer2;
				if (buffer == null || array2.Length == 0)
				{
					buffer2 = null;
				}
				else
				{
					buffer2 = &array2[0];
				}
				JniEnvironment.Arrays.SetShortArrayRegion(new JniObjectReference(array, JniObjectReferenceType.Invalid), start, length, buffer2);
			}
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x0004DF78 File Offset: 0x0004C178
		private unsafe static void _SetIntArrayRegion(IntPtr array, int start, int length, int[] buffer)
		{
			fixed (int[] array2 = buffer)
			{
				int* buffer2;
				if (buffer == null || array2.Length == 0)
				{
					buffer2 = null;
				}
				else
				{
					buffer2 = &array2[0];
				}
				JniEnvironment.Arrays.SetIntArrayRegion(new JniObjectReference(array, JniObjectReferenceType.Invalid), start, length, buffer2);
			}
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x0004DFB0 File Offset: 0x0004C1B0
		private unsafe static void _SetLongArrayRegion(IntPtr array, int start, int length, long[] buffer)
		{
			fixed (long[] array2 = buffer)
			{
				long* buffer2;
				if (buffer == null || array2.Length == 0)
				{
					buffer2 = null;
				}
				else
				{
					buffer2 = &array2[0];
				}
				JniEnvironment.Arrays.SetLongArrayRegion(new JniObjectReference(array, JniObjectReferenceType.Invalid), start, length, buffer2);
			}
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x0004DFE8 File Offset: 0x0004C1E8
		private unsafe static void _SetFloatArrayRegion(IntPtr array, int start, int length, float[] buffer)
		{
			fixed (float[] array2 = buffer)
			{
				float* buffer2;
				if (buffer == null || array2.Length == 0)
				{
					buffer2 = null;
				}
				else
				{
					buffer2 = &array2[0];
				}
				JniEnvironment.Arrays.SetFloatArrayRegion(new JniObjectReference(array, JniObjectReferenceType.Invalid), start, length, buffer2);
			}
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x0004E020 File Offset: 0x0004C220
		private unsafe static void _SetDoubleArrayRegion(IntPtr array, int start, int length, double[] buffer)
		{
			fixed (double[] array2 = buffer)
			{
				double* buffer2;
				if (buffer == null || array2.Length == 0)
				{
					buffer2 = null;
				}
				else
				{
					buffer2 = &array2[0];
				}
				JniEnvironment.Arrays.SetDoubleArrayRegion(new JniObjectReference(array, JniObjectReferenceType.Invalid), start, length, buffer2);
			}
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x0004E058 File Offset: 0x0004C258
		public static void SetArrayItem<T>(IntPtr array_ptr, int index, T value)
		{
			if (array_ptr == IntPtr.Zero)
			{
				throw new ArgumentException("array_ptr");
			}
			if (index < 0 || index >= JNIEnv.GetArrayLength(array_ptr))
			{
				throw new ArgumentOutOfRangeException("index");
			}
			JNIEnv.GetConverter<Action<IntPtr, int, object>>(JNIEnv.SetNativeArrayElement, typeof(T), array_ptr)(array_ptr, index, value);
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x0004E0B8 File Offset: 0x0004C2B8
		public static Java.Lang.Object[] ToObjectArray<T>(T[] array)
		{
			if (array == null)
			{
				return null;
			}
			Java.Lang.Object[] array2 = new Java.Lang.Object[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = JavaConvert.ToJavaObject<T>(array[i]).JavaCast<Java.Lang.Object>();
			}
			return array2;
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x0004E0F8 File Offset: 0x0004C2F8
		public unsafe static void CopyArray(IntPtr src, uint[] dest)
		{
			if (src == IntPtr.Zero)
			{
				return;
			}
			fixed (uint[] array = dest)
			{
				uint* buffer;
				if (dest == null || array.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array[0];
				}
				JniEnvironment.Arrays.GetIntArrayRegion(new JniObjectReference(src, JniObjectReferenceType.Invalid), 0, dest.Length, (int*)buffer);
			}
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x0004E140 File Offset: 0x0004C340
		public unsafe static void CopyArray(IntPtr src, ushort[] dest)
		{
			if (src == IntPtr.Zero)
			{
				return;
			}
			fixed (ushort[] array = dest)
			{
				ushort* buffer;
				if (dest == null || array.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array[0];
				}
				JniEnvironment.Arrays.GetShortArrayRegion(new JniObjectReference(src, JniObjectReferenceType.Invalid), 0, dest.Length, (short*)buffer);
			}
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x0004E188 File Offset: 0x0004C388
		public unsafe static void CopyArray(IntPtr src, ulong[] dest)
		{
			if (src == IntPtr.Zero)
			{
				return;
			}
			fixed (ulong[] array = dest)
			{
				ulong* buffer;
				if (dest == null || array.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array[0];
				}
				JniEnvironment.Arrays.GetLongArrayRegion(new JniObjectReference(src, JniObjectReferenceType.Invalid), 0, dest.Length, (long*)buffer);
			}
		}

		// Token: 0x06001C8F RID: 7311
		[DllImport("libjnigraphics.so")]
		private static extern int AndroidBitmap_getInfo(IntPtr env, IntPtr jbitmap, out AndroidBitmapInfo info);

		// Token: 0x06001C90 RID: 7312
		[DllImport("libjnigraphics.so")]
		private static extern int AndroidBitmap_lockPixels(IntPtr env, IntPtr jbitmap, out IntPtr addrPtr);

		// Token: 0x06001C91 RID: 7313
		[DllImport("libjnigraphics.so")]
		private static extern int AndroidBitmap_unlockPixels(IntPtr env, IntPtr jbitmap);

		// Token: 0x06001C92 RID: 7314 RVA: 0x0004E1CE File Offset: 0x0004C3CE
		internal static int AndroidBitmap_getInfo(IntPtr jbitmap, out AndroidBitmapInfo info)
		{
			return JNIEnv.AndroidBitmap_getInfo(JNIEnv.Handle, jbitmap, out info);
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x0004E1DC File Offset: 0x0004C3DC
		internal static int AndroidBitmap_lockPixels(IntPtr jbitmap, out IntPtr addrPtr)
		{
			return JNIEnv.AndroidBitmap_lockPixels(JNIEnv.Handle, jbitmap, out addrPtr);
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x0004E1EA File Offset: 0x0004C3EA
		internal static int AndroidBitmap_unlockPixels(IntPtr jbitmap)
		{
			return JNIEnv.AndroidBitmap_unlockPixels(JNIEnv.Handle, jbitmap);
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x0004E1F8 File Offset: 0x0004C3F8
		internal static IntPtr _FindClass(string classname)
		{
			return JniEnvironment.Types.FindClass(classname).Handle;
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0004E214 File Offset: 0x0004C414
		public static IntPtr GetSuperclass(IntPtr jclass)
		{
			return JniEnvironment.Types.GetSuperclass(new JniObjectReference(jclass, JniObjectReferenceType.Invalid)).Handle;
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x0004E235 File Offset: 0x0004C435
		public static bool IsAssignableFrom(IntPtr clazz1, IntPtr clazz2)
		{
			return JniEnvironment.Types.IsAssignableFrom(new JniObjectReference(clazz1, JniObjectReferenceType.Invalid), new JniObjectReference(clazz2, JniObjectReferenceType.Invalid));
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x0004E24C File Offset: 0x0004C44C
		public static IntPtr ExceptionOccurred()
		{
			return JniEnvironment.Exceptions.ExceptionOccurred().Handle;
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x0004E266 File Offset: 0x0004C466
		public static void ExceptionDescribe()
		{
			JniEnvironment.Exceptions.ExceptionDescribe();
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0004E26D File Offset: 0x0004C46D
		public static void ExceptionClear()
		{
			JniEnvironment.Exceptions.ExceptionClear();
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0004E274 File Offset: 0x0004C474
		public static IntPtr PopLocalFrame(IntPtr result)
		{
			return JniEnvironment.References.PopLocalFrame(new JniObjectReference(result, JniObjectReferenceType.Invalid)).Handle;
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x0004E295 File Offset: 0x0004C495
		public static bool IsSameObject(IntPtr ref1, IntPtr ref2)
		{
			return JniEnvironment.Types.IsSameObject(new JniObjectReference(ref1, JniObjectReferenceType.Invalid), new JniObjectReference(ref2, JniObjectReferenceType.Invalid));
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x0004E2AC File Offset: 0x0004C4AC
		public static IntPtr AllocObject(IntPtr jclass)
		{
			return JniEnvironment.Object.AllocObject(new JniObjectReference(jclass, JniObjectReferenceType.Invalid)).Handle;
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0004E2D0 File Offset: 0x0004C4D0
		public static IntPtr GetObjectClass(IntPtr jobject)
		{
			return JniEnvironment.Types.GetObjectClass(new JniObjectReference(jobject, JniObjectReferenceType.Invalid)).Handle;
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0004E2F1 File Offset: 0x0004C4F1
		public static bool IsInstanceOf(IntPtr obj, IntPtr clazz)
		{
			return JniEnvironment.Types.IsInstanceOf(new JniObjectReference(obj, JniObjectReferenceType.Invalid), new JniObjectReference(clazz, JniObjectReferenceType.Invalid));
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0004E306 File Offset: 0x0004C506
		public static IntPtr GetMethodID(IntPtr kls, string name, string signature)
		{
			return JniEnvironment.InstanceMethods.GetMethodID(new JniObjectReference(kls, JniObjectReferenceType.Invalid), name, signature).ID;
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x0004E31C File Offset: 0x0004C51C
		public static IntPtr CallObjectMethod(IntPtr jobject, IntPtr jmethod)
		{
			return JniEnvironment.InstanceMethods.CallObjectMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false)).Handle;
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x0004E344 File Offset: 0x0004C544
		public unsafe static IntPtr CallObjectMethod(IntPtr jobject, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.InstanceMethods.CallObjectMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms).Handle;
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x0004E370 File Offset: 0x0004C570
		public unsafe static IntPtr CallObjectMethod(IntPtr jobject, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallObjectMethod(jobject, jmethod, parms2);
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x0004E39D File Offset: 0x0004C59D
		public static bool CallBooleanMethod(IntPtr jobject, IntPtr jmethod)
		{
			return JniEnvironment.InstanceMethods.CallBooleanMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false));
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x0004E3B2 File Offset: 0x0004C5B2
		public unsafe static bool CallBooleanMethod(IntPtr jobject, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.InstanceMethods.CallBooleanMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x0004E3C8 File Offset: 0x0004C5C8
		public unsafe static bool CallBooleanMethod(IntPtr jobject, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallBooleanMethod(jobject, jmethod, parms2);
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x0004E3F5 File Offset: 0x0004C5F5
		public static sbyte CallByteMethod(IntPtr jobject, IntPtr jmethod)
		{
			return JniEnvironment.InstanceMethods.CallByteMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false));
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x0004E40A File Offset: 0x0004C60A
		public unsafe static sbyte CallByteMethod(IntPtr jobject, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.InstanceMethods.CallByteMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x0004E420 File Offset: 0x0004C620
		public unsafe static sbyte CallByteMethod(IntPtr jobject, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallByteMethod(jobject, jmethod, parms2);
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x0004E44D File Offset: 0x0004C64D
		public static char CallCharMethod(IntPtr jobject, IntPtr jmethod)
		{
			return JniEnvironment.InstanceMethods.CallCharMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false));
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x0004E462 File Offset: 0x0004C662
		public unsafe static char CallCharMethod(IntPtr jobject, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.InstanceMethods.CallCharMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x0004E478 File Offset: 0x0004C678
		public unsafe static char CallCharMethod(IntPtr jobject, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallCharMethod(jobject, jmethod, parms2);
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x0004E4A5 File Offset: 0x0004C6A5
		public static short CallShortMethod(IntPtr jobject, IntPtr jmethod)
		{
			return JniEnvironment.InstanceMethods.CallShortMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false));
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x0004E4BA File Offset: 0x0004C6BA
		public unsafe static short CallShortMethod(IntPtr jobject, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.InstanceMethods.CallShortMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x0004E4D0 File Offset: 0x0004C6D0
		public unsafe static short CallShortMethod(IntPtr jobject, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallShortMethod(jobject, jmethod, parms2);
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x0004E4FD File Offset: 0x0004C6FD
		public static int CallIntMethod(IntPtr jobject, IntPtr jmethod)
		{
			return JniEnvironment.InstanceMethods.CallIntMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false));
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x0004E512 File Offset: 0x0004C712
		public unsafe static int CallIntMethod(IntPtr jobject, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.InstanceMethods.CallIntMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x0004E528 File Offset: 0x0004C728
		public unsafe static int CallIntMethod(IntPtr jobject, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallIntMethod(jobject, jmethod, parms2);
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x0004E555 File Offset: 0x0004C755
		public static long CallLongMethod(IntPtr jobject, IntPtr jmethod)
		{
			return JniEnvironment.InstanceMethods.CallLongMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false));
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x0004E56A File Offset: 0x0004C76A
		public unsafe static long CallLongMethod(IntPtr jobject, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.InstanceMethods.CallLongMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0004E580 File Offset: 0x0004C780
		public unsafe static long CallLongMethod(IntPtr jobject, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallLongMethod(jobject, jmethod, parms2);
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x0004E5AD File Offset: 0x0004C7AD
		public static float CallFloatMethod(IntPtr jobject, IntPtr jmethod)
		{
			return JniEnvironment.InstanceMethods.CallFloatMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false));
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x0004E5C2 File Offset: 0x0004C7C2
		public unsafe static float CallFloatMethod(IntPtr jobject, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.InstanceMethods.CallFloatMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x0004E5D8 File Offset: 0x0004C7D8
		public unsafe static float CallFloatMethod(IntPtr jobject, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallFloatMethod(jobject, jmethod, parms2);
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x0004E605 File Offset: 0x0004C805
		public static double CallDoubleMethod(IntPtr jobject, IntPtr jmethod)
		{
			return JniEnvironment.InstanceMethods.CallDoubleMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false));
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x0004E61A File Offset: 0x0004C81A
		public unsafe static double CallDoubleMethod(IntPtr jobject, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.InstanceMethods.CallDoubleMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x0004E630 File Offset: 0x0004C830
		public unsafe static double CallDoubleMethod(IntPtr jobject, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallDoubleMethod(jobject, jmethod, parms2);
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x0004E65D File Offset: 0x0004C85D
		public static void CallVoidMethod(IntPtr jobject, IntPtr jmethod)
		{
			JniEnvironment.InstanceMethods.CallVoidMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false));
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x0004E672 File Offset: 0x0004C872
		public unsafe static void CallVoidMethod(IntPtr jobject, IntPtr jmethod, JValue* parms)
		{
			JniEnvironment.InstanceMethods.CallVoidMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x0004E688 File Offset: 0x0004C888
		public unsafe static void CallVoidMethod(IntPtr jobject, IntPtr jmethod, params JValue[] parms)
		{
			fixed (JValue[] array = parms)
			{
				JValue* parms2;
				if (parms == null || array.Length == 0)
				{
					parms2 = null;
				}
				else
				{
					parms2 = &array[0];
				}
				JNIEnv.CallVoidMethod(jobject, jmethod, parms2);
			}
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x0004E6B8 File Offset: 0x0004C8B8
		public static IntPtr CallNonvirtualObjectMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.InstanceMethods.CallNonvirtualObjectMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false)).Handle;
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x0004E6E8 File Offset: 0x0004C8E8
		public unsafe static IntPtr CallNonvirtualObjectMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.InstanceMethods.CallNonvirtualObjectMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms).Handle;
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x0004E718 File Offset: 0x0004C918
		public unsafe static IntPtr CallNonvirtualObjectMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallNonvirtualObjectMethod(jobject, jclass, jmethod, parms2);
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x0004E746 File Offset: 0x0004C946
		public static bool CallNonvirtualBooleanMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.InstanceMethods.CallNonvirtualBooleanMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false));
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x0004E762 File Offset: 0x0004C962
		public unsafe static bool CallNonvirtualBooleanMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.InstanceMethods.CallNonvirtualBooleanMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x0004E780 File Offset: 0x0004C980
		public unsafe static bool CallNonvirtualBooleanMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallNonvirtualBooleanMethod(jobject, jclass, jmethod, parms2);
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x0004E7AE File Offset: 0x0004C9AE
		public static sbyte CallNonvirtualByteMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.InstanceMethods.CallNonvirtualByteMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false));
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x0004E7CA File Offset: 0x0004C9CA
		public unsafe static sbyte CallNonvirtualByteMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.InstanceMethods.CallNonvirtualByteMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x0004E7E8 File Offset: 0x0004C9E8
		public unsafe static sbyte CallNonvirtualByteMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallNonvirtualByteMethod(jobject, jclass, jmethod, parms2);
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x0004E816 File Offset: 0x0004CA16
		public static char CallNonvirtualCharMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.InstanceMethods.CallNonvirtualCharMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false));
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x0004E832 File Offset: 0x0004CA32
		public unsafe static char CallNonvirtualCharMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.InstanceMethods.CallNonvirtualCharMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x0004E850 File Offset: 0x0004CA50
		public unsafe static char CallNonvirtualCharMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallNonvirtualCharMethod(jobject, jclass, jmethod, parms2);
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x0004E87E File Offset: 0x0004CA7E
		public static short CallNonvirtualShortMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.InstanceMethods.CallNonvirtualShortMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false));
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x0004E89A File Offset: 0x0004CA9A
		public unsafe static short CallNonvirtualShortMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.InstanceMethods.CallNonvirtualShortMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x0004E8B8 File Offset: 0x0004CAB8
		public unsafe static short CallNonvirtualShortMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallNonvirtualShortMethod(jobject, jclass, jmethod, parms2);
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x0004E8E6 File Offset: 0x0004CAE6
		public static int CallNonvirtualIntMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.InstanceMethods.CallNonvirtualIntMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false));
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x0004E902 File Offset: 0x0004CB02
		public unsafe static int CallNonvirtualIntMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.InstanceMethods.CallNonvirtualIntMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x0004E920 File Offset: 0x0004CB20
		public unsafe static int CallNonvirtualIntMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallNonvirtualIntMethod(jobject, jclass, jmethod, parms2);
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x0004E94E File Offset: 0x0004CB4E
		public static long CallNonvirtualLongMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.InstanceMethods.CallNonvirtualLongMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false));
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0004E96A File Offset: 0x0004CB6A
		public unsafe static long CallNonvirtualLongMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.InstanceMethods.CallNonvirtualLongMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x0004E988 File Offset: 0x0004CB88
		public unsafe static long CallNonvirtualLongMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallNonvirtualLongMethod(jobject, jclass, jmethod, parms2);
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x0004E9B6 File Offset: 0x0004CBB6
		public static float CallNonvirtualFloatMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.InstanceMethods.CallNonvirtualFloatMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false));
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x0004E9D2 File Offset: 0x0004CBD2
		public unsafe static float CallNonvirtualFloatMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.InstanceMethods.CallNonvirtualFloatMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0004E9F0 File Offset: 0x0004CBF0
		public unsafe static float CallNonvirtualFloatMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallNonvirtualFloatMethod(jobject, jclass, jmethod, parms2);
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x0004EA1E File Offset: 0x0004CC1E
		public static double CallNonvirtualDoubleMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.InstanceMethods.CallNonvirtualDoubleMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false));
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x0004EA3A File Offset: 0x0004CC3A
		public unsafe static double CallNonvirtualDoubleMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.InstanceMethods.CallNonvirtualDoubleMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x0004EA58 File Offset: 0x0004CC58
		public unsafe static double CallNonvirtualDoubleMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallNonvirtualDoubleMethod(jobject, jclass, jmethod, parms2);
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x0004EA86 File Offset: 0x0004CC86
		public static void CallNonvirtualVoidMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod)
		{
			JniEnvironment.InstanceMethods.CallNonvirtualVoidMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false));
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x0004EAA2 File Offset: 0x0004CCA2
		public unsafe static void CallNonvirtualVoidMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			JniEnvironment.InstanceMethods.CallNonvirtualVoidMethod(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, false), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x0004EAC0 File Offset: 0x0004CCC0
		public unsafe static void CallNonvirtualVoidMethod(IntPtr jobject, IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			fixed (JValue[] array = parms)
			{
				JValue* parms2;
				if (parms == null || array.Length == 0)
				{
					parms2 = null;
				}
				else
				{
					parms2 = &array[0];
				}
				JNIEnv.CallNonvirtualVoidMethod(jobject, jclass, jmethod, parms2);
			}
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x0004EAF0 File Offset: 0x0004CCF0
		public static IntPtr GetFieldID(IntPtr jclass, string name, string sig)
		{
			return JniEnvironment.InstanceFields.GetFieldID(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), name, sig).ID;
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x0004EB08 File Offset: 0x0004CD08
		public static IntPtr GetObjectField(IntPtr jobject, IntPtr jfieldID)
		{
			return JniEnvironment.InstanceFields.GetObjectField(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, false)).Handle;
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x0004EB30 File Offset: 0x0004CD30
		public static bool GetBooleanField(IntPtr jobject, IntPtr jfieldID)
		{
			return JniEnvironment.InstanceFields.GetBooleanField(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, false));
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x0004EB45 File Offset: 0x0004CD45
		public static sbyte GetByteField(IntPtr jobject, IntPtr jfieldID)
		{
			return JniEnvironment.InstanceFields.GetByteField(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, false));
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x0004EB5A File Offset: 0x0004CD5A
		public static char GetCharField(IntPtr jobject, IntPtr jfieldID)
		{
			return JniEnvironment.InstanceFields.GetCharField(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, false));
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x0004EB6F File Offset: 0x0004CD6F
		public static short GetShortField(IntPtr jobject, IntPtr jfieldID)
		{
			return JniEnvironment.InstanceFields.GetShortField(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, false));
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x0004EB84 File Offset: 0x0004CD84
		public static int GetIntField(IntPtr jobject, IntPtr jfieldID)
		{
			return JniEnvironment.InstanceFields.GetIntField(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, false));
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x0004EB99 File Offset: 0x0004CD99
		public static long GetLongField(IntPtr jobject, IntPtr jfieldID)
		{
			return JniEnvironment.InstanceFields.GetLongField(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, false));
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x0004EBAE File Offset: 0x0004CDAE
		public static float GetFloatField(IntPtr jobject, IntPtr jfieldID)
		{
			return JniEnvironment.InstanceFields.GetFloatField(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, false));
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x0004EBC3 File Offset: 0x0004CDC3
		public static double GetDoubleField(IntPtr jobject, IntPtr jfieldID)
		{
			return JniEnvironment.InstanceFields.GetDoubleField(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, false));
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x0004EBD8 File Offset: 0x0004CDD8
		public static void SetField(IntPtr jobject, IntPtr jfieldID, IntPtr val)
		{
			JniEnvironment.InstanceFields.SetObjectField(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, false), new JniObjectReference(val, JniObjectReferenceType.Invalid));
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x0004EBF4 File Offset: 0x0004CDF4
		public static void SetField(IntPtr jobject, IntPtr jfieldID, bool val)
		{
			JniEnvironment.InstanceFields.SetBooleanField(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, false), val);
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0004EC0A File Offset: 0x0004CE0A
		public static void SetField(IntPtr jobject, IntPtr jfieldID, sbyte val)
		{
			JniEnvironment.InstanceFields.SetByteField(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, false), val);
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x0004EC20 File Offset: 0x0004CE20
		public static void SetField(IntPtr jobject, IntPtr jfieldID, char val)
		{
			JniEnvironment.InstanceFields.SetCharField(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, false), val);
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x0004EC36 File Offset: 0x0004CE36
		public static void SetField(IntPtr jobject, IntPtr jfieldID, short val)
		{
			JniEnvironment.InstanceFields.SetShortField(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, false), val);
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x0004EC4C File Offset: 0x0004CE4C
		public static void SetField(IntPtr jobject, IntPtr jfieldID, int val)
		{
			JniEnvironment.InstanceFields.SetIntField(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, false), val);
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x0004EC62 File Offset: 0x0004CE62
		public static void SetField(IntPtr jobject, IntPtr jfieldID, long val)
		{
			JniEnvironment.InstanceFields.SetLongField(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, false), val);
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x0004EC78 File Offset: 0x0004CE78
		public static void SetField(IntPtr jobject, IntPtr jfieldID, float val)
		{
			JniEnvironment.InstanceFields.SetFloatField(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, false), val);
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0004EC8E File Offset: 0x0004CE8E
		public static void SetField(IntPtr jobject, IntPtr jfieldID, double val)
		{
			JniEnvironment.InstanceFields.SetDoubleField(new JniObjectReference(jobject, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, false), val);
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x0004ECA4 File Offset: 0x0004CEA4
		public static IntPtr GetStaticMethodID(IntPtr jclass, string name, string sig)
		{
			return JniEnvironment.StaticMethods.GetStaticMethodID(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), name, sig).ID;
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x0004ECBC File Offset: 0x0004CEBC
		public static IntPtr CallStaticObjectMethod(IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.StaticMethods.CallStaticObjectMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true)).Handle;
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x0004ECE4 File Offset: 0x0004CEE4
		public unsafe static IntPtr CallStaticObjectMethod(IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.StaticMethods.CallStaticObjectMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true), (JniArgumentValue*)parms).Handle;
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x0004ED10 File Offset: 0x0004CF10
		public unsafe static IntPtr CallStaticObjectMethod(IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallStaticObjectMethod(jclass, jmethod, parms2);
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x0004ED3D File Offset: 0x0004CF3D
		public static bool CallStaticBooleanMethod(IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.StaticMethods.CallStaticBooleanMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true));
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x0004ED52 File Offset: 0x0004CF52
		public unsafe static bool CallStaticBooleanMethod(IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.StaticMethods.CallStaticBooleanMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x0004ED68 File Offset: 0x0004CF68
		public unsafe static bool CallStaticBooleanMethod(IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallStaticBooleanMethod(jclass, jmethod, parms2);
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x0004ED95 File Offset: 0x0004CF95
		public static sbyte CallStaticByteMethod(IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.StaticMethods.CallStaticByteMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true));
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x0004EDAA File Offset: 0x0004CFAA
		public unsafe static sbyte CallStaticByteMethod(IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.StaticMethods.CallStaticByteMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x0004EDC0 File Offset: 0x0004CFC0
		public unsafe static sbyte CallStaticByteMethod(IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallStaticByteMethod(jclass, jmethod, parms2);
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x0004EDED File Offset: 0x0004CFED
		public static char CallStaticCharMethod(IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.StaticMethods.CallStaticCharMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true));
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x0004EE02 File Offset: 0x0004D002
		public unsafe static char CallStaticCharMethod(IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.StaticMethods.CallStaticCharMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x0004EE18 File Offset: 0x0004D018
		public unsafe static char CallStaticCharMethod(IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallStaticCharMethod(jclass, jmethod, parms2);
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x0004EE45 File Offset: 0x0004D045
		public static short CallStaticShortMethod(IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.StaticMethods.CallStaticShortMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true));
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x0004EE5A File Offset: 0x0004D05A
		public unsafe static short CallStaticShortMethod(IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.StaticMethods.CallStaticShortMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true), (JniArgumentValue*)parms);
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x0004EE70 File Offset: 0x0004D070
		public unsafe static short CallStaticShortMethod(IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallStaticShortMethod(jclass, jmethod, parms2);
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x0004EE9D File Offset: 0x0004D09D
		public static int CallStaticIntMethod(IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.StaticMethods.CallStaticIntMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true));
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x0004EEB2 File Offset: 0x0004D0B2
		public unsafe static int CallStaticIntMethod(IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.StaticMethods.CallStaticIntMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true), (JniArgumentValue*)parms);
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x0004EEC8 File Offset: 0x0004D0C8
		public unsafe static int CallStaticIntMethod(IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallStaticIntMethod(jclass, jmethod, parms2);
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x0004EEF5 File Offset: 0x0004D0F5
		public static long CallStaticLongMethod(IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.StaticMethods.CallStaticLongMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true));
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x0004EF0A File Offset: 0x0004D10A
		public unsafe static long CallStaticLongMethod(IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.StaticMethods.CallStaticLongMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true), (JniArgumentValue*)parms);
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x0004EF20 File Offset: 0x0004D120
		public unsafe static long CallStaticLongMethod(IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallStaticLongMethod(jclass, jmethod, parms2);
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x0004EF4D File Offset: 0x0004D14D
		public static float CallStaticFloatMethod(IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.StaticMethods.CallStaticFloatMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true));
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x0004EF62 File Offset: 0x0004D162
		public unsafe static float CallStaticFloatMethod(IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.StaticMethods.CallStaticFloatMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true), (JniArgumentValue*)parms);
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x0004EF78 File Offset: 0x0004D178
		public unsafe static float CallStaticFloatMethod(IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallStaticFloatMethod(jclass, jmethod, parms2);
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x0004EFA5 File Offset: 0x0004D1A5
		public static double CallStaticDoubleMethod(IntPtr jclass, IntPtr jmethod)
		{
			return JniEnvironment.StaticMethods.CallStaticDoubleMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true));
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x0004EFBA File Offset: 0x0004D1BA
		public unsafe static double CallStaticDoubleMethod(IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			return JniEnvironment.StaticMethods.CallStaticDoubleMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true), (JniArgumentValue*)parms);
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x0004EFD0 File Offset: 0x0004D1D0
		public unsafe static double CallStaticDoubleMethod(IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			JValue* parms2;
			if (parms == null || parms.Length == 0)
			{
				parms2 = null;
			}
			else
			{
				parms2 = &parms[0];
			}
			return JNIEnv.CallStaticDoubleMethod(jclass, jmethod, parms2);
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x0004EFFD File Offset: 0x0004D1FD
		public static void CallStaticVoidMethod(IntPtr jclass, IntPtr jmethod)
		{
			JniEnvironment.StaticMethods.CallStaticVoidMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true));
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x0004F012 File Offset: 0x0004D212
		public unsafe static void CallStaticVoidMethod(IntPtr jclass, IntPtr jmethod, JValue* parms)
		{
			JniEnvironment.StaticMethods.CallStaticVoidMethod(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniMethodInfo(jmethod, true), (JniArgumentValue*)parms);
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x0004F028 File Offset: 0x0004D228
		public unsafe static void CallStaticVoidMethod(IntPtr jclass, IntPtr jmethod, params JValue[] parms)
		{
			fixed (JValue[] array = parms)
			{
				JValue* parms2;
				if (parms == null || array.Length == 0)
				{
					parms2 = null;
				}
				else
				{
					parms2 = &array[0];
				}
				JNIEnv.CallStaticVoidMethod(jclass, jmethod, parms2);
			}
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x0004F057 File Offset: 0x0004D257
		public static IntPtr GetStaticFieldID(IntPtr jclass, string name, string sig)
		{
			return JniEnvironment.StaticFields.GetStaticFieldID(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), name, sig).ID;
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x0004F06C File Offset: 0x0004D26C
		public static IntPtr GetStaticObjectField(IntPtr jclass, IntPtr jfieldID)
		{
			return JniEnvironment.StaticFields.GetStaticObjectField(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, true)).Handle;
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x0004F094 File Offset: 0x0004D294
		public static bool GetStaticBooleanField(IntPtr jclass, IntPtr jfieldID)
		{
			return JniEnvironment.StaticFields.GetStaticBooleanField(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, true));
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x0004F0A9 File Offset: 0x0004D2A9
		public static sbyte GetStaticByteField(IntPtr jclass, IntPtr jfieldID)
		{
			return JniEnvironment.StaticFields.GetStaticByteField(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, true));
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x0004F0BE File Offset: 0x0004D2BE
		public static char GetStaticCharField(IntPtr jclass, IntPtr jfieldID)
		{
			return JniEnvironment.StaticFields.GetStaticCharField(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, true));
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x0004F0D3 File Offset: 0x0004D2D3
		public static short GetStaticShortField(IntPtr jclass, IntPtr jfieldID)
		{
			return JniEnvironment.StaticFields.GetStaticShortField(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, true));
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x0004F0E8 File Offset: 0x0004D2E8
		public static int GetStaticIntField(IntPtr jclass, IntPtr jfieldID)
		{
			return JniEnvironment.StaticFields.GetStaticIntField(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, true));
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x0004F0FD File Offset: 0x0004D2FD
		public static long GetStaticLongField(IntPtr jclass, IntPtr jfieldID)
		{
			return JniEnvironment.StaticFields.GetStaticLongField(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, true));
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x0004F112 File Offset: 0x0004D312
		public static float GetStaticFloatField(IntPtr jclass, IntPtr jfieldID)
		{
			return JniEnvironment.StaticFields.GetStaticFloatField(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, true));
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x0004F127 File Offset: 0x0004D327
		public static double GetStaticDoubleField(IntPtr jclass, IntPtr jfieldID)
		{
			return JniEnvironment.StaticFields.GetStaticDoubleField(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, true));
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x0004F13C File Offset: 0x0004D33C
		public static void SetStaticField(IntPtr jclass, IntPtr jfieldID, IntPtr val)
		{
			JniEnvironment.StaticFields.SetStaticObjectField(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, true), new JniObjectReference(val, JniObjectReferenceType.Invalid));
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x0004F158 File Offset: 0x0004D358
		public static void SetStaticField(IntPtr jclass, IntPtr jfieldID, bool val)
		{
			JniEnvironment.StaticFields.SetStaticBooleanField(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, true), val);
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x0004F16E File Offset: 0x0004D36E
		public static void SetStaticField(IntPtr jclass, IntPtr jfieldID, sbyte val)
		{
			JniEnvironment.StaticFields.SetStaticByteField(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, true), val);
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x0004F184 File Offset: 0x0004D384
		public static void SetStaticField(IntPtr jclass, IntPtr jfieldID, char val)
		{
			JniEnvironment.StaticFields.SetStaticCharField(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, true), val);
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x0004F19A File Offset: 0x0004D39A
		public static void SetStaticField(IntPtr jclass, IntPtr jfieldID, short val)
		{
			JniEnvironment.StaticFields.SetStaticShortField(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, true), val);
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x0004F1B0 File Offset: 0x0004D3B0
		public static void SetStaticField(IntPtr jclass, IntPtr jfieldID, int val)
		{
			JniEnvironment.StaticFields.SetStaticIntField(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, true), val);
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x0004F1C6 File Offset: 0x0004D3C6
		public static void SetStaticField(IntPtr jclass, IntPtr jfieldID, long val)
		{
			JniEnvironment.StaticFields.SetStaticLongField(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, true), val);
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x0004F1DC File Offset: 0x0004D3DC
		public static void SetStaticField(IntPtr jclass, IntPtr jfieldID, float val)
		{
			JniEnvironment.StaticFields.SetStaticFloatField(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, true), val);
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x0004F1F2 File Offset: 0x0004D3F2
		public static void SetStaticField(IntPtr jclass, IntPtr jfieldID, double val)
		{
			JniEnvironment.StaticFields.SetStaticDoubleField(new JniObjectReference(jclass, JniObjectReferenceType.Invalid), new JniFieldInfo(jfieldID, true), val);
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x0004F208 File Offset: 0x0004D408
		internal static int GetStringLength(IntPtr @string)
		{
			return JniEnvironment.Strings.GetStringLength(new JniObjectReference(@string, JniObjectReferenceType.Invalid));
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x0004F218 File Offset: 0x0004D418
		public static IntPtr GetObjectArrayElement(IntPtr array, int index)
		{
			return JniEnvironment.Arrays.GetObjectArrayElement(new JniObjectReference(array, JniObjectReferenceType.Invalid), index).Handle;
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x0004F23A File Offset: 0x0004D43A
		public static void SetObjectArrayElement(IntPtr array, int index, IntPtr value)
		{
			JniEnvironment.Arrays.SetObjectArrayElement(new JniObjectReference(array, JniObjectReferenceType.Invalid), index, new JniObjectReference(value, JniObjectReferenceType.Invalid));
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x0004F250 File Offset: 0x0004D450
		public static IntPtr NewArray(byte[] array)
		{
			if (array == null)
			{
				return IntPtr.Zero;
			}
			JniObjectReference jniObjectReference = JniEnvironment.Arrays.NewByteArray(array.Length);
			JNIEnv.CopyArray(array, jniObjectReference.Handle);
			return jniObjectReference.Handle;
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x0004F284 File Offset: 0x0004D484
		public static IntPtr NewArray(char[] array)
		{
			if (array == null)
			{
				return IntPtr.Zero;
			}
			JniObjectReference jniObjectReference = JniEnvironment.Arrays.NewCharArray(array.Length);
			JNIEnv.CopyArray(array, jniObjectReference.Handle);
			return jniObjectReference.Handle;
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x0004F2B8 File Offset: 0x0004D4B8
		public static IntPtr NewArray(short[] array)
		{
			if (array == null)
			{
				return IntPtr.Zero;
			}
			JniObjectReference jniObjectReference = JniEnvironment.Arrays.NewShortArray(array.Length);
			JNIEnv.CopyArray(array, jniObjectReference.Handle);
			return jniObjectReference.Handle;
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x0004F2EC File Offset: 0x0004D4EC
		public static IntPtr NewArray(int[] array)
		{
			if (array == null)
			{
				return IntPtr.Zero;
			}
			JniObjectReference jniObjectReference = JniEnvironment.Arrays.NewIntArray(array.Length);
			JNIEnv.CopyArray(array, jniObjectReference.Handle);
			return jniObjectReference.Handle;
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x0004F320 File Offset: 0x0004D520
		public static IntPtr NewArray(long[] array)
		{
			if (array == null)
			{
				return IntPtr.Zero;
			}
			JniObjectReference jniObjectReference = JniEnvironment.Arrays.NewLongArray(array.Length);
			JNIEnv.CopyArray(array, jniObjectReference.Handle);
			return jniObjectReference.Handle;
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x0004F354 File Offset: 0x0004D554
		public static IntPtr NewArray(float[] array)
		{
			if (array == null)
			{
				return IntPtr.Zero;
			}
			JniObjectReference jniObjectReference = JniEnvironment.Arrays.NewFloatArray(array.Length);
			JNIEnv.CopyArray(array, jniObjectReference.Handle);
			return jniObjectReference.Handle;
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x0004F388 File Offset: 0x0004D588
		public static IntPtr NewArray(double[] array)
		{
			if (array == null)
			{
				return IntPtr.Zero;
			}
			JniObjectReference jniObjectReference = JniEnvironment.Arrays.NewDoubleArray(array.Length);
			JNIEnv.CopyArray(array, jniObjectReference.Handle);
			return jniObjectReference.Handle;
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x0004F3BC File Offset: 0x0004D5BC
		public unsafe static void CopyArray(IntPtr src, byte[] dest)
		{
			if (src == IntPtr.Zero)
			{
				return;
			}
			fixed (byte[] array = dest)
			{
				byte* buffer;
				if (dest == null || array.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array[0];
				}
				JniEnvironment.Arrays.GetByteArrayRegion(new JniObjectReference(src, JniObjectReferenceType.Invalid), 0, dest.Length, (sbyte*)buffer);
			}
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x0004F404 File Offset: 0x0004D604
		public unsafe static void CopyArray(IntPtr src, char[] dest)
		{
			if (src == IntPtr.Zero)
			{
				return;
			}
			fixed (char[] array = dest)
			{
				char* buffer;
				if (dest == null || array.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array[0];
				}
				JniEnvironment.Arrays.GetCharArrayRegion(new JniObjectReference(src, JniObjectReferenceType.Invalid), 0, dest.Length, buffer);
			}
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x0004F44C File Offset: 0x0004D64C
		public unsafe static void CopyArray(IntPtr src, short[] dest)
		{
			if (src == IntPtr.Zero)
			{
				return;
			}
			fixed (short[] array = dest)
			{
				short* buffer;
				if (dest == null || array.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array[0];
				}
				JniEnvironment.Arrays.GetShortArrayRegion(new JniObjectReference(src, JniObjectReferenceType.Invalid), 0, dest.Length, buffer);
			}
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x0004F494 File Offset: 0x0004D694
		public unsafe static void CopyArray(IntPtr src, int[] dest)
		{
			if (src == IntPtr.Zero)
			{
				return;
			}
			fixed (int[] array = dest)
			{
				int* buffer;
				if (dest == null || array.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array[0];
				}
				JniEnvironment.Arrays.GetIntArrayRegion(new JniObjectReference(src, JniObjectReferenceType.Invalid), 0, dest.Length, buffer);
			}
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x0004F4DC File Offset: 0x0004D6DC
		public unsafe static void CopyArray(IntPtr src, long[] dest)
		{
			if (src == IntPtr.Zero)
			{
				return;
			}
			fixed (long[] array = dest)
			{
				long* buffer;
				if (dest == null || array.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array[0];
				}
				JniEnvironment.Arrays.GetLongArrayRegion(new JniObjectReference(src, JniObjectReferenceType.Invalid), 0, dest.Length, buffer);
			}
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x0004F524 File Offset: 0x0004D724
		public unsafe static void CopyArray(IntPtr src, float[] dest)
		{
			if (src == IntPtr.Zero)
			{
				return;
			}
			fixed (float[] array = dest)
			{
				float* buffer;
				if (dest == null || array.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array[0];
				}
				JniEnvironment.Arrays.GetFloatArrayRegion(new JniObjectReference(src, JniObjectReferenceType.Invalid), 0, dest.Length, buffer);
			}
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x0004F56C File Offset: 0x0004D76C
		public unsafe static void CopyArray(IntPtr src, double[] dest)
		{
			if (src == IntPtr.Zero)
			{
				return;
			}
			fixed (double[] array = dest)
			{
				double* buffer;
				if (dest == null || array.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array[0];
				}
				JniEnvironment.Arrays.GetDoubleArrayRegion(new JniObjectReference(src, JniObjectReferenceType.Invalid), 0, dest.Length, buffer);
			}
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x0004F5B4 File Offset: 0x0004D7B4
		public unsafe static void CopyArray(byte[] src, IntPtr dest)
		{
			if (src == null)
			{
				throw new ArgumentNullException("src");
			}
			fixed (byte[] array = src)
			{
				byte* buffer;
				if (src == null || array.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array[0];
				}
				JniEnvironment.Arrays.SetByteArrayRegion(new JniObjectReference(dest, JniObjectReferenceType.Invalid), 0, src.Length, (sbyte*)buffer);
			}
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x0004F5FC File Offset: 0x0004D7FC
		public unsafe static void CopyArray(char[] src, IntPtr dest)
		{
			if (src == null)
			{
				throw new ArgumentNullException("src");
			}
			fixed (char[] array = src)
			{
				char* buffer;
				if (src == null || array.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array[0];
				}
				JniEnvironment.Arrays.SetCharArrayRegion(new JniObjectReference(dest, JniObjectReferenceType.Invalid), 0, src.Length, buffer);
			}
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x0004F644 File Offset: 0x0004D844
		public unsafe static void CopyArray(short[] src, IntPtr dest)
		{
			if (src == null)
			{
				throw new ArgumentNullException("src");
			}
			fixed (short[] array = src)
			{
				short* buffer;
				if (src == null || array.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array[0];
				}
				JniEnvironment.Arrays.SetShortArrayRegion(new JniObjectReference(dest, JniObjectReferenceType.Invalid), 0, src.Length, buffer);
			}
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x0004F68C File Offset: 0x0004D88C
		public unsafe static void CopyArray(int[] src, IntPtr dest)
		{
			if (src == null)
			{
				throw new ArgumentNullException("src");
			}
			fixed (int[] array = src)
			{
				int* buffer;
				if (src == null || array.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array[0];
				}
				JniEnvironment.Arrays.SetIntArrayRegion(new JniObjectReference(dest, JniObjectReferenceType.Invalid), 0, src.Length, buffer);
			}
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x0004F6D4 File Offset: 0x0004D8D4
		public unsafe static void CopyArray(long[] src, IntPtr dest)
		{
			if (src == null)
			{
				throw new ArgumentNullException("src");
			}
			fixed (long[] array = src)
			{
				long* buffer;
				if (src == null || array.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array[0];
				}
				JniEnvironment.Arrays.SetLongArrayRegion(new JniObjectReference(dest, JniObjectReferenceType.Invalid), 0, src.Length, buffer);
			}
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x0004F71C File Offset: 0x0004D91C
		public unsafe static void CopyArray(float[] src, IntPtr dest)
		{
			if (src == null)
			{
				throw new ArgumentNullException("src");
			}
			fixed (float[] array = src)
			{
				float* buffer;
				if (src == null || array.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array[0];
				}
				JniEnvironment.Arrays.SetFloatArrayRegion(new JniObjectReference(dest, JniObjectReferenceType.Invalid), 0, src.Length, buffer);
			}
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x0004F764 File Offset: 0x0004D964
		public unsafe static void CopyArray(double[] src, IntPtr dest)
		{
			if (src == null)
			{
				throw new ArgumentNullException("src");
			}
			fixed (double[] array = src)
			{
				double* buffer;
				if (src == null || array.Length == 0)
				{
					buffer = null;
				}
				else
				{
					buffer = &array[0];
				}
				JniEnvironment.Arrays.SetDoubleArrayRegion(new JniObjectReference(dest, JniObjectReferenceType.Invalid), 0, src.Length, buffer);
			}
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x0004F7AC File Offset: 0x0004D9AC
		public static IntPtr NewDirectByteBuffer(IntPtr address, long capacity)
		{
			return JniEnvironment.IO.NewDirectByteBuffer(address, capacity).Handle;
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x0004F7C8 File Offset: 0x0004D9C8
		public static IntPtr GetDirectBufferAddress(IntPtr buf)
		{
			return JniEnvironment.IO.GetDirectBufferAddress(new JniObjectReference(buf, JniObjectReferenceType.Invalid));
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x0004F7D6 File Offset: 0x0004D9D6
		public static long GetDirectBufferCapacity(IntPtr buf)
		{
			return JniEnvironment.IO.GetDirectBufferCapacity(new JniObjectReference(buf, JniObjectReferenceType.Invalid));
		}

		// Token: 0x04000BC6 RID: 3014
		[ThreadStatic]
		private static byte[] mvid_bytes;

		// Token: 0x04000BC7 RID: 3015
		private static Action<AppDomain, UnhandledExceptionEventArgs> AppDomain_DoUnhandledException;

		// Token: 0x04000BC8 RID: 3016
		private const int nameBufferLength = 1024;

		// Token: 0x04000BC9 RID: 3017
		[ThreadStatic]
		private static char[] nameBuffer;

		// Token: 0x04000BCA RID: 3018
		private static Dictionary<Type, Func<Type, IntPtr, int, object>> nativeArrayElementToManaged;

		// Token: 0x04000BCB RID: 3019
		private static Dictionary<Type, Action<Array, IntPtr>> copyManagedToNativeArray;

		// Token: 0x04000BCC RID: 3020
		private static Dictionary<Type, Func<Type, IntPtr, int, Array>> nativeArrayToManaged;

		// Token: 0x04000BCD RID: 3021
		private static Dictionary<Type, Func<Array, IntPtr>> createManagedToNativeArray;

		// Token: 0x04000BCE RID: 3022
		private static Dictionary<Type, Action<IntPtr, int, object>> setNativeArrayElement;
	}
}
