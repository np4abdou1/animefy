using System;
using System.Runtime.ExceptionServices;
using System.Threading;

namespace System
{
	// Token: 0x020000CC RID: 204
	internal class LazyHelper
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x0001CA2C File Offset: 0x0001AC2C
		internal LazyState State { get; }

		// Token: 0x060006AD RID: 1709 RVA: 0x0001CA34 File Offset: 0x0001AC34
		internal LazyHelper(LazyState state)
		{
			this.State = state;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0001CA44 File Offset: 0x0001AC44
		internal LazyHelper(LazyThreadSafetyMode mode, Exception exception)
		{
			switch (mode)
			{
			case LazyThreadSafetyMode.None:
				this.State = 2;
				break;
			case LazyThreadSafetyMode.PublicationOnly:
				this.State = 6;
				break;
			case LazyThreadSafetyMode.ExecutionAndPublication:
				this.State = 9;
				break;
			}
			this._exceptionDispatch = ExceptionDispatchInfo.Capture(exception);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0001CA91 File Offset: 0x0001AC91
		internal void ThrowException()
		{
			this._exceptionDispatch.Throw();
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0001CAA0 File Offset: 0x0001ACA0
		internal static LazyHelper Create(LazyThreadSafetyMode mode, bool useDefaultConstructor)
		{
			switch (mode)
			{
			case LazyThreadSafetyMode.None:
				if (!useDefaultConstructor)
				{
					return LazyHelper.NoneViaFactory;
				}
				return LazyHelper.NoneViaConstructor;
			case LazyThreadSafetyMode.PublicationOnly:
				if (!useDefaultConstructor)
				{
					return LazyHelper.PublicationOnlyViaFactory;
				}
				return LazyHelper.PublicationOnlyViaConstructor;
			case LazyThreadSafetyMode.ExecutionAndPublication:
				return new LazyHelper(useDefaultConstructor ? LazyState.ExecutionAndPublicationViaConstructor : LazyState.ExecutionAndPublicationViaFactory);
			default:
				throw new ArgumentOutOfRangeException("mode", "The mode argument specifies an invalid value.");
			}
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0001CAFC File Offset: 0x0001ACFC
		internal static object CreateViaDefaultConstructor(Type type)
		{
			object result;
			try
			{
				result = Activator.CreateInstance(type);
			}
			catch (MissingMethodException)
			{
				throw new MissingMemberException("The lazily-initialized type does not have a public, parameterless constructor.");
			}
			return result;
		}

		// Token: 0x04000320 RID: 800
		internal static readonly LazyHelper NoneViaConstructor = new LazyHelper(LazyState.NoneViaConstructor);

		// Token: 0x04000321 RID: 801
		internal static readonly LazyHelper NoneViaFactory = new LazyHelper(LazyState.NoneViaFactory);

		// Token: 0x04000322 RID: 802
		internal static readonly LazyHelper PublicationOnlyViaConstructor = new LazyHelper(LazyState.PublicationOnlyViaConstructor);

		// Token: 0x04000323 RID: 803
		internal static readonly LazyHelper PublicationOnlyViaFactory = new LazyHelper(LazyState.PublicationOnlyViaFactory);

		// Token: 0x04000324 RID: 804
		internal static readonly LazyHelper PublicationOnlyWaitForOtherThreadToPublish = new LazyHelper(LazyState.PublicationOnlyWait);

		// Token: 0x04000326 RID: 806
		private readonly ExceptionDispatchInfo _exceptionDispatch;
	}
}
