using Foorniroom.Interfaces;

namespace Foorniroom.Repositories
{
    public class HelloRepository : IHelloRepository
    {
        public string GetMessage()
        {
            return "Привет из репозитория!";
        }
    }
}