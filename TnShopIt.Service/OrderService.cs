using System.Collections.Generic;
using TnShopIt.Data.Infrastructure;
using TnShopIt.Data.Repositories;
using TnShopIt.Model.Models;

namespace TnShopIt.Service
{
    public interface IOrderService
    {
        void Add(Order order);

        void Update(Order order);

        void Delete(int id);

        IEnumerable<Order> GetAll();

        IEnumerable<Order> GetAllPaging(int page, int pageSize, out int totalRow);

        Order GetById(int id);

        IEnumerable<Order> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChanges();
    }

    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;
        private UnitOfWork _uniOfWork;

        public OrderService(IOrderRepository orderRepository, UnitOfWork unitOfWork)
        {
            _orderRepository = orderRepository;
            _uniOfWork = unitOfWork;
        }

        public void Add(Order order)
        {
            _orderRepository.Add(order);
        }

        public void Delete(int id)
        {
            _orderRepository.Delete(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _orderRepository.GetAll(new string[] { "OrderDetail" });
        }

        public IEnumerable<Order> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            //TODO: Select all post by tag
            return _orderRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<Order> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _orderRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Order GetById(int id)
        {
            return _orderRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _uniOfWork.Commit();
        }

        public void Update(Order order)
        {
            _orderRepository.Update(order);
        }
    }
}