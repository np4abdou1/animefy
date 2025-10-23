using System;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Indicates the base serializer to use for a root designer object. This class cannot be inherited.</summary>
	// Token: 0x020002BE RID: 702
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	public sealed class RootDesignerSerializerAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.Serialization.RootDesignerSerializerAttribute" /> class using the specified attributes.</summary>
		/// <param name="serializerTypeName">The fully qualified name of the data type of the serializer. </param>
		/// <param name="baseSerializerTypeName">The name of the base type of the serializer. A class can include multiple serializers as they all have different base types. </param>
		/// <param name="reloadable">
		///       <see langword="true" /> if this serializer supports dynamic reloading of the document; otherwise, <see langword="false" />. </param>
		// Token: 0x060012AA RID: 4778 RVA: 0x000595E2 File Offset: 0x000577E2
		public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable)
		{
			this.<SerializerTypeName>k__BackingField = serializerTypeName;
			this.SerializerBaseTypeName = baseSerializerTypeName;
			this.<Reloadable>k__BackingField = reloadable;
		}

		/// <summary>Gets the fully qualified type name of the base type of the serializer.</summary>
		/// <returns>The name of the base type of the serializer.</returns>
		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x000595FF File Offset: 0x000577FF
		public string SerializerBaseTypeName { get; }

		/// <summary>Gets a unique ID for this attribute type.</summary>
		/// <returns>An object containing a unique ID for this attribute type.</returns>
		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x00059608 File Offset: 0x00057808
		public override object TypeId
		{
			get
			{
				if (this._typeId == null)
				{
					string text = this.SerializerBaseTypeName;
					int num = text.IndexOf(',');
					if (num != -1)
					{
						text = text.Substring(0, num);
					}
					this._typeId = base.GetType().FullName + text;
				}
				return this._typeId;
			}
		}

		// Token: 0x04000D0F RID: 3343
		private string _typeId;
	}
}
