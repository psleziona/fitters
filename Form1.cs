namespace Fitters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ProductBulk bp = new ProductBulk("m¹ka gryczana", 12.2, 10.4, 10.2);
            MealProduct mealProduct = new MealProduct(bp);

            Product p = (Product)bp;
            Console.WriteLine(bp is Product);
        }
    }
}