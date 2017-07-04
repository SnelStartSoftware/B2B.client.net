using System.Collections.Generic;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Een basis object voor het terugmelden van fouten uit de B2B-Api.
    /// </summary>
    public class Error
    {

        protected bool Equals(Error other)
        {
            return string.Equals(ErrorCode, other.ErrorCode);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Error)obj);
        }

        public override int GetHashCode()
        {
            return ErrorCode?.GetHashCode() ?? 0;
        }

        private static readonly List<Error> AllErrors = new List<Error>();

        private Error(Error error, string details)
        {
            Message = error.Message;
            ErrorCode = error.ErrorCode;
            Details = details;
        }

        protected Error(string errorPrefix, int errorCode, string message)
        {
            ErrorCode = $"{errorPrefix}-{errorCode:0000}";
            Message = message;

            AllErrors.Add(this);
        }

        public Error AddDetails(Error error, string details)
        {
            return new Error(error, details);
        }
        /// <summary>
        /// De unieke code van de fout (readonly).
        /// </summary>
        public string ErrorCode { get; }

        /// <summary>
        /// De leesbare melding van de fout (readonly).
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// De deatils indien aanwezig (readonly).
        /// </summary>
        public string Details { get; private set; }

        public static Error IdInModelIsNotEmpty => new Error("ALG", 100, "Het ID dient leeg te zijn");

        public static Error IdInUrlAndModelDoNotMatch => new Error("ALG", 101, "Het ID in het url en het ID van de data in het request komen niet overeen");

        public static Error UnknownError => new Error("ALG", 102, "Onbekende fout");

        public static Error InvalidId => new Error("ALG", 103, "Ongeldig ID");

        public static Error InvalidOdataFilter => new Error("ALG", 104, "Ongeldig OData filter");


    }
}