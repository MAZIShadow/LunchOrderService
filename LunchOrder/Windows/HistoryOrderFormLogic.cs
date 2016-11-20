using System;
using System.Collections.Generic;
using LunchOrder.Interfaces;
using LunchOrder.Repositories;

namespace LunchOrder.Windows
{
    internal class HistoryOrderFormLogic
    {
        private readonly OrderRepository _orderRepository;

        public HistoryOrderFormLogic()
        {
            _orderRepository = new OrderRepository();
        }

        public List<IOrder> LoadHistoryOrders(DateTime pDateTimeFrom, DateTime pDateTimeTo)
        {
            return _orderRepository.FindAllOrdersByDateTimes(pDateTimeFrom, pDateTimeTo);
        }
    }
    
}