using System;
using Java.Interop;
using Java.Lang;

namespace Android.Runtime
{
	// Token: 0x020002B9 RID: 697
	internal class AndroidRuntime : JniRuntime
	{
		// Token: 0x06001AA5 RID: 6821 RVA: 0x000450CF File Offset: 0x000432CF
		internal AndroidRuntime(IntPtr jnienv, IntPtr vm, bool allocNewObjectSupported, IntPtr classLoader, IntPtr classLoader_loadClass, bool jniAddNativeMethodRegistrationAttributePresent) : base(new AndroidRuntimeOptions(jnienv, vm, allocNewObjectSupported, classLoader, classLoader_loadClass, jniAddNativeMethodRegistrationAttributePresent))
		{
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x000450E8 File Offset: 0x000432E8
		public override System.Exception GetExceptionForThrowable(ref JniObjectReference reference, JniObjectReferenceOptions options)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			AndroidValueManager androidValueManager = JNIEnvInit.AndroidValueManager;
			IJavaPeerable javaPeerable = (androidValueManager != null) ? androidValueManager.PeekPeer(reference) : null;
			System.Exception ex = javaPeerable as System.Exception;
			if (ex == null)
			{
				System.Exception @object = Java.Lang.Object.GetObject<Throwable>(reference.Handle, JniHandleOwnership.DoNotTransfer);
				JniObjectReference.Dispose(ref reference, options);
				return @object;
			}
			JniObjectReference.Dispose(ref reference, options);
			AndroidValueManager androidValueManager2 = JNIEnvInit.AndroidValueManager;
			System.Exception ex2 = (androidValueManager2 != null) ? androidValueManager2.UnboxException(javaPeerable) : null;
			if (ex2 != null)
			{
				return ex2;
			}
			return ex;
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00045158 File Offset: 0x00043358
		public override void RaisePendingException(System.Exception pendingException)
		{
			JavaProxyThrowable javaProxyThrowable = pendingException as JavaProxyThrowable;
			if (javaProxyThrowable == null)
			{
				javaProxyThrowable = new JavaProxyThrowable(pendingException);
			}
			JniEnvironment.Exceptions.Throw(new JniObjectReference(javaProxyThrowable.Handle, JniObjectReferenceType.Invalid));
		}
	}
}
