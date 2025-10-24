using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;

namespace System.ComponentModel
{
	// Token: 0x020002A0 RID: 672
	internal sealed class ReflectPropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x060011B5 RID: 4533 RVA: 0x000531F0 File Offset: 0x000513F0
		public ReflectPropertyDescriptor(Type componentClass, string name, Type type, Attribute[] attributes) : base(name, attributes)
		{
			try
			{
				if (type == null)
				{
					throw new ArgumentException(SR.GetString("Invalid type for the {0} property.", new object[]
					{
						name
					}));
				}
				if (componentClass == null)
				{
					throw new ArgumentException(SR.GetString("Null is not a valid value for {0}.", new object[]
					{
						"componentClass"
					}));
				}
				this.type = type;
				this.componentClass = componentClass;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00053274 File Offset: 0x00051474
		public ReflectPropertyDescriptor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) : this(componentClass, name, type, attrs)
		{
			this.propInfo = propInfo;
			this.getMethod = getMethod;
			this.setMethod = setMethod;
			if (getMethod != null && propInfo != null && setMethod == null)
			{
				this.state[ReflectPropertyDescriptor.BitGetQueried | ReflectPropertyDescriptor.BitSetOnDemand] = true;
				return;
			}
			this.state[ReflectPropertyDescriptor.BitGetQueried | ReflectPropertyDescriptor.BitSetQueried] = true;
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x000532F1 File Offset: 0x000514F1
		public ReflectPropertyDescriptor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) : this(componentClass, name, type, attrs)
		{
			this.receiverType = receiverType;
			this.getMethod = getMethod;
			this.setMethod = setMethod;
			this.state[ReflectPropertyDescriptor.BitGetQueried | ReflectPropertyDescriptor.BitSetQueried] = true;
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x00053330 File Offset: 0x00051530
		private object AmbientValue
		{
			get
			{
				if (!this.state[ReflectPropertyDescriptor.BitAmbientValueQueried])
				{
					this.state[ReflectPropertyDescriptor.BitAmbientValueQueried] = true;
					Attribute attribute = this.Attributes[typeof(AmbientValueAttribute)];
					if (attribute != null)
					{
						this.ambientValue = ((AmbientValueAttribute)attribute).Value;
					}
					else
					{
						this.ambientValue = ReflectPropertyDescriptor.noValue;
					}
				}
				return this.ambientValue;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x0005339D File Offset: 0x0005159D
		public override Type ComponentType
		{
			get
			{
				return this.componentClass;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x000533A8 File Offset: 0x000515A8
		private object DefaultValue
		{
			get
			{
				if (!this.state[ReflectPropertyDescriptor.BitDefaultValueQueried])
				{
					this.state[ReflectPropertyDescriptor.BitDefaultValueQueried] = true;
					Attribute attribute = this.Attributes[typeof(DefaultValueAttribute)];
					if (attribute != null)
					{
						this.defaultValue = ((DefaultValueAttribute)attribute).Value;
						if (this.defaultValue != null && this.PropertyType.IsEnum && this.PropertyType.GetEnumUnderlyingType() == this.defaultValue.GetType())
						{
							this.defaultValue = Enum.ToObject(this.PropertyType, this.defaultValue);
						}
					}
					else
					{
						this.defaultValue = ReflectPropertyDescriptor.noValue;
					}
				}
				return this.defaultValue;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x00053464 File Offset: 0x00051664
		private MethodInfo GetMethodValue
		{
			get
			{
				if (!this.state[ReflectPropertyDescriptor.BitGetQueried])
				{
					this.state[ReflectPropertyDescriptor.BitGetQueried] = true;
					if (this.receiverType == null)
					{
						if (this.propInfo == null)
						{
							BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty;
							this.propInfo = this.componentClass.GetProperty(this.Name, bindingAttr, null, this.PropertyType, new Type[0], new ParameterModifier[0]);
						}
						if (this.propInfo != null)
						{
							this.getMethod = this.propInfo.GetGetMethod(true);
						}
						if (this.getMethod == null)
						{
							throw new InvalidOperationException(SR.GetString("Accessor methods for the {0} property are missing.", new object[]
							{
								this.componentClass.FullName + "." + this.Name
							}));
						}
					}
					else
					{
						this.getMethod = MemberDescriptor.FindMethod(this.componentClass, "Get" + this.Name, new Type[]
						{
							this.receiverType
						}, this.type);
						if (this.getMethod == null)
						{
							throw new ArgumentException(SR.GetString("Accessor methods for the {0} property are missing.", new object[]
							{
								this.Name
							}));
						}
					}
				}
				return this.getMethod;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x000535B5 File Offset: 0x000517B5
		private bool IsExtender
		{
			get
			{
				return this.receiverType != null;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x000535C3 File Offset: 0x000517C3
		public override bool IsReadOnly
		{
			get
			{
				return this.SetMethodValue == null || ((ReadOnlyAttribute)this.Attributes[typeof(ReadOnlyAttribute)]).IsReadOnly;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x000535F4 File Offset: 0x000517F4
		public override Type PropertyType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x000535FC File Offset: 0x000517FC
		private MethodInfo ResetMethodValue
		{
			get
			{
				if (!this.state[ReflectPropertyDescriptor.BitResetQueried])
				{
					this.state[ReflectPropertyDescriptor.BitResetQueried] = true;
					Type[] args;
					if (this.receiverType == null)
					{
						args = ReflectPropertyDescriptor.argsNone;
					}
					else
					{
						args = new Type[]
						{
							this.receiverType
						};
					}
					this.resetMethod = MemberDescriptor.FindMethod(this.componentClass, "Reset" + this.Name, args, typeof(void), false);
				}
				return this.resetMethod;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x00053688 File Offset: 0x00051888
		private MethodInfo SetMethodValue
		{
			get
			{
				if (!this.state[ReflectPropertyDescriptor.BitSetQueried] && this.state[ReflectPropertyDescriptor.BitSetOnDemand])
				{
					this.state[ReflectPropertyDescriptor.BitSetQueried] = true;
					BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public;
					string name = this.propInfo.Name;
					if (this.setMethod == null)
					{
						Type baseType = this.ComponentType.BaseType;
						while (baseType != null && baseType != typeof(object) && !(baseType == null))
						{
							PropertyInfo property = baseType.GetProperty(name, bindingAttr, null, this.PropertyType, new Type[0], null);
							if (property != null)
							{
								this.setMethod = property.GetSetMethod();
								if (this.setMethod != null)
								{
									break;
								}
							}
							baseType = baseType.BaseType;
						}
					}
				}
				if (!this.state[ReflectPropertyDescriptor.BitSetQueried])
				{
					this.state[ReflectPropertyDescriptor.BitSetQueried] = true;
					if (this.receiverType == null)
					{
						if (this.propInfo == null)
						{
							BindingFlags bindingAttr2 = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty;
							this.propInfo = this.componentClass.GetProperty(this.Name, bindingAttr2, null, this.PropertyType, new Type[0], new ParameterModifier[0]);
						}
						if (this.propInfo != null)
						{
							this.setMethod = this.propInfo.GetSetMethod(true);
						}
					}
					else
					{
						this.setMethod = MemberDescriptor.FindMethod(this.componentClass, "Set" + this.Name, new Type[]
						{
							this.receiverType,
							this.type
						}, typeof(void));
					}
				}
				return this.setMethod;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x00053840 File Offset: 0x00051A40
		private MethodInfo ShouldSerializeMethodValue
		{
			get
			{
				if (!this.state[ReflectPropertyDescriptor.BitShouldSerializeQueried])
				{
					this.state[ReflectPropertyDescriptor.BitShouldSerializeQueried] = true;
					Type[] args;
					if (this.receiverType == null)
					{
						args = ReflectPropertyDescriptor.argsNone;
					}
					else
					{
						args = new Type[]
						{
							this.receiverType
						};
					}
					this.shouldSerializeMethod = MemberDescriptor.FindMethod(this.componentClass, "ShouldSerialize" + this.Name, args, typeof(bool), false);
				}
				return this.shouldSerializeMethod;
			}
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x000538CC File Offset: 0x00051ACC
		internal bool ExtenderCanResetValue(IExtenderProvider provider, object component)
		{
			if (this.DefaultValue != ReflectPropertyDescriptor.noValue)
			{
				return !object.Equals(this.ExtenderGetValue(provider, component), this.defaultValue);
			}
			if (this.ResetMethodValue != null)
			{
				MethodInfo shouldSerializeMethodValue = this.ShouldSerializeMethodValue;
				if (shouldSerializeMethodValue != null)
				{
					try
					{
						provider = (IExtenderProvider)this.GetInvocationTarget(this.componentClass, provider);
						return (bool)shouldSerializeMethodValue.Invoke(provider, new object[]
						{
							component
						});
					}
					catch
					{
					}
					return true;
				}
				return true;
			}
			return false;
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00053960 File Offset: 0x00051B60
		internal Type ExtenderGetReceiverType()
		{
			return this.receiverType;
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00053968 File Offset: 0x00051B68
		internal Type ExtenderGetType(IExtenderProvider provider)
		{
			return this.PropertyType;
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00053970 File Offset: 0x00051B70
		internal object ExtenderGetValue(IExtenderProvider provider, object component)
		{
			if (provider != null)
			{
				provider = (IExtenderProvider)this.GetInvocationTarget(this.componentClass, provider);
				return this.GetMethodValue.Invoke(provider, new object[]
				{
					component
				});
			}
			return null;
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x000539A4 File Offset: 0x00051BA4
		internal void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc)
		{
			if (this.DefaultValue != ReflectPropertyDescriptor.noValue)
			{
				this.ExtenderSetValue(provider, component, this.DefaultValue, notifyDesc);
				return;
			}
			if (this.AmbientValue != ReflectPropertyDescriptor.noValue)
			{
				this.ExtenderSetValue(provider, component, this.AmbientValue, notifyDesc);
				return;
			}
			if (this.ResetMethodValue != null)
			{
				ISite site = MemberDescriptor.GetSite(component);
				IComponentChangeService componentChangeService = null;
				object oldValue = null;
				if (site != null)
				{
					componentChangeService = (IComponentChangeService)site.GetService(typeof(IComponentChangeService));
				}
				if (componentChangeService != null)
				{
					oldValue = this.ExtenderGetValue(provider, component);
					try
					{
						componentChangeService.OnComponentChanging(component, notifyDesc);
					}
					catch (CheckoutException ex)
					{
						if (ex == CheckoutException.Canceled)
						{
							return;
						}
						throw ex;
					}
				}
				provider = (IExtenderProvider)this.GetInvocationTarget(this.componentClass, provider);
				if (this.ResetMethodValue != null)
				{
					this.ResetMethodValue.Invoke(provider, new object[]
					{
						component
					});
					if (componentChangeService != null)
					{
						object newValue = this.ExtenderGetValue(provider, component);
						componentChangeService.OnComponentChanged(component, notifyDesc, oldValue, newValue);
					}
				}
			}
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00053AA8 File Offset: 0x00051CA8
		internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc)
		{
			if (provider != null)
			{
				ISite site = MemberDescriptor.GetSite(component);
				IComponentChangeService componentChangeService = null;
				object oldValue = null;
				if (site != null)
				{
					componentChangeService = (IComponentChangeService)site.GetService(typeof(IComponentChangeService));
				}
				if (componentChangeService != null)
				{
					oldValue = this.ExtenderGetValue(provider, component);
					try
					{
						componentChangeService.OnComponentChanging(component, notifyDesc);
					}
					catch (CheckoutException ex)
					{
						if (ex == CheckoutException.Canceled)
						{
							return;
						}
						throw ex;
					}
				}
				provider = (IExtenderProvider)this.GetInvocationTarget(this.componentClass, provider);
				if (this.SetMethodValue != null)
				{
					this.SetMethodValue.Invoke(provider, new object[]
					{
						component,
						value
					});
					if (componentChangeService != null)
					{
						componentChangeService.OnComponentChanged(component, notifyDesc, oldValue, value);
					}
				}
			}
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00053B60 File Offset: 0x00051D60
		internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component)
		{
			provider = (IExtenderProvider)this.GetInvocationTarget(this.componentClass, provider);
			if (this.IsReadOnly)
			{
				if (this.ShouldSerializeMethodValue != null)
				{
					try
					{
						return (bool)this.ShouldSerializeMethodValue.Invoke(provider, new object[]
						{
							component
						});
					}
					catch
					{
					}
				}
				return this.Attributes.Contains(DesignerSerializationVisibilityAttribute.Content);
			}
			if (this.DefaultValue == ReflectPropertyDescriptor.noValue)
			{
				if (this.ShouldSerializeMethodValue != null)
				{
					try
					{
						return (bool)this.ShouldSerializeMethodValue.Invoke(provider, new object[]
						{
							component
						});
					}
					catch
					{
					}
				}
				return true;
			}
			return !object.Equals(this.DefaultValue, this.ExtenderGetValue(provider, component));
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00053C3C File Offset: 0x00051E3C
		public override bool CanResetValue(object component)
		{
			if (this.IsExtender || this.IsReadOnly)
			{
				return false;
			}
			if (this.DefaultValue != ReflectPropertyDescriptor.noValue)
			{
				return !object.Equals(this.GetValue(component), this.DefaultValue);
			}
			if (this.ResetMethodValue != null)
			{
				if (this.ShouldSerializeMethodValue != null)
				{
					component = this.GetInvocationTarget(this.componentClass, component);
					try
					{
						return (bool)this.ShouldSerializeMethodValue.Invoke(component, null);
					}
					catch
					{
					}
					return true;
				}
				return true;
			}
			return this.AmbientValue != ReflectPropertyDescriptor.noValue && this.ShouldSerializeValue(component);
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00053CEC File Offset: 0x00051EEC
		protected override void FillAttributes(IList attributes)
		{
			foreach (object obj in TypeDescriptor.GetAttributes(this.PropertyType))
			{
				Attribute value = (Attribute)obj;
				attributes.Add(value);
			}
			BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
			Type baseType = this.componentClass;
			int num = 0;
			while (baseType != null && baseType != typeof(object))
			{
				num++;
				baseType = baseType.BaseType;
			}
			if (num > 0)
			{
				baseType = this.componentClass;
				Attribute[][] array = new Attribute[num][];
				while (baseType != null && baseType != typeof(object))
				{
					MemberInfo memberInfo;
					if (this.IsExtender)
					{
						memberInfo = baseType.GetMethod("Get" + this.Name, bindingAttr, null, new Type[]
						{
							this.receiverType
						}, null);
					}
					else
					{
						memberInfo = baseType.GetProperty(this.Name, bindingAttr, null, this.PropertyType, new Type[0], new ParameterModifier[0]);
					}
					if (memberInfo != null)
					{
						array[--num] = ReflectTypeDescriptionProvider.ReflectGetAttributes(memberInfo);
					}
					baseType = baseType.BaseType;
				}
				foreach (Attribute[] array3 in array)
				{
					if (array3 != null)
					{
						Attribute[] array4 = array3;
						for (int j = 0; j < array4.Length; j++)
						{
							AttributeProviderAttribute attributeProviderAttribute = array4[j] as AttributeProviderAttribute;
							if (attributeProviderAttribute != null)
							{
								Type type = Type.GetType(attributeProviderAttribute.TypeName);
								if (type != null)
								{
									Attribute[] array5 = null;
									if (!string.IsNullOrEmpty(attributeProviderAttribute.PropertyName))
									{
										MemberInfo[] member = type.GetMember(attributeProviderAttribute.PropertyName);
										if (member.Length != 0 && member[0] != null)
										{
											array5 = ReflectTypeDescriptionProvider.ReflectGetAttributes(member[0]);
										}
									}
									else
									{
										array5 = ReflectTypeDescriptionProvider.ReflectGetAttributes(type);
									}
									if (array5 != null)
									{
										foreach (Attribute value2 in array5)
										{
											attributes.Add(value2);
										}
									}
								}
							}
						}
					}
				}
				foreach (Attribute[] array7 in array)
				{
					if (array7 != null)
					{
						foreach (Attribute value3 in array7)
						{
							attributes.Add(value3);
						}
					}
				}
			}
			base.FillAttributes(attributes);
			if (this.SetMethodValue == null)
			{
				attributes.Add(ReadOnlyAttribute.Yes);
			}
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00053F84 File Offset: 0x00052184
		public override object GetValue(object component)
		{
			if (this.IsExtender)
			{
				return null;
			}
			if (component != null)
			{
				component = this.GetInvocationTarget(this.componentClass, component);
				try
				{
					return SecurityUtils.MethodInfoInvoke(this.GetMethodValue, component, null);
				}
				catch (Exception innerException)
				{
					string text = null;
					IComponent component2 = component as IComponent;
					if (component2 != null)
					{
						ISite site = component2.Site;
						if (site != null && site.Name != null)
						{
							text = site.Name;
						}
					}
					if (text == null)
					{
						text = component.GetType().FullName;
					}
					if (innerException is TargetInvocationException)
					{
						innerException = innerException.InnerException;
					}
					string text2 = innerException.Message;
					if (text2 == null)
					{
						text2 = innerException.GetType().Name;
					}
					throw new TargetInvocationException(SR.GetString("Property accessor '{0}' on object '{1}' threw the following exception:'{2}'", new object[]
					{
						this.Name,
						text,
						text2
					}), innerException);
				}
			}
			return null;
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00054060 File Offset: 0x00052260
		protected override void OnValueChanged(object component, EventArgs e)
		{
			if (this.state[ReflectPropertyDescriptor.BitChangedQueried] && this.realChangedEvent == null)
			{
				base.OnValueChanged(component, e);
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00054084 File Offset: 0x00052284
		public override void ResetValue(object component)
		{
			object invocationTarget = this.GetInvocationTarget(this.componentClass, component);
			if (this.DefaultValue != ReflectPropertyDescriptor.noValue)
			{
				this.SetValue(component, this.DefaultValue);
				return;
			}
			if (this.AmbientValue != ReflectPropertyDescriptor.noValue)
			{
				this.SetValue(component, this.AmbientValue);
				return;
			}
			if (this.ResetMethodValue != null)
			{
				ISite site = MemberDescriptor.GetSite(component);
				IComponentChangeService componentChangeService = null;
				object oldValue = null;
				if (site != null)
				{
					componentChangeService = (IComponentChangeService)site.GetService(typeof(IComponentChangeService));
				}
				if (componentChangeService != null)
				{
					oldValue = SecurityUtils.MethodInfoInvoke(this.GetMethodValue, invocationTarget, null);
					try
					{
						componentChangeService.OnComponentChanging(component, this);
					}
					catch (CheckoutException ex)
					{
						if (ex == CheckoutException.Canceled)
						{
							return;
						}
						throw ex;
					}
				}
				if (this.ResetMethodValue != null)
				{
					SecurityUtils.MethodInfoInvoke(this.ResetMethodValue, invocationTarget, null);
					if (componentChangeService != null)
					{
						object newValue = SecurityUtils.MethodInfoInvoke(this.GetMethodValue, invocationTarget, null);
						componentChangeService.OnComponentChanged(component, this, oldValue, newValue);
					}
				}
			}
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00054180 File Offset: 0x00052380
		public override void SetValue(object component, object value)
		{
			if (component != null)
			{
				ISite site = MemberDescriptor.GetSite(component);
				IComponentChangeService componentChangeService = null;
				object obj = null;
				object invocationTarget = this.GetInvocationTarget(this.componentClass, component);
				if (!this.IsReadOnly)
				{
					if (site != null)
					{
						componentChangeService = (IComponentChangeService)site.GetService(typeof(IComponentChangeService));
					}
					if (componentChangeService != null)
					{
						obj = SecurityUtils.MethodInfoInvoke(this.GetMethodValue, invocationTarget, null);
						try
						{
							componentChangeService.OnComponentChanging(component, this);
						}
						catch (CheckoutException ex)
						{
							if (ex == CheckoutException.Canceled)
							{
								return;
							}
							throw ex;
						}
					}
					try
					{
						SecurityUtils.MethodInfoInvoke(this.SetMethodValue, invocationTarget, new object[]
						{
							value
						});
						this.OnValueChanged(invocationTarget, EventArgs.Empty);
					}
					catch (Exception ex2)
					{
						value = obj;
						if (ex2 is TargetInvocationException && ex2.InnerException != null)
						{
							throw ex2.InnerException;
						}
						throw ex2;
					}
					finally
					{
						if (componentChangeService != null)
						{
							componentChangeService.OnComponentChanged(component, this, obj, value);
						}
					}
				}
			}
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0005427C File Offset: 0x0005247C
		public override bool ShouldSerializeValue(object component)
		{
			component = this.GetInvocationTarget(this.componentClass, component);
			if (this.IsReadOnly)
			{
				if (this.ShouldSerializeMethodValue != null)
				{
					try
					{
						return (bool)this.ShouldSerializeMethodValue.Invoke(component, null);
					}
					catch
					{
					}
				}
				return this.Attributes.Contains(DesignerSerializationVisibilityAttribute.Content);
			}
			if (this.DefaultValue == ReflectPropertyDescriptor.noValue)
			{
				if (this.ShouldSerializeMethodValue != null)
				{
					try
					{
						return (bool)this.ShouldSerializeMethodValue.Invoke(component, null);
					}
					catch
					{
					}
				}
				return true;
			}
			return !object.Equals(this.DefaultValue, this.GetValue(component));
		}

		// Token: 0x04000CB2 RID: 3250
		private static readonly Type[] argsNone = new Type[0];

		// Token: 0x04000CB3 RID: 3251
		private static readonly object noValue = new object();

		// Token: 0x04000CB4 RID: 3252
		private static TraceSwitch PropDescCreateSwitch = new TraceSwitch("PropDescCreate", "ReflectPropertyDescriptor: Dump errors when creating property info");

		// Token: 0x04000CB5 RID: 3253
		private static TraceSwitch PropDescUsageSwitch = new TraceSwitch("PropDescUsage", "ReflectPropertyDescriptor: Debug propertydescriptor usage");

		// Token: 0x04000CB6 RID: 3254
		private static readonly int BitDefaultValueQueried = BitVector32.CreateMask();

		// Token: 0x04000CB7 RID: 3255
		private static readonly int BitGetQueried = BitVector32.CreateMask(ReflectPropertyDescriptor.BitDefaultValueQueried);

		// Token: 0x04000CB8 RID: 3256
		private static readonly int BitSetQueried = BitVector32.CreateMask(ReflectPropertyDescriptor.BitGetQueried);

		// Token: 0x04000CB9 RID: 3257
		private static readonly int BitShouldSerializeQueried = BitVector32.CreateMask(ReflectPropertyDescriptor.BitSetQueried);

		// Token: 0x04000CBA RID: 3258
		private static readonly int BitResetQueried = BitVector32.CreateMask(ReflectPropertyDescriptor.BitShouldSerializeQueried);

		// Token: 0x04000CBB RID: 3259
		private static readonly int BitChangedQueried = BitVector32.CreateMask(ReflectPropertyDescriptor.BitResetQueried);

		// Token: 0x04000CBC RID: 3260
		private static readonly int BitIPropChangedQueried = BitVector32.CreateMask(ReflectPropertyDescriptor.BitChangedQueried);

		// Token: 0x04000CBD RID: 3261
		private static readonly int BitReadOnlyChecked = BitVector32.CreateMask(ReflectPropertyDescriptor.BitIPropChangedQueried);

		// Token: 0x04000CBE RID: 3262
		private static readonly int BitAmbientValueQueried = BitVector32.CreateMask(ReflectPropertyDescriptor.BitReadOnlyChecked);

		// Token: 0x04000CBF RID: 3263
		private static readonly int BitSetOnDemand = BitVector32.CreateMask(ReflectPropertyDescriptor.BitAmbientValueQueried);

		// Token: 0x04000CC0 RID: 3264
		private BitVector32 state;

		// Token: 0x04000CC1 RID: 3265
		private Type componentClass;

		// Token: 0x04000CC2 RID: 3266
		private Type type;

		// Token: 0x04000CC3 RID: 3267
		private object defaultValue;

		// Token: 0x04000CC4 RID: 3268
		private object ambientValue;

		// Token: 0x04000CC5 RID: 3269
		private PropertyInfo propInfo;

		// Token: 0x04000CC6 RID: 3270
		private MethodInfo getMethod;

		// Token: 0x04000CC7 RID: 3271
		private MethodInfo setMethod;

		// Token: 0x04000CC8 RID: 3272
		private MethodInfo shouldSerializeMethod;

		// Token: 0x04000CC9 RID: 3273
		private MethodInfo resetMethod;

		// Token: 0x04000CCA RID: 3274
		private EventDescriptor realChangedEvent;

		// Token: 0x04000CCB RID: 3275
		private Type receiverType;
	}
}
