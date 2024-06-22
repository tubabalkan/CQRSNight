using CQRSNight.CQRSDesingPattern.Commands.CategoryCommands;
using CQRSNight.DAL.Context;

namespace CQRSNight.CQRSDesingPattern.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly CQRSContext _context;

        public RemoveCategoryCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(RemoveCategoryCommand command)
        {
            var value = _context.Categories.Find(command.CategoryId);
            _context.Categories.Remove(value);
            _context.SaveChanges();
        }
    }
}
