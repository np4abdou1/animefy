using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security;

namespace System
{
	/// <summary>Represents the base class for custom attributes.</summary>
	// Token: 0x0200013C RID: 316
	[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	[Serializable]
	public abstract class Attribute
	{
		// Token: 0x06000C2B RID: 3115 RVA: 0x00032226 File Offset: 0x00030426
		private static Attribute[] InternalGetCustomAttributes(PropertyInfo element, Type type, bool inherit)
		{
			return (Attribute[])MonoCustomAttrs.GetCustomAttributes(element, type, inherit);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00032226 File Offset: 0x00030426
		private static Attribute[] InternalGetCustomAttributes(EventInfo element, Type type, bool inherit)
		{
			return (Attribute[])MonoCustomAttrs.GetCustomAttributes(element, type, inherit);
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00032238 File Offset: 0x00030438
		private static Attribute[] InternalParamGetCustomAttributes(ParameterInfo parameter, Type attributeType, bool inherit)
		{
			if (parameter.Member.MemberType != MemberTypes.Method)
			{
				return null;
			}
			MethodInfo methodInfo = (MethodInfo)parameter.Member;
			MethodInfo baseDefinition = methodInfo.GetBaseDefinition();
			if (attributeType == null)
			{
				attributeType = typeof(Attribute);
			}
			if (methodInfo == baseDefinition)
			{
				return (Attribute[])parameter.GetCustomAttributes(attributeType, inherit);
			}
			List<Type> list = new List<Type>();
			List<Attribute> list2 = new List<Attribute>();
			for (;;)
			{
				foreach (Attribute attribute in (Attribute[])methodInfo.GetParametersInternal()[parameter.Position].GetCustomAttributes(attributeType, false))
				{
					Type type = attribute.GetType();
					if (!list.Contains(type))
					{
						list.Add(type);
						list2.Add(attribute);
					}
				}
				MethodInfo baseMethod = ((RuntimeMethodInfo)methodInfo).GetBaseMethod();
				if (baseMethod == methodInfo)
				{
					break;
				}
				methodInfo = baseMethod;
			}
			Attribute[] array2 = (Attribute[])Array.CreateInstance(attributeType, list2.Count);
			list2.CopyTo(array2, 0);
			return array2;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x00032332 File Offset: 0x00030532
		private static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.IsDefined(element, attributeType, inherit);
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00032332 File Offset: 0x00030532
		private static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.IsDefined(element, attributeType, inherit);
		}

		/// <summary>Retrieves an array of the custom attributes applied to a member of a type. Parameters specify the member, and the type of the custom attribute to search for.</summary>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class. </param>
		/// <param name="type">The type, or a base type, of the custom attribute to search for.</param>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="type" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> or <paramref name="type" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="type" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		// Token: 0x06000C30 RID: 3120 RVA: 0x0003233C File Offset: 0x0003053C
		public static Attribute[] GetCustomAttributes(MemberInfo element, Type type)
		{
			return Attribute.GetCustomAttributes(element, type, true);
		}

		/// <summary>Retrieves an array of the custom attributes applied to a member of a type. Parameters specify the member, the type of the custom attribute to search for, and whether to search ancestors of the member.</summary>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class. </param>
		/// <param name="type">The type, or a base type, of the custom attribute to search for.</param>
		/// <param name="inherit">If <see langword="true" />, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="type" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> or <paramref name="type" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="type" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		// Token: 0x06000C31 RID: 3121 RVA: 0x00032348 File Offset: 0x00030548
		public static Attribute[] GetCustomAttributes(MemberInfo element, Type type, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (!type.IsSubclassOf(typeof(Attribute)) && type != typeof(Attribute))
			{
				throw new ArgumentException(Environment.GetResourceString("Type passed in must be derived from System.Attribute or System.Attribute itself."));
			}
			MemberTypes memberType = element.MemberType;
			if (memberType == MemberTypes.Event)
			{
				return Attribute.InternalGetCustomAttributes((EventInfo)element, type, inherit);
			}
			if (memberType == MemberTypes.Property)
			{
				return Attribute.InternalGetCustomAttributes((PropertyInfo)element, type, inherit);
			}
			return element.GetCustomAttributes(type, inherit) as Attribute[];
		}

		/// <summary>Retrieves an array of the custom attributes applied to a member of a type. Parameters specify the member, the type of the custom attribute to search for, and whether to search ancestors of the member.</summary>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class. </param>
		/// <param name="inherit">If <see langword="true" />, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		// Token: 0x06000C32 RID: 3122 RVA: 0x000323EC File Offset: 0x000305EC
		public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			MemberTypes memberType = element.MemberType;
			if (memberType == MemberTypes.Event)
			{
				return Attribute.InternalGetCustomAttributes((EventInfo)element, typeof(Attribute), inherit);
			}
			if (memberType == MemberTypes.Property)
			{
				return Attribute.InternalGetCustomAttributes((PropertyInfo)element, typeof(Attribute), inherit);
			}
			return element.GetCustomAttributes(typeof(Attribute), inherit) as Attribute[];
		}

		/// <summary>Determines whether any custom attributes are applied to a member of a type. Parameters specify the member, and the type of the custom attribute to search for.</summary>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, type, or property member of a class. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <returns>
		///     <see langword="true" /> if a custom attribute of type <paramref name="attributeType" /> is applied to <paramref name="element" />; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		// Token: 0x06000C33 RID: 3123 RVA: 0x00032461 File Offset: 0x00030661
		public static bool IsDefined(MemberInfo element, Type attributeType)
		{
			return Attribute.IsDefined(element, attributeType, true);
		}

		/// <summary>Determines whether any custom attributes are applied to a member of a type. Parameters specify the member, the type of the custom attribute to search for, and whether to search ancestors of the member.</summary>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, type, or property member of a class. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <param name="inherit">If <see langword="true" />, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param>
		/// <returns>
		///     <see langword="true" /> if a custom attribute of type <paramref name="attributeType" /> is applied to <paramref name="element" />; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		// Token: 0x06000C34 RID: 3124 RVA: 0x0003246C File Offset: 0x0003066C
		public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			if (!attributeType.IsSubclassOf(typeof(Attribute)) && attributeType != typeof(Attribute))
			{
				throw new ArgumentException(Environment.GetResourceString("Type passed in must be derived from System.Attribute or System.Attribute itself."));
			}
			MemberTypes memberType = element.MemberType;
			if (memberType == MemberTypes.Event)
			{
				return Attribute.InternalIsDefined((EventInfo)element, attributeType, inherit);
			}
			if (memberType == MemberTypes.Property)
			{
				return Attribute.InternalIsDefined((PropertyInfo)element, attributeType, inherit);
			}
			return element.IsDefined(attributeType, inherit);
		}

		/// <summary>Retrieves a custom attribute applied to a member of a type. Parameters specify the member, and the type of the custom attribute to search for.</summary>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or <see langword="null" /> if there is no such attribute.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		// Token: 0x06000C35 RID: 3125 RVA: 0x00032509 File Offset: 0x00030709
		public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType)
		{
			return Attribute.GetCustomAttribute(element, attributeType, true);
		}

		/// <summary>Retrieves a custom attribute applied to a member of a type. Parameters specify the member, the type of the custom attribute to search for, and whether to search ancestors of the member.</summary>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <param name="inherit">If <see langword="true" />, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param>
		/// <returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or <see langword="null" /> if there is no such attribute.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		// Token: 0x06000C36 RID: 3126 RVA: 0x00032514 File Offset: 0x00030714
		public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit)
		{
			Attribute[] customAttributes = Attribute.GetCustomAttributes(element, attributeType, inherit);
			if (customAttributes == null || customAttributes.Length == 0)
			{
				return null;
			}
			if (customAttributes.Length == 1)
			{
				return customAttributes[0];
			}
			throw new AmbiguousMatchException(Environment.GetResourceString("Multiple custom attributes of the same type found."));
		}

