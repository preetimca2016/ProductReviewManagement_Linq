namespace ProductReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management system");
            Console.WriteLine("\n1.Add Values to list \n2.Retrieve Top 3 Records \n3.Retrieve Records Based On Rating and Product Id \n4.Retrived the count \n5.Retrieving the product id \nEnter Option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            //Creating a list for Product Review 
            List<ProductReviews> productReviews = new List<ProductReviews>();
            switch (option)
            {
                case 1:
                    Products.AddingProductReview(productReviews);
                    break;
                case 2:
                    Products.RetrieveTopThreeRating(productReviews);
                    break;
                case 3:
                    Products.RetrieveRecordsBasedOnRatingAndProductId(productReviews);
                    break;
                case 4:
                    Products.CountingProductId(productReviews);
                    break;
                case 5:
                    Products.RetrieveOnlyProductIdAndReviews(productReviews);
                    break;
                case 6:
                    Products.SkipTopFiveRecords(productReviews);
                    break;

            }
        }
    }
}