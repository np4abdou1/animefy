using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000FF RID: 255
	[Serializable]
	internal sealed class OrdinalIgnoreCaseComparer : OrdinalComparer, ISerializable
	{
		// Token: 0x06000948 RID: 2376 RVA: 0x000296BE File Offset: 0x000278BE
		public OrdinalIgnoreCaseComparer() : base(true)
		{
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x000296C7 File Offset: 0x000278C7
		public override int Compare(string x, string y)
		{
			return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x000296D1 File Offset: 0x000278D1
		public override bool Equals(string x, string y)
		{
			return string.Equals(x, y, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x000296DB File Offset: 0x000278DB
		public override int GetHashCode(string obj)
		{
			if (obj == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.obj);
			}
			return CompareInfo.GetIgnoreCaseHash(obj);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x000296EC File Offset: 0x000278EC
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.SetType(typeof(OrdinalComparer));
			info.AddValue("_ignoreCase", true);
		}
	}
}
