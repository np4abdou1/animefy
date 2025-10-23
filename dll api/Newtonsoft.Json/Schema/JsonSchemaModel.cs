using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000148 RID: 328
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaModel
	{
		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00031F9B File Offset: 0x0003019B
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x00031FA3 File Offset: 0x000301A3
		public bool Required { get; set; }

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00031FAC File Offset: 0x000301AC
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x00031FB4 File Offset: 0x000301B4
		public JsonSchemaType Type { get; set; }

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00031FBD File Offset: 0x000301BD
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x00031FC5 File Offset: 0x000301C5
		public int? MinimumLength { get; set; }

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00031FCE File Offset: 0x000301CE
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x00031FD6 File Offset: 0x000301D6
		public int? MaximumLength { get; set; }

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00031FDF File Offset: 0x000301DF
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x00031FE7 File Offset: 0x000301E7
		public double? DivisibleBy { get; set; }

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00031FF0 File Offset: 0x000301F0
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x00031FF8 File Offset: 0x000301F8
		public double? Minimum { get; set; }

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x00032001 File Offset: 0x00030201
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x00032009 File Offset: 0x00030209
		public double? Maximum { get; set; }

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x00032012 File Offset: 0x00030212
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x0003201A File Offset: 0x0003021A
		public bool ExclusiveMinimum { get; set; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00032023 File Offset: 0x00030223
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x0003202B File Offset: 0x0003022B
		public bool ExclusiveMaximum { get; set; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00032034 File Offset: 0x00030234
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x0003203C File Offset: 0x0003023C
		public int? MinimumItems { get; set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00032045 File Offset: 0x00030245
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x0003204D File Offset: 0x0003024D
		public int? MaximumItems { get; set; }

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00032056 File Offset: 0x00030256
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x0003205E File Offset: 0x0003025E
		public IList<string> Patterns { get; set; }

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00032067 File Offset: 0x00030267
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x0003206F File Offset: 0x0003026F
		public IList<JsonSchemaModel> Items { get; set; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00032078 File Offset: 0x00030278
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x00032080 File Offset: 0x00030280
		public IDictionary<string, JsonSchemaModel> Properties { get; set; }

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00032089 File Offset: 0x00030289
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x00032091 File Offset: 0x00030291
		public IDictionary<string, JsonSchemaModel> PatternProperties { get; set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0003209A File Offset: 0x0003029A
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x000320A2 File Offset: 0x000302A2
		public JsonSchemaModel AdditionalProperties { get; set; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x000320AB File Offset: 0x000302AB
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x000320B3 File Offset: 0x000302B3
		public JsonSchemaModel AdditionalItems { get; set; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x000320BC File Offset: 0x000302BC
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x000320C4 File Offset: 0x000302C4
		public bool PositionalItemsValidation { get; set; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x000320CD File Offset: 0x000302CD
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x000320D5 File Offset: 0x000302D5
		public bool AllowAdditionalProperties { get; set; }

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x000320DE File Offset: 0x000302DE
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x000320E6 File Offset: 0x000302E6
		public bool AllowAdditionalItems { get; set; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x000320EF File Offset: 0x000302EF
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x000320F7 File Offset: 0x000302F7
		public bool UniqueItems { get; set; }

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x00032100 File Offset: 0x00030300
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x00032108 File Offset: 0x00030308
		public IList<JToken> Enum { get; set; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x00032111 File Offset: 0x00030311
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x00032119 File Offset: 0x00030319
		public JsonSchemaType Disallow { get; set; }

		// Token: 0x06000AAD RID: 2733 RVA: 0x00032122 File Offset: 0x00030322
		public JsonSchemaModel()
		{
			this.Type = JsonSchemaType.Any;
			this.AllowAdditionalProperties = true;
			this.AllowAdditionalItems = true;
			this.Required = false;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00032148 File Offset: 0x00030348
		public static JsonSchemaModel Create(IList<JsonSchema> schemata)
		{
			JsonSchemaModel jsonSchemaModel = new JsonSchemaModel();
			foreach (JsonSchema schema in schemata)
			{
				JsonSchemaModel.Combine(jsonSchemaModel, schema);
			}
			return jsonSchemaModel;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00032198 File Offset: 0x00030398
		private static void Combine(JsonSchemaModel model, JsonSchema schema)
		{
			model.Required = (model.Required || schema.Required.GetValueOrDefault());
			model.Type &= (schema.Type ?? JsonSchemaType.Any);
			model.MinimumLength = MathUtils.Max(model.MinimumLength, schema.MinimumLength);
			model.MaximumLength = MathUtils.Min(model.MaximumLength, schema.MaximumLength);
			model.DivisibleBy = MathUtils.Max(model.DivisibleBy, schema.DivisibleBy);
			model.Minimum = MathUtils.Max(model.Minimum, schema.Minimum);
			model.Maximum = MathUtils.Max(model.Maximum, schema.Maximum);
			model.ExclusiveMinimum = (model.ExclusiveMinimum || schema.ExclusiveMinimum.GetValueOrDefault());
			model.ExclusiveMaximum = (model.ExclusiveMaximum || schema.ExclusiveMaximum.GetValueOrDefault());
			model.MinimumItems = MathUtils.Max(model.MinimumItems, schema.MinimumItems);
			model.MaximumItems = MathUtils.Min(model.MaximumItems, schema.MaximumItems);
			model.PositionalItemsValidation = (model.PositionalItemsValidation || schema.PositionalItemsValidation);
			model.AllowAdditionalProperties = (model.AllowAdditionalProperties && schema.AllowAdditionalProperties);
			model.AllowAdditionalItems = (model.AllowAdditionalItems && schema.AllowAdditionalItems);
			model.UniqueItems = (model.UniqueItems || schema.UniqueItems);
			if (schema.Enum != null)
			{
				if (model.Enum == null)
				{
					model.Enum = new List<JToken>();
				}
				model.Enum.AddRangeDistinct(schema.Enum, JToken.EqualityComparer);
			}
			model.Disallow |= schema.Disallow.GetValueOrDefault();
			if (schema.Pattern != null)
			{
				if (model.Patterns == null)
				{
					model.Patterns = new List<string>();
				}
				model.Patterns.AddDistinct(schema.Pattern);
			}
		}
	}
}
