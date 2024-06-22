using CQRSNight.CQRSDesingPattern.Queries.CategoryQueries;
using CQRSNight.CQRSDesingPattern.Results.CategoryResults;
using CQRSNight.DAL.Context;

namespace CQRSNight.CQRSDesingPattern.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly CQRSContext _context;

        public GetCategoryByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public GetCategoryByIdQueryResult Handle(GetCategoryByIdQuery query)
        {
            var value = _context.Categories.Find(query.CategoryId);
            return new GetCategoryByIdQueryResult
            {
                CategoryId = value.CategoryId,
                CategoryName = value.CategoryName
            };
        }
    }
}
