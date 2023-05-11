﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Core.DTOs
{
    public class CommentUpdateDto
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }

    }
}
