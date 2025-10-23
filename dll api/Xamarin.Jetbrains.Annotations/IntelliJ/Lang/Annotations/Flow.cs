using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Lang;

namespace IntelliJ.Lang.Annotations
{
	// Token: 0x02000049 RID: 73
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/intellij/lang/annotations/Flow", DoNotGenerateAcw = true)]
	public abstract class Flow : Java.Lang.Object
	{
		// Token: 0x06000213 RID: 531 RVA: 0x0000666A File Offset: 0x0000486A
		internal Flow()
		{
		}

		// Token: 0x040000E2 RID: 226
		[Register("DEFAULT_SOURCE")]
		public const string DefaultSource = "The method argument (if parameter was annotated) or this container (if instance method was annotated)";

		// Token: 0x040000E3 RID: 227
		[Register("DEFAULT_TARGET")]
		public const string DefaultTarget = "This container (if the parameter was annotated) or the return value (if instance method was annotated)";

		// Token: 0x040000E4 RID: 228
		[Register("RETURN_METHOD_TARGET")]
		public const string ReturnMethodTarget = "The return value of this method";

		// Token: 0x040000E5 RID: 229
		[Register("THIS_SOURCE")]
		public const string ThisSource = "this";

		// Token: 0x040000E6 RID: 230
		[Register("THIS_TARGET")]
		public const string ThisTarget = "this";
	}
}
