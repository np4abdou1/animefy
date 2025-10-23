using System;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000153 RID: 339
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public class ValidationEventArgs : EventArgs
	{
		// Token: 0x06000ADD RID: 2781 RVA: 0x000331CD File Offset: 0x000313CD
		internal ValidationEventArgs(JsonSchemaException ex)
		{
			ValidationUtils.ArgumentNotNull(ex, "ex");
			this._ex = ex;
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x000331E7 File Offset: 0x000313E7
		public JsonSchemaException Exception
		{
			get
			{
				return this._ex;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x000331EF File Offset: 0x000313EF
		public string Path
		{
			get
			{
				return this._ex.Path;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x000331FC File Offset: 0x000313FC
		public string Message
		{
			get
			{
				return this._ex.Message;
			}
		}

		// Token: 0x04000657 RID: 1623
		private readonly JsonSchemaException _ex;
	}
}
