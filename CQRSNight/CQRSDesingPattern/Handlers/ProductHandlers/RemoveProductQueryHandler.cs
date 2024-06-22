using CQRSNight.CQRSDesingPattern.Commands.ProductCommands;
using CQRSNight.DAL.Context;

namespace CQRSNight.CQRSDesingPattern.Handlers.ProductHandlers
{
    public class RemoveProductQueryHandler
    {
        private readonly CQRSContext _context;

        public RemoveProductQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(RemoveProductCommand command)
        {
            var value=_context.Products.Find(command.ProductId);
            _context.Products.Remove(value);
            _context.SaveChanges();
        }
    }
}
