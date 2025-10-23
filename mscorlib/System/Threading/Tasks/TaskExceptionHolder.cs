using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.ExceptionServices;

namespace System.Threading.Tasks
{
	// Token: 0x02000231 RID: 561
	internal class TaskExceptionHolder
	{
		// Token: 0x060013A9 RID: 5033 RVA: 0x0004E1EB File Offset: 0x0004C3EB
		internal TaskExceptionHolder(Task task)
		{
			this.m_task = task;
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		private static bool ShouldFailFastOnUnobservedException()
		{
			return false;
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0004E1FC File Offset: 0x0004C3FC
		protected override void Finalize()
		{
			try
			{
				if (this.m_faultExceptions != null && !this.m_isHandled && !Environment.HasShutdownStarted)
				{
					AggregateException ex = new AggregateException("A Task's exception(s) were not observed either by Waiting on the Task or accessing its Exception property. As a result, the unobserved exception was rethrown by the finalizer thread.", this.m_faultExceptions);
					UnobservedTaskExceptionEventArgs unobservedTaskExceptionEventArgs = new UnobservedTaskExceptionEventArgs(ex);
					TaskScheduler.PublishUnobservedTaskException(this.m_task, unobservedTaskExceptionEventArgs);
					if (TaskExceptionHolder.s_failFastOnUnobservedException && !unobservedTaskExceptionEventArgs.m_observed)
					{
						throw ex;
					}
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x0004E274 File Offset: 0x0004C474
		internal bool ContainsFaultList
		{
			get
			{
				return this.m_faultExceptions != null;
			}
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0004E281 File Offset: 0x0004C481
		internal void Add(object exceptionObject, bool representsCancellation)
		{
			if (representsCancellation)
			{
				this.SetCancellationException(exceptionObject);
				return;
			}
			this.AddFaultException(exceptionObject);
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0004E298 File Offset: 0x0004C498
		private void SetCancellationException(object exceptionObject)
		{
			OperationCanceledException ex = exceptionObject as OperationCanceledException;
			if (ex != null)
			{
				this.m_cancellationException = ExceptionDispatchInfo.Capture(ex);
			}
			else
			{
				ExceptionDispatchInfo cancellationException = exceptionObject as ExceptionDispatchInfo;
				this.m_cancellationException = cancellationException;
			}
			this.MarkAsHandled(false);
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0004E2D4 File Offset: 0x0004C4D4
		private void AddFaultException(object exceptionObject)
		{
			LowLevelListWithIList<ExceptionDispatchInfo> lowLevelListWithIList = this.m_faultExceptions;
			if (lowLevelListWithIList == null)
			{
				lowLevelListWithIList = (this.m_faultExceptions = new LowLevelListWithIList<ExceptionDispatchInfo>(1));
			}
			Exception ex = exceptionObject as Exception;
			if (ex != null)
			{
				lowLevelListWithIList.Add(ExceptionDispatchInfo.Capture(ex));
			}
			else
			{
				ExceptionDispatchInfo exceptionDispatchInfo = exceptionObject as ExceptionDispatchInfo;
				if (exceptionDispatchInfo != null)
				{
					lowLevelListWithIList.Add(exceptionDispatchInfo);
				}
				else
				{
					IEnumerable<Exception> enumerable = exceptionObject as IEnumerable<Exception>;
					if (enumerable != null)
					{
						using (IEnumerator<Exception> enumerator = enumerable.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								Exception source = enumerator.Current;
								lowLevelListWithIList.Add(ExceptionDispatchInfo.Capture(source));
							}
							goto IL_AE;
						}
					}
					IEnumerable<ExceptionDispatchInfo> enumerable2 = exceptionObject as IEnumerable<ExceptionDispatchInfo>;
					if (enumerable2 == null)
					{
						throw new ArgumentException("(Internal)Expected an Exception or an IEnumerable<Exception>", "exceptionObject");
					}
					lowLevelListWithIList.AddRange(enumerable2);
				}
			}
			IL_AE:
			if (lowLevelListWithIList.Count > 0)
			{
				this.MarkAsUnhandled();
			}
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0004E3B0 File Offset: 0x0004C5B0
		private void MarkAsUnhandled()
		{
			if (this.m_isHandled)
			{
				GC.ReRegisterForFinalize(this);
				this.m_isHandled = false;
			}
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0004E3CB File Offset: 0x0004C5CB
		internal void MarkAsHandled(bool calledFromFinalizer)
		{
			if (!this.m_isHandled)
			{
				if (!calledFromFinalizer)
				{
					GC.SuppressFinalize(this);
				}
				this.m_isHandled = true;
			}
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0004E3EC File Offset: 0x0004C5EC
		internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException)
		{
			LowLevelListWithIList<ExceptionDispatchInfo> faultExceptions = this.m_faultExceptions;
			this.MarkAsHandled(calledFromFinalizer);
			if (includeThisException == null)
			{
				return new AggregateException(faultExceptions);
			}
			Exception[] array = new Exception[faultExceptions.Count + 1];
			for (int i = 0; i < array.Length - 1; i++)
			{
				array[i] = faultExceptions[i].SourceException;
			}
			array[array.Length - 1] = includeThisException;
			return new AggregateException(array);
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x0004E44E File Offset: 0x0004C64E
		internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			IList<ExceptionDispatchInfo> faultExceptions = this.m_faultExceptions;
			this.MarkAsHandled(false);
			return new ReadOnlyCollection<ExceptionDispatchInfo>(faultExceptions);
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0004E464 File Offset: 0x0004C664
		internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			return this.m_cancellationException;
		}

		// Token: 0x040007D4 RID: 2004
		private static readonly bool s_failFastOnUnobservedException = TaskExceptionHolder.ShouldFailFastOnUnobservedException();

		// Token: 0x040007D5 RID: 2005
		private readonly Task m_task;

		// Token: 0x040007D6 RID: 2006
		private volatile LowLevelListWithIList<ExceptionDispatchInfo> m_faultExceptions;

		// Token: 0x040007D7 RID: 2007
		private ExceptionDispatchInfo m_cancellationException;

		// Token: 0x040007D8 RID: 2008
		private volatile bool m_isHandled;
	}
}
