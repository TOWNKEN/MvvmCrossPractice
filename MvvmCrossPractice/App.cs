using MvvmCrossPractice.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace MvvmCrossPractice
{
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			CreatableTypes()
				.EndingWith("Service")
				.AsInterfaces()
				.RegisterAsSingleton();

			RegisterAppStart<HomeViewModel>();
		}
	}
}
