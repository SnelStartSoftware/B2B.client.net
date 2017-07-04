using System;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Een container voor een uniek identificeerbare sleutel van een object.
    /// </summary>
    public class IdentifierModel : IIdentifierModel
    {
        private readonly string _resource;

        /// <summary>
        /// Geeft een instantie van een <see cref="IdentifierModel"/> terug.
        /// </summary>
        /// <param name="resource">De naam van resource (type object) waartoe deze identifier behoort.</param>
        public IdentifierModel(string resource)
        {
            _resource = resource;
        }

        /// <summary>
        /// Geeft de naam van de resource (type object) terug waartoe deze identifier behoort.
        /// </summary>
        protected virtual string Resource()
        {
            return _resource;
        }

        /// <summary>
        /// De publieke sleutel (public identifier, als <see cref="Guid"/>) dat uniek een object identificeert.
        /// </summary>
        public Guid Id { get; set; }


        /// <summary>
        /// Geeft de realtieve <see cref="Uri"/> terug van het object waartoe de identifier behoort.
        /// </summary>
        public Uri Uri => new Uri($"/{Resource()}/{Id}", UriKind.Relative);


        protected bool Equals(IdentifierModel other)
        {
            return string.Equals(_resource, other._resource) && Id.Equals(other.Id);
        }


        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((IdentifierModel)obj);
        }


        public override int GetHashCode()
        {
            unchecked
            {
                return ((_resource != null ? _resource.GetHashCode() : 0) * 397) ^ Id.GetHashCode();
            }
        }
    }
}