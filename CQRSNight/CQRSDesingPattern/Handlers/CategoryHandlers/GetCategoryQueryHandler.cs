﻿using CQRSNight.CQRSDesingPattern.Queries.CategoryQueries;
using CQRSNight.CQRSDesingPattern.Results.CategoryResults;
using CQRSNight.DAL.Context;

namespace CQRSNight.CQRSDesingPattern.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly CQRSContext _context;

        public GetCategoryQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public List<GetCategoryQueryResult> Handle()
        {
            var values = _context.Categories.Select(x => new GetCategoryQueryResult
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName
            });
            return values.ToList();
        }
        public GetCategoryQueryResult Handle(GetCategoryByIdQuery query)
        {
            var category = _context.Categories
                .Where(x => x.CategoryId == query.CategoryId)
                .Select(x => new GetCategoryQueryResult
                {
                    CategoryId = x.CategoryId,
                    CategoryName = x.CategoryName
                })
                .FirstOrDefault();

            return category;
        }

    }
}
