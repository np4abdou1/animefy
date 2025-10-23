using System;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;

namespace System.Data
{
	// Token: 0x02000024 RID: 36
	internal static class ExceptionBuilder
	{
		// Token: 0x0600016D RID: 365 RVA: 0x00007222 File Offset: 0x00005422
		private static void TraceException(string trace, Exception e)
		{
			if (e != null)
			{
				DataCommonEventSource.Log.Trace<Exception>(trace, e);
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00007233 File Offset: 0x00005433
		internal static Exception TraceExceptionAsReturnValue(Exception e)
		{
			ExceptionBuilder.TraceException("<comm.ADP.TraceException|ERR|THROW> '{0}'", e);
			return e;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00007241 File Offset: 0x00005441
		internal static Exception TraceExceptionForCapture(Exception e)
		{
			ExceptionBuilder.TraceException("<comm.ADP.TraceException|ERR|CATCH> '{0}'", e);
			return e;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00007241 File Offset: 0x00005441
		internal static Exception TraceExceptionWithoutRethrow(Exception e)
		{
			ExceptionBuilder.TraceException("<comm.ADP.TraceException|ERR|CATCH> '{0}'", e);
			return e;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000724F File Offset: 0x0000544F
		internal static Exception _Argument(string error)
		{
			return ExceptionBuilder.TraceExceptionAsReturnValue(new ArgumentException(error));
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000725C File Offset: 0x0000545C
		internal static Exception _Argument(string error, Exception innerException)
		{
			return ExceptionBuilder.TraceExceptionAsReturnValue(new ArgumentException(error, innerException));
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000726A File Offset: 0x0000546A
		private static Exception _ArgumentNull(string paramName, string msg)
		{
			return ExceptionBuilder.TraceExceptionAsReturnValue(new ArgumentNullException(paramName, msg));
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00007278 File Offset: 0x00005478
		internal static Exception _ArgumentOutOfRange(string paramName, string msg)
		{
			return ExceptionBuilder.TraceExceptionAsReturnValue(new ArgumentOutOfRangeException(paramName, msg));
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00007286 File Offset: 0x00005486
		private static Exception _IndexOutOfRange(string error)
		{
			return ExceptionBuilder.TraceExceptionAsReturnValue(new IndexOutOfRangeException(error));
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00007293 File Offset: 0x00005493
		private static Exception _InvalidOperation(string error)
		{
			return ExceptionBuilder.TraceExceptionAsReturnValue(new InvalidOperationException(error));
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000072A0 File Offset: 0x000054A0
		private static Exception _InvalidEnumArgumentException(string error)
		{
			return ExceptionBuilder.TraceExceptionAsReturnValue(new InvalidEnumArgumentException(error));
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000072AD File Offset: 0x000054AD
		private static Exception _InvalidEnumArgumentException<T>(T value)
		{
			return ExceptionBuilder._InvalidEnumArgumentException(SR.Format("The {0} enumeration value, {1}, is invalid.", typeof(T).Name, value.ToString()));
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000072DA File Offset: 0x000054DA
		private static void ThrowDataException(string error, Exception innerException)
		{
			throw ExceptionBuilder.TraceExceptionAsReturnValue(new DataException(error, innerException));
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000072E8 File Offset: 0x000054E8
		private static Exception _Data(string error)
		{
			return ExceptionBuilder.TraceExceptionAsReturnValue(new DataException(error));
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000072F5 File Offset: 0x000054F5
		private static Exception _Constraint(string error)
		{
			return ExceptionBuilder.TraceExceptionAsReturnValue(new ConstraintException(error));
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00007302 File Offset: 0x00005502
		private static Exception _InvalidConstraint(string error)
		{
			return ExceptionBuilder.TraceExceptionAsReturnValue(new InvalidConstraintException(error));
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000730F File Offset: 0x0000550F
		private static Exception _DeletedRowInaccessible(string error)
		{
			return ExceptionBuilder.TraceExceptionAsReturnValue(new DeletedRowInaccessibleException(error));
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000731C File Offset: 0x0000551C
		private static Exception _DuplicateName(string error)
		{
			return ExceptionBuilder.TraceExceptionAsReturnValue(new DuplicateNameException(error));
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00007329 File Offset: 0x00005529
		private static Exception _InRowChangingEvent(string error)
		{
			return ExceptionBuilder.TraceExceptionAsReturnValue(new InRowChangingEventException(error));
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00007336 File Offset: 0x00005536
		private static Exception _MissingPrimaryKey(string error)
		{
			return ExceptionBuilder.TraceExceptionAsReturnValue(new MissingPrimaryKeyException(error));
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00007343 File Offset: 0x00005543
		private static Exception _NoNullAllowed(string error)
		{
			return ExceptionBuilder.TraceExceptionAsReturnValue(new NoNullAllowedException(error));
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00007350 File Offset: 0x00005550
		private static Exception _ReadOnly(string error)
		{
			return ExceptionBuilder.TraceExceptionAsReturnValue(new ReadOnlyException(error));
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000735D File Offset: 0x0000555D
		private static Exception _RowNotInTable(string error)
		{
			return ExceptionBuilder.TraceExceptionAsReturnValue(new RowNotInTableException(error));
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000736A File Offset: 0x0000556A
		private static Exception _VersionNotFound(string error)
		{
			return ExceptionBuilder.TraceExceptionAsReturnValue(new VersionNotFoundException(error));
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00007377 File Offset: 0x00005577
		public static Exception ArgumentNull(string paramName)
		{
			return ExceptionBuilder._ArgumentNull(paramName, SR.Format("'{0}' argument cannot be null.", paramName));
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000738A File Offset: 0x0000558A
		public static Exception ArgumentOutOfRange(string paramName)
		{
			return ExceptionBuilder._ArgumentOutOfRange(paramName, SR.Format("'{0}' argument is out of range.", paramName));
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000739D File Offset: 0x0000559D
		public static Exception BadObjectPropertyAccess(string error)
		{
			return ExceptionBuilder._InvalidOperation(SR.Format("Property not accessible because '{0}'.", error));
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000073AF File Offset: 0x000055AF
		public static Exception CannotModifyCollection()
		{
			return ExceptionBuilder._Argument("Collection itself is not modifiable.");
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000073BB File Offset: 0x000055BB
		public static Exception CaseInsensitiveNameConflict(string name)
		{
			return ExceptionBuilder._Argument(SR.Format("The given name '{0}' matches at least two names in the collection object with different cases, but does not match either of them with the same case.", name));
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000073CD File Offset: 0x000055CD
		public static Exception NamespaceNameConflict(string name)
		{
			return ExceptionBuilder._Argument(SR.Format("The given name '{0}' matches at least two names in the collection object with different namespaces.", name));
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000073DF File Offset: 0x000055DF
		public static Exception InvalidOffsetLength()
		{
			return ExceptionBuilder._Argument("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000073EB File Offset: 0x000055EB
		public static Exception ColumnNotInTheTable(string column, string table)
		{
			return ExceptionBuilder._Argument(SR.Format("Column '{0}' does not belong to table {1}.", column, table));
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000073FE File Offset: 0x000055FE
		public static Exception ColumnNotInAnyTable()
		{
			return ExceptionBuilder._Argument("Column must belong to a table.");
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000740A File Offset: 0x0000560A
		public static Exception ColumnOutOfRange(int index)
		{
			return ExceptionBuilder._IndexOutOfRange(SR.Format("Cannot find column {0}.", index.ToString(CultureInfo.InvariantCulture)));
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00007427 File Offset: 0x00005627
		public static Exception ColumnOutOfRange(string column)
		{
			return ExceptionBuilder._IndexOutOfRange(SR.Format("Cannot find column {0}.", column));
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00007439 File Offset: 0x00005639
		public static Exception CannotAddColumn1(string column)
		{
			return ExceptionBuilder._Argument(SR.Format("Column '{0}' already belongs to this DataTable.", column));
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000744B File Offset: 0x0000564B
		public static Exception CannotAddColumn2(string column)
		{
			return ExceptionBuilder._Argument(SR.Format("Column '{0}' already belongs to another DataTable.", column));
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000745D File Offset: 0x0000565D
		public static Exception CannotAddColumn3()
		{
			return ExceptionBuilder._Argument("Cannot have more than one SimpleContent columns in a DataTable.");
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00007469 File Offset: 0x00005669
		public static Exception CannotAddColumn4(string column)
		{
			return ExceptionBuilder._Argument(SR.Format("Cannot add a SimpleContent column to a table containing element columns or nested relations.", column));
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000747B File Offset: 0x0000567B
		public static Exception CannotAddDuplicate(string column)
		{
			return ExceptionBuilder._DuplicateName(SR.Format("A column named '{0}' already belongs to this DataTable.", column));
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000748D File Offset: 0x0000568D
		public static Exception CannotAddDuplicate2(string table)
		{
			return ExceptionBuilder._DuplicateName(SR.Format("Cannot add a column named '{0}': a nested table with the same name already belongs to this DataTable.", table));
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000749F File Offset: 0x0000569F
		public static Exception CannotAddDuplicate3(string table)
		{
			return ExceptionBuilder._DuplicateName(SR.Format("A column named '{0}' already belongs to this DataTable: cannot set a nested table name to the same name.", table));
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000074B1 File Offset: 0x000056B1
		public static Exception CannotRemoveColumn()
		{
			return ExceptionBuilder._Argument("Cannot remove a column that doesn't belong to this table.");
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000074BD File Offset: 0x000056BD
		public static Exception CannotRemovePrimaryKey()
		{
			return ExceptionBuilder._Argument("Cannot remove this column, because it's part of the primary key.");
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000074C9 File Offset: 0x000056C9
		public static Exception CannotRemoveChildKey(string relation)
		{
			return ExceptionBuilder._Argument(SR.Format("Cannot remove this column, because it is part of the parent key for relationship {0}.", relation));
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000074DB File Offset: 0x000056DB
		public static Exception CannotRemoveConstraint(string constraint, string table)
		{
			return ExceptionBuilder._Argument(SR.Format("Cannot remove this column, because it is a part of the constraint {0} on the table {1}.", constraint, table));
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000074EE File Offset: 0x000056EE
		public static Exception CannotRemoveExpression(string column, string expression)
		{
			return ExceptionBuilder._Argument(SR.Format("Cannot remove this column, because it is part of an expression: {0} = {1}.", column, expression));
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00007501 File Offset: 0x00005701
		public static Exception AddPrimaryKeyConstraint()
		{
			return ExceptionBuilder._Argument("Cannot add primary key constraint since primary key is already set for the table.");
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000750D File Offset: 0x0000570D
		public static Exception NoConstraintName()
		{
			return ExceptionBuilder._Argument("Cannot change the name of a constraint to empty string when it is in the ConstraintCollection.");
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00007519 File Offset: 0x00005719
		public static Exception ConstraintViolation(string constraint)
		{
			return ExceptionBuilder._Constraint(SR.Format("Cannot enforce constraints on constraint {0}.", constraint));
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000752C File Offset: 0x0000572C
		public static string KeysToString(object[] keys)
		{
			string text = string.Empty;
			for (int i = 0; i < keys.Length; i++)
			{
				text = text + Convert.ToString(keys[i], null) + ((i < keys.Length - 1) ? ", " : string.Empty);
			}
			return text;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00007574 File Offset: 0x00005774
		public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values)
		{
			if (columns.Length > 1)
			{
				string text = string.Empty;
				for (int i = 0; i < columns.Length; i++)
				{
					text = text + columns[i].ColumnName + ((i < columns.Length - 1) ? ", " : "");
				}
				return SR.Format("Column '{0}' is constrained to be unique.  Value '{1}' is already present.", text, ExceptionBuilder.KeysToString(values));
			}
			return SR.Format("Column '{0}' is constrained to be unique.  Value '{1}' is already present.", columns[0].ColumnName, Convert.ToString(values[0], null));
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000075EB File Offset: 0x000057EB
		public static Exception ConstraintViolation(DataColumn[] columns, object[] values)
		{
			return ExceptionBuilder._Constraint(ExceptionBuilder.UniqueConstraintViolationText(columns, values));
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000075F9 File Offset: 0x000057F9
		public static Exception ConstraintOutOfRange(int index)
		{
			return ExceptionBuilder._IndexOutOfRange(SR.Format("Cannot find constraint {0}.", index.ToString(CultureInfo.InvariantCulture)));
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00007616 File Offset: 0x00005816
		public static Exception DuplicateConstraint(string constraint)
		{
			return ExceptionBuilder._Data(SR.Format("Constraint matches constraint named {0} already in collection.", constraint));
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00007628 File Offset: 0x00005828
		public static Exception DuplicateConstraintName(string constraint)
		{
			return ExceptionBuilder._DuplicateName(SR.Format("A Constraint named '{0}' already belongs to this DataTable.", constraint));
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000763A File Offset: 0x0000583A
		public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk)
		{
			return ExceptionBuilder._Argument(SR.Format("Cannot remove unique constraint '{0}'. Remove foreign key constraint '{1}' first.", key.ConstraintName, fk.ConstraintName));
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00007657 File Offset: 0x00005857
		public static Exception UniqueConstraintViolation()
		{
			return ExceptionBuilder._Argument("These columns don't currently have unique values.");
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00007663 File Offset: 0x00005863
		public static Exception ConstraintForeignTable()
		{
			return ExceptionBuilder._Argument("These columns don't point to this table.");
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000766F File Offset: 0x0000586F
		public static Exception ConstraintParentValues()
		{
			return ExceptionBuilder._Argument("This constraint cannot be enabled as not all values have corresponding parent values.");
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000767B File Offset: 0x0000587B
		public static Exception ConstraintAddFailed(DataTable table)
		{
			return ExceptionBuilder._InvalidConstraint(SR.Format("This constraint cannot be added since ForeignKey doesn't belong to table {0}.", table.TableName));
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00007692 File Offset: 0x00005892
		public static Exception ConstraintRemoveFailed()
		{
			return ExceptionBuilder._Argument("Cannot remove a constraint that doesn't belong to this table.");
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000769E File Offset: 0x0000589E
		public static Exception FailedCascadeDelete(string constraint)
		{
			return ExceptionBuilder._InvalidConstraint(SR.Format("Cannot delete this row because constraints are enforced on relation {0}, and deleting this row will strand child rows.", constraint));
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000076B0 File Offset: 0x000058B0
		public static Exception FailedCascadeUpdate(string constraint)
		{
			return ExceptionBuilder._InvalidConstraint(SR.Format("Cannot make this change because constraints are enforced on relation {0}, and changing this value will strand child rows.", constraint));
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000076C2 File Offset: 0x000058C2
		public static Exception FailedClearParentTable(string table, string constraint, string childTable)
		{
			return ExceptionBuilder._InvalidConstraint(SR.Format("Cannot clear table {0} because ForeignKeyConstraint {1} enforces constraints and there are child rows in {2}.", table, constraint, childTable));
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000076D6 File Offset: 0x000058D6
		public static Exception ForeignKeyViolation(string constraint, object[] keys)
		{
			return ExceptionBuilder._InvalidConstraint(SR.Format("ForeignKeyConstraint {0} requires the child key values ({1}) to exist in the parent table.", constraint, ExceptionBuilder.KeysToString(keys)));
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000076EE File Offset: 0x000058EE
		public static Exception RemoveParentRow(ForeignKeyConstraint constraint)
		{
			return ExceptionBuilder._InvalidConstraint(SR.Format("Cannot remove this row because it has child rows, and constraints on relation {0} are enforced.", constraint.ConstraintName));
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00007705 File Offset: 0x00005905
		public static string MaxLengthViolationText(string columnName)
		{
			return SR.Format("Column '{0}' exceeds the MaxLength limit.", columnName);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00007712 File Offset: 0x00005912
		public static string NotAllowDBNullViolationText(string columnName)
		{
			return SR.Format("Column '{0}' does not allow DBNull.Value.", columnName);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000771F File Offset: 0x0000591F
		public static Exception CantAddConstraintToMultipleNestedTable(string tableName)
		{
			return ExceptionBuilder._Argument(SR.Format("Cannot add constraint to DataTable '{0}' which is a child table in two nested relations.", tableName));
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00007731 File Offset: 0x00005931
		public static Exception AutoIncrementAndExpression()
		{
			return ExceptionBuilder._Argument("Cannot set AutoIncrement property for a computed column.");
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000773D File Offset: 0x0000593D
		public static Exception AutoIncrementAndDefaultValue()
		{
			return ExceptionBuilder._Argument("Cannot set AutoIncrement property for a column with DefaultValue set.");
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00007749 File Offset: 0x00005949
		public static Exception AutoIncrementSeed()
		{
			return ExceptionBuilder._Argument("AutoIncrementStep must be a non-zero value.");
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00007755 File Offset: 0x00005955
		public static Exception CantChangeDataType()
		{
			return ExceptionBuilder._Argument("Cannot change DataType of a column once it has data.");
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00007761 File Offset: 0x00005961
		public static Exception NullDataType()
		{
			return ExceptionBuilder._Argument("Column requires a valid DataType.");
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000776D File Offset: 0x0000596D
		public static Exception ColumnNameRequired()
		{
			return ExceptionBuilder._Argument("ColumnName is required when it is part of a DataTable.");
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00007779 File Offset: 0x00005979
		public static Exception DefaultValueAndAutoIncrement()
		{
			return ExceptionBuilder._Argument("Cannot set a DefaultValue on an AutoIncrement column.");
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00007788 File Offset: 0x00005988
		public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner)
		{
			if (column.Length != 0)
			{
				return ExceptionBuilder._Argument(SR.Format("The DefaultValue for column {0} is of type {1} and cannot be converted to {2}.", column, defaultType.FullName, columnType.FullName), inner);
			}
			return ExceptionBuilder._Argument(SR.Format("The DefaultValue for the column is of type {0} and cannot be converted to {1}.", defaultType.FullName, columnType.FullName), inner);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000077D7 File Offset: 0x000059D7
		public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner)
		{
			return ExceptionBuilder._Argument(SR.Format("The DefaultValue for column {0} is of type {1}, but the column is of type {2}.", column, defaultType.FullName, columnType.FullName), inner);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000077F6 File Offset: 0x000059F6
		public static Exception ExpressionAndUnique()
		{
			return ExceptionBuilder._Argument("Cannot create an expression on a column that has AutoIncrement or Unique.");
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00007802 File Offset: 0x00005A02
		public static Exception ExpressionAndReadOnly()
		{
			return ExceptionBuilder._Argument("Cannot set expression because column cannot be made ReadOnly.");
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000780E File Offset: 0x00005A0E
		public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint)
		{
			return ExceptionBuilder._Argument(SR.Format("Cannot set Expression property on column {0}, because it is a part of a constraint.", column.ColumnName, constraint.ConstraintName));
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000782B File Offset: 0x00005A2B
		public static Exception ExpressionInConstraint(DataColumn column)
		{
			return ExceptionBuilder._Argument(SR.Format("Cannot create a constraint based on Expression column {0}.", column.ColumnName));
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00007842 File Offset: 0x00005A42
		public static Exception ExpressionCircular()
		{
			return ExceptionBuilder._Argument("Cannot set Expression property due to circular reference in the expression.");
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000784E File Offset: 0x00005A4E
		public static Exception NonUniqueValues(string column)
		{
			return ExceptionBuilder._InvalidConstraint(SR.Format("Column '{0}' contains non-unique values.", column));
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00007860 File Offset: 0x00005A60
		public static Exception NullKeyValues(string column)
		{
			return ExceptionBuilder._Data(SR.Format("Column '{0}' has null values in it.", column));
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00007872 File Offset: 0x00005A72
		public static Exception NullValues(string column)
		{
			return ExceptionBuilder._NoNullAllowed(SR.Format("Column '{0}' does not allow nulls.", column));
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00007884 File Offset: 0x00005A84
		public static Exception ReadOnlyAndExpression()
		{
			return ExceptionBuilder._ReadOnly("Cannot change ReadOnly property for the expression column.");
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00007890 File Offset: 0x00005A90
		public static Exception ReadOnly(string column)
		{
			return ExceptionBuilder._ReadOnly(SR.Format("Column '{0}' is read only.", column));
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000078A2 File Offset: 0x00005AA2
		public static Exception UniqueAndExpression()
		{
			return ExceptionBuilder._Argument("Cannot change Unique property for the expression column.");
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000078AE File Offset: 0x00005AAE
		public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException)
		{
			return ExceptionBuilder._Argument(innerException.Message + SR.Format("Couldn't store <{0}> in {1} Column.  Expected type is {2}.", value.ToString(), column.ColumnName, type.Name), innerException);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000078DD File Offset: 0x00005ADD
		public static Exception CannotSetToNull(DataColumn column)
		{
			return ExceptionBuilder._Argument(SR.Format("Cannot set Column '{0}' to be null. Please use DBNull instead.", column.ColumnName));
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000078F4 File Offset: 0x00005AF4
		public static Exception LongerThanMaxLength(DataColumn column)
		{
			return ExceptionBuilder._Argument(SR.Format("Cannot set column '{0}'. The value violates the MaxLength limit of this column.", column.ColumnName));
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000790B File Offset: 0x00005B0B
		public static Exception CannotSetMaxLength(DataColumn column, int value)
		{
			return ExceptionBuilder._Argument(SR.Format("Cannot set Column '{0}' property MaxLength to '{1}'. There is at least one string in the table longer than the new limit.", column.ColumnName, value.ToString(CultureInfo.InvariantCulture)));
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000792E File Offset: 0x00005B2E
		public static Exception CannotSetMaxLength2(DataColumn column)
		{
			return ExceptionBuilder._Argument(SR.Format("Cannot set Column '{0}' property MaxLength. The Column is SimpleContent.", column.ColumnName));
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00007945 File Offset: 0x00005B45
		public static Exception CannotSetSimpleContentType(string columnName, Type type)
		{
			return ExceptionBuilder._Argument(SR.Format("Cannot set Column '{0}' property DataType to {1}. The Column is SimpleContent.", columnName, type));
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00007958 File Offset: 0x00005B58
		public static Exception CannotSetSimpleContent(string columnName, Type type)
		{
			return ExceptionBuilder._Argument(SR.Format("Cannot set Column '{0}' property MappingType to SimpleContent. The Column DataType is {1}.", columnName, type));
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000796B File Offset: 0x00005B6B
		public static Exception CannotChangeNamespace(string columnName)
		{
			return ExceptionBuilder._Argument(SR.Format("Cannot change the Column '{0}' property Namespace. The Column is SimpleContent.", columnName));
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000797D File Offset: 0x00005B7D
		public static Exception HasToBeStringType(DataColumn column)
		{
			return ExceptionBuilder._Argument(SR.Format("MaxLength applies to string data type only. You cannot set Column '{0}' property MaxLength to be non-negative number.", column.ColumnName));
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00007994 File Offset: 0x00005B94
		public static Exception AutoIncrementCannotSetIfHasData(string typeName)
		{
			return ExceptionBuilder._Argument(SR.Format("Cannot change AutoIncrement of a DataColumn with type '{0}' once it has data.", typeName));
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000079A6 File Offset: 0x00005BA6
		public static Exception INullableUDTwithoutStaticNull(string typeName)
		{
			return ExceptionBuilder._Argument(SR.Format("Type '{0}' does not contain static Null property or field.", typeName));
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000079B8 File Offset: 0x00005BB8
		public static Exception IComparableNotImplemented(string typeName)
		{
			return ExceptionBuilder._Data(SR.Format(" Type '{0}' does not implement IComparable interface. Comparison cannot be done.", typeName));
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000079CA File Offset: 0x00005BCA
		public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName)
		{
			return ExceptionBuilder._InvalidOperation(SR.Format("Type '{0}' does not implement IRevertibleChangeTracking; therefore can not proceed with RejectChanges().", typeName));
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000079DC File Offset: 0x00005BDC
		public static Exception InvalidDataColumnMapping(Type type)
		{
			return ExceptionBuilder._Argument(SR.Format("DataColumn with type '{0}' is a complexType. Can not serialize value of a complex type as Attribute", type.AssemblyQualifiedName));
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000079F3 File Offset: 0x00005BF3
		public static Exception CannotSetDateTimeModeForNonDateTimeColumns()
		{
			return ExceptionBuilder._InvalidOperation("The DateTimeMode can be set only on DataColumns of type DateTime.");
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000079FF File Offset: 0x00005BFF
		public static Exception InvalidDateTimeMode(DataSetDateTime mode)
		{
			return ExceptionBuilder._InvalidEnumArgumentException<DataSetDateTime>(mode);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00007A07 File Offset: 0x00005C07
		public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue)
		{
			return ExceptionBuilder._InvalidOperation(SR.Format("Cannot change DateTimeMode from '{0}' to '{1}' once the table has data.", oldValue.ToString(), newValue.ToString()));
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00007A32 File Offset: 0x00005C32
		public static Exception ColumnTypeNotSupported()
		{
			return ADP.NotSupported("DataSet does not support System.Nullable<>.");
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00007A3E File Offset: 0x00005C3E
		public static Exception SetFailed(string name)
		{
			return ExceptionBuilder._Data(SR.Format("Cannot set {0}.", name));
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00007A50 File Offset: 0x00005C50
		public static Exception SetRowStateFilter()
		{
			return ExceptionBuilder._Data("RowStateFilter cannot show ModifiedOriginals and ModifiedCurrents at the same time.");
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00007A5C File Offset: 0x00005C5C
		public static Exception CanNotUseDataViewManager()
		{
			return ExceptionBuilder._Data("DataSet must be set prior to using DataViewManager.");
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00007A68 File Offset: 0x00005C68
		public static Exception CanNotSetTable()
		{
			return ExceptionBuilder._Data("Cannot change Table property once it is set.");
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00007A74 File Offset: 0x00005C74
		public static Exception CanNotUse()
		{
			return ExceptionBuilder._Data("DataTable must be set prior to using DataView.");
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00007A80 File Offset: 0x00005C80
		public static Exception CanNotBindTable()
		{
			return ExceptionBuilder._Data("Cannot bind to DataTable with no name.");
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00007A8C File Offset: 0x00005C8C
		public static Exception SetTable()
		{
			return ExceptionBuilder._Data("Cannot change Table property on a DefaultView or a DataView coming from a DataViewManager.");
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00007A98 File Offset: 0x00005C98
		public static Exception SetIListObject()
		{
			return ExceptionBuilder._Argument("Cannot set an object into this list.");
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00007AA4 File Offset: 0x00005CA4
		public static Exception AddNewNotAllowNull()
		{
			return ExceptionBuilder._Data("Cannot call AddNew on a DataView where AllowNew is false.");
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00007AB0 File Offset: 0x00005CB0
		public static Exception NotOpen()
		{
			return ExceptionBuilder._Data("DataView is not open.");
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00007ABC File Offset: 0x00005CBC
		public static Exception CreateChildView()
		{
			return ExceptionBuilder._Argument("The relation is not parented to the table to which this DataView points.");
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00007AC8 File Offset: 0x00005CC8
		public static Exception CanNotDelete()
		{
			return ExceptionBuilder._Data("Cannot delete on a DataSource where AllowDelete is false.");
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00007AD4 File Offset: 0x00005CD4
		public static Exception GetElementIndex(int index)
		{
			return ExceptionBuilder._IndexOutOfRange(SR.Format("Index {0} is either negative or above rows count.", index.ToString(CultureInfo.InvariantCulture)));
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00007AF1 File Offset: 0x00005CF1
		public static Exception AddExternalObject()
		{
			return ExceptionBuilder._Argument("Cannot add external objects to this list.");
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00007AFD File Offset: 0x00005CFD
		public static Exception CanNotClear()
		{
			return ExceptionBuilder._Argument("Cannot clear this list.");
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00007B09 File Offset: 0x00005D09
		public static Exception InsertExternalObject()
		{
			return ExceptionBuilder._Argument("Cannot insert external objects to this list.");
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00007B15 File Offset: 0x00005D15
		public static Exception RemoveExternalObject()
		{
			return ExceptionBuilder._Argument("Cannot remove objects not in the list.");
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00007B21 File Offset: 0x00005D21
		public static Exception KeyTableMismatch()
		{
			return ExceptionBuilder._InvalidConstraint("Cannot create a Key from Columns that belong to different tables.");
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00007B2D File Offset: 0x00005D2D
		public static Exception KeyNoColumns()
		{
			return ExceptionBuilder._InvalidConstraint("Cannot have 0 columns.");
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00007B39 File Offset: 0x00005D39
		public static Exception KeyTooManyColumns(int cols)
		{
			return ExceptionBuilder._InvalidConstraint(SR.Format("Cannot have more than {0} columns.", cols.ToString(CultureInfo.InvariantCulture)));
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00007B56 File Offset: 0x00005D56
		public static Exception KeyDuplicateColumns(string columnName)
		{
			return ExceptionBuilder._InvalidConstraint(SR.Format("Cannot create a Key when the same column is listed more than once: '{0}'", columnName));
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00007B68 File Offset: 0x00005D68
		public static Exception RelationDataSetMismatch()
		{
			return ExceptionBuilder._InvalidConstraint("Cannot have a relationship between tables in different DataSets.");
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00007B74 File Offset: 0x00005D74
		public static Exception NoRelationName()
		{
			return ExceptionBuilder._Argument("RelationName is required when it is part of a DataSet.");
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00007B80 File Offset: 0x00005D80
		public static Exception ColumnsTypeMismatch()
		{
			return ExceptionBuilder._InvalidConstraint("Parent Columns and Child Columns don't have type-matching columns.");
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00007B8C File Offset: 0x00005D8C
		public static Exception KeyLengthMismatch()
		{
			return ExceptionBuilder._Argument("ParentColumns and ChildColumns should be the same length.");
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00007B98 File Offset: 0x00005D98
		public static Exception KeyLengthZero()
		{
			return ExceptionBuilder._Argument("ParentColumns and ChildColumns must not be zero length.");
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00007BA4 File Offset: 0x00005DA4
		public static Exception ForeignRelation()
		{
			return ExceptionBuilder._Argument("This relation should connect two tables in this DataSet to be added to this DataSet.");
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00007BB0 File Offset: 0x00005DB0
		public static Exception KeyColumnsIdentical()
		{
			return ExceptionBuilder._InvalidConstraint("ParentKey and ChildKey are identical.");
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00007BBC File Offset: 0x00005DBC
		public static Exception RelationForeignTable(string t1, string t2)
		{
			return ExceptionBuilder._InvalidConstraint(SR.Format("GetChildRows requires a row whose Table is {0}, but the specified row's Table is {1}.", t1, t2));
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00007BCF File Offset: 0x00005DCF
		public static Exception GetParentRowTableMismatch(string t1, string t2)
		{
			return ExceptionBuilder._InvalidConstraint(SR.Format("GetParentRow requires a row whose Table is {0}, but the specified row's Table is {1}.", t1, t2));
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00007BE2 File Offset: 0x00005DE2
		public static Exception SetParentRowTableMismatch(string t1, string t2)
		{
			return ExceptionBuilder._InvalidConstraint(SR.Format("SetParentRow requires a child row whose Table is {0}, but the specified row's Table is {1}.", t1, t2));
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00007BF5 File Offset: 0x00005DF5
		public static Exception RelationForeignRow()
		{
			return ExceptionBuilder._Argument("The row doesn't belong to the same DataSet as this relation.");
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00007C01 File Offset: 0x00005E01
		public static Exception RelationNestedReadOnly()
		{
			return ExceptionBuilder._Argument("Cannot set the 'Nested' property to false for this relation.");
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00007C0D File Offset: 0x00005E0D
		public static Exception TableCantBeNestedInTwoTables(string tableName)
		{
			return ExceptionBuilder._Argument(SR.Format("The same table '{0}' cannot be the child table in two nested relations.", tableName));
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00007C1F File Offset: 0x00005E1F
		public static Exception LoopInNestedRelations(string tableName)
		{
			return ExceptionBuilder._Argument(SR.Format("The table ({0}) cannot be the child table to itself in nested relations.", tableName));
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00007C31 File Offset: 0x00005E31
		public static Exception RelationDoesNotExist()
		{
			return ExceptionBuilder._Argument("This relation doesn't belong to this relation collection.");
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00007C3D File Offset: 0x00005E3D
		public static Exception ParentOrChildColumnsDoNotHaveDataSet()
		{
			return ExceptionBuilder._InvalidConstraint("Cannot create a DataRelation if Parent or Child Columns are not in a DataSet.");
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00007C49 File Offset: 0x00005E49
		public static Exception InValidNestedRelation(string childTableName)
		{
			return ExceptionBuilder._InvalidOperation(SR.Format("Nested table '{0}' which inherits its namespace cannot have multiple parent tables in different namespaces.", childTableName));
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00007C5B File Offset: 0x00005E5B
		public static Exception InvalidParentNamespaceinNestedRelation(string childTableName)
		{
			return ExceptionBuilder._InvalidOperation(SR.Format("Nested table '{0}' with empty namespace cannot have multiple parent tables in different namespaces.", childTableName));
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00007BF5 File Offset: 0x00005DF5
		public static Exception RowNotInTheDataSet()
		{
			return ExceptionBuilder._Argument("The row doesn't belong to the same DataSet as this relation.");
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00007C6D File Offset: 0x00005E6D
		public static Exception RowNotInTheTable()
		{
			return ExceptionBuilder._RowNotInTable("Cannot perform this operation on a row not in the table.");
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00007C79 File Offset: 0x00005E79
		public static Exception EditInRowChanging()
		{
			return ExceptionBuilder._InRowChangingEvent("Cannot change a proposed value in the RowChanging event.");
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00007C85 File Offset: 0x00005E85
		public static Exception EndEditInRowChanging()
		{
			return ExceptionBuilder._InRowChangingEvent("Cannot call EndEdit() inside an OnRowChanging event.");
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00007C91 File Offset: 0x00005E91
		public static Exception BeginEditInRowChanging()
		{
			return ExceptionBuilder._InRowChangingEvent("Cannot call BeginEdit() inside the RowChanging event.");
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00007C9D File Offset: 0x00005E9D
		public static Exception CancelEditInRowChanging()
		{
			return ExceptionBuilder._InRowChangingEvent("Cannot call CancelEdit() inside an OnRowChanging event.  Throw an exception to cancel this update.");
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00007CA9 File Offset: 0x00005EA9
		public static Exception DeleteInRowDeleting()
		{
			return ExceptionBuilder._InRowChangingEvent("Cannot call Delete inside an OnRowDeleting event.  Throw an exception to cancel this delete.");
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00007CB5 File Offset: 0x00005EB5
		public static Exception ValueArrayLength()
		{
			return ExceptionBuilder._Argument("Input array is longer than the number of columns in this table.");
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00007CC1 File Offset: 0x00005EC1
		public static Exception NoCurrentData()
		{
			return ExceptionBuilder._VersionNotFound("There is no Current data to access.");
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00007CCD File Offset: 0x00005ECD
		public static Exception NoOriginalData()
		{
			return ExceptionBuilder._VersionNotFound("There is no Original data to access.");
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00007CD9 File Offset: 0x00005ED9
		public static Exception NoProposedData()
		{
			return ExceptionBuilder._VersionNotFound("There is no Proposed data to access.");
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00007CE5 File Offset: 0x00005EE5
		public static Exception RowRemovedFromTheTable()
		{
			return ExceptionBuilder._RowNotInTable("This row has been removed from a table and does not have any data.  BeginEdit() will allow creation of new data in this row.");
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00007CF1 File Offset: 0x00005EF1
		public static Exception DeletedRowInaccessible()
		{
			return ExceptionBuilder._DeletedRowInaccessible("Deleted row information cannot be accessed through the row.");
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00007CFD File Offset: 0x00005EFD
		public static Exception RowAlreadyDeleted()
		{
			return ExceptionBuilder._DeletedRowInaccessible("Cannot delete this row since it's already deleted.");
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00007D09 File Offset: 0x00005F09
		public static Exception RowEmpty()
		{
			return ExceptionBuilder._Argument("This row is empty.");
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00007D15 File Offset: 0x00005F15
		public static Exception InvalidRowVersion()
		{
			return ExceptionBuilder._Data("Version must be Original, Current, or Proposed.");
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00007D21 File Offset: 0x00005F21
		public static Exception RowOutOfRange(int index)
		{
			return ExceptionBuilder._IndexOutOfRange(SR.Format("There is no row at position {0}.", index.ToString(CultureInfo.InvariantCulture)));
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00007D3E File Offset: 0x00005F3E
		public static Exception RowInsertTwice(int index, string tableName)
		{
			return ExceptionBuilder._IndexOutOfRange(SR.Format("The rowOrder value={0} has been found twice for table named '{1}'.", index.ToString(CultureInfo.InvariantCulture), tableName));
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00007D5C File Offset: 0x00005F5C
		public static Exception RowInsertMissing(string tableName)
		{
			return ExceptionBuilder._IndexOutOfRange(SR.Format("Values are missing in the rowOrder sequence for table '{0}'.", tableName));
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00007D6E File Offset: 0x00005F6E
		public static Exception RowAlreadyRemoved()
		{
			return ExceptionBuilder._Data("Cannot remove a row that's already been removed.");
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00007D7A File Offset: 0x00005F7A
		public static Exception MultipleParents()
		{
			return ExceptionBuilder._Data("A child row has multiple parents.");
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00007D86 File Offset: 0x00005F86
		public static Exception InvalidRowState(DataRowState state)
		{
			return ExceptionBuilder._InvalidEnumArgumentException<DataRowState>(state);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00007D8E File Offset: 0x00005F8E
		public static Exception InvalidRowBitPattern()
		{
			return ExceptionBuilder._Argument("Unrecognized row state bit pattern.");
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00007D9A File Offset: 0x00005F9A
		internal static Exception SetDataSetNameToEmpty()
		{
			return ExceptionBuilder._Argument("Cannot change the name of the DataSet to an empty string.");
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00007DA6 File Offset: 0x00005FA6
		internal static Exception SetDataSetNameConflicting(string name)
		{
			return ExceptionBuilder._Argument(SR.Format("The name '{0}' is invalid. A DataSet cannot have the same name of the DataTable.", name));
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00007DB8 File Offset: 0x00005FB8
		public static Exception DataSetUnsupportedSchema(string ns)
		{
			return ExceptionBuilder._Argument(SR.Format("The schema namespace is invalid. Please use this one instead: {0}.", ns));
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00007DCA File Offset: 0x00005FCA
		public static Exception MergeMissingDefinition(string obj)
		{
			return ExceptionBuilder._Argument(SR.Format("Target DataSet missing definition for {0}.", obj));
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00007DDC File Offset: 0x00005FDC
		public static Exception TablesInDifferentSets()
		{
			return ExceptionBuilder._Argument("Cannot create a relation between tables in different DataSets.");
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00007DE8 File Offset: 0x00005FE8
		public static Exception RelationAlreadyExists()
		{
			return ExceptionBuilder._Argument("A relation already exists for these child columns.");
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00007DF4 File Offset: 0x00005FF4
		public static Exception RowAlreadyInOtherCollection()
		{
			return ExceptionBuilder._Argument("This row already belongs to another table.");
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00007E00 File Offset: 0x00006000
		public static Exception RowAlreadyInTheCollection()
		{
			return ExceptionBuilder._Argument("This row already belongs to this table.");
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00007E0C File Offset: 0x0000600C
		public static Exception TableMissingPrimaryKey()
		{
			return ExceptionBuilder._MissingPrimaryKey("Table doesn't have a primary key.");
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00007E18 File Offset: 0x00006018
		public static Exception RecordStateRange()
		{
			return ExceptionBuilder._Argument("The RowStates parameter must be set to a valid combination of values from the DataViewRowState enumeration.");
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00007E24 File Offset: 0x00006024
		public static Exception IndexKeyLength(int length, int keyLength)
		{
			if (length != 0)
			{
				return ExceptionBuilder._Argument(SR.Format("Expecting {0} value(s) for the key being indexed, but received {1} value(s).", length.ToString(CultureInfo.InvariantCulture), keyLength.ToString(CultureInfo.InvariantCulture)));
			}
			return ExceptionBuilder._Argument("Find finds a row based on a Sort order, and no Sort order is specified.");
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00007E5B File Offset: 0x0000605B
		public static Exception RemovePrimaryKey(DataTable table)
		{
			if (table.TableName.Length != 0)
			{
				return ExceptionBuilder._Argument(SR.Format("Cannot remove unique constraint since it's the primary key of table {0}.", table.TableName));
			}
			return ExceptionBuilder._Argument("Cannot remove unique constraint since it's the primary key of a table.");
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00007E8A File Offset: 0x0000608A
		public static Exception RelationAlreadyInOtherDataSet()
		{
			return ExceptionBuilder._Argument("This relation already belongs to another DataSet.");
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00007E96 File Offset: 0x00006096
		public static Exception RelationAlreadyInTheDataSet()
		{
			return ExceptionBuilder._Argument("This relation already belongs to this DataSet.");
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00007EA2 File Offset: 0x000060A2
		public static Exception RelationNotInTheDataSet(string relation)
		{
			return ExceptionBuilder._Argument(SR.Format("Relation {0} does not belong to this DataSet.", relation));
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00007EB4 File Offset: 0x000060B4
		public static Exception RelationOutOfRange(object index)
		{
			return ExceptionBuilder._IndexOutOfRange(SR.Format("Cannot find relation {0}.", Convert.ToString(index, null)));
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00007ECC File Offset: 0x000060CC
		public static Exception DuplicateRelation(string relation)
		{
			return ExceptionBuilder._DuplicateName(SR.Format("A Relation named '{0}' already belongs to this DataSet.", relation));
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00007EDE File Offset: 0x000060DE
		public static Exception RelationTableNull()
		{
			return ExceptionBuilder._Argument("Cannot create a collection on a null table.");
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00007EDE File Offset: 0x000060DE
		public static Exception RelationDataSetNull()
		{
			return ExceptionBuilder._Argument("Cannot create a collection on a null table.");
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00007EEA File Offset: 0x000060EA
		public static Exception RelationTableWasRemoved()
		{
			return ExceptionBuilder._Argument("The table this collection displays relations for has been removed from its DataSet.");
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00007EF6 File Offset: 0x000060F6
		public static Exception ParentTableMismatch()
		{
			return ExceptionBuilder._Argument("Cannot add a relation to this table's ChildRelation collection where this table isn't the parent table.");
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00007F02 File Offset: 0x00006102
		public static Exception ChildTableMismatch()
		{
			return ExceptionBuilder._Argument("Cannot add a relation to this table's ParentRelation collection where this table isn't the child table.");
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00007F0E File Offset: 0x0000610E
		public static Exception EnforceConstraint()
		{
			return ExceptionBuilder._Constraint("Failed to enable constraints. One or more rows contain values violating non-null, unique, or foreign-key constraints.");
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00007F1A File Offset: 0x0000611A
		public static Exception CaseLocaleMismatch()
		{
			return ExceptionBuilder._Argument("Cannot add a DataRelation or Constraint that has different Locale or CaseSensitive settings between its parent and child tables.");
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00007F26 File Offset: 0x00006126
		public static Exception CannotChangeCaseLocale()
		{
			return ExceptionBuilder.CannotChangeCaseLocale(null);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00007F2E File Offset: 0x0000612E
		public static Exception CannotChangeCaseLocale(Exception innerException)
		{
			return ExceptionBuilder._Argument("Cannot change CaseSensitive or Locale property. This change would lead to at least one DataRelation or Constraint to have different Locale or CaseSensitive settings between its related tables.", innerException);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00007F3B File Offset: 0x0000613B
		public static Exception CannotChangeSchemaSerializationMode()
		{
			return ExceptionBuilder._InvalidOperation("SchemaSerializationMode property can be set only if it is overridden by derived DataSet.");
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00007F47 File Offset: 0x00006147
		public static Exception InvalidSchemaSerializationMode(Type enumType, string mode)
		{
			return ExceptionBuilder._InvalidEnumArgumentException(SR.Format("The {0} enumeration value, {1}, is invalid.", enumType.Name, mode));
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00007F5F File Offset: 0x0000615F
		public static Exception InvalidRemotingFormat(SerializationFormat mode)
		{
			return ExceptionBuilder._InvalidEnumArgumentException<SerializationFormat>(mode);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00007F67 File Offset: 0x00006167
		public static Exception TableForeignPrimaryKey()
		{
			return ExceptionBuilder._Argument("PrimaryKey columns do not belong to this table.");
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00007F73 File Offset: 0x00006173
		public static Exception TableCannotAddToSimpleContent()
		{
			return ExceptionBuilder._Argument("Cannot add a nested relation or an element column to a table containing a SimpleContent column.");
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00007F7F File Offset: 0x0000617F
		public static Exception NoTableName()
		{
			return ExceptionBuilder._Argument("TableName is required when it is part of a DataSet.");
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00007F8B File Offset: 0x0000618B
		public static Exception MultipleTextOnlyColumns()
		{
			return ExceptionBuilder._Argument("DataTable already has a simple content column.");
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00007F97 File Offset: 0x00006197
		public static Exception InvalidSortString(string sort)
		{
			return ExceptionBuilder._Argument(SR.Format(" {0} isn't a valid Sort string entry.", sort));
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00007FA9 File Offset: 0x000061A9
		public static Exception DuplicateTableName(string table)
		{
			return ExceptionBuilder._DuplicateName(SR.Format("A DataTable named '{0}' already belongs to this DataSet.", table));
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00007FBB File Offset: 0x000061BB
		public static Exception DuplicateTableName2(string table, string ns)
		{
			return ExceptionBuilder._DuplicateName(SR.Format("A DataTable named '{0}' with the same Namespace '{1}' already belongs to this DataSet.", table, ns));
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00007FCE File Offset: 0x000061CE
		public static Exception SelfnestedDatasetConflictingName(string table)
		{
			return ExceptionBuilder._DuplicateName(SR.Format("The table ({0}) cannot be the child table to itself in a nested relation: the DataSet name conflicts with the table name.", table));
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00007FE0 File Offset: 0x000061E0
		public static Exception DatasetConflictingName(string table)
		{
			return ExceptionBuilder._DuplicateName(SR.Format("The name '{0}' is invalid. A DataTable cannot have the same name of the DataSet.", table));
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00007FF2 File Offset: 0x000061F2
		public static Exception TableAlreadyInOtherDataSet()
		{
			return ExceptionBuilder._Argument("DataTable already belongs to another DataSet.");
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00007FFE File Offset: 0x000061FE
		public static Exception TableAlreadyInTheDataSet()
		{
			return ExceptionBuilder._Argument("DataTable already belongs to this DataSet.");
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000800A File Offset: 0x0000620A
		public static Exception TableOutOfRange(int index)
		{
			return ExceptionBuilder._IndexOutOfRange(SR.Format("Cannot find table {0}.", index.ToString(CultureInfo.InvariantCulture)));
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00008027 File Offset: 0x00006227
		public static Exception TableNotInTheDataSet(string table)
		{
			return ExceptionBuilder._Argument(SR.Format("Table {0} does not belong to this DataSet.", table));
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00008039 File Offset: 0x00006239
		public static Exception TableInRelation()
		{
			return ExceptionBuilder._Argument("Cannot remove a table that has existing relations.  Remove relations first.");
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00008045 File Offset: 0x00006245
		public static Exception TableInConstraint(DataTable table, Constraint constraint)
		{
			return ExceptionBuilder._Argument(SR.Format("Cannot remove table {0}, because it referenced in ForeignKeyConstraint {1}.  Remove the constraint first.", table.TableName, constraint.ConstraintName));
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00008062 File Offset: 0x00006262
		public static Exception CanNotSerializeDataTableHierarchy()
		{
			return ExceptionBuilder._InvalidOperation("Cannot serialize the DataTable. A DataTable being used in one or more DataColumn expressions is not a descendant of current DataTable.");
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000806E File Offset: 0x0000626E
		public static Exception CanNotRemoteDataTable()
		{
			return ExceptionBuilder._InvalidOperation("This DataTable can only be remoted as part of DataSet. One or more Expression Columns has reference to other DataTable(s).");
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000807A File Offset: 0x0000627A
		public static Exception CanNotSetRemotingFormat()
		{
			return ExceptionBuilder._Argument("Cannot have different remoting format property value for DataSet and DataTable.");
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00008086 File Offset: 0x00006286
		public static Exception CanNotSerializeDataTableWithEmptyName()
		{
			return ExceptionBuilder._InvalidOperation("Cannot serialize the DataTable. DataTable name is not set.");
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00008092 File Offset: 0x00006292
		public static Exception TableNotFound(string tableName)
		{
			return ExceptionBuilder._Argument(SR.Format("DataTable '{0}' does not match to any DataTable in source.", tableName));
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000080A4 File Offset: 0x000062A4
		public static Exception AggregateException(AggregateType aggregateType, Type type)
		{
			return ExceptionBuilder._Data(SR.Format("Invalid usage of aggregate function {0}() and Type: {1}.", aggregateType.ToString(), type.Name));
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000080C8 File Offset: 0x000062C8
		public static Exception InvalidStorageType(TypeCode typecode)
		{
			return ExceptionBuilder._Data(SR.Format("Invalid storage type: {0}.", typecode.ToString()));
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000080E6 File Offset: 0x000062E6
		public static Exception RangeArgument(int min, int max)
		{
			return ExceptionBuilder._Argument(SR.Format("Min ({0}) must be less than or equal to max ({1}) in a Range object.", min.ToString(CultureInfo.InvariantCulture), max.ToString(CultureInfo.InvariantCulture)));
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000810F File Offset: 0x0000630F
		public static Exception NullRange()
		{
			return ExceptionBuilder._Data("This is a null range.");
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000811B File Offset: 0x0000631B
		public static Exception NegativeMinimumCapacity()
		{
			return ExceptionBuilder._Argument("MinimumCapacity must be non-negative.");
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00008128 File Offset: 0x00006328
		public static Exception ProblematicChars(char charValue)
		{
			string resourceFormat = "The DataSet Xml persistency does not support the value '{0}' as Char value, please use Byte storage instead.";
			string str = "0x";
			ushort num = (ushort)charValue;
			return ExceptionBuilder._Argument(SR.Format(resourceFormat, str + num.ToString("X", CultureInfo.InvariantCulture)));
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00008161 File Offset: 0x00006361
		public static Exception StorageSetFailed()
		{
			return ExceptionBuilder._Argument("Type of value has a mismatch with column type");
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000816D File Offset: 0x0000636D
		public static Exception SimpleTypeNotSupported()
		{
			return ExceptionBuilder._Data("DataSet doesn't support 'union' or 'list' as simpleType.");
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00008179 File Offset: 0x00006379
		public static Exception MissingAttribute(string attribute)
		{
			return ExceptionBuilder.MissingAttribute(string.Empty, attribute);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00008186 File Offset: 0x00006386
		public static Exception MissingAttribute(string element, string attribute)
		{
			return ExceptionBuilder._Data(SR.Format("Invalid {0} syntax: missing required '{1}' attribute.", element, attribute));
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00008199 File Offset: 0x00006399
		public static Exception InvalidAttributeValue(string name, string value)
		{
			return ExceptionBuilder._Data(SR.Format("Value '{1}' is invalid for attribute '{0}'.", name, value));
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000081AC File Offset: 0x000063AC
		public static Exception AttributeValues(string name, string value1, string value2)
		{
			return ExceptionBuilder._Data(SR.Format("The value of attribute '{0}' should be '{1}' or '{2}'.", name, value1, value2));
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000081C0 File Offset: 0x000063C0
		public static Exception ElementTypeNotFound(string name)
		{
			return ExceptionBuilder._Data(SR.Format("Cannot find ElementType name='{0}'.", name));
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000081D2 File Offset: 0x000063D2
		public static Exception RelationParentNameMissing(string rel)
		{
			return ExceptionBuilder._Data(SR.Format("Parent table name is missing in relation '{0}'.", rel));
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000081E4 File Offset: 0x000063E4
		public static Exception RelationChildNameMissing(string rel)
		{
			return ExceptionBuilder._Data(SR.Format("Child table name is missing in relation '{0}'.", rel));
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000081F6 File Offset: 0x000063F6
		public static Exception RelationTableKeyMissing(string rel)
		{
			return ExceptionBuilder._Data(SR.Format("Parent table key is missing in relation '{0}'.", rel));
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00008208 File Offset: 0x00006408
		public static Exception RelationChildKeyMissing(string rel)
		{
			return ExceptionBuilder._Data(SR.Format("Child table key is missing in relation '{0}'.", rel));
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000821A File Offset: 0x0000641A
		public static Exception UndefinedDatatype(string name)
		{
			return ExceptionBuilder._Data(SR.Format("Undefined data type: '{0}'.", name));
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000822C File Offset: 0x0000642C
		public static Exception DatatypeNotDefined()
		{
			return ExceptionBuilder._Data("Data type not defined.");
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00008238 File Offset: 0x00006438
		public static Exception MismatchKeyLength()
		{
			return ExceptionBuilder._Data("Invalid Relation definition: different length keys.");
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00008244 File Offset: 0x00006444
		public static Exception InvalidField(string name)
		{
			return ExceptionBuilder._Data(SR.Format("Invalid XPath selection inside field node. Cannot find: {0}.", name));
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00008256 File Offset: 0x00006456
		public static Exception InvalidSelector(string name)
		{
			return ExceptionBuilder._Data(SR.Format("Invalid XPath selection inside selector node: {0}.", name));
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00008268 File Offset: 0x00006468
		public static Exception CircularComplexType(string name)
		{
			return ExceptionBuilder._Data(SR.Format("DataSet doesn't allow the circular reference in the ComplexType named '{0}'.", name));
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000827A File Offset: 0x0000647A
		public static Exception CannotInstantiateAbstract(string name)
		{
			return ExceptionBuilder._Data(SR.Format("DataSet cannot instantiate an abstract ComplexType for the node {0}.", name));
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000828C File Offset: 0x0000648C
		public static Exception InvalidKey(string name)
		{
			return ExceptionBuilder._Data(SR.Format("Invalid 'Key' node inside constraint named: {0}.", name));
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000829E File Offset: 0x0000649E
		public static Exception DiffgramMissingTable(string name)
		{
			return ExceptionBuilder._Data(SR.Format("Cannot load diffGram. Table '{0}' is missing in the destination dataset.", name));
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000082B0 File Offset: 0x000064B0
		public static Exception DiffgramMissingSQL()
		{
			return ExceptionBuilder._Data("Cannot load diffGram. The 'sql' node is missing.");
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000082BC File Offset: 0x000064BC
		public static Exception DuplicateConstraintRead(string str)
		{
			return ExceptionBuilder._Data(SR.Format("The constraint name {0} is already used in the schema.", str));
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000082CE File Offset: 0x000064CE
		public static Exception ColumnTypeConflict(string name)
		{
			return ExceptionBuilder._Data(SR.Format("Column name '{0}' is defined for different mapping types.", name));
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000082E0 File Offset: 0x000064E0
		public static Exception CannotConvert(string name, string type)
		{
			return ExceptionBuilder._Data(SR.Format(" Cannot convert '{0}' to type '{1}'.", name, type));
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000082F3 File Offset: 0x000064F3
		public static Exception MissingRefer(string name)
		{
			return ExceptionBuilder._Data(SR.Format("Missing '{0}' part in '{1}' constraint named '{2}'.", "refer", "keyref", name));
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000830F File Offset: 0x0000650F
		public static Exception InvalidPrefix(string name)
		{
			return ExceptionBuilder._Data(SR.Format("Prefix '{0}' is not valid, because it contains special characters.", name));
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00008321 File Offset: 0x00006521
		public static Exception CanNotDeserializeObjectType()
		{
			return ExceptionBuilder._InvalidOperation("Unable to proceed with deserialization. Data does not implement IXMLSerializable, therefore polymorphism is not supported.");
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000832D File Offset: 0x0000652D
		public static Exception IsDataSetAttributeMissingInSchema()
		{
			return ExceptionBuilder._Data("IsDataSet attribute is missing in input Schema.");
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00008339 File Offset: 0x00006539
		public static Exception TooManyIsDataSetAtributeInSchema()
		{
			return ExceptionBuilder._Data("Cannot determine the DataSet Element. IsDataSet attribute exist more than once.");
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00008345 File Offset: 0x00006545
		public static Exception NestedCircular(string name)
		{
			return ExceptionBuilder._Data(SR.Format("Circular reference in self-nested table '{0}'.", name));
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00008357 File Offset: 0x00006557
		public static Exception MultipleParentRows(string tableQName)
		{
			return ExceptionBuilder._Data(SR.Format("Cannot proceed with serializing DataTable '{0}'. It contains a DataRow which has multiple parent rows on the same Foreign Key.", tableQName));
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00008369 File Offset: 0x00006569
		public static Exception PolymorphismNotSupported(string typeName)
		{
			return ExceptionBuilder._InvalidOperation(SR.Format("Type '{0}' does not implement IXmlSerializable interface therefore can not proceed with serialization.", typeName));
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000837B File Offset: 0x0000657B
		public static Exception DataTableInferenceNotSupported()
		{
			return ExceptionBuilder._InvalidOperation("DataTable does not support schema inference from Xml.");
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00008387 File Offset: 0x00006587
		internal static void ThrowMultipleTargetConverter(Exception innerException)
		{
			ExceptionBuilder.ThrowDataException((innerException != null) ? "An error occurred with the multiple target converter while writing an Xml Schema.  See the inner exception for details." : "An error occurred with the multiple target converter while writing an Xml Schema.  A null or empty string was returned.", innerException);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000839E File Offset: 0x0000659E
		public static Exception DuplicateDeclaration(string name)
		{
			return ExceptionBuilder._Data(SR.Format("Duplicated declaration '{0}'.", name));
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000083B0 File Offset: 0x000065B0
		public static Exception FoundEntity()
		{
			return ExceptionBuilder._Data("DataSet cannot expand entities. Use XmlValidatingReader and set the EntityHandling property accordingly.");
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000083BC File Offset: 0x000065BC
		public static Exception MergeFailed(string name)
		{
			return ExceptionBuilder._Data(name);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x000083C4 File Offset: 0x000065C4
		public static Exception ConvertFailed(Type type1, Type type2)
		{
			return ExceptionBuilder._Data(SR.Format(" Cannot convert object of type '{0}' to object of type '{1}'.", type1.FullName, type2.FullName));
		}

		// Token: 0x06000274 RID: 628 RVA: 0x000083E1 File Offset: 0x000065E1
		public static Exception InvalidDataTableReader(string tableName)
		{
			return ExceptionBuilder._InvalidOperation(SR.Format("DataTableReader is invalid for current DataTable '{0}'.", tableName));
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000083F3 File Offset: 0x000065F3
		public static Exception DataTableReaderSchemaIsInvalid(string tableName)
		{
			return ExceptionBuilder._InvalidOperation(SR.Format("Schema of current DataTable '{0}' in DataTableReader has changed, DataTableReader is invalid.", tableName));
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00008405 File Offset: 0x00006605
		public static Exception CannotCreateDataReaderOnEmptyDataSet()
		{
			return ExceptionBuilder._Argument("DataTableReader Cannot be created. There is no DataTable in DataSet.");
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00008411 File Offset: 0x00006611
		public static Exception DataTableReaderArgumentIsEmpty()
		{
			return ExceptionBuilder._Argument("Cannot create DataTableReader. Argument is Empty.");
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000841D File Offset: 0x0000661D
		public static Exception ArgumentContainsNullValue()
		{
			return ExceptionBuilder._Argument("Cannot create DataTableReader. Arguments contain null value.");
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00008429 File Offset: 0x00006629
		public static Exception InvalidCurrentRowInDataTableReader()
		{
			return ExceptionBuilder._DeletedRowInaccessible("Current DataRow is either in Deleted or Detached state.");
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00008435 File Offset: 0x00006635
		public static Exception EmptyDataTableReader(string tableName)
		{
			return ExceptionBuilder._DeletedRowInaccessible(SR.Format("Current DataTable '{0}' is empty. There is no DataRow in DataTable.", tableName));
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00008447 File Offset: 0x00006647
		internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr)
		{
			return ExceptionBuilder._Argument(SR.Format("Simple type '{0}' has already be declared with different '{1}'.", stName, errorStr));
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000845A File Offset: 0x0000665A
		internal static Exception InternalRBTreeError(RBTreeError internalError)
		{
			return ExceptionBuilder._InvalidOperation(SR.Format("DataTable internal index is corrupted: '{0}'.", (int)internalError));
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00008471 File Offset: 0x00006671
		public static Exception EnumeratorModified()
		{
			return ExceptionBuilder._InvalidOperation("Collection was modified; enumeration operation might not execute.");
		}
	}
}
