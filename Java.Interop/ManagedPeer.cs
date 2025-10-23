using System;
using System.Reflection;
using System.Text;

namespace Java.Interop
{
	// Token: 0x0200008D RID: 141
	[JniTypeSignature("com/xamarin/java_interop/ManagedPeer")]
	internal sealed class ManagedPeer : JavaObject
	{
		// Token: 0x06000497 RID: 1175 RVA: 0x00010B34 File Offset: 0x0000ED34
		static ManagedPeer()
		{
			ManagedPeer._members.JniPeerType.RegisterNativeMethods(new JniNativeMethodRegistration[]
			{
				new JniNativeMethodRegistration("construct", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", new ManagedPeer.ConstructMarshalMethod(ManagedPeer.Construct)),
				new JniNativeMethodRegistration("registerNativeMembers", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;)V", new ManagedPeer.RegisterMarshalMethod(ManagedPeer.RegisterNativeMembers))
			});
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x000025B2 File Offset: 0x000007B2
		internal static void Init()
		{
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00010BB4 File Offset: 0x0000EDB4
		private static void Construct(IntPtr jnienv, IntPtr klass, IntPtr n_self, IntPtr n_assemblyQualifiedName, IntPtr n_constructorSignature, IntPtr n_constructorArguments)
		{
			using (JniTransition jniTransition = new JniTransition(jnienv))
			{
				try
				{
					JniRuntime runtime = JniEnvironment.Runtime;
					JniObjectReference jniObjectReference = new JniObjectReference(n_self, JniObjectReferenceType.Invalid);
					IJavaPeerable javaPeerable = runtime.ValueManager.PeekPeer(jniObjectReference);
					if (javaPeerable != null)
					{
						JniManagedPeerStates jniManagedPeerState = javaPeerable.JniManagedPeerState;
						if ((jniManagedPeerState & JniManagedPeerStates.Activatable) != JniManagedPeerStates.Activatable && (jniManagedPeerState & JniManagedPeerStates.Replaceable) != JniManagedPeerStates.Replaceable)
						{
							return;
						}
					}
					if (JniEnvironment.WithinNewObjectScope)
					{
						if (runtime.ObjectReferenceManager.LogGlobalReferenceMessages)
						{
							runtime.ObjectReferenceManager.WriteGlobalReferenceLine("Warning: Skipping managed constructor invocation for PeerReference={0} IdentityHashCode=0x{1} Java.Type={2}. Please use JniPeerMembers.InstanceMethods.StartCreateInstance() + JniPeerMembers.InstanceMethods.FinishCreateInstance() instead of JniEnvironment.Object.NewObject().", new object[]
							{
								jniObjectReference,
								runtime.ValueManager.GetJniIdentityHashCode(jniObjectReference).ToString("x"),
								JniEnvironment.Types.GetJniTypeNameFromInstance(jniObjectReference)
							});
						}
					}
					else
					{
						Type type = Type.GetType(JniEnvironment.Strings.ToString(n_assemblyQualifiedName), true);
						if (type.IsGenericTypeDefinition)
						{
							throw new NotSupportedException("Constructing instances of generic types from Java is not supported, as the type parameters cannot be determined.", ManagedPeer.CreateJniLocationException());
						}
						Type[] parameterTypes = ManagedPeer.GetParameterTypes(JniEnvironment.Strings.ToString(n_constructorSignature));
						object[] values = ManagedPeer.GetValues(runtime, new JniObjectReference(n_constructorArguments, JniObjectReferenceType.Invalid), parameterTypes);
						ConstructorInfo constructor = type.GetConstructor(parameterTypes);
						if (constructor == null)
						{
							throw ManagedPeer.CreateMissingConstructorException(type, parameterTypes);
						}
						if (javaPeerable != null)
						{
							constructor.Invoke(javaPeerable, values);
						}
						else
						{
							JniEnvironment.Runtime.ValueManager.ActivatePeer(javaPeerable, new JniObjectReference(n_self, JniObjectReferenceType.Invalid), constructor, values);
						}
					}
				}
				catch (Exception ex) when (JniEnvironment.Runtime.ExceptionShouldTransitionToJni(ex))
				{
					jniTransition.SetPendingException(ex);
				}
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00010D5C File Offset: 0x0000EF5C
		private static Exception CreateMissingConstructorException(Type type, Type[] ptypes)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Unable to find constructor ");
			stringBuilder.Append(type.FullName);
			stringBuilder.Append("(");
			if (ptypes.Length != 0)
			{
				stringBuilder.Append(ptypes[0].FullName);
				for (int i = 1; i < ptypes.Length; i++)
				{
					stringBuilder.Append(", ").Append(ptypes[i].FullName);
				}
			}
			stringBuilder.Append(")");
			stringBuilder.Append(". Please provide the missing constructor.");
			return new NotSupportedException(stringBuilder.ToString(), ManagedPeer.CreateJniLocationException());
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00010DF8 File Offset: 0x0000EFF8
		private static Exception CreateJniLocationException()
		{
			Exception result;
			using (JavaException ex = new JavaException())
			{
				result = new JniLocationException(ex.ToString());
			}
			return result;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00010E34 File Offset: 0x0000F034
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

		// Token: 0x0600049D RID: 1181 RVA: 0x00010E80 File Offset: 0x0000F080
		private static object[] GetValues(JniRuntime runtime, JniObjectReference values, Type[] types)
		{
			if (!values.IsValid)
			{
				return null;
			}
			JniEnvironment.Arrays.GetArrayLength(values);
			object[] array = new object[types.Length];
			for (int i = 0; i < array.Length; i++)
			{
				JniObjectReference objectArrayElement = JniEnvironment.Arrays.GetObjectArrayElement(values, i);
				object value = runtime.ValueManager.GetValue(ref objectArrayElement, JniObjectReferenceOptions.CopyAndDispose, types[i]);
				array[i] = value;
			}
			return array;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		private static void RegisterNativeMembers(IntPtr jnienv, IntPtr klass, IntPtr n_nativeClass, IntPtr n_assemblyQualifiedName, IntPtr n_methods)
		{
			using (JniTransition jniTransition = new JniTransition(jnienv))
			{
				try
				{
					JniObjectReference jniObjectReference = new JniObjectReference(n_nativeClass, JniObjectReferenceType.Invalid);
					JniType nativeClass = new JniType(ref jniObjectReference, JniObjectReferenceOptions.Copy);
					Type type = Type.GetType(JniEnvironment.Strings.ToString(new JniObjectReference(n_assemblyQualifiedName, JniObjectReferenceType.Invalid)), true);
					string methods = JniEnvironment.Strings.ToString(new JniObjectReference(n_methods, JniObjectReferenceType.Invalid));
					JniEnvironment.Runtime.TypeManager.RegisterNativeMembers(nativeClass, type, methods);
				}
				catch (Exception ex) when (JniEnvironment.Runtime.ExceptionShouldTransitionToJni(ex))
				{
					jniTransition.SetPendingException(ex);
				}
			}
		}

		// Token: 0x04000145 RID: 325
		private static readonly JniPeerMembers _members = new JniPeerMembers("com/xamarin/java_interop/ManagedPeer", typeof(ManagedPeer));

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x060004A0 RID: 1184
		private delegate void ConstructMarshalMethod(IntPtr jnienv, IntPtr klass, IntPtr n_self, IntPtr n_assemblyQualifiedName, IntPtr n_constructorSignature, IntPtr n_constructorArguments);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x060004A4 RID: 1188
		private delegate void RegisterMarshalMethod(IntPtr jnienv, IntPtr klass, IntPtr n_nativeClass, IntPtr n_assemblyQualifiedName, IntPtr n_methods);
	}
}
