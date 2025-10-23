using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Defines and represents a field. This class cannot be inherited.</summary>
	// Token: 0x020004FD RID: 1277
	[StructLayout(0)]
	public sealed class FieldBuilder : FieldInfo
	{
		// Token: 0x060024F1 RID: 9457 RVA: 0x000907DC File Offset: 0x0008E9DC
		internal FieldBuilder(TypeBuilder tb, string fieldName, Type type, FieldAttributes attributes, Type[] modReq, Type[] modOpt)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			this.attrs = attributes;
			this.name = fieldName;
			this.type = type;
			this.modReq = modReq;
			this.modOpt = modOpt;
			this.offset = -1;
			this.typeb = tb;
			((ModuleBuilder)tb.Module).RegisterToken(this, this.GetToken().Token);
		}

		/// <summary>Indicates the attributes of this field. This property is read-only.</summary>
		/// <returns>The attributes of this field.</returns>
		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x00090856 File Offset: 0x0008EA56
		public override FieldAttributes Attributes
		{
			get
			{
				return this.attrs;
			}
		}

		/// <summary>Indicates a reference to the <see cref="T:System.Type" /> object for the type that declares this field. This property is read-only.</summary>
		/// <returns>A reference to the <see cref="T:System.Type" /> object for the type that declares this field.</returns>
		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060024F3 RID: 9459 RVA: 0x0009085E File Offset: 0x0008EA5E
		public override Type DeclaringType
		{
			get
			{
				return this.typeb;
			}
		}

		/// <summary>Indicates the internal metadata handle for this field. This property is read-only.</summary>
		/// <returns>The internal metadata handle for this field.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported. </exception>
		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x00090866 File Offset: 0x0008EA66
		public override RuntimeFieldHandle FieldHandle
		{
			get
			{
				throw this.CreateNotSupportedException();
			}
		}

		/// <summary>Indicates the <see cref="T:System.Type" /> object that represents the type of this field. This property is read-only.</summary>
		/// <returns>The <see cref="T:System.Type" /> object that represents the type of this field.</returns>
		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x0009086E File Offset: 0x0008EA6E
		public override Type FieldType
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Indicates the name of this field. This property is read-only.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the name of this field.</returns>
		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060024F6 RID: 9462 RVA: 0x00090876 File Offset: 0x0008EA76
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Indicates the reference to the <see cref="T:System.Type" /> object from which this object was obtained. This property is read-only.</summary>
		/// <returns>A reference to the <see cref="T:System.Type" /> object from which this instance was obtained.</returns>
		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060024F7 RID: 9463 RVA: 0x0009085E File Offset: 0x0008EA5E
		public override Type ReflectedType
		{
			get
			{
				return this.typeb;
			}
		}

		/// <summary>Returns all the custom attributes defined for this field.</summary>
		/// <param name="inherit">Controls inheritance of custom attributes from base classes. </param>
		/// <returns>An array of type <see cref="T:System.Object" /> representing all the custom attributes of the constructor represented by this <see cref="T:System.Reflection.Emit.FieldBuilder" /> instance.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported. </exception>
		// Token: 0x060024F8 RID: 9464 RVA: 0x0009087E File Offset: 0x0008EA7E
		public override object[] GetCustomAttributes(bool inherit)
		{
			if (this.typeb.is_created)
			{
				return MonoCustomAttrs.GetCustomAttributes(this, inherit);
			}
			throw this.CreateNotSupportedException();
		}

		/// <summary>Returns all the custom attributes defined for this field identified by the given type.</summary>
		/// <param name="attributeType">The custom attribute type. </param>
		/// <param name="inherit">Controls inheritance of custom attributes from base classes. </param>
		/// <returns>An array of type <see cref="T:System.Object" /> representing all the custom attributes of the constructor represented by this <see cref="T:System.Reflection.Emit.FieldBuilder" /> instance.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported. </exception>
		// Token: 0x060024F9 RID: 9465 RVA: 0x0009089B File Offset: 0x0008EA9B
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (this.typeb.is_created)
			{
				return MonoCustomAttrs.GetCustomAttributes(this, attributeType, inherit);
			}
			throw this.CreateNotSupportedException();
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060024FA RID: 9466 RVA: 0x000908B9 File Offset: 0x0008EAB9
		public override int MetadataToken
		{
			get
			{
				return ((ModuleBuilder)this.typeb.Module).GetToken(this);
			}
		}

		/// <summary>Returns the token representing this field.</summary>
		/// <returns>Returns the <see cref="T:System.Reflection.Emit.FieldToken" /> object that represents the token for this field.</returns>
		// Token: 0x060024FB RID: 9467 RVA: 0x000908D1 File Offset: 0x0008EAD1
		public FieldToken GetToken()
		{
			return new FieldToken(this.MetadataToken);
		}

		/// <summary>Retrieves the value of the field supported by the given object.</summary>
		/// <param name="obj">The object on which to access the field. </param>
		/// <returns>An <see cref="T:System.Object" /> containing the value of the field reflected by this instance.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported. </exception>
		// Token: 0x060024FC RID: 9468 RVA: 0x00090866 File Offset: 0x0008EA66
		public override object GetValue(object obj)
		{
			throw this.CreateNotSupportedException();
		}

		/// <summary>Indicates whether an attribute having the specified type is defined on a field.</summary>
		/// <param name="attributeType">The type of the attribute. </param>
		/// <param name="inherit">Controls inheritance of custom attributes from base classes. </param>
		/// <returns>
		///     <see langword="true" /> if one or more instance of <paramref name="attributeType" /> is defined on this field; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the field using <see cref="M:System.Type.GetField(System.String,System.Reflection.BindingFlags)" /> and call <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> on the returned <see cref="T:System.Reflection.FieldInfo" />. </exception>
		// Token: 0x060024FD RID: 9469 RVA: 0x00090866 File Offset: 0x0008EA66
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw this.CreateNotSupportedException();
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		internal override int GetFieldOffset()
		{
			return 0;
		}

		/// <summary>Sets the value of the field supported by the given object.</summary>
		/// <param name="obj">The object on which to access the field. </param>
		/// <param name="val">The value to assign to the field. </param>
		/// <param name="invokeAttr">A member of <see langword="IBinder" /> that specifies the type of binding that is desired (for example, IBinder.CreateInstance, IBinder.ExactBinding). </param>
		/// <param name="binder">A set of properties and enabling for binding, coercion of argument types, and invocation of members using reflection. If binder is null, then IBinder.DefaultBinding is used. </param>
		/// <param name="culture">The software preferences of a particular culture. </param>
		/// <exception cref="T:System.NotSupportedException">This method is not supported. </exception>
		// Token: 0x060024FF RID: 9471 RVA: 0x00090866 File Offset: 0x0008EA66
		public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
			throw this.CreateNotSupportedException();
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x0008F51E File Offset: 0x0008D71E
		private Exception CreateNotSupportedException()
		{
			return new NotSupportedException("The invoked member is not supported in a dynamic module.");
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x000908E0 File Offset: 0x0008EAE0
		internal void ResolveUserTypes()
		{
			this.type = TypeBuilder.ResolveUserType(this.type);
			TypeBuilder.ResolveUserTypes(this.modReq);
			TypeBuilder.ResolveUserTypes(this.modOpt);
			if (this.marshal_info != null)
			{
				this.marshal_info.marshaltyperef = TypeBuilder.ResolveUserType(this.marshal_info.marshaltyperef);
			}
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x00090938 File Offset: 0x0008EB38
		internal FieldInfo RuntimeResolve()
		{
			RuntimeTypeHandle declaringType = new RuntimeTypeHandle(this.typeb.CreateType() as RuntimeType);
			return FieldInfo.GetFieldFromHandle(this.handle, declaringType);
		}

		/// <summary>Gets the module in which the type that contains this field is being defined.</summary>
		/// <returns>A <see cref="T:System.Reflection.Module" /> that represents the dynamic module in which this field is being defined.</returns>
		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06002503 RID: 9475 RVA: 0x00090968 File Offset: 0x0008EB68
		public override Module Module
		{
			get
			{
				return base.Module;
			}
		}

		// Token: 0x04001218 RID: 4632
		private FieldAttributes attrs;

		// Token: 0x04001219 RID: 4633
		private Type type;

		// Token: 0x0400121A RID: 4634
		private string name;

		// Token: 0x0400121B RID: 4635
		private object def_value;

		// Token: 0x0400121C RID: 4636
		private int offset;

		// Token: 0x0400121D RID: 4637
		internal TypeBuilder typeb;

		// Token: 0x0400121E RID: 4638
		private byte[] rva_data;

		// Token: 0x0400121F RID: 4639
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x04001220 RID: 4640
		private UnmanagedMarshal marshal_info;

		// Token: 0x04001221 RID: 4641
		private RuntimeFieldHandle handle;

		// Token: 0x04001222 RID: 4642
		private Type[] modReq;

		// Token: 0x04001223 RID: 4643
		private Type[] modOpt;
	}
}
