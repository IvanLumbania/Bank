// The 'using' statement for Test Tools is in GlobalUsings.cs
// using Microsoft.VisualStudio.TestTools.UnitTesting;

using NUnit.Framework;
using BankAccountNS;
namespace BankTests
{
    //Testing for BankAccount
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void TestMethod1()
        {
        }
        [Test]

        //Testing Debit amount if it is valid
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        //Testing Debit amount when it is less than zero
        [Test]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act and assert
            Assert.Throws<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }
    }
}