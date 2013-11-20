//
// HWInfo.Internal.cs: defines various handy properties
//
// Author:
//   Alex Soto (alex@alexsoto.me)
//
// Copyright 2013, Alejandro Soto.
//
// Code licensed under the MIT X11 license
//

using System;
using MonoTouch;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HardwareInfo
{
	public partial class HWInfo
	{
		// int sysctlbyname(const char *name, void *oldp, size_t *oldlenp, void *newp, size_t newlen);
		[DllImportAttribute (Constants.SystemLibrary, EntryPoint = "sysctlbyname")]
		internal static extern int SysCtlByName([MarshalAs (UnmanagedType.LPStr)] string propertyName, IntPtr output, IntPtr oldLen, IntPtr newP, uint newLen);

		static string GetSystemInfo (string hwproperty)
		{
			try 
			{
				var strLenght = Marshal.AllocHGlobal (sizeof (int));
				SysCtlByName (hwproperty, IntPtr.Zero, strLenght, IntPtr.Zero, 0);
				var length = Marshal.ReadInt32 (strLenght);

				if (length == 0)
				{
					Marshal.FreeHGlobal (strLenght);
					return "Unknown";
				}

				var stringPtr = Marshal.AllocHGlobal (length);
				SysCtlByName (hwproperty, stringPtr, strLenght, IntPtr.Zero, 0);

				var result = Marshal.PtrToStringAnsi (stringPtr);

				Marshal.FreeHGlobal(strLenght);
				Marshal.FreeHGlobal(stringPtr);

				return result;
			} 
			catch (Exception) 
			{
				return "Unknown";
			}		
		}
	}
}

