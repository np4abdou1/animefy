using System;

namespace System.Runtime.Serialization
{
	/// <summary>Holds the value, <see cref="T:System.Type" />, and name of a serialized object. </summary>
	// Token: 0x02000393 RID: 915
	public readonly struct SerializationEntry
	{
		// Token: 0x06001C77 RID: 7287 RVA: 0x00079151 File Offset: 0x00077351
		internal SerializationEntry(string entryName, object entryValue, Type entryType)
		{
			this._name = entryName;
			this._value = entryValue;
			this._type = entryType;
		}

		/// <summary>Gets the value contained in the object.</summary>
		/// <returns>The value contained in the object.</returns>
		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x00079168 File Offset: 0x00077368
		public object Value
		{
			get
			{
				return this._value;
			}
		}

		/// <summary>Gets the name of the object.</summary>
		/// <returns>The name of the object.</returns>
		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x00079170 File Offset: 0x00077370
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x04000BF0 RID: 3056
		private readonly string _name;

		// Token: 0x04000BF1 RID: 3057
		private readonly object _value;

		// Token: 0x04000BF2 RID: 3058
		private readonly Type _type;
	}
}
