using System;

namespace CreationalDesign
{
    // ==========================================
    // 1. ABSTRACT PRODUCTS (The Menu Items)
    // ==========================================
    public interface IMainCourse
    {
        void Consume();
    }

    public interface IDessert
    {
        void Enjoy();
    }

    // ==========================================
    // 2. CONCRETE PRODUCTS: Italian Family
    // ==========================================
    public class Pizza : IMainCourse
    {
        public void Consume() => Console.WriteLine("Eating a delicious Wood-fired Margherita Pizza.");
    }

    public class Tiramisu : IDessert
    {
        public void Enjoy() => Console.WriteLine("Enjoying a creamy, coffee-flavored Tiramisu.");
    }

    // ==========================================
    // 3. CONCRETE PRODUCTS: Fast Food Family
    // ==========================================
    public class Burger : IMainCourse
    {
        public void Consume() => Console.WriteLine("Chomping down on a juicy Double Cheeseburger.");
    }

    public class IceCream : IDessert
    {
        public void Enjoy() => Console.WriteLine("Cooling down with a scoop of Vanilla Ice Cream.");
    }

    // ==========================================
    // 4. ABSTRACT FACTORY (The Restaurant Kitchen)
    // ==========================================
    public interface IRestaurantFactory
    {
        IMainCourse CreateMainCourse();
        IDessert CreateDessert();
    }

    // ==========================================
    // 5. CONCRETE FACTORIES (Specific Kitchens)
    // ==========================================
    public class ItalianRestaurantFactory : IRestaurantFactory
    {
        public IMainCourse CreateMainCourse() => new Pizza();
        public IDessert CreateDessert() => new Tiramisu();
    }

    public class FastFoodRestaurantFactory : IRestaurantFactory
    {
        public IMainCourse CreateMainCourse() => new Burger();
        public IDessert CreateDessert() => new IceCream();
    }

    // ==========================================
    // 6. CLIENT CODE (The Diner)
    // ==========================================
    public class Diner
    {
        private readonly IMainCourse _mainCourse;
        private readonly IDessert _dessert;

        // The diner doesn't care WHAT specific restaurant it is, 
        // as long as it gets a cohesive meal family.
        public Diner(IRestaurantFactory factory)
        {
            _mainCourse = factory.CreateMainCourse();
            _dessert = factory.CreateDessert();
        }

        public void EatMeal()
        {
            _mainCourse.Consume();
            _dessert.Enjoy();
        }
    }

    // ==========================================
    // 7. EXECUTION
    // ==========================================
    class AbstractFactory
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Ordering from the Italian Restaurant ---");
            IRestaurantFactory italianKitchen = new ItalianRestaurantFactory();
            Diner basicDiner = new Diner(italianKitchen);
            basicDiner.EatMeal();

            Console.WriteLine("\n--- Ordering from the Fast Food Restaurant ---");
            IRestaurantFactory fastFoodKitchen = new FastFoodRestaurantFactory();
            Diner fastFoodDiner = new Diner(fastFoodKitchen);
            fastFoodDiner.EatMeal();
        }
    }
}