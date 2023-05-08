﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Core.DTOs
{
    public class CommentDetailsDto
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public int NumberOfLikes { get; set; }
        public int NumberOfDislikes { get; set; }
        public Guid UserId { get; set; }
        public Guid BookId { get; set; }

    }
}
