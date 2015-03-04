using System;
using ContractComponents.ViewModel;
using ContractService.Model;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
	[TestClass]
	public class UnitTest
	{
		[TestMethod]
		public void TestEventIsRaised()
		{
			var contract = new Contract
			{
				ClientId = 1,
				ClientName = "Name1",
				IsVip = true,
				PresentationDate = DateTime.Now
			};

			var model = new ContractViewModel(contract);
			model.PropertyChanged += (o, args) => args.PropertyName.Should().Be("PresentationDate");
			model.PresentationDate = DateTime.Now;
		}
	}
}