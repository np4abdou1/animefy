using System;
using System.Collections;
using System.Reflection;

namespace System.ComponentModel
{
	// Token: 0x02000280 RID: 640
	internal sealed class ReflectEventDescriptor : EventDescriptor
	{
		// Token: 0x06001131 RID: 4401 RVA: 0x00051772 File Offset: 0x0004F972
		public ReflectEventDescriptor(Type componentClass, EventInfo eventInfo) : base(eventInfo.Name, Array.Empty<Attribute>())
		{
			if (componentClass == null)
			{
				throw new ArgumentException(SR.Format("Null is not a valid value for {0}.", "componentClass"));
			}
			this._componentClass = componentClass;
			this._realEvent = eventInfo;
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x000517B4 File Offset: 0x0004F9B4
		protected override void FillAttributes(IList attributes)
		{
			this.FillMethods();
			if (this._realEvent != null)
			{
				this.FillEventInfoAttribute(this._realEvent, attributes);
			}
			else
			{
				this.FillSingleMethodAttribute(this._removeMethod, attributes);
				this.FillSingleMethodAttribute(this._addMethod, attributes);
			}
			base.FillAttributes(attributes);
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00051808 File Offset: 0x0004FA08
		private void FillEventInfoAttribute(EventInfo realEventInfo, IList attributes)
		{
			string name = realEventInfo.Name;
			BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public;
			Type type = realEventInfo.ReflectedType;
			int num = 0;
			while (type != typeof(object))
			{
				num++;
				type = type.BaseType;
			}
			if (num > 0)
			{
				type = realEventInfo.ReflectedType;
				Attribute[][] array = new Attribute[num][];
				while (type != typeof(object))
				{
					MemberInfo @event = type.GetEvent(name, bindingAttr);
					if (@event != null)
					{
						array[--num] = ReflectTypeDescriptionProvider.ReflectGetAttributes(@event);
					}
					type = type.BaseType;
				}
				foreach (Attribute[] array3 in array)
				{
					if (array3 != null)
					{
						foreach (Attribute value in array3)
						{
							attributes.Add(value);
						}
					}
				}
			}
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x000518E4 File Offset: 0x0004FAE4
		private void FillMethods()
		{
			if (this._filledMethods)
			{
				return;
			}
			if (this._realEvent != null)
			{
				this._addMethod = this._realEvent.GetAddMethod();
				this._removeMethod = this._realEvent.GetRemoveMethod();
				EventInfo eventInfo = null;
				if (this._addMethod == null || this._removeMethod == null)
				{
					Type baseType = this._componentClass.BaseType;
					while (baseType != null && baseType != typeof(object))
					{
						BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
						EventInfo @event = baseType.GetEvent(this._realEvent.Name, bindingAttr);
						if (@event.GetAddMethod() != null)
						{
							eventInfo = @event;
							break;
						}
					}
				}
				if (eventInfo != null)
				{
					this._addMethod = eventInfo.GetAddMethod();
					this._removeMethod = eventInfo.GetRemoveMethod();
					this._type = eventInfo.EventHandlerType;
				}
				else
				{
					this._type = this._realEvent.EventHandlerType;
				}
			}
			else
			{
				this._realEvent = this._componentClass.GetEvent(this.Name);
				if (this._realEvent != null)
				{
					this.FillMethods();
					return;
				}
				Type[] args = new Type[]
				{
					this._type
				};
				this._addMethod = MemberDescriptor.FindMethod(this._componentClass, "AddOn" + this.Name, args, typeof(void));
				this._removeMethod = MemberDescriptor.FindMethod(this._componentClass, "RemoveOn" + this.Name, args, typeof(void));
				if (this._addMethod == null || this._removeMethod == null)
				{
					throw new ArgumentException(SR.Format("Accessor methods for the {0} event are missing.", this.Name));
				}
			}
			this._filledMethods = true;
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00051AB4 File Offset: 0x0004FCB4
		private void FillSingleMethodAttribute(MethodInfo realMethodInfo, IList attributes)
		{
			string name = realMethodInfo.Name;
			BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public;
			Type type = realMethodInfo.ReflectedType;
			int num = 0;
			while (type != null && type != typeof(object))
			{
				num++;
				type = type.BaseType;
			}
			if (num > 0)
			{
				type = realMethodInfo.ReflectedType;
				Attribute[][] array = new Attribute[num][];
				while (type != null && type != typeof(object))
				{
					MemberInfo method = type.GetMethod(name, bindingAttr);
					if (method != null)
					{
						array[--num] = ReflectTypeDescriptionProvider.ReflectGetAttributes(method);
					}
					type = type.BaseType;
				}
				foreach (Attribute[] array3 in array)
				{
					if (array3 != null)
					{
						foreach (Attribute value in array3)
						{
							attributes.Add(value);
						}
					}
				}
			}
		}

		// Token: 0x04000C8E RID: 3214
		private Type _type;

		// Token: 0x04000C8F RID: 3215
		private readonly Type _componentClass;

		// Token: 0x04000C90 RID: 3216
		private MethodInfo _addMethod;

		// Token: 0x04000C91 RID: 3217
		private MethodInfo _removeMethod;

		// Token: 0x04000C92 RID: 3218
		private EventInfo _realEvent;

		// Token: 0x04000C93 RID: 3219
		private bool _filledMethods;
	}
}
