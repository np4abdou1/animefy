using System;

namespace System.Runtime.Serialization
{
	/// <summary>Specifies that the type defines or implements a data contract and is serializable by a serializer, such as the <see cref="T:System.Runtime.Serialization.DataContractSerializer" />. To make their type serializable, type authors must define a data contract for their type. </summary>
	// Token: 0x02000002 RID: 2
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
	public sealed class DataContractAttribute : Attribute
	{
		/// <summary>Gets or sets a value that indicates whether to preserve object reference data.</summary>
		/// <returns>
		///     <see langword="true" /> to keep object reference data using standard XML; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsReference
		{
			get
			{
				return this.isReference;
			}
		}

		// Token: 0x04000001 RID: 1
		private bool isReference;
	}
}
