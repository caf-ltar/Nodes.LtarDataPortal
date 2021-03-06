﻿using Nsar.Nodes.LtarDataPortal.Meteorology.Dto;
using System.Collections.Generic;

namespace Nsar.Nodes.LtarDataPortal.Meteorology.Core
{
    public interface ILoadMeteorology
    {
        void Load(List<COReDataRecord> data);
    }
}