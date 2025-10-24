﻿using System;

namespace System.Xml.Linq
{
	/// <summary>Provides data for the <see cref="E:System.Xml.Linq.XObject.Changing" /> and <see cref="E:System.Xml.Linq.XObject.Changed" /> events.</summary>
	// Token: 0x02000035 RID: 53
	public class XObjectChangeEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XObjectChangeEventArgs" /> class. </summary>
		/// <param name="objectChange">An <see cref="T:System.Xml.Linq.XObjectChange" /> that contains the event arguments for LINQ to XML events.</param>
		// Token: 0x0600018B RID: 395 RVA: 0x0000897B File Offset: 0x00006B7B
		public XObjectChangeEventArgs(XObjectChange objectChange)
		{
			this._objectChange = objectChange;
		}

		// Token: 0x040000DD RID: 221
		private XObjectChange _objectChange;

		/// <summary>Event argument for an <see cref="F:System.Xml.Linq.XObjectChange.Add" /> change event.</summary>
		// Token: 0x040000DE RID: 222
		public static readonly XObjectChangeEventArgs Add = new XObjectChangeEventArgs(XObjectChange.Add);

		/// <summary>Event argument for a <see cref="F:System.Xml.Linq.XObjectChange.Remove" /> change event.</summary>
		// Token: 0x040000DF RID: 223
		public static readonly XObjectChangeEventArgs Remove = new XObjectChangeEventArgs(XObjectChange.Remove);

		/// <summary>Event argument for a <see cref="F:System.Xml.Linq.XObjectChange.Name" /> change event.</summary>
		// Token: 0x040000E0 RID: 224
		public static readonly XObjectChangeEventArgs Name = new XObjectChangeEventArgs(XObjectChange.Name);

		/// <summary>Event argument for a <see cref="F:System.Xml.Linq.XObjectChange.Value" /> change event.</summary>
		// Token: 0x040000E1 RID: 225
		public static readonly XObjectChangeEventArgs Value = new XObjectChangeEventArgs(XObjectChange.Value);
	}
}
