HardwareInfo
============

This is a handy Xamarin.iOS class that holds device information based on device identifier.

Usage and available properties
==============================

```csharp

	using HardwareInfo;
	// ...

	public override void ViewDidLoad ()
	{
		Console.WriteLine ("Device Model Name: {0}", HWInfo.ModelName);
		Console.WriteLine ("Device Family: {0}", HWInfo.DeviceFamily);
		Console.WriteLine ("Device Hostname: {0}", HWInfo.HostName);
		Console.WriteLine ("Is Simulator?: {0}", HWInfo.IsSimulator);
		Console.WriteLine ("Device Has Retina Display?: {0}", HWInfo.IsRetina);
		Console.WriteLine ("Device Identifier: {0}", HWInfo.Identifier);		
	}
	
```

**Results:**

	Device Model Name: iPhone 5 (GSM)
	Device Family: iPhone
	Device Hostname: MonkeyPhone
	Is Simulator?: False
	Device Has Retina Display?: True
	Device Identifier: iPhone5,1


License
=======

Under MIT X11 License

Copyright (c) Alejandro Soto.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.

