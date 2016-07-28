using Android.App;
using MvvmCross.Droid.Views;

namespace MvvmCrossPractice.Droid
{
	[Activity(Label = "Your App Namex", MainLauncher = true, Icon = "@drawable/icon")]
	public class SplashScreen : MvxSplashScreenActivity
	{
		public SplashScreen()
			: base(Resource.Layout.SplashScreen)
		{
		}
	}
}

