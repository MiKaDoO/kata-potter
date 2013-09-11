using KataPotter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using FluentAssertions;

namespace Test
{
	[TestClass()]
	public class BuyServiceTest
	{


		private TestContext testContextInstance;

		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Attributs de tests supplémentaires
		// 
		//Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
		//
		//Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion


		[TestMethod()]
		public void CalculatePrice_ShouldReturn_15dot20_When_b1b2()
		{
			BuyService target = new BuyService(); 
			List<string> card = new List<string>() { "b1","b2" }; 
			float expected = 15.20F; 
			float actual;
			actual = target.CalculatePrice(card);
			actual.Should().Be(expected);
		}

		[TestMethod()]
		public void CalculatePrice_ShouldReturn_21dot60_When_b1b2b3()
		{
			BuyService target = new BuyService();
			List<string> card = new List<string>() { "b1", "b2", "b3" };
			float expected = 21.6F;
			float actual;
			actual = target.CalculatePrice(card);
			actual.Should().Be(expected);
		}


		[TestMethod()]
		public void CalculatePrice_ShouldReturn_16_When_b1b1()
		{
			BuyService target = new BuyService();
			List<string> card = new List<string>() { "b1", "b1" };
			float expected = 16F;
			float actual;
			actual = target.CalculatePrice(card);
			actual.Should().Be(expected);
		}

		[TestMethod()]
		public void CalculatePrice_ShouldReturn_25dot60_When_b1b2b3b4()
		{
			BuyService target = new BuyService();
			List<string> card = new List<string>() { "b1", "b2", "b3", "b4" };
			float expected = 25.6F;
			float actual;
			actual = target.CalculatePrice(card);
			actual.Should().Be(expected);
		}

		[TestMethod()]
		public void CalculatePrice_ShouldReturn_30_When_b1b2b3b4b5()
		{
			BuyService target = new BuyService();
			List<string> card = new List<string>() { "b1", "b2", "b3", "b4", "b5" };
			float expected = 30F;
			float actual;
			actual = target.CalculatePrice(card);
			actual.Should().Be(expected);
		}

		[TestMethod()]
		public void CalculatePrice_ShouldReturn_29dot60_When_b1b1b2b3()
		{
			BuyService target = new BuyService();
			List<string> card = new List<string>() { "b1", "b1", "b2", "b3" };
			float expected = 29.6F;
			float actual;
			actual = target.CalculatePrice(card);
			actual.Should().Be(expected);
		}

		[TestMethod()]
		public void CalculatePrice_ShouldReturn_43dot20_When_b1b1b2b2b3b3()
		{
			BuyService target = new BuyService();
			List<string> card = new List<string>() { "b1", "b1", "b2", "b2", "b3", "b3" };
			float expected = 43.2F;
			float actual;
			actual = target.CalculatePrice(card);
			actual.Should().Be(expected);
		}

		[TestMethod()]
		public void CalculatePrice_ShouldReturn_51dot20_When_b1b2b2b3b3b4b5()
		{
			BuyService target = new BuyService();
			List<string> card = new List<string>() { "b1", "b1", "b2", "b2", "b3", "b3", "b4", "b5" };
			float expected = 51.2F;
			float actual;
			actual = target.CalculatePrice(card);
			actual.Should().Be(expected);
		}

		[TestMethod()]
		public void CalculatePrice_ShouldReturn_81dot20_When_b1b1b1b2b2b2b3b3b3b4b4b5b5()
		{
			BuyService target = new BuyService();
			List<string> card = new List<string>() { "b1", "b1", "b1", "b2", "b2", "b2", "b3", "b3", "b3", "b4", "b4", "b5", "b5" };
			float expected = 81.2F;
			float actual;
			actual = target.CalculatePrice(card);

			actual.Should().Be(expected);
		}
	}
}
