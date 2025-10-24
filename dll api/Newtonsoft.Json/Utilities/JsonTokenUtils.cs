using System;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000D3 RID: 211
	internal static class JsonTokenUtils
	{
		// Token: 0x0600065C RID: 1628 RVA: 0x0002229E File Offset: 0x0002049E
		internal static bool IsEndToken(JsonToken token)
		{
			return token - JsonToken.EndObject <= 2;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x000222AA File Offset: 0x000204AA
		internal static bool IsStartToken(JsonToken token)
		{
			return token - JsonToken.StartObject <= 2;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x000222B5 File Offset: 0x000204B5
		internal static bool IsPrimitiveToken(JsonToken token)
		{
			return token - JsonToken.Integer <= 5 || token - JsonToken.Date <= 1;
		}
	}
}
