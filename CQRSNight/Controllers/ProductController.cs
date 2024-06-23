﻿using CQRSNight.CQRSDesingPattern.Commands.CategoryCommands;
using CQRSNight.CQRSDesingPattern.Commands.ProductCommands;
using CQRSNight.CQRSDesingPattern.Handlers.CategoryHandlers;
using CQRSNight.CQRSDesingPattern.Handlers.ProductHandlers;
using CQRSNight.CQRSDesingPattern.Queries.CategoryQueries;
using CQRSNight.CQRSDesingPattern.Queries.ProductQueries;
using Microsoft.AspNetCore.Mvc;

namespace CQRSNight.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly GetProductByIdQueryHandler _getProductByIdQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        private readonly RemoveProductQueryHandler _removeProductQueryHandler;
       
       
        private readonly UpdateProductQueryHandler _updateProductQueryHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;





        public ProductController(GetProductQueryHandler getProductQueryHandler, CreateProductCommandHandler createProductCommandHandler, RemoveProductQueryHandler removeProductQueryHandler, GetProductQueryHandler getproductQueryHandler, UpdateProductQueryHandler updateProductQueryHandler, GetProductByIdQueryHandler getProductByIdQueryHandler, UpdateProductCommandHandler updateProductCommandHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
            _removeProductQueryHandler = removeProductQueryHandler;

            _updateProductQueryHandler = updateProductQueryHandler;
            _getProductByIdQueryHandler = getProductByIdQueryHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
        }

        public IActionResult ProductList()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);

            return RedirectToAction("ProductList");
        }
        public IActionResult RemoveProduct(int id)
        {
            _removeProductQueryHandler.Handle(new RemoveProductCommand(id));
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = _getProductByIdQueryHandler.Handle(new GetProductByIdQuery(id));
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {
            _updateProductCommandHandler.Handle(command);
            return RedirectToAction("ProductList");
        }

    }
}