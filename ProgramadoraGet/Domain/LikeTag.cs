﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramadoraGet.Domain
{
    public class LikeTag
    {
        public Guid UserId { get; set; }

        public Guid TagId { get; set; }

        #region Navigation

        public virtual User User { get; set; }

        public virtual Tag Tag { get; set; }

        #endregion
    }
}
