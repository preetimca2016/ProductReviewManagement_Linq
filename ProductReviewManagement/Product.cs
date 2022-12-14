using System;
using System.Collections.Generic;
using System.Data;
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
        public static void RetrieveRecordsBasedOnRatingAndProductId(List<ProductReviews> products)
        {
            AddingProductReview(products);
            Console.WriteLine("\nRetrieve Records Based On Rating and Product Id\n");
            var res = (from product in products where product.rating > 3 && (product.productId == 1 || product.productId == 4 || product.productId == 9) select product).ToList();
            DisplayRecord(res);
        }
        public static void CountingProductId(List<ProductReviews> products)
        {
            AddingProductReview(products);
            var data = products.GroupBy(x => x.productId).Select(a => new { ProductId = a.Key, count = a.Count() });
            Console.WriteLine(data);
            foreach (var ele in data)
            {
                Console.WriteLine("ProductId " + ele.ProductId + " " + "Count " + " " + ele.count);
            }
        }
        public static void RetrieveOnlyProductIdAndReviews(List<ProductReviews> products)
        {
            AddingProductReview(products);
            var res = products.Select(product => new { ProductId = product.productId, Review = product.review }).ToList();
            foreach (var ele in res)
            {
                Console.WriteLine("ProductId " + ele.ProductId + " " + "Review " + " " + ele.Review);
            }
        }
        public static void SkipTopFiveRecords(List<ProductReviews> products)
        {
            AddingProductReview(products);
            Console.WriteLine("\n Skip Top Five records in list");
            var res = (from product in products orderby product.rating descending select product).Skip(5).ToList();
            DisplayRecord(res);
        }
        //UC-8 DataTable Create
        public static void CreateDataTable(List<ProductReviews> products)
        {
            AddingProductReview(products);
            DataTable dt = new DataTable();
            dt.Columns.Add("productId");
            dt.Columns.Add("userId");
            dt.Columns.Add("rating");
            dt.Columns.Add("review");
            dt.Columns.Add("isLike", typeof(bool));

            foreach (var data in products)
            {
                dt.Rows.Add(data.productId, data.userId, data.rating, data.review, data.isLike);
            }
            DisplayTable(dt);
        }

        private static void DisplayTable(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}
