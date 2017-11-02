
namespace HelloWorldConsole.Interface
{
    /// <summary>
    /// customer interface
    /// TODO: for future expanstion this can be create as a seperate class library project
    /// </summary>
    public interface ICustomer
    {
        /// <summary>
        /// signature GetFullName 
        /// </summary>
        /// <returns>customer fullname</returns>
        string GetFullName();
        
        /// <summary>
        /// set cutomer name
        /// </summary>
        /// <param name="lastName">lastname</param>
        /// <param name="firstName">firstname</param>
        void SetCustomerName(string lastName, string firstName);
    }
}
