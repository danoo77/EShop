using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DmiConsulting.Eshop.Core.Entities;
using DmiConsulting.Eshop.Core.Entities.OrderAggregation;
using DmiConsulting.Eshop.Core.Interfaces;

namespace DmiConsulting.Eshop.Core.Services
{
    public class OrderService
    {
        private readonly IAsyncRepository<OrderItemAggregation> _orderRepository;
        private readonly IAsyncRepository<OrderItem> _orderItemRepository;
        private readonly IAsyncRepository<Product> _productRepository;

        public OrderService(IAsyncRepository<OrderItemAggregation> orderRepository,
            IAsyncRepository<OrderItem> orderItemRepository, IAsyncRepository<Product> productRepository)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _orderItemRepository = orderItemRepository ?? throw new ArgumentNullException(nameof(orderItemRepository));
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }


        public async Task OrderAsync(int productId, int quantity)
        {
            if (quantity < 1)
            {
                throw new InvalidOperationException("Cannot order product with smaller quantity than 1.");
            }

            var product = await _productRepository.GetByIdAsync(productId);

            if (product == null)
            {
                throw Exception.ProductNotFountException.CreateNew(productId);
            }

            OrderItemAggregation order = new OrderItemAggregation();
            order.OrderTime = DateTime.UtcNow; //should be wrapped to something but for this purpose is enough
            order.OrderedItems.Add(new OrderItem()
            {
                OrderedProduct = product,
                Price = product.Price,
                Quantity = quantity
            });
            await _orderRepository.AddAsync(order);
        }
    }
}
