using RIH_GameLogic.Models.VersionOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Services.VersionOne.Interfaces
{
    public interface ICabalServiceV1
    {
        public Cabal CreateCabal(List<BaseUnit> newCabal);
    }
}
