namespace ChainConstructors.Before
{
    using System;

    class Loan
    {
        private readonly CapitalStrategy strategy;
        private readonly double notional;
        private readonly double outstanding;
        private readonly int rating;
        private readonly DateTime? maturity;
        private readonly DateTime? expiry;

        public Loan(double notional,
            double outstanding,
            int rating,
            DateTime? expiry)
        {
            this.strategy = new TermROC();
            this.notional = notional;
            this.outstanding = outstanding;
            this.rating = rating;
            this.expiry = expiry;
        }

        public Loan(double notional,
            double outstanding,
            int rating,
            DateTime? maturity,
            DateTime? expiry)
        {
            this.strategy = new RevolvingTermROC();
            this.notional = notional;
            this.outstanding = outstanding;
            this.rating = rating;
            this.maturity = maturity;
            this.expiry = expiry;
        }
        
        public Loan(CapitalStrategy strategy,
            double notional,
            double outstanding,
            int rating,
            DateTime? maturity,
            DateTime? expiry)
        {
            this.notional = notional;
            this.outstanding = outstanding;
            this.rating = rating;
            this.maturity = maturity;
            this.expiry = expiry;
            this.strategy = strategy;
        }
        
        public string TypeOfLoan()
        {
            if (strategy is TermROC) return "Term loan";
            if (strategy is RevolvingTermROC) return "Revolving loan";
            if (strategy is RCTLTermROC) return "RCTL loan";
            throw new InvalidOperationException();
        }
    }
}