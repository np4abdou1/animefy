using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200018B RID: 395
	[NullableContext(2)]
	[Nullable(0)]
	public class JTokenWriter : JsonWriter
	{
		// Token: 0x06000D8B RID: 3467 RVA: 0x0003BD65 File Offset: 0x00039F65
		[NullableContext(1)]
		internal override Task WriteTokenAsync(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, CancellationToken cancellationToken)
		{
			if (reader is JTokenReader)
			{
				this.WriteToken(reader, writeChildren, writeDateConstructorAsDate, writeComments);
				return AsyncUtils.CompletedTask;
			}
			return base.WriteTokenSyncReadingAsync(reader, cancellationToken);
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x0003BD89 File Offset: 0x00039F89
		public JToken CurrentToken
		{
			get
			{
				return this._current;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x0003BD91 File Offset: 0x00039F91
		public JToken Token
		{
			get
			{
				if (this._token != null)
				{
					return this._token;
				}
				return this._value;
			}
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0003BDA8 File Offset: 0x00039FA8
		[NullableContext(1)]
		public JTokenWriter(JContainer container)
		{
			ValidationUtils.ArgumentNotNull(container, "container");
			this._token = container;
			this._parent = container;
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0003BDC9 File Offset: 0x00039FC9
		public JTokenWriter()
		{
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x000153AD File Offset: 0x000135AD
		public override void Flush()
		{
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0003BDD1 File Offset: 0x00039FD1
		public override void Close()
		{
			base.Close();
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0003BDD9 File Offset: 0x00039FD9
		public override void WriteStartObject()
		{
			base.WriteStartObject();
			this.AddParent(new JObject());
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0003BDEC File Offset: 0x00039FEC
		[NullableContext(1)]
		private void AddParent(JContainer container)
		{
			if (this._parent == null)
			{
				this._token = container;
			}
			else
			{
				this._parent.AddAndSkipParentCheck(container);
			}
			this._parent = container;
			this._current = container;
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0003BE1C File Offset: 0x0003A01C
		private void RemoveParent()
		{
			this._current = this._parent;
			this._parent = this._parent.Parent;
			if (this._parent != null && this._parent.Type == JTokenType.Property)
			{
				this._parent = this._parent.Parent;
			}
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0003BE6D File Offset: 0x0003A06D
		public override void WriteStartArray()
		{
			base.WriteStartArray();
			this.AddParent(new JArray());
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x0003BE80 File Offset: 0x0003A080
		[NullableContext(1)]
		public override void WriteStartConstructor(string name)
		{
			base.WriteStartConstructor(name);
			this.AddParent(new JConstructor(name));
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x0003BE95 File Offset: 0x0003A095
		protected override void WriteEnd(JsonToken token)
		{
			this.RemoveParent();
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x0003BE9D File Offset: 0x0003A09D
		[NullableContext(1)]
		public override void WritePropertyName(string name)
		{
			JObject jobject = this._parent as JObject;
			if (jobject != null)
			{
				jobject.Remove(name);
			}
			this.AddParent(new JProperty(name));
			base.WritePropertyName(name);
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0003BECA File Offset: 0x0003A0CA
		private void AddRawValue(object value, JTokenType type, JsonToken token)
		{
			this.AddJValue(new JValue(value, type), token);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x0003BEDC File Offset: 0x0003A0DC
		internal void AddJValue(JValue value, JsonToken token)
		{
			if (this._parent != null)
			{
				if (this._parent.TryAdd(value))
				{
					this._current = this._parent.Last;
					if (this._parent.Type == JTokenType.Property)
					{
						this._parent = this._parent.Parent;
						return;
					}
				}
			}
			else
			{
				this._value = (value ?? JValue.CreateNull());
				this._current = this._value;
			}
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x0003BF4C File Offset: 0x0003A14C
		public override void WriteValue(object value)
		{
			if (value is BigInteger)
			{
				base.InternalWriteValue(JsonToken.Integer);
				this.AddRawValue(value, JTokenType.Integer, JsonToken.Integer);
				return;
			}
			base.WriteValue(value);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x0003BF6E File Offset: 0x0003A16E
		public override void WriteNull()
		{
			base.WriteNull();
			this.AddJValue(JValue.CreateNull(), JsonToken.Null);
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x0003BF83 File Offset: 0x0003A183
		public override void WriteUndefined()
		{
			base.WriteUndefined();
			this.AddJValue(JValue.CreateUndefined(), JsonToken.Undefined);
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x0003BF98 File Offset: 0x0003A198
		public override void WriteRaw(string json)
		{
			base.WriteRaw(json);
			this.AddJValue(new JRaw(json), JsonToken.Raw);
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x0003BFAE File Offset: 0x0003A1AE
		public override void WriteComment(string text)
		{
			base.WriteComment(text);
			this.AddJValue(JValue.CreateComment(text), JsonToken.Comment);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0003BFC4 File Offset: 0x0003A1C4
		public override void WriteValue(string value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			base.WriteValue(value);
			this.AddJValue(new JValue(value), JsonToken.String);
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0003BFE5 File Offset: 0x0003A1E5
		public override void WriteValue(int value)
		{
			base.WriteValue(value);
			this.AddRawValue(value, JTokenType.Integer, JsonToken.Integer);
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0003BFFC File Offset: 0x0003A1FC
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
			base.WriteValue(value);
			this.AddRawValue(value, JTokenType.Integer, JsonToken.Integer);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0003C013 File Offset: 0x0003A213
		public override void WriteValue(long value)
		{
			base.WriteValue(value);
			this.AddJValue(new JValue(value), JsonToken.Integer);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0003C029 File Offset: 0x0003A229
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
			base.WriteValue(value);
			this.AddJValue(new JValue(value), JsonToken.Integer);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0003C03F File Offset: 0x0003A23F
		public override void WriteValue(float value)
		{
			base.WriteValue(value);
			this.AddJValue(new JValue(value), JsonToken.Float);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0003C055 File Offset: 0x0003A255
		public override void WriteValue(double value)
		{
			base.WriteValue(value);
			this.AddJValue(new JValue(value), JsonToken.Float);
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x0003C06B File Offset: 0x0003A26B
		public override void WriteValue(bool value)
		{
			base.WriteValue(value);
			this.AddJValue(new JValue(value), JsonToken.Boolean);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0003C082 File Offset: 0x0003A282
		public override void WriteValue(short value)
		{
			base.WriteValue(value);
			this.AddRawValue(value, JTokenType.Integer, JsonToken.Integer);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0003C099 File Offset: 0x0003A299
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
			base.WriteValue(value);
			this.AddRawValue(value, JTokenType.Integer, JsonToken.Integer);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0003C0B0 File Offset: 0x0003A2B0
		public override void WriteValue(char value)
		{
			base.WriteValue(value);
			string value2 = value.ToString(CultureInfo.InvariantCulture);
			this.AddJValue(new JValue(value2), JsonToken.String);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x0003C0DF File Offset: 0x0003A2DF
		public override void WriteValue(byte value)
		{
			base.WriteValue(value);
			this.AddRawValue(value, JTokenType.Integer, JsonToken.Integer);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0003C0F6 File Offset: 0x0003A2F6
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
			base.WriteValue(value);
			this.AddRawValue(value, JTokenType.Integer, JsonToken.Integer);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0003C10D File Offset: 0x0003A30D
		public override void WriteValue(decimal value)
		{
			base.WriteValue(value);
			this.AddJValue(new JValue(value), JsonToken.Float);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0003C123 File Offset: 0x0003A323
		public override void WriteValue(DateTime value)
		{
			base.WriteValue(value);
			value = DateTimeUtils.EnsureDateTime(value, base.DateTimeZoneHandling);
			this.AddJValue(new JValue(value), JsonToken.Date);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0003C148 File Offset: 0x0003A348
		public override void WriteValue(DateTimeOffset value)
		{
			base.WriteValue(value);
			this.AddJValue(new JValue(value), JsonToken.Date);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0003C15F File Offset: 0x0003A35F
		public override void WriteValue(byte[] value)
		{
			base.WriteValue(value);
			this.AddJValue(new JValue(value, JTokenType.Bytes), JsonToken.Bytes);
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0003C178 File Offset: 0x0003A378
		public override void WriteValue(TimeSpan value)
		{
			base.WriteValue(value);
			this.AddJValue(new JValue(value), JsonToken.String);
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0003C18F File Offset: 0x0003A38F
		public override void WriteValue(Guid value)
		{
			base.WriteValue(value);
			this.AddJValue(new JValue(value), JsonToken.String);
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0003C1A6 File Offset: 0x0003A3A6
		public override void WriteValue(Uri value)
		{
			base.WriteValue(value);
			this.AddJValue(new JValue(value), JsonToken.String);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0003C1C0 File Offset: 0x0003A3C0
		[NullableContext(1)]
		internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
			JTokenReader jtokenReader = reader as JTokenReader;
			if (jtokenReader == null || !writeChildren || !writeDateConstructorAsDate || !writeComments)
			{
				base.WriteToken(reader, writeChildren, writeDateConstructorAsDate, writeComments);
				return;
			}
			if (jtokenReader.TokenType == JsonToken.None && !jtokenReader.Read())
			{
				return;
			}
			JToken jtoken = jtokenReader.CurrentToken.CloneToken(null);
			if (this._parent != null)
			{
				this._parent.Add(jtoken);
				this._current = this._parent.Last;
				if (this._parent.Type == JTokenType.Property)
				{
					this._parent = this._parent.Parent;
					base.InternalWriteValue(JsonToken.Null);
				}
			}
			else
			{
				this._current = jtoken;
				if (this._token == null && this._value == null)
				{
					this._token = (jtoken as JContainer);
					this._value = (jtoken as JValue);
				}
			}
			jtokenReader.Skip();
		}

		// Token: 0x04000756 RID: 1878
		private JContainer _token;

		// Token: 0x04000757 RID: 1879
		private JContainer _parent;

		// Token: 0x04000758 RID: 1880
		private JValue _value;

		// Token: 0x04000759 RID: 1881
		private JToken _current;
	}
}
