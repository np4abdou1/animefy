using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Defines and represents a module in a dynamic assembly.</summary>
	// Token: 0x0200050E RID: 1294
	[StructLayout(0)]
	public class ModuleBuilder : Module
	{
		// Token: 0x060025C1 RID: 9665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void basic_init(ModuleBuilder ab);

		// Token: 0x060025C2 RID: 9666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void set_wrappers_type(ModuleBuilder mb, Type ab);

		// Token: 0x060025C3 RID: 9667 RVA: 0x00093088 File Offset: 0x00091288
		internal ModuleBuilder(AssemblyBuilder assb, string name, string fullyqname, bool emitSymbolInfo, bool transient)
		{
			this.scopename = name;
			this.name = name;
			this.fqname = fullyqname;
			this.assemblyb = assb;
			this.assembly = assb;
			this.transient = transient;
			this.guid = Guid.FastNewGuidArray();
			this.table_idx = this.get_next_table_index(this, 0, 1);
			this.name_cache = new Dictionary<TypeName, TypeBuilder>();
			this.us_string_cache = new Dictionary<string, int>(512);
			ModuleBuilder.basic_init(this);
			this.CreateGlobalType();
			if (assb.IsRun)
			{
				Type ab = new TypeBuilder(this, TypeAttributes.Abstract, 16777215).CreateType();
				ModuleBuilder.set_wrappers_type(this, ab);
			}
			if (emitSymbolInfo)
			{
				Assembly assembly = Assembly.LoadWithPartialName("Mono.CompilerServices.SymbolWriter");
				Type type = null;
				if (assembly != null)
				{
					type = assembly.GetType("Mono.CompilerServices.SymbolWriter.SymbolWriterImpl");
				}
				if (type == null)
				{
					ModuleBuilder.WarnAboutSymbolWriter("Failed to load the default Mono.CompilerServices.SymbolWriter assembly");
				}
				else
				{
					try
					{
						this.symbolWriter = (ISymbolWriter)Activator.CreateInstance(type, new object[]
						{
							this
						});
					}
					catch (MissingMethodException)
					{
						ModuleBuilder.WarnAboutSymbolWriter("The default Mono.CompilerServices.SymbolWriter is not available on this platform");
						return;
					}
				}
				string text = this.fqname;
				if (this.assemblyb.AssemblyDir != null)
				{
					text = Path.Combine(this.assemblyb.AssemblyDir, text);
				}
				this.symbolWriter.Initialize(IntPtr.Zero, text, true);
			}
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x000931EC File Offset: 0x000913EC
		private static void WarnAboutSymbolWriter(string message)
		{
			if (ModuleBuilder.has_warned_about_symbolWriter)
			{
				return;
			}
			ModuleBuilder.has_warned_about_symbolWriter = true;
			Console.Error.WriteLine("WARNING: {0}", message);
		}

		/// <summary>Returns a value that indicates whether this dynamic module is transient.</summary>
		/// <returns>
		///     <see langword="true" /> if this dynamic module is transient; otherwise, <see langword="false" />.</returns>
		// Token: 0x060025C5 RID: 9669 RVA: 0x0009320C File Offset: 0x0009140C
		public bool IsTransient()
		{
			return this.transient;
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x00093214 File Offset: 0x00091414
		internal int get_next_table_index(object obj, int table, int count)
		{
			if (this.table_indexes == null)
			{
				this.table_indexes = new int[64];
				for (int i = 0; i < 64; i++)
				{
					this.table_indexes[i] = 1;
				}
				this.table_indexes[2] = 2;
			}
			int result = this.table_indexes[table];
			this.table_indexes[table] += count;
			return result;
		}

		/// <summary>Returns all the classes defined within this module.</summary>
		/// <returns>An array that contains the types defined within the module that is reflected by this instance.</returns>
		/// <exception cref="T:System.Reflection.ReflectionTypeLoadException">One or more classes in a module could not be loaded. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x060025C7 RID: 9671 RVA: 0x00093270 File Offset: 0x00091470
		public override Type[] GetTypes()
		{
			if (this.types == null)
			{
				return Type.EmptyTypes;
			}
			int num = this.num_types;
			Type[] array = new Type[num];
			Array.Copy(this.types, array, num);
			for (int i = 0; i < array.Length; i++)
			{
				if (this.types[i].is_created)
				{
					array[i] = this.types[i].CreateType();
				}
			}
			return array;
		}

		// Token: 0x060025C8 RID: 9672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int getUSIndex(ModuleBuilder mb, string str);

		// Token: 0x060025C9 RID: 9673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int getToken(ModuleBuilder mb, object obj, bool create_open_instance);

		// Token: 0x060025CA RID: 9674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int getMethodToken(ModuleBuilder mb, MethodBase method, Type[] opt_param_types);

		// Token: 0x060025CB RID: 9675 RVA: 0x000932D4 File Offset: 0x000914D4
		internal int GetToken(string str)
		{
			int usindex;
			if (!this.us_string_cache.TryGetValue(str, out usindex))
			{
				usindex = ModuleBuilder.getUSIndex(this, str);
				this.us_string_cache[str] = usindex;
			}
			return usindex;
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x00093308 File Offset: 0x00091508
		private int GetPseudoToken(MemberInfo member, bool create_open_instance)
		{
			Dictionary<MemberInfo, int> dictionary = create_open_instance ? this.inst_tokens_open : this.inst_tokens;
			int num;
			if (dictionary == null)
			{
				dictionary = new Dictionary<MemberInfo, int>(ReferenceEqualityComparer<MemberInfo>.Instance);
				if (create_open_instance)
				{
					this.inst_tokens_open = dictionary;
				}
				else
				{
					this.inst_tokens = dictionary;
				}
			}
			else if (dictionary.TryGetValue(member, out num))
			{
				return num;
			}
			if (member is TypeBuilderInstantiation || member is SymbolType)
			{
				num = ModuleBuilder.typespec_tokengen--;
			}
			else if (member is FieldOnTypeBuilderInst)
			{
				num = ModuleBuilder.memberref_tokengen--;
			}
			else if (member is ConstructorOnTypeBuilderInst)
			{
				num = ModuleBuilder.memberref_tokengen--;
			}
			else if (member is MethodOnTypeBuilderInst)
			{
				num = ModuleBuilder.memberref_tokengen--;
			}
			else if (member is FieldBuilder)
			{
				num = ModuleBuilder.memberref_tokengen--;
			}
			else if (member is TypeBuilder)
			{
				if (create_open_instance && (member as TypeBuilder).ContainsGenericParameters)
				{
					num = ModuleBuilder.typespec_tokengen--;
				}
				else if (member.Module == this)
				{
					num = ModuleBuilder.typedef_tokengen--;
				}
				else
				{
					num = ModuleBuilder.typeref_tokengen--;
				}
			}
			else
			{
				if (member is EnumBuilder)
				{
					num = this.GetPseudoToken((member as EnumBuilder).GetTypeBuilder(), create_open_instance);
					dictionary[member] = num;
					return num;
				}
				if (member is ConstructorBuilder)
				{
					if (member.Module == this && !(member as ConstructorBuilder).TypeBuilder.ContainsGenericParameters)
					{
						num = ModuleBuilder.methoddef_tokengen--;
					}
					else
					{
						num = ModuleBuilder.memberref_tokengen--;
					}
				}
				else if (member is MethodBuilder)
				{
					MethodBuilder methodBuilder = member as MethodBuilder;
					if (member.Module == this && !methodBuilder.TypeBuilder.ContainsGenericParameters && !methodBuilder.IsGenericMethodDefinition)
					{
						num = ModuleBuilder.methoddef_tokengen--;
					}
					else
					{
						num = ModuleBuilder.memberref_tokengen--;
					}
				}
				else
				{
					if (!(member is GenericTypeParameterBuilder))
					{
						throw new NotImplementedException();
					}
					num = ModuleBuilder.typespec_tokengen--;
				}
			}
			dictionary[member] = num;
			this.RegisterToken(member, num);
			return num;
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x00093536 File Offset: 0x00091736
		internal int GetToken(MemberInfo member)
		{
			if (member is ConstructorBuilder || member is MethodBuilder || member is FieldBuilder)
			{
				return this.GetPseudoToken(member, false);
			}
			return ModuleBuilder.getToken(this, member, true);
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x00093564 File Offset: 0x00091764
		internal int GetToken(MemberInfo member, bool create_open_instance)
		{
			if (member is TypeBuilderInstantiation || member is FieldOnTypeBuilderInst || member is ConstructorOnTypeBuilderInst || member is MethodOnTypeBuilderInst || member is SymbolType || member is FieldBuilder || member is TypeBuilder || member is ConstructorBuilder || member is MethodBuilder || member is GenericTypeParameterBuilder || member is EnumBuilder)
			{
				return this.GetPseudoToken(member, create_open_instance);
			}
			return ModuleBuilder.getToken(this, member, create_open_instance);
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x000935DA File Offset: 0x000917DA
		internal int GetToken(MethodBase method, Type[] opt_param_types)
		{
			if (method is ConstructorBuilder || method is MethodBuilder)
			{
				return this.GetPseudoToken(method, false);
			}
			return ModuleBuilder.getMethodToken(this, method, opt_param_types);
		}

		// Token: 0x060025D0 RID: 9680
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void RegisterToken(object obj, int token);

		// Token: 0x060025D1 RID: 9681 RVA: 0x000935FD File Offset: 0x000917FD
		internal TokenGenerator GetTokenGenerator()
		{
			if (this.token_gen == null)
			{
				this.token_gen = new ModuleBuilderTokenGenerator(this);
			}
			return this.token_gen;
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x0009361C File Offset: 0x0009181C
		internal static object RuntimeResolve(object obj)
		{
			if (obj is MethodBuilder)
			{
				return (obj as MethodBuilder).RuntimeResolve();
			}
			if (obj is ConstructorBuilder)
			{
				return (obj as ConstructorBuilder).RuntimeResolve();
			}
			if (obj is FieldBuilder)
			{
				return (obj as FieldBuilder).RuntimeResolve();
			}
			if (obj is GenericTypeParameterBuilder)
			{
				return (obj as GenericTypeParameterBuilder).RuntimeResolve();
			}
			if (obj is FieldOnTypeBuilderInst)
			{
				return (obj as FieldOnTypeBuilderInst).RuntimeResolve();
			}
			if (obj is MethodOnTypeBuilderInst)
			{
				return (obj as MethodOnTypeBuilderInst).RuntimeResolve();
			}
			if (obj is ConstructorOnTypeBuilderInst)
			{
				return (obj as ConstructorOnTypeBuilderInst).RuntimeResolve();
			}
			if (obj is Type)
			{
				return (obj as Type).RuntimeResolve();
			}
			throw new NotImplementedException(obj.GetType().FullName);
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060025D3 RID: 9683 RVA: 0x000936D9 File Offset: 0x000918D9
		internal string FileName
		{
			get
			{
				return this.fqname;
			}
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x000936E1 File Offset: 0x000918E1
		internal void CreateGlobalType()
		{
			if (this.global_type == null)
			{
				this.global_type = new TypeBuilder(this, TypeAttributes.NotPublic, 1);
			}
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x000936FF File Offset: 0x000918FF
		internal override Guid GetModuleVersionId()
		{
			return new Guid(this.guid);
		}

		/// <summary>Gets the dynamic assembly that defined this instance of <see cref="T:System.Reflection.Emit.ModuleBuilder" />.</summary>
		/// <returns>The dynamic assembly that defined the current dynamic module.</returns>
		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060025D6 RID: 9686 RVA: 0x0009370C File Offset: 0x0009190C
		public override Assembly Assembly
		{
			get
			{
				return this.assemblyb;
			}
		}

		/// <summary>A string that indicates that this is an in-memory module.</summary>
		/// <returns>Text that indicates that this is an in-memory module.</returns>
		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060025D7 RID: 9687 RVA: 0x00093714 File Offset: 0x00091914
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets a string that represents the name of the dynamic module.</summary>
		/// <returns>The name of the dynamic module.</returns>
		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x060025D8 RID: 9688 RVA: 0x00093714 File Offset: 0x00091914
		public override string ScopeName
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets a universally unique identifier (UUID) that can be used to distinguish between two versions of a module.</summary>
		/// <returns>A <see cref="T:System.Guid" /> that can be used to distinguish between two versions of a module.</returns>
		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060025D9 RID: 9689 RVA: 0x0008E11F File Offset: 0x0008C31F
		public override Guid ModuleVersionId
		{
			get
			{
				return this.GetModuleVersionId();
			}
		}

		/// <summary>Gets a value indicating whether the object is a resource.</summary>
		/// <returns>
		///     <see langword="true" /> if the object is a resource; otherwise, <see langword="false" />.</returns>
		// Token: 0x060025DA RID: 9690 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public override bool IsResource()
		{
			return false;
		}

		/// <summary>Returns the method or constructor identified by the specified metadata token, in the context defined by the specified generic type parameters. </summary>
		/// <param name="metadataToken">A metadata token that identifies a method or constructor in the module.</param>
		/// <param name="genericTypeArguments">An array of <see cref="T:System.Type" /> objects representing the generic type arguments of the type where the token is in scope, or <see langword="null" /> if that type is not generic. </param>
		/// <param name="genericMethodArguments">An array of <see cref="T:System.Type" /> objects representing the generic type arguments of the method where the token is in scope, or <see langword="null" /> if that method is not generic.</param>
		/// <returns>A <see cref="T:System.Reflection.MethodBase" /> object representing the method that is identified by the specified metadata token.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="metadataToken" /> is not a token for a method or constructor in the scope of the current module.-or-
		///         <paramref name="metadataToken" /> is a <see langword="MethodSpec" /> whose signature contains element type <see langword="var" /> (a type parameter of a generic type) or <see langword="mvar" /> (a type parameter of a generic method), and the necessary generic type arguments were not supplied for either or both of <paramref name="genericTypeArguments" /> and <paramref name="genericMethodArguments" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="metadataToken" /> is not a valid token in the scope of the current module.</exception>
		// Token: 0x060025DB RID: 9691 RVA: 0x0009371C File Offset: 0x0009191C
		public override MethodBase ResolveMethod(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			return RuntimeModule.ResolveMethod(this, this._impl, metadataToken, genericTypeArguments, genericMethodArguments);
		}

		/// <summary>Returns a value that indicates whether this instance is equal to the specified object.</summary>
		/// <param name="obj">An object to compare with this instance, or <see langword="null" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> equals the type and value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x060025DC RID: 9692 RVA: 0x0009372D File Offset: 0x0009192D
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x060025DD RID: 9693 RVA: 0x00093736 File Offset: 0x00091936
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Returns a value that indicates whether the specified attribute type has been applied to this module.</summary>
		/// <param name="attributeType">The type of custom attribute to test for.</param>
		/// <param name="inherit">This argument is ignored for objects of this type.</param>
		/// <returns>
		///     <see langword="true" /> if one or more instances of <paramref name="attributeType" /> have been applied to this module; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not a <see cref="T:System.Type" /> object supplied by the runtime. For example, <paramref name="attributeType" /> is a <see cref="T:System.Reflection.Emit.TypeBuilder" /> object.</exception>
		// Token: 0x060025DE RID: 9694 RVA: 0x0009373E File Offset: 0x0009193E
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return base.IsDefined(attributeType, inherit);
		}

		/// <summary>Returns all the custom attributes that have been applied to the current <see cref="T:System.Reflection.Emit.ModuleBuilder" />.</summary>
		/// <param name="inherit">This argument is ignored for objects of this type.</param>
		/// <returns>An array that contains the custom attributes; the array is empty if there are no attributes.</returns>
		// Token: 0x060025DF RID: 9695 RVA: 0x00093748 File Offset: 0x00091948
		public override object[] GetCustomAttributes(bool inherit)
		{
			return this.GetCustomAttributes(null, inherit);
		}

		/// <summary>Returns all the custom attributes that have been applied to the current <see cref="T:System.Reflection.Emit.ModuleBuilder" />, and that derive from a specified attribute type.</summary>
		/// <param name="attributeType">The base type from which attributes derive.</param>
		/// <param name="inherit">This argument is ignored for objects of this type.</param>
		/// <returns>An array that contains the custom attributes that are derived, at any level, from <paramref name="attributeType" />; the array is empty if there are no such attributes.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not a <see cref="T:System.Type" /> object supplied by the runtime. For example, <paramref name="attributeType" /> is a <see cref="T:System.Reflection.Emit.TypeBuilder" /> object.</exception>
		// Token: 0x060025E0 RID: 9696 RVA: 0x00093754 File Offset: 0x00091954
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (this.cattrs == null || this.cattrs.Length == 0)
			{
				return Array.Empty<object>();
			}
			if (attributeType is TypeBuilder)
			{
				throw new InvalidOperationException("First argument to GetCustomAttributes can't be a TypeBuilder");
			}
			List<object> list = new List<object>();
			for (int i = 0; i < this.cattrs.Length; i++)
			{
				Type type = this.cattrs[i].Ctor.GetType();
				if (type is TypeBuilder)
				{
					throw new InvalidOperationException("Can't construct custom attribute for TypeBuilder type");
				}
				if (attributeType == null || attributeType.IsAssignableFrom(type))
				{
					list.Add(this.cattrs[i].Invoke());
				}
			}
			return list.ToArray();
		}

		// Token: 0x0400127E RID: 4734
		internal IntPtr _impl;

		// Token: 0x0400127F RID: 4735
		internal Assembly assembly;

		// Token: 0x04001280 RID: 4736
		internal string fqname;

		// Token: 0x04001281 RID: 4737
		internal string name;

		// Token: 0x04001282 RID: 4738
		internal string scopename;

		// Token: 0x04001283 RID: 4739
		internal bool is_resource;

		// Token: 0x04001284 RID: 4740
		internal int token;

		// Token: 0x04001285 RID: 4741
		private UIntPtr dynamic_image;

		// Token: 0x04001286 RID: 4742
		private int num_types;

		// Token: 0x04001287 RID: 4743
		private TypeBuilder[] types;

		// Token: 0x04001288 RID: 4744
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x04001289 RID: 4745
		private byte[] guid;

		// Token: 0x0400128A RID: 4746
		private int table_idx;

		// Token: 0x0400128B RID: 4747
		internal AssemblyBuilder assemblyb;

		// Token: 0x0400128C RID: 4748
		private MethodBuilder[] global_methods;

		// Token: 0x0400128D RID: 4749
		private FieldBuilder[] global_fields;

		// Token: 0x0400128E RID: 4750
		private bool is_main;

		// Token: 0x0400128F RID: 4751
		private MonoResource[] resources;

		// Token: 0x04001290 RID: 4752
		private IntPtr unparented_classes;

		// Token: 0x04001291 RID: 4753
		private int[] table_indexes;

		// Token: 0x04001292 RID: 4754
		private TypeBuilder global_type;

		// Token: 0x04001293 RID: 4755
		private Type global_type_created;

		// Token: 0x04001294 RID: 4756
		private Dictionary<TypeName, TypeBuilder> name_cache;

		// Token: 0x04001295 RID: 4757
		private Dictionary<string, int> us_string_cache;

		// Token: 0x04001296 RID: 4758
		private bool transient;

		// Token: 0x04001297 RID: 4759
		private ModuleBuilderTokenGenerator token_gen;

		// Token: 0x04001298 RID: 4760
		private Hashtable resource_writers;

		// Token: 0x04001299 RID: 4761
		private ISymbolWriter symbolWriter;

		// Token: 0x0400129A RID: 4762
		private static bool has_warned_about_symbolWriter;

		// Token: 0x0400129B RID: 4763
		private static int typeref_tokengen = 33554431;

		// Token: 0x0400129C RID: 4764
		private static int typedef_tokengen = 50331647;

		// Token: 0x0400129D RID: 4765
		private static int typespec_tokengen = 469762047;

		// Token: 0x0400129E RID: 4766
		private static int memberref_tokengen = 184549375;

		// Token: 0x0400129F RID: 4767
		private static int methoddef_tokengen = 117440511;

		// Token: 0x040012A0 RID: 4768
		private Dictionary<MemberInfo, int> inst_tokens;

		// Token: 0x040012A1 RID: 4769
		private Dictionary<MemberInfo, int> inst_tokens_open;
	}
}
