using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Threading;

namespace System.Reflection
{
	/// <summary>Represents an assembly, which is a reusable, versionable, and self-describing building block of a common language runtime application.</summary>
	// Token: 0x020004CE RID: 1230
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_Assembly))]
	[ClassInterface(ClassInterfaceType.None)]
	[Serializable]
	[StructLayout(0)]
	public class Assembly : ICustomAttributeProvider, ISerializable
	{
		/// <summary>Gets the location of the assembly as specified originally, for example, in an <see cref="T:System.Reflection.AssemblyName" /> object.</summary>
		/// <returns>The location of the assembly as specified originally.</returns>
		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x0002B1E0 File Offset: 0x000293E0
		public virtual string CodeBase
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Gets the display name of the assembly.</summary>
		/// <returns>The display name of the assembly.</returns>
		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x0002B1E0 File Offset: 0x000293E0
		public virtual string FullName
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060022AE RID: 8878 RVA: 0x0002B1E0 File Offset: 0x000293E0
		internal virtual IntPtr MonoAssembly
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Gets serialization information with all of the data needed to reinstantiate this assembly.</summary>
		/// <param name="info">The object to be populated with serialization information. </param>
		/// <param name="context">The destination context of the serialization. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		// Token: 0x060022AF RID: 8879 RVA: 0x0002B1E0 File Offset: 0x000293E0
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new NotImplementedException();
		}

		/// <summary>Indicates whether or not a specified attribute has been applied to the assembly.</summary>
		/// <param name="attributeType">The type of the attribute to be checked for this assembly. </param>
		/// <param name="inherit">This argument is ignored for objects of this type. </param>
		/// <returns>
		///     <see langword="true" /> if the attribute has been applied to the assembly; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> uses an invalid type.</exception>
		// Token: 0x060022B0 RID: 8880 RVA: 0x0002B1E0 File Offset: 0x000293E0
		public virtual bool IsDefined(Type attributeType, bool inherit)
		{
			throw new NotImplementedException();
		}

		/// <summary>Gets all the custom attributes for this assembly.</summary>
		/// <param name="inherit">This argument is ignored for objects of type <see cref="T:System.Reflection.Assembly" />. </param>
		/// <returns>An array that contains the custom attributes for this assembly.</returns>
		// Token: 0x060022B1 RID: 8881 RVA: 0x0002B1E0 File Offset: 0x000293E0
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			throw new NotImplementedException();
		}

		/// <summary>Gets the custom attributes for this assembly as specified by type.</summary>
		/// <param name="attributeType">The type for which the custom attributes are to be returned. </param>
		/// <param name="inherit">This argument is ignored for objects of type <see cref="T:System.Reflection.Assembly" />. </param>
		/// <returns>An array that contains the custom attributes for this assembly as specified by <paramref name="attributeType" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not a runtime type. </exception>
		// Token: 0x060022B2 RID: 8882 RVA: 0x0002B1E0 File Offset: 0x000293E0
		public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060022B3 RID: 8883
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal virtual extern Type[] GetTypes(bool exportedOnly);

		/// <summary>Gets the types defined in this assembly.</summary>
		/// <returns>An array that contains all the types that are defined in this assembly.</returns>
		/// <exception cref="T:System.Reflection.ReflectionTypeLoadException">The assembly contains one or more types that cannot be loaded. The array returned by the <see cref="P:System.Reflection.ReflectionTypeLoadException.Types" /> property of this exception contains a <see cref="T:System.Type" /> object for each type that was loaded and <see langword="null" /> for each type that could not be loaded, while the <see cref="P:System.Reflection.ReflectionTypeLoadException.LoaderExceptions" /> property contains an exception for each type that could not be loaded.</exception>
		// Token: 0x060022B4 RID: 8884 RVA: 0x0008BF57 File Offset: 0x0008A157
		public virtual Type[] GetTypes()
		{
			return this.GetTypes(false);
		}

		/// <summary>Gets the <see cref="T:System.Type" /> object with the specified name in the assembly instance.</summary>
		/// <param name="name">The full name of the type. </param>
		/// <returns>An object that represents the specified class, or <see langword="null" /> if the class is not found.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="name" /> is invalid. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///         <paramref name="name" />
		///
		///          requires a dependent assembly that could not be found. </exception>
		/// <exception cref="T:System.IO.FileLoadException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.IO.IOException" />, instead.
		///         <paramref name="name" /> requires a dependent assembly that was found but could not be loaded.-or-The current assembly was loaded into the reflection-only context, and <paramref name="name" /> requires a dependent assembly that was not preloaded. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///         <paramref name="name" /> requires a dependent assembly, but the file is not a valid assembly. -or-
		///         <paramref name="name" /> requires a dependent assembly which was compiled for a version of the runtime later than the currently loaded version. </exception>
		// Token: 0x060022B5 RID: 8885 RVA: 0x0008BF60 File Offset: 0x0008A160
		public virtual Type GetType(string name)
		{
			return this.GetType(name, false, false);
		}

		// Token: 0x060022B6 RID: 8886
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase);

		/// <summary>Gets an <see cref="T:System.Reflection.AssemblyName" /> for this assembly, setting the codebase as specified by <paramref name="copiedName" />.</summary>
		/// <param name="copiedName">
		///       <see langword="true" /> to set the <see cref="P:System.Reflection.Assembly.CodeBase" /> to the location of the assembly after it was shadow copied; <see langword="false" /> to set <see cref="P:System.Reflection.Assembly.CodeBase" /> to the original location. </param>
		/// <returns>An object that contains the fully parsed display name for this assembly.</returns>
		// Token: 0x060022B7 RID: 8887 RVA: 0x0002B1E0 File Offset: 0x000293E0
		public virtual AssemblyName GetName(bool copiedName)
		{
			throw new NotImplementedException();
		}

		/// <summary>Gets an <see cref="T:System.Reflection.AssemblyName" /> for this assembly.</summary>
		/// <returns>An object that contains the fully parsed display name for this assembly.</returns>
		// Token: 0x060022B8 RID: 8888 RVA: 0x0008BF6B File Offset: 0x0008A16B
		public virtual AssemblyName GetName()
		{
			return this.GetName(false);
		}

		/// <summary>Returns the full name of the assembly, also known as the display name.</summary>
		/// <returns>The full name of the assembly, or the class name if the full name of the assembly cannot be determined.</returns>
		// Token: 0x060022B9 RID: 8889 RVA: 0x0008BF74 File Offset: 0x0008A174
		public override string ToString()
		{
			return base.ToString();
		}

		/// <summary>Gets the currently loaded assembly in which the specified type is defined.</summary>
		/// <param name="type">An object representing a type in the assembly that will be returned. </param>
		/// <returns>The assembly in which the specified type is defined.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />. </exception>
		// Token: 0x060022BA RID: 8890 RVA: 0x0008BF7C File Offset: 0x0008A17C
		public static Assembly GetAssembly(Type type)
		{
			if (type != null)
			{
				return type.Assembly;
			}
			throw new ArgumentNullException("type");
		}

		/// <summary>Gets the process executable in the default application domain. In other application domains, this is the first executable that was executed by <see cref="M:System.AppDomain.ExecuteAssembly(System.String)" />.</summary>
		/// <returns>The assembly that is the process executable in the default application domain, or the first executable that was executed by <see cref="M:System.AppDomain.ExecuteAssembly(System.String)" />. Can return <see langword="null" /> when called from unmanaged code.</returns>
		// Token: 0x060022BB RID: 8891
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Assembly GetEntryAssembly();

		// Token: 0x060022BC RID: 8892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Assembly LoadFrom(string assemblyFile, bool refOnly, ref StackCrawlMark stackMark);

		/// <summary>Loads an assembly given its file name or path and supplying security evidence.</summary>
		/// <param name="assemblyFile">The name or path of the file that contains the manifest of the assembly. </param>
		/// <param name="securityEvidence">Evidence for loading the assembly. </param>
		/// <returns>The loaded assembly.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="assemblyFile" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///         <paramref name="assemblyFile" /> is not found, or the module you are trying to load does not specify a filename extension. </exception>
		/// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded.-or-The <paramref name="securityEvidence" /> is not ambiguous and is determined to be invalid.</exception>
		/// <exception cref="T:System.BadImageFormatException">
		///         <paramref name="assemblyFile" /> is not a valid assembly; for example, a 32-bit assembly in a 64-bit process. See the exception topic for more information. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyFile" /> was compiled with a later version.</exception>
		/// <exception cref="T:System.Security.SecurityException">A codebase that does not start with "file://" was specified without the required <see cref="T:System.Net.WebPermission" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="assemblyFile" /> parameter is an empty string (""). </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The assembly name is longer than MAX_PATH characters.</exception>
		// Token: 0x060022BD RID: 8893 RVA: 0x0008BF98 File Offset: 0x0008A198
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return Assembly.LoadFrom(assemblyFile, false, ref stackCrawlMark);
		}

		/// <summary>Loads an assembly given the long form of its name.</summary>
		/// <param name="assemblyString">The long form of the assembly name. </param>
		/// <returns>The loaded assembly.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="assemblyString" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="assemblyString" /> is a zero-length string. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///         <paramref name="assemblyString" /> is not found. </exception>
		/// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///         <paramref name="assemblyString" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyString" /> was compiled with a later version.</exception>
		// Token: 0x060022BE RID: 8894 RVA: 0x0008BFB0 File Offset: 0x0008A1B0
		public static Assembly Load(string assemblyString)
		{
			return AppDomain.CurrentDomain.Load(assemblyString);
		}

		/// <summary>Loads an assembly given its <see cref="T:System.Reflection.AssemblyName" />.</summary>
		/// <param name="assemblyRef">The object that describes the assembly to be loaded. </param>
		/// <returns>The loaded assembly.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="assemblyRef" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///         <paramref name="assemblyRef" /> is not found. </exception>
		/// <exception cref="T:System.IO.FileLoadException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.IO.IOException" />, instead.A file that was found could not be loaded. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///         <paramref name="assemblyRef" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyRef" /> was compiled with a later version.</exception>
		// Token: 0x060022BF RID: 8895 RVA: 0x0008BFBD File Offset: 0x0008A1BD
		public static Assembly Load(AssemblyName assemblyRef)
		{
			return AppDomain.CurrentDomain.Load(assemblyRef);
		}

		/// <summary>Loads an assembly into the reflection-only context, given its display name.</summary>
		/// <param name="assemblyString">The display name of the assembly, as returned by the <see cref="P:System.Reflection.AssemblyName.FullName" /> property.</param>
		/// <returns>The loaded assembly.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="assemblyString" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="assemblyString" /> is an empty string (""). </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///         <paramref name="assemblyString" /> is not found. </exception>
		/// <exception cref="T:System.IO.FileLoadException">
		///         <paramref name="assemblyString" /> is found, but cannot be loaded. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///         <paramref name="assemblyString" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyString" /> was compiled with a later version.</exception>
		// Token: 0x060022C0 RID: 8896 RVA: 0x0008BFCC File Offset: 0x0008A1CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Assembly ReflectionOnlyLoad(string assemblyString)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return AppDomain.CurrentDomain.Load(assemblyString, null, true, ref stackCrawlMark);
		}

		/// <summary>Loads an assembly from the application directory or from the global assembly cache using a partial name.</summary>
		/// <param name="partialName">The display name of the assembly. </param>
		/// <returns>The loaded assembly. If <paramref name="partialName" /> is not found, this method returns <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="partialName" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///         <paramref name="assemblyFile" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="partialName" /> was compiled with a later version.</exception>
		// Token: 0x060022C1 RID: 8897 RVA: 0x0008BFEA File Offset: 0x0008A1EA
		public static Assembly LoadWithPartialName(string partialName)
		{
			return Assembly.LoadWithPartialName(partialName, null);
		}

		// Token: 0x060022C2 RID: 8898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Assembly load_with_partial_name(string name, Evidence e);

		/// <summary>Loads an assembly from the application directory or from the global assembly cache using a partial name. The assembly is loaded into the domain of the caller using the supplied evidence.</summary>
		/// <param name="partialName">The display name of the assembly. </param>
		/// <param name="securityEvidence">Evidence for loading the assembly. </param>
		/// <returns>The loaded assembly. If <paramref name="partialName" /> is not found, this method returns <see langword="null" />.</returns>
		/// <exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different sets of evidence. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="partialName" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///         <paramref name="assemblyFile" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="partialName" /> was compiled with a later version.</exception>
		// Token: 0x060022C3 RID: 8899 RVA: 0x0008BFF3 File Offset: 0x0008A1F3
		public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence)
		{
			return Assembly.LoadWithPartialName(partialName, securityEvidence, true);
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x0008BFFD File Offset: 0x0008A1FD
		internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior)
		{
			if (!oldBehavior)
			{
				throw new NotImplementedException();
			}
			if (partialName == null)
			{
				throw new NullReferenceException();
			}
			return Assembly.load_with_partial_name(partialName, securityEvidence);
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x0002B1E0 File Offset: 0x000293E0
		internal virtual Module[] GetModulesInternal()
		{
			throw new NotImplementedException();
		}

		/// <summary>Gets the assembly that contains the code that is currently executing.</summary>
		/// <returns>The assembly that contains the code that is currently executing. </returns>
		// Token: 0x060022C6 RID: 8902
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Assembly GetExecutingAssembly();

		// Token: 0x060022C7 RID: 8903 RVA: 0x0002B1E0 File Offset: 0x000293E0
		internal virtual Module GetManifestModule()
		{
			throw new NotImplementedException();
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x060022C8 RID: 8904 RVA: 0x0005B518 File Offset: 0x00059718
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Determines whether this assembly and the specified object are equal.</summary>
		/// <param name="o">The object to compare with this instance. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="o" /> is equal to this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x060022C9 RID: 8905 RVA: 0x0008A054 File Offset: 0x00088254
		public override bool Equals(object o)
		{
			return base.Equals(o);
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x0008C018 File Offset: 0x0008A218
		private static Exception CreateNIE()
		{
			return new NotImplementedException("Derived classes must implement it");
		}

		/// <summary>Gets a value that indicates whether the current assembly is loaded with full trust.</summary>
		/// <returns>
		///     <see langword="true" /> if the current assembly is loaded with full trust; otherwise, <see langword="false" />.</returns>
		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x0000B18D File Offset: 0x0000938D
		public bool IsFullyTrusted
		{
			get
			{
				return true;
			}
		}

		/// <summary>Gets the <see cref="T:System.Type" /> object with the specified name in the assembly instance, with the options of ignoring the case, and of throwing an exception if the type is not found.</summary>
		/// <param name="name">The full name of the type. </param>
		/// <param name="throwOnError">
		///       <see langword="true" /> to throw an exception if the type is not found; <see langword="false" /> to return <see langword="null" />. </param>
		/// <param name="ignoreCase">
		///       <see langword="true" /> to ignore the case of the type name; otherwise, <see langword="false" />. </param>
		/// <returns>An object that represents the specified class.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="name" /> is invalid.-or- The length of <paramref name="name" /> exceeds 1024 characters. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.TypeLoadException">
		///         <paramref name="throwOnError" /> is <see langword="true" />, and the type cannot be found.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///         <paramref name="name" />
		///
		///          requires a dependent assembly that could not be found. </exception>
		/// <exception cref="T:System.IO.FileLoadException">
		///         <paramref name="name" /> requires a dependent assembly that was found but could not be loaded.-or-The current assembly was loaded into the reflection-only context, and <paramref name="name" /> requires a dependent assembly that was not preloaded. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///         <paramref name="name" /> requires a dependent assembly, but the file is not a valid assembly. -or-
		///         <paramref name="name" /> requires a dependent assembly which was compiled for a version of the runtime later than the currently loaded version.</exception>
		// Token: 0x060022CC RID: 8908 RVA: 0x0008C024 File Offset: 0x0008A224
		public virtual Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
			throw Assembly.CreateNIE();
		}

		/// <summary>Gets the specified module in this assembly.</summary>
		/// <param name="name">The name of the module being requested. </param>
		/// <returns>The module being requested, or <see langword="null" /> if the module is not found.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is an empty string (""). </exception>
		/// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///         <paramref name="name" /> was not found. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///         <paramref name="name" /> is not a valid assembly. </exception>
		// Token: 0x060022CD RID: 8909 RVA: 0x0008C024 File Offset: 0x0008A224
		public virtual Module GetModule(string name)
		{
			throw Assembly.CreateNIE();
		}

		/// <summary>Gets all the modules that are part of this assembly, specifying whether to include resource modules.</summary>
		/// <param name="getResourceModules">
		///       <see langword="true" /> to include resource modules; otherwise, <see langword="false" />. </param>
		/// <returns>An array of modules.</returns>
		// Token: 0x060022CE RID: 8910 RVA: 0x0008C024 File Offset: 0x0008A224
		public virtual Module[] GetModules(bool getResourceModules)
		{
			throw Assembly.CreateNIE();
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.Assembly" /> objects are equal.</summary>
		/// <param name="left">The assembly to compare to <paramref name="right" />.</param>
		/// <param name="right">The assembly to compare to <paramref name="left" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060022CF RID: 8911 RVA: 0x0008C02B File Offset: 0x0008A22B
		public static bool operator ==(Assembly left, Assembly right)
		{
			return left == right || (!(left == null ^ right == null) && left.Equals(right));
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.Assembly" /> objects are not equal.</summary>
		/// <param name="left">The assembly to compare to <paramref name="right" />.</param>
		/// <param name="right">The assembly to compare to <paramref name="left" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060022D0 RID: 8912 RVA: 0x0008C047 File Offset: 0x0008A247
		public static bool operator !=(Assembly left, Assembly right)
		{
			return left != right && ((left == null ^ right == null) || !left.Equals(right));
		}

		// Token: 0x020004CF RID: 1231
		internal class ResolveEventHolder
		{
		}
	}
}
