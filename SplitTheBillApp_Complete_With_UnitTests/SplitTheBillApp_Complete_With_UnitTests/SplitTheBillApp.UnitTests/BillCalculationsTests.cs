using NUnit.Framework;
using SplitTheBillApp_Complete_With_UnitTests;

namespace SplitTheBillApp.UnitTests
{
    [TestFixture]
    class BillCalculationsTests
    {
        [TestCase(100, 20)]
        [TestCase(100, 10)]
        [TestCase(100, 50)]
        public void DetermineTotalWithTip_AlwaysReturnsExpectedResult(double billTotal, double tipPercent)
        {
            //Arrange
            BillCalculations sut = new BillCalculations();

            //Act
            double answer = sut.DetermineTotalWithTip(billTotal, tipPercent);
            double expected = billTotal + tipPercent;

            //Assert
            Assert.AreEqual(expected, answer);

        }

        [TestCase(100, 2)]
        [TestCase(100, 4)]
        [TestCase(100, 10)]
        public void DeterminePricePerPerson_AlwaysReturnsExpectedResult_IfNumOfPeople_IsNotZero(double billTotal, int numOfPeople)
        {
            //Arrange
            BillCalculations sut = new BillCalculations();

            //Act

            double answer = sut.DeterminePricePerPerson(billTotal, numOfPeople);

            double expected = billTotal / numOfPeople;
            //Assert
            Assert.AreEqual(expected, answer);

        }



        [TestCase(100, 0)]
        [TestCase(50, 0)]
        public void DeterminePricePerPerson_AlwaysReturnsExpectedResult_IfNumOfPeople_IsZero(double billTotal, int numOfPeople)
        {
            //Arrange
            BillCalculations sut = new BillCalculations();

            //Act

            double answer = sut.DeterminePricePerPerson(billTotal, numOfPeople);

            double expected = 0;
            //Assert
            Assert.AreEqual(expected, answer);

        }

        [TestCase(100, 50)]
        [TestCase(100, 25)]
        [TestCase(100, 0)]
        public void CalculatePersonsPriceBasedOnPercentage_AlwaysReturnsExpectedResult(double billTotal, double percentageWantsToPay)
        {
            //Arrange
            BillCalculations sut = new BillCalculations();

            //Act

            double answer = sut.CalculatePersonsPriceBasedOnPercentage(billTotal, percentageWantsToPay);
           
            double expected = billTotal - percentageWantsToPay / 100 * billTotal;
            //Assert
            Assert.AreEqual(expected, answer);

        }

    }
}


