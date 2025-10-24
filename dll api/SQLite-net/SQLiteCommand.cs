using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using SQLitePCL;

namespace SQLite
{
	// Token: 0x0200002E RID: 46
	public class SQLiteCommand
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000056CB File Offset: 0x000038CB
		// (set) Token: 0x06000131 RID: 305 RVA: 0x000056D3 File Offset: 0x000038D3
		public string CommandText { get; set; }

		// Token: 0x06000132 RID: 306 RVA: 0x000056DC File Offset: 0x000038DC
		public SQLiteCommand(SQLiteConnection conn)
		{
			this._conn = conn;
			this._bindings = new List<SQLiteCommand.Binding>();
			this.CommandText = "";
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00005704 File Offset: 0x00003904
		public int ExecuteNonQuery()
		{
			if (this._conn.Trace)
			{
				Action<string> tracer = this._conn.Tracer;
				if (tracer != null)
				{
					tracer("Executing: " + ((this != null) ? this.ToString() : null));
				}
			}
			sqlite3_stmt stmt = this.Prepare();
			SQLite3.Result result = SQLite3.Step(stmt);
			this.Finalize(stmt);
			if (result == SQLite3.Result.Done)
			{
				return SQLite3.Changes(this._conn.Handle);
			}
			if (result == SQLite3.Result.Error)
			{
				string errmsg = SQLite3.GetErrmsg(this._conn.Handle);
				throw SQLiteException.New(result, errmsg);
			}
			if (result == SQLite3.Result.Constraint && SQLite3.ExtendedErrCode(this._conn.Handle) == SQLite3.ExtendedResult.ConstraintNotNull)
			{
				throw NotNullConstraintViolationException.New(result, SQLite3.GetErrmsg(this._conn.Handle));
			}
			throw SQLiteException.New(result, SQLite3.GetErrmsg(this._conn.Handle));
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000057DE File Offset: 0x000039DE
		public IEnumerable<T> ExecuteDeferredQuery<T>()
		{
			return this.ExecuteDeferredQuery<T>(this._conn.GetMapping(typeof(T), CreateFlags.None));
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000057FC File Offset: 0x000039FC
		public List<T> ExecuteQuery<T>()
		{
			return this.ExecuteDeferredQuery<T>(this._conn.GetMapping(typeof(T), CreateFlags.None)).ToList<T>();
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000581F File Offset: 0x00003A1F
		public List<T> ExecuteQuery<T>(TableMapping map)
		{
			return this.ExecuteDeferredQuery<T>(map).ToList<T>();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000402B File Offset: 0x0000222B
		protected virtual void OnInstanceCreated(object obj)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000582D File Offset: 0x00003A2D
		public IEnumerable<T> ExecuteDeferredQuery<T>(TableMapping map)
		{
			if (this._conn.Trace)
			{
				Action<string> tracer = this._conn.Tracer;
				if (tracer != null)
				{
					tracer("Executing Query: " + ((this != null) ? this.ToString() : null));
				}
			}
			sqlite3_stmt stmt = this.Prepare();
			try
			{
				TableMapping.Column[] cols = new TableMapping.Column[SQLite3.ColumnCount(stmt)];
				Action<object, sqlite3_stmt, int>[] fastColumnSetters = new Action<object, sqlite3_stmt, int>[SQLite3.ColumnCount(stmt)];
				if (map.Method == TableMapping.MapMethod.ByPosition)
				{
					Array.Copy(map.Columns, cols, Math.Min(cols.Length, map.Columns.Length));
				}
				else if (map.Method == TableMapping.MapMethod.ByName)
				{
					MethodInfo methodInfo = null;
					if (typeof(T) != map.MappedType)
					{
						methodInfo = typeof(FastColumnSetter).GetMethod("GetFastSetter", BindingFlags.Static | BindingFlags.NonPublic).MakeGenericMethod(new Type[]
						{
							map.MappedType
						});
					}
					for (int i = 0; i < cols.Length; i++)
					{
						string columnName = SQLite3.ColumnName16(stmt, i);
						cols[i] = map.FindColumn(columnName);
						if (cols[i] != null)
						{
							if (methodInfo != null)
							{
								fastColumnSetters[i] = (Action<object, sqlite3_stmt, int>)methodInfo.Invoke(null, new object[]
								{
									this._conn,
									cols[i]
								});
							}
							else
							{
								fastColumnSetters[i] = FastColumnSetter.GetFastSetter<T>(this._conn, cols[i]);
							}
						}
					}
				}
				while (SQLite3.Step(stmt) == SQLite3.Result.Row)
				{
					object obj = Activator.CreateInstance(map.MappedType);
					for (int j = 0; j < cols.Length; j++)
					{
						if (cols[j] != null)
						{
							if (fastColumnSetters[j] != null)
							{
								fastColumnSetters[j](obj, stmt, j);
							}
							else
							{
								SQLite3.ColType type = SQLite3.ColumnType(stmt, j);
								object val = this.ReadCol(stmt, j, type, cols[j].ColumnType);
								cols[j].SetValue(obj, val);
							}
						}
					}
					this.OnInstanceCreated(obj);
					yield return (T)((object)obj);
				}
				cols = null;
				fastColumnSetters = null;
			}
			finally
			{
				SQLite3.Finalize(stmt);
			}
			yield break;
			yield break;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00005844 File Offset: 0x00003A44
		public T ExecuteScalar<T>()
		{
			if (this._conn.Trace)
			{
				Action<string> tracer = this._conn.Tracer;
				if (tracer != null)
				{
					tracer("Executing Query: " + ((this != null) ? this.ToString() : null));
				}
			}
			T result = default(T);
			sqlite3_stmt stmt = this.Prepare();
			try
			{
				SQLite3.Result result2 = SQLite3.Step(stmt);
				if (result2 == SQLite3.Result.Row)
				{
					SQLite3.ColType type = SQLite3.ColumnType(stmt, 0);
					object obj = this.ReadCol(stmt, 0, type, typeof(T));
					if (obj != null)
					{
						result = (T)((object)obj);
					}
				}
				else if (result2 != SQLite3.Result.Done)
				{
					throw SQLiteException.New(result2, SQLite3.GetErrmsg(this._conn.Handle));
				}
			}
			finally
			{
				this.Finalize(stmt);
			}
			return result;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000590C File Offset: 0x00003B0C
		public IEnumerable<T> ExecuteQueryScalars<T>()
		{
			if (this._conn.Trace)
			{
				Action<string> tracer = this._conn.Tracer;
				if (tracer != null)
				{
					tracer("Executing Query: " + ((this != null) ? this.ToString() : null));
				}
			}
			sqlite3_stmt stmt = this.Prepare();
			try
			{
				if (SQLite3.ColumnCount(stmt) < 1)
				{
					throw new InvalidOperationException("QueryScalars should return at least one column");
				}
				while (SQLite3.Step(stmt) == SQLite3.Result.Row)
				{
					SQLite3.ColType type = SQLite3.ColumnType(stmt, 0);
					object obj = this.ReadCol(stmt, 0, type, typeof(T));
					if (obj == null)
					{
						T t = default(T);
					}
					else
					{
						yield return (T)((object)obj);
					}
				}
			}
			finally
			{
				this.Finalize(stmt);
			}
			yield break;
			yield break;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000591C File Offset: 0x00003B1C
		public void Bind(string name, object val)
		{
			this._bindings.Add(new SQLiteCommand.Binding
			{
				Name = name,
				Value = val
			});
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000593C File Offset: 0x00003B3C
		public void Bind(object val)
		{
			this.Bind(null, val);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00005948 File Offset: 0x00003B48
		public override string ToString()
		{
			string[] array = new string[1 + this._bindings.Count];
			array[0] = this.CommandText;
			int num = 1;
			foreach (SQLiteCommand.Binding binding in this._bindings)
			{
				array[num] = string.Format("  {0}: {1}", num - 1, binding.Value);
				num++;
			}
			return string.Join(Environment.NewLine, array);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000059DC File Offset: 0x00003BDC
		private sqlite3_stmt Prepare()
		{
			sqlite3_stmt sqlite3_stmt = SQLite3.Prepare2(this._conn.Handle, this.CommandText);
			this.BindAll(sqlite3_stmt);
			return sqlite3_stmt;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00005A08 File Offset: 0x00003C08
		private void Finalize(sqlite3_stmt stmt)
		{
			SQLite3.Finalize(stmt);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00005A14 File Offset: 0x00003C14
		private void BindAll(sqlite3_stmt stmt)
		{
			int num = 1;
			foreach (SQLiteCommand.Binding binding in this._bindings)
			{
				if (binding.Name != null)
				{
					binding.Index = SQLite3.BindParameterIndex(stmt, binding.Name);
				}
				else
				{
					binding.Index = num++;
				}
				SQLiteCommand.BindParameter(stmt, binding.Index, binding.Value, this._conn.StoreDateTimeAsTicks, this._conn.DateTimeStringFormat, this._conn.StoreTimeSpanAsTicks);
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00005ABC File Offset: 0x00003CBC
		internal static void BindParameter(sqlite3_stmt stmt, int index, object value, bool storeDateTimeAsTicks, string dateTimeStringFormat, bool storeTimeSpanAsTicks)
		{
			if (value == null)
			{
				SQLite3.BindNull(stmt, index);
				return;
			}
			if (value is int)
			{
				SQLite3.BindInt(stmt, index, (int)value);
				return;
			}
			if (value is string)
			{
				SQLite3.BindText(stmt, index, (string)value, -1, SQLiteCommand.NegativePointer);
				return;
			}
			if (value is byte || value is ushort || value is sbyte || value is short)
			{
				SQLite3.BindInt(stmt, index, Convert.ToInt32(value));
				return;
			}
			if (value is bool)
			{
				SQLite3.BindInt(stmt, index, ((bool)value) ? 1 : 0);
				return;
			}
			if (value is uint || value is long)
			{
				SQLite3.BindInt64(stmt, index, Convert.ToInt64(value));
				return;
			}
			if (value is float || value is double || value is decimal)
			{
				SQLite3.BindDouble(stmt, index, Convert.ToDouble(value));
				return;
			}
			if (value is TimeSpan)
			{
				if (storeTimeSpanAsTicks)
				{
					SQLite3.BindInt64(stmt, index, ((TimeSpan)value).Ticks);
					return;
				}
				SQLite3.BindText(stmt, index, ((TimeSpan)value).ToString(), -1, SQLiteCommand.NegativePointer);
				return;
			}
			else if (value is DateTime)
			{
				if (storeDateTimeAsTicks)
				{
					SQLite3.BindInt64(stmt, index, ((DateTime)value).Ticks);
					return;
				}
				SQLite3.BindText(stmt, index, ((DateTime)value).ToString(dateTimeStringFormat, CultureInfo.InvariantCulture), -1, SQLiteCommand.NegativePointer);
				return;
			}
			else
			{
				if (value is DateTimeOffset)
				{
					SQLite3.BindInt64(stmt, index, ((DateTimeOffset)value).UtcTicks);
					return;
				}
				if (value is byte[])
				{
					SQLite3.BindBlob(stmt, index, (byte[])value, ((byte[])value).Length, SQLiteCommand.NegativePointer);
					return;
				}
				if (value is Guid)
				{
					SQLite3.BindText(stmt, index, ((Guid)value).ToString(), 72, SQLiteCommand.NegativePointer);
					return;
				}
				if (value is Uri)
				{
					SQLite3.BindText(stmt, index, ((Uri)value).ToString(), -1, SQLiteCommand.NegativePointer);
					return;
				}
				if (value is StringBuilder)
				{
					SQLite3.BindText(stmt, index, ((StringBuilder)value).ToString(), -1, SQLiteCommand.NegativePointer);
					return;
				}
				if (value is UriBuilder)
				{
					SQLite3.BindText(stmt, index, ((UriBuilder)value).ToString(), -1, SQLiteCommand.NegativePointer);
					return;
				}
				EnumCacheInfo info = EnumCache.GetInfo(value.GetType());
				if (!info.IsEnum)
				{
					string str = "Cannot store type: ";
					Type type = Orm.GetType(value);
					throw new NotSupportedException(str + ((type != null) ? type.ToString() : null));
				}
				int num = Convert.ToInt32(value);
				if (info.StoreAsText)
				{
					SQLite3.BindText(stmt, index, info.EnumValues[num], -1, SQLiteCommand.NegativePointer);
					return;
				}
				SQLite3.BindInt(stmt, index, num);
				return;
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00005D6C File Offset: 0x00003F6C
		private object ReadCol(sqlite3_stmt stmt, int index, SQLite3.ColType type, Type clrType)
		{
			if (type == SQLite3.ColType.Null)
			{
				return null;
			}
			TypeInfo typeInfo = clrType.GetTypeInfo();
			if (typeInfo.IsGenericType && typeInfo.GetGenericTypeDefinition() == typeof(Nullable<>))
			{
				clrType = typeInfo.GenericTypeArguments[0];
				typeInfo = clrType.GetTypeInfo();
			}
			if (clrType == typeof(string))
			{
				return SQLite3.ColumnString(stmt, index);
			}
			if (clrType == typeof(int))
			{
				return SQLite3.ColumnInt(stmt, index);
			}
			if (clrType == typeof(bool))
			{
				return SQLite3.ColumnInt(stmt, index) == 1;
			}
			if (clrType == typeof(double))
			{
				return SQLite3.ColumnDouble(stmt, index);
			}
			if (clrType == typeof(float))
			{
				return (float)SQLite3.ColumnDouble(stmt, index);
			}
			if (clrType == typeof(TimeSpan))
			{
				if (this._conn.StoreTimeSpanAsTicks)
				{
					return new TimeSpan(SQLite3.ColumnInt64(stmt, index));
				}
				string text = SQLite3.ColumnString(stmt, index);
				TimeSpan timeSpan;
				if (!TimeSpan.TryParseExact(text, "c", CultureInfo.InvariantCulture, TimeSpanStyles.None, out timeSpan))
				{
					timeSpan = TimeSpan.Parse(text);
				}
				return timeSpan;
			}
			else if (clrType == typeof(DateTime))
			{
				if (this._conn.StoreDateTimeAsTicks)
				{
					return new DateTime(SQLite3.ColumnInt64(stmt, index));
				}
				string s = SQLite3.ColumnString(stmt, index);
				DateTime dateTime;
				if (!DateTime.TryParseExact(s, this._conn.DateTimeStringFormat, CultureInfo.InvariantCulture, this._conn.DateTimeStyle, out dateTime))
				{
					dateTime = DateTime.Parse(s);
				}
				return dateTime;
			}
			else
			{
				if (clrType == typeof(DateTimeOffset))
				{
					return new DateTimeOffset(SQLite3.ColumnInt64(stmt, index), TimeSpan.Zero);
				}
				if (typeInfo.IsEnum)
				{
					if (type == SQLite3.ColType.Text)
					{
						string text2 = SQLite3.ColumnString(stmt, index);
						return Enum.Parse(clrType, text2.ToString(), true);
					}
					return SQLite3.ColumnInt(stmt, index);
				}
				else
				{
					if (clrType == typeof(long))
					{
						return SQLite3.ColumnInt64(stmt, index);
					}
					if (clrType == typeof(uint))
					{
						return (uint)SQLite3.ColumnInt64(stmt, index);
					}
					if (clrType == typeof(decimal))
					{
						return (decimal)SQLite3.ColumnDouble(stmt, index);
					}
					if (clrType == typeof(byte))
					{
						return (byte)SQLite3.ColumnInt(stmt, index);
					}
					if (clrType == typeof(ushort))
					{
						return (ushort)SQLite3.ColumnInt(stmt, index);
					}
					if (clrType == typeof(short))
					{
						return (short)SQLite3.ColumnInt(stmt, index);
					}
					if (clrType == typeof(sbyte))
					{
						return (sbyte)SQLite3.ColumnInt(stmt, index);
					}
					if (clrType == typeof(byte[]))
					{
						return SQLite3.ColumnByteArray(stmt, index);
					}
					if (clrType == typeof(Guid))
					{
						return new Guid(SQLite3.ColumnString(stmt, index));
					}
					if (clrType == typeof(Uri))
					{
						return new Uri(SQLite3.ColumnString(stmt, index));
					}
					if (clrType == typeof(StringBuilder))
					{
						return new StringBuilder(SQLite3.ColumnString(stmt, index));
					}
					if (clrType == typeof(UriBuilder))
					{
						return new UriBuilder(SQLite3.ColumnString(stmt, index));
					}
					string str = "Don't know how to read ";
					Type type2 = clrType;
					throw new NotSupportedException(str + ((type2 != null) ? type2.ToString() : null));
				}
			}
		}

		// Token: 0x040000A1 RID: 161
		private SQLiteConnection _conn;

		// Token: 0x040000A2 RID: 162
		private List<SQLiteCommand.Binding> _bindings;

		// Token: 0x040000A4 RID: 164
		private static IntPtr NegativePointer = new IntPtr(-1);

		// Token: 0x0200002F RID: 47
		private class Binding
		{
			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000144 RID: 324 RVA: 0x00006133 File Offset: 0x00004333
			// (set) Token: 0x06000145 RID: 325 RVA: 0x0000613B File Offset: 0x0000433B
			public string Name { get; set; }

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x06000146 RID: 326 RVA: 0x00006144 File Offset: 0x00004344
			// (set) Token: 0x06000147 RID: 327 RVA: 0x0000614C File Offset: 0x0000434C
			public object Value { get; set; }

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x06000148 RID: 328 RVA: 0x00006155 File Offset: 0x00004355
			// (set) Token: 0x06000149 RID: 329 RVA: 0x0000615D File Offset: 0x0000435D
			public int Index { get; set; }
		}
	}
}
