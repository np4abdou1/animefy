using System;
using System.Text;

namespace System.Xml.Serialization
{
	/// <summary>Specifies that the member can be further detected by using an enumeration.</summary>
	// Token: 0x020001E4 RID: 484
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = false)]
	public class XmlChoiceIdentifierAttribute : Attribute
	{
		/// <summary>Gets or sets the name of the field that returns the enumeration to use when detecting types.</summary>
		/// <returns>The name of a field that returns an enumeration.</returns>
		// Token: 0x17000333 RID: 819
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x00065139 File Offset: 0x00063339
		public string MemberName
		{
			get
			{
				if (this.memberName == null)
				{
					return string.Empty;
				}
				return this.memberName;
			}
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0006514F File Offset: 0x0006334F
		internal void AddKeyHash(StringBuilder sb)
		{
			sb.Append("XCA ");
			KeyHelper.AddField(sb, 1, this.memberName);
			sb.Append('|');
		}

		// Token: 0x04000B6A RID: 2922
		private string memberName;
	}
}
