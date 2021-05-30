namespace TechCafé.DefaultInterfaceImplementations
{
    public interface IClient
    {
        public string GetToken()
        {
            return "Base: Hello World";
        }
    }

    public class TokenClient : IClient
    {
        public string GetToken()
        {
            return "TokenClient: Hello World";
        }
    }
    
    public class DefaultClient : IClient
    {
    }
}