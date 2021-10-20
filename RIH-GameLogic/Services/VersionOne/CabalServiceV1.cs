using RIH_GameLogic.Models.VersionOne;
using RIH_GameLogic.Models.VersionOne.Requests;
using RIH_GameLogic.Repo.VersionOne.Interfaces;
using RIH_GameLogic.Services.VersionOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Services.VersionOne
{
    public class CabalServiceV1 : ICabalServiceV1
    {
        ICabalRepoV1 _cabalRepo;
        IDemonRepoV1 _demonRepo;

        public CabalServiceV1(ICabalRepoV1 cabalRepo, IDemonRepoV1 demonRepo)
        {
            _cabalRepo = cabalRepo;
            _demonRepo = demonRepo;
        }

        public Cabal CreateCabal(CabalAddRequests cabalAddRequests)
        {
            Cabal cabal = _cabalRepo.CreateCabal(cabalAddRequests);
            if (cabal.Equals(null)) return cabal;
            cabal.units = new List<BaseUnit>();
            cabalAddRequests.units.ForEach(unit => cabal.units.Add(_demonRepo.AddDemon(unit, cabal.id)));
            return cabal;
        }
    }
}
