using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Java.Interop.Tools.JavaCallableWrappers;

namespace Java.Interop.Tools.TypeNameMappings
{
	// Token: 0x02000443 RID: 1091
	internal static class JavaNativeTypeManager
	{
		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06002F4A RID: 12106 RVA: 0x0008423D File Offset: 0x0008243D
		// (set) Token: 0x06002F4B RID: 12107 RVA: 0x00084244 File Offset: 0x00082444
		public static PackageNamingPolicy PackageNamingPolicy { get; set; } = PackageNamingPolicy.LowercaseCrc64;

		// Token: 0x06002F4C RID: 12108 RVA: 0x0008424C File Offset: 0x0008244C
		public static string ToCliType(string jniType)
		{
			if (string.IsNullOrEmpty(jniType))
			{
				return jniType;
			}
			string[] array = jniType.Split('/', StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = JavaNativeTypeManager.ToCliTypePart(array[i]);
			}
			return string.Join(".", array);
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x00084294 File Offset: 0x00082494
		private static string ToCliTypePart(string part)
		{
			if (part.IndexOf('$') < 0)
			{
				return JavaNativeTypeManager.ToPascalCase(part, 2);
			}
			string[] array = part.Split('$', StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = JavaNativeTypeManager.ToPascalCase(array[i], 1);
			}
			return string.Join("/", array);
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x000842E4 File Offset: 0x000824E4
		private static string ToPascalCase(string value, int minLength)
		{
			if (value.Length > minLength)
			{
				return char.ToUpperInvariant(value[0]).ToString() + value.Substring(1);
			}
			return value.ToUpperInvariant();
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x00084321 File Offset: 0x00082521
		public static string ToJniName(Type type)
		{
			return JavaNativeTypeManager.ToJniName(type, ExportParameterKind.Unspecified) ?? "java/lang/Object";
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x00084334 File Offset: 0x00082534
		private static string ToJniName(Type type, ExportParameterKind exportKind)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (type.IsValueType)
			{
				return JavaNativeTypeManager.GetPrimitiveClass(type);
			}
			if (type == typeof(string))
			{
				return "java/lang/String";
			}
			if (!type.GetInterfaces().Any((Type t) => t.FullName == "Android.Runtime.IJavaObject"))
			{
				return JavaNativeTypeManager.GetSpecialExportJniType(type.FullName, exportKind);
			}
			Func<Type, Type> decl = (Type t) => t.DeclaringType;
			Func<Type, string> name = (Type t) => t.Name;
			Func<Type, string> ns;
			if ((ns = JavaNativeTypeManager.<>O.<0>__GetPackageName) == null)
			{
				ns = (JavaNativeTypeManager.<>O.<0>__GetPackageName = new Func<Type, string>(JavaNativeTypeManager.GetPackageName));
			}
			return JavaNativeTypeManager.ToJniName<Type>(type, decl, name, ns, (Type t) => JavaNativeTypeManager.ToJniNameFromAttributes(t), (Type _) => false);
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x00084452 File Offset: 0x00082652
		public static string ToJniName(string jniType, int rank)
		{
			if (rank == 0)
			{
				return jniType;
			}
			if (jniType.Length > 1)
			{
				jniType = "L" + jniType + ";";
			}
			return new string('[', rank) + jniType;
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x00084482 File Offset: 0x00082682
		private static bool IsPackageNamePreservedForAssembly(string assemblyName)
		{
			return assemblyName == "Mono.Android";
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x00084490 File Offset: 0x00082690
		public static string GetPackageName(Type type)
		{
			string assemblyName = JavaNativeTypeManager.GetAssemblyName(type.Assembly);
			if (JavaNativeTypeManager.IsPackageNamePreservedForAssembly(assemblyName))
			{
				return type.Namespace.ToLowerInvariant();
			}
			switch (JavaNativeTypeManager.PackageNamingPolicy)
			{
			case PackageNamingPolicy.Lowercase:
				return type.Namespace.ToLowerInvariant();
			case PackageNamingPolicy.LowercaseWithAssemblyName:
				return "assembly_" + (assemblyName.Replace('.', '_') + "." + type.Namespace).ToLowerInvariant();
			case PackageNamingPolicy.LowercaseCrc64:
				return "crc64" + JavaNativeTypeManager.ToCrc64(type.Namespace + ":" + assemblyName);
			default:
				throw new NotSupportedException(string.Format("PackageNamingPolicy.{0} is no longer supported.", JavaNativeTypeManager.PackageNamingPolicy));
			}
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x0008454C File Offset: 0x0008274C
		private static string GetAssemblyName(Assembly assembly)
		{
			string fullName = assembly.FullName;
			int num = fullName.IndexOf(',');
			if (num != -1)
			{
				return fullName.Substring(0, num);
			}
			return fullName;
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x00084578 File Offset: 0x00082778
		public static int GetArrayInfo(Type type, out Type elementType)
		{
			elementType = type;
			int num = 0;
			while (type.IsArray)
			{
				num++;
				elementType = (type = type.GetElementType());
			}
			return num;
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x000845A4 File Offset: 0x000827A4
		private static string GetPrimitiveClass(Type type)
		{
			if (type.IsEnum)
			{
				return JavaNativeTypeManager.GetPrimitiveClass(Enum.GetUnderlyingType(type));
			}
			if (type == typeof(byte))
			{
				return "B";
			}
			if (type == typeof(char))
			{
				return "C";
			}
			if (type == typeof(double))
			{
				return "D";
			}
			if (type == typeof(float))
			{
				return "F";
			}
			if (type == typeof(int))
			{
				return "I";
			}
			if (type == typeof(uint))
			{
				return "I";
			}
			if (type == typeof(long))
			{
				return "J";
			}
			if (type == typeof(ulong))
			{
				return "J";
			}
			if (type == typeof(short))
			{
				return "S";
			}
			if (type == typeof(ushort))
			{
				return "S";
			}
			if (type == typeof(bool))
			{
				return "Z";
			}
			return null;
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x000846D0 File Offset: 0x000828D0
		private static string GetSpecialExportJniType(string typeName, ExportParameterKind exportKind)
		{
			switch (exportKind)
			{
			case ExportParameterKind.InputStream:
				if (typeName != "System.IO.Stream")
				{
					throw new ArgumentException("ExportParameterKind.InputStream is valid only for System.IO.Stream parameter type");
				}
				return "java/io/InputStream";
			case ExportParameterKind.OutputStream:
				if (typeName != "System.IO.Stream")
				{
					throw new ArgumentException("ExportParameterKind.OutputStream is valid only for System.IO.Stream parameter type");
				}
				return "java/io/OutputStream";
			case ExportParameterKind.XmlPullParser:
				if (typeName != "System.Xml.XmlReader")
				{
					throw new ArgumentException("ExportParameterKind.XmlPullParser is valid only for System.Xml.XmlReader parameter type");
				}
				return "org/xmlpull/v1/XmlPullParser";
			case ExportParameterKind.XmlResourceParser:
				if (typeName != "System.Xml.XmlReader")
				{
					throw new ArgumentException("ExportParameterKind.XmlResourceParser is valid only for System.Xml.XmlReader parameter type");
				}
				return "android/content/res/XmlResourceParser";
			default:
				return null;
			}
		}

		// Token: 0x06002F58 RID: 12120 RVA: 0x00084770 File Offset: 0x00082970
		public static string ToJniNameFromAttributes(Type type)
		{
			IJniNameProviderAttribute[] array = (IJniNameProviderAttribute[])type.GetCustomAttributes(typeof(IJniNameProviderAttribute), false);
			if (array.Length == 0 || string.IsNullOrEmpty(array[0].Name))
			{
				return null;
			}
			return array[0].Name.Replace('.', '/');
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x000847BC File Offset: 0x000829BC
		private static string GetJniSignature<T, P>(IEnumerable<P> parameters, Func<P, T> getParameterType, Func<P, ExportParameterKind> getExportKind, T returnType, ExportParameterKind returnExportKind, Func<T, ExportParameterKind, string> getJniTypeName, bool isConstructor)
		{
			StringBuilder stringBuilder = new StringBuilder().Append("(");
			foreach (P arg in parameters)
			{
				string text = getJniTypeName(getParameterType(arg), getExportKind(arg));
				if (text == null)
				{
					return null;
				}
				stringBuilder.Append(text);
			}
			stringBuilder.Append(')');
			if (isConstructor)
			{
				stringBuilder.Append("V");
			}
			else
			{
				string text2 = getJniTypeName(returnType, returnExportKind);
				if (text2 == null)
				{
					return null;
				}
				stringBuilder.Append(text2);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x00084874 File Offset: 0x00082A74
		private static string GetJniTypeName<TR, TD>(TR typeRef, ExportParameterKind exportKind, Func<TR, TD> resolve, Func<TR, KeyValuePair<int, TR>> getArrayInfo, Func<TD, string> getFullName, Func<TD, ExportParameterKind, string> toJniName)
		{
			TD td = resolve(typeRef);
			KeyValuePair<int, TR> keyValuePair = getArrayInfo(typeRef);
			int key = keyValuePair.Key;
			TR value = keyValuePair.Value;
			td = resolve(value);
			if (td == null)
			{
				return null;
			}
			if (getFullName(td) == "System.Void")
			{
				return "V";
			}
			if (getFullName(td) == "System.IntPtr")
			{
				return null;
			}
			string text = toJniName(td, exportKind);
			if (text == null)
			{
				return null;
			}
			if (key != 0 || text.Length <= 1)
			{
				return JavaNativeTypeManager.ToJniName(text, key);
			}
			return "L" + text + ";";
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x0008491C File Offset: 0x00082B1C
		private static ExportParameterKind GetExportKind(ICustomAttributeProvider p)
		{
			object[] customAttributes = p.GetCustomAttributes(typeof(ExportParameterAttribute), false);
			int num = 0;
			if (num >= customAttributes.Length)
			{
				return ExportParameterKind.Unspecified;
			}
			return ((ExportParameterAttribute)customAttributes[num]).Kind;
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x00084954 File Offset: 0x00082B54
		public static string GetJniSignature(MethodInfo method)
		{
			return JavaNativeTypeManager.GetJniSignature<Type, ParameterInfo>(method.GetParameters(), (ParameterInfo p) => p.ParameterType, (ParameterInfo p) => JavaNativeTypeManager.GetExportKind(p), method.ReturnType, JavaNativeTypeManager.GetExportKind(method.ReturnParameter), (Type t, ExportParameterKind k) => JavaNativeTypeManager.GetJniTypeName(t, k), method.IsConstructor);
		}

		// Token: 0x06002F5D RID: 12125 RVA: 0x000849E0 File Offset: 0x00082BE0
		internal static string GetJniTypeName(Type typeRef, ExportParameterKind exportKind)
		{
			return JavaNativeTypeManager.GetJniTypeName<Type, Type>(typeRef, exportKind, (Type t) => t, delegate(Type t)
			{
				Type value;
				return new KeyValuePair<int, Type>(JavaNativeTypeManager.GetArrayInfo(t, out value), value);
			}, (Type t) => t.FullName, (Type t, ExportParameterKind k) => JavaNativeTypeManager.ToJniNameWhichShouldReplaceExistingToJniName(t, k));
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x00084A70 File Offset: 0x00082C70
		private static string ToJniNameWhichShouldReplaceExistingToJniName(Type type, ExportParameterKind exportKind)
		{
			return JavaNativeTypeManager.ToJniNameFromAttributes(type) ?? JavaNativeTypeManager.ToJniName(type, exportKind);
		}

		// Token: 0x06002F5F RID: 12127 RVA: 0x00084A84 File Offset: 0x00082C84
		private static string ToJniName<T>(T type, Func<T, T> decl, Func<T, string> name, Func<T, string> ns, Func<T, string> overrideName, Func<T, bool> shouldUpdateName) where T : class
		{
			List<string> list = new List<string>();
			string text = null;
			T arg = type;
			for (T t = type; t != null; t = decl(t))
			{
				arg = t;
				text = overrideName(t);
				if (text != null)
				{
					break;
				}
				string text2 = name(t).Replace('`', '_');
				if (shouldUpdateName(t))
				{
					text2 = "$" + name(decl(t)) + "_" + text2;
				}
				list.Add(text2);
			}
			if (list.Count == 0 && text != null)
			{
				return text;
			}
			list.Reverse();
			string text3 = string.Join("_", list.ToArray()).Replace("_$", "$");
			if (text != null)
			{
				return (text + "_" + text3).Replace("_$", "$");
			}
			text = text3;
			string text4 = JavaNativeTypeManager.ToLowerCase(ns(arg));
			if (!string.IsNullOrEmpty(text4))
			{
				return text4.Replace('.', '/') + "/" + text;
			}
			return text;
		}

		// Token: 0x06002F60 RID: 12128 RVA: 0x00084B90 File Offset: 0x00082D90
		private static string ToCrc64(string value)
		{
			byte[] array = Crc64Helper.Compute(Encoding.UTF8.GetBytes(value));
			StringBuilder stringBuilder = new StringBuilder(array.Length * 2);
			foreach (byte b in array)
			{
				stringBuilder.AppendFormat("{0:x2}", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x00084BE4 File Offset: 0x00082DE4
		private static string ToLowerCase(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				return value;
			}
			string[] array = value.Split('.', StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = array[i].ToLowerInvariant();
			}
			return string.Join(".", array);
		}

		// Token: 0x02000444 RID: 1092
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040012D3 RID: 4819
			public static Func<Type, string> <0>__GetPackageName;
		}
	}
}
