namespace SalesWebMvc.Services.Exceptions
{
    public class IntregrityExecption : ApplicationException
    {
        public IntregrityExecption(string message) : base(message) { 
        }
    }
}
