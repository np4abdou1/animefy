using System;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Security;
using System.Threading;

namespace System
{
	/// <summary>Contains methods to create types of objects locally or remotely, or obtain references to existing remote objects. This class cannot be inherited. </summary>
	// Token: 0x0200013B RID: 315
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof(_Activator))]
	[ComVisible(true)]
	public sealed class Activator
	{
		/// <summary>Creates an instance of the specified type using the constructor that best matches the specified parameters.</summary>
		/// <param name="type">The type of object to create. </param>
		/// <param name="bindingAttr">A combination of zero or more bit flags that affect the search for the <paramref name="type" /> constructor. If <paramref name="bindingAttr" /> is zero, a case-sensitive search for public constructors is conducted. </param>
		/// <param name="binder">An object that uses <paramref name="bindingAttr" /> and <paramref name="args" /> to seek and identify the <paramref name="type" /> constructor. If <paramref name="binder" /> is <see langword="null" />, the default binder is used. </param>
		/// <param name="args">An array of arguments that match in number, order, and type the parameters of the constructor to invoke. If <paramref name="args" /> is an empty array or <see langword="null" />, the constructor that takes no parameters (the default constructor) is invoked. </param>
		/// <param name="culture">Culture-specific information that governs the coercion of <paramref name="args" /> to the formal types declared for the <paramref name="type" /> constructor. If <paramref name="culture" /> is <see langword="null" />, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. </param>
		/// <returns>A reference to the newly created object.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="type" /> is not a <see langword="RuntimeType" />. -or-
		///         <paramref name="type" /> is an open generic type (that is, the <see cref="P:System.Type.ContainsGenericParameters" /> property returns <see langword="true" />).</exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="type" /> cannot be a <see cref="T:System.Reflection.Emit.TypeBuilder" />.-or- Creation of <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, <see cref="T:System.Void" />, and <see cref="T:System.RuntimeArgumentHandle" /> types, or arrays of those types, is not supported. -or-
		///         The assembly that contains <paramref name="type" /> is a dynamic assembly that was created with <see cref="F:System.Reflection.Emit.AssemblyBuilderAccess.Save" />.-or-The constructor that best matches <paramref name="args" /> has <see langword="varargs" /> arguments.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The constructor being called throws an exception. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have permission to call this constructor. </exception>
		/// <exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">The COM type was not obtained through <see cref="Overload:System.Type.GetTypeFromProgID" /> or <see cref="Overload:System.Type.GetTypeFromCLSID" />. </exception>
		/// <exception cref="T:System.MissingMethodException">No matching constructor was found. </exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">
		///         <paramref name="type" /> is a COM object but the class identifier used to obtain the type is invalid, or the identified class is not registered. </exception>
		/// <exception cref="T:System.TypeLoadException">
		///         <paramref name="type" /> is not a valid type. </exception>
		// Token: 0x06000C24 RID: 3108 RVA: 0x00032087 File Offset: 0x00030287
		public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture)
		{
			return Activator.CreateInstance(type, bindingAttr, binder, args, culture, null);
		}

		/// <summary>Creates an instance of the specified type using the constructor that best matches the specified parameters.</summary>
		/// <param name="type">The type of object to create. </param>
		/// <param name="bindingAttr">A combination of zero or more bit flags that affect the search for the <paramref name="type" /> constructor. If <paramref name="bindingAttr" /> is zero, a case-sensitive search for public constructors is conducted. </param>
		/// <param name="binder">An object that uses <paramref name="bindingAttr" /> and <paramref name="args" /> to seek and identify the <paramref name="type" /> constructor. If <paramref name="binder" /> is <see langword="null" />, the default binder is used. </param>
		/// <param name="args">An array of arguments that match in number, order, and type the parameters of the constructor to invoke. If <paramref name="args" /> is an empty array or <see langword="null" />, the constructor that takes no parameters (the default constructor) is invoked. </param>
		/// <param name="culture">Culture-specific information that governs the coercion of <paramref name="args" /> to the formal types declared for the <paramref name="type" /> constructor. If <paramref name="culture" /> is <see langword="null" />, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. </param>
		/// <param name="activationAttributes">An array of one or more attributes that can participate in activation. This is typically an array that contains a single <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> object that specifies the URL that is required to activate a remote object. This parameter is related to client-activated objects. Client activation is a legacy technology that is retained for backward compatibility but is not recommended for new development. Distributed applications should instead use Windows Communication Foundation.</param>
		/// <returns>A reference to the newly created object.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="type" /> is not a <see langword="RuntimeType" />. -or-
		///         <paramref name="type" /> is an open generic type (that is, the <see cref="P:System.Type.ContainsGenericParameters" /> property returns <see langword="true" />).</exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="type" /> cannot be a <see cref="T:System.Reflection.Emit.TypeBuilder" />.-or- Creation of <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, <see cref="T:System.Void" />, and <see cref="T:System.RuntimeArgumentHandle" /> types, or arrays of those types, is not supported.-or- 
		///         <paramref name="activationAttributes" /> is not an empty array, and the type being created does not derive from <see cref="T:System.MarshalByRefObject" />. -or-
		///         The assembly that contains <paramref name="type" /> is a dynamic assembly that was created with <see cref="F:System.Reflection.Emit.AssemblyBuilderAccess.Save" />.-or-The constructor that best matches <paramref name="args" /> has <see langword="varargs" /> arguments.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The constructor being called throws an exception. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have permission to call this constructor. </exception>
		/// <exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">The COM type was not obtained through <see cref="Overload:System.Type.GetTypeFromProgID" /> or <see cref="Overload:System.Type.GetTypeFromCLSID" />. </exception>
		/// <exception cref="T:System.MissingMethodException">No matching constructor was found. </exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">
		///         <paramref name="type" /> is a COM object but the class identifier used to obtain the type is invalid, or the identified class is not registered. </exception>
		/// <exception cref="T:System.TypeLoadException">
		///         <paramref name="type" /> is not a valid type. </exception>
		// Token: 0x06000C25 RID: 3109 RVA: 0x00032098 File Offset: 0x00030298
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (RuntimeFeature.IsDynamicCodeSupported && type is TypeBuilder)
			{
				throw new NotSupportedException(Environment.GetResourceString("CreateInstance cannot be used with an object of type TypeBuilder."));
			}
			if ((bindingAttr & (BindingFlags)255) == BindingFlags.Default)
			{
				bindingAttr |= (BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance);
			}
			if (activationAttributes != null && activationAttributes.Length != 0)
			{
				if (!type.IsMarshalByRef)
				{
					throw new NotSupportedException(Environment.GetResourceString("Activation Attributes are not supported for types not deriving from MarshalByRefObject."));
				}
				if (!type.IsContextful && (activationAttributes.Length > 1 || !(activationAttributes[0] is UrlAttribute)))
				{
					throw new NotSupportedException(Environment.GetResourceString("UrlAttribute is the only attribute supported for MarshalByRefObject."));
				}
			}
			RuntimeType runtimeType = type.UnderlyingSystemType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a type provided by the runtime."), "type");
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return runtimeType.CreateInstanceImpl(bindingAttr, binder, args, culture, activationAttributes, ref stackCrawlMark);
		}

		/// <summary>Creates an instance of the specified type using the constructor that best matches the specified parameters.</summary>
		/// <param name="type">The type of object to create. </param>
		/// <param name="args">An array of arguments that match in number, order, and type the parameters of the constructor to invoke. If <paramref name="args" /> is an empty array or <see langword="null" />, the constructor that takes no parameters (the default constructor) is invoked. </param>
		/// <returns>A reference to the newly created object.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="type" /> is not a <see langword="RuntimeType" />. -or-
		///         <paramref name="type" /> is an open generic type (that is, the <see cref="P:System.Type.ContainsGenericParameters" /> property returns <see langword="true" />).</exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="type" /> cannot be a <see cref="T:System.Reflection.Emit.TypeBuilder" />.-or- Creation of <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, <see cref="T:System.Void" />, and <see cref="T:System.RuntimeArgumentHandle" /> types, or arrays of those types, is not supported. -or-
		///         The assembly that contains <paramref name="type" /> is a dynamic assembly that was created with <see cref="F:System.Reflection.Emit.AssemblyBuilderAccess.Save" />.-or-The constructor that best matches <paramref name="args" /> has <see langword="varargs" /> arguments. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The constructor being called throws an exception. </exception>
		/// <exception cref="T:System.MethodAccessException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MemberAccessException" />, instead.The caller does not have permission to call this constructor. </exception>
		/// <exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">The COM type was not obtained through <see cref="Overload:System.Type.GetTypeFromProgID" /> or <see cref="Overload:System.Type.GetTypeFromCLSID" />. </exception>
		/// <exception cref="T:System.MissingMethodException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MissingMemberException" />, instead.No matching public constructor was found. </exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">
		///         <paramref name="type" /> is a COM object but the class identifier used to obtain the type is invalid, or the identified class is not registered. </exception>
		/// <exception cref="T:System.TypeLoadException">
		///         <paramref name="type" /> is not a valid type. </exception>
		// Token: 0x06000C26 RID: 3110 RVA: 0x00032168 File Offset: 0x00030368
		public static object CreateInstance(Type type, params object[] args)
		{
			return Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, args, null, null);
		}

		/// <summary>Creates an instance of the specified type using that type's default constructor.</summary>
		/// <param name="type">The type of object to create. </param>
		/// <returns>A reference to the newly created object.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="type" /> is not a <see langword="RuntimeType" />. -or-
		///         <paramref name="type" /> is an open generic type (that is, the <see cref="P:System.Type.ContainsGenericParameters" /> property returns <see langword="true" />).</exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="type" /> cannot be a <see cref="T:System.Reflection.Emit.TypeBuilder" />.-or- Creation of <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, <see cref="T:System.Void" />, and <see cref="T:System.RuntimeArgumentHandle" /> types, or arrays of those types, is not supported.-or-
		///         The assembly that contains <paramref name="type" /> is a dynamic assembly that was created with <see cref="F:System.Reflection.Emit.AssemblyBuilderAccess.Save" />. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The constructor being called throws an exception. </exception>
		/// <exception cref="T:System.MethodAccessException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MemberAccessException" />, instead.The caller does not have permission to call this constructor. </exception>
		/// <exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">The COM type was not obtained through <see cref="Overload:System.Type.GetTypeFromProgID" /> or <see cref="Overload:System.Type.GetTypeFromCLSID" />. </exception>
		/// <exception cref="T:System.MissingMethodException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MissingMemberException" />, instead.No matching public constructor was found. </exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">
		///         <paramref name="type" /> is a COM object but the class identifier used to obtain the type is invalid, or the identified class is not registered. </exception>
		/// <exception cref="T:System.TypeLoadException">
		///         <paramref name="type" /> is not a valid type. </exception>
		// Token: 0x06000C27 RID: 3111 RVA: 0x00032179 File Offset: 0x00030379
		public static object CreateInstance(Type type)
		{
			return Activator.CreateInstance(type, false);
		}

		/// <summary>Creates an instance of the specified type using that type's default constructor.</summary>
		/// <param name="type">The type of object to create. </param>
		/// <param name="nonPublic">
		///       <see langword="true" /> if a public or nonpublic default constructor can match; <see langword="false" /> if only a public default constructor can match. </param>
		/// <returns>A reference to the newly created object.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="type" /> is not a <see langword="RuntimeType" />. -or-
		///         <paramref name="type" /> is an open generic type (that is, the <see cref="P:System.Type.ContainsGenericParameters" /> property returns <see langword="true" />).</exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="type" /> cannot be a <see cref="T:System.Reflection.Emit.TypeBuilder" />.-or- Creation of <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, <see cref="T:System.Void" />, and <see cref="T:System.RuntimeArgumentHandle" /> types, or arrays of those types, is not supported. -or-
		///         The assembly that contains <paramref name="type" /> is a dynamic assembly that was created with <see cref="F:System.Reflection.Emit.AssemblyBuilderAccess.Save" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The constructor being called throws an exception. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have permission to call this constructor. </exception>
		/// <exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidComObjectException">The COM type was not obtained through <see cref="Overload:System.Type.GetTypeFromProgID" /> or <see cref="Overload:System.Type.GetTypeFromCLSID" />. </exception>
		/// <exception cref="T:System.MissingMethodException">No matching public constructor was found. </exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">
		///         <paramref name="type" /> is a COM object but the class identifier used to obtain the type is invalid, or the identified class is not registered. </exception>
		/// <exception cref="T:System.TypeLoadException">
		///         <paramref name="type" /> is not a valid type. </exception>
		// Token: 0x06000C28 RID: 3112 RVA: 0x00032182 File Offset: 0x00030382
		public static object CreateInstance(Type type, bool nonPublic)
		{
			return Activator.CreateInstance(type, nonPublic, true);
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x0003218C File Offset: 0x0003038C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CreateInstance(Type type, bool nonPublic, bool wrapExceptions)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			RuntimeType runtimeType = type.UnderlyingSystemType as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a type provided by the runtime."), "type");
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return runtimeType.CreateInstanceDefaultCtor(!nonPublic, false, true, wrapExceptions, ref stackCrawlMark);
		}

		/// <summary>Creates an instance of the type designated by the specified generic type parameter, using the parameterless constructor.</summary>
		/// <typeparam name="T">The type to create.</typeparam>
		/// <returns>A reference to the newly created object.</returns>
		/// <exception cref="T:System.MissingMethodException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MissingMemberException" />, instead.The type that is specified for <paramref name="T" /> does not have a parameterless constructor. </exception>
		// Token: 0x06000C2A RID: 3114 RVA: 0x000321E0 File Offset: 0x000303E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T CreateInstance<T>()
		{
			RuntimeType runtimeType = typeof(T) as RuntimeType;
			if (runtimeType.HasElementType)
			{
				throw new MissingMethodException(Environment.GetResourceString("No parameterless constructor defined for this object."));
			}
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return (T)((object)runtimeType.CreateInstanceDefaultCtor(true, true, true, true, ref stackCrawlMark));
		}
	}
}
