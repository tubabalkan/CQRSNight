using CQRSNight.CQRSDesingPattern.Commands.CategoryCommands;
using CQRSNight.CQRSDesingPattern.Commands.ProductCommands;
using CQRSNight.DAL.Context;
using CQRSNight.DAL.Entities;

namespace CQRSNight.CQRSDesingPattern.Handlers.ProductHandlers
{
    public class CreateProductQueryHandler
    {
        private readonly CQRSContext _context;

        public CreateProductQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        private void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                CategoryId = command.CategoryId,
                Description = command.Description,
                ImageUrl = command.ImageUrl,
                Price = command.Price,
                ProductName = command.ProductName,
                Stock = command.Stock,
            });
            _context.SaveChanges();

        }
    }
}
