using System;
using Java.Interop;

namespace Android.Runtime
{
	// Token: 0x020002BA RID: 698
	internal class AndroidRuntimeOptions : JniRuntime.CreationOptions
	{
		// Token: 0x06001AA8 RID: 6824 RVA: 0x00045188 File Offset: 0x00043388
		public AndroidRuntimeOptions(IntPtr jnienv, IntPtr vm, bool allocNewObjectSupported, IntPtr classLoader, IntPtr classLoader_loadClass, bool jniAddNativeMethodRegistrationAttributePresent)
		{
			base.EnvironmentPointer = jnienv;
			base.ClassLoader = new JniObjectReference(classLoader, JniObjectReferenceType.Global);
			base.ClassLoader_LoadClass_id = classLoader_loadClass;
			base.InvocationPointer = vm;
			base.NewObjectRequired = !allocNewObjectSupported;
			base.ObjectReferenceManager = new AndroidObjectReferenceManager();
			base.TypeManager = new AndroidTypeManager(jniAddNativeMethodRegistrationAttributePresent);
			base.ValueManager = new AndroidValueManager();
			base.UseMarshalMemberBuilder = false;
			base.JniAddNativeMethodRegistrationAttributePresent = jniAddNativeMethodRegistrationAttributePresent;
		}
	}
}
