using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000123 RID: 291
	[NullableContext(2)]
	[Nullable(0)]
	public class JsonProperty
	{
		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x000288F0 File Offset: 0x00026AF0
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x000288F8 File Offset: 0x00026AF8
		internal JsonContract PropertyContract { get; set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00028901 File Offset: 0x00026B01
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x00028909 File Offset: 0x00026B09
		public string PropertyName
		{
			get
			{
				return this._propertyName;
			}
			set
			{
				this._propertyName = value;
				this._skipPropertyNameEscape = !JavaScriptUtils.ShouldEscapeJavaScriptString(this._propertyName, JavaScriptUtils.HtmlCharEscapeFlags);
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x0002892B File Offset: 0x00026B2B
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x00028933 File Offset: 0x00026B33
		public Type DeclaringType { get; set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0002893C File Offset: 0x00026B3C
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x00028944 File Offset: 0x00026B44
		public int? Order { get; set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x0002894D File Offset: 0x00026B4D
		// (set) Token: 0x0600086F RID: 2159 RVA: 0x00028955 File Offset: 0x00026B55
		public string UnderlyingName { get; set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x0002895E File Offset: 0x00026B5E
		// (set) Token: 0x06000871 RID: 2161 RVA: 0x00028966 File Offset: 0x00026B66
		public IValueProvider ValueProvider { get; set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x0002896F File Offset: 0x00026B6F
		// (set) Token: 0x06000873 RID: 2163 RVA: 0x00028977 File Offset: 0x00026B77
		public IAttributeProvider AttributeProvider { get; set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x00028980 File Offset: 0x00026B80
		// (set) Token: 0x06000875 RID: 2165 RVA: 0x00028988 File Offset: 0x00026B88
		public Type PropertyType
		{
			get
			{
				return this._propertyType;
			}
			set
			{
				if (this._propertyType != value)
				{
					this._propertyType = value;
					this._hasGeneratedDefaultValue = false;
				}
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x000289A6 File Offset: 0x00026BA6
		// (set) Token: 0x06000877 RID: 2167 RVA: 0x000289AE File Offset: 0x00026BAE
		public JsonConverter Converter { get; set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x000289B7 File Offset: 0x00026BB7
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x000289BF File Offset: 0x00026BBF
		[Obsolete("MemberConverter is obsolete. Use Converter instead.")]
		public JsonConverter MemberConverter
		{
			get
			{
				return this.Converter;
			}
			set
			{
				this.Converter = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x000289C8 File Offset: 0x00026BC8
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x000289D0 File Offset: 0x00026BD0
		public bool Ignored { get; set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x000289D9 File Offset: 0x00026BD9
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x000289E1 File Offset: 0x00026BE1
		public bool Readable { get; set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x000289EA File Offset: 0x00026BEA
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x000289F2 File Offset: 0x00026BF2
		public bool Writable { get; set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x000289FB File Offset: 0x00026BFB
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x00028A03 File Offset: 0x00026C03
		public bool HasMemberAttribute { get; set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x00028A0C File Offset: 0x00026C0C
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x00028A1E File Offset: 0x00026C1E
		public object DefaultValue
		{
			get
			{
				if (!this._hasExplicitDefaultValue)
				{
					return null;
				}
				return this._defaultValue;
			}
			set
			{
				this._hasExplicitDefaultValue = true;
				this._defaultValue = value;
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00028A2E File Offset: 0x00026C2E
		internal object GetResolvedDefaultValue()
		{
			if (this._propertyType == null)
			{
				return null;
			}
			if (!this._hasExplicitDefaultValue && !this._hasGeneratedDefaultValue)
			{
				this._defaultValue = ReflectionUtils.GetDefaultValue(this._propertyType);
				this._hasGeneratedDefaultValue = true;
			}
			return this._defaultValue;
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x00028A6E File Offset: 0x00026C6E
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x00028A7B File Offset: 0x00026C7B
		public Required Required
		{
			get
			{
				return this._required.GetValueOrDefault();
			}
			set
			{
				this._required = new Required?(value);
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x00028A89 File Offset: 0x00026C89
		public bool IsRequiredSpecified
		{
			get
			{
				return this._required != null;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x00028A96 File Offset: 0x00026C96
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x00028A9E File Offset: 0x00026C9E
		public bool? IsReference { get; set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00028AA7 File Offset: 0x00026CA7
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x00028AAF File Offset: 0x00026CAF
		public NullValueHandling? NullValueHandling { get; set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x00028AB8 File Offset: 0x00026CB8
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x00028AC0 File Offset: 0x00026CC0
		public DefaultValueHandling? DefaultValueHandling { get; set; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x00028AC9 File Offset: 0x00026CC9
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x00028AD1 File Offset: 0x00026CD1
		public ReferenceLoopHandling? ReferenceLoopHandling { get; set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x00028ADA File Offset: 0x00026CDA
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x00028AE2 File Offset: 0x00026CE2
		public ObjectCreationHandling? ObjectCreationHandling { get; set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00028AEB File Offset: 0x00026CEB
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x00028AF3 File Offset: 0x00026CF3
		public TypeNameHandling? TypeNameHandling { get; set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00028AFC File Offset: 0x00026CFC
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x00028B04 File Offset: 0x00026D04
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Predicate<object> ShouldSerialize { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x00028B0D File Offset: 0x00026D0D
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x00028B15 File Offset: 0x00026D15
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Predicate<object> ShouldDeserialize { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x00028B1E File Offset: 0x00026D1E
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x00028B26 File Offset: 0x00026D26
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Predicate<object> GetIsSpecified { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00028B2F File Offset: 0x00026D2F
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00028B37 File Offset: 0x00026D37
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		public Action<object, object> SetIsSpecified { [return: Nullable(new byte[]
		{
			2,
			1,
			2
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			2
		})] set; }

		// Token: 0x0600089C RID: 2204 RVA: 0x00028B40 File Offset: 0x00026D40
		[NullableContext(1)]
		public override string ToString()
		{
			return this.PropertyName ?? string.Empty;
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x00028B51 File Offset: 0x00026D51
		// (set) Token: 0x0600089E RID: 2206 RVA: 0x00028B59 File Offset: 0x00026D59
		public JsonConverter ItemConverter { get; set; }

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x00028B62 File Offset: 0x00026D62
		// (set) Token: 0x060008A0 RID: 2208 RVA: 0x00028B6A File Offset: 0x00026D6A
		public bool? ItemIsReference { get; set; }

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x00028B73 File Offset: 0x00026D73
		// (set) Token: 0x060008A2 RID: 2210 RVA: 0x00028B7B File Offset: 0x00026D7B
		public TypeNameHandling? ItemTypeNameHandling { get; set; }

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x00028B84 File Offset: 0x00026D84
		// (set) Token: 0x060008A4 RID: 2212 RVA: 0x00028B8C File Offset: 0x00026D8C
		public ReferenceLoopHandling? ItemReferenceLoopHandling { get; set; }

		// Token: 0x060008A5 RID: 2213 RVA: 0x00028B98 File Offset: 0x00026D98
		[NullableContext(1)]
		internal void WritePropertyName(JsonWriter writer)
		{
			string propertyName = this.PropertyName;
			if (this._skipPropertyNameEscape)
			{
				writer.WritePropertyName(propertyName, false);
				return;
			}
			writer.WritePropertyName(propertyName);
		}

		// Token: 0x04000569 RID: 1385
		internal Required? _required;

		// Token: 0x0400056A RID: 1386
		internal bool _hasExplicitDefaultValue;

		// Token: 0x0400056B RID: 1387
		private object _defaultValue;

		// Token: 0x0400056C RID: 1388
		private bool _hasGeneratedDefaultValue;

		// Token: 0x0400056D RID: 1389
		private string _propertyName;

		// Token: 0x0400056E RID: 1390
		internal bool _skipPropertyNameEscape;

		// Token: 0x0400056F RID: 1391
		private Type _propertyType;
	}
}
