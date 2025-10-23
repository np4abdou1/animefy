using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Enforces a synchronization domain for the current context and all contexts that share the same instance.</summary>
	// Token: 0x0200033A RID: 826
	[AttributeUsage(AttributeTargets.Class)]
	[ComVisible(true)]
	[Serializable]
	public class SynchronizationAttribute : ContextAttribute, IContributeClientContextSink, IContributeServerContextSink
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> class with default values.</summary>
		// Token: 0x06001AAD RID: 6829 RVA: 0x00073DCC File Offset: 0x00071FCC
		public SynchronizationAttribute() : this(8, false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> class with a flag indicating the behavior of the object to which this attribute is applied, and a Boolean value indicating whether reentry is required.</summary>
		/// <param name="flag">An integer value indicating the behavior of the object to which this attribute is applied. </param>
		/// <param name="reEntrant">
		///       <see langword="true" /> if reentry is required, and callouts must be intercepted and serialized; otherwise, <see langword="false" />. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="flag" /> parameter was not one of the defined flags. </exception>
		// Token: 0x06001AAE RID: 6830 RVA: 0x00073DD8 File Offset: 0x00071FD8
		public SynchronizationAttribute(int flag, bool reEntrant) : base("Synchronization")
		{
			if (flag != 1 && flag != 4 && flag != 8 && flag != 2)
			{
				throw new ArgumentException("flag");
			}
			this._bReEntrant = reEntrant;
			this._flavor = flag;
		}

		/// <summary>Gets or sets a Boolean value indicating whether reentry is required.</summary>
		/// <returns>A Boolean value indicating whether reentry is required.</returns>
		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06001AAF RID: 6831 RVA: 0x00073E25 File Offset: 0x00072025
		public virtual bool IsReEntrant
		{
			get
			{
				return this._bReEntrant;
			}
		}

		/// <summary>Gets or sets a Boolean value indicating whether the <see cref="T:System.Runtime.Remoting.Contexts.Context" /> implementing this instance of <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> is locked.</summary>
		/// <returns>A Boolean value indicating whether the <see cref="T:System.Runtime.Remoting.Contexts.Context" /> implementing this instance of <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> is locked.</returns>
		// Token: 0x170002F6 RID: 758
		// (set) Token: 0x06001AB0 RID: 6832 RVA: 0x00073E30 File Offset: 0x00072030
		public virtual bool Locked
		{
			set
			{
				SynchronizationAttribute obj;
				if (value)
				{
					this.AcquireLock();
					obj = this;
					lock (obj)
					{
						if (this._lockCount > 1)
						{
							this.ReleaseLock();
						}
						return;
					}
				}
				obj = this;
				lock (obj)
				{
					while (this._lockCount > 0 && this._ownerThread == Thread.CurrentThread)
					{
						this.ReleaseLock();
					}
				}
			}
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x00073EC0 File Offset: 0x000720C0
		internal void AcquireLock()
		{
			this._mutex.WaitOne();
			lock (this)
			{
				this._ownerThread = Thread.CurrentThread;
				this._lockCount++;
			}
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x00073F1C File Offset: 0x0007211C
		internal void ReleaseLock()
		{
			lock (this)
			{
				if (this._lockCount > 0 && this._ownerThread == Thread.CurrentThread)
				{
					this._lockCount--;
					this._mutex.ReleaseMutex();
					if (this._lockCount == 0)
					{
						this._ownerThread = null;
					}
				}
			}
		}

		/// <summary>Adds the <see langword="Synchronized" /> context property to the specified <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />.</summary>
		/// <param name="ctorMsg">The <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" /> to which to add the property. </param>
		// Token: 0x06001AB3 RID: 6835 RVA: 0x00073F90 File Offset: 0x00072190
		[ComVisible(true)]
		public override void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg)
		{
			if (this._flavor != 1)
			{
				ctorMsg.ContextProperties.Add(this);
			}
		}

		/// <summary>Creates a CallOut sink and chains it in front of the provided chain of sinks at the context boundary on the client end of a remoting call.</summary>
		/// <param name="nextSink">The chain of sinks composed so far. </param>
		/// <returns>The composite sink chain with the new CallOut sink.</returns>
		// Token: 0x06001AB4 RID: 6836 RVA: 0x00073FA8 File Offset: 0x000721A8
		public virtual IMessageSink GetClientContextSink(IMessageSink nextSink)
		{
			return new SynchronizedClientContextSink(nextSink, this);
		}

		/// <summary>Creates a synchronized dispatch sink and chains it in front of the provided chain of sinks at the context boundary on the server end of a remoting call.</summary>
		/// <param name="nextSink">The chain of sinks composed so far. </param>
		/// <returns>The composite sink chain with the new synchronized dispatch sink.</returns>
		// Token: 0x06001AB5 RID: 6837 RVA: 0x00073FB1 File Offset: 0x000721B1
		public virtual IMessageSink GetServerContextSink(IMessageSink nextSink)
		{
			return new SynchronizedServerContextSink(nextSink, this);
		}

		/// <summary>Returns a Boolean value indicating whether the context parameter meets the context attribute's requirements.</summary>
		/// <param name="ctx">The context to check. </param>
		/// <param name="msg">Information gathered at construction time of the context bound object marked by this attribute. The <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> can inspect, add to, and remove properties from the context while determining if the context is acceptable to it. </param>
		/// <returns>
		///     <see langword="true" /> if the passed in context is OK; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="ctx" /> or <paramref name="msg" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001AB6 RID: 6838 RVA: 0x00073FBC File Offset: 0x000721BC
		[ComVisible(true)]
		public override bool IsContextOK(Context ctx, IConstructionCallMessage msg)
		{
			SynchronizationAttribute synchronizationAttribute = ctx.GetProperty("Synchronization") as SynchronizationAttribute;
			int flavor = this._flavor;
			switch (flavor)
			{
			case 1:
				return synchronizationAttribute == null;
			case 2:
				return true;
			case 3:
				break;
			case 4:
				return synchronizationAttribute != null;
			default:
				if (flavor == 8)
				{
					return false;
				}
				break;
			}
			return false;
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x00074010 File Offset: 0x00072210
		internal static void ExitContext()
		{
			if (Thread.CurrentContext.IsDefaultContext)
			{
				return;
			}
			SynchronizationAttribute synchronizationAttribute = Thread.CurrentContext.GetProperty("Synchronization") as SynchronizationAttribute;
			if (synchronizationAttribute == null)
			{
				return;
			}
			synchronizationAttribute.Locked = false;
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0007404C File Offset: 0x0007224C
		internal static void EnterContext()
		{
			if (Thread.CurrentContext.IsDefaultContext)
			{
				return;
			}
			SynchronizationAttribute synchronizationAttribute = Thread.CurrentContext.GetProperty("Synchronization") as SynchronizationAttribute;
			if (synchronizationAttribute == null)
			{
				return;
			}
			synchronizationAttribute.Locked = true;
		}

		// Token: 0x04000B29 RID: 2857
		private bool _bReEntrant;

		// Token: 0x04000B2A RID: 2858
		private int _flavor;

		// Token: 0x04000B2B RID: 2859
		[NonSerialized]
		private int _lockCount;

		// Token: 0x04000B2C RID: 2860
		[NonSerialized]
		private Mutex _mutex = new Mutex(false);

		// Token: 0x04000B2D RID: 2861
		[NonSerialized]
		private Thread _ownerThread;
	}
}
