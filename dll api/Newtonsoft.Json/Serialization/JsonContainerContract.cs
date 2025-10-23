using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000113 RID: 275
	[NullableContext(2)]
	[Nullable(0)]
	public class JsonContainerContract : JsonContract
	{
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x00027902 File Offset: 0x00025B02
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x0002790A File Offset: 0x00025B0A
		internal JsonContract ItemContract
		{
			get
			{
				return this._itemContract;
			}
			set
			{
				this._itemContract = value;
				if (this._itemContract != null)
				{
					this._finalItemContract = (this._itemContract.UnderlyingType.IsSealed() ? this._itemContract : null);
					return;
				}
				this._finalItemContract = null;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00027944 File Offset: 0x00025B44
		internal JsonContract FinalItemContract
		{
			get
			{
				return this._finalItemContract;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x0002794C File Offset: 0x00025B4C
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x00027954 File Offset: 0x00025B54
		public JsonConverter ItemConverter { get; set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x0002795D File Offset: 0x00025B5D
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x00027965 File Offset: 0x00025B65
		public bool? ItemIsReference { get; set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x0002796E File Offset: 0x00025B6E
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x00027976 File Offset: 0x00025B76
		public ReferenceLoopHandling? ItemReferenceLoopHandling { get; set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x0002797F File Offset: 0x00025B7F
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x00027987 File Offset: 0x00025B87
		public TypeNameHandling? ItemTypeNameHandling { get; set; }

		// Token: 0x060007EB RID: 2027 RVA: 0x00027990 File Offset: 0x00025B90
		[NullableContext(1)]
		internal JsonContainerContract(Type underlyingType) : base(underlyingType)
		{
			JsonContainerAttribute cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>(underlyingType);
			if (cachedAttribute != null)
			{
				if (cachedAttribute.ItemConverterType != null)
				{
					this.ItemConverter = JsonTypeReflector.CreateJsonConverterInstance(cachedAttribute.ItemConverterType, cachedAttribute.ItemConverterParameters);
				}
				this.ItemIsReference = cachedAttribute._itemIsReference;
				this.ItemReferenceLoopHandling = cachedAttribute._itemReferenceLoopHandling;
				this.ItemTypeNameHandling = cachedAttribute._itemTypeNameHandling;
			}
		}

		// Token: 0x0400051D RID: 1309
		private JsonContract _itemContract;

		// Token: 0x0400051E RID: 1310
		private JsonContract _finalItemContract;
	}
}
