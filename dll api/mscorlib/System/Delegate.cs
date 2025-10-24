﻿using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Represents a delegate, which is a data structure that refers to a static method or to a class instance and an instance method of that class.</summary>
	// Token: 0x0200016D RID: 365
	[Serializable]
	[StructLayout(0)]
	public abstract class Delegate : ICloneable, ISerializable
	{
		/// <summary>Gets the method represented by the delegate.</summary>
		/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> describing the method represented by the delegate.</returns>
		/// <exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private). </exception>
		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x0003D438 File Offset: 0x0003B638
		public MethodInfo Method
		{
			get
			{
				return this.GetMethodImpl();
			}
		}

		// Token: 0x06000E88 RID: 3720
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern MethodInfo GetVirtualMethod_internal();

		/// <summary>Gets the class instance on which the current delegate invokes the instance method.</summary>
		/// <returns>The object on which the current delegate invokes the instance method, if the delegate represents an instance method; <see langword="null" /> if the delegate represents a static method.</returns>
		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x0003D440 File Offset: 0x0003B640
		public object Target
		{
			get
			{
				return this.m_target;
			}
		}

		// Token: 0x06000E8A RID: 3722
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure);

		// Token: 0x06000E8B RID: 3723 RVA: 0x0003D448 File Offset: 0x0003B648
		private static bool arg_type_match(Type delArgType, Type argType)
		{
			bool flag = delArgType == argType;
			if (!flag && !argType.IsValueType && argType.IsAssignableFrom(delArgType))
			{
				flag = true;
			}
			if (!flag)
			{
				if (delArgType.IsEnum && Enum.GetUnderlyingType(delArgType) == argType)
				{
					flag = true;
				}
				else if (argType.IsEnum && Enum.GetUnderlyingType(argType) == delArgType)
				{
					flag = true;
				}
			}
			return flag;
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0003D4AC File Offset: 0x0003B6AC
		private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis)
		{
			bool result;
			if (argType.IsValueType)
			{
				result = ((delArgType.IsByRef && delArgType.GetElementType() == argType) || (boxedThis && delArgType == argType));
			}
			else
			{
				result = (delArgType == argType || argType.IsAssignableFrom(delArgType));
			}
			return result;
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x0003D500 File Offset: 0x0003B700
		private static bool return_type_match(Type delReturnType, Type returnType)
		{
			bool flag = returnType == delReturnType;
			if (!flag && !returnType.IsValueType && delReturnType.IsAssignableFrom(returnType))
			{
				flag = true;
			}
			return flag;
		}

		/// <summary>Creates a delegate of the specified type that represents the specified static or instance method, with the specified first argument and the specified behavior on failure to bind.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> representing the type of delegate to create. </param>
		/// <param name="firstArgument">An <see cref="T:System.Object" /> that is the first argument of the method the delegate represents. For instance methods, it must be compatible with the instance type. </param>
		/// <param name="method">The <see cref="T:System.Reflection.MethodInfo" /> describing the static or instance method the delegate is to represent.</param>
		/// <param name="throwOnBindFailure">
		///       <see langword="true" /> to throw an exception if <paramref name="method" /> cannot be bound; otherwise, <see langword="false" />.</param>
		/// <returns>A delegate of the specified type that represents the specified static or instance method, or <see langword="null" /> if <paramref name="throwOnBindFailure" /> is <see langword="false" /> and the delegate cannot be bound to <paramref name="method" />. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />.-or- 
		///         <paramref name="method" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or-
		///         <paramref name="type" /> is not a <see langword="RuntimeType" />. See Runtime Types in Reflection. -or-
		///         <paramref name="method" /> cannot be bound, and <paramref name="throwOnBindFailure" /> is <see langword="true" />.-or-
		///         <paramref name="method" /> is not a <see langword="RuntimeMethodInfo" />. See Runtime Types in Reflection.</exception>
		/// <exception cref="T:System.MissingMethodException">The <see langword="Invoke" /> method of <paramref name="type" /> is not found. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception>
		// Token: 0x06000E8E RID: 3726 RVA: 0x0003D52C File Offset: 0x0003B72C
		public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure)
		{
			return Delegate.CreateDelegate(type, firstArgument, method, throwOnBindFailure, true);
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0003D538 File Offset: 0x0003B738
		private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (method == null)
			{
				throw new ArgumentNullException("method");
			}
			if (!type.IsSubclassOf(typeof(MulticastDelegate)))
			{
				throw new ArgumentException("type is not a subclass of Multicastdelegate");
			}
			MethodInfo methodInfo = type.GetMethod("Invoke");
			if (!Delegate.return_type_match(methodInfo.ReturnType, method.ReturnType))
			{
				if (throwOnBindFailure)
				{
					throw new ArgumentException("method return type is incompatible");
				}
				return null;
			}
			else
			{
				ParameterInfo[] parametersInternal = methodInfo.GetParametersInternal();
				ParameterInfo[] parametersInternal2 = method.GetParametersInternal();
				bool flag;
				if (firstArgument != null)
				{
					if (!method.IsStatic)
					{
						flag = (parametersInternal2.Length == parametersInternal.Length);
					}
					else
					{
						flag = (parametersInternal2.Length == parametersInternal.Length + 1);
					}
				}
				else if (!method.IsStatic)
				{
					flag = (parametersInternal2.Length + 1 == parametersInternal.Length);
					if (!flag)
					{
						flag = (parametersInternal2.Length == parametersInternal.Length);
					}
				}
				else
				{
					flag = (parametersInternal2.Length == parametersInternal.Length);
					if (!flag)
					{
						flag = (parametersInternal2.Length == parametersInternal.Length + 1);
					}
				}
				if (!flag)
				{
					if (throwOnBindFailure)
					{
						throw new TargetParameterCountException("Parameter count mismatch.");
					}
					return null;
				}
				else
				{
					DelegateData delegateData = new DelegateData();
					bool flag2;
					if (firstArgument != null)
					{
						if (!method.IsStatic)
						{
							flag2 = Delegate.arg_type_match_this(firstArgument.GetType(), method.DeclaringType, true);
							for (int i = 0; i < parametersInternal2.Length; i++)
							{
								flag2 &= Delegate.arg_type_match(parametersInternal[i].ParameterType, parametersInternal2[i].ParameterType);
							}
						}
						else
						{
							flag2 = Delegate.arg_type_match(firstArgument.GetType(), parametersInternal2[0].ParameterType);
							for (int j = 1; j < parametersInternal2.Length; j++)
							{
								flag2 &= Delegate.arg_type_match(parametersInternal[j - 1].ParameterType, parametersInternal2[j].ParameterType);
							}
							delegateData.curried_first_arg = true;
						}
					}
					else if (!method.IsStatic)
					{
						if (parametersInternal2.Length + 1 == parametersInternal.Length)
						{
							flag2 = Delegate.arg_type_match_this(parametersInternal[0].ParameterType, method.DeclaringType, false);
							for (int k = 0; k < parametersInternal2.Length; k++)
							{
								flag2 &= Delegate.arg_type_match(parametersInternal[k + 1].ParameterType, parametersInternal2[k].ParameterType);
							}
						}
						else
						{
							flag2 = allowClosed;
							for (int l = 0; l < parametersInternal2.Length; l++)
							{
								flag2 &= Delegate.arg_type_match(parametersInternal[l].ParameterType, parametersInternal2[l].ParameterType);
							}
						}
					}
					else if (parametersInternal.Length + 1 == parametersInternal2.Length)
					{
						flag2 = (!parametersInternal2[0].ParameterType.IsValueType && !parametersInternal2[0].ParameterType.IsByRef && allowClosed);
						for (int m = 0; m < parametersInternal.Length; m++)
						{
							flag2 &= Delegate.arg_type_match(parametersInternal[m].ParameterType, parametersInternal2[m + 1].ParameterType);
						}
						delegateData.curried_first_arg = true;
					}
					else
					{
						flag2 = true;
						for (int n = 0; n < parametersInternal2.Length; n++)
						{
							flag2 &= Delegate.arg_type_match(parametersInternal[n].ParameterType, parametersInternal2[n].ParameterType);
						}
					}
					if (flag2)
					{
						Delegate @delegate = Delegate.CreateDelegate_internal(type, firstArgument, method, throwOnBindFailure);
						if (@delegate != null)
						{
							@delegate.original_method_info = method;
						}
						if (delegateData != null)
						{
							@delegate.data = delegateData;
						}
						return @delegate;
					}
					if (throwOnBindFailure)
					{
						throw new ArgumentException("method arguments are incompatible");
					}
					return null;
				}
			}
		}

		/// <summary>Creates a delegate of the specified type that represents the specified static or instance method, with the specified first argument.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of delegate to create. </param>
		/// <param name="firstArgument">The object to which the delegate is bound, or <see langword="null" /> to treat <paramref name="method" /> as <see langword="static" /> (<see langword="Shared" /> in Visual Basic). </param>
		/// <param name="method">The <see cref="T:System.Reflection.MethodInfo" /> describing the static or instance method the delegate is to represent.</param>
		/// <returns>A delegate of the specified type that represents the specified static or instance method. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />.-or- 
		///         <paramref name="method" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or-
		///         <paramref name="type" /> is not a <see langword="RuntimeType" />. See Runtime Types in Reflection. -or-
		///         <paramref name="method" /> cannot be bound.-or-
		///         <paramref name="method" /> is not a <see langword="RuntimeMethodInfo" />. See Runtime Types in Reflection.</exception>
		/// <exception cref="T:System.MissingMethodException">The <see langword="Invoke" /> method of <paramref name="type" /> is not found. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception>
		// Token: 0x06000E90 RID: 3728 RVA: 0x0003D85B File Offset: 0x0003BA5B
		public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method)
		{
			return Delegate.CreateDelegate(type, firstArgument, method, true, true);
		}

		/// <summary>Creates a delegate of the specified type to represent the specified static method, with the specified behavior on failure to bind.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of delegate to create. </param>
		/// <param name="method">The <see cref="T:System.Reflection.MethodInfo" /> describing the static or instance method the delegate is to represent.</param>
		/// <param name="throwOnBindFailure">
		///       <see langword="true" /> to throw an exception if <paramref name="method" /> cannot be bound; otherwise, <see langword="false" />.</param>
		/// <returns>A delegate of the specified type to represent the specified static method.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />.-or- 
		///         <paramref name="method" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or-
		///         <paramref name="type" /> is not a <see langword="RuntimeType" />. See Runtime Types in Reflection. -or-
		///         <paramref name="method" /> cannot be bound, and <paramref name="throwOnBindFailure" /> is <see langword="true" />.-or-
		///         <paramref name="method" /> is not a <see langword="RuntimeMethodInfo" />. See Runtime Types in Reflection.</exception>
		/// <exception cref="T:System.MissingMethodException">The <see langword="Invoke" /> method of <paramref name="type" /> is not found. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception>
		// Token: 0x06000E91 RID: 3729 RVA: 0x0003D867 File Offset: 0x0003BA67
		public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure)
		{
			return Delegate.CreateDelegate(type, null, method, throwOnBindFailure, false);
		}

		/// <summary>Creates a delegate of the specified type to represent the specified static method.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of delegate to create. </param>
		/// <param name="method">The <see cref="T:System.Reflection.MethodInfo" /> describing the static or instance method the delegate is to represent. Only static methods are supported in the .NET Framework version 1.0 and 1.1.</param>
		/// <returns>A delegate of the specified type to represent the specified static method.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />.-or- 
		///         <paramref name="method" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or-
		///         <paramref name="type" /> is not a <see langword="RuntimeType" />. See Runtime Types in Reflection. -or- 
		///         <paramref name="method" /> is not a static method, and the .NET Framework version is 1.0 or 1.1. -or-
		///         <paramref name="method" /> cannot be bound.-or-
		///         <paramref name="method" /> is not a <see langword="RuntimeMethodInfo" />. See Runtime Types in Reflection.</exception>
		/// <exception cref="T:System.MissingMethodException">The <see langword="Invoke" /> method of <paramref name="type" /> is not found. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception>
		// Token: 0x06000E92 RID: 3730 RVA: 0x0003D873 File Offset: 0x0003BA73
		public static Delegate CreateDelegate(Type type, MethodInfo method)
		{
			return Delegate.CreateDelegate(type, method, true);
		}

		/// <summary>Creates a delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of delegate to create. </param>
		/// <param name="target">The class instance on which <paramref name="method" /> is invoked. </param>
		/// <param name="method">The name of the instance method that the delegate is to represent. </param>
		/// <returns>A delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />.-or- 
		///         <paramref name="target" /> is <see langword="null" />.-or- 
		///         <paramref name="method" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />. -or-
		///         <paramref name="type" /> is not a <see langword="RuntimeType" />. See Runtime Types in Reflection.-or- 
		///         <paramref name="method" /> is not an instance method. -or-
		///         <paramref name="method" /> cannot be bound, for example because it cannot be found.</exception>
		/// <exception cref="T:System.MissingMethodException">The <see langword="Invoke" /> method of <paramref name="type" /> is not found. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception>
		// Token: 0x06000E93 RID: 3731 RVA: 0x0003D87D File Offset: 0x0003BA7D
		public static Delegate CreateDelegate(Type type, object target, string method)
		{
			return Delegate.CreateDelegate(type, target, method, false);
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0003D888 File Offset: 0x0003BA88
		private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (method == null)
			{
				throw new ArgumentNullException("method");
			}
			if (!type.IsSubclassOf(typeof(MulticastDelegate)))
			{
				throw new ArgumentException("type is not subclass of MulticastDelegate.");
			}
			MethodInfo methodInfo = type.GetMethod("Invoke");
			ParameterInfo[] parametersInternal = methodInfo.GetParametersInternal();
			Type[] array = new Type[parametersInternal.Length];
			for (int i = 0; i < parametersInternal.Length; i++)
			{
				array[i] = parametersInternal[i].ParameterType;
			}
			BindingFlags bindingFlags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.ExactBinding | bflags;
			if (ignoreCase)
			{
				bindingFlags |= BindingFlags.IgnoreCase;
			}
			MethodInfo methodInfo2 = null;
			Type type2 = target;
			while (type2 != null)
			{
				MethodInfo methodInfo3 = type2.GetMethod(method, bindingFlags, null, array, Array.Empty<ParameterModifier>());
				if (methodInfo3 != null && Delegate.return_type_match(methodInfo.ReturnType, methodInfo3.ReturnType))
				{
					methodInfo2 = methodInfo3;
					break;
				}
				type2 = type2.BaseType;
			}
			if (!(methodInfo2 == null))
			{
				return methodInfo2;
			}
			if (throwOnBindFailure)
			{
				throw new ArgumentException("Couldn't bind to method '" + method + "'.");
			}
			return null;
		}

		/// <summary>Creates a delegate of the specified type that represents the specified static method of the specified class, with the specified case-sensitivity and the specified behavior on failure to bind.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of delegate to create. </param>
		/// <param name="target">The <see cref="T:System.Type" /> representing the class that implements <paramref name="method" />. </param>
		/// <param name="method">The name of the static method that the delegate is to represent. </param>
		/// <param name="ignoreCase">A Boolean indicating whether to ignore the case when comparing the name of the method.</param>
		/// <param name="throwOnBindFailure">
		///       <see langword="true" /> to throw an exception if <paramref name="method" /> cannot be bound; otherwise, <see langword="false" />.</param>
		/// <returns>A delegate of the specified type that represents the specified static method of the specified class.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />.-or- 
		///         <paramref name="target" /> is <see langword="null" />.-or- 
		///         <paramref name="method" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or- 
		///         <paramref name="type" /> is not a <see langword="RuntimeType" />. See Runtime Types in Reflection. -or-
		///         <paramref name="target" /> is not a <see langword="RuntimeType" />.-or-
		///         <paramref name="target" /> is an open generic type. That is, its <see cref="P:System.Type.ContainsGenericParameters" /> property is <see langword="true" />.-or-
		///         <paramref name="method" /> is not a <see langword="static" /> method (<see langword="Shared" /> method in Visual Basic). -or-
		///         <paramref name="method" /> cannot be bound, for example because it cannot be found, and <paramref name="throwOnBindFailure" /> is <see langword="true" />. </exception>
		/// <exception cref="T:System.MissingMethodException">The <see langword="Invoke" /> method of <paramref name="type" /> is not found. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception>
		// Token: 0x06000E95 RID: 3733 RVA: 0x0003D998 File Offset: 0x0003BB98
		public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			MethodInfo candidateMethod = Delegate.GetCandidateMethod(type, target, method, BindingFlags.Static, ignoreCase, throwOnBindFailure);
			if (candidateMethod == null)
			{
				return null;
			}
			return Delegate.CreateDelegate_internal(type, null, candidateMethod, throwOnBindFailure);
		}

		/// <summary>Creates a delegate of the specified type that represents the specified static method of the specified class.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of delegate to create. </param>
		/// <param name="target">The <see cref="T:System.Type" /> representing the class that implements <paramref name="method" />. </param>
		/// <param name="method">The name of the static method that the delegate is to represent. </param>
		/// <returns>A delegate of the specified type that represents the specified static method of the specified class.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />.-or- 
		///         <paramref name="target" /> is <see langword="null" />.-or- 
		///         <paramref name="method" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or- 
		///         <paramref name="type" /> is not a <see langword="RuntimeType" />. See Runtime Types in Reflection. -or-
		///         <paramref name="target" /> is not a <see langword="RuntimeType" />.-or-
		///         <paramref name="target" /> is an open generic type. That is, its <see cref="P:System.Type.ContainsGenericParameters" /> property is <see langword="true" />.-or-
		///         <paramref name="method" /> is not a <see langword="static" /> method (<see langword="Shared" /> method in Visual Basic). -or-
		///         <paramref name="method" /> cannot be bound, for example because it cannot be found, and <paramref name="throwOnBindFailure" /> is <see langword="true" />.</exception>
		/// <exception cref="T:System.MissingMethodException">The <see langword="Invoke" /> method of <paramref name="type" /> is not found. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception>
		// Token: 0x06000E96 RID: 3734 RVA: 0x0003D9DB File Offset: 0x0003BBDB
		public static Delegate CreateDelegate(Type type, Type target, string method)
		{
			return Delegate.CreateDelegate(type, target, method, false, true);
		}

		/// <summary>Creates a delegate of the specified type that represents the specified instance method to invoke on the specified class instance, with the specified case-sensitivity and the specified behavior on failure to bind.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of delegate to create. </param>
		/// <param name="target">The class instance on which <paramref name="method" /> is invoked. </param>
		/// <param name="method">The name of the instance method that the delegate is to represent. </param>
		/// <param name="ignoreCase">A Boolean indicating whether to ignore the case when comparing the name of the method. </param>
		/// <param name="throwOnBindFailure">
		///       <see langword="true" /> to throw an exception if <paramref name="method" /> cannot be bound; otherwise, <see langword="false" />.</param>
		/// <returns>A delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />.-or- 
		///         <paramref name="target" /> is <see langword="null" />.-or- 
		///         <paramref name="method" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or-
		///         <paramref name="type" /> is not a <see langword="RuntimeType" />. See Runtime Types in Reflection. -or-  
		///         <paramref name="method" /> is not an instance method. -or-
		///         <paramref name="method" /> cannot be bound, for example because it cannot be found, and <paramref name="throwOnBindFailure" /> is <see langword="true" />.</exception>
		/// <exception cref="T:System.MissingMethodException">The <see langword="Invoke" /> method of <paramref name="type" /> is not found. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception>
		// Token: 0x06000E97 RID: 3735 RVA: 0x0003D9E8 File Offset: 0x0003BBE8
		public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			MethodInfo candidateMethod = Delegate.GetCandidateMethod(type, target.GetType(), method, BindingFlags.Instance, ignoreCase, throwOnBindFailure);
			if (candidateMethod == null)
			{
				return null;
			}
			return Delegate.CreateDelegate_internal(type, target, candidateMethod, throwOnBindFailure);
		}

		/// <summary>Creates a delegate of the specified type that represents the specified instance method to invoke on the specified class instance with the specified case-sensitivity.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of delegate to create. </param>
		/// <param name="target">The class instance on which <paramref name="method" /> is invoked. </param>
		/// <param name="method">The name of the instance method that the delegate is to represent. </param>
		/// <param name="ignoreCase">A Boolean indicating whether to ignore the case when comparing the name of the method. </param>
		/// <returns>A delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />.-or- 
		///         <paramref name="target" /> is <see langword="null" />.-or- 
		///         <paramref name="method" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or-
		///         <paramref name="type" /> is not a <see langword="RuntimeType" />. See Runtime Types in Reflection.-or- 
		///         <paramref name="method" /> is not an instance method. -or-
		///         <paramref name="method" /> cannot be bound, for example because it cannot be found.</exception>
		/// <exception cref="T:System.MissingMethodException">The <see langword="Invoke" /> method of <paramref name="type" /> is not found. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception>
		// Token: 0x06000E98 RID: 3736 RVA: 0x0003DA2A File Offset: 0x0003BC2A
		public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase)
		{
			return Delegate.CreateDelegate(type, target, method, ignoreCase, true);
		}

		/// <summary>Creates a shallow copy of the delegate.</summary>
		/// <returns>A shallow copy of the delegate.</returns>
		// Token: 0x06000E99 RID: 3737 RVA: 0x0000FDD6 File Offset: 0x0000DFD6
		public virtual object Clone()
		{
			return base.MemberwiseClone();
		}

		/// <summary>Determines whether the specified object and the current delegate are of the same type and share the same targets, methods, and invocation list.</summary>
		/// <param name="obj">The object to compare with the current delegate. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> and the current delegate have the same targets, methods, and invocation list; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private). </exception>
		// Token: 0x06000E9A RID: 3738 RVA: 0x0003DA38 File Offset: 0x0003BC38
		public override bool Equals(object obj)
		{
			Delegate @delegate = obj as Delegate;
			if (@delegate == null)
			{
				return false;
			}
			if (@delegate.m_target != this.m_target || !(@delegate.Method == this.Method))
			{
				return false;
			}
			if (@delegate.data == null && this.data == null)
			{
				return true;
			}
			if (@delegate.data != null && this.data != null)
			{
				return @delegate.data.target_type == this.data.target_type && @delegate.data.method_name == this.data.method_name;
			}
			if (@delegate.data != null)
			{
				return @delegate.data.target_type == null;
			}
			return this.data != null && this.data.target_type == null;
		}

		/// <summary>Returns a hash code for the delegate.</summary>
		/// <returns>A hash code for the delegate.</returns>
		// Token: 0x06000E9B RID: 3739 RVA: 0x0003DB10 File Offset: 0x0003BD10
		public override int GetHashCode()
		{
			MethodInfo methodInfo = this.Method;
			return ((methodInfo != null) ? methodInfo.GetHashCode() : base.GetType().GetHashCode()) ^ RuntimeHelpers.GetHashCode(this.m_target);
		}

		/// <summary>Gets the static method represented by the current delegate.</summary>
		/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> describing the static method represented by the current delegate.</returns>
		/// <exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private). </exception>
		// Token: 0x06000E9C RID: 3740 RVA: 0x0003DB4C File Offset: 0x0003BD4C
		protected virtual MethodInfo GetMethodImpl()
		{
			if (this.method_info != null)
			{
				return this.method_info;
			}
			if (this.method != IntPtr.Zero)
			{
				if (!this.method_is_virtual)
				{
					this.method_info = (MethodInfo)RuntimeMethodInfo.GetMethodFromHandleNoGenericCheck(new RuntimeMethodHandle(this.method));
				}
				else
				{
					this.method_info = this.GetVirtualMethod_internal();
				}
			}
			return this.method_info;
		}

		/// <summary>Not supported.</summary>
		/// <param name="info">Not supported. </param>
		/// <param name="context">Not supported. </param>
		/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
		// Token: 0x06000E9D RID: 3741 RVA: 0x0003DBB7 File Offset: 0x0003BDB7
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			DelegateSerializationHolder.GetDelegateData(this, info, context);
		}

		/// <summary>Returns the invocation list of the delegate.</summary>
		/// <returns>An array of delegates representing the invocation list of the current delegate.</returns>
		// Token: 0x06000E9E RID: 3742 RVA: 0x0003DBC1 File Offset: 0x0003BDC1
		public virtual Delegate[] GetInvocationList()
		{
			return new Delegate[]
			{
				this
			};
		}

		/// <summary>Concatenates the invocation lists of two delegates.</summary>
		/// <param name="a">The delegate whose invocation list comes first. </param>
		/// <param name="b">The delegate whose invocation list comes last. </param>
		/// <returns>A new delegate with an invocation list that concatenates the invocation lists of <paramref name="a" /> and <paramref name="b" /> in that order. Returns <paramref name="a" /> if <paramref name="b" /> is <see langword="null" />, returns <paramref name="b" /> if <paramref name="a" /> is a null reference, and returns a null reference if both <paramref name="a" /> and <paramref name="b" /> are null references.</returns>
		/// <exception cref="T:System.ArgumentException">Both <paramref name="a" /> and <paramref name="b" /> are not <see langword="null" />, and <paramref name="a" /> and <paramref name="b" /> are not instances of the same delegate type. </exception>
		// Token: 0x06000E9F RID: 3743 RVA: 0x0003DBD0 File Offset: 0x0003BDD0
		public static Delegate Combine(Delegate a, Delegate b)
		{
			if (a == null)
			{
				return b;
			}
			if (b == null)
			{
				return a;
			}
			if (a.GetType() != b.GetType())
			{
				throw new ArgumentException(string.Format("Incompatible Delegate Types. First is {0} second is {1}.", a.GetType().FullName, b.GetType().FullName));
			}
			return a.CombineImpl(b);
		}

		/// <summary>Concatenates the invocation lists of an array of delegates.</summary>
		/// <param name="delegates">The array of delegates to combine. </param>
		/// <returns>A new delegate with an invocation list that concatenates the invocation lists of the delegates in the <paramref name="delegates" /> array. Returns <see langword="null" /> if <paramref name="delegates" /> is <see langword="null" />, if <paramref name="delegates" /> contains zero elements, or if every entry in <paramref name="delegates" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Not all the non-null entries in <paramref name="delegates" /> are instances of the same delegate type. </exception>
		// Token: 0x06000EA0 RID: 3744 RVA: 0x0003DC28 File Offset: 0x0003BE28
		[ComVisible(true)]
		public static Delegate Combine(params Delegate[] delegates)
		{
			if (delegates == null)
			{
				return null;
			}
			Delegate @delegate = null;
			foreach (Delegate b in delegates)
			{
				@delegate = Delegate.Combine(@delegate, b);
			}
			return @delegate;
		}

		/// <summary>Concatenates the invocation lists of the specified multicast (combinable) delegate and the current multicast (combinable) delegate.</summary>
		/// <param name="d">The multicast (combinable) delegate whose invocation list to append to the end of the invocation list of the current multicast (combinable) delegate. </param>
		/// <returns>A new multicast (combinable) delegate with an invocation list that concatenates the invocation list of the current multicast (combinable) delegate and the invocation list of <paramref name="d" />, or the current multicast (combinable) delegate if <paramref name="d" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.MulticastNotSupportedException">Always thrown. </exception>
		// Token: 0x06000EA1 RID: 3745 RVA: 0x0003DC59 File Offset: 0x0003BE59
		protected virtual Delegate CombineImpl(Delegate d)
		{
			throw new MulticastNotSupportedException(string.Empty);
		}

		/// <summary>Removes the last occurrence of the invocation list of a delegate from the invocation list of another delegate.</summary>
		/// <param name="source">The delegate from which to remove the invocation list of <paramref name="value" />. </param>
		/// <param name="value">The delegate that supplies the invocation list to remove from the invocation list of <paramref name="source" />. </param>
		/// <returns>A new delegate with an invocation list formed by taking the invocation list of <paramref name="source" /> and removing the last occurrence of the invocation list of <paramref name="value" />, if the invocation list of <paramref name="value" /> is found within the invocation list of <paramref name="source" />. Returns <paramref name="source" /> if <paramref name="value" /> is <see langword="null" /> or if the invocation list of <paramref name="value" /> is not found within the invocation list of <paramref name="source" />. Returns a null reference if the invocation list of <paramref name="value" /> is equal to the invocation list of <paramref name="source" /> or if <paramref name="source" /> is a null reference.</returns>
		/// <exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private). </exception>
		/// <exception cref="T:System.ArgumentException">The delegate types do not match.</exception>
		// Token: 0x06000EA2 RID: 3746 RVA: 0x0003DC68 File Offset: 0x0003BE68
		public static Delegate Remove(Delegate source, Delegate value)
		{
			if (source == null)
			{
				return null;
			}
			if (value == null)
			{
				return source;
			}
			if (source.GetType() != value.GetType())
			{
				throw new ArgumentException(string.Format("Incompatible Delegate Types. First is {0} second is {1}.", source.GetType().FullName, value.GetType().FullName));
			}
			return source.RemoveImpl(value);
		}

		/// <summary>Removes the invocation list of a delegate from the invocation list of another delegate.</summary>
		/// <param name="d">The delegate that supplies the invocation list to remove from the invocation list of the current delegate. </param>
		/// <returns>A new delegate with an invocation list formed by taking the invocation list of the current delegate and removing the invocation list of <paramref name="value" />, if the invocation list of <paramref name="value" /> is found within the current delegate's invocation list. Returns the current delegate if <paramref name="value" /> is <see langword="null" /> or if the invocation list of <paramref name="value" /> is not found within the current delegate's invocation list. Returns <see langword="null" /> if the invocation list of <paramref name="value" /> is equal to the current delegate's invocation list.</returns>
		/// <exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private). </exception>
		// Token: 0x06000EA3 RID: 3747 RVA: 0x0003DCBF File Offset: 0x0003BEBF
		protected virtual Delegate RemoveImpl(Delegate d)
		{
			if (this.Equals(d))
			{
				return null;
			}
			return this;
		}

		/// <summary>Determines whether the specified delegates are equal.</summary>
		/// <param name="d1">The first delegate to compare. </param>
		/// <param name="d2">The second delegate to compare. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="d1" /> is equal to <paramref name="d2" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000EA4 RID: 3748 RVA: 0x0003DCCD File Offset: 0x0003BECD
		public static bool operator ==(Delegate d1, Delegate d2)
		{
			if (d1 == null)
			{
				return d2 == null;
			}
			return d2 != null && d1.Equals(d2);
		}

		/// <summary>Determines whether the specified delegates are not equal.</summary>
		/// <param name="d1">The first delegate to compare. </param>
		/// <param name="d2">The second delegate to compare. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="d1" /> is not equal to <paramref name="d2" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000EA5 RID: 3749 RVA: 0x0003DCE5 File Offset: 0x0003BEE5
		public static bool operator !=(Delegate d1, Delegate d2)
		{
			return !(d1 == d2);
		}

		// Token: 0x06000EA6 RID: 3750
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern MulticastDelegate AllocDelegateLike_internal(Delegate d);

		// Token: 0x04000580 RID: 1408
		private IntPtr method_ptr;

		// Token: 0x04000581 RID: 1409
		private IntPtr invoke_impl;

		// Token: 0x04000582 RID: 1410
		private object m_target;

		// Token: 0x04000583 RID: 1411
		private IntPtr method;

		// Token: 0x04000584 RID: 1412
		private IntPtr delegate_trampoline;

		// Token: 0x04000585 RID: 1413
		private IntPtr extra_arg;

		// Token: 0x04000586 RID: 1414
		private IntPtr method_code;

		// Token: 0x04000587 RID: 1415
		private IntPtr interp_method;

		// Token: 0x04000588 RID: 1416
		private IntPtr interp_invoke_impl;

		// Token: 0x04000589 RID: 1417
		private MethodInfo method_info;

		// Token: 0x0400058A RID: 1418
		private MethodInfo original_method_info;

		// Token: 0x0400058B RID: 1419
		private DelegateData data;

		// Token: 0x0400058C RID: 1420
		private bool method_is_virtual;
	}
}
