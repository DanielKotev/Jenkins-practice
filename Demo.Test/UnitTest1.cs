
using Domain;

namespace Demo.Test

{
    public class Tests
    {
        private Bankaccount account;
        [SetUp]
        public void Setup()
        {
            account = new Bankaccount(1000);

        }

        [Test]
        public void Adding_Funds_Updates_Balance()
        {
            // ACT
            account.Add(500);

            // ASSERT
            Assert.That(account.balance, Is.EqualTo(1500));
        }


        [Test]
        public void Withdrawing_Funds_Updates_Balance()
        {
            // ACT
            account.Withdraw(500);

            // ASSERT
            Assert.That(account.balance, Is.EqualTo(500));
        }
        // [Test]
        // public void Withdrawing_More_Than_Balance()
        // {
        //     // ACT
        //     account.Withdraw(1500);

        //     // ASSERT
        //     Assert.That(account.balance, Is.EqualTo(-500));
        // }

        [Test]
        public void Withdrawing_Negative_Funds_Throws()
        {
            // ACT + ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw(-500));
        }
    }
}