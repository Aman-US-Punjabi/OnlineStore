//using System;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//using OnlineStore.Core.Entities.Catalog;
//using OnlineStore.Core.Interfaces.Repositories;

//namespace OnlineStore.PublicApi.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class ProductController : ControllerBase
//    {
//        private readonly IAsyncRepository<Product> _productRepository;
//        private readonly IAsyncReadRepository<Product> _productReadRepository;

//        private readonly ILogger<ProductController> _logger;

//        public ProductController(
//            IAsyncRepository<Product> productRepository,
//            IAsyncReadRepository<Product> productReadRepository)
//        {

//        }
//    }
//}
