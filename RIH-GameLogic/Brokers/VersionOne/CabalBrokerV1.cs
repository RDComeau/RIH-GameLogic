using RIH_GameLogic.Brokers.VersionOne.Interfaces;
using RIH_GameLogic.Models.VersionOne;
using RIH_GameLogic.Models.VersionOne.Requests;
using RIH_GameLogic.Services.VersionOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Brokers.VersionOne
{
    public class CabalBrokerV1 : ICabalBrokerV1
    {
        private ICabalServiceV1 _service;

        public CabalBrokerV1(ICabalServiceV1 service)
        {
            _service = service;
        }

        //public Cabal CreateCabal(CabalAddRequests addCabal)
       // {
            //return _service.CreateCabal(addCabal);
        //}
    }
}
