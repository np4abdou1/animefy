using System;
using Java.Lang;

namespace Android.Runtime
{
	// Token: 0x020002DE RID: 734
	internal class JavaProxyThrowable : Error
	{
		// Token: 0x06001BEC RID: 7148 RVA: 0x0004A9B1 File Offset: 0x00048BB1
		public JavaProxyThrowable(System.Exception innerException) : base(JavaProxyThrowable.GetDetailMessage(innerException))
		{
			this.InnerException = innerException;
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x0004A9C6 File Offset: 0x00048BC6
		private static string GetDetailMessage(System.Exception innerException)
		{
			if (innerException == null)
			{
				throw new ArgumentNullException("innerException");
			}
			return innerException.ToString();
		}

		// Token: 0x04000BBD RID: 3005
		public new readonly System.Exception InnerException;
	}
}
