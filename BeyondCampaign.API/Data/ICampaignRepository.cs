﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyondCampaign.API.Data
{
    internal interface ICampaignRepository
    {
        Task<bool> CampaignExists(int id);
    }
}
