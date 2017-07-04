using System;
using SnelStart.B2B.Client.Operations;
using SnelStart.B2B.Client.Operations.Kostenplaatsen;

namespace SnelStart.B2B.Client
{
    public interface IB2BClient : IDisposable
    {
        IAuthenticationOperations Authentication { get; }
        IKostenplaatsenOperations Kostenplaatsen{ get; }
    }
}