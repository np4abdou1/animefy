using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SQLite
{
	// Token: 0x02000020 RID: 32
	public class TableMapping
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000044CE File Offset: 0x000026CE
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x000044D6 File Offset: 0x000026D6
		public Type MappedType { get; private set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000044DF File Offset: 0x000026DF
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000044E7 File Offset: 0x000026E7
		public string TableName { get; private set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000044F0 File Offset: 0x000026F0
		// (set) Token: 0x060000CB RID: 203 RVA: 0x000044F8 File Offset: 0x000026F8
		public bool WithoutRowId { get; private set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00004501 File Offset: 0x00002701
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00004509 File Offset: 0x00002709
		public TableMapping.Column[] Columns { get; private set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00004512 File Offset: 0x00002712
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000451A File Offset: 0x0000271A
		public TableMapping.Column PK { get; private set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00004523 File Offset: 0x00002723
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x0000452B File Offset: 0x0000272B
		public string GetByPrimaryKeySql { get; private set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00004534 File Offset: 0x00002734
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000453C File Offset: 0x0000273C
		public CreateFlags CreateFlags { get; private set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00004545 File Offset: 0x00002745
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000454D File Offset: 0x0000274D
		internal TableMapping.MapMethod Method { get; private set; }

		// Token: 0x060000D6 RID: 214 RVA: 0x00004558 File Offset: 0x00002758
		public TableMapping(Type type, CreateFlags createFlags = CreateFlags.None)
		{
			this.MappedType = type;
			this.CreateFlags = createFlags;
			TableAttribute tableAttribute = (from x in type.GetTypeInfo().CustomAttributes
			where x.AttributeType == typeof(TableAttribute)
			select (TableAttribute)Orm.InflateAttribute(x)).FirstOrDefault<TableAttribute>();
			this.TableName = ((tableAttribute != null && !string.IsNullOrEmpty(tableAttribute.Name)) ? tableAttribute.Name : this.MappedType.Name);
			this.WithoutRowId = (tableAttribute != null && tableAttribute.WithoutRowId);
			IReadOnlyCollection<MemberInfo> publicMembers = this.GetPublicMembers(type);
			List<TableMapping.Column> list = new List<TableMapping.Column>(publicMembers.Count);
			foreach (MemberInfo memberInfo in publicMembers)
			{
				if (!memberInfo.IsDefined(typeof(IgnoreAttribute), true))
				{
					list.Add(new TableMapping.Column(memberInfo, createFlags));
				}
			}
			this.Columns = list.ToArray();
			foreach (TableMapping.Column column in this.Columns)
			{
				if (column.IsAutoInc && column.IsPK)
				{
					this._autoPk = column;
				}
				if (column.IsPK)
				{
					this.PK = column;
				}
			}
			this.HasAutoIncPK = (this._autoPk != null);
			if (this.PK != null)
			{
				this.GetByPrimaryKeySql = string.Format("select * from \"{0}\" where \"{1}\" = ?", this.TableName, this.PK.Name);
			}
			else
			{
				this.GetByPrimaryKeySql = string.Format("select * from \"{0}\" limit 1", this.TableName);
			}
			this._insertColumns = (from c in this.Columns
			where !c.IsAutoInc
			select c).ToArray<TableMapping.Column>();
			this._insertOrReplaceColumns = this.Columns.ToArray<TableMapping.Column>();
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00004764 File Offset: 0x00002964
		private IReadOnlyCollection<MemberInfo> GetPublicMembers(Type type)
		{
			if (type.Name.StartsWith("ValueTuple`"))
			{
				return this.GetFieldsFromValueTuple(type);
			}
			List<MemberInfo> list = new List<MemberInfo>();
			HashSet<string> memberNames = new HashSet<string>();
			List<MemberInfo> list2 = new List<MemberInfo>();
			Func<PropertyInfo, bool> <>9__0;
			do
			{
				TypeInfo typeInfo = type.GetTypeInfo();
				list2.Clear();
				List<MemberInfo> list3 = list2;
				IEnumerable<PropertyInfo> declaredProperties = typeInfo.DeclaredProperties;
				Func<PropertyInfo, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((PropertyInfo p) => !memberNames.Contains(p.Name) && p.CanRead && p.CanWrite && p.GetMethod != null && p.SetMethod != null && p.GetMethod.IsPublic && p.SetMethod.IsPublic && !p.GetMethod.IsStatic && !p.SetMethod.IsStatic));
				}
				list3.AddRange(declaredProperties.Where(predicate));
				list.AddRange(list2);
				foreach (MemberInfo memberInfo in list2)
				{
					memberNames.Add(memberInfo.Name);
				}
				type = typeInfo.BaseType;
			}
			while (type != typeof(object));
			return list;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000485C File Offset: 0x00002A5C
		private IReadOnlyCollection<MemberInfo> GetFieldsFromValueTuple(Type type)
		{
			this.Method = TableMapping.MapMethod.ByPosition;
			FieldInfo[] fields = type.GetFields();
			if (fields.Length >= 8)
			{
				throw new NotSupportedException("ValueTuple with more than 7 members not supported due to nesting; see https://docs.microsoft.com/en-us/dotnet/api/system.valuetuple-8.rest");
			}
			return fields;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000487C File Offset: 0x00002A7C
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00004884 File Offset: 0x00002A84
		public bool HasAutoIncPK { get; private set; }

		// Token: 0x060000DB RID: 219 RVA: 0x0000488D File Offset: 0x00002A8D
		public void SetAutoIncPK(object obj, long id)
		{
			if (this._autoPk != null)
			{
				this._autoPk.SetValue(obj, Convert.ChangeType(id, this._autoPk.ColumnType, null));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000048BA File Offset: 0x00002ABA
		public TableMapping.Column[] InsertColumns
		{
			get
			{
				return this._insertColumns;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000DD RID: 221 RVA: 0x000048C2 File Offset: 0x00002AC2
		public TableMapping.Column[] InsertOrReplaceColumns
		{
			get
			{
				return this._insertOrReplaceColumns;
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000048CC File Offset: 0x00002ACC
		public TableMapping.Column FindColumnWithPropertyName(string propertyName)
		{
			return this.Columns.FirstOrDefault((TableMapping.Column c) => c.PropertyName == propertyName);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00004900 File Offset: 0x00002B00
		public TableMapping.Column FindColumn(string columnName)
		{
			if (this.Method != TableMapping.MapMethod.ByName)
			{
				throw new InvalidOperationException(string.Format("This {0} is not mapped by name, but {1}.", "TableMapping", this.Method));
			}
			return this.Columns.FirstOrDefault((TableMapping.Column c) => c.Name.ToLower() == columnName.ToLower());
		}

		// Token: 0x04000071 RID: 113
		private readonly TableMapping.Column _autoPk;

		// Token: 0x04000072 RID: 114
		private readonly TableMapping.Column[] _insertColumns;

		// Token: 0x04000073 RID: 115
		private readonly TableMapping.Column[] _insertOrReplaceColumns;

		// Token: 0x02000021 RID: 33
		public class Column
		{
			// Token: 0x17000033 RID: 51
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x00004959 File Offset: 0x00002B59
			// (set) Token: 0x060000E1 RID: 225 RVA: 0x00004961 File Offset: 0x00002B61
			public string Name { get; private set; }

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000496A File Offset: 0x00002B6A
			public PropertyInfo PropertyInfo
			{
				get
				{
					return this._member as PropertyInfo;
				}
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x060000E3 RID: 227 RVA: 0x00004977 File Offset: 0x00002B77
			public string PropertyName
			{
				get
				{
					return this._member.Name;
				}
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x060000E4 RID: 228 RVA: 0x00004984 File Offset: 0x00002B84
			// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000498C File Offset: 0x00002B8C
			public Type ColumnType { get; private set; }

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x060000E6 RID: 230 RVA: 0x00004995 File Offset: 0x00002B95
			// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000499D File Offset: 0x00002B9D
			public string Collation { get; private set; }

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x060000E8 RID: 232 RVA: 0x000049A6 File Offset: 0x00002BA6
			// (set) Token: 0x060000E9 RID: 233 RVA: 0x000049AE File Offset: 0x00002BAE
			public bool IsAutoInc { get; private set; }

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x060000EA RID: 234 RVA: 0x000049B7 File Offset: 0x00002BB7
			// (set) Token: 0x060000EB RID: 235 RVA: 0x000049BF File Offset: 0x00002BBF
			public bool IsAutoGuid { get; private set; }

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x060000EC RID: 236 RVA: 0x000049C8 File Offset: 0x00002BC8
			// (set) Token: 0x060000ED RID: 237 RVA: 0x000049D0 File Offset: 0x00002BD0
			public bool IsPK { get; private set; }

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x060000EE RID: 238 RVA: 0x000049D9 File Offset: 0x00002BD9
			// (set) Token: 0x060000EF RID: 239 RVA: 0x000049E1 File Offset: 0x00002BE1
			public IEnumerable<IndexedAttribute> Indices { get; set; }

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x060000F0 RID: 240 RVA: 0x000049EA File Offset: 0x00002BEA
			// (set) Token: 0x060000F1 RID: 241 RVA: 0x000049F2 File Offset: 0x00002BF2
			public bool IsNullable { get; private set; }

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x060000F2 RID: 242 RVA: 0x000049FB File Offset: 0x00002BFB
			// (set) Token: 0x060000F3 RID: 243 RVA: 0x00004A03 File Offset: 0x00002C03
			public int? MaxStringLength { get; private set; }

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x060000F4 RID: 244 RVA: 0x00004A0C File Offset: 0x00002C0C
			// (set) Token: 0x060000F5 RID: 245 RVA: 0x00004A14 File Offset: 0x00002C14
			public bool StoreAsText { get; private set; }

			// Token: 0x060000F6 RID: 246 RVA: 0x00004A20 File Offset: 0x00002C20
			public Column(MemberInfo member, CreateFlags createFlags = CreateFlags.None)
			{
				this._member = member;
				Type memberType = TableMapping.Column.GetMemberType(member);
				CustomAttributeData customAttributeData = member.CustomAttributes.FirstOrDefault((CustomAttributeData x) => x.AttributeType == typeof(ColumnAttribute));
				string name;
				if (customAttributeData == null || customAttributeData.ConstructorArguments.Count <= 0)
				{
					name = member.Name;
				}
				else
				{
					object value = customAttributeData.ConstructorArguments[0].Value;
					name = ((value != null) ? value.ToString() : null);
				}
				this.Name = name;
				this.ColumnType = (Nullable.GetUnderlyingType(memberType) ?? memberType);
				this.Collation = Orm.Collation(member);
				this.IsPK = (Orm.IsPK(member) || ((createFlags & CreateFlags.ImplicitPK) == CreateFlags.ImplicitPK && string.Compare(member.Name, "Id", StringComparison.OrdinalIgnoreCase) == 0));
				bool flag = Orm.IsAutoInc(member) || (this.IsPK && (createFlags & CreateFlags.AutoIncPK) == CreateFlags.AutoIncPK);
				this.IsAutoGuid = (flag && this.ColumnType == typeof(Guid));
				this.IsAutoInc = (flag && !this.IsAutoGuid);
				this.Indices = Orm.GetIndices(member);
				if (!this.Indices.Any<IndexedAttribute>() && !this.IsPK && (createFlags & CreateFlags.ImplicitIndex) == CreateFlags.ImplicitIndex && this.Name.EndsWith("Id", StringComparison.OrdinalIgnoreCase))
				{
					this.Indices = new IndexedAttribute[]
					{
						new IndexedAttribute()
					};
				}
				this.IsNullable = (!this.IsPK && !Orm.IsMarkedNotNull(member));
				this.MaxStringLength = Orm.MaxStringLength(member);
				this.StoreAsText = memberType.GetTypeInfo().CustomAttributes.Any((CustomAttributeData x) => x.AttributeType == typeof(StoreAsTextAttribute));
			}

			// Token: 0x060000F7 RID: 247 RVA: 0x00004BF2 File Offset: 0x00002DF2
			public Column(PropertyInfo member, CreateFlags createFlags = CreateFlags.None) : this(member, createFlags)
			{
			}

			// Token: 0x060000F8 RID: 248 RVA: 0x00004BFC File Offset: 0x00002DFC
			public void SetValue(object obj, object val)
			{
				PropertyInfo propertyInfo = this._member as PropertyInfo;
				if (propertyInfo != null)
				{
					if (val != null && this.ColumnType.GetTypeInfo().IsEnum)
					{
						propertyInfo.SetValue(obj, Enum.ToObject(this.ColumnType, val));
						return;
					}
					propertyInfo.SetValue(obj, val);
					return;
				}
				else
				{
					FieldInfo fieldInfo = this._member as FieldInfo;
					if (fieldInfo == null)
					{
						throw new InvalidProgramException("unreachable condition");
					}
					if (val != null && this.ColumnType.GetTypeInfo().IsEnum)
					{
						fieldInfo.SetValue(obj, Enum.ToObject(this.ColumnType, val));
						return;
					}
					fieldInfo.SetValue(obj, val);
					return;
				}
			}

			// Token: 0x060000F9 RID: 249 RVA: 0x00004C98 File Offset: 0x00002E98
			public object GetValue(object obj)
			{
				PropertyInfo propertyInfo = this._member as PropertyInfo;
				if (propertyInfo != null)
				{
					return propertyInfo.GetValue(obj);
				}
				FieldInfo fieldInfo = this._member as FieldInfo;
				if (fieldInfo != null)
				{
					return fieldInfo.GetValue(obj);
				}
				throw new InvalidProgramException("unreachable condition");
			}

			// Token: 0x060000FA RID: 250 RVA: 0x00004CE0 File Offset: 0x00002EE0
			private static Type GetMemberType(MemberInfo m)
			{
				MemberTypes memberType = m.MemberType;
				if (memberType == MemberTypes.Field)
				{
					return ((FieldInfo)m).FieldType;
				}
				if (memberType == MemberTypes.Property)
				{
					return ((PropertyInfo)m).PropertyType;
				}
				throw new InvalidProgramException("TableMapping supports properties or fields only.");
			}

			// Token: 0x04000075 RID: 117
			private MemberInfo _member;
		}

		// Token: 0x02000023 RID: 35
		internal enum MapMethod
		{
			// Token: 0x04000084 RID: 132
			ByName,
			// Token: 0x04000085 RID: 133
			ByPosition
		}
	}
}
