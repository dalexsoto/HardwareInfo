//
// HWInfo.Definitions.cs: defines the info dicts.
//
// Author:
//   Alex Soto (alex@alexsoto.me)
//
// Copyright 2013, Alejandro Soto.
//
// Code licensed under the MIT X11 license
//
// Device information comes from:
// http://theiphonewiki.com/wiki
//

using System;
using System.Collections.Generic;

namespace HardwareInfo
{
	public partial class HWInfo
	{
		static Dictionary<string, string> DeviceDic = new Dictionary<string, string> () 
		{
			// iPhone http://theiphonewiki.com/wiki/IPhone
			{ "iPhone1,1", "iPhone 1G" },
			{ "iPhone1,2", "iPhone 3G" },
			{ "iPhone2,1", "iPhone 3GS" },
			{ "iPhone3,1", "iPhone 4 (GSM)" },
			{ "iPhone3,2", "iPhone 4 (GSM Rev A)" },
			{ "iPhone3,3", "iPhone 4 (CDMA)" },
			{ "iPhone4,1", "iPhone 4S" },
			{ "iPhone5,1", "iPhone 5 (GSM)" },
			{ "iPhone5,2", "iPhone 5 (Global)" },
			{ "iPhone5,3", "iPhone 5c (GSM)" },
			{ "iPhone5,4", "iPhone 5c (Global)" },
			{ "iPhone6,1", "iPhone 5s (GSM)" },
			{ "iPhone6,2", "iPhone 5s (Global)" },

			// iPad http://theiphonewiki.com/wiki/IPad
			{ "iPad1,1", "iPad 1G" },
			{ "iPad2,1", "iPad 2 (WiFi)" },
			{ "iPad2,2", "iPad 2 (GSM)" },
			{ "iPad2,3", "iPad 2 (CDMA)" },
			{ "iPad2,4", "iPad 2 (Rev A)" },
			{ "iPad3,1", "iPad 3 (WiFi)" },
			{ "iPad3,2", "iPad 3 (GSM)" },
			{ "iPad3,3", "iPad 3 (Global)" },
			{ "iPad3,4", "iPad 4 (WiFi)" },
			{ "iPad3,5", "iPad 4 (GSM)" },
			{ "iPad3,6", "iPad 4 (Global)" },
			{ "iPad4,1", "iPad Air (WiFi)" },
			{ "iPad4,2", "iPad Air (Cellular)" },

			// iPad Mini http://theiphonewiki.com/wiki/IPad_mini
			{ "iPad2,5", "iPad mini 1G (WiFi)" },
			{ "iPad2,6", "iPad mini 1G (GSM)" },
			{ "iPad2,7", "iPad mini 1G (Global)" },
			{ "iPad4,4", "iPad mini 2G (WiFi)" },
			{ "iPad4,5", "iPad mini 2G (Cellular)" },

			// iPod http://theiphonewiki.com/wiki/IPod
			{ "iPod1,1", "iPod touch 1G" },
			{ "iPod2,1", "iPod touch 2G" },
			{ "iPod3,1", "iPod touch 3G" },
			{ "iPod4,1", "iPod touch 4G" },
			{ "iPod5,1", "iPod touch 5G" }
		};

		static List<string> NonRetina = new List<string> ()
		{
			// iPhone http://theiphonewiki.com/wiki/IPhone
			"iPhone1,1", "iPhone1,2", "iPhone2,1",

			// iPad http://theiphonewiki.com/wiki/IPad
			"iPad1,1", "iPad2,1", "iPad2,2", "iPad2,3", "iPad2,4",

			// iPad Mini http://theiphonewiki.com/wiki/IPad_mini
			"iPad2,5", "iPad2,6", "iPad2,7",

			// iPod http://theiphonewiki.com/wiki/IPod
			"iPod1,1", "iPod2,1", "iPod3,1"
		};
	}

	public enum HWDevice
	{
		iPhone,
		iPad,
		iPod,
		Unknown
	}
}

