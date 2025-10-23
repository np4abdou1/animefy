using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001B0 RID: 432
	public abstract class DateTimeConverterBase : JsonConverter
	{
		// Token: 0x06000EB4 RID: 3764 RVA: 0x0004140C File Offset: 0x0003F60C
		[NullableContext(1)]
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(DateTime) || objectType == typeof(DateTime?) || (objectType == typeof(DateTimeOffset) || objectType == typeof(DateTimeOffset?));
		}
	}
}
