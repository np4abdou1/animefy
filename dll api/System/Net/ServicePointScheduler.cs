using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	// Token: 0x020001C0 RID: 448
	internal class ServicePointScheduler
	{
		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x0003FE82 File Offset: 0x0003E082
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x0003FE8A File Offset: 0x0003E08A
		private ServicePoint ServicePoint { get; set; }

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x0003FE93 File Offset: 0x0003E093
		public int MaxIdleTime
		{
			get
			{
				return this.maxIdleTime;
			}
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0003FE9C File Offset: 0x0003E09C
		public ServicePointScheduler(ServicePoint servicePoint, int connectionLimit, int maxIdleTime)
		{
			this.ServicePoint = servicePoint;
			this.connectionLimit = connectionLimit;
			this.maxIdleTime = maxIdleTime;
			this.schedulerEvent = new ServicePointScheduler.AsyncManualResetEvent(false);
			this.defaultGroup = new ServicePointScheduler.ConnectionGroup(this, string.Empty);
			this.operations = new LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>>();
			this.idleConnections = new LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>>();
			this.idleSince = DateTime.UtcNow;
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0003FF20 File Offset: 0x0003E120
		public void Run()
		{
			if (Interlocked.CompareExchange(ref this.running, 1, 0) == 0)
			{
				Task.Run(() => this.RunScheduler());
			}
			this.schedulerEvent.Set();
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0003FF50 File Offset: 0x0003E150
		private Task RunScheduler()
		{
			ServicePointScheduler.<RunScheduler>d__32 <RunScheduler>d__;
			<RunScheduler>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<RunScheduler>d__.<>4__this = this;
			<RunScheduler>d__.<>1__state = -1;
			<RunScheduler>d__.<>t__builder.Start<ServicePointScheduler.<RunScheduler>d__32>(ref <RunScheduler>d__);
			return <RunScheduler>d__.<>t__builder.Task;
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0003FF94 File Offset: 0x0003E194
		private void Cleanup()
		{
			if (this.groups != null)
			{
				string[] array = new string[this.groups.Count];
				this.groups.Keys.CopyTo(array, 0);
				foreach (string key in array)
				{
					if (this.groups.ContainsKey(key) && this.groups[key].IsEmpty())
					{
						this.groups.Remove(key);
					}
				}
				if (this.groups.Count == 0)
				{
					this.groups = null;
				}
			}
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00040024 File Offset: 0x0003E224
		private void RunSchedulerIteration()
		{
			this.schedulerEvent.Reset();
			bool flag;
			do
			{
				flag = this.SchedulerIteration(this.defaultGroup);
				if (this.groups != null)
				{
					foreach (KeyValuePair<string, ServicePointScheduler.ConnectionGroup> keyValuePair in this.groups)
					{
						flag |= this.SchedulerIteration(keyValuePair.Value);
					}
				}
			}
			while (flag);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x000400A4 File Offset: 0x0003E2A4
		private bool OperationCompleted(ServicePointScheduler.ConnectionGroup group, WebOperation operation)
		{
			WebCompletionSource<ValueTuple<bool, WebOperation>>.Result currentResult = operation.Finished.CurrentResult;
			bool flag;
			WebOperation webOperation;
			if (!currentResult.Success)
			{
				flag = false;
				webOperation = null;
			}
			else
			{
				ValueTuple<bool, WebOperation> argument = currentResult.Argument;
				flag = argument.Item1;
				webOperation = argument.Item2;
			}
			if (!flag || !operation.Connection.Continue(webOperation))
			{
				group.RemoveConnection(operation.Connection);
				if (webOperation == null)
				{
					return true;
				}
				flag = false;
			}
			if (webOperation == null)
			{
				if (flag)
				{
					Task item = Task.Delay(this.MaxIdleTime);
					this.idleConnections.AddLast(new ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>(group, operation.Connection, item));
				}
				return true;
			}
			this.operations.AddLast(new ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>(group, webOperation));
			if (flag)
			{
				this.RemoveIdleConnection(operation.Connection);
				return false;
			}
			group.Cleanup();
			group.CreateOrReuseConnection(webOperation, true);
			return false;
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00040167 File Offset: 0x0003E367
		private void CloseIdleConnection(ServicePointScheduler.ConnectionGroup group, WebConnection connection)
		{
			group.RemoveConnection(connection);
			this.RemoveIdleConnection(connection);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00040178 File Offset: 0x0003E378
		private bool SchedulerIteration(ServicePointScheduler.ConnectionGroup group)
		{
			group.Cleanup();
			WebOperation nextOperation = group.GetNextOperation();
			if (nextOperation == null)
			{
				return false;
			}
			WebConnection item = group.CreateOrReuseConnection(nextOperation, false).Item1;
			if (item == null)
			{
				return false;
			}
			this.operations.AddLast(new ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>(group, nextOperation));
			this.RemoveIdleConnection(item);
			return true;
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x000401C8 File Offset: 0x0003E3C8
		private void RemoveOperation(WebOperation operation)
		{
			LinkedListNode<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> linkedListNode = this.operations.First;
			while (linkedListNode != null)
			{
				LinkedListNode<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> linkedListNode2 = linkedListNode;
				linkedListNode = linkedListNode.Next;
				if (linkedListNode2.Value.Item2 == operation)
				{
					this.operations.Remove(linkedListNode2);
				}
			}
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0004020C File Offset: 0x0003E40C
		private void RemoveIdleConnection(WebConnection connection)
		{
			LinkedListNode<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> linkedListNode = this.idleConnections.First;
			while (linkedListNode != null)
			{
				LinkedListNode<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> linkedListNode2 = linkedListNode;
				linkedListNode = linkedListNode.Next;
				if (linkedListNode2.Value.Item2 == connection)
				{
					this.idleConnections.Remove(linkedListNode2);
				}
			}
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0004024D File Offset: 0x0003E44D
		private void FinalCleanup()
		{
			this.groups = null;
			this.operations = null;
			this.idleConnections = null;
			this.defaultGroup = null;
			this.ServicePoint.FreeServicePoint();
			ServicePointManager.RemoveServicePoint(this.ServicePoint);
			this.ServicePoint = null;
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00040288 File Offset: 0x0003E488
		public void SendRequest(WebOperation operation, string groupName)
		{
			ServicePoint servicePoint = this.ServicePoint;
			lock (servicePoint)
			{
				this.GetConnectionGroup(groupName).EnqueueOperation(operation);
				this.Run();
			}
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x000402D8 File Offset: 0x0003E4D8
		private ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name)
		{
			ServicePoint servicePoint = this.ServicePoint;
			ServicePointScheduler.ConnectionGroup result;
			lock (servicePoint)
			{
				if (string.IsNullOrEmpty(name))
				{
					result = this.defaultGroup;
				}
				else
				{
					if (this.groups == null)
					{
						this.groups = new Dictionary<string, ServicePointScheduler.ConnectionGroup>();
					}
					ServicePointScheduler.ConnectionGroup connectionGroup;
					if (this.groups.TryGetValue(name, out connectionGroup))
					{
						result = connectionGroup;
					}
					else
					{
						connectionGroup = new ServicePointScheduler.ConnectionGroup(this, name);
						this.groups.Add(name, connectionGroup);
						result = connectionGroup;
					}
				}
			}
			return result;
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00040364 File Offset: 0x0003E564
		private void OnConnectionCreated(WebConnection connection)
		{
			Interlocked.Increment(ref this.currentConnections);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00040372 File Offset: 0x0003E572
		private void OnConnectionClosed(WebConnection connection)
		{
			this.RemoveIdleConnection(connection);
			Interlocked.Decrement(ref this.currentConnections);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00040388 File Offset: 0x0003E588
		public static Task<bool> WaitAsync(Task workerTask, int millisecondTimeout)
		{
			ServicePointScheduler.<WaitAsync>d__46 <WaitAsync>d__;
			<WaitAsync>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<WaitAsync>d__.workerTask = workerTask;
			<WaitAsync>d__.millisecondTimeout = millisecondTimeout;
			<WaitAsync>d__.<>1__state = -1;
			<WaitAsync>d__.<>t__builder.Start<ServicePointScheduler.<WaitAsync>d__46>(ref <WaitAsync>d__);
			return <WaitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x040008F8 RID: 2296
		private int running;

		// Token: 0x040008F9 RID: 2297
		private int maxIdleTime = 100000;

		// Token: 0x040008FA RID: 2298
		private ServicePointScheduler.AsyncManualResetEvent schedulerEvent;

		// Token: 0x040008FB RID: 2299
		private ServicePointScheduler.ConnectionGroup defaultGroup;

		// Token: 0x040008FC RID: 2300
		private Dictionary<string, ServicePointScheduler.ConnectionGroup> groups;

		// Token: 0x040008FD RID: 2301
		private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> operations;

		// Token: 0x040008FE RID: 2302
		private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> idleConnections;

		// Token: 0x040008FF RID: 2303
		private int currentConnections;

		// Token: 0x04000900 RID: 2304
		private int connectionLimit;

		// Token: 0x04000901 RID: 2305
		private DateTime idleSince;

		// Token: 0x04000902 RID: 2306
		private static int nextId;

		// Token: 0x04000903 RID: 2307
		public readonly int ID = ++ServicePointScheduler.nextId;

		// Token: 0x020001C1 RID: 449
		private class ConnectionGroup
		{
			// Token: 0x17000275 RID: 629
			// (get) Token: 0x06000C47 RID: 3143 RVA: 0x000403DB File Offset: 0x0003E5DB
			public ServicePointScheduler Scheduler { get; }

			// Token: 0x06000C48 RID: 3144 RVA: 0x000403E3 File Offset: 0x0003E5E3
			public ConnectionGroup(ServicePointScheduler scheduler, string name)
			{
				this.Scheduler = scheduler;
				this.<Name>k__BackingField = name;
				this.connections = new LinkedList<WebConnection>();
				this.queue = new LinkedList<WebOperation>();
			}

			// Token: 0x06000C49 RID: 3145 RVA: 0x00040422 File Offset: 0x0003E622
			public bool IsEmpty()
			{
				return this.connections.Count == 0 && this.queue.Count == 0;
			}

			// Token: 0x06000C4A RID: 3146 RVA: 0x00040441 File Offset: 0x0003E641
			public void RemoveConnection(WebConnection connection)
			{
				this.connections.Remove(connection);
				connection.Dispose();
				this.Scheduler.OnConnectionClosed(connection);
			}

			// Token: 0x06000C4B RID: 3147 RVA: 0x00040464 File Offset: 0x0003E664
			public void Cleanup()
			{
				LinkedListNode<WebConnection> linkedListNode = this.connections.First;
				while (linkedListNode != null)
				{
					WebConnection value = linkedListNode.Value;
					LinkedListNode<WebConnection> node = linkedListNode;
					linkedListNode = linkedListNode.Next;
					if (value.Closed)
					{
						this.connections.Remove(node);
						this.Scheduler.OnConnectionClosed(value);
					}
				}
			}

			// Token: 0x06000C4C RID: 3148 RVA: 0x000404B2 File Offset: 0x0003E6B2
			public void EnqueueOperation(WebOperation operation)
			{
				this.queue.AddLast(operation);
			}

			// Token: 0x06000C4D RID: 3149 RVA: 0x000404C4 File Offset: 0x0003E6C4
			public WebOperation GetNextOperation()
			{
				LinkedListNode<WebOperation> linkedListNode = this.queue.First;
				while (linkedListNode != null)
				{
					WebOperation value = linkedListNode.Value;
					LinkedListNode<WebOperation> node = linkedListNode;
					linkedListNode = linkedListNode.Next;
					if (!value.Aborted)
					{
						return value;
					}
					this.queue.Remove(node);
					this.Scheduler.RemoveOperation(value);
				}
				return null;
			}

			// Token: 0x06000C4E RID: 3150 RVA: 0x00040518 File Offset: 0x0003E718
			public WebConnection FindIdleConnection(WebOperation operation)
			{
				WebConnection webConnection = null;
				foreach (WebConnection webConnection2 in this.connections)
				{
					if (webConnection2.CanReuseConnection(operation) && (webConnection == null || webConnection2.IdleSince > webConnection.IdleSince))
					{
						webConnection = webConnection2;
					}
				}
				if (webConnection != null && webConnection.StartOperation(operation, true))
				{
					this.queue.Remove(operation);
					return webConnection;
				}
				foreach (WebConnection webConnection3 in this.connections)
				{
					if (webConnection3.StartOperation(operation, true))
					{
						this.queue.Remove(operation);
						return webConnection3;
					}
				}
				return null;
			}

			// Token: 0x06000C4F RID: 3151 RVA: 0x00040600 File Offset: 0x0003E800
			[return: TupleElementNames(new string[]
			{
				"connection",
				"created"
			})]
			public ValueTuple<WebConnection, bool> CreateOrReuseConnection(WebOperation operation, bool force)
			{
				WebConnection webConnection = this.FindIdleConnection(operation);
				if (webConnection != null)
				{
					return new ValueTuple<WebConnection, bool>(webConnection, false);
				}
				if (force || this.Scheduler.ServicePoint.ConnectionLimit > this.connections.Count || this.connections.Count == 0)
				{
					webConnection = new WebConnection(this.Scheduler.ServicePoint);
					webConnection.StartOperation(operation, false);
					this.connections.AddFirst(webConnection);
					this.Scheduler.OnConnectionCreated(webConnection);
					this.queue.Remove(operation);
					return new ValueTuple<WebConnection, bool>(webConnection, true);
				}
				return new ValueTuple<WebConnection, bool>(null, false);
			}

			// Token: 0x04000906 RID: 2310
			private static int nextId;

			// Token: 0x04000907 RID: 2311
			public readonly int ID = ++ServicePointScheduler.ConnectionGroup.nextId;

			// Token: 0x04000908 RID: 2312
			private LinkedList<WebConnection> connections;

			// Token: 0x04000909 RID: 2313
			private LinkedList<WebOperation> queue;
		}

		// Token: 0x020001C2 RID: 450
		private class AsyncManualResetEvent
		{
			// Token: 0x06000C50 RID: 3152 RVA: 0x0004069C File Offset: 0x0003E89C
			public Task<bool> WaitAsync(int millisecondTimeout)
			{
				return ServicePointScheduler.WaitAsync(this.m_tcs.Task, millisecondTimeout);
			}

			// Token: 0x06000C51 RID: 3153 RVA: 0x000406B4 File Offset: 0x0003E8B4
			public void Set()
			{
				TaskCompletionSource<bool> tcs = this.m_tcs;
				Task.Factory.StartNew<bool>((object s) => ((TaskCompletionSource<bool>)s).TrySetResult(true), tcs, CancellationToken.None, TaskCreationOptions.PreferFairness, TaskScheduler.Default);
				tcs.Task.Wait();
			}

			// Token: 0x06000C52 RID: 3154 RVA: 0x0004070C File Offset: 0x0003E90C
			public void Reset()
			{
				TaskCompletionSource<bool> tcs;
				do
				{
					tcs = this.m_tcs;
				}
				while (tcs.Task.IsCompleted && Interlocked.CompareExchange<TaskCompletionSource<bool>>(ref this.m_tcs, new TaskCompletionSource<bool>(), tcs) != tcs);
			}

			// Token: 0x06000C53 RID: 3155 RVA: 0x00040743 File Offset: 0x0003E943
			public AsyncManualResetEvent(bool state)
			{
				if (state)
				{
					this.Set();
				}
			}

			// Token: 0x0400090A RID: 2314
			private volatile TaskCompletionSource<bool> m_tcs = new TaskCompletionSource<bool>();
		}
	}
}
