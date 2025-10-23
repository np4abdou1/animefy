using System;

namespace System.Runtime.Serialization
{
	/// <summary>When applied to the member of a type, specifies that the member is part of a data contract and is serializable by the <see cref="T:System.Runtime.Serialization.DataContractSerializer" />.</summary>
	// Token: 0x02000003 RID: 3
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class DataMemberAttribute : Attribute
	{
		/// <summary>Gets or sets a data member name. </summary>
		/// <returns>The name of the data member. The default is the name of the target that the attribute is applied to. </returns>
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets or sets the order of serialization and deserialization of a member.</summary>
		/// <returns>The numeric order of serialization or deserialization.</returns>
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002060 File Offset: 0x00000260
		public int Order
		{
			get
			{
				return this.order;
			}
		}

		/// <summary>Gets or sets a value that instructs the serialization engine that the member must be present when reading or deserializing.</summary>
		/// <returns>
		///     <see langword="true" />, if the member is required; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">the member is not present.</exception>
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002068 File Offset: 0x00000268
		public bool IsRequired
		{
			get
			{
				return this.isRequired;
			}
		}

		/// <summary>Gets or sets a value that specifies whether to serialize the default value for a field or property being serialized. </summary>
		/// <returns>
		///     <see langword="true" /> if the default value for a member should be generated in the serialization stream; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002070 File Offset: 0x00000270
		public bool EmitDefaultValue
		{
			get
			{
				return this.emitDefaultValue;
			}
		}

		// Token: 0x04000002 RID: 2
		private string name;

		// Token: 0x04000003 RID: 3
		private int order;

		// Token: 0x04000004 RID: 4
		private bool isRequired;

		// Token: 0x04000005 RID: 5
		private bool emitDefaultValue;
	}
}
