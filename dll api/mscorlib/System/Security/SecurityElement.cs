using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Security
{
	/// <summary>Represents the XML object model for encoding security objects. This class cannot be inherited.</summary>
	// Token: 0x02000285 RID: 645
	[ComVisible(true)]
	[Serializable]
	public sealed class SecurityElement
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityElement" /> class with the specified tag.</summary>
		/// <param name="tag">The tag name of an XML element. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tag" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tag" /> parameter is invalid in XML. </exception>
		// Token: 0x06001676 RID: 5750 RVA: 0x0005BBFC File Offset: 0x00059DFC
		public SecurityElement(string tag) : this(tag, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityElement" /> class with the specified tag and text.</summary>
		/// <param name="tag">The tag name of the XML element. </param>
		/// <param name="text">The text content within the element. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tag" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tag" /> parameter or <paramref name="text" /> parameter is invalid in XML. </exception>
		// Token: 0x06001677 RID: 5751 RVA: 0x0005BC08 File Offset: 0x00059E08
		public SecurityElement(string tag, string text)
		{
			if (tag == null)
			{
				throw new ArgumentNullException("tag");
			}
			if (!SecurityElement.IsValidTag(tag))
			{
				throw new ArgumentException(Locale.GetText("Invalid XML string") + ": " + tag);
			}
			this.tag = tag;
			this.Text = text;
		}

		/// <summary>Gets or sets the array of child elements of the XML element.</summary>
		/// <returns>The ordered child elements of the XML element as security elements.</returns>
		/// <exception cref="T:System.ArgumentException">A child of the XML parent node is <see langword="null" />. </exception>
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x0005BC5A File Offset: 0x00059E5A
		public ArrayList Children
		{
			get
			{
				return this.children;
			}
		}

		/// <summary>Gets or sets the tag name of an XML element.</summary>
		/// <returns>The tag name of an XML element.</returns>
		/// <exception cref="T:System.ArgumentNullException">The tag is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The tag is not valid in XML. </exception>
		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x0005BC62 File Offset: 0x00059E62
		public string Tag
		{
			get
			{
				return this.tag;
			}
		}

		/// <summary>Gets or sets the text within an XML element.</summary>
		/// <returns>The value of the text within an XML element.</returns>
		/// <exception cref="T:System.ArgumentException">The text is not valid in XML. </exception>
		// Token: 0x1700024D RID: 589
		// (set) Token: 0x0600167A RID: 5754 RVA: 0x0005BC6A File Offset: 0x00059E6A
		public string Text
		{
			set
			{
				if (value != null && !SecurityElement.IsValidText(value))
				{
					throw new ArgumentException(Locale.GetText("Invalid XML string") + ": " + value);
				}
				this.text = SecurityElement.Unescape(value);
			}
		}

		/// <summary>Adds a name/value attribute to an XML element.</summary>
		/// <param name="name">The name of the attribute. </param>
		/// <param name="value">The value of the attribute. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter or <paramref name="value" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter or <paramref name="value" /> parameter is invalid in XML.-or- An attribute with the name specified by the <paramref name="name" /> parameter already exists. </exception>
		// Token: 0x0600167B RID: 5755 RVA: 0x0005BCA0 File Offset: 0x00059EA0
		public void AddAttribute(string name, string value)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (this.GetAttribute(name) != null)
			{
				throw new ArgumentException(Locale.GetText("Duplicate attribute : " + name));
			}
			if (this.attributes == null)
			{
				this.attributes = new ArrayList();
			}
			this.attributes.Add(new SecurityElement.SecurityAttribute(name, value));
		}

		/// <summary>Adds a child element to the XML element.</summary>
		/// <param name="child">The child element to add. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="child" /> parameter is <see langword="null" />. </exception>
		// Token: 0x0600167C RID: 5756 RVA: 0x0005BD0E File Offset: 0x00059F0E
		public void AddChild(SecurityElement child)
		{
			if (child == null)
			{
				throw new ArgumentNullException("child");
			}
			if (this.children == null)
			{
				this.children = new ArrayList();
			}
			this.children.Add(child);
		}

		/// <summary>Replaces invalid XML characters in a string with their valid XML equivalent.</summary>
		/// <param name="str">The string within which to escape invalid characters. </param>
		/// <returns>The input string with invalid characters replaced.</returns>
		// Token: 0x0600167D RID: 5757 RVA: 0x0005BD40 File Offset: 0x00059F40
		public static string Escape(string str)
		{
			if (str == null)
			{
				return null;
			}
			if (str.IndexOfAny(SecurityElement.invalid_chars) == -1)
			{
				return str;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int length = str.Length;
			int i = 0;
			while (i < length)
			{
				char c = str[i];
				if (c <= '&')
				{
					if (c != '"')
					{
						if (c != '&')
						{
							goto IL_96;
						}
						stringBuilder.Append("&amp;");
					}
					else
					{
						stringBuilder.Append("&quot;");
					}
				}
				else if (c != '\'')
				{
					if (c != '<')
					{
						if (c != '>')
						{
							goto IL_96;
						}
						stringBuilder.Append("&gt;");
					}
					else
					{
						stringBuilder.Append("&lt;");
					}
				}
				else
				{
					stringBuilder.Append("&apos;");
				}
				IL_9E:
				i++;
				continue;
				IL_96:
				stringBuilder.Append(c);
				goto IL_9E;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x0005BDFC File Offset: 0x00059FFC
		private static string Unescape(string str)
		{
			if (str == null)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder(str);
			stringBuilder.Replace("&lt;", "<");
			stringBuilder.Replace("&gt;", ">");
			stringBuilder.Replace("&amp;", "&");
			stringBuilder.Replace("&quot;", "\"");
			stringBuilder.Replace("&apos;", "'");
			return stringBuilder.ToString();
		}

		/// <summary>Determines whether a string is a valid attribute name.</summary>
		/// <param name="name">The attribute name to test for validity. </param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="name" /> parameter is a valid XML attribute name; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600167F RID: 5759 RVA: 0x0005BE6E File Offset: 0x0005A06E
		public static bool IsValidAttributeName(string name)
		{
			return name != null && name.IndexOfAny(SecurityElement.invalid_attr_name_chars) == -1;
		}

		/// <summary>Determines whether a string is a valid attribute value.</summary>
		/// <param name="value">The attribute value to test for validity. </param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="value" /> parameter is a valid XML attribute value; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001680 RID: 5760 RVA: 0x0005BE83 File Offset: 0x0005A083
		public static bool IsValidAttributeValue(string value)
		{
			return value != null && value.IndexOfAny(SecurityElement.invalid_attr_value_chars) == -1;
		}

		/// <summary>Determines whether a string is a valid tag.</summary>
		/// <param name="tag">The tag to test for validity. </param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="tag" /> parameter is a valid XML tag; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001681 RID: 5761 RVA: 0x0005BE98 File Offset: 0x0005A098
		public static bool IsValidTag(string tag)
		{
			return tag != null && tag.IndexOfAny(SecurityElement.invalid_tag_chars) == -1;
		}

		/// <summary>Determines whether a string is valid as text within an XML element.</summary>
		/// <param name="text">The text to test for validity. </param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="text" /> parameter is a valid XML text element; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001682 RID: 5762 RVA: 0x0005BEAD File Offset: 0x0005A0AD
		public static bool IsValidText(string text)
		{
			return text != null && text.IndexOfAny(SecurityElement.invalid_text_chars) == -1;
		}

		/// <summary>Finds a child by its tag name.</summary>
		/// <param name="tag">The tag for which to search in child elements. </param>
		/// <returns>The first child XML element with the specified tag value, or <see langword="null" /> if no child element with <paramref name="tag" /> exists.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tag" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001683 RID: 5763 RVA: 0x0005BEC4 File Offset: 0x0005A0C4
		public SecurityElement SearchForChildByTag(string tag)
		{
			if (tag == null)
			{
				throw new ArgumentNullException("tag");
			}
			if (this.children == null)
			{
				return null;
			}
			for (int i = 0; i < this.children.Count; i++)
			{
				SecurityElement securityElement = (SecurityElement)this.children[i];
				if (securityElement.tag == tag)
				{
					return securityElement;
				}
			}
			return null;
		}

		/// <summary>Produces a string representation of an XML element and its constituent attributes, child elements, and text.</summary>
		/// <returns>The XML element and its contents.</returns>
		// Token: 0x06001684 RID: 5764 RVA: 0x0005BF24 File Offset: 0x0005A124
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			this.ToXml(ref stringBuilder, 0);
			return stringBuilder.ToString();
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x0005BF48 File Offset: 0x0005A148
		private void ToXml(ref StringBuilder s, int level)
		{
			s.Append("<");
			s.Append(this.tag);
			if (this.attributes != null)
			{
				s.Append(" ");
				for (int i = 0; i < this.attributes.Count; i++)
				{
					SecurityElement.SecurityAttribute securityAttribute = (SecurityElement.SecurityAttribute)this.attributes[i];
					s.Append(securityAttribute.Name).Append("=\"").Append(SecurityElement.Escape(securityAttribute.Value)).Append("\"");
					if (i != this.attributes.Count - 1)
					{
						s.Append(Environment.NewLine);
					}
				}
			}
			if ((this.text == null || this.text == string.Empty) && (this.children == null || this.children.Count == 0))
			{
				s.Append("/>").Append(Environment.NewLine);
				return;
			}
			s.Append(">").Append(SecurityElement.Escape(this.text));
			if (this.children != null)
			{
				s.Append(Environment.NewLine);
				foreach (object obj in this.children)
				{
					((SecurityElement)obj).ToXml(ref s, level + 1);
				}
			}
			s.Append("</").Append(this.tag).Append(">").Append(Environment.NewLine);
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x0005C0F4 File Offset: 0x0005A2F4
		internal SecurityElement.SecurityAttribute GetAttribute(string name)
		{
			if (this.attributes != null)
			{
				foreach (object obj in this.attributes)
				{
					SecurityElement.SecurityAttribute securityAttribute = (SecurityElement.SecurityAttribute)obj;
					if (securityAttribute.Name == name)
					{
						return securityAttribute;
					}
				}
			}
			return null;
		}

		// Token: 0x1700024E RID: 590
		// (set) Token: 0x06001687 RID: 5767 RVA: 0x0005C164 File Offset: 0x0005A364
		internal string m_strText
		{
			set
			{
				this.text = value;
			}
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x0005C170 File Offset: 0x0005A370
		internal string SearchForTextOfLocalName(string strLocalName)
		{
			if (strLocalName == null)
			{
				throw new ArgumentNullException("strLocalName");
			}
			if (this.tag == null)
			{
				return null;
			}
			if (this.tag.Equals(strLocalName) || this.tag.EndsWith(":" + strLocalName, StringComparison.Ordinal))
			{
				return SecurityElement.Unescape(this.text);
			}
			if (this.children == null)
			{
				return null;
			}
			foreach (object obj in this.children)
			{
				string text = ((SecurityElement)obj).SearchForTextOfLocalName(strLocalName);
				if (text != null)
				{
					return text;
				}
			}
			return null;
		}

		// Token: 0x040008BD RID: 2237
		private string text;

		// Token: 0x040008BE RID: 2238
		private string tag;

		// Token: 0x040008BF RID: 2239
		private ArrayList attributes;

		// Token: 0x040008C0 RID: 2240
		private ArrayList children;

		// Token: 0x040008C1 RID: 2241
		private static readonly char[] invalid_tag_chars = new char[]
		{
			' ',
			'<',
			'>'
		};

		// Token: 0x040008C2 RID: 2242
		private static readonly char[] invalid_text_chars = new char[]
		{
			'<',
			'>'
		};

		// Token: 0x040008C3 RID: 2243
		private static readonly char[] invalid_attr_name_chars = new char[]
		{
			' ',
			'<',
			'>'
		};

		// Token: 0x040008C4 RID: 2244
		private static readonly char[] invalid_attr_value_chars = new char[]
		{
			'"',
			'<',
			'>'
		};

		// Token: 0x040008C5 RID: 2245
		private static readonly char[] invalid_chars = new char[]
		{
			'<',
			'>',
			'"',
			'\'',
			'&'
		};

		// Token: 0x02000286 RID: 646
		internal class SecurityAttribute
		{
			// Token: 0x0600168A RID: 5770 RVA: 0x0005C27C File Offset: 0x0005A47C
			public SecurityAttribute(string name, string value)
			{
				if (!SecurityElement.IsValidAttributeName(name))
				{
					throw new ArgumentException(Locale.GetText("Invalid XML attribute name") + ": " + name);
				}
				if (!SecurityElement.IsValidAttributeValue(value))
				{
					throw new ArgumentException(Locale.GetText("Invalid XML attribute value") + ": " + value);
				}
				this._name = name;
				this._value = SecurityElement.Unescape(value);
			}

			// Token: 0x1700024F RID: 591
			// (get) Token: 0x0600168B RID: 5771 RVA: 0x0005C2E8 File Offset: 0x0005A4E8
			public string Name
			{
				get
				{
					return this._name;
				}
			}

			// Token: 0x17000250 RID: 592
			// (get) Token: 0x0600168C RID: 5772 RVA: 0x0005C2F0 File Offset: 0x0005A4F0
			public string Value
			{
				get
				{
					return this._value;
				}
			}

			// Token: 0x040008C6 RID: 2246
			private string _name;

			// Token: 0x040008C7 RID: 2247
			private string _value;
		}
	}
}
