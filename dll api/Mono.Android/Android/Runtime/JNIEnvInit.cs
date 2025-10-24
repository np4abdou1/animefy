using System;
using Java.Interop;
using Java.Interop.Tools.TypeNameMappings;
using Mono;

namespace Android.Runtime
{
	// Token: 0x020002E5 RID: 741
	internal static class JNIEnvInit
	{
		// Token: 0x06001D7D RID: 7549 RVA: 0x0004FF08 File Offset: 0x0004E108
		private unsafe static void RegisterJniNatives(IntPtr typeName_ptr, int typeName_len, IntPtr jniClass, IntPtr methods_ptr, int methods_len)
		{
			string text = new string((char*)((void*)typeName_ptr), 0, typeName_len);
			Type type = Type.GetType(text);
			if (type == null)
			{
				RuntimeNativeMethods.monodroid_log(LogLevel.Error, LogCategories.Default, string.Concat(new string[]
				{
					"Could not load type '",
					text,
					"'. Skipping JNI registration of type '",
					TypeManager.GetClassName(jniClass),
					"'."
				}));
				return;
			}
			string className = TypeManager.GetClassName(jniClass);
			TypeManager.RegisterType(className, type);
			JniType nativeClass = null;
			JniType.GetCachedJniType(ref nativeClass, className);
			ReadOnlySpan<char> methods = new ReadOnlySpan<char>((void*)methods_ptr, methods_len);
			((AndroidTypeManager)JNIEnvInit.androidRuntime.TypeManager).RegisterNativeMembers(nativeClass, type, methods);
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x0004FFAC File Offset: 0x0004E1AC
		internal unsafe static void Initialize(JNIEnvInit.JnienvInitializeArgs* args)
		{
			IntPtr zero = IntPtr.Zero;
			IntPtr zero2 = IntPtr.Zero;
			JNIEnvInit.LogAssemblyCategory = ((args->logCategories & 2U) > 0U);
			JNIEnvInit.gref_gc_threshold = args->grefGcThreshold;
			JNIEnvInit.jniRemappingInUse = args->jniRemappingInUse;
			JNIEnvInit.java_class_loader = args->grefLoader;
			JNIEnvInit.mid_Class_forName = new JniMethodInfo(args->Class_forName, true);
			JNIEnvInit.LocalRefsAreIndirect = (args->localRefsAreIndirect == 1);
			SystemDependencyProvider.Initialize();
			bool flag = args->androidSdkVersion > 10;
			JNIEnvInit.BoundExceptionType = (BoundExceptionType)args->ioExceptionType;
			JNIEnvInit.androidRuntime = new AndroidRuntime(args->env, args->javaVm, flag, args->grefLoader, args->Loader_loadClass, args->jniAddNativeMethodRegistrationAttributePresent != 0);
			JNIEnvInit.AndroidValueManager = (AndroidValueManager)JNIEnvInit.androidRuntime.ValueManager;
			JNIEnvInit.AllocObjectSupported = flag;
			JNIEnvInit.IsRunningOnDesktop = (args->isRunningOnDesktop == 1);
			JNIEnvInit.grefIGCUserPeer_class = args->grefIGCUserPeer;
			JNIEnvInit.PropagateExceptions = (args->brokenExceptionTransitions == 0);
			JavaNativeTypeManager.PackageNamingPolicy = (PackageNamingPolicy)args->packageNamingPolicy;
			PackageNamingPolicy packageNamingPolicy;
			if (JNIEnvInit.IsRunningOnDesktop && Enum.TryParse<PackageNamingPolicy>(Environment.GetEnvironmentVariable("__XA_PACKAGE_NAMING_POLICY__"), out packageNamingPolicy))
			{
				JavaNativeTypeManager.PackageNamingPolicy = packageNamingPolicy;
			}
		}

		// Token: 0x04000C10 RID: 3088
		internal static AndroidValueManager AndroidValueManager;

		// Token: 0x04000C11 RID: 3089
		internal static bool AllocObjectSupported;

		// Token: 0x04000C12 RID: 3090
		internal static bool IsRunningOnDesktop;

		// Token: 0x04000C13 RID: 3091
		internal static bool jniRemappingInUse;

		// Token: 0x04000C14 RID: 3092
		internal static bool LocalRefsAreIndirect;

		// Token: 0x04000C15 RID: 3093
		internal static bool LogAssemblyCategory;

		// Token: 0x04000C16 RID: 3094
		internal static bool MarshalMethodsEnabled;

		// Token: 0x04000C17 RID: 3095
		internal static bool PropagateExceptions;

		// Token: 0x04000C18 RID: 3096
		internal static BoundExceptionType BoundExceptionType;

		// Token: 0x04000C19 RID: 3097
		internal static int gref_gc_threshold;

		// Token: 0x04000C1A RID: 3098
		internal static IntPtr grefIGCUserPeer_class;

		// Token: 0x04000C1B RID: 3099
		internal static IntPtr java_class_loader;

		// Token: 0x04000C1C RID: 3100
		internal static JniMethodInfo mid_Class_forName;

		// Token: 0x04000C1D RID: 3101
		private static AndroidRuntime androidRuntime;

		// Token: 0x020002E6 RID: 742
		internal struct JnienvInitializeArgs
		{
			// Token: 0x04000C1E RID: 3102
			public IntPtr javaVm;

			// Token: 0x04000C1F RID: 3103
			public IntPtr env;

			// Token: 0x04000C20 RID: 3104
			public IntPtr grefLoader;

			// Token: 0x04000C21 RID: 3105
			public IntPtr Loader_loadClass;

			// Token: 0x04000C22 RID: 3106
			public IntPtr grefClass;

			// Token: 0x04000C23 RID: 3107
			public IntPtr Class_forName;

			// Token: 0x04000C24 RID: 3108
			public uint logCategories;

			// Token: 0x04000C25 RID: 3109
			public int version;

			// Token: 0x04000C26 RID: 3110
			public int androidSdkVersion;

			// Token: 0x04000C27 RID: 3111
			public int localRefsAreIndirect;

			// Token: 0x04000C28 RID: 3112
			public int grefGcThreshold;

			// Token: 0x04000C29 RID: 3113
			public IntPtr grefIGCUserPeer;

			// Token: 0x04000C2A RID: 3114
			public int isRunningOnDesktop;

			// Token: 0x04000C2B RID: 3115
			public byte brokenExceptionTransitions;

			// Token: 0x04000C2C RID: 3116
			public int packageNamingPolicy;

			// Token: 0x04000C2D RID: 3117
			public byte ioExceptionType;

			// Token: 0x04000C2E RID: 3118
			public int jniAddNativeMethodRegistrationAttributePresent;

			// Token: 0x04000C2F RID: 3119
			public bool jniRemappingInUse;

			// Token: 0x04000C30 RID: 3120
			public bool marshalMethodsEnabled;
		}
	}
}
