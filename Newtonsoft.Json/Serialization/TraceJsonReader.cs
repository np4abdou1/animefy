using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200013B RID: 315
	[NullableContext(1)]
	[Nullable(0)]
	internal class TraceJsonReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x0600099F RID: 2463 RVA: 0x0002F3F4 File Offset: 0x0002D5F4
		public TraceJsonReader(JsonReader innerReader)
		{
			this._innerReader = innerReader;
			this._sw = new StringWriter(CultureInfo.InvariantCulture);
			this._sw.Write("Deserialized JSON: " + Environment.NewLine);
			this._textWriter = new JsonTextWriter(this._sw);
			this._textWriter.Formatting = Formatting.Indented;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0002F455 File Offset: 0x0002D655
		public string GetDeserializedJsonMessage()
		{
			return this._sw.ToString();
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0002F462 File Offset: 0x0002D662
		public override bool Read()
		{
			bool result = this._innerReader.Read();
			this.WriteCurrentToken();
			return result;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0002F475 File Offset: 0x0002D675
		public override int? ReadAsInt32()
		{
			int? result = this._innerReader.ReadAsInt32();
			this.WriteCurrentToken();
			return result;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0002F488 File Offset: 0x0002D688
		[NullableContext(2)]
		public override string ReadAsString()
		{
			string result = this._innerReader.ReadAsString();
			this.WriteCurrentToken();
			return result;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0002F49B File Offset: 0x0002D69B
		[NullableContext(2)]
		public override byte[] ReadAsBytes()
		{
			byte[] result = this._innerReader.ReadAsBytes();
			this.WriteCurrentToken();
			return result;
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0002F4AE File Offset: 0x0002D6AE
		public override decimal? ReadAsDecimal()
		{
			decimal? result = this._innerReader.ReadAsDecimal();
			this.WriteCurrentToken();
			return result;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0002F4C1 File Offset: 0x0002D6C1
		public override double? ReadAsDouble()
		{
			double? result = this._innerReader.ReadAsDouble();
			this.WriteCurrentToken();
			return result;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0002F4D4 File Offset: 0x0002D6D4
		public override bool? ReadAsBoolean()
		{
			bool? result = this._innerReader.ReadAsBoolean();
			this.WriteCurrentToken();
			return result;
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0002F4E7 File Offset: 0x0002D6E7
		public override DateTime? ReadAsDateTime()
		{
			DateTime? result = this._innerReader.ReadAsDateTime();
			this.WriteCurrentToken();
			return result;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0002F4FA File Offset: 0x0002D6FA
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			DateTimeOffset? result = this._innerReader.ReadAsDateTimeOffset();
			this.WriteCurrentToken();
			return result;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0002F50D File Offset: 0x0002D70D
		public void WriteCurrentToken()
		{
			this._textWriter.WriteToken(this._innerReader, false, false, true);
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x0002F523 File Offset: 0x0002D723
		public override int Depth
		{
			get
			{
				return this._innerReader.Depth;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x0002F530 File Offset: 0x0002D730
		public override string Path
		{
			get
			{
				return this._innerReader.Path;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0002F53D File Offset: 0x0002D73D
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x0002F54A File Offset: 0x0002D74A
		public override char QuoteChar
		{
			get
			{
				return this._innerReader.QuoteChar;
			}
			protected internal set
			{
				this._innerReader.QuoteChar = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x0002F558 File Offset: 0x0002D758
		public override JsonToken TokenType
		{
			get
			{
				return this._innerReader.TokenType;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0002F565 File Offset: 0x0002D765
		[Nullable(2)]
		public override object Value
		{
			[NullableContext(2)]
			get
			{
				return this._innerReader.Value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x0002F572 File Offset: 0x0002D772
		[Nullable(2)]
		public override Type ValueType
		{
			[NullableContext(2)]
			get
			{
				return this._innerReader.ValueType;
			}
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0002F57F File Offset: 0x0002D77F
		public override void Close()
		{
			this._innerReader.Close();
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0002F58C File Offset: 0x0002D78C
		bool IJsonLineInfo.HasLineInfo()
		{
			IJsonLineInfo jsonLineInfo = this._innerReader as IJsonLineInfo;
			return jsonLineInfo != null && jsonLineInfo.HasLineInfo();
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x0002F5B0 File Offset: 0x0002D7B0
		int IJsonLineInfo.LineNumber
		{
			get
			{
				IJsonLineInfo jsonLineInfo = this._innerReader as IJsonLineInfo;
				if (jsonLineInfo == null)
				{
					return 0;
				}
				return jsonLineInfo.LineNumber;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x0002F5D4 File Offset: 0x0002D7D4
		int IJsonLineInfo.LinePosition
		{
			get
			{
				IJsonLineInfo jsonLineInfo = this._innerReader as IJsonLineInfo;
				if (jsonLineInfo == null)
				{
					return 0;
				}
				return jsonLineInfo.LinePosition;
			}
		}

		// Token: 0x040005C0 RID: 1472
		private readonly JsonReader _innerReader;

		// Token: 0x040005C1 RID: 1473
		private readonly JsonTextWriter _textWriter;

		// Token: 0x040005C2 RID: 1474
		private readonly StringWriter _sw;
	}
}
