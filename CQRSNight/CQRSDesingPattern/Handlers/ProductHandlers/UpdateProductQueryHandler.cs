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

    }
}
