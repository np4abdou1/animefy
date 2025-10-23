using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001E5 RID: 485
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonWriter : JsonWriter
	{
		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x00046ABA File Offset: 0x00044CBA
		// (set) Token: 0x0600102F RID: 4143 RVA: 0x00046AC7 File Offset: 0x00044CC7
		public DateTimeKind DateTimeKindHandling
		{
			get
			{
				return this._writer.DateTimeKindHandling;
			}
			set
			{
				this._writer.DateTimeKindHandling = value;
			}
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00046AD5 File Offset: 0x00044CD5
		public BsonWriter(Stream stream)
		{
			ValidationUtils.ArgumentNotNull(stream, "stream");
			this._writer = new BsonBinaryWriter(new BinaryWriter(stream));
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00046AF9 File Offset: 0x00044CF9
		public BsonWriter(BinaryWriter writer)
		{
			ValidationUtils.ArgumentNotNull(writer, "writer");
			this._writer = new BsonBinaryWriter(writer);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00046B18 File Offset: 0x00044D18
		public override void Flush()
		{
			this._writer.Flush();
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00046B25 File Offset: 0x00044D25
		protected override void WriteEnd(JsonToken token)
		{
			base.WriteEnd(token);
			this.RemoveParent();
			if (base.Top == 0)
			{
				this._writer.WriteToken(this._root);
			}
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x00046B4D File Offset: 0x00044D4D
		public override void WriteComment(string text)
		{
			throw JsonWriterException.Create(this, "Cannot write JSON comment as BSON.", null);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00046B5B File Offset: 0x00044D5B
		public override void WriteStartConstructor(string name)
		{
			throw JsonWriterException.Create(this, "Cannot write JSON constructor as BSON.", null);
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00046B69 File Offset: 0x00044D69
		public override void WriteRaw(string json)
		{
			throw JsonWriterException.Create(this, "Cannot write raw JSON as BSON.", null);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00046B69 File Offset: 0x00044D69
		public override void WriteRawValue(string json)
		{
			throw JsonWriterException.Create(this, "Cannot write raw JSON as BSON.", null);
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00046B77 File Offset: 0x00044D77
		public override void WriteStartArray()
		{
			base.WriteStartArray();
			this.AddParent(new BsonArray());
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00046B8A File Offset: 0x00044D8A
		public override void WriteStartObject()
		{
			base.WriteStartObject();
			this.AddParent(new BsonObject());
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00046B9D File Offset: 0x00044D9D
		public override void WritePropertyName(string name)
		{
			base.WritePropertyName(name);
			this._propertyName = name;
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x00046BAD File Offset: 0x00044DAD
		public override void Close()
		{
			base.Close();
			if (base.CloseOutput)
			{
				BsonBinaryWriter writer = this._writer;
				if (writer == null)
				{
					return;
				}
				writer.Close();
			}
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x00046BCD File Offset: 0x00044DCD
		private void AddParent(BsonToken container)
		{
			this.AddToken(container);
			this._parent = container;
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x00046BDD File Offset: 0x00044DDD
		private void RemoveParent()
		{
			this._parent = this._parent.Parent;
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x00046BF0 File Offset: 0x00044DF0
		private void AddValue(object value, BsonType type)
		{
			this.AddToken(new BsonValue(value, type));
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x00046C00 File Offset: 0x00044E00
		internal void AddToken(BsonToken token)
		{
			if (this._parent != null)
			{
				BsonObject bsonObject = this._parent as BsonObject;
				if (bsonObject != null)
				{
					bsonObject.Add(this._propertyName, token);
					this._propertyName = null;
					return;
				}
				((BsonArray)this._parent).Add(token);
				return;
			}
			else
			{
				if (token.Type != BsonType.Object && token.Type != BsonType.Array)
				{
					throw JsonWriterException.Create(this, "Error writing {0} value. BSON must start with an Object or Array.".FormatWith(CultureInfo.InvariantCulture, token.Type), null);
				}
				this._parent = token;
				this._root = token;
				return;
			}
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x00046C90 File Offset: 0x00044E90
		public override void WriteValue(object value)
		{
			if (value is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)value;
				base.SetWriteState(JsonToken.Integer, null);
				this.AddToken(new BsonBinary(bigInteger.ToByteArray(), BsonBinaryType.Binary));
				return;
			}
			base.WriteValue(value);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00046CCF File Offset: 0x00044ECF
		public override void WriteNull()
		{
			base.WriteNull();
			this.AddToken(BsonEmpty.Null);
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00046CE2 File Offset: 0x00044EE2
		public override void WriteUndefined()
		{
			base.WriteUndefined();
			this.AddToken(BsonEmpty.Undefined);
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00046CF5 File Offset: 0x00044EF5
		public override void WriteValue(string value)
		{
			base.WriteValue(value);
			this.AddToken((value == null) ? BsonEmpty.Null : new BsonString(value, true));
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00046D15 File Offset: 0x00044F15
		public override void WriteValue(int value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Integer);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00046D2C File Offset: 0x00044F2C
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
			if (value > 2147483647U)
			{
				throw JsonWriterException.Create(this, "Value is too large to fit in a signed 32 bit integer. BSON does not support unsigned values.", null);
			}
			base.WriteValue(value);
			this.AddValue(value, BsonType.Integer);
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00046D58 File Offset: 0x00044F58
		public override void WriteValue(long value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Long);
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00046D6F File Offset: 0x00044F6F
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
			if (value > 9223372036854775807UL)
			{
				throw JsonWriterException.Create(this, "Value is too large to fit in a signed 64 bit integer. BSON does not support unsigned values.", null);
			}
			base.WriteValue(value);
			this.AddValue(value, BsonType.Long);
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00046D9F File Offset: 0x00044F9F
		public override void WriteValue(float value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Number);
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00046DB5 File Offset: 0x00044FB5
		public override void WriteValue(double value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Number);
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x00046DCB File Offset: 0x00044FCB
		public override void WriteValue(bool value)
		{
			base.WriteValue(value);
			this.AddToken(value ? BsonBoolean.True : BsonBoolean.False);
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00046DE9 File Offset: 0x00044FE9
		public override void WriteValue(short value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Integer);
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00046E00 File Offset: 0x00045000
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Integer);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00046E18 File Offset: 0x00045018
		public override void WriteValue(char value)
		{
			base.WriteValue(value);
			string value2 = value.ToString(CultureInfo.InvariantCulture);
			this.AddToken(new BsonString(value2, true));
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00046E48 File Offset: 0x00045048
		public override void WriteValue(byte value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Integer);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00046E5F File Offset: 0x0004505F
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Integer);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00046E76 File Offset: 0x00045076
		public override void WriteValue(decimal value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Number);
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00046E8C File Offset: 0x0004508C
		public override void WriteValue(DateTime value)
		{
			base.WriteValue(value);
			value = DateTimeUtils.EnsureDateTime(value, base.DateTimeZoneHandling);
			this.AddValue(value, BsonType.Date);
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00046EB1 File Offset: 0x000450B1
		public override void WriteValue(DateTimeOffset value)
		{
			base.WriteValue(value);
			this.AddValue(value, BsonType.Date);
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x00046EC8 File Offset: 0x000450C8
		public override void WriteValue(byte[] value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			base.WriteValue(value);
			this.AddToken(new BsonBinary(value, BsonBinaryType.Binary));
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00046EE8 File Offset: 0x000450E8
		public override void WriteValue(Guid value)
		{
			base.WriteValue(value);
			this.AddToken(new BsonBinary(value.ToByteArray(), BsonBinaryType.Uuid));
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00046F04 File Offset: 0x00045104
		public override void WriteValue(TimeSpan value)
		{
			base.WriteValue(value);
			this.AddToken(new BsonString(value.ToString(), true));
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00046F26 File Offset: 0x00045126
		public override void WriteValue(Uri value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			base.WriteValue(value);
			this.AddToken(new BsonString(value.ToString(), true));
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00046F51 File Offset: 0x00045151
		public void WriteObjectId(byte[] value)
		{
			ValidationUtils.ArgumentNotNull(value, "value");
			if (value.Length != 12)
			{
				throw JsonWriterException.Create(this, "An object id must be 12 bytes", null);
			}
			base.SetWriteState(JsonToken.Undefined, null);
			this.AddValue(value, BsonType.Oid);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00046F83 File Offset: 0x00045183
		public void WriteRegex(string pattern, string options)
		{
			ValidationUtils.ArgumentNotNull(pattern, "pattern");
			base.SetWriteState(JsonToken.Undefined, null);
			this.AddToken(new BsonRegex(pattern, options));
		}

		// Token: 0x0400087B RID: 2171
		private readonly BsonBinaryWriter _writer;

		// Token: 0x0400087C RID: 2172
		private BsonToken _root;

		// Token: 0x0400087D RID: 2173
		private BsonToken _parent;

		// Token: 0x0400087E RID: 2174
		private string _propertyName;
	}
}
