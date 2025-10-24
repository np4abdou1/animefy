using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Android.Runtime;
using Java.Lang;

namespace Java.Interop
{
	// Token: 0x02000439 RID: 1081
	public static class JavaObjectExtensions
	{
		// Token: 0x06002F16 RID: 12054 RVA: 0x00083217 File Offset: 0x00081417
		public static JavaCollection ToInteroperableCollection(this ICollection instance)
		{
			if (!(instance is JavaCollection))
			{
				return new JavaCollection(instance);
			}
			return (JavaCollection)instance;
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x0008322E File Offset: 0x0008142E
		public static JavaCollection<T> ToInteroperableCollection<T>(this ICollection<T> instance)
		{
			if (!(instance is JavaCollection<T>))
			{
				return new JavaCollection<T>(instance);
			}
			return (JavaCollection<T>)instance;
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x00083245 File Offset: 0x00081445
		public static JavaList ToInteroperableCollection(this IList instance)
		{
			if (!(instance is JavaList))
			{
				return new JavaList(instance);
			}
			return (JavaList)instance;
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x0008325C File Offset: 0x0008145C
		public static JavaList<T> ToInteroperableCollection<T>(this IList<T> instance)
		{
			if (!(instance is JavaList<T>))
			{
				return new JavaList<T>(instance);
			}
			return (JavaList<T>)instance;
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x00083273 File Offset: 0x00081473
		public static JavaDictionary ToInteroperableCollection(this IDictionary instance)
		{
			if (!(instance is JavaDictionary))
			{
				return new JavaDictionary(instance);
			}
			return (JavaDictionary)instance;
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x0008328A File Offset: 0x0008148A
		public static JavaDictionary<K, V> ToInteroperableCollection<K, V>(this IDictionary<K, V> instance)
		{
			if (!(instance is JavaDictionary<K, V>))
			{
				return new JavaDictionary<K, V>(instance);
			}
			return (JavaDictionary<K, V>)instance;
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x000832A1 File Offset: 0x000814A1
		public static TResult JavaCast<TResult>(this IJavaObject instance) where TResult : class, IJavaObject
		{
			return instance._JavaCast<TResult>();
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x000832AC File Offset: 0x000814AC
		internal static TResult _JavaCast<TResult>(this IJavaObject instance)
		{
			if (instance == null)
			{
				return default(TResult);
			}
			if (instance is TResult)
			{
				return (TResult)((object)instance);
			}
			if (instance.Handle == IntPtr.Zero)
			{
				throw new ObjectDisposedException(instance.GetType().FullName);
			}
			Type typeFromHandle = typeof(TResult);
			if (typeFromHandle.IsClass)
			{
				return (TResult)((object)JavaObjectExtensions.CastClass(instance, typeFromHandle));
			}
			if (typeFromHandle.IsInterface)
			{
				return (TResult)((object)Java.Lang.Object.GetObject(instance.Handle, JniHandleOwnership.DoNotTransfer, typeFromHandle));
			}
			throw new NotSupportedException(string.Format("Unable to convert type '{0}' to '{1}'.", instance.GetType().FullName, typeFromHandle.FullName));
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x00083354 File Offset: 0x00081554
		private static IJavaObject CastClass(IJavaObject instance, Type resultType)
		{
			IntPtr intPtr = JNIEnv.FindClass(resultType);
			try
			{
				if (intPtr == IntPtr.Zero)
				{
					throw new ArgumentException("Unable to determine JNI class for '" + resultType.FullName + "'.", "TResult");
				}
				if (!JNIEnv.IsInstanceOf(instance.Handle, intPtr))
				{
					throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.", instance.GetType().FullName, resultType.FullName));
				}
			}
			finally
			{
				JNIEnv.DeleteGlobalRef(intPtr);
			}
			if (resultType.IsAbstract)
			{
				Type invokerType = JavaObjectExtensions.GetInvokerType(resultType);
				if (invokerType == null)
				{
					throw new ArgumentException("Unable to get Invoker for abstract type '" + resultType.FullName + "'.", "TResult");
				}
				resultType = invokerType;
			}
			return (IJavaObject)TypeManager.CreateProxy(resultType, instance.Handle, JniHandleOwnership.DoNotTransfer);
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x00083428 File Offset: 0x00081628
		internal static IJavaObject JavaCast(IJavaObject instance, Type resultType)
		{
			if (resultType == null)
			{
				throw new ArgumentNullException("resultType");
			}
			if (instance == null)
			{
				return null;
			}
			if (resultType.IsAssignableFrom(instance.GetType()))
			{
				return instance;
			}
			if (resultType.IsClass)
			{
				return JavaObjectExtensions.CastClass(instance, resultType);
			}
			if (resultType.IsInterface)
			{
				return (IJavaObject)Java.Lang.Object.GetObject(instance.Handle, JniHandleOwnership.DoNotTransfer, resultType);
			}
			throw new NotSupportedException(string.Format("Unable to convert type '{0}' to '{1}'.", instance.GetType().FullName, resultType.FullName));
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x000834AC File Offset: 0x000816AC
		[UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "*Invoker types are preserved by the MarkJavaObjects linker step.")]
		internal static Type GetInvokerType(Type type)
		{
			Type[] genericArguments = type.GetGenericArguments();
			if (genericArguments.Length == 0)
			{
				return type.Assembly.GetType(((type != null) ? type.ToString() : null) + "Invoker");
			}
			Type genericTypeDefinition = type.GetGenericTypeDefinition();
			int num = genericTypeDefinition.FullName.IndexOf("`", StringComparison.Ordinal);
			if (num == -1)
			{
				throw new NotSupportedException("Generic type doesn't follow generic type naming convention! " + type.FullName);
			}
			Type type2 = genericTypeDefinition.Assembly.GetType(genericTypeDefinition.FullName.Substring(0, num) + "Invoker" + genericTypeDefinition.FullName.Substring(num));
			if (type2 == null)
			{
				return null;
			}
			return type2.MakeGenericType(genericArguments);
		}
	}
}
