using System;
using MS.Internal.Xml.XPath;

namespace System.Xml.Schema
{
	// Token: 0x02000223 RID: 547
	internal class DoubleLinkAxis : Axis
	{
		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x0006FBE8 File Offset: 0x0006DDE8
		// (set) Token: 0x06001209 RID: 4617 RVA: 0x0006FBF0 File Offset: 0x0006DDF0
		internal Axis Next
		{
			get
			{
				return this.next;
			}
			set
			{
				this.next = value;
			}
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0006FBFC File Offset: 0x0006DDFC
		internal DoubleLinkAxis(Axis axis, DoubleLinkAxis inputaxis) : base(axis.TypeOfAxis, inputaxis, axis.Prefix, axis.Name, axis.NodeType)
		{
			this.next = null;
			base.Urn = axis.Urn;
			this.abbrAxis = axis.AbbrAxis;
			if (inputaxis != null)
			{
				inputaxis.Next = this;
			}
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0006FC51 File Offset: 0x0006DE51
		internal static DoubleLinkAxis ConvertTree(Axis axis)
		{
			if (axis == null)
			{
				return null;
			}
			return new DoubleLinkAxis(axis, DoubleLinkAxis.ConvertTree((Axis)axis.Input));
		}

		// Token: 0x04000C44 RID: 3140
		internal Axis next;
	}
}
