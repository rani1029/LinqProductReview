using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReviewManage
{
    class ProductReview
    {
        public int productId
        {
            get;
            set;
        }
        public int userId
        {
            get;
            set;
        }
        public double rating
        {
            get;
            set;
        }
        public string review
        {
            get;
            set;
        }
        public bool isLike
        {
            get;
            set;
        }
    }
}
