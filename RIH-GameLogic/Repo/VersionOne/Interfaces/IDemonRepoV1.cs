using RIH_GameLogic.Models.VersionOne;
using RIH_GameLogic.Models.VersionOne.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Repo.VersionOne.Interfaces
{
    public interface IDemonRepoV1
    {
        BaseUnit AddDemon(BaseUnit unit);
        BaseUnit AddDemon(BaseUnit unit, int cabalId);
    }
}
