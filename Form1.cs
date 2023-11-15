namespace Fitters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //InitializeComponent();
            ProductBulk bp = new BulkProduct("m¹ka gryczana");
            MealProduct mealProduct = new MealProduct(bp);

            Product p = (Product)bp;
            Console.WriteLine(bp is Product);
            mealProduct.product.showName();
        }
    }
}