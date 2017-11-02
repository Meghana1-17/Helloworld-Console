using HelloWorldConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorldConsole.Service
{
    /// <summary>
    /// customer service class
    /// TODO: for future expanstion this can be create as a seperate class library project
    /// </summary>
    public class CustomerService : ICustomer
    {
        #region "Private Variable"
        /// <summary>
        /// customer firstname
        /// </summary>
        private string FirstName { get; set; }

        /// <summary>
        /// customer lastname
        /// </summary>
        private string LastName { get; set; }
        #endregion

        /// <summary>
        /// implimenation for GetFullName method
        /// </summary>
        /// <returns></returns>
        public string GetFullName()
        {
            return this.LastName + " " + this.FirstName;
        }

        /// <summary>
        /// implimenation for SetCustomerName method
        /// </summary>
        /// <param name="lastName">lastname</param>
        /// <param name="firstName">firstname</param>
        public void SetCustomerName(string lastName, string firstName)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
        }
    }
}
