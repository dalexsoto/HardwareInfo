//
// HWInfo.cs: defines various handy properties
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
using System.Runtime.InteropServices;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;
using System.Net;

namespace HardwareInfo
{
	public partial class HWInfo
	{
		static string identifier;
		public static string Identifier {
			get {
				if (string.IsNullOrEmpty (identifier))
					identifier = GetSystemInfo ("hw.machine");
				return identifier;
			}
		}

		static string modelName;
		public static string ModelName {
			get {
				if (!string.IsNullOrEmpty (modelName))
					return modelName;

				if (DeviceDic.TryGetValue (Identifier, out modelName)) {
					IsSimulator = false;
					return modelName;
				}

				else if (identifier.Contains("86")) {
					IsSimulator = true;
					modelName = UIDevice.CurrentDevice.Model;
					return modelName;
				} else
					return modelName = "Unknown";
			}
		}

		public static HWDevice DeviceFamily {
			get {
				if (ModelName.Contains ("iPhone"))
					return HWDevice.iPhone;
				else if (ModelName.Contains ("iPad"))
					return HWDevice.iPad;
				else if (ModelName.Contains ("iPod"))
					return HWDevice.iPod;
				else
					return HWDevice.Unknown;
			}
		}

		public static bool IsRetina {
			get {
				if (NonRetina.Contains (Identifier))
					return false;
				else
					return true;
			}
		}

		public static bool IsSimulator { get; private set;	}

		public static string HostName {
			get {
				return Dns.GetHostName ();
			}
		}
	}
}

