using HelloWorldConsole.Interface;

namespace HelloWorldConsole.Repo
{
    /// <summary>
    /// customer client class
    /// TODO: for future expanstion this can be create as a seperate class library project
    /// </summary>
    public class CustomerClient
    {
        private ICustomer _customerService;
        
        /// <summary>
        /// constructor to set service
        /// </summary>
        /// <param name="customerService"></param>
        public CustomerClient(ICustomer customerService)
        {
            this._customerService = customerService;
        }
        
        /// <summary>
        /// get customer full name
        /// </summary>
        /// <returns></returns>
        public string GetCustomerName()
        {
            return this._customerService.GetFullName();
        }
        
        /// <summary>
        /// set customer name
        /// </summary>
        /// <param name="lastName">lastname</param>
        /// <param name="firstName">firstname</param>
        public void SetCustomreName(string lastName, string firstName)
        {
            this._customerService.SetCustomerName(lastName, firstName);
        }
    }
}
