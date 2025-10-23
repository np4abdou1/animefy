using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Security.Policy;
using System.Threading;
using Mono.Security;

namespace System
{
	/// <summary>Represents an application domain, which is an isolated environment where applications execute. This class cannot be inherited.</summary>
	// Token: 0x02000160 RID: 352
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[StructLayout(0)]
	public sealed class AppDomain : MarshalByRefObject
	{
		// Token: 0x06000E0A RID: 3594 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		internal static bool IsAppXModel()
		{
			return false;
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00032DE9 File Offset: 0x00030FE9
		private AppDomain()
		{
		}

		// Token: 0x06000E0C RID: 3596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AppDomainSetup getSetup();

		/// <summary>Gets the application domain configuration information for this instance.</summary>
		/// <returns>The application domain initialization information.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain.</exception>
		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x0003BF24 File Offset: 0x0003A124
		public AppDomainSetup SetupInformation
		{
			get
			{
				return new AppDomainSetup(this.getSetup());
			}
		}

		// Token: 0x06000E0E RID: 3598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern string getFriendlyName();

		/// <summary>Gets the <see cref="T:System.Security.Policy.Evidence" /> associated with this application domain.</summary>
		/// <returns>The evidence associated with this application domain.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain.</exception>
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x0003BF34 File Offset: 0x0003A134
		public Evidence Evidence
		{
			get
			{
				if (this._evidence == null)
				{
					lock (this)
					{
						Assembly entryAssembly = Assembly.GetEntryAssembly();
						if (entryAssembly == null)
						{
							if (this == AppDomain.DefaultDomain)
							{
								return new Evidence();
							}
							this._evidence = AppDomain.DefaultDomain.Evidence;
						}
						else
						{
							this._evidence = Evidence.GetDefaultHostEvidence(entryAssembly);
						}
					}
				}
				return new Evidence((Evidence)this._evidence);
			}
		}

		// Token: 0x06000E10 RID: 3600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AppDomain getCurDomain();

		/// <summary>Gets the current application domain for the current <see cref="T:System.Threading.Thread" />.</summary>
		/// <returns>The current application domain.</returns>
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x0003BFC0 File Offset: 0x0003A1C0
		public static AppDomain CurrentDomain
		{
			get
			{
				return AppDomain.getCurDomain();
			}
		}

		// Token: 0x06000E12 RID: 3602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AppDomain getRootDomain();

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x0003BFC8 File Offset: 0x0003A1C8
		internal static AppDomain DefaultDomain
		{
			get
			{
				if (AppDomain.default_domain == null)
				{
					AppDomain rootDomain = AppDomain.getRootDomain();
					if (rootDomain == AppDomain.CurrentDomain)
					{
						AppDomain.default_domain = rootDomain;
					}
					else
					{
						AppDomain.default_domain = (AppDomain)RemotingServices.GetDomainProxy(rootDomain);
					}
				}
				return AppDomain.default_domain;
			}
		}

		/// <summary>Defines a dynamic assembly with the specified name and access mode.</summary>
		/// <param name="name">The unique identity of the dynamic assembly. </param>
		/// <param name="access">The access mode for the dynamic assembly. </param>
		/// <returns>A dynamic assembly with the specified name and access mode.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <see langword="Name" /> property of <paramref name="name" /> is <see langword="null" />.-or- The <see langword="Name" /> property of <paramref name="name" /> begins with white space, or contains a forward or backward slash. </exception>
		/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception>
		// Token: 0x06000E14 RID: 3604 RVA: 0x0003C008 File Offset: 0x0003A208
		public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access)
		{
			return this.DefineDynamicAssembly(name, access, null, null, null, null, null, false);
		}

