using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Reflection
{
	/// <summary>Provides access to custom attribute data for assemblies, modules, types, members and parameters that are loaded into the reflection-only context.</summary>
	// Token: 0x020004D1 RID: 1233
	[ComVisible(true)]
	[Serializable]
	public class CustomAttributeData
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.CustomAttributeData" /> class.</summary>
		// Token: 0x060022EF RID: 8943 RVA: 0x00003ACD File Offset: 0x00001CCD
		protected CustomAttributeData()
		{
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x0008C9B9 File Offset: 0x0008ABB9
		internal CustomAttributeData(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length)
		{
			this.ctorInfo = ctorInfo;
			this.lazyData = new CustomAttributeData.LazyCAttrData();
			this.lazyData.assembly = assembly;
			this.lazyData.data = data;
			this.lazyData.data_length = data_length;
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x0008C9F8 File Offset: 0x0008ABF8
		internal CustomAttributeData(ConstructorInfo ctorInfo) : this(ctorInfo, Array.Empty<CustomAttributeTypedArgument>(), Array.Empty<CustomAttributeNamedArgument>())
		{
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x0008CA0B File Offset: 0x0008AC0B
		internal CustomAttributeData(ConstructorInfo ctorInfo, IList<CustomAttributeTypedArgument> ctorArgs, IList<CustomAttributeNamedArgument> namedArgs)
		{
			this.ctorInfo = ctorInfo;
			this.ctorArgs = ctorArgs;
			this.namedArgs = namedArgs;
		}

		// Token: 0x060022F3 RID: 8947
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs);

		// Token: 0x060022F4 RID: 8948 RVA: 0x0008CA28 File Offset: 0x0008AC28
		private void ResolveArguments()
		{
			if (this.lazyData == null)
			{
				return;
			}
			object[] array;
			object[] array2;
			CustomAttributeData.ResolveArgumentsInternal(this.ctorInfo, this.lazyData.assembly, this.lazyData.data, this.lazyData.data_length, out array, out array2);
			this.ctorArgs = Array.AsReadOnly<CustomAttributeTypedArgument>((array != null) ? CustomAttributeData.UnboxValues<CustomAttributeTypedArgument>(array) : Array.Empty<CustomAttributeTypedArgument>());
			this.namedArgs = Array.AsReadOnly<CustomAttributeNamedArgument>((array2 != null) ? CustomAttributeData.UnboxValues<CustomAttributeNamedArgument>(array2) : Array.Empty<CustomAttributeNamedArgument>());
			this.lazyData = null;
		}

		/// <summary>Gets the list of positional arguments specified for the attribute instance represented by the <see cref="T:System.Reflection.CustomAttributeData" /> object.</summary>
		/// <returns>A collection of structures that represent the positional arguments specified for the custom attribute instance.</returns>
		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x0008CAAB File Offset: 0x0008ACAB
		[ComVisible(true)]
		public virtual IList<CustomAttributeTypedArgument> ConstructorArguments
		{
			get
			{
				this.ResolveArguments();
				return this.ctorArgs;
			}
		}

		/// <summary>Gets the list of named arguments specified for the attribute instance represented by the <see cref="T:System.Reflection.CustomAttributeData" /> object.</summary>
		/// <returns>A collection of structures that represent the named arguments specified for the custom attribute instance.</returns>
		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060022F6 RID: 8950 RVA: 0x0008CAB9 File Offset: 0x0008ACB9
		public virtual IList<CustomAttributeNamedArgument> NamedArguments
		{
			get
			{
				this.ResolveArguments();
				return this.namedArgs;
			}
		}

		/// <summary>Returns a list of <see cref="T:System.Reflection.CustomAttributeData" /> objects representing data about the attributes that have been applied to the target member.</summary>
		/// <param name="target">The member whose attribute data is to be retrieved.</param>
		/// <returns>A list of objects that represent data about the attributes that have been applied to the target member.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="target" /> is <see langword="null" />.</exception>
		// Token: 0x060022F7 RID: 8951 RVA: 0x0008CAC7 File Offset: 0x0008ACC7
		public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target)
		{
			return MonoCustomAttrs.GetCustomAttributesData(target, false);
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x0008CAC7 File Offset: 0x0008ACC7
		internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target)
		{
			return MonoCustomAttrs.GetCustomAttributesData(target, false);
		}

		/// <summary>Gets the type of the attribute.</summary>
		/// <returns>The type of the attribute.</returns>
		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x0008CAD0 File Offset: 0x0008ACD0
		public Type AttributeType
		{
			get
			{
				return this.ctorInfo.DeclaringType;
			}
		}

		/// <summary>Returns a string representation of the custom attribute.</summary>
		/// <returns>A string value that represents the custom attribute.</returns>
		// Token: 0x060022FA RID: 8954 RVA: 0x0008CAE0 File Offset: 0x0008ACE0
		public override string ToString()
		{
			this.ResolveArguments();
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("[" + this.ctorInfo.DeclaringType.FullName + "(");
			for (int i = 0; i < this.ctorArgs.Count; i++)
			{
				stringBuilder.Append(this.ctorArgs[i].ToString());
				if (i + 1 < this.ctorArgs.Count)
				{
					stringBuilder.Append(", ");
				}
			}
			if (this.namedArgs.Count > 0)
			{
				stringBuilder.Append(", ");
			}
			for (int j = 0; j < this.namedArgs.Count; j++)
			{
				stringBuilder.Append(this.namedArgs[j].ToString());
				if (j + 1 < this.namedArgs.Count)
				{
					stringBuilder.Append(", ");
				}
			}
			stringBuilder.AppendFormat(")]", Array.Empty<object>());
			return stringBuilder.ToString();
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x0008CBF8 File Offset: 0x0008ADF8
		private static T[] UnboxValues<T>(object[] values)
		{
			T[] array = new T[values.Length];
			for (int i = 0; i < values.Length; i++)
			{
				array[i] = (T)((object)values[i]);
			}
			return array;
		}

		/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An object to compare with this instance, or <see langword="null" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is equal to the current instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x060022FC RID: 8956 RVA: 0x0008CC2C File Offset: 0x0008AE2C
		public override bool Equals(object obj)
		{
			CustomAttributeData customAttributeData = obj as CustomAttributeData;
			if (customAttributeData == null || customAttributeData.ctorInfo != this.ctorInfo || customAttributeData.ctorArgs.Count != this.ctorArgs.Count || customAttributeData.namedArgs.Count != this.namedArgs.Count)
			{
				return false;
			}
			for (int i = 0; i < this.ctorArgs.Count; i++)
			{
				if (this.ctorArgs[i].Equals(customAttributeData.ctorArgs[i]))
				{
					return false;
				}
			}
			for (int j = 0; j < this.namedArgs.Count; j++)
			{
				bool flag = false;
				for (int k = 0; k < customAttributeData.namedArgs.Count; k++)
				{
					if (this.namedArgs[j].Equals(customAttributeData.namedArgs[k]))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Serves as a hash function for a particular type.</summary>
		/// <returns>A hash code for the current <see cref="T:System.Object" />.</returns>
		// Token: 0x060022FD RID: 8957 RVA: 0x0008CD3C File Offset: 0x0008AF3C
		public override int GetHashCode()
		{
			int num = (this.ctorInfo == null) ? 13 : (this.ctorInfo.GetHashCode() << 16);
			if (this.ctorArgs != null)
			{
				for (int i = 0; i < this.ctorArgs.Count; i++)
				{
					num += (num ^ 7 + this.ctorArgs[i].GetHashCode() << i * 4);
				}
			}
			if (this.namedArgs != null)
			{
				for (int j = 0; j < this.namedArgs.Count; j++)
				{
					num += this.namedArgs[j].GetHashCode() << 5;
				}
			}
			return num;
		}

		// Token: 0x04001105 RID: 4357
		private ConstructorInfo ctorInfo;

		// Token: 0x04001106 RID: 4358
		private IList<CustomAttributeTypedArgument> ctorArgs;

		// Token: 0x04001107 RID: 4359
		private IList<CustomAttributeNamedArgument> namedArgs;

		// Token: 0x04001108 RID: 4360
		private CustomAttributeData.LazyCAttrData lazyData;

		// Token: 0x020004D2 RID: 1234
		private class LazyCAttrData
		{
			// Token: 0x04001109 RID: 4361
			internal Assembly assembly;

			// Token: 0x0400110A RID: 4362
			internal IntPtr data;

			// Token: 0x0400110B RID: 4363
			internal uint data_length;
		}
	}
}
