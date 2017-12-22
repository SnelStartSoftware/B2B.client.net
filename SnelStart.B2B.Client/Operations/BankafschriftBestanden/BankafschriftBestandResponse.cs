using System.Collections.Generic;

namespace SnelStart.B2B.Client.Operations
{
    public class BankafschriftBestandResponse
    {
        /// <summary>
        /// De naam van het bestand
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<BankafschriftBestandResponseError> Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsSuccess { get; set; }
    }
}