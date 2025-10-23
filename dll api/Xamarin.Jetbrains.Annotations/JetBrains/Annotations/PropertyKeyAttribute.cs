using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace JetBrains.Annotations
{
	// Token: 0x0200003F RID: 63
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("org.jetbrains.annotations.PropertyKey")]
	public class PropertyKeyAttribute : Attribute
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000649F File Offset: 0x0000469F
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x000064A7 File Offset: 0x000046A7
		[Register("resourceBundle")]
		public string ResourceBundle { get; set; }
	}
}
