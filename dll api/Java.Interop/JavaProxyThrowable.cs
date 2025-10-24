using System;

namespace Java.Interop
{
	// Token: 0x0200004A RID: 74
	[JniTypeSignature("com/xamarin/java_interop/internal/JavaProxyThrowable")]
	internal sealed class JavaProxyThrowable : JavaException
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0000C555 File Offset: 0x0000A755
		// (set) Token: 0x060002DF RID: 735 RVA: 0x0000C55D File Offset: 0x0000A75D
		public Exception Exception { get; private set; }

		// Token: 0x060002E0 RID: 736 RVA: 0x0000C566 File Offset: 0x0000A766
		public JavaProxyThrowable(Exception exception) : base(JavaProxyThrowable.GetMessage(exception))
		{
			this.Exception = exception;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000C57B File Offset: 0x0000A77B
		private static string GetMessage(Exception exception)
		{
			if (exception == null)
			{
				throw new ArgumentNullException("exception");
			}
			return exception.ToString();
		}
	}
}
