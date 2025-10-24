using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace Java.Interop
{
	// Token: 0x0200001E RID: 30
	public class JniRuntime : IDisposable
	{
		// Token: 0x06000180 RID: 384 RVA: 0x00007CEC File Offset: 0x00005EEC
		private static bool GetBuiltInTypeArraySignature(Type type, ref JniTypeSignature signature)
		{
			if (type == typeof(JavaArray<bool>) || type == typeof(JavaPrimitiveArray<bool>))
			{
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__BooleanTypeArraySignature, "Z", 1, true);
				return true;
			}
			if (type == typeof(JavaArray<sbyte>) || type == typeof(JavaPrimitiveArray<sbyte>))
			{
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__SByteTypeArraySignature, "B", 1, true);
				return true;
			}
			if (type == typeof(JavaArray<char>) || type == typeof(JavaPrimitiveArray<char>))
			{
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__CharTypeArraySignature, "C", 1, true);
				return true;
			}
			if (type == typeof(JavaArray<short>) || type == typeof(JavaPrimitiveArray<short>))
			{
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__Int16TypeArraySignature, "S", 1, true);
				return true;
			}
			if (type == typeof(JavaArray<int>) || type == typeof(JavaPrimitiveArray<int>))
			{
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__Int32TypeArraySignature, "I", 1, true);
				return true;
			}
			if (type == typeof(JavaArray<long>) || type == typeof(JavaPrimitiveArray<long>))
			{
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__Int64TypeArraySignature, "J", 1, true);
				return true;
			}
			if (type == typeof(JavaArray<float>) || type == typeof(JavaPrimitiveArray<float>))
			{
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__SingleTypeArraySignature, "F", 1, true);
				return true;
			}
			if (type == typeof(JavaArray<double>) || type == typeof(JavaPrimitiveArray<double>))
			{
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__DoubleTypeArraySignature, "D", 1, true);
				return true;
			}
			return false;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00007EE4 File Offset: 0x000060E4
		private static KeyValuePair<Type, JniValueMarshaler>[] InitJniPrimitiveArrayMarshalers()
		{
			return new KeyValuePair<Type, JniValueMarshaler>[]
			{
				new KeyValuePair<Type, JniValueMarshaler>(typeof(bool[]), JavaBooleanArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaArray<bool>), JavaBooleanArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaPrimitiveArray<bool>), JavaBooleanArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaBooleanArray), JavaBooleanArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(sbyte[]), JavaSByteArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaArray<sbyte>), JavaSByteArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaPrimitiveArray<sbyte>), JavaSByteArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaSByteArray), JavaSByteArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(char[]), JavaCharArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaArray<char>), JavaCharArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaPrimitiveArray<char>), JavaCharArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaCharArray), JavaCharArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(short[]), JavaInt16Array.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaArray<short>), JavaInt16Array.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaPrimitiveArray<short>), JavaInt16Array.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaInt16Array), JavaInt16Array.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(int[]), JavaInt32Array.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaArray<int>), JavaInt32Array.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaPrimitiveArray<int>), JavaInt32Array.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaInt32Array), JavaInt32Array.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(long[]), JavaInt64Array.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaArray<long>), JavaInt64Array.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaPrimitiveArray<long>), JavaInt64Array.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaInt64Array), JavaInt64Array.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(float[]), JavaSingleArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaArray<float>), JavaSingleArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaPrimitiveArray<float>), JavaSingleArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaSingleArray), JavaSingleArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(double[]), JavaDoubleArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaArray<double>), JavaDoubleArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaPrimitiveArray<double>), JavaDoubleArray.ArrayMarshaler),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(JavaDoubleArray), JavaDoubleArray.ArrayMarshaler)
			};
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000826F File Offset: 0x0000646F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static JniTypeSignature GetCachedTypeSignature(ref JniTypeSignature field, string signature, int arrayRank = 0, bool keyword = false)
		{
			if (!field.IsValid)
			{
				field = new JniTypeSignature(signature, arrayRank, keyword);
			}
			return field;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00008290 File Offset: 0x00006490
		private static bool GetBuiltInTypeSignature(Type type, ref JniTypeSignature signature)
		{
			switch (Type.GetTypeCode(type))
			{
			case TypeCode.Empty:
			case TypeCode.DBNull:
			case TypeCode.UInt16:
			case TypeCode.UInt32:
			case TypeCode.UInt64:
			case TypeCode.Decimal:
			case TypeCode.DateTime:
				return false;
			case TypeCode.Boolean:
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__BooleanTypeSignature, "Z", 0, true);
				return true;
			case TypeCode.Char:
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__CharTypeSignature, "C", 0, true);
				return true;
			case TypeCode.SByte:
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__SByteTypeSignature, "B", 0, true);
				return true;
			case TypeCode.Int16:
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__Int16TypeSignature, "S", 0, true);
				return true;
			case TypeCode.Int32:
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__Int32TypeSignature, "I", 0, true);
				return true;
			case TypeCode.Int64:
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__Int64TypeSignature, "J", 0, true);
				return true;
			case TypeCode.Single:
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__SingleTypeSignature, "F", 0, true);
				return true;
			case TypeCode.Double:
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__DoubleTypeSignature, "D", 0, true);
				return true;
			case TypeCode.String:
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__StringTypeSignature, "java/lang/String", 0, false);
				return true;
			}
			if (type == typeof(void))
			{
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__VoidTypeSignature, "V", 0, true);
				return true;
			}
			if (!type.IsValueType)
			{
				return false;
			}
			if (type == typeof(bool?))
			{
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__BooleanNullableTypeSignature, "java/lang/Boolean", 0, false);
				return true;
			}
			if (type == typeof(sbyte?))
			{
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__SByteNullableTypeSignature, "java/lang/Byte", 0, false);
				return true;
			}
			if (type == typeof(char?))
			{
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__CharNullableTypeSignature, "java/lang/Character", 0, false);
				return true;
			}
			if (type == typeof(short?))
			{
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__Int16NullableTypeSignature, "java/lang/Short", 0, false);
				return true;
			}
			if (type == typeof(int?))
			{
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__Int32NullableTypeSignature, "java/lang/Integer", 0, false);
				return true;
			}
			if (type == typeof(long?))
			{
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__Int64NullableTypeSignature, "java/lang/Long", 0, false);
				return true;
			}
			if (type == typeof(float?))
			{
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__SingleNullableTypeSignature, "java/lang/Float", 0, false);
				return true;
			}
			if (type == typeof(double?))
			{
				signature = JniRuntime.GetCachedTypeSignature(ref JniRuntime.__DoubleNullableTypeSignature, "java/lang/Double", 0, false);
				return true;
			}
			return false;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000856C File Offset: 0x0000676C
		private static Dictionary<string, Type> InitJniBuiltinSimpleReferenceToType()
		{
			return new Dictionary<string, Type>(StringComparer.Ordinal)
			{
				{
					"java/lang/String",
					typeof(string)
				},
				{
					"V",
					typeof(void)
				},
				{
					"Z",
					typeof(bool)
				},
				{
					"java/lang/Boolean",
					typeof(bool?)
				},
				{
					"B",
					typeof(sbyte)
				},
				{
					"java/lang/Byte",
					typeof(sbyte?)
				},
				{
					"C",
					typeof(char)
				},
				{
					"java/lang/Character",
					typeof(char?)
				},
				{
					"S",
					typeof(short)
				},
				{
					"java/lang/Short",
					typeof(short?)
				},
				{
					"I",
					typeof(int)
				},
				{
					"java/lang/Integer",
					typeof(int?)
				},
				{
					"J",
					typeof(long)
				},
				{
					"java/lang/Long",
					typeof(long?)
				},
				{
					"F",
					typeof(float)
				},
				{
					"java/lang/Float",
					typeof(float?)
				},
				{
					"D",
					typeof(double)
				},
				{
					"java/lang/Double",
					typeof(double?)
				}
			};
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00008700 File Offset: 0x00006900
		private static KeyValuePair<Type, JniValueMarshaler>[] InitJniBuiltinMarshalers()
		{
			return new KeyValuePair<Type, JniValueMarshaler>[]
			{
				new KeyValuePair<Type, JniValueMarshaler>(typeof(string), JniStringValueMarshaler.Instance),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(bool), JniBooleanValueMarshaler.Instance),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(bool?), JniNullableBooleanValueMarshaler.Instance),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(sbyte), JniSByteValueMarshaler.Instance),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(sbyte?), JniNullableSByteValueMarshaler.Instance),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(char), JniCharValueMarshaler.Instance),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(char?), JniNullableCharValueMarshaler.Instance),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(short), JniInt16ValueMarshaler.Instance),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(short?), JniNullableInt16ValueMarshaler.Instance),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(int), JniInt32ValueMarshaler.Instance),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(int?), JniNullableInt32ValueMarshaler.Instance),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(long), JniInt64ValueMarshaler.Instance),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(long?), JniNullableInt64ValueMarshaler.Instance),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(float), JniSingleValueMarshaler.Instance),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(float?), JniNullableSingleValueMarshaler.Instance),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(double), JniDoubleValueMarshaler.Instance),
				new KeyValuePair<Type, JniValueMarshaler>(typeof(double?), JniNullableDoubleValueMarshaler.Instance)
			};
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000088E8 File Offset: 0x00006AE8
		public static JniRuntime GetRegisteredRuntime(IntPtr invocationPointer)
		{
			Dictionary<IntPtr, JniRuntime> runtimes = JniRuntime.Runtimes;
			JniRuntime result;
			lock (runtimes)
			{
				JniRuntime jniRuntime;
				result = (JniRuntime.Runtimes.TryGetValue(invocationPointer, out jniRuntime) ? jniRuntime : null);
			}
			return result;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00008938 File Offset: 0x00006B38
		public static JniRuntime CurrentRuntime
		{
			get
			{
				JniRuntime jniRuntime = JniRuntime.current;
				if (jniRuntime != null)
				{
					return jniRuntime;
				}
				int num = 0;
				Dictionary<IntPtr, JniRuntime> runtimes = JniRuntime.Runtimes;
				lock (runtimes)
				{
					foreach (JniRuntime jniRuntime2 in JniRuntime.Runtimes.Values)
					{
						if (num++ == 0)
						{
							jniRuntime = jniRuntime2;
						}
					}
				}
				if (num == 1)
				{
					Interlocked.CompareExchange<JniRuntime>(ref JniRuntime.current, jniRuntime, null);
					return jniRuntime;
				}
				if (num > 1)
				{
					throw new NotSupportedException(string.Format("Found {0} known Java Runtime instances. Don't know which to use. Use JniRuntime.SetCurrent().", num));
				}
				throw new NotSupportedException("No available Java runtime to attach to. Please create one.");
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00008A00 File Offset: 0x00006C00
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00008A08 File Offset: 0x00006C08
		public IntPtr InvocationPointer { get; private set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00008A11 File Offset: 0x00006C11
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00008A19 File Offset: 0x00006C19
		public JniVersion JniVersion { get; private set; }

		// Token: 0x1700002A RID: 42
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00008A22 File Offset: 0x00006C22
		private bool TrackIDs
		{
			[CompilerGenerated]
			set
			{
				this.<TrackIDs>k__BackingField = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00008A2B File Offset: 0x00006C2B
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00008A33 File Offset: 0x00006C33
		internal bool NewObjectRequired { get; private set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00008A3C File Offset: 0x00006C3C
		internal bool JniAddNativeMethodRegistrationAttributePresent { get; }

		// Token: 0x06000190 RID: 400 RVA: 0x00008A44 File Offset: 0x00006C44
		protected JniRuntime(JniRuntime.CreationOptions options)
		{
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
			if (options.InvocationPointer == IntPtr.Zero)
			{
				throw new ArgumentException("options.InvocationPointer is null", "options");
			}
			this.TrackIDs = options.TrackIDs;
			this.DestroyRuntimeOnDispose = options.DestroyRuntimeOnDispose;
			this.JniAddNativeMethodRegistrationAttributePresent = options.JniAddNativeMethodRegistrationAttributePresent;
			this.NewObjectRequired = options.NewObjectRequired;
			this.JniVersion = options.JniVersion;
			this.InvocationPointer = options.InvocationPointer;
			this.Invoker = JniRuntime.CreateInvoker(this.InvocationPointer);
			this.SetValueManager(options);
			this.SetMarshalMemberBuilder(options);
			JniRuntime.JniObjectReferenceManager objectReferenceManager = options.ObjectReferenceManager;
			if (objectReferenceManager == null)
			{
				throw new NotSupportedException("Please set CreationOptions.ObjectReferenceManager!");
			}
			this.ObjectReferenceManager = this.SetRuntime<JniRuntime.JniObjectReferenceManager>(objectReferenceManager);
			this.TypeManager = this.SetRuntime<JniRuntime.JniTypeManager>(options.TypeManager ?? new JniRuntime.JniTypeManager());
			Interlocked.CompareExchange<JniRuntime>(ref JniRuntime.current, this, null);
			Dictionary<IntPtr, JniRuntime> runtimes = JniRuntime.Runtimes;
			lock (runtimes)
			{
				JniRuntime.Runtimes[this.InvocationPointer] = this;
			}
			IntPtr intPtr = options.EnvironmentPointer;
			if (intPtr == IntPtr.Zero && this.Invoker.GetEnv(this.InvocationPointer, out intPtr, (int)this.JniVersion) != 0 && (intPtr = this._AttachCurrentThread(null, default(JniObjectReference))) == IntPtr.Zero)
			{
				throw new InvalidOperationException("Could not obtain JNIEnv* value!");
			}
			JniEnvironment.SetEnvironmentInfo(new JniEnvironmentInfo(intPtr, this));
			this.ClassLoader = options.ClassLoader;
			if (options.ClassLoader_LoadClass_id != IntPtr.Zero)
			{
				this.ClassLoader_LoadClass = new JniMethodInfo(options.ClassLoader_LoadClass_id, false);
			}
			if (this.ClassLoader.IsValid)
			{
				this.ClassLoader = this.ClassLoader.NewGlobalRef();
			}
			if (!this.ClassLoader.IsValid || this.ClassLoader_LoadClass == null)
			{
				using (JniType jniType = new JniType("java/lang/ClassLoader"))
				{
					if (!this.ClassLoader.IsValid)
					{
						JniMethodInfo staticMethod = jniType.GetStaticMethod("getSystemClassLoader", "()Ljava/lang/ClassLoader;");
						JniObjectReference jniObjectReference = JniEnvironment.StaticMethods.CallStaticObjectMethod(jniType.PeerReference, staticMethod);
						this.ClassLoader = jniObjectReference.NewGlobalRef();
						JniObjectReference.Dispose(ref jniObjectReference);
					}
					if (this.ClassLoader_LoadClass == null)
					{
						this.ClassLoader_LoadClass = jniType.GetInstanceMethod("loadClass", "(Ljava/lang/String;)Ljava/lang/Class;");
					}
				}
			}
			ManagedPeer.Init();
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00008CDC File Offset: 0x00006EDC
		private T SetRuntime<T>(T value) where T : class, JniRuntime.ISetRuntime
		{
			if (value == null)
			{
				throw new NotSupportedException();
			}
			value.OnSetRuntime(this);
			return value;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00008CFC File Offset: 0x00006EFC
		private void SetValueManager(JniRuntime.CreationOptions options)
		{
			JniRuntime.JniValueManager jniValueManager = options.ValueManager;
			if (jniValueManager == null)
			{
				throw new ArgumentException("No JniValueManager specified in JniRuntime.CreationOptions.ValueManager.", "options");
			}
			this.valueManager = this.SetRuntime<JniRuntime.JniValueManager>(jniValueManager);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00008D30 File Offset: 0x00006F30
		private void SetMarshalMemberBuilder(JniRuntime.CreationOptions options)
		{
			if (!options.UseMarshalMemberBuilder)
			{
				return;
			}
			if (options.MarshalMemberBuilder != null)
			{
				this.marshalMemberBuilder = this.SetRuntime<JniRuntime.JniMarshalMemberBuilder>(options.MarshalMemberBuilder);
				return;
			}
			Assembly assembly;
			try
			{
				assembly = Assembly.Load(new AssemblyName("Java.Interop.Export"));
			}
			catch (Exception)
			{
				return;
			}
			Type type = assembly.GetType("Java.Interop.MarshalMemberBuilder");
			if (type == null)
			{
				throw new InvalidOperationException("Could not find Java.Interop.MarshalMemberBuilder from Java.Interop.Export.dll!");
			}
			JniRuntime.JniMarshalMemberBuilder runtime = (JniRuntime.JniMarshalMemberBuilder)Activator.CreateInstance(type);
			this.marshalMemberBuilder = this.SetRuntime<JniRuntime.JniMarshalMemberBuilder>(runtime);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00008DC0 File Offset: 0x00006FC0
		private static JavaVMInterface CreateInvoker(IntPtr handle)
		{
			return (JavaVMInterface)Marshal.PtrToStructure(Marshal.ReadIntPtr(handle), typeof(JavaVMInterface));
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00008DDC File Offset: 0x00006FDC
		~JniRuntime()
		{
			this.Dispose(false);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00008E0C File Offset: 0x0000700C
		public override string ToString()
		{
			return string.Format("{0}(0x{1})", base.GetType().FullName, this.InvocationPointer.ToString("x"));
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00008E41 File Offset: 0x00007041
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00008E50 File Offset: 0x00007050
		protected virtual void Dispose(bool disposing)
		{
			if (this.InvocationPointer == IntPtr.Zero)
			{
				return;
			}
			Interlocked.CompareExchange<JniRuntime>(ref JniRuntime.current, null, this);
			Dictionary<IntPtr, JniRuntime> runtimes = JniRuntime.Runtimes;
			lock (runtimes)
			{
				JniRuntime jniRuntime;
				if (JniRuntime.Runtimes.TryGetValue(this.InvocationPointer, out jniRuntime) && jniRuntime == this)
				{
					JniRuntime.Runtimes.Remove(this.InvocationPointer);
				}
			}
			if (disposing)
			{
				JniObjectReference.Dispose(ref this.ClassLoader);
				this.ClearTrackedReferences();
				this.ValueManager.Dispose();
				JniRuntime.JniMarshalMemberBuilder jniMarshalMemberBuilder = this.marshalMemberBuilder;
				if (jniMarshalMemberBuilder != null)
				{
					jniMarshalMemberBuilder.Dispose();
				}
				this.TypeManager.Dispose();
				this.ObjectReferenceManager.Dispose();
				IList<JniEnvironmentInfo> values = JniEnvironment.Info.Values;
				for (int i = 0; i < values.Count; i++)
				{
					if (values[i].Runtime == this)
					{
						values[i].Dispose();
					}
				}
			}
			if (this.DestroyRuntimeOnDispose)
			{
				this.DestroyRuntime();
			}
			this.InvocationPointer = IntPtr.Zero;
			this.Invoker = default(JavaVMInterface);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00008F80 File Offset: 0x00007180
		internal IntPtr _AttachCurrentThread(string name = null, JniObjectReference group = default(JniObjectReference))
		{
			this.AssertValid();
			JavaVMThreadAttachArgs javaVMThreadAttachArgs = new JavaVMThreadAttachArgs
			{
				version = this.JniVersion
			};
			IntPtr result;
			try
			{
				if (name != null)
				{
					javaVMThreadAttachArgs.name = Marshal.StringToHGlobalAnsi(name);
				}
				if (group.IsValid)
				{
					javaVMThreadAttachArgs.group = group.Handle;
				}
				IntPtr intPtr;
				int num = this.Invoker.AttachCurrentThread(this.InvocationPointer, out intPtr, ref javaVMThreadAttachArgs);
				if (num != 0)
				{
					throw new NotSupportedException("AttachCurrentThread returned " + num.ToString());
				}
				result = intPtr;
			}
			finally
			{
				Marshal.FreeHGlobal(javaVMThreadAttachArgs.name);
			}
			return result;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000902C File Offset: 0x0000722C
		private void AssertValid()
		{
			if (this.InvocationPointer == IntPtr.Zero)
			{
				throw new ObjectDisposedException("JniRuntime");
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000904B File Offset: 0x0000724B
		public void DestroyRuntime()
		{
			this.AssertValid();
			this.Invoker.DestroyJavaVM(this.InvocationPointer);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000906A File Offset: 0x0000726A
		public virtual Exception GetExceptionForThrowable(ref JniObjectReference reference, JniObjectReferenceOptions options)
		{
			return this.ValueManager.GetValue<Exception>(ref reference, options, null);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000907A File Offset: 0x0000727A
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00009082 File Offset: 0x00007282
		public JniRuntime.JniObjectReferenceManager ObjectReferenceManager { get; private set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000908B File Offset: 0x0000728B
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00009093 File Offset: 0x00007293
		public JniRuntime.JniTypeManager TypeManager { get; private set; }

		// Token: 0x060001A1 RID: 417 RVA: 0x0000909C File Offset: 0x0000729C
		internal void Track(JniType value)
		{
			Dictionary<IntPtr, IDisposable> trackedInstances = this.TrackedInstances;
			lock (trackedInstances)
			{
				if (!this.TrackedInstances.ContainsKey(value.PeerReference.Handle))
				{
					this.TrackedInstances[value.PeerReference.Handle] = value;
				}
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000910C File Offset: 0x0000730C
		internal void UnTrack(IntPtr key)
		{
			Dictionary<IntPtr, IDisposable> trackedInstances = this.TrackedInstances;
			lock (trackedInstances)
			{
				if (this.TrackedInstances.ContainsKey(key))
				{
					this.TrackedInstances.Remove(key);
				}
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00009164 File Offset: 0x00007364
		private void ClearTrackedReferences()
		{
			Dictionary<IntPtr, IDisposable> trackedInstances = this.TrackedInstances;
			List<IDisposable> list;
			lock (trackedInstances)
			{
				list = new List<IDisposable>(this.TrackedInstances.Values);
				this.TrackedInstances.Clear();
			}
			foreach (IDisposable disposable in list)
			{
				disposable.Dispose();
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000091F4 File Offset: 0x000073F4
		public virtual bool ExceptionShouldTransitionToJni(Exception e)
		{
			return !Debugger.IsAttached;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000091FE File Offset: 0x000073FE
		public virtual void RaisePendingException(Exception pendingException)
		{
			JniEnvironment.Exceptions.Throw(pendingException);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00009206 File Offset: 0x00007406
		public JniRuntime.JniValueManager ValueManager
		{
			get
			{
				JniRuntime.JniValueManager jniValueManager = this.valueManager;
				if (jniValueManager == null)
				{
					throw new NotSupportedException();
				}
				return jniValueManager;
			}
		}

		// Token: 0x0400002B RID: 43
		private static JniTypeSignature __BooleanTypeArraySignature;

		// Token: 0x0400002C RID: 44
		private static JniTypeSignature __SByteTypeArraySignature;

		// Token: 0x0400002D RID: 45
		private static JniTypeSignature __CharTypeArraySignature;

		// Token: 0x0400002E RID: 46
		private static JniTypeSignature __Int16TypeArraySignature;

		// Token: 0x0400002F RID: 47
		private static JniTypeSignature __Int32TypeArraySignature;

		// Token: 0x04000030 RID: 48
		private static JniTypeSignature __Int64TypeArraySignature;

		// Token: 0x04000031 RID: 49
		private static JniTypeSignature __SingleTypeArraySignature;

		// Token: 0x04000032 RID: 50
		private static JniTypeSignature __DoubleTypeArraySignature;

		// Token: 0x04000033 RID: 51
		private static readonly Lazy<KeyValuePair<Type, JniValueMarshaler>[]> JniPrimitiveArrayMarshalers = new Lazy<KeyValuePair<Type, JniValueMarshaler>[]>(new Func<KeyValuePair<Type, JniValueMarshaler>[]>(JniRuntime.InitJniPrimitiveArrayMarshalers));

		// Token: 0x04000034 RID: 52
		private static JniTypeSignature __StringTypeSignature;

		// Token: 0x04000035 RID: 53
		private static JniTypeSignature __VoidTypeSignature;

		// Token: 0x04000036 RID: 54
		private static JniTypeSignature __BooleanTypeSignature;

		// Token: 0x04000037 RID: 55
		private static JniTypeSignature __BooleanNullableTypeSignature;

		// Token: 0x04000038 RID: 56
		private static JniTypeSignature __SByteTypeSignature;

		// Token: 0x04000039 RID: 57
		private static JniTypeSignature __SByteNullableTypeSignature;

		// Token: 0x0400003A RID: 58
		private static JniTypeSignature __CharTypeSignature;

		// Token: 0x0400003B RID: 59
		private static JniTypeSignature __CharNullableTypeSignature;

		// Token: 0x0400003C RID: 60
		private static JniTypeSignature __Int16TypeSignature;

		// Token: 0x0400003D RID: 61
		private static JniTypeSignature __Int16NullableTypeSignature;

		// Token: 0x0400003E RID: 62
		private static JniTypeSignature __Int32TypeSignature;

		// Token: 0x0400003F RID: 63
		private static JniTypeSignature __Int32NullableTypeSignature;

		// Token: 0x04000040 RID: 64
		private static JniTypeSignature __Int64TypeSignature;

		// Token: 0x04000041 RID: 65
		private static JniTypeSignature __Int64NullableTypeSignature;

		// Token: 0x04000042 RID: 66
		private static JniTypeSignature __SingleTypeSignature;

		// Token: 0x04000043 RID: 67
		private static JniTypeSignature __SingleNullableTypeSignature;

		// Token: 0x04000044 RID: 68
		private static JniTypeSignature __DoubleTypeSignature;

		// Token: 0x04000045 RID: 69
		private static JniTypeSignature __DoubleNullableTypeSignature;

		// Token: 0x04000046 RID: 70
		private static readonly Lazy<Dictionary<string, Type>> JniBuiltinSimpleReferenceToType = new Lazy<Dictionary<string, Type>>(new Func<Dictionary<string, Type>>(JniRuntime.InitJniBuiltinSimpleReferenceToType));

		// Token: 0x04000047 RID: 71
		private static readonly Lazy<KeyValuePair<Type, JniValueMarshaler>[]> JniBuiltinMarshalers = new Lazy<KeyValuePair<Type, JniValueMarshaler>[]>(new Func<KeyValuePair<Type, JniValueMarshaler>[]>(JniRuntime.InitJniBuiltinMarshalers));

		// Token: 0x04000048 RID: 72
		private static Dictionary<IntPtr, JniRuntime> Runtimes = new Dictionary<IntPtr, JniRuntime>();

		// Token: 0x04000049 RID: 73
		private static JniRuntime current;

		// Token: 0x0400004A RID: 74
		private Dictionary<IntPtr, IDisposable> TrackedInstances = new Dictionary<IntPtr, IDisposable>();

		// Token: 0x0400004B RID: 75
		private JavaVMInterface Invoker;

		// Token: 0x0400004C RID: 76
		private bool DestroyRuntimeOnDispose;

		// Token: 0x0400004D RID: 77
		internal JniObjectReference ClassLoader;

		// Token: 0x0400004E RID: 78
		internal JniMethodInfo ClassLoader_LoadClass;

		// Token: 0x04000056 RID: 86
		private JniRuntime.JniMarshalMemberBuilder marshalMemberBuilder;

		// Token: 0x04000057 RID: 87
		private JniRuntime.JniValueManager valueManager;

		// Token: 0x0200001F RID: 31
		public abstract class JniValueManager : JniRuntime.ISetRuntime, IDisposable
		{
			// Token: 0x17000030 RID: 48
			// (get) Token: 0x060001A8 RID: 424 RVA: 0x00009271 File Offset: 0x00007471
			public JniRuntime Runtime
			{
				get
				{
					JniRuntime jniRuntime = this.runtime;
					if (jniRuntime == null)
					{
						throw new NotSupportedException();
					}
					return jniRuntime;
				}
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x00009283 File Offset: 0x00007483
			public virtual void OnSetRuntime(JniRuntime runtime)
			{
				if (this.disposed)
				{
					throw new ObjectDisposedException(base.GetType().Name);
				}
				this.runtime = runtime;
			}

			// Token: 0x060001AA RID: 426 RVA: 0x000092A5 File Offset: 0x000074A5
			public void Dispose()
			{
				this.Dispose(true);
				GC.SuppressFinalize(this);
			}

			// Token: 0x060001AB RID: 427 RVA: 0x000092B4 File Offset: 0x000074B4
			protected virtual void Dispose(bool disposing)
			{
				this.disposed = true;
			}

			// Token: 0x060001AC RID: 428
			public abstract void AddPeer(IJavaPeerable value);

			// Token: 0x060001AD RID: 429
			public abstract void RemovePeer(IJavaPeerable value);

			// Token: 0x060001AE RID: 430
			public abstract void FinalizePeer(IJavaPeerable value);

			// Token: 0x060001AF RID: 431
			public abstract List<JniSurfacedPeerInfo> GetSurfacedPeers();

			// Token: 0x060001B0 RID: 432
			public abstract void ActivatePeer(IJavaPeerable self, JniObjectReference reference, ConstructorInfo cinfo, object[] argumentValues);

			// Token: 0x060001B1 RID: 433 RVA: 0x000092C0 File Offset: 0x000074C0
			public void ConstructPeer(IJavaPeerable peer, ref JniObjectReference reference, JniObjectReferenceOptions options)
			{
				if (peer == null)
				{
					throw new ArgumentNullException("peer");
				}
				JniObjectReference jniObjectReference = peer.PeerReference;
				if (jniObjectReference.IsValid)
				{
					peer.SetJniManagedPeerState(peer.JniManagedPeerState | JniManagedPeerStates.Activatable);
					JniObjectReference.Dispose(ref reference, options);
					jniObjectReference = jniObjectReference.NewGlobalRef();
				}
				else
				{
					if (options == JniObjectReferenceOptions.None)
					{
						return;
					}
					if (!reference.IsValid)
					{
						throw new ArgumentException("JNI Object Reference is invalid.", "reference");
					}
					jniObjectReference = reference;
					if ((options & JniObjectReferenceOptions.Copy) == JniObjectReferenceOptions.Copy)
					{
						jniObjectReference = reference.NewGlobalRef();
					}
					JniObjectReference.Dispose(ref reference, options);
				}
				peer.SetPeerReference(jniObjectReference);
				peer.SetJniIdentityHashCode(JniSystem.IdentityHashCode(jniObjectReference));
				JniRuntime.JniObjectReferenceManager objectReferenceManager = this.Runtime.ObjectReferenceManager;
				if (objectReferenceManager.LogGlobalReferenceMessages)
				{
					objectReferenceManager.WriteGlobalReferenceLine("Created PeerReference={0} IdentityHashCode=0x{1} Instance=0x{2} Instance.Type={3}, Java.Type={4}", new object[]
					{
						jniObjectReference.ToString(),
						peer.JniIdentityHashCode.ToString("x"),
						RuntimeHelpers.GetHashCode(peer).ToString("x"),
						peer.GetType().FullName,
						JniEnvironment.Types.GetJniTypeNameFromInstance(jniObjectReference)
					});
				}
				if ((options & (JniObjectReferenceOptions)4) != (JniObjectReferenceOptions)4)
				{
					this.AddPeer(peer);
				}
			}

			// Token: 0x060001B2 RID: 434 RVA: 0x000093D9 File Offset: 0x000075D9
			public int GetJniIdentityHashCode(JniObjectReference reference)
			{
				return JniSystem.IdentityHashCode(reference);
			}

			// Token: 0x060001B3 RID: 435 RVA: 0x000093E4 File Offset: 0x000075E4
			public virtual void DisposePeer(IJavaPeerable value)
			{
				if (this.disposed)
				{
					throw new ObjectDisposedException(base.GetType().Name);
				}
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (!value.PeerReference.IsValid)
				{
					return;
				}
				value.Disposed();
				this.RemovePeer(value);
				JniObjectReference peerReference = value.PeerReference;
				if (!peerReference.IsValid)
				{
					return;
				}
				this.DisposePeer(peerReference, value);
			}

			// Token: 0x060001B4 RID: 436 RVA: 0x00009450 File Offset: 0x00007650
			private void DisposePeer(JniObjectReference h, IJavaPeerable value)
			{
				if (this.disposed)
				{
					throw new ObjectDisposedException(base.GetType().Name);
				}
				JniRuntime.JniObjectReferenceManager objectReferenceManager = this.Runtime.ObjectReferenceManager;
				if (objectReferenceManager.LogGlobalReferenceMessages)
				{
					objectReferenceManager.WriteGlobalReferenceLine("Disposing PeerReference={0} IdentityHashCode=0x{1} Instance=0x{2} Instance.Type={3} Java.Type={4}", new object[]
					{
						h.ToString(),
						value.JniIdentityHashCode.ToString("x"),
						RuntimeHelpers.GetHashCode(value).ToString("x"),
						value.GetType().ToString(),
						JniEnvironment.Types.GetJniTypeNameFromInstance(h)
					});
				}
				JniObjectReference.Dispose(ref h);
				value.SetPeerReference(default(JniObjectReference));
				GC.SuppressFinalize(value);
			}

			// Token: 0x060001B5 RID: 437 RVA: 0x0000950C File Offset: 0x0000770C
			public virtual void DisposePeerUnlessReferenced(IJavaPeerable value)
			{
				if (this.disposed)
				{
					throw new ObjectDisposedException(base.GetType().Name);
				}
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				JniObjectReference peerReference = value.PeerReference;
				if (!peerReference.IsValid)
				{
					return;
				}
				IJavaPeerable javaPeerable = this.PeekPeer(peerReference);
				if (javaPeerable != null && javaPeerable == value)
				{
					return;
				}
				this.DisposePeer(peerReference, value);
			}

			// Token: 0x060001B6 RID: 438
			public abstract IJavaPeerable PeekPeer(JniObjectReference reference);

			// Token: 0x060001B7 RID: 439 RVA: 0x0000956C File Offset: 0x0000776C
			public object PeekValue(JniObjectReference reference)
			{
				if (this.disposed)
				{
					throw new ObjectDisposedException(base.GetType().Name);
				}
				if (!reference.IsValid)
				{
					return null;
				}
				IJavaPeerable javaPeerable = this.PeekPeer(reference);
				if (javaPeerable == null)
				{
					return javaPeerable;
				}
				object result;
				if (!this.TryUnboxPeerObject(javaPeerable, out result))
				{
					return javaPeerable;
				}
				return result;
			}

			// Token: 0x060001B8 RID: 440 RVA: 0x000095B8 File Offset: 0x000077B8
			protected virtual bool TryUnboxPeerObject(IJavaPeerable value, out object result)
			{
				result = null;
				JavaProxyObject javaProxyObject = value as JavaProxyObject;
				if (javaProxyObject != null)
				{
					result = javaProxyObject.Value;
					return true;
				}
				JavaProxyThrowable javaProxyThrowable = value as JavaProxyThrowable;
				if (javaProxyThrowable != null)
				{
					result = javaProxyThrowable.Exception;
					return true;
				}
				return false;
			}

			// Token: 0x060001B9 RID: 441 RVA: 0x000095F4 File Offset: 0x000077F4
			private static Type GetPeerType(Type type)
			{
				foreach (KeyValuePair<Type, Type> keyValuePair in JniRuntime.JniValueManager.PeerTypeMappings)
				{
					if (keyValuePair.Key == type)
					{
						return keyValuePair.Value;
					}
				}
				return type;
			}

			// Token: 0x060001BA RID: 442 RVA: 0x00009638 File Offset: 0x00007838
			public virtual IJavaPeerable CreatePeer(ref JniObjectReference reference, JniObjectReferenceOptions transfer, Type targetType)
			{
				if (this.disposed)
				{
					throw new ObjectDisposedException(base.GetType().Name);
				}
				targetType = (targetType ?? typeof(JavaObject));
				targetType = JniRuntime.JniValueManager.GetPeerType(targetType);
				if (!typeof(IJavaPeerable).IsAssignableFrom(targetType))
				{
					throw new ArgumentException("targetType `" + targetType.AssemblyQualifiedName + "` must implement IJavaPeerable!", "targetType");
				}
				ConstructorInfo peerConstructor = this.GetPeerConstructor(reference, targetType);
				if (peerConstructor == null)
				{
					throw new NotSupportedException(string.Format("Could not find an appropriate constructable wrapper type for Java type '{0}', targetType='{1}'.", JniEnvironment.Types.GetJniTypeNameFromInstance(reference), targetType));
				}
				object[] array = new object[]
				{
					reference,
					transfer
				};
				IJavaPeerable result;
				try
				{
					IJavaPeerable javaPeerable = (IJavaPeerable)peerConstructor.Invoke(array);
					javaPeerable.SetJniManagedPeerState(javaPeerable.JniManagedPeerState | JniManagedPeerStates.Replaceable);
					result = javaPeerable;
				}
				finally
				{
					reference = (JniObjectReference)array[0];
				}
				return result;
			}

			// Token: 0x060001BB RID: 443 RVA: 0x00009738 File Offset: 0x00007938
			private ConstructorInfo GetPeerConstructor(JniObjectReference instance, Type fallbackType)
			{
				JniObjectReference type = JniEnvironment.Types.GetObjectClass(instance);
				string signature = JniEnvironment.Types.GetJniTypeNameFromClass(type);
				while (signature != null)
				{
					JniTypeSignature typeSignature;
					if (!JniTypeSignature.TryParse(signature, out typeSignature))
					{
						return null;
					}
					Type type2 = this.Runtime.TypeManager.GetType(typeSignature);
					if (type2 != null)
					{
						ConstructorInfo activationConstructor = JniRuntime.JniValueManager.GetActivationConstructor(type2);
						if (activationConstructor != null)
						{
							JniObjectReference.Dispose(ref type);
							return activationConstructor;
						}
					}
					JniObjectReference superclass = JniEnvironment.Types.GetSuperclass(type);
					signature = (superclass.IsValid ? JniEnvironment.Types.GetJniTypeNameFromClass(superclass) : null);
					JniObjectReference.Dispose(ref type, JniObjectReferenceOptions.CopyAndDispose);
					type = superclass;
				}
				JniObjectReference.Dispose(ref type, JniObjectReferenceOptions.CopyAndDispose);
				return JniRuntime.JniValueManager.GetActivationConstructor(fallbackType);
			}

			// Token: 0x060001BC RID: 444 RVA: 0x000097D4 File Offset: 0x000079D4
			private static ConstructorInfo GetActivationConstructor(Type type)
			{
				return (from c in type.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
				let p = c.GetParameters()
				where p.Length == 2 && p[0].ParameterType == JniRuntime.JniValueManager.ByRefJniObjectReference && p[1].ParameterType == typeof(JniObjectReferenceOptions)
				select c).FirstOrDefault<ConstructorInfo>();
			}

			// Token: 0x060001BD RID: 445 RVA: 0x0000985C File Offset: 0x00007A5C
			internal Type GetRuntimeType(JniObjectReference reference)
			{
				if (!reference.IsValid)
				{
					return null;
				}
				JniTypeSignature typeSignature;
				if (!JniTypeSignature.TryParse(JniEnvironment.Types.GetJniTypeNameFromInstance(reference), out typeSignature))
				{
					return null;
				}
				return this.Runtime.TypeManager.GetType(typeSignature);
			}

			// Token: 0x060001BE RID: 446 RVA: 0x00009898 File Offset: 0x00007A98
			public object GetValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType = null)
			{
				if (this.disposed)
				{
					throw new ObjectDisposedException(base.GetType().Name);
				}
				if (!reference.IsValid)
				{
					return null;
				}
				object obj = this.PeekValue(reference);
				if (obj != null && (targetType == null || targetType.IsAssignableFrom(obj.GetType())))
				{
					JniObjectReference.Dispose(ref reference, options);
					return obj;
				}
				if (targetType != null && typeof(IJavaPeerable).IsAssignableFrom(targetType))
				{
					return JavaPeerableValueMarshaler.Instance.CreateGenericValue(ref reference, options, targetType);
				}
				targetType = (targetType ?? this.GetRuntimeType(reference));
				if (targetType == null)
				{
					return JavaPeerableValueMarshaler.Instance.CreateGenericValue(ref reference, options, targetType);
				}
				return this.GetValueMarshaler(targetType).CreateValue(ref reference, options, targetType);
			}

			// Token: 0x060001BF RID: 447 RVA: 0x0000995C File Offset: 0x00007B5C
			public T GetValue<T>(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType = null)
			{
				if (!reference.IsValid)
				{
					return default(T);
				}
				if (targetType != null && !typeof(T).IsAssignableFrom(targetType))
				{
					throw new ArgumentException(string.Format("Requested runtime '{0}' value of '{1}' is not compatible with requested compile-time type T of '{2}'.", "targetType", targetType, typeof(T)), "targetType");
				}
				targetType = (targetType ?? typeof(T));
				object obj = this.PeekValue(reference);
				if (obj != null && (targetType == null || targetType.IsAssignableFrom(obj.GetType())))
				{
					JniObjectReference.Dispose(ref reference, options);
					return (T)((object)obj);
				}
				if (typeof(IJavaPeerable).IsAssignableFrom(targetType))
				{
					return (T)((object)JavaPeerableValueMarshaler.Instance.CreateGenericValue(ref reference, options, targetType));
				}
				return this.GetValueMarshaler<T>().CreateGenericValue(ref reference, options, targetType);
			}

			// Token: 0x060001C0 RID: 448 RVA: 0x00009A34 File Offset: 0x00007C34
			public JniValueMarshaler<T> GetValueMarshaler<T>()
			{
				if (this.disposed)
				{
					throw new ObjectDisposedException(base.GetType().Name);
				}
				JniValueMarshaler valueMarshaler = this.GetValueMarshaler(typeof(T));
				JniValueMarshaler<T> jniValueMarshaler = valueMarshaler as JniValueMarshaler<T>;
				if (jniValueMarshaler != null)
				{
					return jniValueMarshaler;
				}
				Dictionary<Type, JniValueMarshaler> marshalers = this.Marshalers;
				JniValueMarshaler<T> result;
				lock (marshalers)
				{
					JniValueMarshaler jniValueMarshaler2;
					if (!this.Marshalers.TryGetValue(typeof(T), out jniValueMarshaler2))
					{
						this.Marshalers.Add(typeof(T), jniValueMarshaler2 = new DelegatingValueMarshaler<T>(valueMarshaler));
					}
					result = (JniValueMarshaler<T>)jniValueMarshaler2;
				}
				return result;
			}

			// Token: 0x060001C1 RID: 449 RVA: 0x00009AE8 File Offset: 0x00007CE8
			public JniValueMarshaler GetValueMarshaler(Type type)
			{
				if (this.disposed)
				{
					throw new ObjectDisposedException(base.GetType().Name);
				}
				if (type == null)
				{
					throw new ArgumentNullException("type");
				}
				if (type.ContainsGenericParameters)
				{
					throw new ArgumentException("Generic type definitions are not supported.", "type");
				}
				JniValueMarshalerAttribute customAttribute = type.GetCustomAttribute<JniValueMarshalerAttribute>();
				if (customAttribute != null)
				{
					return (JniValueMarshaler)Activator.CreateInstance(customAttribute.MarshalerType);
				}
				if (typeof(IJavaPeerable) == type)
				{
					return JavaPeerableValueMarshaler.Instance;
				}
				if (typeof(void) == type)
				{
					return VoidValueMarshaler.Instance;
				}
				foreach (KeyValuePair<Type, JniValueMarshaler> keyValuePair in JniRuntime.JniBuiltinMarshalers.Value)
				{
					if (keyValuePair.Key == type)
					{
						return keyValuePair.Value;
					}
				}
				Type listIface = typeof(IList<>);
				Type type2 = (from iface in type.GetInterfaces().Concat(new Type[]
				{
					type
				})
				where listIface.IsAssignableFrom(iface.IsGenericType ? iface.GetGenericTypeDefinition() : iface)
				select iface).FirstOrDefault<Type>();
				if (type2 != null)
				{
					Type type3 = type2.GenericTypeArguments[0];
					if (type3.IsValueType)
					{
						foreach (KeyValuePair<Type, JniValueMarshaler> keyValuePair2 in JniRuntime.JniPrimitiveArrayMarshalers.Value)
						{
							if (type.IsAssignableFrom(keyValuePair2.Key))
							{
								return keyValuePair2.Value;
							}
						}
					}
					return JniRuntime.JniValueManager.GetObjectArrayMarshaler(type3);
				}
				if (typeof(IJavaPeerable).IsAssignableFrom(type))
				{
					return JavaPeerableValueMarshaler.Instance;
				}
				JniValueMarshalerAttribute jniValueMarshalerAttribute = null;
				Type[] interfaces = type.GetInterfaces();
				for (int i = 0; i < interfaces.Length; i++)
				{
					customAttribute = interfaces[i].GetCustomAttribute<JniValueMarshalerAttribute>();
					if (customAttribute != null)
					{
						if (jniValueMarshalerAttribute != null)
						{
							throw new NotSupportedException(string.Format("There is more than one interface with custom marshaler for type {0}.", type));
						}
						jniValueMarshalerAttribute = customAttribute;
					}
				}
				if (jniValueMarshalerAttribute != null)
				{
					return (JniValueMarshaler)Activator.CreateInstance(jniValueMarshalerAttribute.MarshalerType);
				}
				return this.GetValueMarshalerCore(type);
			}

			// Token: 0x060001C2 RID: 450 RVA: 0x00009CE4 File Offset: 0x00007EE4
			private static JniValueMarshaler GetObjectArrayMarshaler(Type elementType)
			{
				MethodInfo method = new Func<JniValueMarshaler>(JniRuntime.JniValueManager.GetObjectArrayMarshalerHelper<object>).Method.GetGenericMethodDefinition().MakeGenericMethod(new Type[]
				{
					elementType
				});
				return ((Func<JniValueMarshaler>)Delegate.CreateDelegate(typeof(Func<JniValueMarshaler>), method))();
			}

			// Token: 0x060001C3 RID: 451 RVA: 0x00009D31 File Offset: 0x00007F31
			private static JniValueMarshaler GetObjectArrayMarshalerHelper<T>()
			{
				return JavaObjectArray<T>.Instance;
			}

			// Token: 0x060001C4 RID: 452 RVA: 0x00009D38 File Offset: 0x00007F38
			protected virtual JniValueMarshaler GetValueMarshalerCore(Type type)
			{
				return ProxyValueMarshaler.Instance;
			}

			// Token: 0x04000058 RID: 88
			private JniRuntime runtime;

			// Token: 0x04000059 RID: 89
			private bool disposed;

			// Token: 0x0400005A RID: 90
			private static readonly KeyValuePair<Type, Type>[] PeerTypeMappings = new KeyValuePair<Type, Type>[]
			{
				new KeyValuePair<Type, Type>(typeof(object), typeof(JavaObject)),
				new KeyValuePair<Type, Type>(typeof(IJavaPeerable), typeof(JavaObject)),
				new KeyValuePair<Type, Type>(typeof(Exception), typeof(JavaException))
			};

			// Token: 0x0400005B RID: 91
			private static readonly Type ByRefJniObjectReference = typeof(JniObjectReference).MakeByRefType();

			// Token: 0x0400005C RID: 92
			private Dictionary<Type, JniValueMarshaler> Marshalers = new Dictionary<Type, JniValueMarshaler>();
		}

		// Token: 0x02000022 RID: 34
		public class CreationOptions
		{
			// Token: 0x17000031 RID: 49
			// (get) Token: 0x060001CE RID: 462 RVA: 0x00009E71 File Offset: 0x00008071
			public bool TrackIDs { get; }

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x060001CF RID: 463 RVA: 0x00009E79 File Offset: 0x00008079
			public bool DestroyRuntimeOnDispose { get; }

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x060001D0 RID: 464 RVA: 0x00009E81 File Offset: 0x00008081
			// (set) Token: 0x060001D1 RID: 465 RVA: 0x00009E89 File Offset: 0x00008089
			public bool NewObjectRequired { get; set; }

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x060001D2 RID: 466 RVA: 0x00009E92 File Offset: 0x00008092
			// (set) Token: 0x060001D3 RID: 467 RVA: 0x00009E9A File Offset: 0x0000809A
			public JniVersion JniVersion { get; set; }

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x060001D4 RID: 468 RVA: 0x00009EA3 File Offset: 0x000080A3
			// (set) Token: 0x060001D5 RID: 469 RVA: 0x00009EAB File Offset: 0x000080AB
			public IntPtr InvocationPointer { get; set; }

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x060001D6 RID: 470 RVA: 0x00009EB4 File Offset: 0x000080B4
			// (set) Token: 0x060001D7 RID: 471 RVA: 0x00009EBC File Offset: 0x000080BC
			public IntPtr EnvironmentPointer { get; set; }

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x060001D8 RID: 472 RVA: 0x00009EC5 File Offset: 0x000080C5
			// (set) Token: 0x060001D9 RID: 473 RVA: 0x00009ECD File Offset: 0x000080CD
			public JniObjectReference ClassLoader { get; set; }

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x060001DA RID: 474 RVA: 0x00009ED6 File Offset: 0x000080D6
			// (set) Token: 0x060001DB RID: 475 RVA: 0x00009EDE File Offset: 0x000080DE
			public IntPtr ClassLoader_LoadClass_id { get; set; }

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x060001DC RID: 476 RVA: 0x00009EE7 File Offset: 0x000080E7
			// (set) Token: 0x060001DD RID: 477 RVA: 0x00009EEF File Offset: 0x000080EF
			public JniRuntime.JniObjectReferenceManager ObjectReferenceManager { get; set; }

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x060001DE RID: 478 RVA: 0x00009EF8 File Offset: 0x000080F8
			// (set) Token: 0x060001DF RID: 479 RVA: 0x00009F00 File Offset: 0x00008100
			public JniRuntime.JniTypeManager TypeManager { get; set; }

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x060001E0 RID: 480 RVA: 0x00009F09 File Offset: 0x00008109
			// (set) Token: 0x060001E1 RID: 481 RVA: 0x00009F11 File Offset: 0x00008111
			public bool JniAddNativeMethodRegistrationAttributePresent { get; set; } = true;

			// Token: 0x060001E2 RID: 482 RVA: 0x00009F1A File Offset: 0x0000811A
			public CreationOptions()
			{
				this.JniVersion = JniVersion.v1_2;
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x060001E3 RID: 483 RVA: 0x00009F3B File Offset: 0x0000813B
			// (set) Token: 0x060001E4 RID: 484 RVA: 0x00009F43 File Offset: 0x00008143
			public bool UseMarshalMemberBuilder { get; set; } = true;

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x060001E5 RID: 485 RVA: 0x00009F4C File Offset: 0x0000814C
			public JniRuntime.JniMarshalMemberBuilder MarshalMemberBuilder { get; }

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x060001E6 RID: 486 RVA: 0x00009F54 File Offset: 0x00008154
			// (set) Token: 0x060001E7 RID: 487 RVA: 0x00009F5C File Offset: 0x0000815C
			public JniRuntime.JniValueManager ValueManager { get; set; }
		}

		// Token: 0x02000023 RID: 35
		private interface ISetRuntime
		{
			// Token: 0x060001E8 RID: 488
			void OnSetRuntime(JniRuntime runtime);
		}

		// Token: 0x02000024 RID: 36
		public abstract class JniMarshalMemberBuilder : JniRuntime.ISetRuntime
		{
			// Token: 0x060001E9 RID: 489 RVA: 0x00009F65 File Offset: 0x00008165
			public virtual void OnSetRuntime(JniRuntime runtime)
			{
				if (this.disposed)
				{
					throw new ObjectDisposedException(base.GetType().Name);
				}
				this.runtime = runtime;
			}

			// Token: 0x060001EA RID: 490 RVA: 0x00009F87 File Offset: 0x00008187
			public void Dispose()
			{
				this.Dispose(false);
			}

			// Token: 0x060001EB RID: 491 RVA: 0x00009F90 File Offset: 0x00008190
			protected virtual void Dispose(bool disposing)
			{
				this.disposed = true;
			}

			// Token: 0x04000070 RID: 112
			private JniRuntime runtime;

			// Token: 0x04000071 RID: 113
			private bool disposed;
		}

		// Token: 0x02000025 RID: 37
		public abstract class JniObjectReferenceManager : IDisposable, JniRuntime.ISetRuntime
		{
			// Token: 0x060001EC RID: 492 RVA: 0x000032A7 File Offset: 0x000014A7
			public JniObjectReferenceManager()
			{
			}

			// Token: 0x060001ED RID: 493 RVA: 0x00009F99 File Offset: 0x00008199
			public virtual void OnSetRuntime(JniRuntime runtime)
			{
				this.runtime = runtime;
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060001EE RID: 494
			public abstract int GlobalReferenceCount { get; }

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060001EF RID: 495
			public abstract int WeakGlobalReferenceCount { get; }

			// Token: 0x060001F0 RID: 496 RVA: 0x00009FA4 File Offset: 0x000081A4
			internal JniObjectReference CreateLocalReference(JniEnvironmentInfo environment, JniObjectReference reference)
			{
				int localReferenceCount = environment.LocalReferenceCount;
				JniObjectReference result = this.CreateLocalReference(reference, ref localReferenceCount);
				environment.LocalReferenceCount = localReferenceCount;
				return result;
			}

			// Token: 0x060001F1 RID: 497 RVA: 0x00009FC8 File Offset: 0x000081C8
			public virtual JniObjectReference CreateLocalReference(JniObjectReference reference, ref int localReferenceCount)
			{
				if (!reference.IsValid)
				{
					return reference;
				}
				int num = localReferenceCount;
				localReferenceCount++;
				return JniEnvironment.References.NewLocalRef(reference);
			}

			// Token: 0x060001F2 RID: 498 RVA: 0x00009FE8 File Offset: 0x000081E8
			internal void DeleteLocalReference(JniEnvironmentInfo environment, ref JniObjectReference reference)
			{
				int localReferenceCount = environment.LocalReferenceCount;
				this.DeleteLocalReference(ref reference, ref localReferenceCount);
				environment.LocalReferenceCount = localReferenceCount;
			}

			// Token: 0x060001F3 RID: 499 RVA: 0x0000A00C File Offset: 0x0000820C
			public virtual void DeleteLocalReference(ref JniObjectReference reference, ref int localReferenceCount)
			{
				if (!reference.IsValid)
				{
					return;
				}
				localReferenceCount--;
				int num = localReferenceCount;
				JniEnvironment.References.DeleteLocalRef(reference.Handle);
				reference.Invalidate();
			}

			// Token: 0x060001F4 RID: 500 RVA: 0x0000A034 File Offset: 0x00008234
			internal void CreatedLocalReference(JniEnvironmentInfo environment, JniObjectReference reference)
			{
				int localReferenceCount = environment.LocalReferenceCount;
				this.CreatedLocalReference(reference, ref localReferenceCount);
				environment.LocalReferenceCount = localReferenceCount;
			}

			// Token: 0x060001F5 RID: 501 RVA: 0x0000A058 File Offset: 0x00008258
			public virtual void CreatedLocalReference(JniObjectReference reference, ref int localReferenceCount)
			{
				if (!reference.IsValid)
				{
					return;
				}
				int num = localReferenceCount;
				localReferenceCount++;
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060001F6 RID: 502 RVA: 0x000021BF File Offset: 0x000003BF
			public virtual bool LogGlobalReferenceMessages
			{
				get
				{
					return false;
				}
			}

			// Token: 0x060001F7 RID: 503 RVA: 0x000025B2 File Offset: 0x000007B2
			public virtual void WriteGlobalReferenceLine(string format, params object[] args)
			{
			}

			// Token: 0x060001F8 RID: 504 RVA: 0x0000A06F File Offset: 0x0000826F
			public virtual JniObjectReference CreateGlobalReference(JniObjectReference reference)
			{
				if (!reference.IsValid)
				{
					return reference;
				}
				JniObjectReference result = JniEnvironment.References.NewGlobalRef(reference);
				int globalReferenceCount = this.GlobalReferenceCount;
				return result;
			}

			// Token: 0x060001F9 RID: 505 RVA: 0x0000A08B File Offset: 0x0000828B
			public virtual void DeleteGlobalReference(ref JniObjectReference reference)
			{
				if (!reference.IsValid)
				{
					return;
				}
				int globalReferenceCount = this.GlobalReferenceCount;
				JniEnvironment.References.DeleteGlobalRef(reference.Handle);
				reference.Invalidate();
			}

			// Token: 0x060001FA RID: 506 RVA: 0x0000A0B0 File Offset: 0x000082B0
			public virtual void DeleteWeakGlobalReference(ref JniObjectReference reference)
			{
				if (!reference.IsValid)
				{
					return;
				}
				int weakGlobalReferenceCount = this.WeakGlobalReferenceCount;
				JniEnvironment.References.DeleteWeakGlobalRef(reference.Handle);
				reference.Invalidate();
			}

			// Token: 0x060001FB RID: 507 RVA: 0x0000A0D5 File Offset: 0x000082D5
			public void Dispose()
			{
				this.Dispose(false);
			}

			// Token: 0x060001FC RID: 508 RVA: 0x000025B2 File Offset: 0x000007B2
			protected virtual void Dispose(bool disposing)
			{
			}

			// Token: 0x04000072 RID: 114
			private JniRuntime runtime;
		}

		// Token: 0x02000026 RID: 38
		public class JniTypeManager : IDisposable, JniRuntime.ISetRuntime
		{
			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060001FD RID: 509 RVA: 0x0000A0DE File Offset: 0x000082DE
			public JniRuntime Runtime
			{
				get
				{
					JniRuntime jniRuntime = this.runtime;
					if (jniRuntime == null)
					{
						throw new NotSupportedException();
					}
					return jniRuntime;
				}
			}

			// Token: 0x060001FE RID: 510 RVA: 0x0000A0F0 File Offset: 0x000082F0
			public virtual void OnSetRuntime(JniRuntime runtime)
			{
				this.AssertValid();
				this.runtime = runtime;
			}

			// Token: 0x060001FF RID: 511 RVA: 0x0000A0FF File Offset: 0x000082FF
			public void Dispose()
			{
				this.Dispose(false);
			}

			// Token: 0x06000200 RID: 512 RVA: 0x0000A108 File Offset: 0x00008308
			protected virtual void Dispose(bool disposing)
			{
				this.disposed = true;
			}

			// Token: 0x06000201 RID: 513 RVA: 0x0000A111 File Offset: 0x00008311
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private void AssertValid()
			{
				if (!this.disposed)
				{
					return;
				}
				throw new ObjectDisposedException("JniTypeManager");
			}

			// Token: 0x06000202 RID: 514 RVA: 0x0000A128 File Offset: 0x00008328
			internal static void AssertSimpleReference(string jniSimpleReference, string argumentName = "jniSimpleReference")
			{
				if (string.IsNullOrEmpty(jniSimpleReference))
				{
					throw new ArgumentNullException(argumentName);
				}
				if (jniSimpleReference.IndexOf('.') >= 0)
				{
					throw new ArgumentException("JNI type names do not contain '.', they use '/'. Are you sure you're using a JNI type name?", argumentName);
				}
				char c = jniSimpleReference[0];
				if (c != 'L')
				{
					if (c == '[')
					{
						throw new ArgumentException("Arrays cannot be present in simplified type references.", argumentName);
					}
				}
				else if (jniSimpleReference[jniSimpleReference.Length - 1] == ';')
				{
					throw new ArgumentException("JNI type references are not supported.", argumentName);
				}
			}

			// Token: 0x06000203 RID: 515 RVA: 0x0000A198 File Offset: 0x00008398
			public JniTypeSignature GetTypeSignature(Type type)
			{
				this.AssertValid();
				if (type == null)
				{
					throw new ArgumentNullException("type");
				}
				if (type.ContainsGenericParameters)
				{
					throw new ArgumentException(string.Format("'{0}' contains a generic type definition. This is not supported.", type), "type");
				}
				int num;
				type = JniRuntime.JniTypeManager.GetUnderlyingType(type, out num);
				JniTypeSignature empty = JniTypeSignature.Empty;
				if (JniRuntime.GetBuiltInTypeSignature(type, ref empty))
				{
					return empty.AddArrayRank(num);
				}
				if (JniRuntime.GetBuiltInTypeArraySignature(type, ref empty))
				{
					return empty.AddArrayRank(num);
				}
				string simpleReference = this.GetSimpleReference(type);
				if (simpleReference != null)
				{
					return new JniTypeSignature(simpleReference, num, false);
				}
				JniTypeSignatureAttribute customAttribute = type.GetCustomAttribute(false);
				if (customAttribute != null)
				{
					return new JniTypeSignature(customAttribute.SimpleReference, customAttribute.ArrayRank + num, customAttribute.IsKeyword);
				}
				bool isGenericType = type.IsGenericType;
				Type type2 = isGenericType ? type.GetGenericTypeDefinition() : type;
				if (isGenericType && (type2 == typeof(JavaArray<>) || type2 == typeof(JavaObjectArray<>)))
				{
					return this.GetTypeSignature(type.GenericTypeArguments[0]).AddArrayRank(num + 1);
				}
				if (isGenericType)
				{
					simpleReference = this.GetSimpleReference(type2);
					if (simpleReference != null)
					{
						return new JniTypeSignature(simpleReference, num, false);
					}
				}
				return default(JniTypeSignature);
			}

			// Token: 0x06000204 RID: 516 RVA: 0x0000A2CC File Offset: 0x000084CC
			private static Type GetUnderlyingType(Type type, out int rank)
			{
				rank = 0;
				Type type2 = type;
				while (type.IsArray)
				{
					if (type.IsArray && type.GetArrayRank() > 1)
					{
						throw new ArgumentException("Multidimensional array '" + type2.FullName + "' is not supported.", "type");
					}
					rank++;
					type = type.GetElementType();
				}
				if (type.IsEnum)
				{
					type = Enum.GetUnderlyingType(type);
				}
				return type;
			}

			// Token: 0x06000205 RID: 517 RVA: 0x0000A338 File Offset: 0x00008538
			protected virtual string GetSimpleReference(Type type)
			{
				return this.GetSimpleReferences(type).FirstOrDefault<string>();
			}

			// Token: 0x06000206 RID: 518 RVA: 0x0000A348 File Offset: 0x00008548
			protected virtual IEnumerable<string> GetSimpleReferences(Type type)
			{
				this.AssertValid();
				if (type == null)
				{
					throw new ArgumentNullException("type");
				}
				if (type.IsArray)
				{
					throw new ArgumentException("Array type '" + type.FullName + "' is not supported.", "type");
				}
				return JniRuntime.JniTypeManager.EmptyStringArray;
			}

			// Token: 0x06000207 RID: 519 RVA: 0x0000A39C File Offset: 0x0000859C
			public Type GetType(JniTypeSignature typeSignature)
			{
				this.AssertValid();
				return this.GetTypes(typeSignature).FirstOrDefault<Type>();
			}

			// Token: 0x06000208 RID: 520 RVA: 0x0000A3B0 File Offset: 0x000085B0
			public virtual IEnumerable<Type> GetTypes(JniTypeSignature typeSignature)
			{
				this.AssertValid();
				if (typeSignature.SimpleReference == null)
				{
					return JniRuntime.JniTypeManager.EmptyTypeArray;
				}
				return this.CreateGetTypesEnumerator(typeSignature);
			}

			// Token: 0x06000209 RID: 521 RVA: 0x0000A3CE File Offset: 0x000085CE
			private IEnumerable<Type> CreateGetTypesEnumerator(JniTypeSignature typeSignature)
			{
				if (!typeSignature.IsValid)
				{
					yield break;
				}
				string simpleReference = typeSignature.SimpleReference;
				if (simpleReference == null)
				{
					throw new InvalidOperationException("Should not be reached");
				}
				foreach (Type type in this.GetTypesForSimpleReference(simpleReference))
				{
					if (typeSignature.ArrayRank == 0)
					{
						yield return type;
					}
					else
					{
						if (typeSignature.ArrayRank > 0)
						{
							int num = typeSignature.ArrayRank;
							Type type2 = type;
							if (typeSignature.IsKeyword)
							{
								type2 = typeof(JavaPrimitiveArray<>).MakeGenericType(new Type[]
								{
									type2
								});
								num--;
							}
							while (num-- > 0)
							{
								type2 = typeof(JavaObjectArray<>).MakeGenericType(new Type[]
								{
									type2
								});
							}
							yield return type2;
						}
						if (typeSignature.ArrayRank > 0)
						{
							int arrayRank = typeSignature.ArrayRank;
							Type type3 = type;
							while (arrayRank-- > 0)
							{
								type3 = type3.MakeArrayType();
							}
							yield return type3;
						}
						type = null;
					}
				}
				IEnumerator<Type> enumerator = null;
				yield break;
				yield break;
			}

			// Token: 0x0600020A RID: 522 RVA: 0x0000A3E5 File Offset: 0x000085E5
			protected virtual IEnumerable<Type> GetTypesForSimpleReference(string jniSimpleReference)
			{
				this.AssertValid();
				JniRuntime.JniTypeManager.AssertSimpleReference(jniSimpleReference, "jniSimpleReference");
				return this.CreateGetTypesForSimpleReferenceEnumerator(jniSimpleReference);
			}

			// Token: 0x0600020B RID: 523 RVA: 0x0000A3FF File Offset: 0x000085FF
			private IEnumerable<Type> CreateGetTypesForSimpleReferenceEnumerator(string jniSimpleReference)
			{
				Type type;
				if (JniRuntime.JniBuiltinSimpleReferenceToType.Value.TryGetValue(jniSimpleReference, out type))
				{
					yield return type;
				}
				yield break;
			}

			// Token: 0x0600020C RID: 524 RVA: 0x0000A40F File Offset: 0x0000860F
			public virtual void RegisterNativeMembers(JniType nativeClass, Type type, string methods)
			{
				this.TryRegisterNativeMembers(nativeClass, type, methods);
			}

			// Token: 0x0600020D RID: 525 RVA: 0x0000A41B File Offset: 0x0000861B
			protected bool TryRegisterNativeMembers(JniType nativeClass, Type type, string methods)
			{
				this.AssertValid();
				return this.TryLoadJniMarshalMethods(nativeClass, type, methods) || this.TryRegisterNativeMembers(nativeClass, type, methods, null);
			}

			// Token: 0x0600020E RID: 526 RVA: 0x0000A43C File Offset: 0x0000863C
			private bool TryLoadJniMarshalMethods(JniType nativeClass, Type type, string methods)
			{
				Type type2 = (type != null) ? type.GetNestedType("__<$>_jni_marshal_methods", BindingFlags.NonPublic) : null;
				if (type2 == null)
				{
					return false;
				}
				MethodInfo runtimeMethod = type2.GetRuntimeMethod("__RegisterNativeMembers", JniRuntime.JniTypeManager.registerMethodParameters);
				return this.TryRegisterNativeMembers(nativeClass, type2, methods, runtimeMethod);
			}

			// Token: 0x0600020F RID: 527 RVA: 0x0000A484 File Offset: 0x00008684
			private bool TryRegisterNativeMembers(JniType nativeClass, Type marshalType, string methods, MethodInfo registerMethod)
			{
				bool flag = false;
				bool result = false;
				try
				{
					Monitor.TryEnter(JniRuntime.JniTypeManager.sharedRegistrations, ref flag);
					List<JniNativeMethodRegistration> list;
					if (flag)
					{
						JniRuntime.JniTypeManager.sharedRegistrations.Clear();
						list = JniRuntime.JniTypeManager.sharedRegistrations;
					}
					else
					{
						list = new List<JniNativeMethodRegistration>();
					}
					JniNativeMethodRegistrationArguments jniNativeMethodRegistrationArguments = new JniNativeMethodRegistrationArguments(list, methods);
					if (registerMethod != null)
					{
						registerMethod.Invoke(null, new object[]
						{
							jniNativeMethodRegistrationArguments
						});
						result = true;
					}
					else
					{
						result = this.FindAndCallRegisterMethod(marshalType, jniNativeMethodRegistrationArguments);
					}
					if (list.Count > 0)
					{
						nativeClass.RegisterNativeMethods(list.ToArray());
					}
				}
				finally
				{
					if (flag)
					{
						Monitor.Exit(JniRuntime.JniTypeManager.sharedRegistrations);
					}
				}
				return result;
			}

			// Token: 0x06000210 RID: 528 RVA: 0x0000A52C File Offset: 0x0000872C
			private bool FindAndCallRegisterMethod(Type marshalType, JniNativeMethodRegistrationArguments arguments)
			{
				if (!this.Runtime.JniAddNativeMethodRegistrationAttributePresent)
				{
					return false;
				}
				bool result = false;
				foreach (MethodInfo methodInfo in marshalType.GetRuntimeMethods())
				{
					if (methodInfo.GetCustomAttribute(typeof(JniAddNativeMethodRegistrationAttribute)) != null)
					{
						if ((methodInfo.Attributes & MethodAttributes.Static) != MethodAttributes.Static)
						{
							throw new InvalidOperationException(string.Format("The method {0} marked with {1} must be static", methodInfo, "JniAddNativeMethodRegistrationAttribute"));
						}
						((Action<JniNativeMethodRegistrationArguments>)methodInfo.CreateDelegate(typeof(Action<JniNativeMethodRegistrationArguments>)))(arguments);
						result = true;
					}
				}
				return result;
			}

			// Token: 0x04000073 RID: 115
			private JniRuntime runtime;

			// Token: 0x04000074 RID: 116
			private bool disposed;

			// Token: 0x04000075 RID: 117
			private static readonly string[] EmptyStringArray = Array.Empty<string>();

			// Token: 0x04000076 RID: 118
			private static readonly Type[] EmptyTypeArray = Array.Empty<Type>();

			// Token: 0x04000077 RID: 119
			private static Type[] registerMethodParameters = new Type[]
			{
				typeof(JniNativeMethodRegistrationArguments)
			};

			// Token: 0x04000078 RID: 120
			private static List<JniNativeMethodRegistration> sharedRegistrations = new List<JniNativeMethodRegistration>();
		}
	}
}
