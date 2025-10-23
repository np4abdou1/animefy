using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000121 RID: 289
	[NullableContext(2)]
	[Nullable(0)]
	public class JsonObjectContract : JsonContainerContract
	{
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x00028552 File Offset: 0x00026752
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x0002855A File Offset: 0x0002675A
		public MemberSerialization MemberSerialization { get; set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x00028563 File Offset: 0x00026763
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x0002856B File Offset: 0x0002676B
		public MissingMemberHandling? MissingMemberHandling { get; set; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00028574 File Offset: 0x00026774
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x0002857C File Offset: 0x0002677C
		public Required? ItemRequired { get; set; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x00028585 File Offset: 0x00026785
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x0002858D File Offset: 0x0002678D
		public NullValueHandling? ItemNullValueHandling { get; set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00028596 File Offset: 0x00026796
		[Nullable(1)]
		public JsonPropertyCollection Properties { [NullableContext(1)] get; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x0002859E File Offset: 0x0002679E
		[Nullable(1)]
		public JsonPropertyCollection CreatorParameters
		{
			[NullableContext(1)]
			get
			{
				if (this._creatorParameters == null)
				{
					this._creatorParameters = new JsonPropertyCollection(base.UnderlyingType);
				}
				return this._creatorParameters;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x000285BF File Offset: 0x000267BF
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x000285C7 File Offset: 0x000267C7
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public ObjectConstructor<object> OverrideCreator
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return this._overrideCreator;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this._overrideCreator = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x000285D0 File Offset: 0x000267D0
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x000285D8 File Offset: 0x000267D8
		[Nullable(new byte[]
		{
			2,
			1
		})]
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return this._parameterizedCreator;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this._parameterizedCreator = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x000285E1 File Offset: 0x000267E1
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x000285E9 File Offset: 0x000267E9
		public ExtensionDataSetter ExtensionDataSetter { get; set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x000285F2 File Offset: 0x000267F2
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x000285FA File Offset: 0x000267FA
		public ExtensionDataGetter ExtensionDataGetter { get; set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00028603 File Offset: 0x00026803
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x0002860B File Offset: 0x0002680B
		public Type ExtensionDataValueType
		{
			get
			{
				return this._extensionDataValueType;
			}
			set
			{
				this._extensionDataValueType = value;
				this.ExtensionDataIsJToken = (value != null && typeof(JToken).IsAssignableFrom(value));
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x00028636 File Offset: 0x00026836
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x0002863E File Offset: 0x0002683E
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Func<string, string> ExtensionDataNameResolver { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x00028648 File Offset: 0x00026848
		internal bool HasRequiredOrDefaultValueProperties
		{
			get
			{
				if (this._hasRequiredOrDefaultValueProperties == null)
				{
					this._hasRequiredOrDefaultValueProperties = new bool?(false);
					if (this.ItemRequired.GetValueOrDefault(Required.Default) != Required.Default)
					{
						this._hasRequiredOrDefaultValueProperties = new bool?(true);
					}
					else
					{
						foreach (JsonProperty jsonProperty in this.Properties)
						{
							if (jsonProperty.Required == Required.Default)
							{
								DefaultValueHandling? defaultValueHandling = jsonProperty.DefaultValueHandling & DefaultValueHandling.Populate;
								DefaultValueHandling defaultValueHandling2 = DefaultValueHandling.Populate;
								if (!(defaultValueHandling.GetValueOrDefault() == defaultValueHandling2 & defaultValueHandling != null))
								{
									continue;
								}
							}
							this._hasRequiredOrDefaultValueProperties = new bool?(true);
							break;
						}
					}
				}
				return this._hasRequiredOrDefaultValueProperties.GetValueOrDefault();
			}
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00028734 File Offset: 0x00026934
		[NullableContext(1)]
		public JsonObjectContract(Type underlyingType) : base(underlyingType)
		{
			this.ContractType = JsonContractType.Object;
			this.Properties = new JsonPropertyCollection(base.UnderlyingType);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00028755 File Offset: 0x00026955
		[NullableContext(1)]
		[SecuritySafeCritical]
		internal object GetUninitializedObject()
		{
			if (!JsonTypeReflector.FullyTrusted)
			{
				throw new JsonException("Insufficient permissions. Creating an uninitialized '{0}' type requires full trust.".FormatWith(CultureInfo.InvariantCulture, this.NonNullableUnderlyingType));
			}
			return FormatterServices.GetUninitializedObject(this.NonNullableUnderlyingType);
		}

		// Token: 0x04000561 RID: 1377
		internal bool ExtensionDataIsJToken;

		// Token: 0x04000562 RID: 1378
		private bool? _hasRequiredOrDefaultValueProperties;

		// Token: 0x04000563 RID: 1379
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ObjectConstructor<object> _overrideCreator;

		// Token: 0x04000564 RID: 1380
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ObjectConstructor<object> _parameterizedCreator;

		// Token: 0x04000565 RID: 1381
		private JsonPropertyCollection _creatorParameters;

		// Token: 0x04000566 RID: 1382
		private Type _extensionDataValueType;
	}
}
