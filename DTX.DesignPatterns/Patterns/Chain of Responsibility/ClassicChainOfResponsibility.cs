using System;

namespace DTX.DesignPatterns.Patterns.Chain_of_Responsibility
{
    public static class ClassicChainOfResponsibility
    {
        // Handler
        private class Receiver
        {
            public bool BankTransfer { get; }
            public bool MoneyTransfer { get; }
            public bool PayPalTransfer { get; }
            public Receiver(bool bankTransfer, bool moneyTransfer, bool payPalTransfer)
            {
                BankTransfer = bankTransfer;
                MoneyTransfer = moneyTransfer;
                PayPalTransfer = payPalTransfer;
            }
        }

        // BaseHandler
        private abstract class PaymentHandler
        {
            public PaymentHandler Successor { protected get; set; }
            public abstract void Handle(Receiver receiver);
        }

        // ConcreteHandler A
        private class BankPaymentHandler : PaymentHandler
        {
            public override void Handle(Receiver receiver)
            {
                if (receiver.BankTransfer)
                {
                    Console.WriteLine(@"Handling bank payment");
                }
                else
                {
                    Successor?.Handle(receiver);
                }
            }
        }

        // ConcreteHandler B
        private class PayPalPaymentHandler : PaymentHandler
        {
            public override void Handle(Receiver receiver)
            {
                if (receiver.PayPalTransfer)
                {
                    Console.WriteLine(@"Handling PayPal payment");
                }
                else
                {
                    Successor?.Handle(receiver);
                }
            }
        }

        // ConcreteHandler C
        private class MoneyPaymentHandler : PaymentHandler
        {
            public override void Handle(Receiver receiver)
            {
                if (receiver.MoneyTransfer)
                {
                    Console.WriteLine(@"Handling money payment");
                }
                else
                {
                    Successor?.Handle(receiver);
                }
            }
        }

        // Client
        public static void Start()
        {
            var receiver = new Receiver(false, true, true);

            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHnadler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();
            bankPaymentHandler.Successor = paypalPaymentHandler;
            paypalPaymentHandler.Successor = moneyPaymentHnadler;

            bankPaymentHandler.Handle(receiver);
        }
    }
}