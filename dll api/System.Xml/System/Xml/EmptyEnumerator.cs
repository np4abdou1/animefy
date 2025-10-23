using System;
using System.Collections;

namespace System.Xml
{
	// Token: 0x02000159 RID: 345
	internal sealed class EmptyEnumerator : IEnumerator
	{
		// Token: 0x06000CE2 RID: 3298 RVA: 0x0000A216 File Offset: 0x00008416
		bool IEnumerator.MoveNext()
		{
			return false;
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00008574 File Offset: 0x00006774
		void IEnumerator.Reset()
		{
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00008B54 File Offset: 0x00006D54
		object IEnumerator.Current
		{
			get
			{
				throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
			}
		}
	}
}
