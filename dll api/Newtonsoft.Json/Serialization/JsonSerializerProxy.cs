using System;
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200012D RID: 301
	[NullableContext(1)]
	[Nullable(0)]
	internal class JsonSerializerProxy : JsonSerializer
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000917 RID: 2327 RVA: 0x0002E575 File Offset: 0x0002C775
		// (remove) Token: 0x06000918 RID: 2328 RVA: 0x0002E583 File Offset: 0x0002C783
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override event EventHandler<ErrorEventArgs> Error
		{
			add
			{
				this._serializer.Error += value;
			}
			remove
			{
				this._serializer.Error -= value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x0002E591 File Offset: 0x0002C791
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x0002E59E File Offset: 0x0002C79E
		[Nullable(2)]
		public override IReferenceResolver ReferenceResolver
		{
			[NullableContext(2)]
			get
			{
				return this._serializer.ReferenceResolver;
			}
			[NullableContext(2)]
			set
			{
				this._serializer.ReferenceResolver = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x0002E5AC File Offset: 0x0002C7AC
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x0002E5B9 File Offset: 0x0002C7B9
		[Nullable(2)]
		public override ITraceWriter TraceWriter
		{
			[NullableContext(2)]
			get
			{
				return this._serializer.TraceWriter;
			}
			[NullableContext(2)]
			set
			{
				this._serializer.TraceWriter = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x0002E5C7 File Offset: 0x0002C7C7
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x0002E5D4 File Offset: 0x0002C7D4
		[Nullable(2)]
		public override IEqualityComparer EqualityComparer
		{
			[NullableContext(2)]
			get
			{
				return this._serializer.EqualityComparer;
			}
			[NullableContext(2)]
			set
			{
				this._serializer.EqualityComparer = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x0002E5E2 File Offset: 0x0002C7E2
		public override JsonConverterCollection Converters
		{
			get
			{
				return this._serializer.Converters;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x0002E5EF File Offset: 0x0002C7EF
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x0002E5FC File Offset: 0x0002C7FC
		public override DefaultValueHandling DefaultValueHandling
		{
			get
			{
				return this._serializer.DefaultValueHandling;
			}
			set
			{
				this._serializer.DefaultValueHandling = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x0002E60A File Offset: 0x0002C80A
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x0002E617 File Offset: 0x0002C817
		public override IContractResolver ContractResolver
		{
			get
			{
				return this._serializer.ContractResolver;
			}
			set
			{
				this._serializer.ContractResolver = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0002E625 File Offset: 0x0002C825
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x0002E632 File Offset: 0x0002C832
		public override MissingMemberHandling MissingMemberHandling
		{
			get
			{
				return this._serializer.MissingMemberHandling;
			}
			set
			{
				this._serializer.MissingMemberHandling = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x0002E640 File Offset: 0x0002C840
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x0002E64D File Offset: 0x0002C84D
		public override NullValueHandling NullValueHandling
		{
			get
			{
				return this._serializer.NullValueHandling;
			}
			set
			{
				this._serializer.NullValueHandling = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x0002E65B File Offset: 0x0002C85B
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x0002E668 File Offset: 0x0002C868
		public override ObjectCreationHandling ObjectCreationHandling
		{
			get
			{
				return this._serializer.ObjectCreationHandling;
			}
			set
			{
				this._serializer.ObjectCreationHandling = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x0002E676 File Offset: 0x0002C876
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x0002E683 File Offset: 0x0002C883
		public override ReferenceLoopHandling ReferenceLoopHandling
		{
			get
			{
				return this._serializer.ReferenceLoopHandling;
			}
			set
			{
				this._serializer.ReferenceLoopHandling = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x0002E691 File Offset: 0x0002C891
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x0002E69E File Offset: 0x0002C89E
		public override PreserveReferencesHandling PreserveReferencesHandling
		{
			get
			{
				return this._serializer.PreserveReferencesHandling;
			}
			set
			{
				this._serializer.PreserveReferencesHandling = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x0002E6AC File Offset: 0x0002C8AC
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x0002E6B9 File Offset: 0x0002C8B9
		public override TypeNameHandling TypeNameHandling
		{
			get
			{
				return this._serializer.TypeNameHandling;
			}
			set
			{
				this._serializer.TypeNameHandling = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x0002E6C7 File Offset: 0x0002C8C7
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x0002E6D4 File Offset: 0x0002C8D4
		public override MetadataPropertyHandling MetadataPropertyHandling
		{
			get
			{
				return this._serializer.MetadataPropertyHandling;
			}
			set
			{
				this._serializer.MetadataPropertyHandling = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x0002E6E2 File Offset: 0x0002C8E2
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x0002E6EF File Offset: 0x0002C8EF
		[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
		public override FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			get
			{
				return this._serializer.TypeNameAssemblyFormat;
			}
			set
			{
				this._serializer.TypeNameAssemblyFormat = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x0002E6FD File Offset: 0x0002C8FD
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x0002E70A File Offset: 0x0002C90A
		public override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			get
			{
				return this._serializer.TypeNameAssemblyFormatHandling;
			}
			set
			{
				this._serializer.TypeNameAssemblyFormatHandling = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x0002E718 File Offset: 0x0002C918
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x0002E725 File Offset: 0x0002C925
		public override ConstructorHandling ConstructorHandling
		{
			get
			{
				return this._serializer.ConstructorHandling;
			}
			set
			{
				this._serializer.ConstructorHandling = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x0002E733 File Offset: 0x0002C933
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x0002E740 File Offset: 0x0002C940
		[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
		public override SerializationBinder Binder
		{
			get
			{
				return this._serializer.Binder;
			}
			set
			{
				this._serializer.Binder = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x0002E74E File Offset: 0x0002C94E
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x0002E75B File Offset: 0x0002C95B
		public override ISerializationBinder SerializationBinder
		{
			get
			{
				return this._serializer.SerializationBinder;
			}
			set
			{
				this._serializer.SerializationBinder = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x0002E769 File Offset: 0x0002C969
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x0002E776 File Offset: 0x0002C976
		public override StreamingContext Context
		{
			get
			{
				return this._serializer.Context;
			}
			set
			{
				this._serializer.Context = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x0002E784 File Offset: 0x0002C984
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x0002E791 File Offset: 0x0002C991
		public override Formatting Formatting
		{
			get
			{
				return this._serializer.Formatting;
			}
			set
			{
				this._serializer.Formatting = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x0002E79F File Offset: 0x0002C99F
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x0002E7AC File Offset: 0x0002C9AC
		public override DateFormatHandling DateFormatHandling
		{
			get
			{
				return this._serializer.DateFormatHandling;
			}
			set
			{
				this._serializer.DateFormatHandling = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x0002E7BA File Offset: 0x0002C9BA
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x0002E7C7 File Offset: 0x0002C9C7
		public override DateTimeZoneHandling DateTimeZoneHandling
		{
			get
			{
				return this._serializer.DateTimeZoneHandling;
			}
			set
			{
				this._serializer.DateTimeZoneHandling = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x0002E7D5 File Offset: 0x0002C9D5
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x0002E7E2 File Offset: 0x0002C9E2
		public override DateParseHandling DateParseHandling
		{
			get
			{
				return this._serializer.DateParseHandling;
			}
			set
			{
				this._serializer.DateParseHandling = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x0002E7F0 File Offset: 0x0002C9F0
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x0002E7FD File Offset: 0x0002C9FD
		public override FloatFormatHandling FloatFormatHandling
		{
			get
			{
				return this._serializer.FloatFormatHandling;
			}
			set
			{
				this._serializer.FloatFormatHandling = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x0002E80B File Offset: 0x0002CA0B
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x0002E818 File Offset: 0x0002CA18
		public override FloatParseHandling FloatParseHandling
		{
			get
			{
				return this._serializer.FloatParseHandling;
			}
			set
			{
				this._serializer.FloatParseHandling = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x0002E826 File Offset: 0x0002CA26
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x0002E833 File Offset: 0x0002CA33
		public override StringEscapeHandling StringEscapeHandling
		{
			get
			{
				return this._serializer.StringEscapeHandling;
			}
			set
			{
				this._serializer.StringEscapeHandling = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x0002E841 File Offset: 0x0002CA41
		// (set) Token: 0x0600094D RID: 2381 RVA: 0x0002E84E File Offset: 0x0002CA4E
		public override string DateFormatString
		{
			get
			{
				return this._serializer.DateFormatString;
			}
			set
			{
				this._serializer.DateFormatString = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x0002E85C File Offset: 0x0002CA5C
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x0002E869 File Offset: 0x0002CA69
		public override CultureInfo Culture
		{
			get
			{
				return this._serializer.Culture;
			}
			set
			{
				this._serializer.Culture = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x0002E877 File Offset: 0x0002CA77
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x0002E884 File Offset: 0x0002CA84
		public override int? MaxDepth
		{
			get
			{
				return this._serializer.MaxDepth;
			}
			set
			{
				this._serializer.MaxDepth = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x0002E892 File Offset: 0x0002CA92
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x0002E89F File Offset: 0x0002CA9F
		public override bool CheckAdditionalContent
		{
			get
			{
				return this._serializer.CheckAdditionalContent;
			}
			set
			{
				this._serializer.CheckAdditionalContent = value;
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0002E8AD File Offset: 0x0002CAAD
		internal JsonSerializerInternalBase GetInternalSerializer()
		{
			if (this._serializerReader != null)
			{
				return this._serializerReader;
			}
			return this._serializerWriter;
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0002E8C4 File Offset: 0x0002CAC4
		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader)
		{
			ValidationUtils.ArgumentNotNull(serializerReader, "serializerReader");
			this._serializerReader = serializerReader;
			this._serializer = serializerReader.Serializer;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0002E8EA File Offset: 0x0002CAEA
		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter)
		{
			ValidationUtils.ArgumentNotNull(serializerWriter, "serializerWriter");
			this._serializerWriter = serializerWriter;
			this._serializer = serializerWriter.Serializer;
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0002E910 File Offset: 0x0002CB10
		[NullableContext(2)]
		internal override object DeserializeInternal([Nullable(1)] JsonReader reader, Type objectType)
		{
			if (this._serializerReader != null)
			{
				return this._serializerReader.Deserialize(reader, objectType, false);
			}
			return this._serializer.Deserialize(reader, objectType);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0002E936 File Offset: 0x0002CB36
		internal override void PopulateInternal(JsonReader reader, object target)
		{
			if (this._serializerReader != null)
			{
				this._serializerReader.Populate(reader, target);
				return;
			}
			this._serializer.Populate(reader, target);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0002E95B File Offset: 0x0002CB5B
		[NullableContext(2)]
		internal override void SerializeInternal([Nullable(1)] JsonWriter jsonWriter, object value, Type rootType)
		{
			if (this._serializerWriter != null)
			{
				this._serializerWriter.Serialize(jsonWriter, value, rootType);
				return;
			}
			this._serializer.Serialize(jsonWriter, value);
		}

		// Token: 0x040005A3 RID: 1443
		[Nullable(2)]
		private readonly JsonSerializerInternalReader _serializerReader;

		// Token: 0x040005A4 RID: 1444
		[Nullable(2)]
		private readonly JsonSerializerInternalWriter _serializerWriter;

		// Token: 0x040005A5 RID: 1445
		internal readonly JsonSerializer _serializer;
	}
}
