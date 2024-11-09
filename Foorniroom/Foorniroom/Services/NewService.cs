using Foorniroom.Interfaces;
using Foorniroom.Services;

namespace Foorniroom.Services
{
        public class NewService : INewService
{
    public string GetMessage()
    {
        return "I am new service";
    }
}
}

