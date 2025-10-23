using System;

namespace System.ComponentModel
{
	/// <summary>Implements <see cref="T:System.ComponentModel.IComponent" /> and provides the base implementation for remotable components that are marshaled by value (a copy of the serialized object is passed).</summary>
	// Token: 0x02000278 RID: 632
	[DesignerCategory("Component")]
	[TypeConverter(typeof(ComponentConverter))]
	public class MarshalByValueComponent : IComponent, IDisposable, IServiceProvider
	{
		/// <summary>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.</summary>
		// Token: 0x060010CB RID: 4299 RVA: 0x00050588 File Offset: 0x0004E788
		~MarshalByValueComponent()
		{
			this.Dispose(false);
		}

		/// <summary>Gets or sets the site of the component.</summary>
		/// <returns>An object implementing the <see cref="T:System.ComponentModel.ISite" /> interface that represents the site of the component.</returns>
		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060010CC RID: 4300 RVA: 0x000505B8 File Offset: 0x0004E7B8
		// (set) Token: 0x060010CD RID: 4301 RVA: 0x000505C0 File Offset: 0x0004E7C0
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual ISite Site
		{
			get
			{
				return this._site;
			}
			set
			{
				this._site = value;
			}
		}

		/// <summary>Releases all resources used by the <see cref="T:System.ComponentModel.MarshalByValueComponent" />.</summary>
		// Token: 0x060010CE RID: 4302 RVA: 0x000505C9 File Offset: 0x0004E7C9
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.ComponentModel.MarshalByValueComponent" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x060010CF RID: 4303 RVA: 0x000505D8 File Offset: 0x0004E7D8
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				lock (this)
				{
					ISite site = this._site;
					if (site != null)
					{
						IContainer container = site.Container;
						if (container != null)
						{
							container.Remove(this);
						}
					}
					EventHandlerList events = this._events;
					EventHandler eventHandler = (EventHandler)((events != null) ? events[MarshalByValueComponent.s_eventDisposed] : null);
					if (eventHandler != null)
					{
						eventHandler(this, EventArgs.Empty);
					}
				}
			}
		}

		/// <summary>Gets the implementer of the <see cref="T:System.IServiceProvider" />.</summary>
		/// <param name="service">A <see cref="T:System.Type" /> that represents the type of service you want. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the implementer of the <see cref="T:System.IServiceProvider" />.</returns>
		// Token: 0x060010D0 RID: 4304 RVA: 0x0005065C File Offset: 0x0004E85C
		public virtual object GetService(Type service)
		{
			ISite site = this._site;
			if (site == null)
			{
				return null;
			}
			return site.GetService(service);
		}

		/// <summary>Returns a <see cref="T:System.String" /> containing the name of the <see cref="T:System.ComponentModel.Component" />, if any. This method should not be overridden.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the name of the <see cref="T:System.ComponentModel.Component" />, if any.
		///     <see langword="null" /> if the <see cref="T:System.ComponentModel.Component" /> is unnamed.</returns>
		// Token: 0x060010D1 RID: 4305 RVA: 0x00050670 File Offset: 0x0004E870
		public override string ToString()
		{
			ISite site = this._site;
			if (site != null)
			{
				return site.Name + " [" + base.GetType().FullName + "]";
			}
			return base.GetType().FullName;
		}

		// Token: 0x04000C71 RID: 3185
		private static readonly object s_eventDisposed = new object();

		// Token: 0x04000C72 RID: 3186
		private ISite _site;

		// Token: 0x04000C73 RID: 3187
		private EventHandlerList _events;
	}
}
