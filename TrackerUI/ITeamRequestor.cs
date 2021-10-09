using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Model;

namespace TrackerUI
{
    public interface ITeamRequestor
    {
        void TeamComplete(TeamModel model);
    }
}
