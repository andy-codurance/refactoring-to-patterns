namespace ReplaceConstructors.After
{
    using System;
    using Xunit;
    using Xunit.Abstractions;

    public class Tests
    {
        private readonly ITestOutputHelper outputHelper;

        public Tests(ITestOutputHelper outputHelper)
        {
            this.outputHelper = outputHelper;
        }

        [Fact]
        public void CreateTermLoan()
        {
            var loan = new Loan(0.0, 0, null);
            Assert.Equal("Term loan", loan.TypeOfLoan());
        }

        [Fact]
        public void CreateTermLoan2()
        {
            var loan = new Loan(0.0, 0, null, null);
            Assert.Equal("Term loan", loan.TypeOfLoan());
        }

        [Fact]
        public void CreateTermLoan3()
        {
            var loan = new Loan(0.0, 0.0, 0, null, null);
            Assert.Equal("Term loan", loan.TypeOfLoan());
        }

        [Fact]
        public void CreateTermLoan4()
        {
            var loan = new Loan(null, 0.0, 0, null, null);
            Assert.Equal("Term loan", loan.TypeOfLoan());
        }

        [Fact]
        public void CreateTermLoan5()
        {
            var loan = new Loan(null, 0.0, 0.0, 0, null, null);
            Assert.Equal("Term loan", loan.TypeOfLoan());
        }
        
        [Fact]
        public void CreateRevolverLoan()
        {
            var loan = new Loan(0.0, 0, null, DateTime.Now);
            Assert.Equal("Revolver loan", loan.TypeOfLoan());
        }
        
        [Fact]
        public void CreateRevolverLoan2()
        {
            var loan = new Loan(0.0, 0.0, 0, null, DateTime.Now);
            Assert.Equal("Revolver loan", loan.TypeOfLoan());
        }
        
        [Fact]
        public void CreateRevolverLoan3()
        {
            var loan = new Loan(null, 0.0, 0, null, DateTime.Now);
            Assert.Equal("Revolver loan", loan.TypeOfLoan());
        }
        
        [Fact]
        public void CreateRevolverLoan4()
        {
            var loan = new Loan(null, 0.0, 0.0, 0, null, DateTime.Now);
            Assert.Equal("Revolver loan", loan.TypeOfLoan());
        }
        
        [Fact]
        public void CreateRCTLLoan()
        {
            var loan = new Loan(0.0, 0, DateTime.Now, DateTime.Now);
            Assert.Equal("RCTL loan", loan.TypeOfLoan());
        }
        
        [Fact]
        public void CreateRCTLLoan2()
        {
            var loan = new Loan(0.0, 0.0, 0, DateTime.Now, DateTime.Now);
            Assert.Equal("RCTL loan", loan.TypeOfLoan());
        }
        
        [Fact]
        public void CreateRCTLLoan3()
        {
            var loan = new Loan(null, 0.0, 0, DateTime.Now, DateTime.Now);
            Assert.Equal("RCTL loan", loan.TypeOfLoan());
        }
        
        [Fact]
        public void CreateRCTLLoan4()
        {
            var loan = new Loan(null, 0.0, 0.0, 0, DateTime.Now, DateTime.Now);
            Assert.Equal("RCTL loan", loan.TypeOfLoan());
        }
        
        [Fact]
        public void CreateSpecificLoan()
        {
            var loan = new Loan(new CapitalStrategyRevolver(), 0.0, 0.0, 0, DateTime.Now, DateTime.Now);
            Assert.Equal("Revolver loan", loan.TypeOfLoan());
        }
    }
}