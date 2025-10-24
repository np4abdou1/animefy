using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Android.Runtime;
using Java.Lang;

namespace Java.Interop
{
	// Token: 0x02000433 RID: 1075
	internal static class JavaConvert
	{
		// Token: 0x06002ED8 RID: 11992 RVA: 0x00081E98 File Offset: 0x00080098
		private static Func<IntPtr, JniHandleOwnership, object> GetJniHandleConverter(Type target)
		{
			if (target == null)
			{
				return null;
			}
			Func<IntPtr, JniHandleOwnership, object> result;
			if (JavaConvert.JniHandleConverters.TryGetValue(target, out result))
			{
				return result;
			}
			if (target.IsArray)
			{
				return (IntPtr h, JniHandleOwnership t) => JNIEnv.GetArray(h, t, target.GetElementType());
			}
			if (target.IsGenericType && target.GetGenericTypeDefinition() == typeof(IDictionary<, >))
			{
				return JavaConvert.GetJniHandleConverterForType(typeof(JavaDictionary<, >).MakeGenericType(target.GetGenericArguments()));
			}
			if (typeof(IDictionary).IsAssignableFrom(target))
			{
				return (IntPtr h, JniHandleOwnership t) => JavaDictionary.FromJniHandle(h, t);
			}
			if (target.IsGenericType && target.GetGenericTypeDefinition() == typeof(IList<>))
			{
				return JavaConvert.GetJniHandleConverterForType(typeof(JavaList<>).MakeGenericType(target.GetGenericArguments()));
			}
			if (typeof(IList).IsAssignableFrom(target))
			{
				return (IntPtr h, JniHandleOwnership t) => JavaList.FromJniHandle(h, t);
			}
			if (target.IsGenericType && target.GetGenericTypeDefinition() == typeof(ICollection<>))
			{
				return JavaConvert.GetJniHandleConverterForType(typeof(JavaCollection<>).MakeGenericType(target.GetGenericArguments()));
			}
			if (typeof(ICollection).IsAssignableFrom(target))
			{
				return (IntPtr h, JniHandleOwnership t) => JavaCollection.FromJniHandle(h, t);
			}
			return null;
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x00082074 File Offset: 0x00080274
		private static Func<IntPtr, JniHandleOwnership, object> GetJniHandleConverterForType([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] Type t)
		{
			MethodInfo method = t.GetMethod("FromJniHandle", BindingFlags.Static | BindingFlags.Public);
			return (Func<IntPtr, JniHandleOwnership, object>)Delegate.CreateDelegate(typeof(Func<IntPtr, JniHandleOwnership, object>), method);
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x000820A4 File Offset: 0x000802A4
		public static T FromJniHandle<T>(IntPtr handle, JniHandleOwnership transfer)
		{
			bool flag;
			return JavaConvert.FromJniHandle<T>(handle, transfer, out flag);
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x000820BC File Offset: 0x000802BC
		public static T FromJniHandle<T>(IntPtr handle, JniHandleOwnership transfer, out bool set)
		{
			if (handle == IntPtr.Zero)
			{
				set = false;
				return default(T);
			}
			IJavaObject javaObject = (IJavaObject)Java.Lang.Object.PeekObject(handle, null);
			if (javaObject != null)
			{
				T result = JavaConvert.FromJavaObject<T>(javaObject, out set);
				if (set)
				{
					JNIEnv.DeleteRef(handle, transfer);
					return result;
				}
			}
			set = true;
			if (typeof(IJavaObject).IsAssignableFrom(typeof(T)))
			{
				return Java.Lang.Object._GetObject<T>(handle, transfer);
			}
			Func<IntPtr, JniHandleOwnership, object> func = JavaConvert.GetJniHandleConverter(typeof(T)) ?? JavaConvert.GetJniHandleConverter(JavaConvert.GetTypeMapping(handle));
			if (func != null)
			{
				return (T)((object)func(handle, transfer));
			}
			IJavaPeerable @object = Java.Lang.Object.GetObject(handle, transfer, null);
			if (@object is T)
			{
				return (T)((object)@object);
			}
			return (T)((object)Convert.ChangeType(@object, typeof(T)));
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x00082190 File Offset: 0x00080390
		public static object FromJniHandle(IntPtr handle, JniHandleOwnership transfer, Type targetType = null)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
			IJavaObject javaObject = (IJavaObject)Java.Lang.Object.PeekObject(handle, null);
			if (javaObject != null)
			{
				object obj = JavaConvert.FromJavaObject(javaObject, targetType);
				if (obj != null)
				{
					JNIEnv.DeleteRef(handle, transfer);
					return obj;
				}
			}
			if (targetType != null && typeof(IJavaObject).IsAssignableFrom(targetType))
			{
				return Java.Lang.Object.GetObject(handle, transfer, targetType);
			}
			Func<IntPtr, JniHandleOwnership, object> func = (targetType != null) ? (JavaConvert.GetJniHandleConverter(targetType) ?? JavaConvert.GetJniHandleConverter(JavaConvert.GetTypeMapping(handle))) : JavaConvert.GetJniHandleConverter(JavaConvert.GetTypeMapping(handle));
			if (func != null)
			{
				return func(handle, transfer);
			}
			IJavaPeerable @object = Java.Lang.Object.GetObject(handle, transfer, null);
			if (@object != null && (targetType == null || targetType.IsAssignableFrom(@object.GetType())))
			{
				return @object;
			}
			return Convert.ChangeType(@object, targetType);
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x00082258 File Offset: 0x00080458
		private static Type GetTypeMapping(IntPtr handle)
		{
			JniObjectReference objectClass = JniEnvironment.Types.GetObjectClass(new JniObjectReference(handle, JniObjectReferenceType.Invalid));
			Type result;
			try
			{
				string className = TypeManager.GetClassName(objectClass.Handle);
				Type type;
				if (JavaConvert.TypeMappings.TryGetValue(className, out type))
				{
					result = type;
				}
				else if (JniEnvironment.Types.IsAssignableFrom(objectClass, new JniObjectReference(JavaDictionary.map_class, JniObjectReferenceType.Invalid)))
				{
					result = typeof(JavaDictionary);
				}
				else if (JniEnvironment.Types.IsAssignableFrom(objectClass, JavaList.list_members.JniPeerType.PeerReference))
				{
					result = typeof(JavaList);
				}
				else if (JniEnvironment.Types.IsAssignableFrom(objectClass, new JniObjectReference(JavaCollection.collection_class, JniObjectReferenceType.Invalid)))
				{
					result = typeof(JavaCollection);
				}
				else
				{
					result = null;
				}
			}
			finally
			{
				JniObjectReference.Dispose(ref objectClass);
			}
			return result;
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x00082314 File Offset: 0x00080514
		internal static string GetJniClassForType(Type type)
		{
			foreach (KeyValuePair<string, Type> keyValuePair in JavaConvert.TypeMappings)
			{
				if (keyValuePair.Value == type)
				{
					return keyValuePair.Key;
				}
			}
			return null;
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x0008237C File Offset: 0x0008057C
		public static T FromJavaObject<T>(IJavaObject value)
		{
			bool flag;
			return JavaConvert.FromJavaObject<T>(value, out flag);
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x00082394 File Offset: 0x00080594
		public static T FromJavaObject<T>(IJavaObject value, out bool set)
		{
			if (value == null)
			{
				set = false;
				return default(T);
			}
			if (typeof(IJavaObject).IsAssignableFrom(typeof(T)))
			{
				set = true;
				return value._JavaCast<T>();
			}
			JavaObject javaObject = value as JavaObject;
			if (javaObject != null)
			{
				set = true;
				if (javaObject.Instance is T)
				{
					return (T)((object)javaObject.Instance);
				}
				return (T)((object)Convert.ChangeType(javaObject.Instance, typeof(T)));
			}
			else
			{
				if (value is T)
				{
					set = true;
					return (T)((object)value);
				}
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				if (intPtr == IntPtr.Zero)
				{
					set = false;
					return default(T);
				}
				set = true;
				Func<IntPtr, JniHandleOwnership, object> jniHandleConverter = JavaConvert.GetJniHandleConverter(typeof(T));
				if (jniHandleConverter != null)
				{
					return (T)((object)jniHandleConverter(intPtr, JniHandleOwnership.TransferLocalRef));
				}
				JNIEnv.DeleteLocalRef(intPtr);
				return (T)((object)Convert.ChangeType(value, typeof(T)));
			}
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x0008248C File Offset: 0x0008068C
		public static object FromJavaObject(IJavaObject value, Type targetType = null)
		{
			if (value == null)
			{
				return null;
			}
			if (targetType != null && typeof(IJavaObject).IsAssignableFrom(targetType))
			{
				return JavaObjectExtensions.JavaCast(value, targetType);
			}
			JavaObject javaObject = value as JavaObject;
			if (javaObject != null)
			{
				if (targetType == null)
				{
					return javaObject.Instance;
				}
				return Convert.ChangeType(javaObject.Instance, targetType);
			}
			else
			{
				if (targetType == null || targetType.IsAssignableFrom(value.GetType()))
				{
					return value;
				}
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				if (intPtr == IntPtr.Zero)
				{
					return null;
				}
				Func<IntPtr, JniHandleOwnership, object> jniHandleConverter = JavaConvert.GetJniHandleConverter(targetType);
				if (jniHandleConverter != null)
				{
					return jniHandleConverter(intPtr, JniHandleOwnership.TransferLocalRef);
				}
				JNIEnv.DeleteLocalRef(intPtr);
				return Convert.ChangeType(value, targetType);
			}
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x00082538 File Offset: 0x00080738
		private static Func<object, IJavaObject> GetJavaObjectConverter(Type source)
		{
			Func<object, IJavaObject> result;
			if (JavaConvert.JavaObjectConverters.TryGetValue(source, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x00082558 File Offset: 0x00080758
		public static IJavaObject ToJavaObject<T>(T value)
		{
			if (value is IJavaObject)
			{
				return (IJavaObject)((object)value);
			}
			if (value == null)
			{
				return null;
			}
			Func<object, IJavaObject> javaObjectConverter = JavaConvert.GetJavaObjectConverter(typeof(T));
			if (javaObjectConverter != null)
			{
				return javaObjectConverter(value);
			}
			return new JavaObject(value);
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x000825B4 File Offset: 0x000807B4
		private static Func<object, IntPtr> GetLocalJniHandleConverter(object value)
		{
			Type type = value.GetType();
			Func<object, IntPtr> result;
			if (JavaConvert.LocalJniHandleConverters.TryGetValue(type, out result))
			{
				return result;
			}
			if (value != null && JavaConvert.LocalJniHandleConverters.TryGetValue(value.GetType(), out result))
			{
				return result;
			}
			if (type.IsArray)
			{
				return JavaConvert.LocalJniHandleConverters[typeof(Array)];
			}
			return JavaConvert.LocalJniHandleConverters[typeof(JavaObject)];
		}

		// Token: 0x06002EE5 RID: 12005 RVA: 0x00082624 File Offset: 0x00080824
		internal static IntPtr ToLocalJniHandle(object value)
		{
			if (value == null)
			{
				return IntPtr.Zero;
			}
			IJavaObject javaObject = value as IJavaObject;
			if (javaObject != null)
			{
				return JNIEnv.ToLocalJniHandle(javaObject);
			}
			return JavaConvert.GetLocalJniHandleConverter(value)(value);
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x00082658 File Offset: 0x00080858
		public static TReturn WithLocalJniHandle<TValue, TReturn>(TValue value, Func<IntPtr, TReturn> action)
		{
			IntPtr intPtr = JavaConvert.ToLocalJniHandle(value);
			TReturn result;
			try
			{
				result = action(intPtr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
			return result;
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x000826A0 File Offset: 0x000808A0
		public static TReturn WithLocalJniHandle<TReturn>(object value, Func<IntPtr, TReturn> action)
		{
			IntPtr intPtr = JavaConvert.ToLocalJniHandle(value);
			TReturn result;
			try
			{
				result = action(intPtr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
			return result;
		}

		// Token: 0x040012B6 RID: 4790
		private static Dictionary<Type, Func<IntPtr, JniHandleOwnership, object>> JniHandleConverters = new Dictionary<Type, Func<IntPtr, JniHandleOwnership, object>>
		{
			{
				typeof(bool),
				delegate(IntPtr handle, JniHandleOwnership transfer)
				{
					object result;
					using (Java.Lang.Boolean boolean = new Java.Lang.Boolean(handle, transfer | JniHandleOwnership.DoNotRegister))
					{
						result = boolean.BooleanValue();
					}
					return result;
				}
			},
			{
				typeof(byte),
				delegate(IntPtr handle, JniHandleOwnership transfer)
				{
					object result;
					using (Java.Lang.Byte @byte = new Java.Lang.Byte(handle, transfer | JniHandleOwnership.DoNotRegister))
					{
						result = (byte)@byte.ByteValue();
					}
					return result;
				}
			},
			{
				typeof(sbyte),
				delegate(IntPtr handle, JniHandleOwnership transfer)
				{
					object result;
					using (Java.Lang.Byte @byte = new Java.Lang.Byte(handle, transfer | JniHandleOwnership.DoNotRegister))
					{
						result = @byte.ByteValue();
					}
					return result;
				}
			},
			{
				typeof(char),
				delegate(IntPtr handle, JniHandleOwnership transfer)
				{
					object result;
					using (Character character = new Character(handle, transfer | JniHandleOwnership.DoNotRegister))
					{
						result = character.CharValue();
					}
					return result;
				}
			},
			{
				typeof(short),
				delegate(IntPtr handle, JniHandleOwnership transfer)
				{
					object result;
					using (Short @short = new Short(handle, transfer | JniHandleOwnership.DoNotRegister))
					{
						result = @short.ShortValue();
					}
					return result;
				}
			},
			{
				typeof(int),
				delegate(IntPtr handle, JniHandleOwnership transfer)
				{
					object result;
					using (Integer integer = new Integer(handle, transfer | JniHandleOwnership.DoNotRegister))
					{
						result = integer.IntValue();
					}
					return result;
				}
			},
			{
				typeof(long),
				delegate(IntPtr handle, JniHandleOwnership transfer)
				{
					object result;
					using (Long @long = new Long(handle, transfer | JniHandleOwnership.DoNotRegister))
					{
						result = @long.LongValue();
					}
					return result;
				}
			},
			{
				typeof(float),
				delegate(IntPtr handle, JniHandleOwnership transfer)
				{
					object result;
					using (Float @float = new Float(handle, transfer | JniHandleOwnership.DoNotRegister))
					{
						result = @float.FloatValue();
					}
					return result;
				}
			},
			{
				typeof(double),
				delegate(IntPtr handle, JniHandleOwnership transfer)
				{
					object result;
					using (Java.Lang.Double @double = new Java.Lang.Double(handle, transfer | JniHandleOwnership.DoNotRegister))
					{
						result = @double.DoubleValue();
					}
					return result;
				}
			},
			{
				typeof(string),
				delegate(IntPtr handle, JniHandleOwnership transfer)
				{
					object result;
					using (Java.Lang.String @string = new Java.Lang.String(handle, transfer | JniHandleOwnership.DoNotRegister))
					{
						result = @string.ToString();
					}
					return result;
				}
			}
		};

		// Token: 0x040012B7 RID: 4791
		private static Dictionary<string, Type> TypeMappings = new Dictionary<string, Type>(9, StringComparer.Ordinal)
		{
			{
				"java/lang/Boolean",
				typeof(bool)
			},
			{
				"java/lang/Byte",
				typeof(byte)
			},
			{
				"java/lang/Character",
				typeof(char)
			},
			{
				"java/lang/Short",
				typeof(short)
			},
			{
				"java/lang/Integer",
				typeof(int)
			},
			{
				"java/lang/Long",
				typeof(long)
			},
			{
				"java/lang/Float",
				typeof(float)
			},
			{
				"java/lang/Double",
				typeof(double)
			},
			{
				"java/lang/String",
				typeof(string)
			}
		};

		// Token: 0x040012B8 RID: 4792
		private static Dictionary<Type, Func<object, IJavaObject>> JavaObjectConverters = new Dictionary<Type, Func<object, IJavaObject>>
		{
			{
				typeof(bool),
				(object value) => new Java.Lang.Boolean((bool)value)
			},
			{
				typeof(byte),
				(object value) => new Java.Lang.Byte((sbyte)((byte)value))
			},
			{
				typeof(sbyte),
				(object value) => new Java.Lang.Byte((sbyte)value)
			},
			{
				typeof(char),
				(object value) => new Character((char)value)
			},
			{
				typeof(short),
				(object value) => new Short((short)value)
			},
			{
				typeof(int),
				(object value) => new Integer((int)value)
			},
			{
				typeof(long),
				(object value) => new Long((long)value)
			},
			{
				typeof(float),
				(object value) => new Float((float)value)
			},
			{
				typeof(double),
				(object value) => new Java.Lang.Double((double)value)
			},
			{
				typeof(string),
				(object value) => new Java.Lang.String(value.ToString())
			}
		};

		// Token: 0x040012B9 RID: 4793
		private static Dictionary<Type, Func<object, IntPtr>> LocalJniHandleConverters = new Dictionary<Type, Func<object, IntPtr>>
		{
			{
				typeof(bool),
				delegate(object value)
				{
					IntPtr result;
					using (Java.Lang.Boolean boolean = new Java.Lang.Boolean((bool)value))
					{
						result = JNIEnv.ToLocalJniHandle(boolean);
					}
					return result;
				}
			},
			{
				typeof(byte),
				delegate(object value)
				{
					IntPtr result;
					using (Java.Lang.Byte @byte = new Java.Lang.Byte((sbyte)((byte)value)))
					{
						result = JNIEnv.ToLocalJniHandle(@byte);
					}
					return result;
				}
			},
			{
				typeof(sbyte),
				delegate(object value)
				{
					IntPtr result;
					using (Java.Lang.Byte @byte = new Java.Lang.Byte((sbyte)value))
					{
						result = JNIEnv.ToLocalJniHandle(@byte);
					}
					return result;
				}
			},
			{
				typeof(char),
				delegate(object value)
				{
					IntPtr result;
					using (Character character = new Character((char)value))
					{
						result = JNIEnv.ToLocalJniHandle(character);
					}
					return result;
				}
			},
			{
				typeof(short),
				delegate(object value)
				{
					IntPtr result;
					using (Short @short = new Short((short)value))
					{
						result = JNIEnv.ToLocalJniHandle(@short);
					}
					return result;
				}
			},
			{
				typeof(int),
				delegate(object value)
				{
					IntPtr result;
					using (Integer integer = new Integer((int)value))
					{
						result = JNIEnv.ToLocalJniHandle(integer);
					}
					return result;
				}
			},
			{
				typeof(long),
				delegate(object value)
				{
					IntPtr result;
					using (Long @long = new Long((long)value))
					{
						result = JNIEnv.ToLocalJniHandle(@long);
					}
					return result;
				}
			},
			{
				typeof(float),
				delegate(object value)
				{
					IntPtr result;
					using (Float @float = new Float((float)value))
					{
						result = JNIEnv.ToLocalJniHandle(@float);
					}
					return result;
				}
			},
			{
				typeof(double),
				delegate(object value)
				{
					IntPtr result;
					using (Java.Lang.Double @double = new Java.Lang.Double((double)value))
					{
						result = JNIEnv.ToLocalJniHandle(@double);
					}
					return result;
				}
			},
			{
				typeof(string),
				delegate(object value)
				{
					if (value == null)
					{
						return IntPtr.Zero;
					}
					IntPtr result;
					using (Java.Lang.String @string = new Java.Lang.String(value.ToString()))
					{
						result = JNIEnv.ToLocalJniHandle(@string);
					}
					return result;
				}
			},
			{
				typeof(Array),
				(object value) => JNIEnv.NewArray((Array)value, null)
			},
			{
				typeof(JavaObject),
				delegate(object value)
				{
					if (value != null)
					{
						return JNIEnv.ToLocalJniHandle(new JavaObject(value));
					}
					return IntPtr.Zero;
				}
			}
		};
	}
}
