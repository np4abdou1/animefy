using System;
using System.Collections;

namespace System.Xml
{
	// Token: 0x02000138 RID: 312
	internal sealed class XmlChildEnumerator : IEnumerator
	{
		// Token: 0x06000AA2 RID: 2722 RVA: 0x00047123 File Offset: 0x00045323
		internal XmlChildEnumerator(XmlNode container)
		{
			this.container = container;
			this.child = container.FirstChild;
			this.isFirst = true;
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00047145 File Offset: 0x00045345
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00047150 File Offset: 0x00045350
		internal bool MoveNext()
		{
			if (this.isFirst)
			{
				this.child = this.container.FirstChild;
				this.isFirst = false;
			}
			else if (this.child != null)
			{
				this.child = this.child.NextSibling;
			}
			return this.child != null;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x000471A1 File Offset: 0x000453A1
		void IEnumerator.Reset()
		{
			this.isFirst = true;
			this.child = this.container.FirstChild;
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x000471BB File Offset: 0x000453BB
		object IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x000471C3 File Offset: 0x000453C3
		internal XmlNode Current
		{
			get
			{
				if (this.isFirst || this.child == null)
				{
					throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
				}
				return this.child;
			}
		}

		// Token: 0x04000865 RID: 2149
		internal XmlNode container;

		// Token: 0x04000866 RID: 2150
		internal XmlNode child;

		// Token: 0x04000867 RID: 2151
		internal bool isFirst;
	}
}