		/// <summary>Retrieves an array of the custom attributes applied to a method parameter. Parameters specify the method parameter, the type of the custom attribute to search for, and whether to search ancestors of the method parameter.</summary>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.ParameterInfo" /> class that describes a parameter of a member of a class. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <param name="inherit">If <see langword="true" />, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="attributeType" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		// Token: 0x06000C37 RID: 3127 RVA: 0x0003254C File Offset: 0x0003074C
		public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			if (!attributeType.IsSubclassOf(typeof(Attribute)) && attributeType != typeof(Attribute))
			{
				throw new ArgumentException(Environment.GetResourceString("Type passed in must be derived from System.Attribute or System.Attribute itself."));
			}
			if (element.Member == null)
			{
				throw new ArgumentException(Environment.GetResourceString("The ParameterInfo object is not valid."), "element");
			}
			if (element.Member.MemberType == MemberTypes.Method && inherit)
			{
				return Attribute.InternalParamGetCustomAttributes(element, attributeType, inherit);
			}
			return element.GetCustomAttributes(attributeType, inherit) as Attribute[];
		}

		/// <summary>Retrieves an array of the custom attributes applied to a method parameter. Parameters specify the method parameter, and whether to search ancestors of the method parameter.</summary>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.ParameterInfo" /> class that describes a parameter of a member of a class. </param>
		/// <param name="inherit">If <see langword="true" />, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Reflection.ParameterInfo.Member" /> property of <paramref name="element" /> is <see langword="null." /><see langword="" /></exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		// Token: 0x06000C38 RID: 3128 RVA: 0x000325FC File Offset: 0x000307FC
		public static Attribute[] GetCustomAttributes(ParameterInfo element, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			if (element.Member == null)
			{
				throw new ArgumentException(Environment.GetResourceString("The ParameterInfo object is not valid."), "element");
			}
			if (element.Member.MemberType == MemberTypes.Method && inherit)
			{
				return Attribute.InternalParamGetCustomAttributes(element, null, inherit);
			}
			return element.GetCustomAttributes(typeof(Attribute), inherit) as Attribute[];
		}

		/// <summary>Retrieves an array of the custom attributes applied to a module. Parameters specify the module, and an ignored search option.</summary>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.Module" /> class that describes a portable executable file. </param>
		/// <param name="inherit">This parameter is ignored, and does not affect the operation of this method. </param>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />. </exception>
		// Token: 0x06000C39 RID: 3129 RVA: 0x0003266B File Offset: 0x0003086B
		public static Attribute[] GetCustomAttributes(Module element, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return (Attribute[])element.GetCustomAttributes(typeof(Attribute), inherit);
		}

		/// <summary>Retrieves an array of the custom attributes applied to a module. Parameters specify the module, the type of the custom attribute to search for, and an ignored search option.</summary>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.Module" /> class that describes a portable executable file. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <param name="inherit">This parameter is ignored, and does not affect the operation of this method. </param>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="attributeType" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		// Token: 0x06000C3A RID: 3130 RVA: 0x00032698 File Offset: 0x00030898
		public static Attribute[] GetCustomAttributes(Module element, Type attributeType, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			if (!attributeType.IsSubclassOf(typeof(Attribute)) && attributeType != typeof(Attribute))
			{
				throw new ArgumentException(Environment.GetResourceString("Type passed in must be derived from System.Attribute or System.Attribute itself."));
			}
			return (Attribute[])element.GetCustomAttributes(attributeType, inherit);
		}

		/// <summary>Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, and the type of the custom attribute to search for.</summary>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="attributeType" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		// Token: 0x06000C3B RID: 3131 RVA: 0x0003270E File Offset: 0x0003090E
		public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType)
		{
			return Attribute.GetCustomAttributes(element, attributeType, true);
		}

		/// <summary>Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, the type of the custom attribute to search for, and an ignored search option.</summary>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules. </param>
		/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
		/// <param name="inherit">This parameter is ignored, and does not affect the operation of this method. </param>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="attributeType" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		// Token: 0x06000C3C RID: 3132 RVA: 0x00032718 File Offset: 0x00030918
		public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			if (!attributeType.IsSubclassOf(typeof(Attribute)) && attributeType != typeof(Attribute))
			{
				throw new ArgumentException(Environment.GetResourceString("Type passed in must be derived from System.Attribute or System.Attribute itself."));
			}
			return (Attribute[])element.GetCustomAttributes(attributeType, inherit);
		}

		/// <summary>Retrieves an array of the custom attributes applied to an assembly. A parameter specifies the assembly.</summary>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules. </param>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> is <see langword="null" />. </exception>
		// Token: 0x06000C3D RID: 3133 RVA: 0x0003278E File Offset: 0x0003098E
		public static Attribute[] GetCustomAttributes(Assembly element)
		{
			return Attribute.GetCustomAttributes(element, true);
		}

		/// <summary>Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, and an ignored search option.</summary>
		/// <param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules. </param>
		/// <param name="inherit">This parameter is ignored, and does not affect the operation of this method. </param>
		/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />. </exception>
		// Token: 0x06000C3E RID: 3134 RVA: 0x00032797 File Offset: 0x00030997
		public static Attribute[] GetCustomAttributes(Assembly element, bool inherit)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return (Attribute[])element.GetCustomAttributes(typeof(Attribute), inherit);
		}

		/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An <see cref="T:System.Object" /> to compare with this instance or <see langword="null" />. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> equals the type and value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000C40 RID: 3136 RVA: 0x000327C4 File Offset: 0x000309C4
		[SecuritySafeCritical]
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			RuntimeType runtimeType = (RuntimeType)base.GetType();
			if ((RuntimeType)obj.GetType() != runtimeType)
			{
				return false;
			}
			FieldInfo[] fields = runtimeType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			for (int i = 0; i < fields.Length; i++)
			{
				object thisValue = ((RtFieldInfo)fields[i]).UnsafeGetValue(this);
				object thatValue = ((RtFieldInfo)fields[i]).UnsafeGetValue(obj);
				if (!Attribute.AreFieldValuesEqual(thisValue, thatValue))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00032840 File Offset: 0x00030A40
		private static bool AreFieldValuesEqual(object thisValue, object thatValue)
		{
			if (thisValue == null && thatValue == null)
			{
				return true;
			}
			if (thisValue == null || thatValue == null)
			{
				return false;
			}
			if (thisValue.GetType().IsArray)
			{
				if (!thisValue.GetType().Equals(thatValue.GetType()))
				{
					return false;
				}
				Array array = thisValue as Array;
				Array array2 = thatValue as Array;
				if (array.Length != array2.Length)
				{
					return false;
				}
				for (int i = 0; i < array.Length; i++)
				{
					if (!Attribute.AreFieldValuesEqual(array.GetValue(i), array2.GetValue(i)))
					{
						return false;
					}
				}
			}
			else if (!thisValue.Equals(thatValue))
			{
				return false;
			}
			return true;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000C42 RID: 3138 RVA: 0x000328D4 File Offset: 0x00030AD4
		[SecuritySafeCritical]
		public override int GetHashCode()
		{
			Type type = base.GetType();
			FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			object obj = null;
			for (int i = 0; i < fields.Length; i++)
			{
				object obj2 = ((RtFieldInfo)fields[i]).UnsafeGetValue(this);
				if (obj2 != null && !obj2.GetType().IsArray)
				{
					obj = obj2;
				}
				if (obj != null)
				{
					break;
				}
			}
			if (obj != null)
			{
				return obj.GetHashCode();
			}
			return type.GetHashCode();
		}

		/// <summary>When implemented in a derived class, gets a unique identifier for this <see cref="T:System.Attribute" />.</summary>
		/// <returns>An <see cref="T:System.Object" /> that is a unique identifier for the attribute.</returns>
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x0002AC6C File Offset: 0x00028E6C
		public virtual object TypeId
		{
			get
			{
				return base.GetType();
			}
		}

		/// <summary>When overridden in a derived class, returns a value that indicates whether this instance equals a specified object.</summary>
		/// <param name="obj">An <see cref="T:System.Object" /> to compare with this instance of <see cref="T:System.Attribute" />. </param>
		/// <returns>
		///     <see langword="true" /> if this instance equals <paramref name="obj" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000C44 RID: 3140 RVA: 0x00032939 File Offset: 0x00030B39
		public virtual bool Match(object obj)
		{
			return this.Equals(obj);
		}

		/// <summary>When overridden in a derived class, indicates whether the value of this instance is the default value for the derived class.</summary>
		/// <returns>
		///     <see langword="true" /> if this instance is the default attribute for the class; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000C45 RID: 3141 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool IsDefaultAttribute()
		{
			return false;
		}
	}
}
