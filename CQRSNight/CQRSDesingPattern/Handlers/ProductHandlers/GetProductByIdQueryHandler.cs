﻿using CQRSNight.CQRSDesingPattern.Queries.ProductQueries;
using CQRSNight.CQRSDesingPattern.Results.ProductResults;
using CQRSNight.DAL.Context;

namespace CQRSNight.CQRSDesingPattern.Handlers.ProductHandlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly CQRSContext _context;

        public GetProductByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var value = _context.Products.Find(query.ProductId);
            return new GetProductByIdQueryResult
            {
                ProductId = value.ProductId,
                CategoryId = value.CategoryId,
                Description = value.Description,
                ImageUrl = value.ImageUrl,
                Price = value.Price,
                ProductName = value.ProductName,
                Stock = value.Stock
            };
        }
    }
}
