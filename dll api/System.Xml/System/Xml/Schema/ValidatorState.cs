using System;

namespace System.Xml.Schema
{
	// Token: 0x02000326 RID: 806
	internal enum ValidatorState
	{
		// Token: 0x0400114C RID: 4428
		None,
		// Token: 0x0400114D RID: 4429
		Start,
		// Token: 0x0400114E RID: 4430
		TopLevelAttribute,
		// Token: 0x0400114F RID: 4431
		TopLevelTextOrWS,
		// Token: 0x04001150 RID: 4432
		Element,
		// Token: 0x04001151 RID: 4433
		Attribute,
		// Token: 0x04001152 RID: 4434
		EndOfAttributes,
		// Token: 0x04001153 RID: 4435
		Text,
		// Token: 0x04001154 RID: 4436
		Whitespace,
		// Token: 0x04001155 RID: 4437
		EndElement,
		// Token: 0x04001156 RID: 4438
		SkipToEndElement,
		// Token: 0x04001157 RID: 4439
		Finish
	}
}
