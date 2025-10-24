using System;

namespace System.Runtime.Serialization
{
	/// <summary>Specifies that the field is an enumeration member and should be serialized.</summary>
	// Token: 0x02000004 RID: 4
	[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class EnumMemberAttribute : Attribute
	{
		/// <summary>Gets or sets the value associated with the enumeration member the attribute is applied to. </summary>
		/// <returns>The value associated with the enumeration member.</returns>
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002078 File Offset: 0x00000278
		public string Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x04000006 RID: 6
		private string value;
	}
}
