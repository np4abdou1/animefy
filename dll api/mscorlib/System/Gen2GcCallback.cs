using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x020000A0 RID: 160
	internal sealed class Gen2GcCallback : CriticalFinalizerObject
	{
		// Token: 0x06000552 RID: 1362 RVA: 0x00013B7E File Offset: 0x00011D7E
		private Gen2GcCallback()
		{
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00013B86 File Offset: 0x00011D86
		public static void Register(Func<object, bool> callback, object targetObj)
		{
			new Gen2GcCallback().Setup(callback, targetObj);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00013B94 File Offset: 0x00011D94
		private void Setup(Func<object, bool> callback, object targetObj)
		{
			this._callback = callback;
			this._weakTargetObj = GCHandle.Alloc(targetObj, GCHandleType.Weak);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00013BAC File Offset: 0x00011DAC
		protected override void Finalize()
		{
			try
			{
				object target = this._weakTargetObj.Target;
				if (target == null)
				{
					this._weakTargetObj.Free();
				}
				else
				{
					try
					{
						if (!this._callback(target))
						{
							return;
						}
					}
					catch
					{
					}
					if (!Environment.HasShutdownStarted)
					{
						GC.ReRegisterForFinalize(this);
					}
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x04000224 RID: 548
		private Func<object, bool> _callback;

		// Token: 0x04000225 RID: 549
		private GCHandle _weakTargetObj;
	}
}
