﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramadoraGet.Domain
{
    public class Question
    {
        public Guid Id { get; set; }

        public string Content { get; set; }

        public string Title { get; set; }

        public Guid UserId { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }


        #region Navigation

        public virtual ICollection<Comment> Comment { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<QuestionTag> QuestionTag { get; set; }
        #endregion
    }
}
