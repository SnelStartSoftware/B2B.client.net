using System;

namespace SnelStart.B2B.Client.Operations
{
    public interface IIdentifierModel
    {
        Guid Id { get; }
        Uri Uri { get; }
    }
}