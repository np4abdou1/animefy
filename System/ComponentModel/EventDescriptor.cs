using System;

namespace System.ComponentModel
{
	/// <summary>Provides information about an event.</summary>
	// Token: 0x02000261 RID: 609
	public abstract class EventDescriptor : MemberDescriptor
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EventDescriptor" /> class with the specified name and attribute array.</summary>
		/// <param name="name">The name of the event. </param>
		/// <param name="attrs">An array of type <see cref="T:System.Attribute" /> that contains the event attributes. </param>
		// Token: 0x06001044 RID: 4164 RVA: 0x0004FB19 File Offset: 0x0004DD19
		protected EventDescriptor(string name, Attribute[] attrs) : base(name, attrs)
		{
		}
	}
}
