using RIH_GameLogic.Models.VersionOne.GameTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Repo.VersionOne.Interfaces
{
    public interface IRestrictionRepoV1
    {
        Restrictions CreateRestrictions(Restrictions restrictions);
    }
}
