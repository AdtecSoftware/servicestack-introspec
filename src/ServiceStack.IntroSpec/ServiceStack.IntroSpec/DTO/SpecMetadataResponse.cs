﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this 
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

namespace ServiceStack.IntroSpec.DTO
{
    using System.Collections.Generic;

    public class SpecMetadataResponse
    {
        public IEnumerable<string> DtoNames { get; set; }
        public IEnumerable<DtoGrouping> Categories { get; set; }
        public IEnumerable<DtoGrouping> Tags { get; set; }
    }
}