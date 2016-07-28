using System.Collections.Generic;

namespace MvvmCrossPractice.Services.Times
{
	public interface IDescriptionService
	{
		List<Description> Descriptions { get; }
	}
}