using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Model;

namespace TrackerUI
{
    public interface IPrizeRequestor
    {
        void PrizeComplete(PrizeModel model);
    }
}
