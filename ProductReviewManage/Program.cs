using System;
using System.Collections.Generic;


namespace ProductReviewManage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WElcome to product review management");
            List<ProductReview> productReviewList = new List<ProductReview>();
            {
                new ProductReview() { productId = 1, userId = 1, rating = 5, review = "Good", isLike = true };
                new ProductReview() { productId = 1, userId = 1, rating = 5, review = "Good", isLike = true };
                new ProductReview() { productId = 1, userId = 1, rating = 5, review = "Good", isLike = true };
                new ProductReview() { productId = 1, userId = 1, rating = 5, review = "Good", isLike = true };
                new ProductReview() { productId = 1, userId = 1, rating = 5, review = "Good", isLike = true };
                new ProductReview() { productId = 1, userId = 1, rating = 5, review = "Good", isLike = true };
                new ProductReview() { productId = 1, userId = 1, rating = 5, review = "Good", isLike = true };
                new ProductReview() { productId = 1, userId = 1, rating = 5, review = "Good", isLike = true };
                new ProductReview() { productId = 1, userId = 1, rating = 5, review = "Good", isLike = true };
                new ProductReview() { productId = 1, userId = 1, rating = 5, review = "Good", isLike = true };
                new ProductReview() { productId = 1, userId = 1, rating = 5, review = "Good", isLike = true };
            };
        }
    }
}
