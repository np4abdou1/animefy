using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Mono.Security;

namespace System.Reflection.Emit
{
	/// <summary>Defines and represents a dynamic assembly.</summary>
	// Token: 0x020004EF RID: 1263
	[StructLayout(0)]
	public sealed class AssemblyBuilder : Assembly
	{
		// Token: 0x06002446 RID: 9286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void basic_init(AssemblyBuilder ab);

		// Token: 0x06002447 RID: 9287 RVA: 0x0008F058 File Offset: 0x0008D258
		internal AssemblyBuilder(AssemblyName n, string directory, AssemblyBuilderAccess access, bool corlib_internal)
		{
			if ((access & (AssemblyBuilderAccess)2048) != (AssemblyBuilderAccess)0)
			{
				throw new NotImplementedException("COMPILER_ACCESS is no longer supperted, use a newer mcs.");
			}
			if (!Enum.IsDefined(typeof(AssemblyBuilderAccess), access))
			{
				throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Argument value {0} is not valid.", (int)access), "access");
			}
			this.name = n.Name;
			this.access = (uint)access;
			this.flags = (uint)n.Flags;
			if (this.IsSave && (directory == null || directory.Length == 0))
			{
				this.dir = Directory.GetCurrentDirectory();
			}
			else
			{
				this.dir = directory;
			}
			if (n.CultureInfo != null)
			{
				this.culture = n.CultureInfo.Name;
				this.versioninfo_culture = n.CultureInfo.Name;
			}
			Version version = n.Version;
			if (version != null)
			{
				this.version = version.ToString();
			}
			if (n.KeyPair != null)
			{
				this.sn = n.KeyPair.StrongName();
			}
			else
			{
				byte[] publicKey = n.GetPublicKey();
				if (publicKey != null && publicKey.Length != 0)
				{
					this.sn = new StrongName(publicKey);
				}
			}
			if (this.sn != null)
			{
				this.flags |= 1U;
			}
			this.corlib_internal = corlib_internal;
			if (this.sn != null)
			{
				this.pktoken = new byte[this.sn.PublicKeyToken.Length * 2];
				int num = 0;
				foreach (byte b in this.sn.PublicKeyToken)
				{
					string text = b.ToString("x2");
					this.pktoken[num++] = (byte)text[0];
					this.pktoken[num++] = (byte)text[1];
				}
			}
			AssemblyBuilder.basic_init(this);
		}

