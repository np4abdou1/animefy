using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200014A RID: 330
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaNode
	{
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00032802 File Offset: 0x00030A02
		public string Id { get; }

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x0003280A File Offset: 0x00030A0A
		public ReadOnlyCollection<JsonSchema> Schemas { get; }

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00032812 File Offset: 0x00030A12
		public Dictionary<string, JsonSchemaNode> Properties { get; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0003281A File Offset: 0x00030A1A
		public Dictionary<string, JsonSchemaNode> PatternProperties { get; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x00032822 File Offset: 0x00030A22
		public List<JsonSchemaNode> Items { get; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x0003282A File Offset: 0x00030A2A
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x00032832 File Offset: 0x00030A32
		public JsonSchemaNode AdditionalProperties { get; set; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0003283B File Offset: 0x00030A3B
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x00032843 File Offset: 0x00030A43
		public JsonSchemaNode AdditionalItems { get; set; }

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0003284C File Offset: 0x00030A4C
		public JsonSchemaNode(JsonSchema schema)
		{
			this.Schemas = new ReadOnlyCollection<JsonSchema>(new JsonSchema[]
			{
				schema
			});
			this.Properties = new Dictionary<string, JsonSchemaNode>();
			this.PatternProperties = new Dictionary<string, JsonSchemaNode>();
			this.Items = new List<JsonSchemaNode>();
			this.Id = JsonSchemaNode.GetId(this.Schemas);
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x000328A8 File Offset: 0x00030AA8
		private JsonSchemaNode(JsonSchemaNode source, JsonSchema schema)
		{
			this.Schemas = new ReadOnlyCollection<JsonSchema>(source.Schemas.Union(new JsonSchema[]
			{
				schema
			}).ToList<JsonSchema>());
			this.Properties = new Dictionary<string, JsonSchemaNode>(source.Properties);
			this.PatternProperties = new Dictionary<string, JsonSchemaNode>(source.PatternProperties);
			this.Items = new List<JsonSchemaNode>(source.Items);
			this.AdditionalProperties = source.AdditionalProperties;
			this.AdditionalItems = source.AdditionalItems;
			this.Id = JsonSchemaNode.GetId(this.Schemas);
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0003293C File Offset: 0x00030B3C
		public JsonSchemaNode Combine(JsonSchema schema)
		{
			return new JsonSchemaNode(this, schema);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00032948 File Offset: 0x00030B48
		public static string GetId(IEnumerable<JsonSchema> schemata)
		{
			return string.Join("-", (from s in schemata
			select s.InternalId).OrderBy((string id) => id, StringComparer.Ordinal));
		}
	}
}
