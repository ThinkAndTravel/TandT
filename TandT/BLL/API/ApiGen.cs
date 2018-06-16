
namespace Models
{
    public class ApiGen
    {
        static IRefitService service;
        public static IRefitService Get ()
        {
            if (service == null) ;
           //     service = RestService.For<IRefitService>("");
            return service;
        }
    }
}
