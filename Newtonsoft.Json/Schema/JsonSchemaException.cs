﻿using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000144 RID: 324
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	[Serializable]
	public class JsonSchemaException : JsonException
	{
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00031577 File Offset: 0x0002F777
		public int LineNumber { get; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0003157F File Offset: 0x0002F77F
		public int LinePosition { get; }

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00031587 File Offset: 0x0002F787
		public string Path { get; }

		// Token: 0x06000A5F RID: 2655 RVA: 0x000050C2 File Offset: 0x000032C2
		public JsonSchemaException()
		{
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x000050CA File Offset: 0x000032CA
		public JsonSchemaException(string message) : base(message)
		{
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x000050D3 File Offset: 0x000032D3
		public JsonSchemaException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x000050DD File Offset: 0x000032DD
		public JsonSchemaException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0003158F File Offset: 0x0002F78F
		internal JsonSchemaException(string message, Exception innerException, string path, int lineNumber, int linePosition) : base(message, innerException)
		{
			this.Path = path;
			this.LineNumber = lineNumber;
			this.LinePosition = linePosition;
		}
	}
}
