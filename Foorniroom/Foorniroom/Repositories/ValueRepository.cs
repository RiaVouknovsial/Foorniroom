using Foorniroom.Interfaces;

namespace Foorniroom.Repositories
{
    public class ValueRepository : IValueRepository
    {
        public string GetValue()
        {
            return "Peace in the world!";
        }
    }
}
