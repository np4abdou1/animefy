using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Lang;

namespace Kotlin.Jvm
{
	// Token: 0x02000189 RID: 393
	[Annotation("kotlin.jvm.Throws")]
	public class ThrowsAttribute : Attribute
	{
		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x0003EF8C File Offset: 0x0003D18C
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x0003EF94 File Offset: 0x0003D194
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[Register("exceptionClasses")]
		public Class[] ExceptionClasses { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
