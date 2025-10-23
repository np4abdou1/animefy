using System;

namespace System.Net
{
	// Token: 0x02000157 RID: 343
	internal static class ExceptionHelper
	{
		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x00033665 File Offset: 0x00031865
		internal static NotImplementedException MethodNotImplementedException
		{
			get
			{
				return new NotImplementedException(SR.GetString("This method is not implemented by this class."));
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x00033676 File Offset: 0x00031876
		internal static NotImplementedException PropertyNotImplementedException
		{
			get
			{
				return new NotImplementedException(SR.GetString("This property is not implemented by this class."));
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x00033687 File Offset: 0x00031887
		internal static WebException TimeoutException
		{
			get
			{
				return new WebException("The operation has timed out.");
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x00033693 File Offset: 0x00031893
		internal static NotSupportedException PropertyNotSupportedException
		{
			get
			{
				return new NotSupportedException(SR.GetString("This property is not supported by this class."));
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x000336A4 File Offset: 0x000318A4
		internal static WebException RequestAbortedException
		{
			get
			{
				return new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
			}
		}
	}
}
