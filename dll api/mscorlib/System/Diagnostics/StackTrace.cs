﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Diagnostics
{
	/// <summary>Represents a stack trace, which is an ordered collection of one or more stack frames.</summary>
	// Token: 0x020005C2 RID: 1474
	[ComVisible(true)]
	[Serializable]
	public class StackTrace
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class from the caller's frame.</summary>
		// Token: 0x06002C43 RID: 11331 RVA: 0x000B772B File Offset: 0x000B592B
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackTrace()
		{
			this.init_frames(0, false);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class from the caller's frame, optionally capturing source information.</summary>
		/// <param name="fNeedFileInfo">
		///       <see langword="true" /> to capture the file name, line number, and column number; otherwise, <see langword="false" />. </param>
		// Token: 0x06002C44 RID: 11332 RVA: 0x000B773B File Offset: 0x000B593B
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackTrace(bool fNeedFileInfo)
		{
			this.init_frames(0, fNeedFileInfo);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class from the caller's frame, skipping the specified number of frames and optionally capturing source information.</summary>
		/// <param name="skipFrames">The number of frames up the stack from which to start the trace. </param>
		/// <param name="fNeedFileInfo">
		///       <see langword="true" /> to capture the file name, line number, and column number; otherwise, <see langword="false" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="skipFrames" /> parameter is negative. </exception>
		// Token: 0x06002C45 RID: 11333 RVA: 0x000B774B File Offset: 0x000B594B
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StackTrace(int skipFrames, bool fNeedFileInfo)
		{
			this.init_frames(skipFrames, fNeedFileInfo);
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x000B775C File Offset: 0x000B595C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void init_frames(int skipFrames, bool fNeedFileInfo)
		{
			if (skipFrames < 0)
			{
				throw new ArgumentOutOfRangeException("< 0", "skipFrames");
			}
			List<StackFrame> list = new List<StackFrame>();
			skipFrames += 2;
			StackFrame stackFrame;
			while ((stackFrame = new StackFrame(skipFrames, fNeedFileInfo)) != null && stackFrame.GetMethod() != null)
			{
				list.Add(stackFrame);
				skipFrames++;
			}
			this.debug_info = fNeedFileInfo;
			this.frames = list.ToArray();
		}

		// Token: 0x06002C47 RID: 11335
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo);

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class, using the provided exception object and optionally capturing source information.</summary>
		/// <param name="e">The exception object from which to construct the stack trace. </param>
		/// <param name="fNeedFileInfo">
		///       <see langword="true" /> to capture the file name, line number, and column number; otherwise, <see langword="false" />. </param>
		/// <exception cref="T:System.ArgumentNullException">The parameter <paramref name="e" /> is <see langword="null" />. </exception>
		// Token: 0x06002C48 RID: 11336 RVA: 0x000B77C2 File Offset: 0x000B59C2
		public StackTrace(Exception e, bool fNeedFileInfo) : this(e, 0, fNeedFileInfo)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class using the provided exception object, skipping the specified number of frames and optionally capturing source information.</summary>
		/// <param name="e">The exception object from which to construct the stack trace. </param>
		/// <param name="skipFrames">The number of frames up the stack from which to start the trace. </param>
		/// <param name="fNeedFileInfo">
		///       <see langword="true" /> to capture the file name, line number, and column number; otherwise, <see langword="false" />. </param>
		/// <exception cref="T:System.ArgumentNullException">The parameter <paramref name="e" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="skipFrames" /> parameter is negative. </exception>
		// Token: 0x06002C49 RID: 11337 RVA: 0x000B77D0 File Offset: 0x000B59D0
		public StackTrace(Exception e, int skipFrames, bool fNeedFileInfo)
		{
			if (e == null)
			{
				throw new ArgumentNullException("e");
			}
			if (skipFrames < 0)
			{
				throw new ArgumentOutOfRangeException("< 0", "skipFrames");
			}
			this.frames = StackTrace.get_trace(e, skipFrames, fNeedFileInfo);
			this.captured_traces = e.captured_traces;
		}

		/// <summary>Gets the number of frames in the stack trace.</summary>
		/// <returns>The number of frames in the stack trace. </returns>
		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06002C4A RID: 11338 RVA: 0x000B781F File Offset: 0x000B5A1F
		public virtual int FrameCount
		{
			get
			{
				if (this.frames != null)
				{
					return this.frames.Length;
				}
				return 0;
			}
		}

		/// <summary>Gets the specified stack frame.</summary>
		/// <param name="index">The index of the stack frame requested. </param>
		/// <returns>The specified stack frame.</returns>
		// Token: 0x06002C4B RID: 11339 RVA: 0x000B7833 File Offset: 0x000B5A33
		public virtual StackFrame GetFrame(int index)
		{
			if (index < 0 || index >= this.FrameCount)
			{
				return null;
			}
			return this.frames[index];
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x000B784C File Offset: 0x000B5A4C
		private static string GetAotId()
		{
			if (!StackTrace.isAotidSet)
			{
				byte[] aotId = RuntimeAssembly.GetAotId();
				if (aotId != null)
				{
					StackTrace.aotid = new Guid(aotId).ToString("N");
				}
				StackTrace.isAotidSet = true;
			}
			return StackTrace.aotid;
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x000B788C File Offset: 0x000B5A8C
		private bool AddFrames(StringBuilder sb, bool separator, out bool isAsync)
		{
			isAsync = false;
			bool flag = false;
			int i = 0;
			while (i < this.FrameCount)
			{
				StackFrame frame = this.GetFrame(i);
				if (frame.GetMethod() == null)
				{
					if (flag || separator)
					{
						sb.Append(Environment.NewLine);
					}
					sb.Append("  at ");
					string internalMethodName = frame.GetInternalMethodName();
					if (internalMethodName != null)
					{
						sb.Append(internalMethodName);
						goto IL_180;
					}
					sb.AppendFormat("<0x{0:x5} + 0x{1:x5}> <unknown method>", frame.GetMethodAddress(), frame.GetNativeOffset());
					goto IL_180;
				}
				else
				{
					bool flag2;
					this.GetFullNameForStackTrace(sb, frame.GetMethod(), flag || separator, out flag2, out isAsync);
					if (!flag2)
					{
						if (frame.GetILOffset() == -1)
						{
							sb.AppendFormat(" <0x{0:x5} + 0x{1:x5}>", frame.GetMethodAddress(), frame.GetNativeOffset());
							if (frame.GetMethodIndex() != 16777215U)
							{
								sb.AppendFormat(" {0}", frame.GetMethodIndex());
							}
						}
						else
						{
							sb.AppendFormat(" [0x{0:x5}]", frame.GetILOffset());
						}
						string text = frame.GetSecureFileName();
						if (text[0] == '<')
						{
							string arg = frame.GetMethod().Module.ModuleVersionId.ToString("N");
							string aotId = StackTrace.GetAotId();
							if (frame.GetILOffset() != -1 || aotId == null)
							{
								text = string.Format("<{0}>", arg);
							}
							else
							{
								text = string.Format("<{0}#{1}>", arg, aotId);
							}
						}
						sb.AppendFormat(" in {0}:{1} ", text, frame.GetFileLineNumber());
						goto IL_180;
					}
				}
				IL_182:
				i++;
				continue;
				IL_180:
				flag = true;
				goto IL_182;
			}
			return flag;
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x000B7A2C File Offset: 0x000B5C2C
		private void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi, bool needsNewLine, out bool skipped, out bool isAsync)
		{
			Type type = mi.DeclaringType;
			if (type.IsGenericType && !type.IsGenericTypeDefinition)
			{
				type = type.GetGenericTypeDefinition();
				foreach (MethodInfo methodInfo in type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
				{
					if (methodInfo.MetadataToken == mi.MetadataToken)
					{
						mi = methodInfo;
						break;
					}
				}
			}
			isAsync = typeof(IAsyncStateMachine).IsAssignableFrom(type);
			skipped = (mi.IsDefined(typeof(StackTraceHiddenAttribute)) || type.IsDefined(typeof(StackTraceHiddenAttribute)));
			if (skipped)
			{
				return;
			}
			if (isAsync)
			{
				StackTrace.ConvertAsyncStateMachineMethod(ref mi, ref type);
			}
			if (needsNewLine)
			{
				sb.Append(Environment.NewLine);
			}
			sb.Append("  at ");
			sb.Append(type.ToString());
			sb.Append(".");
			sb.Append(mi.Name);
			if (mi.IsGenericMethod)
			{
				mi = ((MethodInfo)mi).GetGenericMethodDefinition();
				Type[] genericArguments = mi.GetGenericArguments();
				sb.Append("[");
				for (int j = 0; j < genericArguments.Length; j++)
				{
					if (j > 0)
					{
						sb.Append(",");
					}
					sb.Append(genericArguments[j].Name);
				}
				sb.Append("]");
			}
			ParameterInfo[] parameters = mi.GetParameters();
			sb.Append(" (");
			for (int k = 0; k < parameters.Length; k++)
			{
				if (k > 0)
				{
					sb.Append(", ");
				}
				Type type2 = parameters[k].ParameterType;
				if (type2.IsGenericType && !type2.IsGenericTypeDefinition)
				{
					type2 = type2.GetGenericTypeDefinition();
				}
				sb.Append(type2.ToString());
				if (parameters[k].Name != null)
				{
					sb.Append(" ");
					sb.Append(parameters[k].Name);
				}
			}
			sb.Append(")");
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x000B7C20 File Offset: 0x000B5E20
		private static void ConvertAsyncStateMachineMethod(ref MethodBase method, ref Type declaringType)
		{
			Type declaringType2 = declaringType.DeclaringType;
			if (declaringType2 == null)
			{
				return;
			}
			MethodInfo[] methods = declaringType2.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if (methods == null)
			{
				return;
			}
			foreach (MethodInfo methodInfo in methods)
			{
				IEnumerable<AsyncStateMachineAttribute> customAttributes = methodInfo.GetCustomAttributes<AsyncStateMachineAttribute>();
				if (customAttributes != null)
				{
					using (IEnumerator<AsyncStateMachineAttribute> enumerator = customAttributes.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.StateMachineType == declaringType)
							{
								method = methodInfo;
								declaringType = methodInfo.DeclaringType;
								return;
							}
						}
					}
				}
			}
		}

		/// <summary>Builds a readable representation of the stack trace.</summary>
		/// <returns>A readable representation of the stack trace.</returns>
		// Token: 0x06002C50 RID: 11344 RVA: 0x000B7CC4 File Offset: 0x000B5EC4
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = false;
			if (this.captured_traces != null)
			{
				StackTrace[] array = this.captured_traces;
				for (int i = 0; i < array.Length; i++)
				{
					bool flag2;
					flag = array[i].AddFrames(stringBuilder, flag, out flag2);
					if (flag && !flag2)
					{
						stringBuilder.Append(Environment.NewLine);
						stringBuilder.Append("--- End of stack trace from previous location where exception was thrown ---");
						stringBuilder.Append(Environment.NewLine);
					}
				}
			}
			bool flag3;
			this.AddFrames(stringBuilder, flag, out flag3);
			return stringBuilder.ToString();
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x00034E60 File Offset: 0x00033060
		internal string ToString(StackTrace.TraceFormat traceFormat)
		{
			return this.ToString();
		}

		// Token: 0x04001831 RID: 6193
		private StackFrame[] frames;

		// Token: 0x04001832 RID: 6194
		private readonly StackTrace[] captured_traces;

		// Token: 0x04001833 RID: 6195
		private bool debug_info;

		// Token: 0x04001834 RID: 6196
		private static bool isAotidSet;

		// Token: 0x04001835 RID: 6197
		private static string aotid;

		// Token: 0x020005C3 RID: 1475
		internal enum TraceFormat
		{
			// Token: 0x04001837 RID: 6199
			Normal,
			// Token: 0x04001838 RID: 6200
			TrailingNewLine,
			// Token: 0x04001839 RID: 6201
			NoResourceLookup
		}
	}
}
