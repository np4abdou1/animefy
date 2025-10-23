using System;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	// Token: 0x02000145 RID: 325
	[Serializable]
	internal sealed class Empty : ISerializable
	{
		// Token: 0x06000C75 RID: 3189 RVA: 0x00003ACD File Offset: 0x00001CCD
		private Empty()
		{
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00011C1B File Offset: 0x0000FE1B
		public override string ToString()
		{
			return string.Empty;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00034453 File Offset: 0x00032653
		[SecurityCritical]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			UnitySerializationHolder.GetUnitySerializationInfo(info, 1, null, null);
		}

		// Token: 0x04000412 RID: 1042
		public static readonly Empty Value = new Empty();
	}
}
