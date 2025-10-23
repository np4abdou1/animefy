using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Provides a static method to create a <see cref="T:System.FormattableString" /> object from a composite format string and its arguments. </summary>
	// Token: 0x02000445 RID: 1093
	public static class FormattableStringFactory
	{
		/// <summary>Creates a <see cref="T:System.FormattableString" /> instance from a composite format string and its arguments. </summary>
		/// <param name="format">A composite format string. </param>
		/// <param name="arguments">The arguments whose string representations are to be inserted in the result string. </param>
		/// <returns>The object that represents the composite format string and its arguments. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="format" /> is <see langword="null" />. -or-
		///         <paramref name="arguments" /> is <see langword="null" />. </exception>
		// Token: 0x06002006 RID: 8198 RVA: 0x00087EF3 File Offset: 0x000860F3
		public static FormattableString Create(string format, params object[] arguments)
		{
			if (format == null)
			{
				throw new ArgumentNullException("format");
			}
			if (arguments == null)
			{
				throw new ArgumentNullException("arguments");
			}
			return new FormattableStringFactory.ConcreteFormattableString(format, arguments);
		}

		// Token: 0x02000446 RID: 1094
		private sealed class ConcreteFormattableString : FormattableString
		{
			// Token: 0x06002007 RID: 8199 RVA: 0x00087F18 File Offset: 0x00086118
			internal ConcreteFormattableString(string format, object[] arguments)
			{
				this._format = format;
				this._arguments = arguments;
			}

			// Token: 0x17000402 RID: 1026
			// (get) Token: 0x06002008 RID: 8200 RVA: 0x00087F2E File Offset: 0x0008612E
			public override string Format
			{
				get
				{
					return this._format;
				}
			}

			// Token: 0x06002009 RID: 8201 RVA: 0x00087F36 File Offset: 0x00086136
			public override object[] GetArguments()
			{
				return this._arguments;
			}

			// Token: 0x17000403 RID: 1027
			// (get) Token: 0x0600200A RID: 8202 RVA: 0x00087F3E File Offset: 0x0008613E
			public override int ArgumentCount
			{
				get
				{
					return this._arguments.Length;
				}
			}

			// Token: 0x0600200B RID: 8203 RVA: 0x00087F48 File Offset: 0x00086148
			public override object GetArgument(int index)
			{
				return this._arguments[index];
			}

			// Token: 0x0600200C RID: 8204 RVA: 0x00087F52 File Offset: 0x00086152
			public override string ToString(IFormatProvider formatProvider)
			{
				return string.Format(formatProvider, this._format, this._arguments);
			}

			// Token: 0x04000F44 RID: 3908
			private readonly string _format;

			// Token: 0x04000F45 RID: 3909
			private readonly object[] _arguments;
		}
	}
}
