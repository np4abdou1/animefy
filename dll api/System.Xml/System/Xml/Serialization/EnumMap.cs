using System;
using System.Globalization;
using System.Text;

namespace System.Xml.Serialization
{
	// Token: 0x0200021C RID: 540
	internal class EnumMap : ObjectMap
	{
		// Token: 0x060011E2 RID: 4578 RVA: 0x0006F164 File Offset: 0x0006D364
		public EnumMap(EnumMap.EnumMapMember[] members, bool isFlags)
		{
			this._members = members;
			this._isFlags = isFlags;
			this._enumNames = new string[this._members.Length];
			this._xmlNames = new string[this._members.Length];
			this._values = new long[this._members.Length];
			for (int i = 0; i < this._members.Length; i++)
			{
				EnumMap.EnumMapMember enumMapMember = this._members[i];
				this._enumNames[i] = enumMapMember.EnumName;
				this._xmlNames[i] = enumMapMember.XmlName;
				this._values[i] = enumMapMember.Value;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x0006F204 File Offset: 0x0006D404
		public bool IsFlags
		{
			get
			{
				return this._isFlags;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x0006F20C File Offset: 0x0006D40C
		public string[] EnumNames
		{
			get
			{
				return this._enumNames;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x0006F214 File Offset: 0x0006D414
		public string[] XmlNames
		{
			get
			{
				return this._xmlNames;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x0006F21C File Offset: 0x0006D41C
		public long[] Values
		{
			get
			{
				return this._values;
			}
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x0006F224 File Offset: 0x0006D424
		public string GetXmlName(string typeName, object enumValue)
		{
			if (enumValue is string)
			{
				throw new InvalidCastException();
			}
			long num = 0L;
			try
			{
				num = ((IConvertible)enumValue).ToInt64(CultureInfo.CurrentCulture);
			}
			catch (FormatException)
			{
				throw new InvalidCastException();
			}
			for (int i = 0; i < this.Values.Length; i++)
			{
				if (this.Values[i] == num)
				{
					return this.XmlNames[i];
				}
			}
			if (this.IsFlags && num == 0L)
			{
				return string.Empty;
			}
			string text = string.Empty;
			if (this.IsFlags)
			{
				text = XmlCustomFormatter.FromEnum(num, this.XmlNames, this.Values, typeName);
			}
			if (text.Length == 0)
			{
				throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, "'{0}' is not a valid value for {1}.", num, typeName));
			}
			return text;
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x0006F2EC File Offset: 0x0006D4EC
		public string GetEnumName(string typeName, string xmlName)
		{
			if (!this._isFlags)
			{
				foreach (EnumMap.EnumMapMember enumMapMember in this._members)
				{
					if (enumMapMember.XmlName == xmlName)
					{
						return enumMapMember.EnumName;
					}
				}
				return null;
			}
			xmlName = xmlName.Trim();
			if (xmlName.Length == 0)
			{
				return "0";
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string text in xmlName.Split(null))
			{
				if (!(text == string.Empty))
				{
					string text2 = null;
					for (int j = 0; j < this.XmlNames.Length; j++)
					{
						if (this.XmlNames[j] == text)
						{
							text2 = this.EnumNames[j];
							break;
						}
					}
					if (text2 == null)
					{
						throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, "'{0}' is not a valid value for {1}.", text, typeName));
					}
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append(',');
					}
					stringBuilder.Append(text2);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000C2A RID: 3114
		private readonly EnumMap.EnumMapMember[] _members;

		// Token: 0x04000C2B RID: 3115
		private readonly bool _isFlags;

		// Token: 0x04000C2C RID: 3116
		private readonly string[] _enumNames;

		// Token: 0x04000C2D RID: 3117
		private readonly string[] _xmlNames;

		// Token: 0x04000C2E RID: 3118
		private readonly long[] _values;

		// Token: 0x0200021D RID: 541
		public class EnumMapMember
		{
			// Token: 0x060011E9 RID: 4585 RVA: 0x0006F3F9 File Offset: 0x0006D5F9
			public EnumMapMember(string xmlName, string enumName, long value)
			{
				this._xmlName = xmlName;
				this._enumName = enumName;
				this._value = value;
			}

			// Token: 0x170003A6 RID: 934
			// (get) Token: 0x060011EA RID: 4586 RVA: 0x0006F416 File Offset: 0x0006D616
			public string XmlName
			{
				get
				{
					return this._xmlName;
				}
			}

			// Token: 0x170003A7 RID: 935
			// (get) Token: 0x060011EB RID: 4587 RVA: 0x0006F41E File Offset: 0x0006D61E
			public string EnumName
			{
				get
				{
					return this._enumName;
				}
			}

			// Token: 0x170003A8 RID: 936
			// (get) Token: 0x060011EC RID: 4588 RVA: 0x0006F426 File Offset: 0x0006D626
			public long Value
			{
				get
				{
					return this._value;
				}
			}

			// Token: 0x04000C2F RID: 3119
			private readonly string _xmlName;

			// Token: 0x04000C30 RID: 3120
			private readonly string _enumName;

			// Token: 0x04000C31 RID: 3121
			private readonly long _value;
		}
	}
}
