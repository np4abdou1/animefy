using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000FE RID: 254
	[Serializable]
	internal sealed class OrdinalCaseSensitiveComparer : OrdinalComparer, ISerializable
	{
		// Token: 0x06000943 RID: 2371 RVA: 0x00029674 File Offset: 0x00027874
		public OrdinalCaseSensitiveComparer() : base(false)
		{
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0002967D File Offset: 0x0002787D
		public override int Compare(string x, string y)
		{
			return string.CompareOrdinal(x, y);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00029686 File Offset: 0x00027886
		public override bool Equals(string x, string y)
		{
			return string.Equals(x, y);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0002968F File Offset: 0x0002788F
		public override int GetHashCode(string obj)
		{
			if (obj == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.obj);
			}
			return obj.GetHashCode();
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x000296A0 File Offset: 0x000278A0
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.SetType(typeof(OrdinalComparer));
			info.AddValue("_ignoreCase", false);
		}
	}
}