		/// <summary>Defines a dynamic assembly using the specified name, access mode, storage directory, evidence, permission requests, and synchronization option.</summary>
		/// <param name="name">The unique identity of the dynamic assembly. </param>
		/// <param name="access">The mode in which the dynamic assembly will be accessed. </param>
		/// <param name="dir">The name of the directory where the dynamic assembly will be saved. If <paramref name="dir" /> is <see langword="null" />, the directory defaults to the current directory. </param>
		/// <param name="evidence">The evidence supplied for the dynamic assembly. The evidence is used unaltered as the final set of evidence used for policy resolution. </param>
		/// <param name="requiredPermissions">The required permissions request. </param>
		/// <param name="optionalPermissions">The optional permissions request. </param>
		/// <param name="refusedPermissions">The refused permissions request. </param>
		/// <param name="isSynchronized">
		///       <see langword="true" /> to synchronize the creation of modules, types, and members in the dynamic assembly; otherwise, <see langword="false" />. </param>
		/// <returns>A dynamic assembly with the specified name and features.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <see langword="Name" /> property of <paramref name="name" /> is <see langword="null" />.-or- The <see langword="Name" /> property of <paramref name="name" /> begins with white space, or contains a forward or backward slash. </exception>
		/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception>
		// Token: 0x06000E15 RID: 3605 RVA: 0x0003C023 File Offset: 0x0003A223
		public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, bool isSynchronized)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			AppDomain.ValidateAssemblyName(name.Name);
			AssemblyBuilder assemblyBuilder = new AssemblyBuilder(name, dir, access, false);
			assemblyBuilder.AddPermissionRequests(requiredPermissions, optionalPermissions, refusedPermissions);
			return assemblyBuilder;
		}

		// Token: 0x06000E16 RID: 3606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Assembly[] GetAssemblies(bool refOnly);

		/// <summary>Gets the assemblies that have been loaded into the execution context of this application domain.</summary>
		/// <returns>An array of assemblies in this application domain.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception>
		// Token: 0x06000E17 RID: 3607 RVA: 0x0003C053 File Offset: 0x0003A253
		public Assembly[] GetAssemblies()
		{
			return this.GetAssemblies(false);
		}

		/// <summary>Gets the value stored in the current application domain for the specified name.</summary>
		/// <param name="name">The name of a predefined application domain property, or the name of an application domain property you have defined.</param>
		/// <returns>The value of the <paramref name="name" /> property, or <see langword="null" /> if the property does not exist.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception>
		// Token: 0x06000E18 RID: 3608
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern object GetData(string name);

		/// <summary>Gives the <see cref="T:System.AppDomain" /> an infinite lifetime by preventing a lease from being created.</summary>
		/// <returns>Always <see langword="null" />.</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception>
		// Token: 0x06000E19 RID: 3609 RVA: 0x0002AC82 File Offset: 0x00028E82
		public override object InitializeLifetimeService()
		{
			return null;
		}

		// Token: 0x06000E1A RID: 3610
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly, ref StackCrawlMark stackMark);

		/// <summary>Loads an <see cref="T:System.Reflection.Assembly" /> given its <see cref="T:System.Reflection.AssemblyName" />.</summary>
		/// <param name="assemblyRef">An object that describes the assembly to load. </param>
		/// <returns>The loaded assembly.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="assemblyRef" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///         <paramref name="assemblyRef" /> is not found. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///         <paramref name="assemblyRef" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyRef" /> was compiled with a later version.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception>
		/// <exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception>
		// Token: 0x06000E1B RID: 3611 RVA: 0x0003C05C File Offset: 0x0003A25C
		public Assembly Load(AssemblyName assemblyRef)
		{
			return this.Load(assemblyRef, null);
		}

		/// <summary>Loads an <see cref="T:System.Reflection.Assembly" /> given its <see cref="T:System.Reflection.AssemblyName" />.</summary>
		/// <param name="assemblyRef">An object that describes the assembly to load. </param>
		/// <param name="assemblySecurity">Evidence for loading the assembly. </param>
		/// <returns>The loaded assembly.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="assemblyRef" /> is <see langword="null" /></exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///         <paramref name="assemblyRef" /> is not found. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///         <paramref name="assemblyRef" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyRef" /> was compiled with a later version.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception>
		/// <exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception>
		// Token: 0x06000E1C RID: 3612 RVA: 0x0003C068 File Offset: 0x0003A268
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity)
		{
			if (assemblyRef == null)
			{
				throw new ArgumentNullException("assemblyRef");
			}
			if (assemblyRef.Name == null || assemblyRef.Name.Length == 0)
			{
				if (assemblyRef.CodeBase != null)
				{
					return Assembly.LoadFrom(assemblyRef.CodeBase, assemblySecurity);
				}
				throw new ArgumentException(Locale.GetText("assemblyRef.Name cannot be empty."), "assemblyRef");
			}
			else
			{
				StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
				Assembly assembly = this.LoadAssembly(assemblyRef.FullName, assemblySecurity, false, ref stackCrawlMark);
				if (assembly != null)
				{
					return assembly;
				}
				if (assemblyRef.CodeBase == null)
				{
					throw new FileNotFoundException(null, assemblyRef.Name);
				}
				string text = assemblyRef.CodeBase;
				if (text.StartsWith("file://", StringComparison.OrdinalIgnoreCase))
				{
					text = new Uri(text).LocalPath;
				}
				try
				{
					assembly = Assembly.LoadFrom(text, assemblySecurity);
				}
				catch
				{
					throw new FileNotFoundException(null, assemblyRef.Name);
				}
				AssemblyName name = assembly.GetName();
				if (assemblyRef.Name != name.Name)
				{
					throw new FileNotFoundException(null, assemblyRef.Name);
				}
				if (assemblyRef.Version != null && assemblyRef.Version != new Version(0, 0, 0, 0) && assemblyRef.Version != name.Version)
				{
					throw new FileNotFoundException(null, assemblyRef.Name);
				}
				if (assemblyRef.CultureInfo != null && assemblyRef.CultureInfo.Equals(name))
				{
					throw new FileNotFoundException(null, assemblyRef.Name);
				}
				byte[] publicKeyToken = assemblyRef.GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length != 0)
				{
					byte[] publicKeyToken2 = name.GetPublicKeyToken();
					if (publicKeyToken2 == null || publicKeyToken.Length != publicKeyToken2.Length)
					{
						throw new FileNotFoundException(null, assemblyRef.Name);
					}
					for (int i = publicKeyToken.Length - 1; i >= 0; i--)
					{
						if (publicKeyToken2[i] != publicKeyToken[i])
						{
							throw new FileNotFoundException(null, assemblyRef.Name);
						}
					}
				}
				return assembly;
			}
		}

		/// <summary>Loads an <see cref="T:System.Reflection.Assembly" /> given its display name.</summary>
		/// <param name="assemblyString">The display name of the assembly. See <see cref="P:System.Reflection.Assembly.FullName" />.</param>
		/// <returns>The loaded assembly.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="assemblyString" /> is <see langword="null" /></exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///         <paramref name="assemblyString" /> is not found. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///         <paramref name="assemblyString" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyString" /> was compiled with a later version.</exception>
		/// <exception cref="T:System.AppDomainUnloadedException">The operation is attempted on an unloaded application domain. </exception>
		/// <exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different evidences. </exception>
		// Token: 0x06000E1D RID: 3613 RVA: 0x0003C230 File Offset: 0x0003A430
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Assembly Load(string assemblyString)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return this.Load(assemblyString, null, false, ref stackCrawlMark);
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x0003C24A File Offset: 0x0003A44A
		internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly, ref StackCrawlMark stackMark)
		{
			if (assemblyString == null)
			{
				throw new ArgumentNullException("assemblyString");
			}
			if (assemblyString.Length == 0)
			{
				throw new ArgumentException("assemblyString cannot have zero length");
			}
			Assembly assembly = this.LoadAssembly(assemblyString, assemblySecurity, refonly, ref stackMark);
			if (assembly == null)
			{
				throw new FileNotFoundException(null, assemblyString);
			}
			return assembly;
		}

		// Token: 0x06000E1F RID: 3615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AppDomain InternalSetDomainByID(int domain_id);

		// Token: 0x06000E20 RID: 3616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AppDomain InternalSetDomain(AppDomain context);

		// Token: 0x06000E21 RID: 3617
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalPushDomainRef(AppDomain domain);

		// Token: 0x06000E22 RID: 3618
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalPushDomainRefByID(int domain_id);

		// Token: 0x06000E23 RID: 3619
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalPopDomainRef();

		// Token: 0x06000E24 RID: 3620
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Context InternalSetContext(Context context);

		// Token: 0x06000E25 RID: 3621
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Context InternalGetContext();

		// Token: 0x06000E26 RID: 3622
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Context InternalGetDefaultContext();

		// Token: 0x06000E27 RID: 3623
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string InternalGetProcessGuid(string newguid);

		// Token: 0x06000E28 RID: 3624 RVA: 0x0003C28C File Offset: 0x0003A48C
		internal static object InvokeInDomain(AppDomain domain, MethodInfo method, object obj, object[] args)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			bool flag = false;
			object result;
			try
			{
				AppDomain.InternalPushDomainRef(domain);
				flag = true;
				AppDomain.InternalSetDomain(domain);
				Exception ex;
				object obj2 = ((RuntimeMethodInfo)method).InternalInvoke(obj, args, out ex);
				if (ex != null)
				{
					throw ex;
				}
				result = obj2;
			}
			finally
			{
				AppDomain.InternalSetDomain(currentDomain);
				if (flag)
				{
					AppDomain.InternalPopDomainRef();
				}
			}
			return result;
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x0003C2E8 File Offset: 0x0003A4E8
		internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			bool flag = false;
			object result;
			try
			{
				AppDomain.InternalPushDomainRefByID(domain_id);
				flag = true;
				AppDomain.InternalSetDomainByID(domain_id);
				Exception ex;
				object obj2 = ((RuntimeMethodInfo)method).InternalInvoke(obj, args, out ex);
				if (ex != null)
				{
					throw ex;
				}
				result = obj2;
			}
			finally
			{
				AppDomain.InternalSetDomain(currentDomain);
				if (flag)
				{
					AppDomain.InternalPopDomainRef();
				}
			}
			return result;
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x0003C344 File Offset: 0x0003A544
		internal static string GetProcessGuid()
		{
			if (AppDomain._process_guid == null)
			{
				AppDomain._process_guid = AppDomain.InternalGetProcessGuid(Guid.NewGuid().ToString());
			}
			return AppDomain._process_guid;
		}

		/// <summary>Creates a new application domain with the specified name.</summary>
		/// <param name="friendlyName">The friendly name of the domain. </param>
		/// <returns>The newly created application domain.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="friendlyName" /> is <see langword="null" />. </exception>
		// Token: 0x06000E2B RID: 3627 RVA: 0x0003C37A File Offset: 0x0003A57A
		public static AppDomain CreateDomain(string friendlyName)
		{
			return AppDomain.CreateDomain(friendlyName, null, null);
		}

		/// <summary>Creates a new application domain with the given name using the supplied evidence.</summary>
		/// <param name="friendlyName">The friendly name of the domain. This friendly name can be displayed in user interfaces to identify the domain. For more information, see <see cref="P:System.AppDomain.FriendlyName" />. </param>
		/// <param name="securityInfo">Evidence that establishes the identity of the code that runs in the application domain. Pass <see langword="null" /> to use the evidence of the current application domain.</param>
		/// <returns>The newly created application domain.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="friendlyName" /> is <see langword="null" />. </exception>
		// Token: 0x06000E2C RID: 3628 RVA: 0x0003C384 File Offset: 0x0003A584
		public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo)
		{
			return AppDomain.CreateDomain(friendlyName, securityInfo, null);
		}

		// Token: 0x06000E2D RID: 3629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AppDomain createDomain(string friendlyName, AppDomainSetup info);

		/// <summary>Creates a new application domain using the specified name, evidence, and application domain setup information.</summary>
		/// <param name="friendlyName">The friendly name of the domain. This friendly name can be displayed in user interfaces to identify the domain. For more information, see <see cref="P:System.AppDomain.FriendlyName" />. </param>
		/// <param name="securityInfo">Evidence that establishes the identity of the code that runs in the application domain. Pass <see langword="null" /> to use the evidence of the current application domain.</param>
		/// <param name="info">An object that contains application domain initialization information. </param>
		/// <returns>The newly created application domain.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="friendlyName" /> is <see langword="null" />. </exception>
		// Token: 0x06000E2E RID: 3630 RVA: 0x0003C390 File Offset: 0x0003A590
		public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup info)
		{
			if (friendlyName == null)
			{
				throw new ArgumentNullException("friendlyName");
			}
			AppDomain defaultDomain = AppDomain.DefaultDomain;
			if (info == null)
			{
				if (defaultDomain == null)
				{
					info = new AppDomainSetup();
				}
				else
				{
					info = defaultDomain.SetupInformation;
				}
			}
			else
			{
				info = new AppDomainSetup(info);
			}
			if (defaultDomain != null)
			{
				if (!info.Equals(defaultDomain.SetupInformation))
				{
					if (info.ApplicationBase == null)
					{
						info.ApplicationBase = defaultDomain.SetupInformation.ApplicationBase;
					}
					if (info.ConfigurationFile == null)
					{
						info.ConfigurationFile = Path.GetFileName(defaultDomain.SetupInformation.ConfigurationFile);
					}
				}
			}
			else if (info.ConfigurationFile == null)
			{
				info.ConfigurationFile = "[I don't have a config file]";
			}
			info.SerializeNonPrimitives();
			AppDomain appDomain = (AppDomain)RemotingServices.GetDomainProxy(AppDomain.createDomain(friendlyName, info));
			if (securityInfo == null)
			{
				if (defaultDomain == null)
				{
					appDomain._evidence = null;
				}
				else
				{
					appDomain._evidence = defaultDomain.Evidence;
				}
			}
			else
			{
				appDomain._evidence = new Evidence(securityInfo);
			}
			return appDomain;
		}

		/// <summary>Creates a new application domain with the given name, using evidence, application base path, relative search path, and a parameter that specifies whether a shadow copy of an assembly is to be loaded into the application domain.</summary>
		/// <param name="friendlyName">The friendly name of the domain. This friendly name can be displayed in user interfaces to identify the domain. For more information, see <see cref="P:System.AppDomain.FriendlyName" />. </param>
		/// <param name="securityInfo">Evidence that establishes the identity of the code that runs in the application domain. Pass <see langword="null" /> to use the evidence of the current application domain.</param>
		/// <param name="appBasePath">The base directory that the assembly resolver uses to probe for assemblies. For more information, see <see cref="P:System.AppDomain.BaseDirectory" />. </param>
		/// <param name="appRelativeSearchPath">The path relative to the base directory where the assembly resolver should probe for private assemblies. For more information, see <see cref="P:System.AppDomain.RelativeSearchPath" />. </param>
		/// <param name="shadowCopyFiles">If <see langword="true" />, a shadow copy of an assembly is loaded into this application domain. </param>
		/// <returns>The newly created application domain.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="friendlyName" /> is <see langword="null" />. </exception>
		// Token: 0x06000E2F RID: 3631 RVA: 0x0003C471 File Offset: 0x0003A671
		public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles)
		{
			return AppDomain.CreateDomain(friendlyName, securityInfo, AppDomain.CreateDomainSetup(appBasePath, appRelativeSearchPath, shadowCopyFiles));
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0003C484 File Offset: 0x0003A684
		private static AppDomainSetup CreateDomainSetup(string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles)
		{
			AppDomainSetup appDomainSetup = new AppDomainSetup();
			appDomainSetup.ApplicationBase = appBasePath;
			appDomainSetup.PrivateBinPath = appRelativeSearchPath;
			if (shadowCopyFiles)
			{
				appDomainSetup.ShadowCopyFiles = "true";
			}
			else
			{
				appDomainSetup.ShadowCopyFiles = "false";
			}
			return appDomainSetup;
		}

		// Token: 0x06000E31 RID: 3633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool InternalIsFinalizingForUnload(int domain_id);

		/// <summary>Indicates whether this application domain is unloading, and the objects it contains are being finalized by the common language runtime.</summary>
		/// <returns>
		///     <see langword="true" /> if this application domain is unloading and the common language runtime has started invoking finalizers; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000E32 RID: 3634 RVA: 0x0003C4C1 File Offset: 0x0003A6C1
		public bool IsFinalizingForUnload()
		{
			return AppDomain.InternalIsFinalizingForUnload(this.getDomainID());
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0003C4CE File Offset: 0x0003A6CE
		private int getDomainID()
		{
			return Thread.GetDomainID();
		}

		/// <summary>Obtains a string representation that includes the friendly name of the application domain and any context policies.</summary>
		/// <returns>A string formed by concatenating the literal string "Name:", the friendly name of the application domain, and either string representations of the context policies or the string "There are no context policies."</returns>
		/// <exception cref="T:System.AppDomainUnloadedException">The application domain represented by the current <see cref="T:System.AppDomain" /> has been unloaded.</exception>
		// Token: 0x06000E34 RID: 3636 RVA: 0x0003C4D5 File Offset: 0x0003A6D5
		public override string ToString()
		{
			return this.getFriendlyName();
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0003C4E0 File Offset: 0x0003A6E0
		private static void ValidateAssemblyName(string name)
		{
			if (name == null || name.Length == 0)
			{
				throw new ArgumentException("The Name of AssemblyName cannot be null or a zero-length string.");
			}
			bool flag = true;
			for (int i = 0; i < name.Length; i++)
			{
				char c = name[i];
				if (i == 0 && char.IsWhiteSpace(c))
				{
					flag = false;
					break;
				}
				if (c == '/' || c == '\\' || c == ':')
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				throw new ArgumentException("The Name of AssemblyName cannot start with whitespace, or contain '/', '\\'  or ':'.");
			}
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0003C54E File Offset: 0x0003A74E
		private void DoAssemblyLoad(Assembly assembly)
		{
			if (this.AssemblyLoad == null)
			{
				return;
			}
			this.AssemblyLoad(this, new AssemblyLoadEventArgs(assembly));
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x0003C56C File Offset: 0x0003A76C
		private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly)
		{
			ResolveEventHandler resolveEventHandler;
			if (refonly)
			{
				resolveEventHandler = this.ReflectionOnlyAssemblyResolve;
			}
			else
			{
				resolveEventHandler = this.AssemblyResolve;
			}
			if (resolveEventHandler == null)
			{
				return null;
			}
			Dictionary<string, object> dictionary;
			if (refonly)
			{
				dictionary = AppDomain.assembly_resolve_in_progress_refonly;
				if (dictionary == null)
				{
					dictionary = new Dictionary<string, object>();
					AppDomain.assembly_resolve_in_progress_refonly = dictionary;
				}
			}
			else
			{
				dictionary = AppDomain.assembly_resolve_in_progress;
				if (dictionary == null)
				{
					dictionary = new Dictionary<string, object>();
					AppDomain.assembly_resolve_in_progress = dictionary;
				}
			}
			if (dictionary.ContainsKey(name))
			{
				return null;
			}
			dictionary[name] = null;
			Assembly result;
			try
			{
				Delegate[] invocationList = resolveEventHandler.GetInvocationList();
				for (int i = 0; i < invocationList.Length; i++)
				{
					Assembly assembly = ((ResolveEventHandler)invocationList[i])(this, new ResolveEventArgs(name, requestingAssembly));
					if (assembly != null)
					{
						return assembly;
					}
				}
				result = null;
			}
			finally
			{
				dictionary.Remove(name);
			}
			return result;
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x0003C630 File Offset: 0x0003A830
		internal Assembly DoTypeBuilderResolve(TypeBuilder tb)
		{
			if (this.TypeResolve == null)
			{
				return null;
			}
			return this.DoTypeResolve(tb.FullName);
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0003C648 File Offset: 0x0003A848
		internal Assembly DoTypeResolve(string name)
		{
			if (this.TypeResolve == null)
			{
				return null;
			}
			Dictionary<string, object> dictionary = AppDomain.type_resolve_in_progress;
			if (dictionary == null)
			{
				dictionary = (AppDomain.type_resolve_in_progress = new Dictionary<string, object>());
			}
			if (dictionary.ContainsKey(name))
			{
				return null;
			}
			dictionary[name] = null;
			Assembly result;
			try
			{
				Delegate[] invocationList = this.TypeResolve.GetInvocationList();
				for (int i = 0; i < invocationList.Length; i++)
				{
					Assembly assembly = ((ResolveEventHandler)invocationList[i])(this, new ResolveEventArgs(name));
					if (assembly != null)
					{
						return assembly;
					}
				}
				result = null;
			}
			finally
			{
				dictionary.Remove(name);
			}
			return result;
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0003C6E4 File Offset: 0x0003A8E4
		private void DoDomainUnload()
		{
			if (this.DomainUnload != null)
			{
				this.DomainUnload(this, null);
			}
		}

		// Token: 0x06000E3B RID: 3643
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void DoUnhandledException(Exception e);

		// Token: 0x06000E3C RID: 3644 RVA: 0x0003C6FB File Offset: 0x0003A8FB
		internal void DoUnhandledException(UnhandledExceptionEventArgs args)
		{
			if (this.UnhandledException != null)
			{
				this.UnhandledException(this, args);
			}
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x0003C712 File Offset: 0x0003A912
		internal byte[] GetMarshalledDomainObjRef()
		{
			return CADSerializer.SerializeObject(RemotingServices.Marshal(AppDomain.CurrentDomain, null, typeof(AppDomain))).GetBuffer();
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0003C734 File Offset: 0x0003A934
		internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm)
		{
			IMessage msg;
			if (arrRequest != null)
			{
				msg = CADSerializer.DeserializeMessage(new MemoryStream(arrRequest), null);
			}
			else
			{
				msg = new MethodCall(cadMsg);
			}
			IMessage message = ChannelServices.SyncDispatchMessage(msg);
			cadMrm = CADMethodReturnMessage.Create(message);
			if (cadMrm == null)
			{
				arrResponse = CADSerializer.SerializeMessage(message).GetBuffer();
				return;
			}
			arrResponse = null;
		}

		/// <summary>Occurs when an <see cref="T:System.AppDomain" /> is about to be unloaded.</summary>
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000E3F RID: 3647 RVA: 0x0003C780 File Offset: 0x0003A980
		// (remove) Token: 0x06000E40 RID: 3648 RVA: 0x0003C7B8 File Offset: 0x0003A9B8
		public event EventHandler DomainUnload;

		/// <summary>Gets a value that indicates whether the current application domain has a set of permissions that is granted to all assemblies that are loaded into the application domain.</summary>
		/// <returns>
		///     <see langword="true" /> if the current application domain has a homogenous set of permissions; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x0000B18D File Offset: 0x0000938D
		public bool IsHomogenous
		{
			get
			{
				return true;
			}
		}

		/// <summary>Gets a value that indicates whether assemblies that are loaded into the current application domain execute with full trust.</summary>
		/// <returns>
		///     <see langword="true" /> if assemblies that are loaded into the current application domain execute with full trust; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x0000B18D File Offset: 0x0000938D
		public bool IsFullyTrusted
		{
			get
			{
				return true;
			}
		}

		/// <summary>Creates a new application domain with the given name, using evidence, application base path, relative search path, and a parameter that specifies whether a shadow copy of an assembly is to be loaded into the application domain. Specifies a callback method that is invoked when the application domain is initialized, and an array of string arguments to pass the callback method.</summary>
		/// <param name="friendlyName">The friendly name of the domain. This friendly name can be displayed in user interfaces to identify the domain. For more information, see <see cref="P:System.AppDomain.FriendlyName" />. </param>
		/// <param name="securityInfo">Evidence that establishes the identity of the code that runs in the application domain. Pass <see langword="null" /> to use the evidence of the current application domain.</param>
		/// <param name="appBasePath">The base directory that the assembly resolver uses to probe for assemblies. For more information, see <see cref="P:System.AppDomain.BaseDirectory" />. </param>
		/// <param name="appRelativeSearchPath">The path relative to the base directory where the assembly resolver should probe for private assemblies. For more information, see <see cref="P:System.AppDomain.RelativeSearchPath" />. </param>
		/// <param name="shadowCopyFiles">
		///       <see langword="true" /> to load a shadow copy of an assembly into the application domain. </param>
		/// <param name="adInit">An <see cref="T:System.AppDomainInitializer" /> delegate that represents a callback method to invoke when the new <see cref="T:System.AppDomain" /> object is initialized.</param>
		/// <param name="adInitArgs">An array of string arguments to be passed to the callback represented by <paramref name="adInit" />, when the new <see cref="T:System.AppDomain" /> object is initialized.</param>
		/// <returns>The newly created application domain.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="friendlyName" /> is <see langword="null" />. </exception>
		// Token: 0x06000E43 RID: 3651 RVA: 0x0003C7F0 File Offset: 0x0003A9F0
		public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles, AppDomainInitializer adInit, string[] adInitArgs)
		{
			AppDomainSetup appDomainSetup = AppDomain.CreateDomainSetup(appBasePath, appRelativeSearchPath, shadowCopyFiles);
			appDomainSetup.AppDomainInitializerArguments = adInitArgs;
			appDomainSetup.AppDomainInitializer = adInit;
			return AppDomain.CreateDomain(friendlyName, securityInfo, appDomainSetup);
		}

		// Token: 0x04000505 RID: 1285
		private IntPtr _mono_app_domain;

		// Token: 0x04000506 RID: 1286
		private static string _process_guid;

		// Token: 0x04000507 RID: 1287
		[ThreadStatic]
		private static Dictionary<string, object> type_resolve_in_progress;

		// Token: 0x04000508 RID: 1288
		[ThreadStatic]
		private static Dictionary<string, object> assembly_resolve_in_progress;

		// Token: 0x04000509 RID: 1289
		[ThreadStatic]
		private static Dictionary<string, object> assembly_resolve_in_progress_refonly;

		// Token: 0x0400050A RID: 1290
		private object _evidence;

		// Token: 0x0400050B RID: 1291
		private object _granted;

		// Token: 0x0400050C RID: 1292
		private int _principalPolicy;

		// Token: 0x0400050D RID: 1293
		[ThreadStatic]
		private static object _principal;

		// Token: 0x0400050E RID: 1294
		private static AppDomain default_domain;

		// Token: 0x0400050F RID: 1295
		[CompilerGenerated]
		private AssemblyLoadEventHandler AssemblyLoad;

		// Token: 0x04000510 RID: 1296
		[CompilerGenerated]
		private ResolveEventHandler AssemblyResolve;

		// Token: 0x04000512 RID: 1298
		[CompilerGenerated]
		private EventHandler ProcessExit;

		// Token: 0x04000513 RID: 1299
		[CompilerGenerated]
		private ResolveEventHandler ResourceResolve;

		// Token: 0x04000514 RID: 1300
		[CompilerGenerated]
		private ResolveEventHandler TypeResolve;

		// Token: 0x04000515 RID: 1301
		[CompilerGenerated]
		private UnhandledExceptionEventHandler UnhandledException;

		// Token: 0x04000516 RID: 1302
		[CompilerGenerated]
		private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException;

		// Token: 0x04000517 RID: 1303
		private object _domain_manager;

		// Token: 0x04000518 RID: 1304
		[CompilerGenerated]
		private ResolveEventHandler ReflectionOnlyAssemblyResolve;

		// Token: 0x04000519 RID: 1305
		private object _activation;

		// Token: 0x0400051A RID: 1306
		private object _applicationIdentity;

		// Token: 0x0400051B RID: 1307
		private List<string> compatibility_switch;
	}
}
