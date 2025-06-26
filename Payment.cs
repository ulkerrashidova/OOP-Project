namespace Project_Rashidova
{
    public class Payment
    {
        public decimal Amount { get; set; }
        public bool Status { get; set; }  // true - оплачено, false - ні

        public Payment(decimal amount, bool status)
        {
            Amount = amount;
            Status = status;
        }

        public bool IsAmountValid()
        {
            // Сума повинна бути більшою за 0
            return Amount > 0;
        }
    }
}

