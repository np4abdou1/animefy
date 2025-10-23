using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Provides the default implementations of the <see cref="T:System.Runtime.Remoting.Contexts.IContextAttribute" /> and <see cref="T:System.Runtime.Remoting.Contexts.IContextProperty" /> interfaces.</summary>
	// Token: 0x02000330 RID: 816
	[AttributeUsage(AttributeTargets.Class)]
	[ComVisible(true)]
	[Serializable]
	public class ContextAttribute : Attribute, IContextAttribute, IContextProperty
	{
		/// <summary>Creates an instance of the <see cref="T:System.Runtime.Remoting.Contexts.ContextAttribute" /> class with the specified name.</summary>
		/// <param name="name">The name of the context attribute. </param>
		// Token: 0x06001A94 RID: 6804 RVA: 0x00073AF4 File Offset: 0x00071CF4
		public ContextAttribute(string name)
		{
			this.AttributeName = name;
		}

		/// <summary>Gets the name of the context attribute.</summary>
		/// <returns>The name of the context attribute.</returns>
		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001A95 RID: 6805 RVA: 0x00073B03 File Offset: 0x00071D03
		public virtual string Name
		{
			get
			{
				return this.AttributeName;
			}
		}

		/// <summary>Returns a Boolean value indicating whether this instance is equal to the specified object.</summary>
		/// <param name="o">The object to compare with this instance. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="o" /> is not <see langword="null" /> and if the object names are equivalent; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001A96 RID: 6806 RVA: 0x00073B0B File Offset: 0x00071D0B
		public override bool Equals(object o)
		{
			return o != null && o is ContextAttribute && !(((ContextAttribute)o).AttributeName != this.AttributeName);
		}

		/// <summary>Called when the context is frozen.</summary>
		/// <param name="newContext">The context to freeze. </param>
		// Token: 0x06001A97 RID: 6807 RVA: 0x00002A7D File Offset: 0x00000C7D
		public virtual void Freeze(Context newContext)
		{
		}

		/// <summary>Returns the hashcode for this instance of <see cref="T:System.Runtime.Remoting.Contexts.ContextAttribute" />.</summary>
		/// <returns>The hashcode for this instance of <see cref="T:System.Runtime.Remoting.Contexts.ContextAttribute" />.</returns>
		// Token: 0x06001A98 RID: 6808 RVA: 0x00073B37 File Offset: 0x00071D37
		public override int GetHashCode()
		{
			if (this.AttributeName == null)
			{
				return 0;
			}
			return this.AttributeName.GetHashCode();
		}

		/// <summary>Adds the current context property to the given message.</summary>
		/// <param name="ctorMsg">The <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" /> to which to add the context property. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="ctorMsg" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001A99 RID: 6809 RVA: 0x00073B4E File Offset: 0x00071D4E
		public virtual void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg)
		{
			if (ctorMsg == null)
			{
				throw new ArgumentNullException("ctorMsg");
			}
			ctorMsg.ContextProperties.Add(this);
		}

		/// <summary>Returns a Boolean value indicating whether the context parameter meets the context attribute's requirements.</summary>
		/// <param name="ctx">The context in which to check. </param>
		/// <param name="ctorMsg">The <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" /> to which to add the context property.</param>
		/// <returns>
		///     <see langword="true" /> if the passed in context is okay; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Either <paramref name="ctx" /> or <paramref name="ctorMsg" /> is <see langword="null" />. </exception>
		// Token: 0x06001A9A RID: 6810 RVA: 0x00073B6C File Offset: 0x00071D6C
		public virtual bool IsContextOK(Context ctx, IConstructionCallMessage ctorMsg)
		{
			if (ctorMsg == null)
			{
				throw new ArgumentNullException("ctorMsg");
			}
			if (ctx == null)
			{
				throw new ArgumentNullException("ctx");
			}
			if (!ctorMsg.ActivationType.IsContextful)
			{
				return true;
			}
			IContextProperty property = ctx.GetProperty(this.AttributeName);
			return property != null && this == property;
		}

		/// <summary>Returns a Boolean value indicating whether the context property is compatible with the new context.</summary>
		/// <param name="newCtx">The new context in which the property has been created. </param>
		/// <returns>
		///     <see langword="true" /> if the context property is okay with the new context; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001A9B RID: 6811 RVA: 0x0000B18D File Offset: 0x0000938D
		public virtual bool IsNewContextOK(Context newCtx)
		{
			return true;
		}

		/// <summary>Indicates the name of the context attribute.</summary>
		// Token: 0x04000B25 RID: 2853
		protected string AttributeName;
	}
}
