using CQRSNight.CQRSDesingPattern.Commands.ProductCommands;
using CQRSNight.DAL.Context;

namespace CQRSNight.CQRSDesingPattern.Handlers.ProductHandlers
{
    public class UpdateProductQueryHandler
    {
        private readonly CQRSContext _context;

        public UpdateProductQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(UpdateProductCommand command)
        {
            var value=_context.Products.Find(command.ProductId);
            value.ProductName = command.ProductName;
            value.Price = command.Price;
            value.Description = command.Description;
            value.Stock = command.Stock;
            value.ImageUrl = command.ImageUrl;
            value.CategoryId = command.CategoryId;
            _context.SaveChanges();
        }
    }
}
