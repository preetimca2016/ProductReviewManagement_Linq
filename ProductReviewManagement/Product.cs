using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{

    public class Products
    {
        public static void AddingProductReview(List<ProductReviews> products)
        {
            products.Add(new ProductReviews() { productId = 1, userId = 1, review = "Good", rating = 14, isLike = true });
            products.Add(new ProductReviews() { productId = 2, userId = 2, review = "Average", rating = 12, isLike = true });
            products.Add(new ProductReviews() { productId = 3, userId = 4, review = "Good", rating = 19, isLike = true });
            products.Add(new ProductReviews() { productId = 2, userId = 5, review = "Bad", rating = 7, isLike = false });
            products.Add(new ProductReviews() { productId = 1, userId = 1, review = "Very Good", rating = 19, isLike = true });
            products.Add(new ProductReviews() { productId = 2, userId = 6, review = "Average", rating = 10, isLike = true });
            products.Add(new ProductReviews() { productId = 4, userId = 7, review = "Good", rating = 15, isLike = true });
            products.Add(new ProductReviews() { productId = 9, userId = 8, review = "Average", rating = 11, isLike = true });
            products.Add(new ProductReviews() { productId = 3, userId = 9, review = "Bad", rating = 6, isLike = false });
            products.Add(new ProductReviews() { productId = 5, userId = 4, review = "Average", rating = 13, isLike = true });
            DisplayRecord(products);
        }
        public static void DisplayRecord(List<ProductReviews> products)
        {
            foreach (ProductReviews product in products)
            {
                Console.WriteLine("ProductId:{0}\t UserId:{1}\t Review:{2}\tRating:{3}\tIsLike:{4}\t", product.productId, product.userId, product.review, product.rating, product.isLike);
            }
        }
        public static void RetrieveTopThreeRating(List<ProductReviews> products)
        {
            AddingProductReview(products);
            Console.WriteLine("\nRetrieving Top Three Records Based On Rating\n");
            var res = (from product in products orderby product.rating descending select product).Take(3).ToList();
            DisplayRecord(res);

        }
    }
}
