using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>Discovers the attributes of a parameter and provides access to parameter metadata.</summary>
	// Token: 0x020004AF RID: 1199
	[Serializable]
	[StructLayout(0)]
	public class ParameterInfo : ICustomAttributeProvider, IObjectReference
	{
		/// <summary>Initializes a new instance of the <see langword="ParameterInfo" /> class.</summary>
		// Token: 0x06002181 RID: 8577 RVA: 0x00003ACD File Offset: 0x00001CCD
		protected ParameterInfo()
		{
		}

		/// <summary>Gets the attributes for this parameter.</summary>
		/// <returns>A <see langword="ParameterAttributes" /> object representing the attributes for this parameter.</returns>
		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x0008A5F4 File Offset: 0x000887F4
		public virtual ParameterAttributes Attributes
		{
			get
			{
				return this.AttrsImpl;
			}
		}

		/// <summary>Gets a value indicating the member in which the parameter is implemented.</summary>
		/// <returns>The member which implanted the parameter represented by this <see cref="T:System.Reflection.ParameterInfo" />.</returns>
		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x0008A5FC File Offset: 0x000887FC
		public virtual MemberInfo Member
		{
			get
			{
				return this.MemberImpl;
			}
		}

		/// <summary>Gets the name of the parameter.</summary>
		/// <returns>The simple name of this parameter.</returns>
		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x0008A604 File Offset: 0x00088804
		public virtual string Name
		{
			get
			{
				return this.NameImpl;
			}
		}

		/// <summary>Gets the <see langword="Type" /> of this parameter.</summary>
		/// <returns>The <see langword="Type" /> object that represents the <see langword="Type" /> of this parameter.</returns>
		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06002185 RID: 8581 RVA: 0x0008A60C File Offset: 0x0008880C
		public virtual Type ParameterType
		{
			get
			{
				return this.ClassImpl;
			}
		}

		/// <summary>Gets the zero-based position of the parameter in the formal parameter list.</summary>
		/// <returns>An integer representing the position this parameter occupies in the parameter list.</returns>
		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06002186 RID: 8582 RVA: 0x0008A614 File Offset: 0x00088814
		public virtual int Position
		{
			get
			{
				return this.PositionImpl;
			}
		}

		/// <summary>Gets a value indicating whether this is an input parameter.</summary>
		/// <returns>
		///     <see langword="true" /> if the parameter is an input parameter; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06002187 RID: 8583 RVA: 0x0008A61C File Offset: 0x0008881C
		public bool IsIn
		{
			get
			{
				return (this.Attributes & ParameterAttributes.In) > ParameterAttributes.None;
			}
		}

		/// <summary>Gets a value indicating whether this parameter is optional.</summary>
		/// <returns>
		///     <see langword="true" /> if the parameter is optional; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x0008A629 File Offset: 0x00088829
		public bool IsOptional
		{
			get
			{
				return (this.Attributes & ParameterAttributes.Optional) > ParameterAttributes.None;
			}
		}

		/// <summary>Gets a value indicating whether this is an output parameter.</summary>
		/// <returns>
		///     <see langword="true" /> if the parameter is an output parameter; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06002189 RID: 8585 RVA: 0x0008A637 File Offset: 0x00088837
		public bool IsOut
		{
			get
			{
				return (this.Attributes & ParameterAttributes.Out) > ParameterAttributes.None;
			}
		}

		/// <summary>Gets a value indicating the default value if the parameter has a default value.</summary>
		/// <returns>The default value of the parameter, or <see cref="F:System.DBNull.Value" /> if the parameter has no default value.</returns>
		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public virtual object DefaultValue
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Determines whether the custom attribute of the specified type or its derived types is applied to this parameter.</summary>
		/// <param name="attributeType">The <see langword="Type" /> object to search for. </param>
		/// <param name="inherit">This argument is ignored for objects of this type. See Remarks.</param>
		/// <returns>
		///     <see langword="true" /> if one or more instances of <paramref name="attributeType" /> or its derived types are applied to this parameter; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not a <see cref="T:System.Type" /> object supplied by the common language runtime.</exception>
		// Token: 0x0600218B RID: 8587 RVA: 0x0008A644 File Offset: 0x00088844
		public virtual bool IsDefined(Type attributeType, bool inherit)
		{
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			return false;
		}

		/// <summary>Gets all the custom attributes defined on this parameter.</summary>
		/// <param name="inherit">This argument is ignored for objects of this type. See Remarks.</param>
		/// <returns>An array that contains all the custom attributes applied to this parameter.</returns>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type could not be loaded. </exception>
		// Token: 0x0600218C RID: 8588 RVA: 0x0008A65B File Offset: 0x0008885B
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			return Array.Empty<object>();
		}

		/// <summary>Gets the custom attributes of the specified type or its derived types that are applied to this parameter.</summary>
		/// <param name="attributeType">The custom attributes identified by type. </param>
		/// <param name="inherit">This argument is ignored for objects of this type. See Remarks.</param>
		/// <returns>An array that contains the custom attributes of the specified type or its derived types.</returns>
		/// <exception cref="T:System.ArgumentException">The type must be a type provided by the underlying runtime system.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="attributeType" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type could not be loaded. </exception>
		// Token: 0x0600218D RID: 8589 RVA: 0x0008A662 File Offset: 0x00088862
		public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			return Array.Empty<object>();
		}

		/// <summary>Returns the real object that should be deserialized instead of the object that the serialized stream specifies.</summary>
		/// <param name="context">The serialized stream from which the current object is deserialized.</param>
		/// <returns>The actual object that is put into the graph.</returns>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The parameter's position in the parameter list of its associated member is not valid for that member's type.</exception>
		// Token: 0x0600218E RID: 8590 RVA: 0x0008A680 File Offset: 0x00088880
		public object GetRealObject(StreamingContext context)
		{
			if (this.MemberImpl == null)
			{
				throw new SerializationException("Insufficient state to return the real object.");
			}
			MemberTypes memberType = this.MemberImpl.MemberType;
			if (memberType != MemberTypes.Constructor && memberType != MemberTypes.Method)
			{
				if (memberType != MemberTypes.Property)
				{
					throw new SerializationException("Serialized member does not have a ParameterInfo.");
				}
				ParameterInfo[] array = ((PropertyInfo)this.MemberImpl).GetIndexParameters();
				if (array != null && this.PositionImpl > -1 && this.PositionImpl < array.Length)
				{
					return array[this.PositionImpl];
				}
				throw new SerializationException("Non existent ParameterInfo. Position bigger than member's parameters length.");
			}
			else if (this.PositionImpl == -1)
			{
				if (this.MemberImpl.MemberType == MemberTypes.Method)
				{
					return ((MethodInfo)this.MemberImpl).ReturnParameter;
				}
				throw new SerializationException("Non existent ParameterInfo. Position bigger than member's parameters length.");
			}
			else
			{
				ParameterInfo[] array = ((MethodBase)this.MemberImpl).GetParametersNoCopy();
				if (array != null && this.PositionImpl < array.Length)
				{
					return array[this.PositionImpl];
				}
				throw new SerializationException("Non existent ParameterInfo. Position bigger than member's parameters length.");
			}
		}

		/// <summary>Gets the parameter type and name represented as a string.</summary>
		/// <returns>A string containing the type and the name of the parameter.</returns>
		// Token: 0x0600218F RID: 8591 RVA: 0x0008A772 File Offset: 0x00088972
		public override string ToString()
		{
			return this.ParameterType.FormatTypeName() + " " + this.Name;
		}

		/// <summary>The attributes of the parameter.</summary>
		// Token: 0x0400103B RID: 4155
		protected ParameterAttributes AttrsImpl;

		/// <summary>The <see langword="Type" /> of the parameter.</summary>
		// Token: 0x0400103C RID: 4156
		protected Type ClassImpl;

		/// <summary>The default value of the parameter.</summary>
		// Token: 0x0400103D RID: 4157
		protected object DefaultValueImpl;

		/// <summary>The member in which the field is implemented.</summary>
		// Token: 0x0400103E RID: 4158
		protected MemberInfo MemberImpl;

		/// <summary>The name of the parameter.</summary>
		// Token: 0x0400103F RID: 4159
		protected string NameImpl;

		/// <summary>The zero-based position of the parameter in the parameter list.</summary>
		// Token: 0x04001040 RID: 4160
		protected int PositionImpl;

		// Token: 0x04001041 RID: 4161
		private const int MetadataToken_ParamDef = 134217728;
	}
}
