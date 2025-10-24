using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the visibility a property has to the design-time serializer.</summary>
	// Token: 0x0200023A RID: 570
	public enum DesignerSerializationVisibility
	{
		/// <summary>The code generator does not produce code for the object.</summary>
		// Token: 0x04000C10 RID: 3088
		Hidden,
		/// <summary>The code generator produces code for the object.</summary>
		// Token: 0x04000C11 RID: 3089
		Visible,
		/// <summary>The code generator produces code for the contents of the object, rather than for the object itself.</summary>
		// Token: 0x04000C12 RID: 3090
		Content
	}
}
