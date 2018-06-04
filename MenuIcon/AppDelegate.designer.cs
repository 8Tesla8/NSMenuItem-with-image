// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MenuIcon
{
	partial class AppDelegate
	{
		[Outlet]
		AppKit.NSMenu mn_file { get; set; }

		[Outlet]
		AppKit.NSMenuItem mn_icons { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (mn_file != null) {
				mn_file.Dispose ();
				mn_file = null;
			}

			if (mn_icons != null) {
				mn_icons.Dispose ();
				mn_icons = null;
			}
		}
	}
}
