using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000140 RID: 320
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public class JsonSchema
	{
		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x00030068 File Offset: 0x0002E268
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x00030070 File Offset: 0x0002E270
		public string Id { get; set; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x00030079 File Offset: 0x0002E279
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x00030081 File Offset: 0x0002E281
		public string Title { get; set; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x0003008A File Offset: 0x0002E28A
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x00030092 File Offset: 0x0002E292
		public bool? Required { get; set; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0003009B File Offset: 0x0002E29B
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x000300A3 File Offset: 0x0002E2A3
		public bool? ReadOnly { get; set; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x000300AC File Offset: 0x0002E2AC
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x000300B4 File Offset: 0x0002E2B4
		public bool? Hidden { get; set; }

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x000300BD File Offset: 0x0002E2BD
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x000300C5 File Offset: 0x0002E2C5
		public bool? Transient { get; set; }

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x000300CE File Offset: 0x0002E2CE
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x000300D6 File Offset: 0x0002E2D6
		public string Description { get; set; }

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x000300DF File Offset: 0x0002E2DF
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x000300E7 File Offset: 0x0002E2E7
		public JsonSchemaType? Type { get; set; }

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x000300F0 File Offset: 0x0002E2F0
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x000300F8 File Offset: 0x0002E2F8
		public string Pattern { get; set; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00030101 File Offset: 0x0002E301
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x00030109 File Offset: 0x0002E309
		public int? MinimumLength { get; set; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x00030112 File Offset: 0x0002E312
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x0003011A File Offset: 0x0002E31A
		public int? MaximumLength { get; set; }

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00030123 File Offset: 0x0002E323
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x0003012B File Offset: 0x0002E32B
		public double? DivisibleBy { get; set; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x00030134 File Offset: 0x0002E334
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x0003013C File Offset: 0x0002E33C
		public double? Minimum { get; set; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00030145 File Offset: 0x0002E345
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x0003014D File Offset: 0x0002E34D
		public double? Maximum { get; set; }

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00030156 File Offset: 0x0002E356
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x0003015E File Offset: 0x0002E35E
		public bool? ExclusiveMinimum { get; set; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00030167 File Offset: 0x0002E367
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x0003016F File Offset: 0x0002E36F
		public bool? ExclusiveMaximum { get; set; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x00030178 File Offset: 0x0002E378
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x00030180 File Offset: 0x0002E380
		public int? MinimumItems { get; set; }

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00030189 File Offset: 0x0002E389
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x00030191 File Offset: 0x0002E391
		public int? MaximumItems { get; set; }

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0003019A File Offset: 0x0002E39A
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x000301A2 File Offset: 0x0002E3A2
		public IList<JsonSchema> Items { get; set; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x000301AB File Offset: 0x0002E3AB
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x000301B3 File Offset: 0x0002E3B3
		public bool PositionalItemsValidation { get; set; }

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x000301BC File Offset: 0x0002E3BC
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x000301C4 File Offset: 0x0002E3C4
		public JsonSchema AdditionalItems { get; set; }

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x000301CD File Offset: 0x0002E3CD
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x000301D5 File Offset: 0x0002E3D5
		public bool AllowAdditionalItems { get; set; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x000301DE File Offset: 0x0002E3DE
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x000301E6 File Offset: 0x0002E3E6
		public bool UniqueItems { get; set; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x000301EF File Offset: 0x0002E3EF
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x000301F7 File Offset: 0x0002E3F7
		public IDictionary<string, JsonSchema> Properties { get; set; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x00030200 File Offset: 0x0002E400
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x00030208 File Offset: 0x0002E408
		public JsonSchema AdditionalProperties { get; set; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00030211 File Offset: 0x0002E411
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x00030219 File Offset: 0x0002E419
		public IDictionary<string, JsonSchema> PatternProperties { get; set; }

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00030222 File Offset: 0x0002E422
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x0003022A File Offset: 0x0002E42A
		public bool AllowAdditionalProperties { get; set; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00030233 File Offset: 0x0002E433
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x0003023B File Offset: 0x0002E43B
		public string Requires { get; set; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00030244 File Offset: 0x0002E444
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x0003024C File Offset: 0x0002E44C
		public IList<JToken> Enum { get; set; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00030255 File Offset: 0x0002E455
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x0003025D File Offset: 0x0002E45D
		public JsonSchemaType? Disallow { get; set; }

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x00030266 File Offset: 0x0002E466
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x0003026E File Offset: 0x0002E46E
		public JToken Default { get; set; }

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00030277 File Offset: 0x0002E477
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x0003027F File Offset: 0x0002E47F
		public IList<JsonSchema> Extends { get; set; }

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x00030288 File Offset: 0x0002E488
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x00030290 File Offset: 0x0002E490
		public string Format { get; set; }

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x00030299 File Offset: 0x0002E499
		// (set) Token: 0x06000A39 RID: 2617 RVA: 0x000302A1 File Offset: 0x0002E4A1
		internal string Location { get; set; }

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x000302AA File Offset: 0x0002E4AA
		internal string InternalId
		{
			get
			{
				return this._internalId;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x000302B2 File Offset: 0x0002E4B2
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x000302BA File Offset: 0x0002E4BA
		internal string DeferredReference { get; set; }

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x000302C3 File Offset: 0x0002E4C3
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x000302CB File Offset: 0x0002E4CB
		internal bool ReferencesResolved { get; set; }

		// Token: 0x06000A3F RID: 2623 RVA: 0x000302D4 File Offset: 0x0002E4D4
		public JsonSchema()
		{
			this.AllowAdditionalProperties = true;
			this.AllowAdditionalItems = true;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0003030D File Offset: 0x0002E50D
		public static JsonSchema Read(JsonReader reader)
		{
			return JsonSchema.Read(reader, new JsonSchemaResolver());
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0003031A File Offset: 0x0002E51A
		public static JsonSchema Read(JsonReader reader, JsonSchemaResolver resolver)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			ValidationUtils.ArgumentNotNull(resolver, "resolver");
			return new JsonSchemaBuilder(resolver).Read(reader);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0003033E File Offset: 0x0002E53E
		public static JsonSchema Parse(string json)
		{
			return JsonSchema.Parse(json, new JsonSchemaResolver());
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0003034C File Offset: 0x0002E54C
		public static JsonSchema Parse(string json, JsonSchemaResolver resolver)
		{
			ValidationUtils.ArgumentNotNull(json, "json");
			JsonSchema result;
			using (JsonReader jsonReader = new JsonTextReader(new StringReader(json)))
			{
				result = JsonSchema.Read(jsonReader, resolver);
			}
			return result;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00030398 File Offset: 0x0002E598
		public void WriteTo(JsonWriter writer)
		{
			this.WriteTo(writer, new JsonSchemaResolver());
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x000303A6 File Offset: 0x0002E5A6
		public void WriteTo(JsonWriter writer, JsonSchemaResolver resolver)
		{
			ValidationUtils.ArgumentNotNull(writer, "writer");
			ValidationUtils.ArgumentNotNull(resolver, "resolver");
			new JsonSchemaWriter(writer, resolver).WriteSchema(this);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x000303CC File Offset: 0x0002E5CC
		public override string ToString()
		{
			StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
			this.WriteTo(new JsonTextWriter(stringWriter)
			{
				Formatting = Formatting.Indented
			});
			return stringWriter.ToString();
		}

		// Token: 0x040005EA RID: 1514
		private readonly string _internalId = Guid.NewGuid().ToString("N");
	}
}
