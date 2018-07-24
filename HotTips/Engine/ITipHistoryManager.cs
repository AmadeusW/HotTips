﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotTips
{
    public interface ITipHistoryManager
    {
        List<string> GetTipHistory();
        bool HasTipBeenSeen(string globalTipId);
        void MarkTipAsSeen(string globalTipId);
        void ClearTipHistory();
        bool IsTipGroupExcluded(string tipGroupId);
        void MarkTipGroupAsExcluded(string tipGroupId);
        void MarkTipGroupAsIncluded(string tipGroupId);
        Task SetCadenceAsync(string cadence);
        string GetCadence();
        Task SetLastDisplayTimeAsync(DateTime dateTime);
        DateTime GetLastDisplayTime();
    }
}