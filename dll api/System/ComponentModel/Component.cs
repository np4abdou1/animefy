using System;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	/// <summary>Provides the base implementation for the <see cref="T:System.ComponentModel.IComponent" /> interface and enables object sharing between applications.</summary>
	// Token: 0x02000299 RID: 665
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[DesignerCategory("Component")]
	public class Component : MarshalByRefObject, IComponent, IDisposable
	{
		/// <summary>Releases unmanaged resources and performs other cleanup operations before the <see cref="T:System.ComponentModel.Component" /> is reclaimed by garbage collection.</summary>
		// Token: 0x06001187 RID: 4487 RVA: 0x00052100 File Offset: 0x00050300
		~Component()
		{
			this.Dispose(false);
		}

		/// <summary>Gets a value indicating whether the component can raise an event.</summary>
		/// <returns>
		///     <see langword="true" /> if the component can raise events; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x00009518 File Offset: 0x00007718
		protected virtual bool CanRaiseEvents
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x00052130 File Offset: 0x00050330
		internal bool CanRaiseEventsInternal
		{
			get
			{
				return this.CanRaiseEvents;
			}
		}

		/// <summary>Gets the list of event handlers that are attached to this <see cref="T:System.ComponentModel.Component" />.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.EventHandlerList" /> that provides the delegates for this component.</returns>
		// Token: 0x1700038F RID: 911
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x00052138 File Offset: 0x00050338
		protected EventHandlerList Events
		{
			get
			{
				if (this.events == null)
				{
					this.events = new EventHandlerList(this);
				}
				return this.events;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.ComponentModel.ISite" /> of the <see cref="T:System.ComponentModel.Component" />.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.ISite" /> associated with the <see cref="T:System.ComponentModel.Component" />, or <see langword="null" /> if the <see cref="T:System.ComponentModel.Component" /> is not encapsulated in an <see cref="T:System.ComponentModel.IContainer" />, the <see cref="T:System.ComponentModel.Component" /> does not have an <see cref="T:System.ComponentModel.ISite" /> associated with it, or the <see cref="T:System.ComponentModel.Component" /> is removed from its <see cref="T:System.ComponentModel.IContainer" />.</returns>
		// Token: 0x17000390 RID: 912
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x00052154 File Offset: 0x00050354
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual ISite Site
		{
			get
			{
				return this.site;
			}
		}

		/// <summary>Releases all resources used by the <see cref="T:System.ComponentModel.Component" />.</summary>
		// Token: 0x0600118C RID: 4492 RVA: 0x0005215C File Offset: 0x0005035C
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.ComponentModel.Component" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x0600118D RID: 4493 RVA: 0x0005216C File Offset: 0x0005036C
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				lock (this)
				{
					if (this.site != null && this.site.Container != null)
					{
						this.site.Container.Remove(this);
					}
					if (this.events != null)
					{
						EventHandler eventHandler = (EventHandler)this.events[Component.EventDisposed];
						if (eventHandler != null)
						{
							eventHandler(this, EventArgs.Empty);
						}
					}
				}
			}
		}

		/// <summary>Returns an object that represents a service provided by the <see cref="T:System.ComponentModel.Component" /> or by its <see cref="T:System.ComponentModel.Container" />.</summary>
		/// <param name="service">A service provided by the <see cref="T:System.ComponentModel.Component" />. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents a service provided by the <see cref="T:System.ComponentModel.Component" />, or <see langword="null" /> if the <see cref="T:System.ComponentModel.Component" /> does not provide the specified service.</returns>
		// Token: 0x0600118E RID: 4494 RVA: 0x000521F8 File Offset: 0x000503F8
		protected virtual object GetService(Type service)
		{
			ISite site = this.site;
			if (site != null)
			{
				return site.GetService(service);
			}
			return null;
		}

		/// <summary>Gets a value that indicates whether the <see cref="T:System.ComponentModel.Component" /> is currently in design mode.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.ComponentModel.Component" /> is in design mode; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000391 RID: 913
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x00052218 File Offset: 0x00050418
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		protected bool DesignMode
		{
			get
			{
				ISite site = this.site;
				return site != null && site.DesignMode;
			}
		}

		/// <summary>Returns a <see cref="T:System.String" /> containing the name of the <see cref="T:System.ComponentModel.Component" />, if any. This method should not be overridden.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the name of the <see cref="T:System.ComponentModel.Component" />, if any, or <see langword="null" /> if the <see cref="T:System.ComponentModel.Component" /> is unnamed.</returns>
		// Token: 0x06001190 RID: 4496 RVA: 0x00052238 File Offset: 0x00050438
		public override string ToString()
		{
			ISite site = this.site;
			if (site != null)
			{
				return site.Name + " [" + base.GetType().FullName + "]";
			}
			return base.GetType().FullName;
		}

		// Token: 0x04000C9F RID: 3231
		private static readonly object EventDisposed = new object();

		// Token: 0x04000CA0 RID: 3232
		private ISite site;

		// Token: 0x04000CA1 RID: 3233
		private EventHandlerList events;
	}
}
