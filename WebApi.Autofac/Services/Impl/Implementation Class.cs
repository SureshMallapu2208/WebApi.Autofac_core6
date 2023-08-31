namespace WebApi.Autofac.Services.Impl
{
    public class Implementation_Class : ISample
    {
        public void Add()
        {
            Console.WriteLine($"Dependency Injection with Autofac");
        }
    }
}
