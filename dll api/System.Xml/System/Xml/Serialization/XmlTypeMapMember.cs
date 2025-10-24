using System;
using System.Reflection;

namespace System.Xml.Serialization
{
	// Token: 0x0200020F RID: 527
	internal class XmlTypeMapMember
	{
		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x0006DA8D File Offset: 0x0006BC8D
		// (set) Token: 0x06001179 RID: 4473 RVA: 0x0006DA95 File Offset: 0x0006BC95
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x0006DA9E File Offset: 0x0006BC9E
		// (set) Token: 0x0600117B RID: 4475 RVA: 0x0006DAA6 File Offset: 0x0006BCA6
		public object DefaultValue
		{
			get
			{
				return this._defaultValue;
			}
			set
			{
				this._defaultValue = value;
			}
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0006DAAF File Offset: 0x0006BCAF
		public bool IsReadOnly(Type type)
		{
			if (this._member == null)
			{
				this.InitMember(type);
			}
			return this._member is PropertyInfo && !((PropertyInfo)this._member).CanWrite;
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x0006DAE8 File Offset: 0x0006BCE8
		public static object GetValue(object ob, string name)
		{
			MemberInfo[] member = ob.GetType().GetMember(name, BindingFlags.Instance | BindingFlags.Public);
			if (member[0] is PropertyInfo)
			{
				return ((PropertyInfo)member[0]).GetValue(ob, null);
			}
			return ((FieldInfo)member[0]).GetValue(ob);
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x0006DB2C File Offset: 0x0006BD2C
		public object GetValue(object ob)
		{
			if (this._member == null)
			{
				this.InitMember(ob.GetType());
			}
			if (this._member is PropertyInfo)
			{
				return ((PropertyInfo)this._member).GetValue(ob, null);
			}
			return ((FieldInfo)this._member).GetValue(ob);
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0006DB84 File Offset: 0x0006BD84
		public void SetValue(object ob, object value)
		{
			if (this._member == null)
			{
				this.InitMember(ob.GetType());
			}
			this._typeData.ConvertForAssignment(ref value);
			if (this._member is PropertyInfo)
			{
				((PropertyInfo)this._member).SetValue(ob, value, null);
				return;
			}
			((FieldInfo)this._member).SetValue(ob, value);
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x0006DBEC File Offset: 0x0006BDEC
		public static void SetValue(object ob, string name, object value)
		{
			MemberInfo[] member = ob.GetType().GetMember(name, BindingFlags.Instance | BindingFlags.Public);
			if (member[0] is PropertyInfo)
			{
				((PropertyInfo)member[0]).SetValue(ob, value, null);
				return;
			}
			((FieldInfo)member[0]).SetValue(ob, value);
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x0006DC34 File Offset: 0x0006BE34
		private void InitMember(Type type)
		{
			MemberInfo[] member = type.GetMember(this._name, BindingFlags.Instance | BindingFlags.Public);
			this._member = member[0];
			member = type.GetMember(this._name + "Specified", BindingFlags.Instance | BindingFlags.Public);
			if (member.Length != 0)
			{
				this._specifiedMember = member[0];
			}
			if (this._specifiedMember is PropertyInfo && !((PropertyInfo)this._specifiedMember).CanRead)
			{
				this._specifiedMember = null;
			}
			MethodInfo method = type.GetMethod("ShouldSerialize" + this._name, BindingFlags.Instance | BindingFlags.Public, null, Type.EmptyTypes, null);
			if (method != null && method.ReturnType == typeof(bool) && !method.IsGenericMethod)
			{
				this._shouldSerialize = method;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x0006DCF4 File Offset: 0x0006BEF4
		// (set) Token: 0x06001183 RID: 4483 RVA: 0x0006DCFC File Offset: 0x0006BEFC
		public TypeData TypeData
		{
			get
			{
				return this._typeData;
			}
			set
			{
				this._typeData = value;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001184 RID: 4484 RVA: 0x0006DD05 File Offset: 0x0006BF05
		// (set) Token: 0x06001185 RID: 4485 RVA: 0x0006DD0D File Offset: 0x0006BF0D
		public int Index
		{
			get
			{
				return this._index;
			}
			set
			{
				this._index = value;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x0006DD16 File Offset: 0x0006BF16
		// (set) Token: 0x06001187 RID: 4487 RVA: 0x0006DD1E File Offset: 0x0006BF1E
		public int GlobalIndex
		{
			get
			{
				return this._globalIndex;
			}
			set
			{
				this._globalIndex = value;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x0006DD27 File Offset: 0x0006BF27
		// (set) Token: 0x06001189 RID: 4489 RVA: 0x0006DD34 File Offset: 0x0006BF34
		public bool IsOptionalValueType
		{
			get
			{
				return (this._flags & 1) != 0;
			}
			set
			{
				this._flags = (value ? (this._flags | 1) : (this._flags & -2));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x0006DD52 File Offset: 0x0006BF52
		// (set) Token: 0x0600118B RID: 4491 RVA: 0x0006DD5F File Offset: 0x0006BF5F
		public bool IsReturnValue
		{
			get
			{
				return (this._flags & 2) != 0;
			}
			set
			{
				this._flags = (value ? (this._flags | 2) : (this._flags & -3));
			}
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0006DD7D File Offset: 0x0006BF7D
		public void CheckOptionalValueType(Type type)
		{
			if (this._member == null)
			{
				this.InitMember(type);
			}
			this.IsOptionalValueType = (this._specifiedMember != null || this._shouldSerialize != null);
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x0006DDB8 File Offset: 0x0006BFB8
		public bool GetValueSpecified(object ob)
		{
			if (this._specifiedGlobalIndex != -1)
			{
				object[] array = (object[])ob;
				return this._specifiedGlobalIndex < array.Length && (bool)array[this._specifiedGlobalIndex];
			}
			bool flag = true;
			if (this._specifiedMember != null)
			{
				if (this._specifiedMember is PropertyInfo)
				{
					flag = (bool)((PropertyInfo)this._specifiedMember).GetValue(ob, null);
				}
				else
				{
					flag = (bool)((FieldInfo)this._specifiedMember).GetValue(ob);
				}
			}
			if (this._shouldSerialize != null)
			{
				flag = (flag && (bool)this._shouldSerialize.Invoke(ob, new object[0]));
			}
			return flag;
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x0006DE6C File Offset: 0x0006C06C
		public void SetValueSpecified(object ob, bool value)
		{
			if (this._specifiedGlobalIndex != -1)
			{
				((object[])ob)[this._specifiedGlobalIndex] = value;
				return;
			}
			if (!(this._specifiedMember is PropertyInfo))
			{
				if (this._specifiedMember is FieldInfo)
				{
					((FieldInfo)this._specifiedMember).SetValue(ob, value);
				}
				return;
			}
			if (!((PropertyInfo)this._specifiedMember).CanWrite)
			{
				return;
			}
			((PropertyInfo)this._specifiedMember).SetValue(ob, value, null);
		}

		// Token: 0x04000BF8 RID: 3064
		private string _name;

		// Token: 0x04000BF9 RID: 3065
		private int _index;

		// Token: 0x04000BFA RID: 3066
		private int _globalIndex = -1;

		// Token: 0x04000BFB RID: 3067
		private int _specifiedGlobalIndex = -1;

		// Token: 0x04000BFC RID: 3068
		private TypeData _typeData;

		// Token: 0x04000BFD RID: 3069
		private MemberInfo _member;

		// Token: 0x04000BFE RID: 3070
		private MemberInfo _specifiedMember;

		// Token: 0x04000BFF RID: 3071
		private MethodInfo _shouldSerialize;

		// Token: 0x04000C00 RID: 3072
		private object _defaultValue = DBNull.Value;

		// Token: 0x04000C01 RID: 3073
		private int _flags;
	}
}