		/// <summary>Gets the location of the assembly, as specified originally (such as in an <see cref="T:System.Reflection.AssemblyName" /> object).</summary>
		/// <returns>The location of the assembly, as specified originally.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x0008F262 File Offset: 0x0008D462
		public override string CodeBase
		{
			get
			{
				throw this.not_supported();
			}
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x00002A7D File Offset: 0x00000C7D
		internal void AddPermissionRequests(PermissionSet required, PermissionSet optional, PermissionSet refused)
		{
		}

		/// <summary>Defines a named transient dynamic module in this assembly.</summary>
		/// <param name="name">The name of the dynamic module. Must be less than 260 characters in length. </param>
		/// <returns>A <see cref="T:System.Reflection.Emit.ModuleBuilder" /> representing the defined dynamic module.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="name" /> begins with white space.-or- The length of <paramref name="name" /> is zero.-or- The length of <paramref name="name" /> is greater than or equal to 260. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ExecutionEngineException">The assembly for default symbol writer cannot be loaded.-or- The type that implements the default symbol writer interface cannot be found. </exception>
		// Token: 0x0600244A RID: 9290 RVA: 0x0008F26A File Offset: 0x0008D46A
		public ModuleBuilder DefineDynamicModule(string name)
		{
			return this.DefineDynamicModule(name, name, false, true);
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x0008F278 File Offset: 0x0008D478
		private ModuleBuilder DefineDynamicModule(string name, string fileName, bool emitSymbolInfo, bool transient)
		{
			this.check_name_and_filename(name, fileName, false);
			if (!transient)
			{
				if (Path.GetExtension(fileName) == string.Empty)
				{
					throw new ArgumentException("Module file name '" + fileName + "' must have file extension.");
				}
				if (!this.IsSave)
				{
					throw new NotSupportedException("Persistable modules are not supported in a dynamic assembly created with AssemblyBuilderAccess.Run");
				}
				if (this.created)
				{
					throw new InvalidOperationException("Assembly was already saved.");
				}
			}
			ModuleBuilder moduleBuilder = new ModuleBuilder(this, name, fileName, emitSymbolInfo, transient);
			if (this.modules != null && this.is_module_only)
			{
				throw new InvalidOperationException("A module-only assembly can only contain one module.");
			}
			if (this.modules != null)
			{
				ModuleBuilder[] destinationArray = new ModuleBuilder[this.modules.Length + 1];
				Array.Copy(this.modules, destinationArray, this.modules.Length);
				this.modules = destinationArray;
			}
			else
			{
				this.modules = new ModuleBuilder[1];
			}
			this.modules[this.modules.Length - 1] = moduleBuilder;
			return moduleBuilder;
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x0008F35B File Offset: 0x0008D55B
		internal override Module[] GetModulesInternal()
		{
			if (this.modules == null)
			{
				return new Module[0];
			}
			return (Module[])this.modules.Clone();
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x0008F37C File Offset: 0x0008D57C
		internal override Type[] GetTypes(bool exportedOnly)
		{
			Type[] array = null;
			if (this.modules != null)
			{
				for (int i = 0; i < this.modules.Length; i++)
				{
					Type[] types = this.modules[i].GetTypes();
					if (array == null)
					{
						array = types;
					}
					else
					{
						Type[] destinationArray = new Type[array.Length + types.Length];
						Array.Copy(array, 0, destinationArray, 0, array.Length);
						Array.Copy(types, 0, destinationArray, array.Length, types.Length);
					}
				}
			}
			if (this.loaded_modules != null)
			{
				for (int j = 0; j < this.loaded_modules.Length; j++)
				{
					Type[] types2 = this.loaded_modules[j].GetTypes();
					if (array == null)
					{
						array = types2;
					}
					else
					{
						Type[] destinationArray2 = new Type[array.Length + types2.Length];
						Array.Copy(array, 0, destinationArray2, 0, array.Length);
						Array.Copy(types2, 0, destinationArray2, array.Length, types2.Length);
					}
				}
			}
			if (array != null)
			{
				List<Exception> list = null;
				foreach (Type type in array)
				{
					if (type is TypeBuilder)
					{
						if (list == null)
						{
							list = new List<Exception>();
						}
						list.Add(new TypeLoadException(string.Format("Type '{0}' is not finished", type.FullName)));
					}
				}
				if (list != null)
				{
					throw new ReflectionTypeLoadException(new Type[list.Count], list.ToArray());
				}
			}
			if (array != null)
			{
				return array;
			}
			return Type.EmptyTypes;
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x0600244E RID: 9294 RVA: 0x0008F4C1 File Offset: 0x0008D6C1
		internal bool IsSave
		{
			get
			{
				return this.access != 1U;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x0600244F RID: 9295 RVA: 0x0008F4CF File Offset: 0x0008D6CF
		internal bool IsRun
		{
			get
			{
				return this.access == 1U || this.access == 3U || this.access == 9U;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06002450 RID: 9296 RVA: 0x0008F4EF File Offset: 0x0008D6EF
		internal string AssemblyDir
		{
			get
			{
				return this.dir;
			}
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x0008F4F7 File Offset: 0x0008D6F7
		internal override Module GetManifestModule()
		{
			if (this.manifest_module == null)
			{
				this.manifest_module = this.DefineDynamicModule("Default Dynamic Module");
			}
			return this.manifest_module;
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x0008F51E File Offset: 0x0008D71E
		private Exception not_supported()
		{
			return new NotSupportedException("The invoked member is not supported in a dynamic module.");
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x0008F52C File Offset: 0x0008D72C
		private void check_name_and_filename(string name, string fileName, bool fileNeedsToExists)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (fileName == null)
			{
				throw new ArgumentNullException("fileName");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("Empty name is not legal.", "name");
			}
			if (fileName.Length == 0)
			{
				throw new ArgumentException("Empty file name is not legal.", "fileName");
			}
			if (Path.GetFileName(fileName) != fileName)
			{
				throw new ArgumentException("fileName '" + fileName + "' must not include a path.", "fileName");
			}
			string text = fileName;
			if (this.dir != null)
			{
				text = Path.Combine(this.dir, fileName);
			}
			if (fileNeedsToExists && !File.Exists(text))
			{
				throw new FileNotFoundException("Could not find file '" + fileName + "'");
			}
			if (this.resources != null)
			{
				for (int i = 0; i < this.resources.Length; i++)
				{
					if (this.resources[i].filename == text)
					{
						throw new ArgumentException("Duplicate file name '" + fileName + "'");
					}
					if (this.resources[i].name == name)
					{
						throw new ArgumentException("Duplicate name '" + name + "'");
					}
				}
			}
			if (this.modules != null)
			{
				for (int j = 0; j < this.modules.Length; j++)
				{
					if (!this.modules[j].IsTransient() && this.modules[j].FileName == fileName)
					{
						throw new ArgumentException("Duplicate file name '" + fileName + "'");
					}
					if (this.modules[j].Name == name)
					{
						throw new ArgumentException("Duplicate name '" + name + "'");
					}
				}
			}
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x0008F6DF File Offset: 0x0008D8DF
		internal Type MakeGenericType(Type gtd, Type[] typeArguments)
		{
			return new TypeBuilderInstantiation(gtd, typeArguments);
		}

		/// <summary>Gets the specified type from the types that have been defined and created in the current <see cref="T:System.Reflection.Emit.AssemblyBuilder" />.</summary>
		/// <param name="name">The name of the type to search for.</param>
		/// <param name="throwOnError">
		///       <see langword="true" /> to throw an exception if the type is not found; otherwise, <see langword="false" />.</param>
		/// <param name="ignoreCase">
		///       <see langword="true" /> to ignore the case of the type name when searching; otherwise, <see langword="false" />.</param>
		/// <returns>The specified type, or <see langword="null" /> if the type is not found or has not been created yet. </returns>
		// Token: 0x06002455 RID: 9301 RVA: 0x0008F6E8 File Offset: 0x0008D8E8
		public override Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
			if (name == null)
			{
				throw new ArgumentNullException(name);
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("name", "Name cannot be empty");
			}
			Type type = base.InternalGetType(null, name, throwOnError, ignoreCase);
			if (!(type is TypeBuilder))
			{
				return type;
			}
			if (throwOnError)
			{
				throw new TypeLoadException(string.Format("Could not load type '{0}' from assembly '{1}'", name, this.name));
			}
			return null;
		}

		/// <summary>Gets the specified module in this assembly.</summary>
		/// <param name="name">The name of the requested module.</param>
		/// <returns>The module being requested, or <see langword="null" /> if the module is not found.</returns>
		// Token: 0x06002456 RID: 9302 RVA: 0x0008F748 File Offset: 0x0008D948
		public override Module GetModule(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("Name can't be empty");
			}
			if (this.modules == null)
			{
				return null;
			}
			foreach (ModuleBuilder module in this.modules)
			{
				if (module.ScopeName == name)
				{
					return module;
				}
			}
			return null;
		}

		/// <summary>Gets all the modules that are part of this assembly, and optionally includes resource modules.</summary>
		/// <param name="getResourceModules">
		///       <see langword="true" /> to include resource modules; otherwise, <see langword="false" />.</param>
		/// <returns>The modules that are part of this assembly.</returns>
		// Token: 0x06002457 RID: 9303 RVA: 0x0008F7AC File Offset: 0x0008D9AC
		public override Module[] GetModules(bool getResourceModules)
		{
			Module[] modulesInternal = this.GetModulesInternal();
			if (!getResourceModules)
			{
				List<Module> list = new List<Module>(modulesInternal.Length);
				foreach (Module module in modulesInternal)
				{
					if (!module.IsResource())
					{
						list.Add(module);
					}
				}
				return list.ToArray();
			}
			return modulesInternal;
		}

		/// <summary>Gets the <see cref="T:System.Reflection.AssemblyName" /> that was specified when the current dynamic assembly was created, and sets the code base as specified.</summary>
		/// <param name="copiedName">
		///       <see langword="true" /> to set the code base to the location of the assembly after it is shadow-copied; <see langword="false" /> to set the code base to the original location.</param>
		/// <returns>The name of the dynamic assembly.</returns>
		// Token: 0x06002458 RID: 9304 RVA: 0x0008F7FC File Offset: 0x0008D9FC
		public override AssemblyName GetName(bool copiedName)
		{
			AssemblyName assemblyName = AssemblyName.Create(this, false);
			if (this.sn != null)
			{
				assemblyName.SetPublicKey(this.sn.PublicKey);
				assemblyName.SetPublicKeyToken(this.sn.PublicKeyToken);
			}
			return assemblyName;
		}

		/// <summary>Returns a value that indicates whether this instance is equal to the specified object.</summary>
		/// <param name="obj">An object to compare with this instance, or <see langword="null" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> equals the type and value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002459 RID: 9305 RVA: 0x0008F83C File Offset: 0x0008DA3C
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x0600245A RID: 9306 RVA: 0x0008D07D File Offset: 0x0008B27D
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x0008F845 File Offset: 0x0008DA45
		public override string ToString()
		{
			if (this.assemblyName != null)
			{
				return this.assemblyName;
			}
			this.assemblyName = this.FullName;
			return this.assemblyName;
		}

		/// <summary>Returns a value that indicates whether one or more instances of the specified attribute type is applied to this member.</summary>
		/// <param name="attributeType">The type of attribute to test for.</param>
		/// <param name="inherit">This argument is ignored for objects of this type.</param>
		/// <returns>
		///     <see langword="true" /> if one or more instances of <paramref name="attributeType" /> is applied to this dynamic assembly; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600245C RID: 9308 RVA: 0x00032332 File Offset: 0x00030532
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.IsDefined(this, attributeType, inherit);
		}

		/// <summary>Returns all the custom attributes that have been applied to the current <see cref="T:System.Reflection.Emit.AssemblyBuilder" />.</summary>
		/// <param name="inherit">This argument is ignored for objects of this type.</param>
		/// <returns>An array that contains the custom attributes; the array is empty if there are no attributes.</returns>
		// Token: 0x0600245D RID: 9309 RVA: 0x0008D062 File Offset: 0x0008B262
		public override object[] GetCustomAttributes(bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, inherit);
		}

		/// <summary>Returns all the custom attributes that have been applied to the current <see cref="T:System.Reflection.Emit.AssemblyBuilder" />, and that derive from a specified attribute type.</summary>
		/// <param name="attributeType">The base type from which attributes derive.</param>
		/// <param name="inherit">This argument is ignored for objects of this type.</param>
		/// <returns>An array that contains the custom attributes that are derived at any level from <paramref name="attributeType" />; the array is empty if there are no such attributes.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not a <see cref="T:System.Type" /> object supplied by the runtime. For example, <paramref name="attributeType" /> is a <see cref="T:System.Reflection.Emit.TypeBuilder" /> object.</exception>
		// Token: 0x0600245E RID: 9310 RVA: 0x0008D06B File Offset: 0x0008B26B
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, attributeType, inherit);
		}

		/// <summary>Gets the display name of the current dynamic assembly. </summary>
		/// <returns>The display name of the dynamic assembly.</returns>
		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600245F RID: 9311 RVA: 0x0008D052 File Offset: 0x0008B252
		public override string FullName
		{
			get
			{
				return RuntimeAssembly.get_fullname(this);
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x0008F868 File Offset: 0x0008DA68
		internal override IntPtr MonoAssembly
		{
			get
			{
				return this._mono_assembly;
			}
		}

		// Token: 0x040011AA RID: 4522
		internal IntPtr _mono_assembly;

		// Token: 0x040011AB RID: 4523
		private object _evidence;

		// Token: 0x040011AC RID: 4524
		private UIntPtr dynamic_assembly;

		// Token: 0x040011AD RID: 4525
		private MethodInfo entry_point;

		// Token: 0x040011AE RID: 4526
		private ModuleBuilder[] modules;

		// Token: 0x040011AF RID: 4527
		private string name;

		// Token: 0x040011B0 RID: 4528
		private string dir;

		// Token: 0x040011B1 RID: 4529
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x040011B2 RID: 4530
		private MonoResource[] resources;

		// Token: 0x040011B3 RID: 4531
		private byte[] public_key;

		// Token: 0x040011B4 RID: 4532
		private string version;

		// Token: 0x040011B5 RID: 4533
		private string culture;

		// Token: 0x040011B6 RID: 4534
		private uint algid;

		// Token: 0x040011B7 RID: 4535
		private uint flags;

		// Token: 0x040011B8 RID: 4536
		private PEFileKinds pekind = PEFileKinds.Dll;

		// Token: 0x040011B9 RID: 4537
		private bool delay_sign;

		// Token: 0x040011BA RID: 4538
		private uint access;

		// Token: 0x040011BB RID: 4539
		private Module[] loaded_modules;

		// Token: 0x040011BC RID: 4540
		private MonoWin32Resource[] win32_resources;

		// Token: 0x040011BD RID: 4541
		private RefEmitPermissionSet[] permissions_minimum;

		// Token: 0x040011BE RID: 4542
		private RefEmitPermissionSet[] permissions_optional;

		// Token: 0x040011BF RID: 4543
		private RefEmitPermissionSet[] permissions_refused;

		// Token: 0x040011C0 RID: 4544
		private PortableExecutableKinds peKind;

		// Token: 0x040011C1 RID: 4545
		private ImageFileMachine machine;

		// Token: 0x040011C2 RID: 4546
		private bool corlib_internal;

		// Token: 0x040011C3 RID: 4547
		private Type[] type_forwarders;

		// Token: 0x040011C4 RID: 4548
		private byte[] pktoken;

		// Token: 0x040011C5 RID: 4549
		private object _minimum;

		// Token: 0x040011C6 RID: 4550
		private object _optional;

		// Token: 0x040011C7 RID: 4551
		private object _refuse;

		// Token: 0x040011C8 RID: 4552
		private object _granted;

		// Token: 0x040011C9 RID: 4553
		private object _denied;

		// Token: 0x040011CA RID: 4554
		private string assemblyName;

		// Token: 0x040011CB RID: 4555
		internal Type corlib_object_type = typeof(object);

		// Token: 0x040011CC RID: 4556
		internal Type corlib_value_type = typeof(ValueType);

		// Token: 0x040011CD RID: 4557
		internal Type corlib_enum_type = typeof(Enum);

		// Token: 0x040011CE RID: 4558
		internal Type corlib_void_type = typeof(void);

		// Token: 0x040011CF RID: 4559
		private ArrayList resource_writers;

		// Token: 0x040011D0 RID: 4560
		private Win32VersionResource version_res;

		// Token: 0x040011D1 RID: 4561
		private bool created;

		// Token: 0x040011D2 RID: 4562
		private bool is_module_only;

		// Token: 0x040011D3 RID: 4563
		private StrongName sn;

		// Token: 0x040011D4 RID: 4564
		private NativeResourceType native_resource;

		// Token: 0x040011D5 RID: 4565
		private string versioninfo_culture;

		// Token: 0x040011D6 RID: 4566
		private const AssemblyBuilderAccess COMPILER_ACCESS = (AssemblyBuilderAccess)2048;

		// Token: 0x040011D7 RID: 4567
		private ModuleBuilder manifest_module;
	}
}
