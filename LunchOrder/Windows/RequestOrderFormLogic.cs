using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunchOrder.Entity;
using LunchOrder.Interfaces;
using LunchOrder.Repositories;

namespace LunchOrder.Windows
{
    internal class RequestOrderFormLogic
    {
        private readonly IOrder _order;
        private readonly OrderRepository _orderRepository;

        public RequestOrderFormLogic(IOrder pOrder)
        {
            _orderRepository = new OrderRepository();
            _order = pOrder;
        }

        public bool IsValid(out string pMessage)
        {
            pMessage = string.Empty;

            if (!IsValidEmail())
            {
                pMessage = "Adres Email jest błędny";

                return false;
            }

            return true;
        }

        private bool IsValidEmail()
        {
            return Validation.EmailValidation.IsValid(_order.EmailDelivery);
        }

        public void SetEmail(string pEmail)
        {
            _order.EmailDelivery = pEmail;
        }

        public void SetComment(string pComment)
        {
            _order.Comment = pComment;
        }

        public bool SendOrder()
        {
            _order.OrderDate = DateTime.Now;
            var saveOrder = _orderRepository.SaveOrder(_order);

            if (!saveOrder)
            {
                return false;
            }

            var emailRequestOrder = new EmailRequestOrder();

            if (!emailRequestOrder.SendEmail(_order.EmailDelivery))
            {
                //todo: Zalogować blad wysylania email
            }

            return true;
        }
    }
}
