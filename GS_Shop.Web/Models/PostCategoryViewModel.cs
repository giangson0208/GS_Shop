﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace GS_Shop.Web.Models
{
    public class PostCategoryViewModel
    {
        public int ID { set; get; }

        public string Name { set; get; }

        public string Alias { set; get; }

        public string Image { set; get; }

        public string Description { set; get; }

        public int? DisplayOrder { set; get; }

        public bool? HomeFlag { set; get; }

        public int? ParentID { set; get; }

        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { set; get; }

        public DateTime? UpdateDate { set; get; }

        public string UpdateBy { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        public bool Status { set; get; }

        public virtual IEnumerable<PostViewModel> Posts { set; get; }
    }
}