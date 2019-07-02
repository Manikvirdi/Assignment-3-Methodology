using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApp14;

namespace CalculatorTestMutant
{
    public class Class1
    {

		//Addition
		[Test]
		public void GetAddition_Input80and80_Returns160()
		{

			//Arrange 
			double number1 = 80;
			double number2 = 80;

			double expectedResult = number1 + number2;
			Calculator testCalc = new Calculator(number1, number2);

			//Act 
			double actualResult = testCalc.GetAddition();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void GetAddition_Input8and47_Returns55()
		{

			//Arrange 
			double number1 = 8;
			double number2 = 47;

			double expectedResult = number1 + number2;
			Calculator testCalc = new Calculator(number1, number2);

			//Act
			double actualResult = testCalc.GetAddition();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void GetAddition_Input112andt128_Returns240()
		{
			//Arrange 
			double number1 = 112;
			double number2 = 128;
			double expectedResult = number1 + number2;
			Calculator testCalc = new Calculator(number1, number2);

			//Act
			double actualResult = testCalc.GetAddition();

			//Assert
			Assert.AreEqual(expectedResult, actualResult);

		}
		// Subtraction
		[Test]
		public void GetSubtraction_Input495and128_Returns367()
		{
			//Arrange 
			double number1 = 495;
			double number2 = 128;

			double expectedResult = number1 - number2;
			Calculator testCalc = new Calculator(number1, number2);

			//Act
			double actualResult = testCalc.GetSubtraction();

			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void GetSubtraction_Input365and12_Returns353()
		{
			//Arrange 
			double number1 = 365;
			double number2 = 12;

			double expectedResult = number1 - number2;
			Calculator testCalc = new Calculator(number1, number2);

			//Act 
			double actualResult = testCalc.GetSubtraction();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}


		[Test]
		public void GetSubtraction_Input12and10_Returns2()
		{
			//Arrange 
			double number1 = 12;
			double number2 = 10;

			double expectedResult = number1 - number2;
			Calculator testCalc = new Calculator(number1, number2);

			//Act
			double actualResult = testCalc.GetSubtraction();

			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

		//Division Mutant
		[Test]
		public void GetDivision_Input10and2_Returns5()
		{
			//Arrange 
			double number1 = 10;
			double number2 = 2;

			double expectedResult = number1 / number2;
			Calculator testCalc = new Calculator(number1, number2);

			//Act 
			double actualResult = testCalc.GetDivision();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void GetDivision_Input45and5_Returns9()
		{
			//Arrange 
			double number1 = 45;
			double number2 = 5;

			double expectedResult = number1 / number2;
			Calculator testCalc = new Calculator(number1, number2);

			//Act 
			double actualResult = testCalc.GetDivision();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void GetDivision_Input72and9_Return8()
		{
			//Arrange 
			double number1 = 72;
			double number2 = 9;

			double expectedResult = number1 / number2;
			Calculator testCalc = new Calculator(number1, number2);

			//Act 
			double actualResult = testCalc.GetDivision();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}

		// Multiplication
		[Test]
		public void GetMultiplication_Input3and5_Returns15()
		{
			//Arrange 
			double number1 = 3;
			double number2 = 5;

			double expectedResult = number1 * number2;
			Calculator testCalc = new Calculator(number1, number2);

			//Act 
			double actualResult = testCalc.GetMultiplication();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void GetMultiplication_Input100and2_Returns200()
		{
			//Arrange 
			double number1 = 100;
			double number2 = 2;

			double expectedResult = number1 * number2;
			Calculator testCalc = new Calculator(number1, number2);

			//Act 
			double actualResult = testCalc.GetMultiplication();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void GetMultiplication_Input6and6_Returns36()
		{
			//Arrange 
			double number1 = 6;
			double number2 = 6;

			double expectedResult = number1 * number2;
			Calculator testCalc = new Calculator(number1, number2);

			//Act 
			double actualResult = testCalc.GetMultiplication();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}
		
		
		// 3 new Test Cases
		[Test]
		public void GetDivision_Input1point0and3point0_Returns0point33333333333333331d()
		{
			//Arrange 
			double number1 = 1;
			double number2 = 3;

			double expectedResult = number1 / number2;
			Calculator testCalc = new Calculator(number1, number2);

			//Act 
			double actualResult = testCalc.GetDivision();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void GetDivision_Input2and1_Returns2()
		{
			//Arrange 
			double number1 = 2;
			double number2 = 1;

			double expectedResult = number1 / number2;
			Calculator testCalc = new Calculator(number1, number2);

			//Act 
			double actualResult = testCalc.GetDivision();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void GetDivision_Input9and3_Returns3()
		{
			//Arrange 
			double number1 = 9;
			double number2 = 3;

			double expectedResult = number1 / number2;
			Calculator testCalc = new Calculator(number1, number2);

			//Act 
			double actualResult = testCalc.GetDivision();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}
		
	

	}
}
