using System;
using System.Collections;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Represents a collection of properties that can be added to <see cref="T:System.Data.DataColumn" />, <see cref="T:System.Data.DataSet" />, or <see cref="T:System.Data.DataTable" />. </summary>
	// Token: 0x0200007B RID: 123
	[Serializable]
	public class PropertyCollection : Hashtable, ICloneable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.PropertyCollection" /> class.</summary>
		// Token: 0x060007D2 RID: 2002 RVA: 0x00026A40 File Offset: 0x00024C40
		public PropertyCollection()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.PropertyCollection" /> class.</summary>
		/// <param name="info">The data needed to serialize or deserialize an object.</param>
		/// <param name="context">The source and destination of a given serialized stream.</param>
		// Token: 0x060007D3 RID: 2003 RVA: 0x00026A48 File Offset: 0x00024C48
		protected PropertyCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Creates a shallow copy of the <see cref="T:System.Data.PropertyCollection" /> object.</summary>
		/// <returns>Returns <see cref="T:System.Object" />, a shallow copy of the <see cref="T:System.Data.PropertyCollection" /> object.</returns>
		// Token: 0x060007D4 RID: 2004 RVA: 0x00026A54 File Offset: 0x00024C54
		public override object Clone()
		{
			PropertyCollection propertyCollection = new PropertyCollection();
			foreach (object obj in this)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				propertyCollection.Add(dictionaryEntry.Key, dictionaryEntry.Value);
			}
			return propertyCollection;
		}
	}
}
