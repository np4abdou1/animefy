using System;
using System.Runtime.Serialization;
using System.Text;

namespace System.Reflection
{
	/// <summary>The exception that is thrown by the <see cref="M:System.Reflection.Module.GetTypes" /> method if any of the classes in a module cannot be loaded. This class cannot be inherited.</summary>
	// Token: 0x020004B6 RID: 1206
	[Serializable]
	public sealed class ReflectionTypeLoadException : SystemException, ISerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.ReflectionTypeLoadException" /> class with the given classes and their associated exceptions.</summary>
		/// <param name="classes">An array of type <see langword="Type" /> containing the classes that were defined in the module and loaded. This array can contain null reference (<see langword="Nothing" /> in Visual Basic) values. </param>
		/// <param name="exceptions">An array of type <see langword="Exception" /> containing the exceptions that were thrown by the class loader. The null reference (<see langword="Nothing" /> in Visual Basic) values in the <paramref name="classes" /> array line up with the exceptions in this <paramref name="exceptions" /> array. </param>
		// Token: 0x060021A9 RID: 8617 RVA: 0x0008A860 File Offset: 0x00088A60
		public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions) : base(null)
		{
			this.<Types>k__BackingField = classes;
			this.LoaderExceptions = exceptions;
			base.HResult = -2146232830;
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x0008A882 File Offset: 0x00088A82
		private ReflectionTypeLoadException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.LoaderExceptions = (Exception[])info.GetValue("Exceptions", typeof(Exception[]));
		}

		/// <summary>Provides an <see cref="T:System.Runtime.Serialization.ISerializable" /> implementation for serialized objects.</summary>
		/// <param name="info">The information and data needed to serialize or deserialize an object. </param>
		/// <param name="context">The context for the serialization. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <see langword="info" /> is <see langword="null" />. </exception>
		// Token: 0x060021AB RID: 8619 RVA: 0x0008A8AC File Offset: 0x00088AAC
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("Types", null, typeof(Type[]));
			info.AddValue("Exceptions", this.LoaderExceptions, typeof(Exception[]));
		}

		/// <summary>Gets the array of exceptions thrown by the class loader.</summary>
		/// <returns>An array of type <see langword="Exception" /> containing the exceptions thrown by the class loader. The null values in the <see cref="P:System.Reflection.ReflectionTypeLoadException.Types" /> array of this instance line up with the exceptions in this array.</returns>
		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x0008A8E7 File Offset: 0x00088AE7
		public Exception[] LoaderExceptions { get; }

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x0008A8EF File Offset: 0x00088AEF
		public override string Message
		{
			get
			{
				return this.CreateString(true);
			}
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x0008A8F8 File Offset: 0x00088AF8
		public override string ToString()
		{
			return this.CreateString(false);
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x0008A904 File Offset: 0x00088B04
		private string CreateString(bool isMessage)
		{
			string text = isMessage ? base.Message : base.ToString();
			Exception[] loaderExceptions = this.LoaderExceptions;
			if (loaderExceptions == null || loaderExceptions.Length == 0)
			{
				return text;
			}
			StringBuilder stringBuilder = new StringBuilder(text);
			foreach (Exception ex in loaderExceptions)
			{
				if (ex != null)
				{
					stringBuilder.AppendLine();
					stringBuilder.Append(isMessage ? ex.Message : ex.ToString());
				}
			}
			return stringBuilder.ToString();
		}
	}
}
