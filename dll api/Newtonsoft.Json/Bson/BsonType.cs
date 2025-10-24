using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001E4 RID: 484
	internal enum BsonType : sbyte
	{
		// Token: 0x04000867 RID: 2151
		Number = 1,
		// Token: 0x04000868 RID: 2152
		String,
		// Token: 0x04000869 RID: 2153
		Object,
		// Token: 0x0400086A RID: 2154
		Array,
		// Token: 0x0400086B RID: 2155
		Binary,
		// Token: 0x0400086C RID: 2156
		Undefined,
		// Token: 0x0400086D RID: 2157
		Oid,
		// Token: 0x0400086E RID: 2158
		Boolean,
		// Token: 0x0400086F RID: 2159
		Date,
		// Token: 0x04000870 RID: 2160
		Null,
		// Token: 0x04000871 RID: 2161
		Regex,
		// Token: 0x04000872 RID: 2162
		Reference,
		// Token: 0x04000873 RID: 2163
		Code,
		// Token: 0x04000874 RID: 2164
		Symbol,
		// Token: 0x04000875 RID: 2165
		CodeWScope,
		// Token: 0x04000876 RID: 2166
		Integer,
		// Token: 0x04000877 RID: 2167
		TimeStamp,
		// Token: 0x04000878 RID: 2168
		Long,
		// Token: 0x04000879 RID: 2169
		MinKey = -1,
		// Token: 0x0400087A RID: 2170
		MaxKey = 127
	}
}
