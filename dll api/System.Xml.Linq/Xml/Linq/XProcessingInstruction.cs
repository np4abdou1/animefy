using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Xml.Linq
{
	/// <summary>Represents an XML processing instruction. </summary>
	// Token: 0x02000036 RID: 54
	public class XProcessingInstruction : XNode
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XProcessingInstruction" /> class. </summary>
		/// <param name="target">A <see cref="T:System.String" /> containing the target application for this <see cref="T:System.Xml.Linq.XProcessingInstruction" />.</param>
		/// <param name="data">The string data for this <see cref="T:System.Xml.Linq.XProcessingInstruction" />.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="target" /> or <paramref name="data" /> parameter is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="target" /> does not follow the constraints of an XML name.</exception>
		// Token: 0x0600018D RID: 397 RVA: 0x000089B8 File Offset: 0x00006BB8
		public XProcessingInstruction(string target, string data)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			XProcessingInstruction.ValidateName(target);
			this.target = target;
			this.data = data;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XProcessingInstruction" /> class. </summary>
		/// <param name="other">The <see cref="T:System.Xml.Linq.XProcessingInstruction" /> node to copy from.</param>
		// Token: 0x0600018E RID: 398 RVA: 0x000089E2 File Offset: 0x00006BE2
		public XProcessingInstruction(XProcessingInstruction other)
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			this.target = other.target;
			this.data = other.data;
		}

		/// <summary>Gets or sets the string value of this processing instruction.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the string value of this processing instruction.</returns>
		/// <exception cref="T:System.ArgumentNullException">The string <paramref name="value" /> is <see langword="null" />.</exception>
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00008A10 File Offset: 0x00006C10
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00008A18 File Offset: 0x00006C18
		public string Data
		{
			get
			{
				return this.data;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				bool flag = base.NotifyChanging(this, XObjectChangeEventArgs.Value);
				this.data = value;
				if (flag)
				{
					base.NotifyChanged(this, XObjectChangeEventArgs.Value);
				}
			}
		}

		/// <summary>Gets the node type for this node.</summary>
		/// <returns>The node type. For <see cref="T:System.Xml.Linq.XProcessingInstruction" /> objects, this value is <see cref="F:System.Xml.XmlNodeType.ProcessingInstruction" />.</returns>
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00008A4A File Offset: 0x00006C4A
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.ProcessingInstruction;
			}
		}

		/// <summary>Gets or sets a string containing the target application for this processing instruction.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the target application for this processing instruction.</returns>
		/// <exception cref="T:System.ArgumentNullException">The string <paramref name="value" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="target" /> does not follow the constraints of an XML name.</exception>
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00008A4D File Offset: 0x00006C4D
		public string Target
		{
			get
			{
				return this.target;
			}
		}

		/// <summary>Writes this processing instruction to an <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> to write this processing instruction to.</param>
		// Token: 0x06000193 RID: 403 RVA: 0x00008A55 File Offset: 0x00006C55
		public override void WriteTo(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			writer.WriteProcessingInstruction(this.target, this.data);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00008A77 File Offset: 0x00006C77
		public override Task WriteToAsync(XmlWriter writer, CancellationToken cancellationToken)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			return writer.WriteProcessingInstructionAsync(this.target, this.data);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00008AA9 File Offset: 0x00006CA9
		internal override XNode CloneNode()
		{
			return new XProcessingInstruction(this);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00008AB4 File Offset: 0x00006CB4
		internal override bool DeepEquals(XNode node)
		{
			XProcessingInstruction xprocessingInstruction = node as XProcessingInstruction;
			return xprocessingInstruction != null && this.target == xprocessingInstruction.target && this.data == xprocessingInstruction.data;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00008AF1 File Offset: 0x00006CF1
		internal override int GetDeepHashCode()
		{
			return this.target.GetHashCode() ^ this.data.GetHashCode();
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00008B0A File Offset: 0x00006D0A
		private static void ValidateName(string name)
		{
			XmlConvert.VerifyNCName(name);
			if (string.Equals(name, "xml", StringComparison.OrdinalIgnoreCase))
			{
				throw new ArgumentException(SR.Format("'{0}' is an invalid name for a processing instruction.", name));
			}
		}

		// Token: 0x040000E2 RID: 226
		internal string target;

		// Token: 0x040000E3 RID: 227
		internal string data;
	}
}
