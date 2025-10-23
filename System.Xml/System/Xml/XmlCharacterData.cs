using System;

namespace System.Xml
{
	/// <summary>Provides text manipulation methods that are used by several classes.</summary>
	// Token: 0x02000137 RID: 311
	public abstract class XmlCharacterData : XmlLinkedNode
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlCharacterData" /> class.</summary>
		/// <param name="data">String that contains character data to be added to document.</param>
		/// <param name="doc">
		///       <see cref="T:System.Xml.XmlDocument" /> to contain character data.</param>
		// Token: 0x06000A9A RID: 2714 RVA: 0x00047079 File Offset: 0x00045279
		protected internal XmlCharacterData(string data, XmlDocument doc) : base(doc)
		{
			this.data = data;
		}

		/// <summary>Gets or sets the value of the node.</summary>
		/// <returns>The value of the node.</returns>
		/// <exception cref="T:System.ArgumentException">Node is read-only. </exception>
		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00047089 File Offset: 0x00045289
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x00047091 File Offset: 0x00045291
		public override string Value
		{
			get
			{
				return this.Data;
			}
			set
			{
				this.Data = value;
			}
		}

		/// <summary>Gets or sets the concatenated values of the node and all the children of the node.</summary>
		/// <returns>The concatenated values of the node and all the children of the node.</returns>
		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0004709A File Offset: 0x0004529A
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x000470A2 File Offset: 0x000452A2
		public override string InnerText
		{
			get
			{
				return this.Value;
			}
			set
			{
				this.Value = value;
			}
		}

		/// <summary>Contains the data of the node.</summary>
		/// <returns>The data of the node.</returns>
		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x000470AB File Offset: 0x000452AB
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x000470C4 File Offset: 0x000452C4
		public virtual string Data
		{
			get
			{
				if (this.data != null)
				{
					return this.data;
				}
				return string.Empty;
			}
			set
			{
				XmlNode parentNode = this.ParentNode;
				XmlNodeChangedEventArgs eventArgs = this.GetEventArgs(this, parentNode, parentNode, this.data, value, XmlNodeChangedAction.Change);
				if (eventArgs != null)
				{
					this.BeforeEvent(eventArgs);
				}
				this.data = value;
				if (eventArgs != null)
				{
					this.AfterEvent(eventArgs);
				}
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00047108 File Offset: 0x00045308
		internal bool CheckOnData(string data)
		{
			return XmlCharType.Instance.IsOnlyWhitespace(data);
		}

		// Token: 0x04000864 RID: 2148
		private string data;
	}
}
