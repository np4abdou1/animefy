using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000125 RID: 293
	[StackTraceHidden]
	internal static class ThrowHelper
	{
		// Token: 0x06000B47 RID: 2887 RVA: 0x0002F549 File Offset: 0x0002D749
		internal static void ThrowArgumentNullException(ExceptionArgument argument)
		{
			throw ThrowHelper.CreateArgumentNullException(argument);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x0002F551 File Offset: 0x0002D751
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Exception CreateArgumentNullException(ExceptionArgument argument)
		{
			return new ArgumentNullException(argument.ToString());
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0002F565 File Offset: 0x0002D765
		internal static void ThrowArrayTypeMismatchException()
		{
			throw ThrowHelper.CreateArrayTypeMismatchException();
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0002F56C File Offset: 0x0002D76C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Exception CreateArrayTypeMismatchException()
		{
			return new ArrayTypeMismatchException();
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0002F573 File Offset: 0x0002D773
		internal static void ThrowArgumentException_DestinationTooShort()
		{
			throw ThrowHelper.CreateArgumentException_DestinationTooShort();
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0002F57A File Offset: 0x0002D77A
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Exception CreateArgumentException_DestinationTooShort()
		{
			return new ArgumentException("Destination is too short.");
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0002F586 File Offset: 0x0002D786
		internal static void ThrowIndexOutOfRangeException()
		{
			throw ThrowHelper.CreateIndexOutOfRangeException();
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0002F58D File Offset: 0x0002D78D
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Exception CreateIndexOutOfRangeException()
		{
			return new IndexOutOfRangeException();
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0002F594 File Offset: 0x0002D794
		internal static void ThrowArgumentOutOfRangeException()
		{
			throw ThrowHelper.CreateArgumentOutOfRangeException();
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0002F59B File Offset: 0x0002D79B
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Exception CreateArgumentOutOfRangeException()
		{
			return new ArgumentOutOfRangeException();
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0002F5A2 File Offset: 0x0002D7A2
		internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument)
		{
			throw ThrowHelper.CreateArgumentOutOfRangeException(argument);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0002F5AA File Offset: 0x0002D7AA
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument)
		{
			return new ArgumentOutOfRangeException(argument.ToString());
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0002F5BE File Offset: 0x0002D7BE
		internal static void ThrowNotSupportedException()
		{
			throw ThrowHelper.CreateThrowNotSupportedException();
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0002F5C5 File Offset: 0x0002D7C5
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Exception CreateThrowNotSupportedException()
		{
			return new NotSupportedException();
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0002F5CC File Offset: 0x0002D7CC
		internal static void ThrowWrongKeyTypeArgumentException(object key, Type targetType)
		{
			throw new ArgumentException(Environment.GetResourceString("The value \"{0}\" is not of type \"{1}\" and cannot be used in this generic collection.", new object[]
			{
				key,
				targetType
			}), "key");
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0002F5F0 File Offset: 0x0002D7F0
		internal static void ThrowWrongValueTypeArgumentException(object value, Type targetType)
		{
			throw new ArgumentException(Environment.GetResourceString("The value \"{0}\" is not of type \"{1}\" and cannot be used in this generic collection.", new object[]
			{
				value,
				targetType
			}), "value");
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0002F614 File Offset: 0x0002D814
		internal static void ThrowArgumentException(ExceptionResource resource)
		{
			throw new ArgumentException(Environment.GetResourceString(ThrowHelper.GetResourceName(resource)));
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0002F626 File Offset: 0x0002D826
		internal static void ThrowArgumentException(ExceptionResource resource, ExceptionArgument argument)
		{
			throw new ArgumentException(Environment.GetResourceString(ThrowHelper.GetResourceName(resource)), ThrowHelper.GetArgumentName(argument));
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0002F63E File Offset: 0x0002D83E
		internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource)
		{
			if (CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
			{
				throw new ArgumentOutOfRangeException(ThrowHelper.GetArgumentName(argument), string.Empty);
			}
			throw new ArgumentOutOfRangeException(ThrowHelper.GetArgumentName(argument), Environment.GetResourceString(ThrowHelper.GetResourceName(resource)));
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0002F66E File Offset: 0x0002D86E
		internal static void ThrowInvalidOperationException(ExceptionResource resource)
		{
			throw new InvalidOperationException(Environment.GetResourceString(ThrowHelper.GetResourceName(resource)));
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0002F680 File Offset: 0x0002D880
		internal static void ThrowSerializationException(ExceptionResource resource)
		{
			throw new SerializationException(Environment.GetResourceString(ThrowHelper.GetResourceName(resource)));
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0002F692 File Offset: 0x0002D892
		internal static void ThrowNotSupportedException(ExceptionResource resource)
		{
			throw new NotSupportedException(Environment.GetResourceString(ThrowHelper.GetResourceName(resource)));
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0002F6A4 File Offset: 0x0002D8A4
		internal static void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
		{
			throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0002F6B0 File Offset: 0x0002D8B0
		internal static void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen()
		{
			throw new InvalidOperationException("Enumeration has either not started or has already finished.");
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0002F6BC File Offset: 0x0002D8BC
		internal static void ThrowInvalidOperationException_InvalidOperation_EnumNotStarted()
		{
			throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0002F6C8 File Offset: 0x0002D8C8
		internal static void ThrowInvalidOperationException_InvalidOperation_EnumEnded()
		{
			throw new InvalidOperationException("Enumeration already finished.");
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0002F6D4 File Offset: 0x0002D8D4
		internal static void ThrowInvalidOperationException_InvalidOperation_NoValue()
		{
			throw new InvalidOperationException("Nullable object must have a value.");
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0002F6E0 File Offset: 0x0002D8E0
		private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, string resource)
		{
			return new ArgumentOutOfRangeException(ThrowHelper.GetArgumentName(argument), resource);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0002F6EE File Offset: 0x0002D8EE
		internal static void ThrowArgumentOutOfRange_IndexException()
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(ExceptionArgument.index, "Index was out of range. Must be non-negative and less than the size of the collection.");
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0002F6FC File Offset: 0x0002D8FC
		internal static void ThrowIndexArgumentOutOfRange_NeedNonNegNumException()
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(ExceptionArgument.index, "Non-negative number required.");
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0002F70A File Offset: 0x0002D90A
		internal static void ThrowArgumentException_Argument_InvalidArrayType()
		{
			throw new ArgumentException("Target array type is not compatible with the type of items in the collection.");
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0002F716 File Offset: 0x0002D916
		private static ArgumentException GetAddingDuplicateWithKeyArgumentException(object key)
		{
			return new ArgumentException(SR.Format("An item with the same key has already been added. Key: {0}", key));
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x0002F728 File Offset: 0x0002D928
		internal static void ThrowAddingDuplicateWithKeyArgumentException(object key)
		{
			throw ThrowHelper.GetAddingDuplicateWithKeyArgumentException(key);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0002F730 File Offset: 0x0002D930
		private static KeyNotFoundException GetKeyNotFoundException(object key)
		{
			throw new KeyNotFoundException(SR.Format("The given key '{0}' was not present in the dictionary.", key.ToString()));
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0002F747 File Offset: 0x0002D947
		internal static void ThrowKeyNotFoundException(object key)
		{
			throw ThrowHelper.GetKeyNotFoundException(key);
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0002F74F File Offset: 0x0002D94F
		internal static void ThrowInvalidTypeWithPointersNotSupported(Type targetType)
		{
			throw new ArgumentException(SR.Format("Cannot use type '{0}'. Only value types without pointers or references are supported.", targetType));
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0002F761 File Offset: 0x0002D961
		internal static void ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
		{
			throw ThrowHelper.GetInvalidOperationException("Operations that change non-concurrent collections must have exclusive access. A concurrent update was performed on this collection and corrupted its state. The collection's state is no longer correct.");
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0002F76D File Offset: 0x0002D96D
		internal static InvalidOperationException GetInvalidOperationException(string str)
		{
			return new InvalidOperationException(str);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0002F775 File Offset: 0x0002D975
		internal static void ThrowArraySegmentCtorValidationFailedExceptions(Array array, int offset, int count)
		{
			throw ThrowHelper.GetArraySegmentCtorValidationFailedException(array, offset, count);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0002F77F File Offset: 0x0002D97F
		private static Exception GetArraySegmentCtorValidationFailedException(Array array, int offset, int count)
		{
			if (array == null)
			{
				return ThrowHelper.GetArgumentNullException(ExceptionArgument.array);
			}
			if (offset < 0)
			{
				return ThrowHelper.GetArgumentOutOfRangeException(ExceptionArgument.offset, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (count < 0)
			{
				return ThrowHelper.GetArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			return ThrowHelper.GetArgumentException(ExceptionResource.Argument_InvalidOffLen);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0002F7AC File Offset: 0x0002D9AC
		private static ArgumentException GetArgumentException(ExceptionResource resource)
		{
			return new ArgumentException(resource.ToString());
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0002F7C0 File Offset: 0x0002D9C0
		private static ArgumentNullException GetArgumentNullException(ExceptionArgument argument)
		{
			return new ArgumentNullException(ThrowHelper.GetArgumentName(argument));
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0002F7D0 File Offset: 0x0002D9D0
		internal static void IfNullAndNullsAreIllegalThenThrow<T>(object value, ExceptionArgument argName)
		{
			if (value == null && default(T) != null)
			{
				ThrowHelper.ThrowArgumentNullException(argName);
			}
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0002F7F8 File Offset: 0x0002D9F8
		internal static string GetArgumentName(ExceptionArgument argument)
		{
			string result;
			switch (argument)
			{
			case ExceptionArgument.obj:
				result = "obj";
				break;
			case ExceptionArgument.dictionary:
				result = "dictionary";
				break;
			case ExceptionArgument.dictionaryCreationThreshold:
				result = "dictionaryCreationThreshold";
				break;
			case ExceptionArgument.array:
				result = "array";
				break;
			case ExceptionArgument.info:
				result = "info";
				break;
			case ExceptionArgument.key:
				result = "key";
				break;
			case ExceptionArgument.collection:
				result = "collection";
				break;
			case ExceptionArgument.list:
				result = "list";
				break;
			case ExceptionArgument.match:
				result = "match";
				break;
			case ExceptionArgument.converter:
				result = "converter";
				break;
			case ExceptionArgument.queue:
				result = "queue";
				break;
			case ExceptionArgument.stack:
				result = "stack";
				break;
			case ExceptionArgument.capacity:
				result = "capacity";
				break;
			case ExceptionArgument.index:
				result = "index";
				break;
			case ExceptionArgument.startIndex:
				result = "startIndex";
				break;
			case ExceptionArgument.value:
				result = "value";
				break;
			case ExceptionArgument.count:
				result = "count";
				break;
			case ExceptionArgument.arrayIndex:
				result = "arrayIndex";
				break;
			case ExceptionArgument.name:
				result = "name";
				break;
			case ExceptionArgument.mode:
				result = "mode";
				break;
			case ExceptionArgument.item:
				result = "item";
				break;
			case ExceptionArgument.options:
				result = "options";
				break;
			case ExceptionArgument.view:
				result = "view";
				break;
			case ExceptionArgument.sourceBytesToCopy:
				result = "sourceBytesToCopy";
				break;
			default:
				return string.Empty;
			}
			return result;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0002F951 File Offset: 0x0002DB51
		private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource)
		{
			return new ArgumentOutOfRangeException(ThrowHelper.GetArgumentName(argument), resource.ToString());
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0002F96B File Offset: 0x0002DB6B
		internal static void ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index()
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0002F976 File Offset: 0x0002DB76
		internal static void ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count()
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_Count);
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0002F984 File Offset: 0x0002DB84
		internal static string GetResourceName(ExceptionResource resource)
		{
			string result;
			switch (resource)
			{
			case ExceptionResource.Argument_ImplementIComparable:
				result = "At least one object must implement IComparable.";
				break;
			case ExceptionResource.Argument_InvalidType:
				result = "The type of arguments passed into generic comparer methods is invalid.";
				break;
			case ExceptionResource.Argument_InvalidArgumentForComparison:
				result = "Type of argument is not compatible with the generic comparer.";
				break;
			case ExceptionResource.Argument_InvalidRegistryKeyPermissionCheck:
				result = "The specified RegistryKeyPermissionCheck value is invalid.";
				break;
			case ExceptionResource.ArgumentOutOfRange_NeedNonNegNum:
				result = "Non-negative number required.";
				break;
			case ExceptionResource.Arg_ArrayPlusOffTooSmall:
				result = "Destination array is not long enough to copy all the items in the collection. Check array index and length.";
				break;
			case ExceptionResource.Arg_NonZeroLowerBound:
				result = "The lower bound of target array must be zero.";
				break;
			case ExceptionResource.Arg_RankMultiDimNotSupported:
				result = "Only single dimensional arrays are supported for the requested action.";
				break;
			case ExceptionResource.Arg_RegKeyDelHive:
				result = "Cannot delete a registry hive's subtree.";
				break;
			case ExceptionResource.Arg_RegKeyStrLenBug:
				result = "Registry key names should not be greater than 255 characters.";
				break;
			case ExceptionResource.Arg_RegSetStrArrNull:
				result = "RegistryKey.SetValue does not allow a String[] that contains a null String reference.";
				break;
			case ExceptionResource.Arg_RegSetMismatchedKind:
				result = "The type of the value object did not match the specified RegistryValueKind or the object could not be properly converted.";
				break;
			case ExceptionResource.Arg_RegSubKeyAbsent:
				result = "Cannot delete a subkey tree because the subkey does not exist.";
				break;
			case ExceptionResource.Arg_RegSubKeyValueAbsent:
				result = "No value exists with that name.";
				break;
			case ExceptionResource.Argument_AddingDuplicate:
				result = "An item with the same key has already been added.";
				break;
			case ExceptionResource.Serialization_InvalidOnDeser:
				result = "OnDeserialization method was called while the object was not being deserialized.";
				break;
			case ExceptionResource.Serialization_MissingKeys:
				result = "The Keys for this Hashtable are missing.";
				break;
			case ExceptionResource.Serialization_NullKey:
				result = "One of the serialized keys is null.";
				break;
			case ExceptionResource.Argument_InvalidArrayType:
				result = "Target array type is not compatible with the type of items in the collection.";
				break;
			case ExceptionResource.NotSupported_KeyCollectionSet:
				result = "Mutating a key collection derived from a dictionary is not allowed.";
				break;
			case ExceptionResource.NotSupported_ValueCollectionSet:
				result = "Mutating a value collection derived from a dictionary is not allowed.";
				break;
			case ExceptionResource.ArgumentOutOfRange_SmallCapacity:
				result = "capacity was less than the current size.";
				break;
			case ExceptionResource.ArgumentOutOfRange_Index:
				result = "Index was out of range. Must be non-negative and less than the size of the collection.";
				break;
			case ExceptionResource.Argument_InvalidOffLen:
				result = "Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.";
				break;
			case ExceptionResource.Argument_ItemNotExist:
				result = "The specified item does not exist in this KeyedCollection.";
				break;
			case ExceptionResource.ArgumentOutOfRange_Count:
				result = "Count must be positive and count must refer to a location within the string/array/collection.";
				break;
			case ExceptionResource.ArgumentOutOfRange_InvalidThreshold:
				result = "The specified threshold for creating dictionary is out of range.";
				break;
			case ExceptionResource.ArgumentOutOfRange_ListInsert:
				result = "Index must be within the bounds of the List.";
				break;
			case ExceptionResource.NotSupported_ReadOnlyCollection:
				result = "Collection is read-only.";
				break;
			case ExceptionResource.InvalidOperation_CannotRemoveFromStackOrQueue:
				result = "Removal is an invalid operation for Stack or Queue.";
				break;
			case ExceptionResource.InvalidOperation_EmptyQueue:
				result = "Queue empty.";
				break;
			case ExceptionResource.InvalidOperation_EnumOpCantHappen:
				result = "Enumeration has either not started or has already finished.";
				break;
			case ExceptionResource.InvalidOperation_EnumFailedVersion:
				result = "Collection was modified; enumeration operation may not execute.";
				break;
			case ExceptionResource.InvalidOperation_EmptyStack:
				result = "Stack empty.";
				break;
			case ExceptionResource.ArgumentOutOfRange_BiggerThanCollection:
				result = "Larger than collection size.";
				break;
			case ExceptionResource.InvalidOperation_EnumNotStarted:
				result = "Enumeration has not started. Call MoveNext.";
				break;
			case ExceptionResource.InvalidOperation_EnumEnded:
				result = "Enumeration already finished.";
				break;
			case ExceptionResource.NotSupported_SortedListNestedWrite:
				result = "This operation is not supported on SortedList nested types because they require modifying the original SortedList.";
				break;
			case ExceptionResource.InvalidOperation_NoValue:
				result = "Nullable object must have a value.";
				break;
			case ExceptionResource.InvalidOperation_RegRemoveSubKey:
				result = "Registry key has subkeys and recursive removes are not supported by this method.";
				break;
			case ExceptionResource.Security_RegistryPermission:
				result = "Requested registry access is not allowed.";
				break;
			case ExceptionResource.UnauthorizedAccess_RegistryNoWrite:
				result = "Cannot write to the registry key.";
				break;
			case ExceptionResource.ObjectDisposed_RegKeyClosed:
				result = "Cannot access a closed registry key.";
				break;
			case ExceptionResource.NotSupported_InComparableType:
				result = "A type must implement IComparable<T> or IComparable to support comparison.";
				break;
			case ExceptionResource.Argument_InvalidRegistryOptionsCheck:
				result = "The specified RegistryOptions value is invalid.";
				break;
			case ExceptionResource.Argument_InvalidRegistryViewCheck:
				result = "The specified RegistryView value is invalid.";
				break;
			default:
				return string.Empty;
			}
			return result;
		}
	}
}
