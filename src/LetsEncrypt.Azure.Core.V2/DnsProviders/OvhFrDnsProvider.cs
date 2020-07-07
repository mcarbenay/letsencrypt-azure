using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LetsEncrypt.Azure.Core.V2.DnsProviders
{
    public class OvhFrDnsProvider : IDnsProvider
    {
        public int MinimumTtl
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Task Cleanup(string recordSetName)
        {
            throw new NotImplementedException();
        }

        public Task PersistChallenge(string recordSetName, string recordValue)
        {
            throw new NotImplementedException();
        }
    }
}
