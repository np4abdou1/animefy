using System;

namespace System.Xml
{
	/// <summary>Provides data for the <see cref="E:System.Xml.XmlDocument.NodeChanged" />, <see cref="E:System.Xml.XmlDocument.NodeChanging" />, <see cref="E:System.Xml.XmlDocument.NodeInserted" />, <see cref="E:System.Xml.XmlDocument.NodeInserting" />, <see cref="E:System.Xml.XmlDocument.NodeRemoved" /> and <see cref="E:System.Xml.XmlDocument.NodeRemoving" /> events.</summary>
	// Token: 0x0200014D RID: 333
	public class XmlNodeChangedEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlNodeChangedEventArgs" /> class.</summary>
		/// <param name="node">The <see cref="T:System.Xml.XmlNode" /> that generated the event.</param>
		/// <param name="oldParent">The old parent <see cref="T:System.Xml.XmlNode" /> of the <see cref="T:System.Xml.XmlNode" /> that generated the event.</param>
		/// <param name="newParent">The new parent <see cref="T:System.Xml.XmlNode" /> of the <see cref="T:System.Xml.XmlNode" /> that generated the event.</param>
		/// <param name="oldValue">The old value of the <see cref="T:System.Xml.XmlNode" /> that generated the event.</param>
		/// <param name="newValue">The new value of the <see cref="T:System.Xml.XmlNode" /> that generated the event.</param>
		/// <param name="action">The <see cref="T:System.Xml.XmlNodeChangedAction" />.</param>
		// Token: 0x06000C2F RID: 3119 RVA: 0x0004C6E2 File Offset: 0x0004A8E2
		public XmlNodeChangedEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
			this.node = node;
			this.oldParent = oldParent;
			this.newParent = newParent;
			this.action = action;
			this.oldValue = oldValue;
			this.newValue = newValue;
		}

		/// <summary>Gets a value indicating what type of node change event is occurring.</summary>
		/// <returns>An <see langword="XmlNodeChangedAction" /> value describing the node change event.XmlNodeChangedAction Value Description Insert A node has been or will be inserted. Remove A node has been or will be removed. Change A node has been or will be changed. The <see langword="Action" /> value does not differentiate between when the event occurred (before or after). You can create separate event handlers to handle both instances.</returns>
		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x0004C717 File Offset: 0x0004A917
		public XmlNodeChangedAction Action
		{
			get
			{
				return this.action;
			}
		}

		// Token: 0x040008C8 RID: 2248
		private XmlNodeChangedAction action;

		// Token: 0x040008C9 RID: 2249
		private XmlNode node;

		// Token: 0x040008CA RID: 2250
		private XmlNode oldParent;

		// Token: 0x040008CB RID: 2251
		private XmlNode newParent;

		// Token: 0x040008CC RID: 2252
		private string oldValue;

		// Token: 0x040008CD RID: 2253
		private string newValue;
	}
}
