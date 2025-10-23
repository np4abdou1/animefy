using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Domain.Task
{
	// Token: 0x02000103 RID: 259
	[Register("com/unity3d/services/core/domain/task/BaseParams", "", "Com.Unity3d.Services.Core.Domain.Task.IBaseParamsInvoker")]
	public interface IBaseParams : IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
