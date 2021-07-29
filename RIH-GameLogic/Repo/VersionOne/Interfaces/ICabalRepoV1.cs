using RIH_GameLogic.Models.VersionOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Repo.VersionOne.Interfaces
{
    public interface ICabalRepoV1
    {
        public Cabal CreateCabalInSQL(List<BaseUnit> newCabal);
    }
}
