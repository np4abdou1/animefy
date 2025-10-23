﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Activation;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;
using Mono;

namespace System
{
	// Token: 0x0200014F RID: 335
	[Serializable]
	[StructLayout(0)]
	internal class RuntimeType : System.Reflection.TypeInfo, ISerializable, ICloneable
	{
		// Token: 0x06000CE8 RID: 3304 RVA: 0x00035CF1 File Offset: 0x00033EF1
		internal static RuntimeType GetType(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark)
		{
			if (typeName == null)
			{
				throw new ArgumentNullException("typeName");
			}
			return RuntimeTypeHandle.GetTypeByName(typeName, throwOnError, ignoreCase, reflectionOnly, ref stackMark, false);
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x00035D10 File Offset: 0x00033F10
		private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type)
		{
			if (type.IsPointer || type.IsByRef || type == typeof(void))
			{
				throw new ArgumentException(Environment.GetResourceString("The type '{0}' may not be used as a type argument.", new object[]
				{
					type.ToString()
				}));
			}
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00035D60 File Offset: 0x00033F60
		internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters)
		{
			if (genericArguments == null)
			{
				throw new ArgumentNullException();
			}
			for (int i = 0; i < genericArguments.Length; i++)
			{
				if (genericArguments[i] == null)
				{
					throw new ArgumentNullException();
				}
				RuntimeType.ThrowIfTypeNeverValidGenericArgument(genericArguments[i]);
			}
			if (genericArguments.Length != genericParamters.Length)
			{
				throw new ArgumentException(Environment.GetResourceString("The type or method has {1} generic parameter(s), but {0} generic argument(s) were provided. A generic argument must be provided for each generic parameter.", new object[]
				{
					genericArguments.Length,
					genericParamters.Length
				}));
			}
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00035DD4 File Offset: 0x00033FD4
		private static void SplitName(string fullname, out string name, out string ns)
		{
			name = null;
			ns = null;
			if (fullname == null)
			{
				return;
			}
			int num = fullname.LastIndexOf(".", StringComparison.Ordinal);
			if (num == -1)
			{
				name = fullname;
				return;
			}
			ns = fullname.Substring(0, num);
			int num2 = fullname.Length - ns.Length - 1;
			if (num2 != 0)
			{
				name = fullname.Substring(num + 1, num2);
				return;
			}
			name = "";
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00035E34 File Offset: 0x00034034
		internal static BindingFlags FilterPreCalculate(bool isPublic, bool isInherited, bool isStatic)
		{
			BindingFlags bindingFlags = isPublic ? BindingFlags.Public : BindingFlags.NonPublic;
			if (isInherited)
			{
				bindingFlags |= BindingFlags.DeclaredOnly;
				if (isStatic)
				{
					bindingFlags |= (BindingFlags.Static | BindingFlags.FlattenHierarchy);
				}
				else
				{
					bindingFlags |= BindingFlags.Instance;
				}
			}
			else if (isStatic)
			{
				bindingFlags |= BindingFlags.Static;
			}
			else
			{
				bindingFlags |= BindingFlags.Instance;
			}
			return bindingFlags;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00035E70 File Offset: 0x00034070
		private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType)
		{
			prefixLookup = false;
			ignoreCase = false;
			if (name != null)
			{
				if ((bindingFlags & BindingFlags.IgnoreCase) != BindingFlags.Default)
				{
					name = name.ToLower(CultureInfo.InvariantCulture);
					ignoreCase = true;
					listType = RuntimeType.MemberListType.CaseInsensitive;
				}
				else
				{
					listType = RuntimeType.MemberListType.CaseSensitive;
				}
				if (allowPrefixLookup && name.EndsWith("*", StringComparison.Ordinal))
				{
					name = name.Substring(0, name.Length - 1);
					prefixLookup = true;
					listType = RuntimeType.MemberListType.All;
					return;
				}
			}
			else
			{
				listType = RuntimeType.MemberListType.All;
			}
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00035EDC File Offset: 0x000340DC
		private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType)
		{
			bool flag;
			RuntimeType.FilterHelper(bindingFlags, ref name, false, out flag, out ignoreCase, out listType);
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00035EF5 File Offset: 0x000340F5
		private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase)
		{
			if (ignoreCase)
			{
				if (!memberInfo.Name.StartsWith(name, StringComparison.OrdinalIgnoreCase))
				{
					return false;
				}
			}
			else if (!memberInfo.Name.StartsWith(name, StringComparison.Ordinal))
			{
				return false;
			}
			return true;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00035F20 File Offset: 0x00034120
		private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup)
		{
			if (isPublic)
			{
				if ((bindingFlags & BindingFlags.Public) == BindingFlags.Default)
				{
					return false;
				}
			}
			else if ((bindingFlags & BindingFlags.NonPublic) == BindingFlags.Default)
			{
				return false;
			}
			bool flag = memberInfo.DeclaringType != memberInfo.ReflectedType;
			if ((bindingFlags & BindingFlags.DeclaredOnly) > BindingFlags.Default && flag)
			{
				return false;
			}
			if (memberInfo.MemberType != MemberTypes.TypeInfo && memberInfo.MemberType != MemberTypes.NestedType)
			{
				if (isStatic)
				{
					if ((bindingFlags & BindingFlags.FlattenHierarchy) == BindingFlags.Default && flag)
					{
						return false;
					}
					if ((bindingFlags & BindingFlags.Static) == BindingFlags.Default)
					{
						return false;
					}
				}
				else if ((bindingFlags & BindingFlags.Instance) == BindingFlags.Default)
				{
					return false;
				}
			}
			if (prefixLookup && !RuntimeType.FilterApplyPrefixLookup(memberInfo, name, (bindingFlags & BindingFlags.IgnoreCase) > BindingFlags.Default))
			{
				return false;
			}
			if ((bindingFlags & BindingFlags.DeclaredOnly) == BindingFlags.Default && flag && isNonProtectedInternal && (bindingFlags & BindingFlags.NonPublic) != BindingFlags.Default && !isStatic && (bindingFlags & BindingFlags.Instance) != BindingFlags.Default)
			{
				MethodInfo methodInfo = memberInfo as MethodInfo;
				if (methodInfo == null)
				{
					return false;
				}
				if (!methodInfo.IsVirtual && !methodInfo.IsAbstract)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00035FEC File Offset: 0x000341EC
		private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns)
		{
			bool isPublic = type.IsNestedPublic || type.IsPublic;
			bool isStatic = false;
			return RuntimeType.FilterApplyBase(type, bindingFlags, isPublic, type.IsNestedAssembly, isStatic, name, prefixLookup) && (ns == null || !(ns != type.Namespace));
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00036038 File Offset: 0x00034238
		private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes)
		{
			return RuntimeType.FilterApplyMethodBase(method, method.BindingFlags, bindingFlags, callConv, argumentTypes);
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00036049 File Offset: 0x00034249
		private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes)
		{
			return RuntimeType.FilterApplyMethodBase(constructor, constructor.BindingFlags, bindingFlags, callConv, argumentTypes);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0003605C File Offset: 0x0003425C
		private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes)
		{
			bindingFlags ^= BindingFlags.DeclaredOnly;
			if ((callConv & CallingConventions.Any) == (CallingConventions)0)
			{
				if ((callConv & CallingConventions.VarArgs) != (CallingConventions)0 && (methodBase.CallingConvention & CallingConventions.VarArgs) == (CallingConventions)0)
				{
					return false;
				}
				if ((callConv & CallingConventions.Standard) != (CallingConventions)0 && (methodBase.CallingConvention & CallingConventions.Standard) == (CallingConventions)0)
				{
					return false;
				}
			}
			if (argumentTypes != null)
			{
				ParameterInfo[] parametersNoCopy = methodBase.GetParametersNoCopy();
				if (argumentTypes.Length != parametersNoCopy.Length)
				{
					if ((bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.CreateInstance | BindingFlags.GetProperty | BindingFlags.SetProperty)) == BindingFlags.Default)
					{
						return false;
					}
					bool flag = false;
					if (argumentTypes.Length > parametersNoCopy.Length)
					{
						if ((methodBase.CallingConvention & CallingConventions.VarArgs) == (CallingConventions)0)
						{
							flag = true;
						}
					}
					else if ((bindingFlags & BindingFlags.OptionalParamBinding) == BindingFlags.Default)
					{
						flag = true;
					}
					else if (!parametersNoCopy[argumentTypes.Length].IsOptional)
					{
						flag = true;
					}
					if (flag)
					{
						if (parametersNoCopy.Length == 0)
						{
							return false;
						}
						if (argumentTypes.Length < parametersNoCopy.Length - 1)
						{
							return false;
						}
						ParameterInfo parameterInfo = parametersNoCopy[parametersNoCopy.Length - 1];
						if (!parameterInfo.ParameterType.IsArray)
						{
							return false;
						}
						if (!parameterInfo.IsDefined(typeof(ParamArrayAttribute), false))
						{
							return false;
						}
					}
				}
				else if ((bindingFlags & BindingFlags.ExactBinding) != BindingFlags.Default && (bindingFlags & BindingFlags.InvokeMethod) == BindingFlags.Default)
				{
					for (int i = 0; i < parametersNoCopy.Length; i++)
					{
						if (argumentTypes[i] != null && !argumentTypes[i].MatchesParameterTypeExactly(parametersNoCopy[i]))
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0003616C File Offset: 0x0003436C
		internal RuntimeType()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0003617C File Offset: 0x0003437C
		private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, int genericParamCount, bool allowPrefixLookup)
		{
			bool flag;
			bool ignoreCase;
			RuntimeType.MemberListType listType;
			RuntimeType.FilterHelper(bindingAttr, ref name, allowPrefixLookup, out flag, out ignoreCase, out listType);
			RuntimeMethodInfo[] methodsByName = this.GetMethodsByName(name, bindingAttr, listType, this);
			RuntimeType.ListBuilder<MethodInfo> result = new RuntimeType.ListBuilder<MethodInfo>(methodsByName.Length);
			int i = 0;
			while (i < methodsByName.Length)
			{
				RuntimeMethodInfo runtimeMethodInfo = methodsByName[i];
				if (genericParamCount == -1)
				{
					goto IL_5E;
				}
				bool isGenericMethod = runtimeMethodInfo.IsGenericMethod;
				if ((genericParamCount != 0 || !isGenericMethod) && (genericParamCount <= 0 || isGenericMethod) && runtimeMethodInfo.GetGenericArguments().Length == genericParamCount)
				{
					goto IL_5E;
				}
				IL_82:
				i++;
				continue;
				IL_5E:
				if (RuntimeType.FilterApplyMethodInfo(runtimeMethodInfo, bindingAttr, callConv, types) && (!flag || RuntimeType.FilterApplyPrefixLookup(runtimeMethodInfo, name, ignoreCase)))
				{
					result.Add(runtimeMethodInfo);
					goto IL_82;
				}
				goto IL_82;
			}
			return result;
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0003621C File Offset: 0x0003441C
		private RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup)
		{
			bool flag;
			bool ignoreCase;
			RuntimeType.MemberListType memberListType;
			RuntimeType.FilterHelper(bindingAttr, ref name, allowPrefixLookup, out flag, out ignoreCase, out memberListType);
			if ((!flag && name != null && name.Length == 0) || (!string.IsNullOrEmpty(name) && name != ConstructorInfo.ConstructorName && name != ConstructorInfo.TypeConstructorName))
			{
				return new RuntimeType.ListBuilder<ConstructorInfo>(0);
			}
			RuntimeConstructorInfo[] constructors_internal = this.GetConstructors_internal(bindingAttr, this);
			RuntimeType.ListBuilder<ConstructorInfo> result = new RuntimeType.ListBuilder<ConstructorInfo>(constructors_internal.Length);
			foreach (RuntimeConstructorInfo runtimeConstructorInfo in constructors_internal)
			{
				if (RuntimeType.FilterApplyConstructorInfo(runtimeConstructorInfo, bindingAttr, callConv, types) && (!flag || RuntimeType.FilterApplyPrefixLookup(runtimeConstructorInfo, name, ignoreCase)))
				{
					result.Add(runtimeConstructorInfo);
				}
			}
			return result;
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x000362C4 File Offset: 0x000344C4
		private RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup)
		{
			bool flag;
			bool ignoreCase;
			RuntimeType.MemberListType listType;
			RuntimeType.FilterHelper(bindingAttr, ref name, allowPrefixLookup, out flag, out ignoreCase, out listType);
			RuntimePropertyInfo[] propertiesByName = this.GetPropertiesByName(name, bindingAttr, listType, this);
			bindingAttr ^= BindingFlags.DeclaredOnly;
			RuntimeType.ListBuilder<PropertyInfo> result = new RuntimeType.ListBuilder<PropertyInfo>(propertiesByName.Length);
			foreach (RuntimePropertyInfo runtimePropertyInfo in propertiesByName)
			{
				if ((bindingAttr & runtimePropertyInfo.BindingFlags) == runtimePropertyInfo.BindingFlags && (!flag || RuntimeType.FilterApplyPrefixLookup(runtimePropertyInfo, name, ignoreCase)) && (types == null || runtimePropertyInfo.GetIndexParameters().Length == types.Length))
				{
					result.Add(runtimePropertyInfo);
				}
			}
			return result;
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00036350 File Offset: 0x00034550
		private RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			bool flag;
			bool ignoreCase;
			RuntimeType.MemberListType listType;
			RuntimeType.FilterHelper(bindingAttr, ref name, allowPrefixLookup, out flag, out ignoreCase, out listType);
			RuntimeEventInfo[] events_internal = this.GetEvents_internal(name, bindingAttr, listType, this);
			bindingAttr ^= BindingFlags.DeclaredOnly;
			RuntimeType.ListBuilder<EventInfo> result = new RuntimeType.ListBuilder<EventInfo>(events_internal.Length);
			foreach (RuntimeEventInfo runtimeEventInfo in events_internal)
			{
				if ((bindingAttr & runtimeEventInfo.BindingFlags) == runtimeEventInfo.BindingFlags && (!flag || RuntimeType.FilterApplyPrefixLookup(runtimeEventInfo, name, ignoreCase)))
				{
					result.Add(runtimeEventInfo);
				}
			}
			return result;
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x000363CC File Offset: 0x000345CC
		private RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			bool flag;
			bool ignoreCase;
			RuntimeType.MemberListType listType;
			RuntimeType.FilterHelper(bindingAttr, ref name, allowPrefixLookup, out flag, out ignoreCase, out listType);
			RuntimeFieldInfo[] fields_internal = this.GetFields_internal(name, bindingAttr, listType, this);
			bindingAttr ^= BindingFlags.DeclaredOnly;
			RuntimeType.ListBuilder<FieldInfo> result = new RuntimeType.ListBuilder<FieldInfo>(fields_internal.Length);
			foreach (RuntimeFieldInfo runtimeFieldInfo in fields_internal)
			{
				if ((bindingAttr & runtimeFieldInfo.BindingFlags) == runtimeFieldInfo.BindingFlags && (!flag || RuntimeType.FilterApplyPrefixLookup(runtimeFieldInfo, name, ignoreCase)))
				{
					result.Add(runtimeFieldInfo);
				}
			}
			return result;
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00036448 File Offset: 0x00034648
		private RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			bindingAttr &= ~BindingFlags.Static;
			string text;
			string ns;
			RuntimeType.SplitName(fullname, out text, out ns);
			bool prefixLookup;
			bool flag;
			RuntimeType.MemberListType listType;
			RuntimeType.FilterHelper(bindingAttr, ref text, allowPrefixLookup, out prefixLookup, out flag, out listType);
			RuntimeType[] nestedTypes_internal = this.GetNestedTypes_internal(text, bindingAttr, listType);
			RuntimeType.ListBuilder<Type> result = new RuntimeType.ListBuilder<Type>(nestedTypes_internal.Length);
			foreach (RuntimeType runtimeType in nestedTypes_internal)
			{
				if (RuntimeType.FilterApplyType(runtimeType, bindingAttr, text, prefixLookup, ns))
				{
					result.Add(runtimeType);
				}
			}
			return result;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x000364C0 File Offset: 0x000346C0
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			return this.GetMethodCandidates(null, bindingAttr, CallingConventions.Any, null, -1, false).ToArray();
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x000364E4 File Offset: 0x000346E4
		[ComVisible(true)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			return this.GetConstructorCandidates(null, bindingAttr, CallingConventions.Any, null, false).ToArray();
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00036504 File Offset: 0x00034704
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			return this.GetPropertyCandidates(null, bindingAttr, null, false).ToArray();
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00036524 File Offset: 0x00034724
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			return this.GetEventCandidates(null, bindingAttr, false).ToArray();
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00036544 File Offset: 0x00034744
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			return this.GetFieldCandidates(null, bindingAttr, false).ToArray();
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00036564 File Offset: 0x00034764
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			RuntimeType.ListBuilder<ConstructorInfo> constructorCandidates = this.GetConstructorCandidates(null, bindingAttr, CallingConventions.Any, types, false);
			if (constructorCandidates.Count == 0)
			{
				return null;
			}
			if (types.Length == 0 && constructorCandidates.Count == 1)
			{
				ConstructorInfo constructorInfo = constructorCandidates[0];
				ParameterInfo[] parametersNoCopy = constructorInfo.GetParametersNoCopy();
				if (parametersNoCopy == null || parametersNoCopy.Length == 0)
				{
					return constructorInfo;
				}
			}
			MethodBase[] match;
			if ((bindingAttr & BindingFlags.ExactBinding) != BindingFlags.Default)
			{
				match = constructorCandidates.ToArray();
				return System.DefaultBinder.ExactBinding(match, types, modifiers) as ConstructorInfo;
			}
			if (binder == null)
			{
				binder = Type.DefaultBinder;
			}
			Binder binder2 = binder;
			match = constructorCandidates.ToArray();
			return binder2.SelectMethod(bindingAttr, match, types, modifiers) as ConstructorInfo;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x000365F8 File Offset: 0x000347F8
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			if (name == null)
			{
				throw new ArgumentNullException();
			}
			RuntimeType.ListBuilder<PropertyInfo> propertyCandidates = this.GetPropertyCandidates(name, bindingAttr, types, false);
			if (propertyCandidates.Count == 0)
			{
				return null;
			}
			if (types == null || types.Length == 0)
			{
				if (propertyCandidates.Count == 1)
				{
					PropertyInfo propertyInfo = propertyCandidates[0];
					if (returnType != null && !returnType.IsEquivalentTo(propertyInfo.PropertyType))
					{
						return null;
					}
					return propertyInfo;
				}
				else if (returnType == null)
				{
					throw new AmbiguousMatchException(Environment.GetResourceString("Ambiguous match found."));
				}
			}
			if ((bindingAttr & BindingFlags.ExactBinding) != BindingFlags.Default)
			{
				return System.DefaultBinder.ExactPropertyBinding(propertyCandidates.ToArray(), returnType, types, modifiers);
			}
			if (binder == null)
			{
				binder = Type.DefaultBinder;
			}
			return binder.SelectProperty(bindingAttr, propertyCandidates.ToArray(), returnType, types, modifiers);
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x000366A8 File Offset: 0x000348A8
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			if (name == null)
			{
				throw new ArgumentNullException();
			}
			bool flag;
			RuntimeType.MemberListType listType;
			RuntimeType.FilterHelper(bindingAttr, ref name, out flag, out listType);
			RuntimeEventInfo[] events_internal = this.GetEvents_internal(name, bindingAttr, listType, this);
			EventInfo eventInfo = null;
			bindingAttr ^= BindingFlags.DeclaredOnly;
			foreach (RuntimeEventInfo runtimeEventInfo in events_internal)
			{
				if ((bindingAttr & runtimeEventInfo.BindingFlags) == runtimeEventInfo.BindingFlags)
				{
					if (eventInfo != null)
					{
						throw new AmbiguousMatchException(Environment.GetResourceString("Ambiguous match found."));
					}
					eventInfo = runtimeEventInfo;
				}
			}
			return eventInfo;
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00036724 File Offset: 0x00034924
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			if (name == null)
			{
				throw new ArgumentNullException();
			}
			bool flag;
			RuntimeType.MemberListType listType;
			RuntimeType.FilterHelper(bindingAttr, ref name, out flag, out listType);
			RuntimeFieldInfo[] fields_internal = this.GetFields_internal(name, bindingAttr, listType, this);
			FieldInfo fieldInfo = null;
			bindingAttr ^= BindingFlags.DeclaredOnly;
			bool flag2 = false;
			foreach (RuntimeFieldInfo runtimeFieldInfo in fields_internal)
			{
				if ((bindingAttr & runtimeFieldInfo.BindingFlags) == runtimeFieldInfo.BindingFlags)
				{
					if (fieldInfo != null)
					{
						if (runtimeFieldInfo.DeclaringType == fieldInfo.DeclaringType)
						{
							throw new AmbiguousMatchException(Environment.GetResourceString("Ambiguous match found."));
						}
						if (fieldInfo.DeclaringType.IsInterface && runtimeFieldInfo.DeclaringType.IsInterface)
						{
							flag2 = true;
						}
					}
					if (fieldInfo == null || runtimeFieldInfo.DeclaringType.IsSubclassOf(fieldInfo.DeclaringType) || fieldInfo.DeclaringType.IsInterface)
					{
						fieldInfo = runtimeFieldInfo;
					}
				}
			}
			if (flag2 && fieldInfo.DeclaringType.IsInterface)
			{
				throw new AmbiguousMatchException(Environment.GetResourceString("Ambiguous match found."));
			}
			return fieldInfo;
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00036820 File Offset: 0x00034A20
		public override Type GetNestedType(string fullname, BindingFlags bindingAttr)
		{
			if (fullname == null)
			{
				throw new ArgumentNullException();
			}
			bindingAttr &= ~BindingFlags.Static;
			string text;
			string ns;
			RuntimeType.SplitName(fullname, out text, out ns);
			bool flag;
			RuntimeType.MemberListType listType;
			RuntimeType.FilterHelper(bindingAttr, ref text, out flag, out listType);
			RuntimeType[] nestedTypes_internal = this.GetNestedTypes_internal(text, bindingAttr, listType);
			RuntimeType runtimeType = null;
			foreach (RuntimeType runtimeType2 in nestedTypes_internal)
			{
				if (RuntimeType.FilterApplyType(runtimeType2, bindingAttr, text, false, ns))
				{
					if (runtimeType != null)
					{
						throw new AmbiguousMatchException(Environment.GetResourceString("Ambiguous match found."));
					}
					runtimeType = runtimeType2;
				}
			}
			return runtimeType;
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x000368A8 File Offset: 0x00034AA8
		public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			if (name == null)
			{
				throw new ArgumentNullException();
			}
			RuntimeType.ListBuilder<MethodInfo> listBuilder = default(RuntimeType.ListBuilder<MethodInfo>);
			RuntimeType.ListBuilder<ConstructorInfo> listBuilder2 = default(RuntimeType.ListBuilder<ConstructorInfo>);
			RuntimeType.ListBuilder<PropertyInfo> listBuilder3 = default(RuntimeType.ListBuilder<PropertyInfo>);
			RuntimeType.ListBuilder<EventInfo> listBuilder4 = default(RuntimeType.ListBuilder<EventInfo>);
			RuntimeType.ListBuilder<FieldInfo> listBuilder5 = default(RuntimeType.ListBuilder<FieldInfo>);
			RuntimeType.ListBuilder<Type> listBuilder6 = default(RuntimeType.ListBuilder<Type>);
			int num = 0;
			if ((type & MemberTypes.Method) != (MemberTypes)0)
			{
				listBuilder = this.GetMethodCandidates(name, bindingAttr, CallingConventions.Any, null, -1, true);
				if (type == MemberTypes.Method)
				{
					return listBuilder.ToArray();
				}
				num += listBuilder.Count;
			}
			if ((type & MemberTypes.Constructor) != (MemberTypes)0)
			{
				listBuilder2 = this.GetConstructorCandidates(name, bindingAttr, CallingConventions.Any, null, true);
				if (type == MemberTypes.Constructor)
				{
					return listBuilder2.ToArray();
				}
				num += listBuilder2.Count;
			}
			if ((type & MemberTypes.Property) != (MemberTypes)0)
			{
				listBuilder3 = this.GetPropertyCandidates(name, bindingAttr, null, true);
				if (type == MemberTypes.Property)
				{
					return listBuilder3.ToArray();
				}
				num += listBuilder3.Count;
			}
			if ((type & MemberTypes.Event) != (MemberTypes)0)
			{
				listBuilder4 = this.GetEventCandidates(name, bindingAttr, true);
				if (type == MemberTypes.Event)
				{
					return listBuilder4.ToArray();
				}
				num += listBuilder4.Count;
			}
			if ((type & MemberTypes.Field) != (MemberTypes)0)
			{
				listBuilder5 = this.GetFieldCandidates(name, bindingAttr, true);
				if (type == MemberTypes.Field)
				{
					return listBuilder5.ToArray();
				}
				num += listBuilder5.Count;
			}
			if ((type & (MemberTypes.TypeInfo | MemberTypes.NestedType)) != (MemberTypes)0)
			{
				listBuilder6 = this.GetNestedTypeCandidates(name, bindingAttr, true);
				if (type == MemberTypes.NestedType || type == MemberTypes.TypeInfo)
				{
					return listBuilder6.ToArray();
				}
				num += listBuilder6.Count;
			}
			MemberInfo[] array;
			if (type != (MemberTypes.Constructor | MemberTypes.Method))
			{
				array = new MemberInfo[num];
			}
			else
			{
				MemberInfo[] array2 = new MethodBase[num];
				array = array2;
			}
			MemberInfo[] array3 = array;
			int num2 = 0;
			object[] array4 = array3;
			listBuilder.CopyTo(array4, num2);
			num2 += listBuilder.Count;
			array4 = array3;
			listBuilder2.CopyTo(array4, num2);
			num2 += listBuilder2.Count;
			array4 = array3;
			listBuilder3.CopyTo(array4, num2);
			num2 += listBuilder3.Count;
			array4 = array3;
			listBuilder4.CopyTo(array4, num2);
			num2 += listBuilder4.Count;
			array4 = array3;
			listBuilder5.CopyTo(array4, num2);
			num2 += listBuilder5.Count;
			array4 = array3;
			listBuilder6.CopyTo(array4, num2);
			num2 += listBuilder6.Count;
			return array3;
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x00036ACC File Offset: 0x00034CCC
		public override Module Module
		{
			get
			{
				return this.GetRuntimeModule();
			}
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00036AD4 File Offset: 0x00034CD4
		internal RuntimeModule GetRuntimeModule()
		{
			return RuntimeTypeHandle.GetModule(this);
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x00036ADC File Offset: 0x00034CDC
		public override Assembly Assembly
		{
			get
			{
				return this.GetRuntimeAssembly();
			}
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00036AE4 File Offset: 0x00034CE4
		internal RuntimeAssembly GetRuntimeAssembly()
		{
			return RuntimeTypeHandle.GetAssembly(this);
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00036AEC File Offset: 0x00034CEC
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				return new RuntimeTypeHandle(this);
			}
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00036AF4 File Offset: 0x00034CF4
		[SecuritySafeCritical]
		public override bool IsInstanceOfType(object o)
		{
			return RuntimeTypeHandle.IsInstanceOfType(this, o);
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00036AFD File Offset: 0x00034CFD
		public override bool IsAssignableFrom(System.Reflection.TypeInfo typeInfo)
		{
			return !(typeInfo == null) && this.IsAssignableFrom(typeInfo.AsType());
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00036B18 File Offset: 0x00034D18
		public override bool IsAssignableFrom(Type c)
		{
			if (c == null)
			{
				return false;
			}
			if (c == this)
			{
				return true;
			}
			RuntimeType runtimeType = c.UnderlyingSystemType as RuntimeType;
			if (runtimeType != null)
			{
				return RuntimeTypeHandle.CanCastTo(runtimeType, this);
			}
			if (RuntimeFeature.IsDynamicCodeSupported && c is TypeBuilder)
			{
				if (c.IsSubclassOf(this))
				{
					return true;
				}
				if (base.IsInterface)
				{
					return c.ImplementInterface(this);
				}
				if (this.IsGenericParameter)
				{
					Type[] genericParameterConstraints = this.GetGenericParameterConstraints();
					for (int i = 0; i < genericParameterConstraints.Length; i++)
					{
						if (!genericParameterConstraints[i].IsAssignableFrom(c))
						{
							return false;
						}
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00036BA4 File Offset: 0x00034DA4
		public override bool IsEquivalentTo(Type other)
		{
			RuntimeType runtimeType = other as RuntimeType;
			return runtimeType != null && (runtimeType == this || RuntimeTypeHandle.IsEquivalentTo(this, runtimeType));
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x00036BCF File Offset: 0x00034DCF
		public override Type BaseType
		{
			get
			{
				return this.GetBaseType();
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00036BD8 File Offset: 0x00034DD8
		private RuntimeType GetBaseType()
		{
			if (base.IsInterface)
			{
				return null;
			}
			if (RuntimeTypeHandle.IsGenericVariable(this))
			{
				Type[] genericParameterConstraints = this.GetGenericParameterConstraints();
				RuntimeType runtimeType = RuntimeType.ObjectType;
				foreach (RuntimeType runtimeType2 in genericParameterConstraints)
				{
					if (!runtimeType2.IsInterface)
					{
						if (runtimeType2.IsGenericParameter)
						{
							GenericParameterAttributes genericParameterAttributes = runtimeType2.GenericParameterAttributes & GenericParameterAttributes.SpecialConstraintMask;
							if ((genericParameterAttributes & GenericParameterAttributes.ReferenceTypeConstraint) == GenericParameterAttributes.None && (genericParameterAttributes & GenericParameterAttributes.NotNullableValueTypeConstraint) == GenericParameterAttributes.None)
							{
								goto IL_55;
							}
						}
						runtimeType = runtimeType2;
					}
					IL_55:;
				}
				if (runtimeType == RuntimeType.ObjectType && (this.GenericParameterAttributes & GenericParameterAttributes.SpecialConstraintMask & GenericParameterAttributes.NotNullableValueTypeConstraint) != GenericParameterAttributes.None)
				{
					runtimeType = RuntimeType.ValueType;
				}
				return runtimeType;
			}
			return RuntimeTypeHandle.GetBaseType(this);
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x0000245A File Offset: 0x0000065A
		public override Type UnderlyingSystemType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00036C6C File Offset: 0x00034E6C
		[SecuritySafeCritical]
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return RuntimeTypeHandle.GetAttributes(this);
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00036C74 File Offset: 0x00034E74
		[SecuritySafeCritical]
		protected override bool IsContextfulImpl()
		{
			return RuntimeTypeHandle.IsContextful(this);
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00036C7C File Offset: 0x00034E7C
		protected override bool IsByRefImpl()
		{
			return RuntimeTypeHandle.IsByRef(this);
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00036C84 File Offset: 0x00034E84
		protected override bool IsPrimitiveImpl()
		{
			return RuntimeTypeHandle.IsPrimitive(this);
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00036C8C File Offset: 0x00034E8C
		protected override bool IsPointerImpl()
		{
			return RuntimeTypeHandle.IsPointer(this);
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00036C94 File Offset: 0x00034E94
		[SecuritySafeCritical]
		protected override bool IsCOMObjectImpl()
		{
			return RuntimeTypeHandle.IsComObject(this, false);
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00036C9D File Offset: 0x00034E9D
		protected override bool IsValueTypeImpl()
		{
			return !(this == typeof(ValueType)) && !(this == typeof(Enum)) && this.IsSubclassOf(typeof(ValueType));
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x00036CD5 File Offset: 0x00034ED5
		public override bool IsEnum
		{
			get
			{
				return this.GetBaseType() == RuntimeType.EnumType;
			}
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00036CE7 File Offset: 0x00034EE7
		protected override bool HasElementTypeImpl()
		{
			return RuntimeTypeHandle.HasElementType(this);
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x00036CEF File Offset: 0x00034EEF
		public override GenericParameterAttributes GenericParameterAttributes
		{
			[SecuritySafeCritical]
			get
			{
				if (!this.IsGenericParameter)
				{
					throw new InvalidOperationException(Environment.GetResourceString("Method may only be called on a Type for which Type.IsGenericParameter is true."));
				}
				return this.GetGenericParameterAttributes();
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x00036D0F File Offset: 0x00034F0F
		internal override bool IsSzArray
		{
			get
			{
				return RuntimeTypeHandle.IsSzArray(this);
			}
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00036D17 File Offset: 0x00034F17
		protected override bool IsArrayImpl()
		{
			return RuntimeTypeHandle.IsArray(this);
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00036D1F File Offset: 0x00034F1F
		[SecuritySafeCritical]
		public override int GetArrayRank()
		{
			if (!this.IsArrayImpl())
			{
				throw new ArgumentException(Environment.GetResourceString("Must be an array type."));
			}
			return RuntimeTypeHandle.GetArrayRank(this);
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00036D3F File Offset: 0x00034F3F
		public override Type GetElementType()
		{
			return RuntimeTypeHandle.GetElementType(this);
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00036D48 File Offset: 0x00034F48
		public override string[] GetEnumNames()
		{
			if (!this.IsEnum)
			{
				throw new ArgumentException(Environment.GetResourceString("Type provided must be an Enum."), "enumType");
			}
			string[] array = Enum.InternalGetNames(this);
			string[] array2 = new string[array.Length];
			Array.Copy(array, array2, array.Length);
			return array2;
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00036D90 File Offset: 0x00034F90
		[SecuritySafeCritical]
		public override Array GetEnumValues()
		{
			if (!this.IsEnum)
			{
				throw new ArgumentException(Environment.GetResourceString("Type provided must be an Enum."), "enumType");
			}
			ulong[] array = Enum.InternalGetValues(this);
			Array array2 = Array.CreateInstance(this, array.Length);
			for (int i = 0; i < array.Length; i++)
			{
				object value = Enum.ToObject(this, array[i]);
				array2.SetValue(value, i);
			}
			return array2;
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00036DEC File Offset: 0x00034FEC
		public override Type GetEnumUnderlyingType()
		{
			if (!this.IsEnum)
			{
				throw new ArgumentException(Environment.GetResourceString("Type provided must be an Enum."), "enumType");
			}
			return Enum.InternalGetUnderlyingType(this);
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00036E14 File Offset: 0x00035014
		public override bool IsEnumDefined(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			RuntimeType runtimeType = (RuntimeType)value.GetType();
			if (runtimeType.IsEnum)
			{
				if (!runtimeType.IsEquivalentTo(this))
				{
					throw new ArgumentException(Environment.GetResourceString("Object must be the same type as the enum. The type passed in was '{0}'; the enum type was '{1}'.", new object[]
					{
						runtimeType.ToString(),
						this.ToString()
					}));
				}
				runtimeType = (RuntimeType)runtimeType.GetEnumUnderlyingType();
			}
			if (runtimeType == RuntimeType.StringType)
			{
				object[] array = Enum.InternalGetNames(this);
				return Array.IndexOf<object>(array, value) >= 0;
			}
			if (Type.IsIntegerType(runtimeType))
			{
				RuntimeType runtimeType2 = Enum.InternalGetUnderlyingType(this);
				if (runtimeType2 != runtimeType)
				{
					throw new ArgumentException(Environment.GetResourceString("Enum underlying type and the object must be same type or object must be a String. Type passed in was '{0}'; the enum underlying type was '{1}'.", new object[]
					{
						runtimeType.ToString(),
						runtimeType2.ToString()
					}));
				}
				ulong[] array2 = Enum.InternalGetValues(this);
				ulong value2 = Enum.ToUInt64(value);
				return Array.BinarySearch<ulong>(array2, value2) >= 0;
			}
			else
			{
				if (CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
				{
					throw new ArgumentException(Environment.GetResourceString("Enum underlying type and the object must be same type or object must be a String. Type passed in was '{0}'; the enum underlying type was '{1}'.", new object[]
					{
						runtimeType.ToString(),
						this.GetEnumUnderlyingType()
					}));
				}
				throw new InvalidOperationException(Environment.GetResourceString("Unknown enum type."));
			}
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00036F3C File Offset: 0x0003513C
		public override string GetEnumName(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Type type = value.GetType();
			if (!type.IsEnum && !Type.IsIntegerType(type))
			{
				throw new ArgumentException(Environment.GetResourceString("The value passed in must be an enum base or an underlying type for an enum, such as an Int32."), "value");
			}
			ulong[] array = Enum.InternalGetValues(this);
			ulong value2 = Enum.ToUInt64(value);
			int num = Array.BinarySearch<ulong>(array, value2);
			if (num >= 0)
			{
				return Enum.InternalGetNames(this)[num];
			}
			return null;
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00036FA5 File Offset: 0x000351A5
		internal RuntimeType[] GetGenericArgumentsInternal()
		{
			return (RuntimeType[])this.GetGenericArgumentsInternal(true);
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00036FB4 File Offset: 0x000351B4
		public override Type[] GetGenericArguments()
		{
			Type[] array = this.GetGenericArgumentsInternal(false);
			if (array == null)
			{
				array = Array.Empty<Type>();
			}
			return array;
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00036FD4 File Offset: 0x000351D4
		[SecuritySafeCritical]
		public override Type MakeGenericType(params Type[] instantiation)
		{
			if (instantiation == null)
			{
				throw new ArgumentNullException("instantiation");
			}
			RuntimeType[] array = new RuntimeType[instantiation.Length];
			if (!this.IsGenericTypeDefinition)
			{
				throw new InvalidOperationException(Environment.GetResourceString("{0} is not a GenericTypeDefinition. MakeGenericType may only be called on a type for which Type.IsGenericTypeDefinition is true.", new object[]
				{
					this
				}));
			}
			if (this.GetGenericArguments().Length != instantiation.Length)
			{
				throw new ArgumentException(Environment.GetResourceString("The number of generic arguments provided doesn't equal the arity of the generic type definition."), "instantiation");
			}
			int i = 0;
			while (i < instantiation.Length)
			{
				Type type = instantiation[i];
				if (type == null)
				{
					throw new ArgumentNullException();
				}
				RuntimeType runtimeType = type as RuntimeType;
				if (runtimeType == null)
				{
					if (type.IsSignatureType)
					{
						return Type.MakeGenericSignatureType(this, instantiation);
					}
					Type[] array2 = new Type[instantiation.Length];
					for (int j = 0; j < instantiation.Length; j++)
					{
						array2[j] = instantiation[j];
					}
					instantiation = array2;
					if (!RuntimeFeature.IsDynamicCodeSupported)
					{
						throw new PlatformNotSupportedException();
					}
					return this.MakeTypeBuilderInstantiation(instantiation);
				}
				else
				{
					array[i] = runtimeType;
					i++;
				}
			}
			RuntimeType[] genericArgumentsInternal = this.GetGenericArgumentsInternal();
			RuntimeType.SanityCheckGenericArguments(array, genericArgumentsInternal);
			Type[] types = array;
			Type type2 = RuntimeType.MakeGenericType(this, types);
			if (type2 == null)
			{
				throw new TypeLoadException();
			}
			return type2;
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x000370ED File Offset: 0x000352ED
		private Type MakeTypeBuilderInstantiation(Type[] instantiation)
		{
			return TypeBuilderInstantiation.MakeGenericType(this, instantiation);
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x000370F6 File Offset: 0x000352F6
		public override bool IsGenericTypeDefinition
		{
			get
			{
				return RuntimeTypeHandle.IsGenericTypeDefinition(this);
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x000370FE File Offset: 0x000352FE
		public override bool IsGenericParameter
		{
			get
			{
				return RuntimeTypeHandle.IsGenericVariable(this);
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x00037106 File Offset: 0x00035306
		public override int GenericParameterPosition
		{
			get
			{
				if (!this.IsGenericParameter)
				{
					throw new InvalidOperationException(Environment.GetResourceString("Method may only be called on a Type for which Type.IsGenericParameter is true."));
				}
				return this.GetGenericParameterPosition();
			}
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00037126 File Offset: 0x00035326
		public override Type GetGenericTypeDefinition()
		{
			if (!this.IsGenericType)
			{
				throw new InvalidOperationException(Environment.GetResourceString("This operation is only valid on generic types."));
			}
			return RuntimeTypeHandle.GetGenericTypeDefinition(this);
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x00037146 File Offset: 0x00035346
		public override bool IsGenericType
		{
			get
			{
				return RuntimeTypeHandle.HasInstantiation(this);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x0003714E File Offset: 0x0003534E
		public override bool IsConstructedGenericType
		{
			get
			{
				return this.IsGenericType && !this.IsGenericTypeDefinition;
			}
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00037164 File Offset: 0x00035364
		[SecuritySafeCritical]
		[DebuggerStepThrough]
		[DebuggerHidden]
		public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams)
		{
			if (this.IsGenericParameter)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Method must be called on a Type for which Type.IsGenericParameter is false."));
			}
			if ((bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.CreateInstance | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty)) == BindingFlags.Default)
			{
				throw new ArgumentException(Environment.GetResourceString("Must specify binding flags describing the invoke operation required (BindingFlags.InvokeMethod CreateInstance GetField SetField GetProperty SetProperty)."), "bindingFlags");
			}
			if ((bindingFlags & (BindingFlags)255) == BindingFlags.Default)
			{
				bindingFlags |= (BindingFlags.Instance | BindingFlags.Public);
				if ((bindingFlags & BindingFlags.CreateInstance) == BindingFlags.Default)
				{
					bindingFlags |= BindingFlags.Static;
				}
			}
			if (namedParams != null)
			{
				if (providedArgs != null)
				{
					if (namedParams.Length > providedArgs.Length)
					{
						throw new ArgumentException(Environment.GetResourceString("Named parameter array cannot be bigger than argument array."), "namedParams");
					}
				}
				else if (namedParams.Length != 0)
				{
					throw new ArgumentException(Environment.GetResourceString("Named parameter array cannot be bigger than argument array."), "namedParams");
				}
			}
			if (target != null && target.GetType().IsCOMObject)
			{
				if ((bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty)) == BindingFlags.Default)
				{
					throw new ArgumentException(Environment.GetResourceString("Must specify property Set or Get or method call for a COM Object."), "bindingFlags");
				}
				if ((bindingFlags & BindingFlags.GetProperty) != BindingFlags.Default && (bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty) & ~(BindingFlags.InvokeMethod | BindingFlags.GetProperty)) != BindingFlags.Default)
				{
					throw new ArgumentException(Environment.GetResourceString("Cannot specify both Get and Set on a property."), "bindingFlags");
				}
				if ((bindingFlags & BindingFlags.InvokeMethod) != BindingFlags.Default && (bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty) & ~(BindingFlags.InvokeMethod | BindingFlags.GetProperty)) != BindingFlags.Default)
				{
					throw new ArgumentException(Environment.GetResourceString("Cannot specify Set on a property and Invoke on a method."), "bindingFlags");
				}
				if ((bindingFlags & BindingFlags.SetProperty) != BindingFlags.Default && (bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty) & ~BindingFlags.SetProperty) != BindingFlags.Default)
				{
					throw new ArgumentException(Environment.GetResourceString("Only one of the following binding flags can be set: BindingFlags.SetProperty, BindingFlags.PutDispProperty,  BindingFlags.PutRefDispProperty."), "bindingFlags");
				}
				if ((bindingFlags & BindingFlags.PutDispProperty) != BindingFlags.Default && (bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty) & ~BindingFlags.PutDispProperty) != BindingFlags.Default)
				{
					throw new ArgumentException(Environment.GetResourceString("Only one of the following binding flags can be set: BindingFlags.SetProperty, BindingFlags.PutDispProperty,  BindingFlags.PutRefDispProperty."), "bindingFlags");
				}
				if ((bindingFlags & BindingFlags.PutRefDispProperty) != BindingFlags.Default && (bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty) & ~BindingFlags.PutRefDispProperty) != BindingFlags.Default)
				{
					throw new ArgumentException(Environment.GetResourceString("Only one of the following binding flags can be set: BindingFlags.SetProperty, BindingFlags.PutDispProperty,  BindingFlags.PutRefDispProperty."), "bindingFlags");
				}
				if (RemotingServices.IsTransparentProxy(target))
				{
					throw new NotImplementedException();
				}
				if (name == null)
				{
					throw new ArgumentNullException("name");
				}
				throw new NotImplementedException();
			}
			else
			{
				if (namedParams != null && Array.IndexOf<string>(namedParams, null) != -1)
				{
					throw new ArgumentException(Environment.GetResourceString("Named parameter value must not be null."), "namedParams");
				}
				int num = (providedArgs != null) ? providedArgs.Length : 0;
				if (binder == null)
				{
					binder = Type.DefaultBinder;
				}
				if ((bindingFlags & BindingFlags.CreateInstance) != BindingFlags.Default)
				{
					if ((bindingFlags & BindingFlags.CreateInstance) != BindingFlags.Default && (bindingFlags & (BindingFlags.InvokeMethod | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty)) != BindingFlags.Default)
					{
						throw new ArgumentException(Environment.GetResourceString("Cannot specify both CreateInstance and another access type."), "bindingFlags");
					}
					return Activator.CreateInstance(this, bindingFlags, binder, providedArgs, culture);
				}
				else
				{
					if ((bindingFlags & (BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty)) != BindingFlags.Default)
					{
						bindingFlags |= BindingFlags.SetProperty;
					}
					if (name == null)
					{
						throw new ArgumentNullException("name");
					}
					if (name.Length == 0 || name.Equals("[DISPID=0]"))
					{
						name = this.GetDefaultMemberName();
						if (name == null)
						{
							name = "ToString";
						}
					}
					bool flag = (bindingFlags & BindingFlags.GetField) > BindingFlags.Default;
					bool flag2 = (bindingFlags & BindingFlags.SetField) > BindingFlags.Default;
					if (flag || flag2)
					{
						if (flag)
						{
							if (flag2)
							{
								throw new ArgumentException(Environment.GetResourceString("Cannot specify both Get and Set on a field."), "bindingFlags");
							}
							if ((bindingFlags & BindingFlags.SetProperty) != BindingFlags.Default)
							{
								throw new ArgumentException(Environment.GetResourceString("Cannot specify both GetField and SetProperty."), "bindingFlags");
							}
						}
						else
						{
							if (providedArgs == null)
							{
								throw new ArgumentNullException("providedArgs");
							}
							if ((bindingFlags & BindingFlags.GetProperty) != BindingFlags.Default)
							{
								throw new ArgumentException(Environment.GetResourceString("Cannot specify both SetField and GetProperty."), "bindingFlags");
							}
							if ((bindingFlags & BindingFlags.InvokeMethod) != BindingFlags.Default)
							{
								throw new ArgumentException(Environment.GetResourceString("Cannot specify Set on a Field and Invoke on a method."), "bindingFlags");
							}
						}
						FieldInfo fieldInfo = null;
						FieldInfo[] array = this.GetMember(name, MemberTypes.Field, bindingFlags) as FieldInfo[];
						if (array.Length == 1)
						{
							fieldInfo = array[0];
						}
						else if (array.Length != 0)
						{
							fieldInfo = binder.BindToField(bindingFlags, array, flag ? Empty.Value : providedArgs[0], culture);
						}
						if (fieldInfo != null)
						{
							if (fieldInfo.FieldType.IsArray || fieldInfo.FieldType == typeof(Array))
							{
								int num2;
								if ((bindingFlags & BindingFlags.GetField) != BindingFlags.Default)
								{
									num2 = num;
								}
								else
								{
									num2 = num - 1;
								}
								if (num2 > 0)
								{
									int[] array2 = new int[num2];
									for (int i = 0; i < num2; i++)
									{
										try
										{
											array2[i] = ((IConvertible)providedArgs[i]).ToInt32(null);
										}
										catch (InvalidCastException)
										{
											throw new ArgumentException(Environment.GetResourceString("All indexes must be of type Int32."));
										}
									}
									Array array3 = (Array)fieldInfo.GetValue(target);
									if ((bindingFlags & BindingFlags.GetField) != BindingFlags.Default)
									{
										return array3.GetValue(array2);
									}
									array3.SetValue(providedArgs[num2], array2);
									return null;
								}
							}
							if (flag)
							{
								if (num != 0)
								{
									throw new ArgumentException(Environment.GetResourceString("No arguments can be provided to Get a field value."), "bindingFlags");
								}
								return fieldInfo.GetValue(target);
							}
							else
							{
								if (num != 1)
								{
									throw new ArgumentException(Environment.GetResourceString("Only the field value can be specified to set a field value."), "bindingFlags");
								}
								fieldInfo.SetValue(target, providedArgs[0], bindingFlags, binder, culture);
								return null;
							}
						}
						else if ((bindingFlags & (BindingFlags)16773888) == BindingFlags.Default)
						{
							throw new MissingFieldException(this.FullName, name);
						}
					}
					bool flag3 = (bindingFlags & BindingFlags.GetProperty) > BindingFlags.Default;
					bool flag4 = (bindingFlags & BindingFlags.SetProperty) > BindingFlags.Default;
					if (flag3 || flag4)
					{
						if (flag3)
						{
							if (flag4)
							{
								throw new ArgumentException(Environment.GetResourceString("Cannot specify both Get and Set on a property."), "bindingFlags");
							}
						}
						else if ((bindingFlags & BindingFlags.InvokeMethod) != BindingFlags.Default)
						{
							throw new ArgumentException(Environment.GetResourceString("Cannot specify Set on a property and Invoke on a method."), "bindingFlags");
						}
					}
					MethodInfo[] array4 = null;
					MethodInfo methodInfo = null;
					if ((bindingFlags & BindingFlags.InvokeMethod) != BindingFlags.Default)
					{
						MethodInfo[] array5 = this.GetMember(name, MemberTypes.Method, bindingFlags) as MethodInfo[];
						List<MethodInfo> list = null;
						foreach (MethodInfo methodInfo2 in array5)
						{
							if (RuntimeType.FilterApplyMethodInfo((RuntimeMethodInfo)methodInfo2, bindingFlags, CallingConventions.Any, new Type[num]))
							{
								if (methodInfo == null)
								{
									methodInfo = methodInfo2;
								}
								else
								{
									if (list == null)
									{
										list = new List<MethodInfo>(array5.Length);
										list.Add(methodInfo);
									}
									list.Add(methodInfo2);
								}
							}
						}
						if (list != null)
						{
							array4 = new MethodInfo[list.Count];
							list.CopyTo(array4);
						}
					}
					if ((methodInfo == null && flag3) || flag4)
					{
						PropertyInfo[] array6 = this.GetMember(name, MemberTypes.Property, bindingFlags) as PropertyInfo[];
						List<MethodInfo> list2 = null;
						for (int k = 0; k < array6.Length; k++)
						{
							MethodInfo methodInfo3;
							if (flag4)
							{
								methodInfo3 = array6[k].GetSetMethod(true);
							}
							else
							{
								methodInfo3 = array6[k].GetGetMethod(true);
							}
							if (!(methodInfo3 == null) && RuntimeType.FilterApplyMethodInfo((RuntimeMethodInfo)methodInfo3, bindingFlags, CallingConventions.Any, new Type[num]))
							{
								if (methodInfo == null)
								{
									methodInfo = methodInfo3;
								}
								else
								{
									if (list2 == null)
									{
										list2 = new List<MethodInfo>(array6.Length);
										list2.Add(methodInfo);
									}
									list2.Add(methodInfo3);
								}
							}
						}
						if (list2 != null)
						{
							array4 = new MethodInfo[list2.Count];
							list2.CopyTo(array4);
						}
					}
					if (!(methodInfo != null))
					{
						throw new MissingMethodException(this.FullName, name);
					}
					if (array4 == null && num == 0 && methodInfo.GetParametersNoCopy().Length == 0 && (bindingFlags & BindingFlags.OptionalParamBinding) == BindingFlags.Default)
					{
						return methodInfo.Invoke(target, bindingFlags, binder, providedArgs, culture);
					}
					if (array4 == null)
					{
						array4 = new MethodInfo[]
						{
							methodInfo
						};
					}
					if (providedArgs == null)
					{
						providedArgs = Array.Empty<object>();
					}
					object obj = null;
					MethodBase methodBase = null;
					try
					{
						Binder binder2 = binder;
						BindingFlags bindingAttr = bindingFlags;
						MethodBase[] match = array4;
						methodBase = binder2.BindToMethod(bindingAttr, match, ref providedArgs, modifiers, culture, namedParams, out obj);
					}
					catch (MissingMethodException)
					{
					}
					if (methodBase == null)
					{
						throw new MissingMethodException(this.FullName, name);
					}
					object result = ((MethodInfo)methodBase).Invoke(target, bindingFlags, binder, providedArgs, culture);
					if (obj != null)
					{
						binder.ReorderArgumentArray(ref providedArgs, obj);
					}
					return result;
				}
			}
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x000378A4 File Offset: 0x00035AA4
		public override bool Equals(object obj)
		{
			return obj == this;
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x0002B2FC File Offset: 0x000294FC
		public static bool operator ==(RuntimeType left, RuntimeType right)
		{
			return left == right;
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x0002B302 File Offset: 0x00029502
		public static bool operator !=(RuntimeType left, RuntimeType right)
		{
			return left != right;
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x0000245A File Offset: 0x0000065A
		public object Clone()
		{
			return this;
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x000378AA File Offset: 0x00035AAA
		[SecurityCritical]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			UnitySerializationHolder.GetUnitySerializationInfo(info, this);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x000378C1 File Offset: 0x00035AC1
		[SecuritySafeCritical]
		public override object[] GetCustomAttributes(bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, RuntimeType.ObjectType, inherit);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x000378D0 File Offset: 0x00035AD0
		[SecuritySafeCritical]
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			RuntimeType runtimeType = attributeType.UnderlyingSystemType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a type provided by the runtime."), "attributeType");
			}
			return MonoCustomAttrs.GetCustomAttributes(this, runtimeType, inherit);
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00037920 File Offset: 0x00035B20
		[SecuritySafeCritical]
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			RuntimeType runtimeType = attributeType.UnderlyingSystemType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a type provided by the runtime."), "attributeType");
			}
			return MonoCustomAttrs.IsDefined(this, runtimeType, inherit);
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0003796D File Offset: 0x00035B6D
		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return CustomAttributeData.GetCustomAttributesInternal(this);
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00037978 File Offset: 0x00035B78
		internal override string FormatTypeName(bool serialization)
		{
			if (serialization)
			{
				return this.GetCachedName(TypeNameKind.SerializationName);
			}
			Type rootElementType = base.GetRootElementType();
			if (rootElementType.IsNested)
			{
				return this.Name;
			}
			string text = this.ToString();
			if (rootElementType.IsPrimitive || rootElementType == typeof(void) || rootElementType == typeof(TypedReference))
			{
				text = text.Substring("System.".Length);
			}
			return text;
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x000379EB File Offset: 0x00035BEB
		public override MemberTypes MemberType
		{
			get
			{
				if (base.IsPublic || base.IsNotPublic)
				{
					return MemberTypes.TypeInfo;
				}
				return MemberTypes.NestedType;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00037A05 File Offset: 0x00035C05
		public override Type ReflectedType
		{
			get
			{
				return this.DeclaringType;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x00037A0D File Offset: 0x00035C0D
		public override int MetadataToken
		{
			[SecuritySafeCritical]
			get
			{
				return RuntimeTypeHandle.GetToken(this);
			}
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00037A18 File Offset: 0x00035C18
		private void CreateInstanceCheckThis()
		{
			if (this is ReflectionOnlyType)
			{
				throw new ArgumentException(Environment.GetResourceString("It is illegal to invoke a method on a Type loaded via ReflectionOnlyGetType."));
			}
			if (this.ContainsGenericParameters)
			{
				throw new ArgumentException(Environment.GetResourceString("Cannot create an instance of {0} because Type.ContainsGenericParameters is true.", new object[]
				{
					this
				}));
			}
			Type rootElementType = base.GetRootElementType();
			if (rootElementType == typeof(ArgIterator))
			{
				throw new NotSupportedException(Environment.GetResourceString("Cannot dynamically create an instance of ArgIterator."));
			}
			if (rootElementType == typeof(void))
			{
				throw new NotSupportedException(Environment.GetResourceString("Cannot dynamically create an instance of System.Void."));
			}
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00037AA0 File Offset: 0x00035CA0
		[SecurityCritical]
		internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark)
		{
			this.CreateInstanceCheckThis();
			object result = null;
			try
			{
				try
				{
					if (activationAttributes != null)
					{
						ActivationServices.PushActivationAttributes(this, activationAttributes);
					}
					if (args == null)
					{
						args = Array.Empty<object>();
					}
					int num = args.Length;
					if (binder == null)
					{
						binder = Type.DefaultBinder;
					}
					bool publicOnly = (bindingAttr & BindingFlags.NonPublic) == BindingFlags.Default;
					bool wrapExceptions = (bindingAttr & BindingFlags.DoNotWrapExceptions) == BindingFlags.Default;
					if (num == 0 && (bindingAttr & BindingFlags.Public) != BindingFlags.Default && (bindingAttr & BindingFlags.Instance) != BindingFlags.Default && (this.IsGenericCOMObjectImpl() || base.IsValueType))
					{
						result = this.CreateInstanceDefaultCtor(publicOnly, false, true, wrapExceptions, ref stackMark);
					}
					else
					{
						ConstructorInfo[] constructors = this.GetConstructors(bindingAttr);
						List<MethodBase> list = new List<MethodBase>(constructors.Length);
						Type[] array = new Type[num];
						for (int i = 0; i < num; i++)
						{
							if (args[i] != null)
							{
								array[i] = args[i].GetType();
							}
						}
						for (int j = 0; j < constructors.Length; j++)
						{
							if (RuntimeType.FilterApplyConstructorInfo((RuntimeConstructorInfo)constructors[j], bindingAttr, CallingConventions.Any, array))
							{
								list.Add(constructors[j]);
							}
						}
						MethodBase[] array2 = new MethodBase[list.Count];
						list.CopyTo(array2);
						if (array2 != null && array2.Length == 0)
						{
							array2 = null;
						}
						if (array2 == null)
						{
							if (activationAttributes != null)
							{
								ActivationServices.PopActivationAttributes(this);
								activationAttributes = null;
							}
							throw new MissingMethodException(Environment.GetResourceString("Constructor on type '{0}' not found.", new object[]
							{
								this.FullName
							}));
						}
						object obj = null;
						MethodBase methodBase;
						try
						{
							methodBase = binder.BindToMethod(bindingAttr, array2, ref args, null, culture, null, out obj);
						}
						catch (MissingMethodException)
						{
							methodBase = null;
						}
						if (methodBase == null)
						{
							if (activationAttributes != null)
							{
								ActivationServices.PopActivationAttributes(this);
								activationAttributes = null;
							}
							throw new MissingMethodException(Environment.GetResourceString("Constructor on type '{0}' not found.", new object[]
							{
								this.FullName
							}));
						}
						if (methodBase.GetParametersNoCopy().Length == 0)
						{
							if (args.Length != 0)
							{
								throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Vararg calling convention not supported."), Array.Empty<object>()));
							}
							if (activationAttributes != null && activationAttributes.Length != 0)
							{
								result = this.ActivationCreateInstance(methodBase, bindingAttr, binder, args, culture, activationAttributes);
							}
							else
							{
								result = Activator.CreateInstance(this, true, wrapExceptions);
							}
						}
						else
						{
							if (activationAttributes != null && activationAttributes.Length != 0)
							{
								result = this.ActivationCreateInstance(methodBase, bindingAttr, binder, args, culture, activationAttributes);
							}
							else
							{
								result = ((ConstructorInfo)methodBase).Invoke(bindingAttr, binder, args, culture);
							}
							if (obj != null)
							{
								binder.ReorderArgumentArray(ref args, obj);
							}
						}
					}
				}
				finally
				{
					if (activationAttributes != null)
					{
						ActivationServices.PopActivationAttributes(this);
						activationAttributes = null;
					}
				}
			}
			catch (Exception)
			{
				throw;
			}
			return result;
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00037D28 File Offset: 0x00035F28
		private object ActivationCreateInstance(MethodBase invokeMethod, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			object obj = ActivationServices.CreateProxyFromAttributes(this, activationAttributes);
			if (obj != null)
			{
				invokeMethod.Invoke(obj, bindingAttr, binder, args, culture);
			}
			return obj;
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00037D50 File Offset: 0x00035F50
		[SecuritySafeCritical]
		[DebuggerStepThrough]
		[DebuggerHidden]
		internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, bool wrapExceptions, ref StackCrawlMark stackMark)
		{
			if (base.GetType() == typeof(ReflectionOnlyType))
			{
				throw new InvalidOperationException(Environment.GetResourceString("The requested operation is invalid in the ReflectionOnly context."));
			}
			return this.CreateInstanceSlow(publicOnly, wrapExceptions, skipCheckThis, fillCache);
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00037D84 File Offset: 0x00035F84
		internal RuntimeConstructorInfo GetDefaultConstructor()
		{
			RuntimeConstructorInfo runtimeConstructorInfo = null;
			if (this.type_info == null)
			{
				this.type_info = new MonoTypeInfo();
			}
			else
			{
				runtimeConstructorInfo = this.type_info.default_ctor;
			}
			if (runtimeConstructorInfo == null)
			{
				ConstructorInfo[] constructors = this.GetConstructors(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				for (int i = 0; i < constructors.Length; i++)
				{
					if (constructors[i].GetParametersCount() == 0)
					{
						runtimeConstructorInfo = (this.type_info.default_ctor = (RuntimeConstructorInfo)constructors[i]);
						break;
					}
				}
			}
			return runtimeConstructorInfo;
		}

		// Token: 0x06000D43 RID: 3395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern MethodInfo GetCorrespondingInflatedMethod(MethodInfo generic);

		// Token: 0x06000D44 RID: 3396
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern ConstructorInfo GetCorrespondingInflatedConstructor(ConstructorInfo generic);

		// Token: 0x06000D45 RID: 3397 RVA: 0x00037DF6 File Offset: 0x00035FF6
		internal override MethodInfo GetMethod(MethodInfo fromNoninstanciated)
		{
			if (fromNoninstanciated == null)
			{
				throw new ArgumentNullException("fromNoninstanciated");
			}
			return this.GetCorrespondingInflatedMethod(fromNoninstanciated);
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00037E13 File Offset: 0x00036013
		internal override ConstructorInfo GetConstructor(ConstructorInfo fromNoninstanciated)
		{
			if (fromNoninstanciated == null)
			{
				throw new ArgumentNullException("fromNoninstanciated");
			}
			return this.GetCorrespondingInflatedConstructor(fromNoninstanciated);
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00037E30 File Offset: 0x00036030
		internal override FieldInfo GetField(FieldInfo fromNoninstanciated)
		{
			BindingFlags bindingFlags = fromNoninstanciated.IsStatic ? BindingFlags.Static : BindingFlags.Instance;
			bindingFlags |= (fromNoninstanciated.IsPublic ? BindingFlags.Public : BindingFlags.NonPublic);
			return this.GetField(fromNoninstanciated.Name, bindingFlags);
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00037E68 File Offset: 0x00036068
		private string GetDefaultMemberName()
		{
			object[] customAttributes = this.GetCustomAttributes(typeof(DefaultMemberAttribute), true);
			if (customAttributes.Length == 0)
			{
				return null;
			}
			return ((DefaultMemberAttribute)customAttributes[0]).MemberName;
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00037E9C File Offset: 0x0003609C
		internal RuntimeConstructorInfo GetSerializationCtor()
		{
			if (this.m_serializationCtor == null)
			{
				Type[] types = new Type[]
				{
					typeof(SerializationInfo),
					typeof(StreamingContext)
				};
				this.m_serializationCtor = (base.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, CallingConventions.Any, types, null) as RuntimeConstructorInfo);
			}
			return this.m_serializationCtor;
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00037EF5 File Offset: 0x000360F5
		internal object CreateInstanceSlow(bool publicOnly, bool wrapExceptions, bool skipCheckThis, bool fillCache)
		{
			if (!skipCheckThis)
			{
				this.CreateInstanceCheckThis();
			}
			return this.CreateInstanceMono(!publicOnly, wrapExceptions);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00037F0C File Offset: 0x0003610C
		private object CreateInstanceMono(bool nonPublic, bool wrapExceptions)
		{
			RuntimeConstructorInfo runtimeConstructorInfo = this.GetDefaultConstructor();
			if (!nonPublic && runtimeConstructorInfo != null && !runtimeConstructorInfo.IsPublic)
			{
				runtimeConstructorInfo = null;
			}
			if (runtimeConstructorInfo == null)
			{
				Type rootElementType = base.GetRootElementType();
				if (rootElementType == typeof(TypedReference) || rootElementType == typeof(RuntimeArgumentHandle))
				{
					throw new NotSupportedException(Environment.GetResourceString("Cannot create boxed TypedReference, ArgIterator, or RuntimeArgumentHandle Objects."));
				}
				if (base.IsValueType)
				{
					return RuntimeType.CreateInstanceInternal(this);
				}
				throw new MissingMethodException("Default constructor not found for type " + this.FullName);
			}
			else
			{
				if (base.IsAbstract)
				{
					throw new MissingMethodException("Cannot create an abstract class '{0}'.", this.FullName);
				}
				return runtimeConstructorInfo.InternalInvoke(null, null, wrapExceptions);
			}
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00037FB8 File Offset: 0x000361B8
		internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr)
		{
			bool flag = false;
			object result = this.TryConvertToType(value, ref flag);
			if (!flag)
			{
				return result;
			}
			if ((invokeAttr & BindingFlags.ExactBinding) == BindingFlags.ExactBinding)
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentUICulture, Environment.GetResourceString("Object of type '{0}' cannot be converted to type '{1}'."), value.GetType(), this));
			}
			if (binder != null && binder != Type.DefaultBinder)
			{
				return binder.ChangeType(value, this, culture);
			}
			throw new ArgumentException(string.Format(CultureInfo.CurrentUICulture, Environment.GetResourceString("Object of type '{0}' cannot be converted to type '{1}'."), value.GetType(), this));
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x0003803C File Offset: 0x0003623C
		private object TryConvertToType(object value, ref bool failed)
		{
			if (this.IsInstanceOfType(value))
			{
				return value;
			}
			if (base.IsByRef)
			{
				Type elementType = this.GetElementType();
				if (value == null || elementType.IsInstanceOfType(value))
				{
					return value;
				}
			}
			if (value == null)
			{
				return value;
			}
			if (this.IsEnum)
			{
				if (Enum.GetUnderlyingType(this) == value.GetType())
				{
					return value;
				}
				object obj = RuntimeType.IsConvertibleToPrimitiveType(value, this);
				if (obj != null)
				{
					return obj;
				}
			}
			else if (base.IsPrimitive)
			{
				object obj2 = RuntimeType.IsConvertibleToPrimitiveType(value, this);
				if (obj2 != null)
				{
					return obj2;
				}
			}
			else if (base.IsPointer)
			{
				Type type = value.GetType();
				if (type == typeof(IntPtr) || type == typeof(UIntPtr))
				{
					return value;
				}
			}
			failed = true;
			return null;
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x000380F0 File Offset: 0x000362F0
		private static object IsConvertibleToPrimitiveType(object value, Type targetType)
		{
			Type type = value.GetType();
			if (type.IsEnum)
			{
				type = Enum.GetUnderlyingType(type);
				if (type == targetType)
				{
					return value;
				}
			}
			TypeCode typeCode = Type.GetTypeCode(type);
			switch (Type.GetTypeCode(targetType))
			{
			case TypeCode.Char:
				if (typeCode == TypeCode.Byte)
				{
					return (char)((byte)value);
				}
				if (typeCode == TypeCode.UInt16)
				{
					return value;
				}
				break;
			case TypeCode.Int16:
				if (typeCode == TypeCode.SByte)
				{
					return (short)((sbyte)value);
				}
				if (typeCode == TypeCode.Byte)
				{
					return (short)((byte)value);
				}
				break;
			case TypeCode.UInt16:
				if (typeCode == TypeCode.Char)
				{
					return value;
				}
				if (typeCode == TypeCode.Byte)
				{
					return (ushort)((byte)value);
				}
				break;
			case TypeCode.Int32:
				switch (typeCode)
				{
				case TypeCode.Char:
					return (int)((char)value);
				case TypeCode.SByte:
					return (int)((sbyte)value);
				case TypeCode.Byte:
					return (int)((byte)value);
				case TypeCode.Int16:
					return (int)((short)value);
				case TypeCode.UInt16:
					return (int)((ushort)value);
				}
				break;
			case TypeCode.UInt32:
				switch (typeCode)
				{
				case TypeCode.Char:
					return (uint)((char)value);
				case TypeCode.Byte:
					return (uint)((byte)value);
				case TypeCode.UInt16:
					return (uint)((ushort)value);
				}
				break;
			case TypeCode.Int64:
				switch (typeCode)
				{
				case TypeCode.Char:
					return (long)((ulong)((char)value));
				case TypeCode.SByte:
					return (long)((sbyte)value);
				case TypeCode.Byte:
					return (long)((ulong)((byte)value));
				case TypeCode.Int16:
					return (long)((short)value);
				case TypeCode.UInt16:
					return (long)((ulong)((ushort)value));
				case TypeCode.Int32:
					return (long)((int)value);
				case TypeCode.UInt32:
					return (long)((ulong)((uint)value));
				}
				break;
			case TypeCode.UInt64:
				switch (typeCode)
				{
				case TypeCode.Char:
					return (ulong)((char)value);
				case TypeCode.Byte:
					return (ulong)((byte)value);
				case TypeCode.UInt16:
					return (ulong)((ushort)value);
				case TypeCode.UInt32:
					return (ulong)((uint)value);
				}
				break;
			case TypeCode.Single:
				switch (typeCode)
				{
				case TypeCode.Char:
					return (float)((char)value);
				case TypeCode.SByte:
					return (float)((sbyte)value);
				case TypeCode.Byte:
					return (float)((byte)value);
				case TypeCode.Int16:
					return (float)((short)value);
				case TypeCode.UInt16:
					return (float)((ushort)value);
				case TypeCode.Int32:
					return (float)((int)value);
				case TypeCode.UInt32:
					return (uint)value;
				case TypeCode.Int64:
					return (float)((long)value);
				case TypeCode.UInt64:
					return (ulong)value;
				}
				break;
			case TypeCode.Double:
				switch (typeCode)
				{
				case TypeCode.Char:
					return (double)((char)value);
				case TypeCode.SByte:
					return (double)((sbyte)value);
				case TypeCode.Byte:
					return (double)((byte)value);
				case TypeCode.Int16:
					return (double)((short)value);
				case TypeCode.UInt16:
					return (double)((ushort)value);
				case TypeCode.Int32:
					return (double)((int)value);
				case TypeCode.UInt32:
					return (uint)value;
				case TypeCode.Int64:
					return (double)((long)value);
				case TypeCode.UInt64:
					return (ulong)value;
				case TypeCode.Single:
					return (double)((float)value);
				}
				break;
			}
			return null;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x000384A1 File Offset: 0x000366A1
		private string GetCachedName(TypeNameKind kind)
		{
			if (kind == TypeNameKind.SerializationName)
			{
				return this.ToString();
			}
			throw new NotImplementedException();
		}

		// Token: 0x06000D50 RID: 3408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Type make_array_type(int rank);

		// Token: 0x06000D51 RID: 3409 RVA: 0x000384B3 File Offset: 0x000366B3
		public override Type MakeArrayType()
		{
			return this.make_array_type(0);
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x000384BC File Offset: 0x000366BC
		public override Type MakeArrayType(int rank)
		{
			if (rank < 1 || rank > 255)
			{
				throw new IndexOutOfRangeException();
			}
			return this.make_array_type(rank);
		}

		// Token: 0x06000D53 RID: 3411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Type make_byref_type();

		// Token: 0x06000D54 RID: 3412 RVA: 0x000384D7 File Offset: 0x000366D7
		public override Type MakeByRefType()
		{
			if (base.IsByRef)
			{
				throw new TypeLoadException("Can not call MakeByRefType on a ByRef type");
			}
			return this.make_byref_type();
		}

		// Token: 0x06000D55 RID: 3413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Type MakePointerType(Type type);

		// Token: 0x06000D56 RID: 3414 RVA: 0x000384F2 File Offset: 0x000366F2
		public override Type MakePointerType()
		{
			if (base.IsByRef)
			{
				throw new TypeLoadException(string.Format("Could not load type '{0}' from assembly '{1}", base.GetType(), this.AssemblyQualifiedName));
			}
			return RuntimeType.MakePointerType(this);
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x00038520 File Offset: 0x00036720
		public override bool ContainsGenericParameters
		{
			get
			{
				if (this.IsGenericParameter)
				{
					return true;
				}
				if (this.IsGenericType)
				{
					Type[] genericArguments = this.GetGenericArguments();
					for (int i = 0; i < genericArguments.Length; i++)
					{
						if (genericArguments[i].ContainsGenericParameters)
						{
							return true;
						}
					}
				}
				return base.HasElementType && this.GetElementType().ContainsGenericParameters;
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00038578 File Offset: 0x00036778
		public override Type[] GetGenericParameterConstraints()
		{
			if (!this.IsGenericParameter)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Method may only be called on a Type for which Type.IsGenericParameter is true."));
			}
			RuntimeGenericParamInfoHandle runtimeGenericParamInfoHandle = new RuntimeGenericParamInfoHandle(RuntimeTypeHandle.GetGenericParameterInfo(this));
			Type[] array = runtimeGenericParamInfoHandle.Constraints;
			if (array == null)
			{
				array = EmptyArray<Type>.Value;
			}
			return array;
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x000385BC File Offset: 0x000367BC
		internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument)
		{
			return ((RuntimeType)RuntimeType.MakeGenericType(genericType, new Type[]
			{
				genericArgument
			})).GetDefaultConstructor().InternalInvoke(null, null, true);
		}

		// Token: 0x06000D5A RID: 3418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Type MakeGenericType(Type gt, Type[] types);

		// Token: 0x06000D5B RID: 3419
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, RuntimeType.MemberListType listType);

		// Token: 0x06000D5C RID: 3420 RVA: 0x000385E0 File Offset: 0x000367E0
		internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			RuntimeTypeHandle reflectedType2 = new RuntimeTypeHandle(reflectedType);
			RuntimeMethodInfo[] result;
			using (SafeStringMarshal safeStringMarshal = new SafeStringMarshal(name))
			{
				using (SafeGPtrArrayHandle safeGPtrArrayHandle = new SafeGPtrArrayHandle(this.GetMethodsByName_native(safeStringMarshal.Value, bindingAttr, listType)))
				{
					int length = safeGPtrArrayHandle.Length;
					RuntimeMethodInfo[] array = new RuntimeMethodInfo[length];
					for (int i = 0; i < length; i++)
					{
						RuntimeMethodHandle handle = new RuntimeMethodHandle(safeGPtrArrayHandle[i]);
						array[i] = (RuntimeMethodInfo)RuntimeMethodInfo.GetMethodFromHandleNoGenericCheck(handle, reflectedType2);
					}
					result = array;
				}
			}
			return result;
		}

		// Token: 0x06000D5D RID: 3421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType);

		// Token: 0x06000D5E RID: 3422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern IntPtr GetConstructors_native(BindingFlags bindingAttr);

		// Token: 0x06000D5F RID: 3423 RVA: 0x00038698 File Offset: 0x00036898
		private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType)
		{
			RuntimeTypeHandle reflectedType2 = new RuntimeTypeHandle(reflectedType);
			RuntimeConstructorInfo[] result;
			using (SafeGPtrArrayHandle safeGPtrArrayHandle = new SafeGPtrArrayHandle(this.GetConstructors_native(bindingAttr)))
			{
				int length = safeGPtrArrayHandle.Length;
				RuntimeConstructorInfo[] array = new RuntimeConstructorInfo[length];
				for (int i = 0; i < length; i++)
				{
					RuntimeMethodHandle handle = new RuntimeMethodHandle(safeGPtrArrayHandle[i]);
					array[i] = (RuntimeConstructorInfo)RuntimeMethodInfo.GetMethodFromHandleNoGenericCheck(handle, reflectedType2);
				}
				result = array;
			}
			return result;
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00038720 File Offset: 0x00036920
		private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			RuntimeTypeHandle reflectedType2 = new RuntimeTypeHandle(reflectedType);
			RuntimePropertyInfo[] result;
			using (SafeStringMarshal safeStringMarshal = new SafeStringMarshal(name))
			{
				using (SafeGPtrArrayHandle safeGPtrArrayHandle = new SafeGPtrArrayHandle(this.GetPropertiesByName_native(safeStringMarshal.Value, bindingAttr, listType)))
				{
					int length = safeGPtrArrayHandle.Length;
					RuntimePropertyInfo[] array = new RuntimePropertyInfo[length];
					for (int i = 0; i < length; i++)
					{
						RuntimePropertyHandle handle = new RuntimePropertyHandle(safeGPtrArrayHandle[i]);
						array[i] = (RuntimePropertyInfo)RuntimePropertyInfo.GetPropertyFromHandle(handle, reflectedType2);
					}
					result = array;
				}
			}
			return result;
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x000387D8 File Offset: 0x000369D8
		public override Guid GUID
		{
			get
			{
				object[] customAttributes = this.GetCustomAttributes(typeof(GuidAttribute), true);
				if (customAttributes.Length == 0)
				{
					return Guid.Empty;
				}
				return new Guid(((GuidAttribute)customAttributes[0]).Value);
			}
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00038813 File Offset: 0x00036A13
		protected override TypeCode GetTypeCodeImpl()
		{
			return RuntimeType.GetTypeCodeImplInternal(this);
		}

		// Token: 0x06000D63 RID: 3427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TypeCode GetTypeCodeImplInternal(Type type);

		// Token: 0x06000D64 RID: 3428 RVA: 0x0003881B File Offset: 0x00036A1B
		public override string ToString()
		{
			return this.getFullName(false, false);
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		private bool IsGenericCOMObjectImpl()
		{
			return false;
		}

		// Token: 0x06000D66 RID: 3430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern object CreateInstanceInternal(Type type);

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000D67 RID: 3431
		public override extern MethodBase DeclaringMethod { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000D68 RID: 3432
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern string getFullName(bool full_name, bool assembly_qualified);

		// Token: 0x06000D69 RID: 3433
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Type[] GetGenericArgumentsInternal(bool runtimeArray);

		// Token: 0x06000D6A RID: 3434 RVA: 0x00038828 File Offset: 0x00036A28
		private GenericParameterAttributes GetGenericParameterAttributes()
		{
			return new RuntimeGenericParamInfoHandle(RuntimeTypeHandle.GetGenericParameterInfo(this)).Attributes;
		}

		// Token: 0x06000D6B RID: 3435
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int GetGenericParameterPosition();

		// Token: 0x06000D6C RID: 3436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern IntPtr GetEvents_native(IntPtr name, RuntimeType.MemberListType listType);

		// Token: 0x06000D6D RID: 3437
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType);

		// Token: 0x06000D6E RID: 3438 RVA: 0x00038848 File Offset: 0x00036A48
		private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			RuntimeTypeHandle declaringType = new RuntimeTypeHandle(reflectedType);
			RuntimeFieldInfo[] result;
			using (SafeStringMarshal safeStringMarshal = new SafeStringMarshal(name))
			{
				using (SafeGPtrArrayHandle safeGPtrArrayHandle = new SafeGPtrArrayHandle(this.GetFields_native(safeStringMarshal.Value, bindingAttr, listType)))
				{
					int length = safeGPtrArrayHandle.Length;
					RuntimeFieldInfo[] array = new RuntimeFieldInfo[length];
					for (int i = 0; i < length; i++)
					{
						RuntimeFieldHandle handle = new RuntimeFieldHandle(safeGPtrArrayHandle[i]);
						array[i] = (RuntimeFieldInfo)FieldInfo.GetFieldFromHandle(handle, declaringType);
					}
					result = array;
				}
			}
			return result;
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00038900 File Offset: 0x00036B00
		private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			RuntimeTypeHandle reflectedType2 = new RuntimeTypeHandle(reflectedType);
			RuntimeEventInfo[] result;
			using (SafeStringMarshal safeStringMarshal = new SafeStringMarshal(name))
			{
				using (SafeGPtrArrayHandle safeGPtrArrayHandle = new SafeGPtrArrayHandle(this.GetEvents_native(safeStringMarshal.Value, listType)))
				{
					int length = safeGPtrArrayHandle.Length;
					RuntimeEventInfo[] array = new RuntimeEventInfo[length];
					for (int i = 0; i < length; i++)
					{
						RuntimeEventHandle handle = new RuntimeEventHandle(safeGPtrArrayHandle[i]);
						array[i] = (RuntimeEventInfo)EventInfo.GetEventFromHandle(handle, reflectedType2);
					}
					result = array;
				}
			}
			return result;
		}

		// Token: 0x06000D70 RID: 3440
		[MethodImpl(MethodImplOptions.InternalCall)]
		public override extern Type[] GetInterfaces();

		// Token: 0x06000D71 RID: 3441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType);

		// Token: 0x06000D72 RID: 3442 RVA: 0x000389B8 File Offset: 0x00036BB8
		private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr, RuntimeType.MemberListType listType)
		{
			string str = null;
			if (displayName != null)
			{
				str = TypeIdentifiers.FromDisplay(displayName).InternalName;
			}
			RuntimeType[] result;
			using (SafeStringMarshal safeStringMarshal = new SafeStringMarshal(str))
			{
				using (SafeGPtrArrayHandle safeGPtrArrayHandle = new SafeGPtrArrayHandle(this.GetNestedTypes_native(safeStringMarshal.Value, bindingAttr, listType)))
				{
					int length = safeGPtrArrayHandle.Length;
					RuntimeType[] array = new RuntimeType[length];
					for (int i = 0; i < length; i++)
					{
						RuntimeTypeHandle handle = new RuntimeTypeHandle(safeGPtrArrayHandle[i]);
						array[i] = (RuntimeType)Type.GetTypeFromHandle(handle);
					}
					result = array;
				}
			}
			return result;
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x00038A78 File Offset: 0x00036C78
		public override string AssemblyQualifiedName
		{
			get
			{
				return this.getFullName(true, true);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000D74 RID: 3444
		public override extern Type DeclaringType { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000D75 RID: 3445
		public override extern string Name { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000D76 RID: 3446
		public override extern string Namespace { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000D77 RID: 3447 RVA: 0x00038A84 File Offset: 0x00036C84
		public override int GetHashCode()
		{
			Type underlyingSystemType = this.UnderlyingSystemType;
			if (underlyingSystemType != null && underlyingSystemType != this)
			{
				return underlyingSystemType.GetHashCode();
			}
			return (int)this._impl.Value;
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x00038AC4 File Offset: 0x00036CC4
		public override string FullName
		{
			get
			{
				if (this.ContainsGenericParameters && !base.GetRootElementType().IsGenericTypeDefinition)
				{
					return null;
				}
				if (this.type_info == null)
				{
					this.type_info = new MonoTypeInfo();
				}
				string result;
				if ((result = this.type_info.full_name) == null)
				{
					result = (this.type_info.full_name = this.getFullName(true, false));
				}
				return result;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x00038B22 File Offset: 0x00036D22
		public override bool IsSZArray
		{
			get
			{
				return base.IsArray && this == this.GetElementType().MakeArrayType();
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		internal override bool IsUserType
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00038B3C File Offset: 0x00036D3C
		[ComVisible(true)]
		public override bool IsSubclassOf(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			RuntimeType runtimeType = type as RuntimeType;
			return !(runtimeType == null) && RuntimeTypeHandle.IsSubclassOf(this, runtimeType);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00038B70 File Offset: 0x00036D70
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers)
		{
			return this.GetMethodImplCommon(name, -1, bindingAttr, binder, callConv, types, modifiers);
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00038B84 File Offset: 0x00036D84
		private MethodInfo GetMethodImplCommon(string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers)
		{
			RuntimeType.ListBuilder<MethodInfo> methodCandidates = this.GetMethodCandidates(name, genericParameterCount, bindingAttr, callConv, types, false);
			if (methodCandidates.Count == 0)
			{
				return null;
			}
			MethodBase[] match;
			if (types == null || types.Length == 0)
			{
				MethodInfo methodInfo = methodCandidates[0];
				if (methodCandidates.Count == 1)
				{
					return methodInfo;
				}
				if (types == null)
				{
					for (int i = 1; i < methodCandidates.Count; i++)
					{
						if (!System.DefaultBinder.CompareMethodSig(methodCandidates[i], methodInfo))
						{
							throw new AmbiguousMatchException("Ambiguous match found.");
						}
					}
					match = methodCandidates.ToArray();
					return System.DefaultBinder.FindMostDerivedNewSlotMeth(match, methodCandidates.Count) as MethodInfo;
				}
			}
			if (binder == null)
			{
				binder = Type.DefaultBinder;
			}
			Binder binder2 = binder;
			match = methodCandidates.ToArray();
			return binder2.SelectMethod(bindingAttr, match, types, modifiers) as MethodInfo;
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00038C3C File Offset: 0x00036E3C
		private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, int genericParameterCount, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup)
		{
			bool flag;
			bool ignoreCase;
			RuntimeType.MemberListType listType;
			RuntimeType.FilterHelper(bindingAttr, ref name, allowPrefixLookup, out flag, out ignoreCase, out listType);
			RuntimeMethodInfo[] methodsByName = this.GetMethodsByName(name, bindingAttr, listType, this);
			RuntimeType.ListBuilder<MethodInfo> result = new RuntimeType.ListBuilder<MethodInfo>(methodsByName.Length);
			foreach (RuntimeMethodInfo runtimeMethodInfo in methodsByName)
			{
				if ((genericParameterCount == -1 || genericParameterCount == runtimeMethodInfo.GenericParameterCount) && RuntimeType.FilterApplyMethodInfo(runtimeMethodInfo, bindingAttr, callConv, types) && (!flag || RuntimeType.FilterApplyPrefixLookup(runtimeMethodInfo, name, ignoreCase)))
				{
					result.Add(runtimeMethodInfo);
				}
			}
			return result;
		}

		// Token: 0x0400044B RID: 1099
		internal static readonly RuntimeType ValueType = (RuntimeType)typeof(ValueType);

		// Token: 0x0400044C RID: 1100
		internal static readonly RuntimeType EnumType = (RuntimeType)typeof(Enum);

		// Token: 0x0400044D RID: 1101
		private static readonly RuntimeType ObjectType = (RuntimeType)typeof(object);

		// Token: 0x0400044E RID: 1102
		private static readonly RuntimeType StringType = (RuntimeType)typeof(string);

		// Token: 0x0400044F RID: 1103
		private static readonly RuntimeType DelegateType = (RuntimeType)typeof(Delegate);

		// Token: 0x04000450 RID: 1104
		private static Type[] s_SICtorParamTypes;

		// Token: 0x04000451 RID: 1105
		private const BindingFlags MemberBindingMask = (BindingFlags)255;

		// Token: 0x04000452 RID: 1106
		private const BindingFlags InvocationMask = BindingFlags.InvokeMethod | BindingFlags.CreateInstance | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty;

		// Token: 0x04000453 RID: 1107
		private const BindingFlags BinderNonCreateInstance = BindingFlags.InvokeMethod | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty;

		// Token: 0x04000454 RID: 1108
		private const BindingFlags BinderGetSetProperty = BindingFlags.GetProperty | BindingFlags.SetProperty;

		// Token: 0x04000455 RID: 1109
		private const BindingFlags BinderSetInvokeProperty = BindingFlags.InvokeMethod | BindingFlags.SetProperty;

		// Token: 0x04000456 RID: 1110
		private const BindingFlags BinderGetSetField = BindingFlags.GetField | BindingFlags.SetField;

		// Token: 0x04000457 RID: 1111
		private const BindingFlags BinderSetInvokeField = BindingFlags.InvokeMethod | BindingFlags.SetField;

		// Token: 0x04000458 RID: 1112
		private const BindingFlags BinderNonFieldGetSet = (BindingFlags)16773888;

		// Token: 0x04000459 RID: 1113
		private const BindingFlags ClassicBindingMask = BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty;

		// Token: 0x0400045A RID: 1114
		private static RuntimeType s_typedRef = (RuntimeType)typeof(TypedReference);

		// Token: 0x0400045B RID: 1115
		[NonSerialized]
		private MonoTypeInfo type_info;

		// Token: 0x0400045C RID: 1116
		internal object GenericCache;

		// Token: 0x0400045D RID: 1117
		private RuntimeConstructorInfo m_serializationCtor;

		// Token: 0x0400045E RID: 1118
		private static Dictionary<Guid, Type> clsid_types;

		// Token: 0x0400045F RID: 1119
		private static AssemblyBuilder clsid_assemblybuilder;

		// Token: 0x04000460 RID: 1120
		private const int GenericParameterCountAny = -1;

		// Token: 0x02000150 RID: 336
		internal enum MemberListType
		{
			// Token: 0x04000462 RID: 1122
			All,
			// Token: 0x04000463 RID: 1123
			CaseSensitive,
			// Token: 0x04000464 RID: 1124
			CaseInsensitive,
			// Token: 0x04000465 RID: 1125
			HandleToInfo
		}

		// Token: 0x02000151 RID: 337
		private struct ListBuilder<T> where T : class
		{
			// Token: 0x06000D80 RID: 3456 RVA: 0x00038D41 File Offset: 0x00036F41
			public ListBuilder(int capacity)
			{
				this._items = null;
				this._item = default(T);
				this._count = 0;
				this._capacity = capacity;
			}

			// Token: 0x17000123 RID: 291
			public T this[int index]
			{
				get
				{
					if (this._items == null)
					{
						return this._item;
					}
					return this._items[index];
				}
			}

			// Token: 0x06000D82 RID: 3458 RVA: 0x00038D84 File Offset: 0x00036F84
			public T[] ToArray()
			{
				if (this._count == 0)
				{
					return Array.Empty<T>();
				}
				if (this._count == 1)
				{
					return new T[]
					{
						this._item
					};
				}
				Array.Resize<T>(ref this._items, this._count);
				this._capacity = this._count;
				return this._items;
			}

			// Token: 0x06000D83 RID: 3459 RVA: 0x00038DDF File Offset: 0x00036FDF
			public void CopyTo(object[] array, int index)
			{
				if (this._count == 0)
				{
					return;
				}
				if (this._count == 1)
				{
					array[index] = this._item;
					return;
				}
				Array.Copy(this._items, 0, array, index, this._count);
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00038E16 File Offset: 0x00037016
			public int Count
			{
				get
				{
					return this._count;
				}
			}

			// Token: 0x06000D85 RID: 3461 RVA: 0x00038E20 File Offset: 0x00037020
			public void Add(T item)
			{
				if (this._count == 0)
				{
					this._item = item;
				}
				else
				{
					if (this._count == 1)
					{
						if (this._capacity < 2)
						{
							this._capacity = 4;
						}
						this._items = new T[this._capacity];
						this._items[0] = this._item;
					}
					else if (this._capacity == this._count)
					{
						int num = 2 * this._capacity;
						Array.Resize<T>(ref this._items, num);
						this._capacity = num;
					}
					this._items[this._count] = item;
				}
				this._count++;
			}

			// Token: 0x04000466 RID: 1126
			private T[] _items;

			// Token: 0x04000467 RID: 1127
			private T _item;

			// Token: 0x04000468 RID: 1128
			private int _count;

			// Token: 0x04000469 RID: 1129
			private int _capacity;
		}
	}
}
