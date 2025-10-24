using System;
using System.Globalization;
using System.Reflection;
using System.Text;
using SQLitePCL;

namespace SQLite
{
	// Token: 0x02000032 RID: 50
	internal class FastColumnSetter
	{
		// Token: 0x0600015D RID: 349 RVA: 0x00006770 File Offset: 0x00004970
		internal static Action<object, sqlite3_stmt, int> GetFastSetter<T>(SQLiteConnection conn, TableMapping.Column column)
		{
			Action<object, sqlite3_stmt, int> result = null;
			Type type = column.PropertyInfo.PropertyType;
			TypeInfo typeInfo = type.GetTypeInfo();
			if (typeInfo.IsGenericType && typeInfo.GetGenericTypeDefinition() == typeof(Nullable<>))
			{
				type = typeInfo.GenericTypeArguments[0];
				typeInfo = type.GetTypeInfo();
			}
			if (type == typeof(string))
			{
				result = FastColumnSetter.CreateTypedSetterDelegate<T, string>(column, (sqlite3_stmt stmt, int index) => SQLite3.ColumnString(stmt, index));
			}
			else if (type == typeof(int))
			{
				result = FastColumnSetter.CreateNullableTypedSetterDelegate<T, int>(column, (sqlite3_stmt stmt, int index) => SQLite3.ColumnInt(stmt, index));
			}
			else if (type == typeof(bool))
			{
				result = FastColumnSetter.CreateNullableTypedSetterDelegate<T, bool>(column, (sqlite3_stmt stmt, int index) => SQLite3.ColumnInt(stmt, index) == 1);
			}
			else if (type == typeof(double))
			{
				result = FastColumnSetter.CreateNullableTypedSetterDelegate<T, double>(column, (sqlite3_stmt stmt, int index) => SQLite3.ColumnDouble(stmt, index));
			}
			else if (type == typeof(float))
			{
				result = FastColumnSetter.CreateNullableTypedSetterDelegate<T, float>(column, (sqlite3_stmt stmt, int index) => (float)SQLite3.ColumnDouble(stmt, index));
			}
			else if (type == typeof(TimeSpan))
			{
				if (conn.StoreTimeSpanAsTicks)
				{
					result = FastColumnSetter.CreateNullableTypedSetterDelegate<T, TimeSpan>(column, (sqlite3_stmt stmt, int index) => new TimeSpan(SQLite3.ColumnInt64(stmt, index)));
				}
				else
				{
					result = FastColumnSetter.CreateNullableTypedSetterDelegate<T, TimeSpan>(column, delegate(sqlite3_stmt stmt, int index)
					{
						string text = SQLite3.ColumnString(stmt, index);
						TimeSpan result2;
						if (!TimeSpan.TryParseExact(text, "c", CultureInfo.InvariantCulture, TimeSpanStyles.None, out result2))
						{
							result2 = TimeSpan.Parse(text);
						}
						return result2;
					});
				}
			}
			else if (type == typeof(DateTime))
			{
				if (conn.StoreDateTimeAsTicks)
				{
					result = FastColumnSetter.CreateNullableTypedSetterDelegate<T, DateTime>(column, (sqlite3_stmt stmt, int index) => new DateTime(SQLite3.ColumnInt64(stmt, index)));
				}
				else
				{
					result = FastColumnSetter.CreateNullableTypedSetterDelegate<T, DateTime>(column, delegate(sqlite3_stmt stmt, int index)
					{
						string s = SQLite3.ColumnString(stmt, index);
						DateTime result2;
						if (!DateTime.TryParseExact(s, conn.DateTimeStringFormat, CultureInfo.InvariantCulture, conn.DateTimeStyle, out result2))
						{
							result2 = DateTime.Parse(s);
						}
						return result2;
					});
				}
			}
			else if (type == typeof(DateTimeOffset))
			{
				result = FastColumnSetter.CreateNullableTypedSetterDelegate<T, DateTimeOffset>(column, (sqlite3_stmt stmt, int index) => new DateTimeOffset(SQLite3.ColumnInt64(stmt, index), TimeSpan.Zero));
			}
			else if (!typeInfo.IsEnum)
			{
				if (type == typeof(long))
				{
					result = FastColumnSetter.CreateNullableTypedSetterDelegate<T, long>(column, (sqlite3_stmt stmt, int index) => SQLite3.ColumnInt64(stmt, index));
				}
				else if (type == typeof(uint))
				{
					result = FastColumnSetter.CreateNullableTypedSetterDelegate<T, uint>(column, (sqlite3_stmt stmt, int index) => (uint)SQLite3.ColumnInt64(stmt, index));
				}
				else if (type == typeof(decimal))
				{
					result = FastColumnSetter.CreateNullableTypedSetterDelegate<T, decimal>(column, (sqlite3_stmt stmt, int index) => (decimal)SQLite3.ColumnDouble(stmt, index));
				}
				else if (type == typeof(byte))
				{
					result = FastColumnSetter.CreateNullableTypedSetterDelegate<T, byte>(column, (sqlite3_stmt stmt, int index) => (byte)SQLite3.ColumnInt(stmt, index));
				}
				else if (type == typeof(ushort))
				{
					result = FastColumnSetter.CreateNullableTypedSetterDelegate<T, ushort>(column, (sqlite3_stmt stmt, int index) => (ushort)SQLite3.ColumnInt(stmt, index));
				}
				else if (type == typeof(short))
				{
					result = FastColumnSetter.CreateNullableTypedSetterDelegate<T, short>(column, (sqlite3_stmt stmt, int index) => (short)SQLite3.ColumnInt(stmt, index));
				}
				else if (type == typeof(sbyte))
				{
					result = FastColumnSetter.CreateNullableTypedSetterDelegate<T, sbyte>(column, (sqlite3_stmt stmt, int index) => (sbyte)SQLite3.ColumnInt(stmt, index));
				}
				else if (type == typeof(byte[]))
				{
					result = FastColumnSetter.CreateTypedSetterDelegate<T, byte[]>(column, (sqlite3_stmt stmt, int index) => SQLite3.ColumnByteArray(stmt, index));
				}
				else if (type == typeof(Guid))
				{
					result = FastColumnSetter.CreateNullableTypedSetterDelegate<T, Guid>(column, (sqlite3_stmt stmt, int index) => new Guid(SQLite3.ColumnString(stmt, index)));
				}
				else if (type == typeof(Uri))
				{
					result = FastColumnSetter.CreateTypedSetterDelegate<T, Uri>(column, (sqlite3_stmt stmt, int index) => new Uri(SQLite3.ColumnString(stmt, index)));
				}
				else if (type == typeof(StringBuilder))
				{
					result = FastColumnSetter.CreateTypedSetterDelegate<T, StringBuilder>(column, (sqlite3_stmt stmt, int index) => new StringBuilder(SQLite3.ColumnString(stmt, index)));
				}
				else if (type == typeof(UriBuilder))
				{
					result = FastColumnSetter.CreateTypedSetterDelegate<T, UriBuilder>(column, (sqlite3_stmt stmt, int index) => new UriBuilder(SQLite3.ColumnString(stmt, index)));
				}
			}
			return result;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00006CF0 File Offset: 0x00004EF0
		private static Action<object, sqlite3_stmt, int> CreateNullableTypedSetterDelegate<ObjectType, ColumnMemberType>(TableMapping.Column column, Func<sqlite3_stmt, int, ColumnMemberType> getColumnValue) where ColumnMemberType : struct
		{
			TypeInfo typeInfo = column.PropertyInfo.PropertyType.GetTypeInfo();
			bool flag = false;
			if (typeInfo.IsGenericType && typeInfo.GetGenericTypeDefinition() == typeof(Nullable<>))
			{
				flag = true;
			}
			if (flag)
			{
				Action<ObjectType, ColumnMemberType?> setProperty = (Action<ObjectType, ColumnMemberType?>)Delegate.CreateDelegate(typeof(Action<ObjectType, ColumnMemberType?>), null, column.PropertyInfo.GetSetMethod());
				return delegate(object o, sqlite3_stmt stmt, int i)
				{
					if (SQLite3.ColumnType(stmt, i) != SQLite3.ColType.Null)
					{
						setProperty((ObjectType)((object)o), new ColumnMemberType?(getColumnValue(stmt, i)));
					}
				};
			}
			return FastColumnSetter.CreateTypedSetterDelegate<ObjectType, ColumnMemberType>(column, getColumnValue);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00006D80 File Offset: 0x00004F80
		private static Action<object, sqlite3_stmt, int> CreateTypedSetterDelegate<ObjectType, ColumnMemberType>(TableMapping.Column column, Func<sqlite3_stmt, int, ColumnMemberType> getColumnValue)
		{
			Action<ObjectType, ColumnMemberType> setProperty = (Action<ObjectType, ColumnMemberType>)Delegate.CreateDelegate(typeof(Action<ObjectType, ColumnMemberType>), null, column.PropertyInfo.GetSetMethod());
			return delegate(object o, sqlite3_stmt stmt, int i)
			{
				if (SQLite3.ColumnType(stmt, i) != SQLite3.ColType.Null)
				{
					setProperty((ObjectType)((object)o), getColumnValue(stmt, i));
				}
			};
		}
	}
}
