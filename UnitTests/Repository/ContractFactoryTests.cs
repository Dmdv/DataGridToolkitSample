using System.Linq;
using ContractService.Repository;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Repository
{
	[TestClass()]
	public class ContractFactoryTests
	{
		[TestMethod()]
		public void AllTestFakeFactory()
		{
			IContractsRepository fake = new ContractFakeFactory();
			fake.All().Count().Should().Be(ContractFakeFactory.MaxValue);
		}
	}
}
