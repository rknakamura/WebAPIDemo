using System;

namespace WebApplicationDemo
{
    public interface IDependencyInjection
    {
        string Get();
    }

    public class DependencyInjection : IDependencyInjection
    {
        public string Get()
        {
            return string.Empty;
        }
    }
}