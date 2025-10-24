using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Threading;
using Java.Interop;
using Java.Interop.Tools.TypeNameMappings;

namespace Android.Runtime
{
	// Token: 0x020002BC RID: 700
	internal class AndroidTypeManager : JniRuntime.JniTypeManager
	{
		// Token: 0x06001AB4 RID: 6836 RVA: 0x00045504 File Offset: 0x00043704
		public AndroidTypeManager(bool jniAddNativeMethodRegistrationAttributePresent)
		{
			this.jniAddNativeMethodRegistrationAttributePresent = jniAddNativeMethodRegistrationAttributePresent;
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x00045513 File Offset: 0x00043713
		protected override IEnumerable<Type> GetTypesForSimpleReference(string jniSimpleReference)
		{
			foreach (Type type in base.GetTypesForSimpleReference(jniSimpleReference))
			{
				yield return type;
			}
			IEnumerator<Type> enumerator = null;
			Type javaToManagedType = TypeManager.GetJavaToManagedType(jniSimpleReference);
			if (javaToManagedType != null)
			{
				yield return javaToManagedType;
			}
			yield break;
			yield break;
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x0004552C File Offset: 0x0004372C
		protected override string GetSimpleReference(Type type)
		{
			string text = JNIEnv.TypemapManagedToJava(type);
			if (text != null)
			{
				return text;
			}
			if (JNIEnvInit.IsRunningOnDesktop)
			{
				return JavaNativeTypeManager.ToJniName(type);
			}
			return null;
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x00045554 File Offset: 0x00043754
		protected override IEnumerable<string> GetSimpleReferences(Type type)
		{
			string text = JNIEnv.TypemapManagedToJava(type);
			if (JNIEnvInit.IsRunningOnDesktop)
			{
				string text2 = JavaNativeTypeManager.ToJniName(type);
				if (text != null && text2 != null)
				{
					return new string[]
					{
						text,
						text2
					};
				}
				if (text2 != null)
				{
					return new string[]
					{
						text2
					};
				}
			}
			if (text != null)
			{
				return new string[]
				{
					text
				};
			}
			return Array.Empty<string>();
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x000455AC File Offset: 0x000437AC
		[UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Mono.Android.Export.dll is preserved when [Export] is used via [DynamicDependency].")]
		private static Delegate CreateDynamicCallback(MethodInfo method)
		{
			if (AndroidTypeManager.dynamic_callback_gen == null)
			{
				Assembly assembly = Assembly.Load("Mono.Android.Export");
				if (assembly == null)
				{
					throw new InvalidOperationException("To use methods marked with ExportAttribute, Mono.Android.Export.dll needs to be referenced in the application");
				}
				Type type = assembly.GetType("Java.Interop.DynamicCallbackCodeGenerator");
				if (type == null)
				{
					throw new InvalidOperationException("The referenced Mono.Android.Export.dll does not match the expected version. The required type was not found.");
				}
				AndroidTypeManager.dynamic_callback_gen = type.GetMethod("Create");
				if (AndroidTypeManager.dynamic_callback_gen == null)
				{
					throw new InvalidOperationException("The referenced Mono.Android.Export.dll does not match the expected version. The required method was not found.");
				}
			}
			return (Delegate)AndroidTypeManager.dynamic_callback_gen.Invoke(null, new object[]
			{
				method
			});
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x00045644 File Offset: 0x00043844
		private static bool FastRegisterNativeMembers(JniType nativeClass, Type type, ReadOnlySpan<char> methods)
		{
			if (!AndroidTypeManager.MagicRegistrationMap.Filled)
			{
				return false;
			}
			bool flag = false;
			bool result = false;
			try
			{
				Monitor.TryEnter(AndroidTypeManager.sharedRegistrations, ref flag);
				List<JniNativeMethodRegistration> list;
				if (flag)
				{
					AndroidTypeManager.sharedRegistrations.Clear();
					list = AndroidTypeManager.sharedRegistrations;
				}
				else
				{
					list = new List<JniNativeMethodRegistration>();
				}
				result = AndroidTypeManager.MagicRegistrationMap.CallRegisterMethod(new JniNativeMethodRegistrationArguments(list, methods.ToString()), type.FullName);
				if (list.Count > 0)
				{
					nativeClass.RegisterNativeMethods(list.ToArray());
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(AndroidTypeManager.sharedRegistrations);
				}
			}
			return result;
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x000456DC File Offset: 0x000438DC
		public override void RegisterNativeMembers(JniType nativeClass, Type type, string methods)
		{
			this.RegisterNativeMembers(nativeClass, type, methods.AsSpan());
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x000456EC File Offset: 0x000438EC
		public void RegisterNativeMembers(JniType nativeClass, Type type, ReadOnlySpan<char> methods)
		{
			try
			{
				if (methods.IsEmpty)
				{
					if (this.jniAddNativeMethodRegistrationAttributePresent)
					{
						base.RegisterNativeMembers(nativeClass, type, methods.ToString());
					}
				}
				else if (!AndroidTypeManager.FastRegisterNativeMembers(nativeClass, type, methods))
				{
					int num = AndroidTypeManager.CountMethods(methods);
					if (num < 1)
					{
						if (this.jniAddNativeMethodRegistrationAttributePresent)
						{
							base.RegisterNativeMembers(nativeClass, type, methods.ToString());
						}
					}
					else
					{
						JniNativeMethodRegistration[] array = new JniNativeMethodRegistration[num];
						int numMethods = 0;
						MethodInfo[] array2 = null;
						ReadOnlySpan<char> span = methods;
						bool flag = false;
						while (!span.IsEmpty)
						{
							int num2 = span.IndexOf('\n');
							ReadOnlySpan<char> methodLine = span.Slice(0, (num2 != -1) ? num2 : span.Length);
							if (!methodLine.IsEmpty)
							{
								ReadOnlySpan<char> readOnlySpan;
								ReadOnlySpan<char> span2;
								ReadOnlySpan<char> span3;
								ReadOnlySpan<char> readOnlySpan2;
								AndroidTypeManager.SplitMethodLine(methodLine, out readOnlySpan, out span2, out span3, out readOnlySpan2);
								Delegate @delegate;
								if (span3.SequenceEqual("__export__"))
								{
									ReadOnlySpan<char> span4 = readOnlySpan.Slice(2);
									MethodInfo methodInfo = null;
									if (array2 == null)
									{
										array2 = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
									}
									foreach (MethodInfo methodInfo2 in array2)
									{
										if (span4.SequenceEqual(methodInfo2.Name) && span2.SequenceEqual(JavaNativeTypeManager.GetJniSignature(methodInfo2)))
										{
											methodInfo = methodInfo2;
											break;
										}
									}
									if (methodInfo == null)
									{
										throw new InvalidOperationException(string.Format("Specified managed method '{0}' was not found. Signature: {1}", span4.ToString(), span2.ToString()));
									}
									@delegate = AndroidTypeManager.CreateDynamicCallback(methodInfo);
									flag = true;
								}
								else
								{
									Type type2 = type;
									if (!readOnlySpan2.IsEmpty)
									{
										type2 = Type.GetType(readOnlySpan2.ToString(), true);
									}
									while (type2.ContainsGenericParameters)
									{
										type2 = type2.BaseType;
									}
									@delegate = ((AndroidTypeManager.GetCallbackHandler)Delegate.CreateDelegate(typeof(AndroidTypeManager.GetCallbackHandler), type2, span3.ToString()))();
								}
								if (@delegate != null)
								{
									flag = true;
									array[numMethods++] = new JniNativeMethodRegistration(readOnlySpan.ToString(), span2.ToString(), @delegate);
								}
							}
							span = ((num2 != -1) ? span.Slice(num2 + 1) : default(ReadOnlySpan<char>));
						}
						if (flag)
						{
							JniEnvironment.Types.RegisterNatives(nativeClass.PeerReference, array, numMethods);
						}
					}
				}
			}
			catch (Exception pendingException)
			{
				JniEnvironment.Runtime.RaisePendingException(pendingException);
			}
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x00045974 File Offset: 0x00043B74
		private static int CountMethods(ReadOnlySpan<char> methodsSpan)
		{
			int num = 0;
			while (!methodsSpan.IsEmpty)
			{
				num++;
				int num2 = methodsSpan.IndexOf('\n');
				methodsSpan = ((num2 != -1) ? methodsSpan.Slice(num2 + 1) : default(ReadOnlySpan<char>));
			}
			return num;
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x000459B8 File Offset: 0x00043BB8
		private static void SplitMethodLine(ReadOnlySpan<char> methodLine, out ReadOnlySpan<char> name, out ReadOnlySpan<char> signature, out ReadOnlySpan<char> callback, out ReadOnlySpan<char> callbackDeclaringType)
		{
			int num = methodLine.IndexOf(':');
			name = methodLine.Slice(0, num);
			methodLine = methodLine.Slice(num + 1);
			num = methodLine.IndexOf(':');
			signature = methodLine.Slice(0, num);
			methodLine = methodLine.Slice(num + 1);
			num = methodLine.IndexOf(':');
			callback = methodLine.Slice(0, (num != -1) ? num : methodLine.Length);
			callbackDeclaringType = ((num != -1) ? methodLine.Slice(num + 1) : default(ReadOnlySpan<char>));
		}

		// Token: 0x04000B6E RID: 2926
		private bool jniAddNativeMethodRegistrationAttributePresent;

		// Token: 0x04000B6F RID: 2927
		private static MethodInfo dynamic_callback_gen;

		// Token: 0x04000B70 RID: 2928
		private static List<JniNativeMethodRegistration> sharedRegistrations = new List<JniNativeMethodRegistration>();

		// Token: 0x020002BD RID: 701
		// (Invoke) Token: 0x06001AC1 RID: 6849
		private delegate Delegate GetCallbackHandler();

		// Token: 0x020002BE RID: 702
		private class MagicRegistrationMap
		{
			// Token: 0x06001AC4 RID: 6852 RVA: 0x00025BC2 File Offset: 0x00023DC2
			private static void Prefill()
			{
			}

			// Token: 0x06001AC5 RID: 6853 RVA: 0x00045A67 File Offset: 0x00043C67
			static MagicRegistrationMap()
			{
				AndroidTypeManager.MagicRegistrationMap.Prefill();
			}

			// Token: 0x170005BD RID: 1469
			// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x00045A6E File Offset: 0x00043C6E
			public static bool Filled
			{
				get
				{
					return AndroidTypeManager.MagicRegistrationMap.typesMap != null && AndroidTypeManager.MagicRegistrationMap.typesMap.Count > 0;
				}
			}

			// Token: 0x06001AC7 RID: 6855 RVA: 0x00045A88 File Offset: 0x00043C88
			internal static bool CallRegisterMethod(JniNativeMethodRegistrationArguments arguments, string typeName)
			{
				int value = 0;
				if (typeName != null)
				{
					Dictionary<string, int> dictionary = AndroidTypeManager.MagicRegistrationMap.typesMap;
					if (dictionary != null && dictionary.TryGetValue(typeName, out value))
					{
						return AndroidTypeManager.MagicRegistrationMap.CallRegisterMethodByIndex(arguments, new int?(value));
					}
				}
				return false;
			}

			// Token: 0x06001AC8 RID: 6856 RVA: 0x00045ABE File Offset: 0x00043CBE
			private static bool CallRegisterMethodByIndex(JniNativeMethodRegistrationArguments arguments, int? typeIdx)
			{
				return false;
			}

			// Token: 0x04000B71 RID: 2929
			private static Dictionary<string, int> typesMap;
		}
	}
}
