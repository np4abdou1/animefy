﻿using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x0200001C RID: 28
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class JsonConverter<[Nullable(2)] T> : JsonConverter
	{
		// Token: 0x06000088 RID: 136 RVA: 0x00002E68 File Offset: 0x00001068
		public sealed override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			if (!((value != null) ? (value is T) : ReflectionUtils.IsNullable(typeof(T))))
			{
				throw new JsonSerializationException("Converter cannot write specified value to JSON. {0} is required.".FormatWith(CultureInfo.InvariantCulture, typeof(T)));
			}
			this.WriteJson(writer, (T)((object)value), serializer);
		}

		// Token: 0x06000089 RID: 137
		public abstract void WriteJson(JsonWriter writer, [Nullable(2)] T value, JsonSerializer serializer);

		// Token: 0x0600008A RID: 138 RVA: 0x00002EC4 File Offset: 0x000010C4
		[return: Nullable(2)]
		public sealed override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			bool flag = existingValue == null;
			if (!flag && !(existingValue is T))
			{
				throw new JsonSerializationException("Converter cannot read JSON with the specified existing value. {0} is required.".FormatWith(CultureInfo.InvariantCulture, typeof(T)));
			}
			return this.ReadJson(reader, objectType, flag ? default(T) : ((T)((object)existingValue)), !flag, serializer);
		}

		// Token: 0x0600008B RID: 139
		[return: Nullable(2)]
		public abstract T ReadJson(JsonReader reader, Type objectType, [Nullable(2)] T existingValue, bool hasExistingValue, JsonSerializer serializer);

		// Token: 0x0600008C RID: 140 RVA: 0x00002F27 File Offset: 0x00001127
		public sealed override bool CanConvert(Type objectType)
		{
			return typeof(T).IsAssignableFrom(objectType);
		}
	}
}
