// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MvvmCrossPractice.iOS.Views
{
	[Register ("DescriptionCell")]
	partial class DescriptionCell
	{
		[Outlet]
		UIKit.UILabel CountLabel { get; set; }

		[Outlet]
		UIKit.UIImageView MainImage { get; set; }

		[Outlet]
		UIKit.UILabel NameLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CountLabel != null) {
				CountLabel.Dispose ();
				CountLabel = null;
			}

			if (MainImage != null) {
				MainImage.Dispose ();
				MainImage = null;
			}

			if (NameLabel != null) {
				NameLabel.Dispose ();
				NameLabel = null;
			}
		}
	}
}
