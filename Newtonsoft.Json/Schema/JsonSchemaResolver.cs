using System;
using System.Collections.Generic;
using System.Linq;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200014D RID: 333
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public class JsonSchemaResolver
	{
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x000329D1 File Offset: 0x00030BD1
		// (set) Token: 0x06000ACD RID: 2765 RVA: 0x000329D9 File Offset: 0x00030BD9
		public IList<JsonSchema> LoadedSchemas { get; protected set; }

		// Token: 0x06000ACE RID: 2766 RVA: 0x000329E2 File Offset: 0x00030BE2
		public JsonSchemaResolver()
		{
			this.LoadedSchemas = new List<JsonSchema>();
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x000329F8 File Offset: 0x00030BF8
		public virtual JsonSchema GetSchema(string reference)
		{
			JsonSchema jsonSchema = this.LoadedSchemas.SingleOrDefault((JsonSchema s) => string.Equals(s.Id, reference, StringComparison.Ordinal));
			if (jsonSchema == null)
			{
				jsonSchema = this.LoadedSchemas.SingleOrDefault((JsonSchema s) => string.Equals(s.Location, reference, StringComparison.Ordinal));
			}
			return jsonSchema;
		}
	}
}
