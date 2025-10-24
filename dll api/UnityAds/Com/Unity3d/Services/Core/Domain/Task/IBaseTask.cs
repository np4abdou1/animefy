using System;
using Android.Runtime;
using Com.Unity3d.Services.Core.DI;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Domain.Task
{
	// Token: 0x02000106 RID: 262
	[Register("com/unity3d/services/core/domain/task/BaseTask", "", "Com.Unity3d.Services.Core.Domain.Task.IBaseTaskInvoker")]
	[JavaTypeParameters(new string[]
	{
		"P extends com.unity3d.services.core.domain.task.BaseParams",
		"R"
	})]
	public interface IBaseTask : IServiceComponent, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
