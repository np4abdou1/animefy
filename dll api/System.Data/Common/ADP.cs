using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;

namespace System.Data.Common
{
	// Token: 0x020000CF RID: 207
	internal static class ADP
	{
		// Token: 0x06000E28 RID: 3624 RVA: 0x00007222 File Offset: 0x00005422
		private static void TraceException(string trace, Exception e)
		{
			if (e != null)
			{
				DataCommonEventSource.Log.Trace<Exception>(trace, e);
			}
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x0004854D File Offset: 0x0004674D
		internal static void TraceExceptionAsReturnValue(Exception e)
		{
			ADP.TraceException("<comm.ADP.TraceException|ERR|THROW> '{0}'", e);
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x0004855A File Offset: 0x0004675A
		internal static void TraceExceptionWithoutRethrow(Exception e)
		{
			ADP.TraceException("<comm.ADP.TraceException|ERR|CATCH> '%ls'\n", e);
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00048567 File Offset: 0x00046767
		internal static ArgumentException Argument(string error)
		{
			ArgumentException ex = new ArgumentException(error);
			ADP.TraceExceptionAsReturnValue(ex);
			return ex;
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00048575 File Offset: 0x00046775
		internal static ArgumentException Argument(string error, string parameter)
		{
			ArgumentException ex = new ArgumentException(error, parameter);
			ADP.TraceExceptionAsReturnValue(ex);
			return ex;
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00048584 File Offset: 0x00046784
		internal static ArgumentNullException ArgumentNull(string parameter)
		{
			ArgumentNullException ex = new ArgumentNullException(parameter);
			ADP.TraceExceptionAsReturnValue(ex);
			return ex;
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x00048592 File Offset: 0x00046792
		internal static ArgumentNullException ArgumentNull(string parameter, string error)
		{
			ArgumentNullException ex = new ArgumentNullException(parameter, error);
			ADP.TraceExceptionAsReturnValue(ex);
			return ex;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x000485A1 File Offset: 0x000467A1
		internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName)
		{
			ArgumentOutOfRangeException ex = new ArgumentOutOfRangeException(parameterName);
			ADP.TraceExceptionAsReturnValue(ex);
			return ex;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x000485AF File Offset: 0x000467AF
		internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName)
		{
			ArgumentOutOfRangeException ex = new ArgumentOutOfRangeException(parameterName, message);
			ADP.TraceExceptionAsReturnValue(ex);
			return ex;
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x000485BE File Offset: 0x000467BE
		internal static IndexOutOfRangeException IndexOutOfRange(string error)
		{
			IndexOutOfRangeException ex = new IndexOutOfRangeException(error);
			ADP.TraceExceptionAsReturnValue(ex);
			return ex;
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x000485CC File Offset: 0x000467CC
		internal static InvalidCastException InvalidCast(string error)
		{
			return ADP.InvalidCast(error, null);
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x000485D5 File Offset: 0x000467D5
		internal static InvalidCastException InvalidCast(string error, Exception inner)
		{
			InvalidCastException ex = new InvalidCastException(error, inner);
			ADP.TraceExceptionAsReturnValue(ex);
			return ex;
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x000485E4 File Offset: 0x000467E4
		internal static InvalidOperationException InvalidOperation(string error)
		{
			InvalidOperationException ex = new InvalidOperationException(error);
			ADP.TraceExceptionAsReturnValue(ex);
			return ex;
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x000485F2 File Offset: 0x000467F2
		internal static NotSupportedException NotSupported()
		{
			NotSupportedException ex = new NotSupportedException();
			ADP.TraceExceptionAsReturnValue(ex);
			return ex;
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x000485FF File Offset: 0x000467FF
		internal static NotSupportedException NotSupported(string error)
		{
			NotSupportedException ex = new NotSupportedException(error);
			ADP.TraceExceptionAsReturnValue(ex);
			return ex;
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x0004860D File Offset: 0x0004680D
		internal static InvalidOperationException DataAdapter(string error)
		{
			return ADP.InvalidOperation(error);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00048615 File Offset: 0x00046815
		internal static void CheckArgumentNull(object value, string parameterName)
		{
			if (value == null)
			{
				throw ADP.ArgumentNull(parameterName);
			}
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00048624 File Offset: 0x00046824
		internal static bool IsCatchableExceptionType(Exception e)
		{
			Type type = e.GetType();
			return type != ADP.s_stackOverflowType && type != ADP.s_outOfMemoryType && type != ADP.s_threadAbortType && type != ADP.s_nullReferenceType && type != ADP.s_accessViolationType && !ADP.s_securityType.IsAssignableFrom(type);
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0004868C File Offset: 0x0004688C
		internal static bool IsCatchableOrSecurityExceptionType(Exception e)
		{
			Type type = e.GetType();
			return type != ADP.s_stackOverflowType && type != ADP.s_outOfMemoryType && type != ADP.s_threadAbortType && type != ADP.s_nullReferenceType && type != ADP.s_accessViolationType;
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x000486E1 File Offset: 0x000468E1
		internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value)
		{
			return ADP.ArgumentOutOfRange(SR.Format("The {0} enumeration value, {1}, is invalid.", type.Name, value.ToString(CultureInfo.InvariantCulture)), type.Name);
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x0004870A File Offset: 0x0004690A
		internal static ArgumentException CollectionRemoveInvalidObject(Type itemType, ICollection collection)
		{
			return ADP.Argument(SR.Format("Attempted to remove an {0} that is not contained by this {1}.", itemType.Name, collection.GetType().Name));
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x0004872C File Offset: 0x0004692C
		internal static ArgumentNullException CollectionNullValue(string parameter, Type collection, Type itemType)
		{
			return ADP.ArgumentNull(parameter, SR.Format("The {0} only accepts non-null {1} type objects.", collection.Name, itemType.Name));
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0004874A File Offset: 0x0004694A
		internal static IndexOutOfRangeException CollectionIndexInt32(int index, Type collection, int count)
		{
			return ADP.IndexOutOfRange(SR.Format("Invalid index {0} for this {1} with Count={2}.", index.ToString(CultureInfo.InvariantCulture), collection.Name, count.ToString(CultureInfo.InvariantCulture)));
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00048779 File Offset: 0x00046979
		internal static InvalidCastException CollectionInvalidType(Type collection, Type itemType, object invalidValue)
		{
			return ADP.InvalidCast(SR.Format("The {0} only accepts non-null {1} type objects, not {2} objects.", collection.Name, itemType.Name, invalidValue.GetType().Name));
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x000487A1 File Offset: 0x000469A1
		internal static Exception StreamClosed([CallerMemberName] string method = "")
		{
			return ADP.InvalidOperation(SR.Format("Invalid attempt to {0} when stream is closed.", method));
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x000487B3 File Offset: 0x000469B3
		internal static ArgumentException ParametersIsNotParent(Type parameterType, ICollection collection)
		{
			return ADP.Argument(SR.Format("The {0} is already contained by another {1}.", parameterType.Name, collection.GetType().Name));
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x000487B3 File Offset: 0x000469B3
		internal static ArgumentException ParametersIsParent(Type parameterType, ICollection collection)
		{
			return ADP.Argument(SR.Format("The {0} is already contained by another {1}.", parameterType.Name, collection.GetType().Name));
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x000487D5 File Offset: 0x000469D5
		internal static Exception DataReaderClosed([CallerMemberName] string method = "")
		{
			return ADP.InvalidOperation(SR.Format("Invalid attempt to call {0} when reader is closed.", method));
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x000487E7 File Offset: 0x000469E7
		internal static int DstCompare(string strA, string strB)
		{
			return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, strB, CompareOptions.IgnoreCase | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x000487FC File Offset: 0x000469FC
		internal static Exception InvalidSeekOrigin(string parameterName)
		{
			return ADP.ArgumentOutOfRange("Specified SeekOrigin value is invalid.", parameterName);
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x00048809 File Offset: 0x00046A09
		internal static void TraceExceptionForCapture(Exception e)
		{
			ADP.TraceException("<comm.ADP.TraceException|ERR|CATCH> '{0}'", e);
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00048816 File Offset: 0x00046A16
		internal static void CheckArgumentLength(Array value, string parameterName)
		{
			ADP.CheckArgumentNull(value, parameterName);
			if (value.Length == 0)
			{
				throw ADP.Argument(SR.Format("Expecting non-empty array for '{0}' parameter.", parameterName));
			}
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00048838 File Offset: 0x00046A38
		internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value)
		{
			return ADP.InvalidEnumerationValue(typeof(AcceptRejectRule), (int)value);
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0004884A File Offset: 0x00046A4A
		internal static ArgumentOutOfRangeException InvalidLoadOption(LoadOption value)
		{
			return ADP.InvalidEnumerationValue(typeof(LoadOption), (int)value);
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x0004885C File Offset: 0x00046A5C
		internal static ArgumentOutOfRangeException InvalidMissingMappingAction(MissingMappingAction value)
		{
			return ADP.InvalidEnumerationValue(typeof(MissingMappingAction), (int)value);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x0004886E File Offset: 0x00046A6E
		internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value)
		{
			return ADP.InvalidEnumerationValue(typeof(MissingSchemaAction), (int)value);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00048880 File Offset: 0x00046A80
		internal static ArgumentOutOfRangeException InvalidRule(Rule value)
		{
			return ADP.InvalidEnumerationValue(typeof(Rule), (int)value);
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00048892 File Offset: 0x00046A92
		internal static ArgumentOutOfRangeException InvalidSchemaType(SchemaType value)
		{
			return ADP.InvalidEnumerationValue(typeof(SchemaType), (int)value);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x000488A4 File Offset: 0x00046AA4
		internal static Exception WrongType(Type got, Type expected)
		{
			return ADP.Argument(SR.Format("Expecting argument of type {1}, but received type {0}.", got.ToString(), expected.ToString()));
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x000488C1 File Offset: 0x00046AC1
		internal static Exception CollectionUniqueValue(Type itemType, string propertyName, string propertyValue)
		{
			return ADP.Argument(SR.Format("The {0}.{1} is required to be unique, '{2}' already exists in the collection.", itemType.Name, propertyName, propertyValue));
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x0004860D File Offset: 0x0004680D
		private static InvalidOperationException DataMapping(string error)
		{
			return ADP.InvalidOperation(error);
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x000488DA File Offset: 0x00046ADA
		internal static InvalidOperationException ColumnSchemaExpression(string srcColumn, string cacheColumn)
		{
			return ADP.DataMapping(SR.Format("The column mapping from SourceColumn '{0}' failed because the DataColumn '{1}' is a computed column.", srcColumn, cacheColumn));
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x000488ED File Offset: 0x00046AED
		internal static InvalidOperationException ColumnSchemaMismatch(string srcColumn, Type srcType, DataColumn column)
		{
			return ADP.DataMapping(SR.Format("Inconvertible type mismatch between SourceColumn '{0}' of {1} and the DataColumn '{2}' of {3}.", new object[]
			{
				srcColumn,
				srcType.Name,
				column.ColumnName,
				column.DataType.Name
			}));
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00048928 File Offset: 0x00046B28
		internal static InvalidOperationException ColumnSchemaMissing(string cacheColumn, string tableName, string srcColumn)
		{
			if (string.IsNullOrEmpty(tableName))
			{
				return ADP.InvalidOperation(SR.Format("Missing the DataColumn '{0}' for the SourceColumn '{2}'.", cacheColumn, tableName, srcColumn));
			}
			return ADP.DataMapping(SR.Format("Missing the DataColumn '{0}' in the DataTable '{1}' for the SourceColumn '{2}'.", cacheColumn, tableName, srcColumn));
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00048957 File Offset: 0x00046B57
		internal static InvalidOperationException MissingColumnMapping(string srcColumn)
		{
			return ADP.DataMapping(SR.Format("Missing SourceColumn mapping for '{0}'.", srcColumn));
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00048969 File Offset: 0x00046B69
		internal static InvalidOperationException MissingTableSchema(string cacheTable, string srcTable)
		{
			return ADP.DataMapping(SR.Format("Missing the '{0}' DataTable for the '{1}' SourceTable.", cacheTable, srcTable));
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0004897C File Offset: 0x00046B7C
		internal static InvalidOperationException MissingTableMapping(string srcTable)
		{
			return ADP.DataMapping(SR.Format("Missing SourceTable mapping: '{0}'", srcTable));
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x0004898E File Offset: 0x00046B8E
		internal static InvalidOperationException MissingTableMappingDestination(string dstTable)
		{
			return ADP.DataMapping(SR.Format("Missing TableMapping when TableMapping.DataSetTable='{0}'.", dstTable));
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x000489A0 File Offset: 0x00046BA0
		internal static Exception InvalidSourceColumn(string parameter)
		{
			return ADP.Argument("SourceColumn is required to be a non-empty string.", parameter);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x000489AD File Offset: 0x00046BAD
		internal static Exception ColumnsAddNullAttempt(string parameter)
		{
			return ADP.CollectionNullValue(parameter, typeof(DataColumnMappingCollection), typeof(DataColumnMapping));
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x000489C9 File Offset: 0x00046BC9
		internal static Exception ColumnsIndexInt32(int index, IColumnMappingCollection collection)
		{
			return ADP.CollectionIndexInt32(index, collection.GetType(), collection.Count);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x000489DD File Offset: 0x00046BDD
		internal static Exception ColumnsIsNotParent(ICollection collection)
		{
			return ADP.ParametersIsNotParent(typeof(DataColumnMapping), collection);
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x000489EF File Offset: 0x00046BEF
		internal static Exception ColumnsIsParent(ICollection collection)
		{
			return ADP.ParametersIsParent(typeof(DataColumnMapping), collection);
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x00048A01 File Offset: 0x00046C01
		internal static Exception ColumnsUniqueSourceColumn(string srcColumn)
		{
			return ADP.CollectionUniqueValue(typeof(DataColumnMapping), "SourceColumn", srcColumn);
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00048A18 File Offset: 0x00046C18
		internal static Exception NotADataColumnMapping(object value)
		{
			return ADP.CollectionInvalidType(typeof(DataColumnMappingCollection), typeof(DataColumnMapping), value);
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00048A34 File Offset: 0x00046C34
		internal static Exception InvalidSourceTable(string parameter)
		{
			return ADP.Argument("SourceTable is required to be a non-empty string", parameter);
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00048A41 File Offset: 0x00046C41
		internal static Exception TablesAddNullAttempt(string parameter)
		{
			return ADP.CollectionNullValue(parameter, typeof(DataTableMappingCollection), typeof(DataTableMapping));
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x000489C9 File Offset: 0x00046BC9
		internal static Exception TablesIndexInt32(int index, ITableMappingCollection collection)
		{
			return ADP.CollectionIndexInt32(index, collection.GetType(), collection.Count);
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00048A5D File Offset: 0x00046C5D
		internal static Exception TablesIsNotParent(ICollection collection)
		{
			return ADP.ParametersIsNotParent(typeof(DataTableMapping), collection);
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00048A6F File Offset: 0x00046C6F
		internal static Exception TablesIsParent(ICollection collection)
		{
			return ADP.ParametersIsParent(typeof(DataTableMapping), collection);
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00048A81 File Offset: 0x00046C81
		internal static Exception TablesUniqueSourceTable(string srcTable)
		{
			return ADP.CollectionUniqueValue(typeof(DataTableMapping), "SourceTable", srcTable);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00048A98 File Offset: 0x00046C98
		internal static Exception NotADataTableMapping(object value)
		{
			return ADP.CollectionInvalidType(typeof(DataTableMappingCollection), typeof(DataTableMapping), value);
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00048AB4 File Offset: 0x00046CB4
		internal static Exception FillRequires(string parameter)
		{
			return ADP.ArgumentNull(parameter);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00048ABC File Offset: 0x00046CBC
		internal static Exception FillChapterAutoIncrement()
		{
			return ADP.InvalidOperation("Hierarchical chapter columns must map to an AutoIncrement DataColumn.");
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00048AC8 File Offset: 0x00046CC8
		internal static InvalidOperationException MissingDataReaderFieldType(int index)
		{
			return ADP.DataAdapter(SR.Format("DataReader.GetFieldType({0}) returned null.", index));
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00048AE0 File Offset: 0x00046CE0
		internal static void BuildSchemaTableInfoTableNames(string[] columnNameArray)
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>(columnNameArray.Length);
			int num = columnNameArray.Length;
			int num2 = columnNameArray.Length - 1;
			while (0 <= num2)
			{
				string text = columnNameArray[num2];
				if (text != null && 0 < text.Length)
				{
					text = text.ToLower(CultureInfo.InvariantCulture);
					int val;
					if (dictionary.TryGetValue(text, out val))
					{
						num = Math.Min(num, val);
					}
					dictionary[text] = num2;
				}
				else
				{
					columnNameArray[num2] = string.Empty;
					num = num2;
				}
				num2--;
			}
			int uniqueIndex = 1;
			for (int i = num; i < columnNameArray.Length; i++)
			{
				string text2 = columnNameArray[i];
				if (text2.Length == 0)
				{
					columnNameArray[i] = "Column";
					uniqueIndex = ADP.GenerateUniqueName(dictionary, ref columnNameArray[i], i, uniqueIndex);
				}
				else
				{
					text2 = text2.ToLower(CultureInfo.InvariantCulture);
					if (i != dictionary[text2])
					{
						ADP.GenerateUniqueName(dictionary, ref columnNameArray[i], i, 1);
					}
				}
			}
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00048BC4 File Offset: 0x00046DC4
		private static int GenerateUniqueName(Dictionary<string, int> hash, ref string columnName, int index, int uniqueIndex)
		{
			string text;
			for (;;)
			{
				text = columnName + uniqueIndex.ToString(CultureInfo.InvariantCulture);
				string key = text.ToLower(CultureInfo.InvariantCulture);
				if (hash.TryAdd(key, index))
				{
					break;
				}
				uniqueIndex++;
			}
			columnName = text;
			return uniqueIndex;
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00048C08 File Offset: 0x00046E08
		internal static int SrcCompare(string strA, string strB)
		{
			if (!(strA == strB))
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x0400047E RID: 1150
		private static readonly Type s_stackOverflowType = typeof(StackOverflowException);

		// Token: 0x0400047F RID: 1151
		private static readonly Type s_outOfMemoryType = typeof(OutOfMemoryException);

		// Token: 0x04000480 RID: 1152
		private static readonly Type s_threadAbortType = typeof(ThreadAbortException);

		// Token: 0x04000481 RID: 1153
		private static readonly Type s_nullReferenceType = typeof(NullReferenceException);

		// Token: 0x04000482 RID: 1154
		private static readonly Type s_accessViolationType = typeof(AccessViolationException);

		// Token: 0x04000483 RID: 1155
		private static readonly Type s_securityType = typeof(SecurityException);

		// Token: 0x04000484 RID: 1156
		internal static readonly string StrEmpty = "";

		// Token: 0x04000485 RID: 1157
		internal static readonly string[] AzureSqlServerEndpoints = new string[]
		{
			SR.GetString(".database.windows.net"),
			SR.GetString(".database.cloudapi.de"),
			SR.GetString(".database.usgovcloudapi.net"),
			SR.GetString(".database.chinacloudapi.cn")
		};

		// Token: 0x04000486 RID: 1158
		internal static readonly IntPtr PtrZero = new IntPtr(0);

		// Token: 0x04000487 RID: 1159
		internal static readonly int PtrSize = IntPtr.Size;
	}
}
