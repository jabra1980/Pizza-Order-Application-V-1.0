using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Order
{
    public class Pizza
    {
        
        private string? Bread;
        private string? SizeInch;
        private string? Sauce;
        private string? Cheese;
        private string? Protein;
        private string? Vegetable;
        private string? PizzaName;
        private string? Description;
        private List<string> Toppings;
        private List<string> items;

        public Pizza()
        {
            this.Toppings = new List<string>();
            this.items = new List<string>() { "Black Olives", "Green Pepper", "Mushroom", "Onion", "Tomatoes", "Jalapeno Peppers" };
        }


        public void SetDescription(PizzaType pizzaType)
        {

            switch (pizzaType)
            {
                case PizzaType.Veggie:
                    this.Description = "A medley of fresh green peppers, onion, tomatoes, mushrooms, and olives";
                    break;
                case PizzaType.Hawaiian:
                    this.Description = "Succulent pineapple and slices of ham topped with an extra layer of cheese";
                    break;
                case PizzaType.MeatZZa:
                    this.Description = "Slice after slice of pepperoni, ham, savory Italian sausage and beef crumble topped with an extra layer of cheese.";
                    break;
            }

        }
        public void SetBread(PizzaType pizzaType)
        {
            
            switch (pizzaType)
            {
                case PizzaType.Veggie:

                    Console.WriteLine("\tCHOOSE YOUR CRUST");
                    Console.WriteLine("1- ORIGINAL HAND TOSSED");
                    Console.WriteLine("2- CRUNCHY THIN CRUST");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            this.Bread = "ORIGINAL HAND TOSSED";
                            break;
                        case 2:
                            this.Bread = "CRUNCHY THIN CRUST";
                            break;
                    }
                    break;
                
                case PizzaType.Hawaiian:

                    Console.WriteLine("\tCHOOSE YOUR CRUST");
                    Console.WriteLine("1- ORIGINAL HAND TOSSED");
                    Console.WriteLine("2- CRUNCHY THIN CRUST");
                    int option1 = Convert.ToInt32(Console.ReadLine());
                    switch (option1)
                    {
                        case 1:
                            this.Bread = "ORIGINAL HAND TOSSED";
                            break;
                        case 2:
                            this.Bread = "CRUNCHY THIN CRUST";
                            break;
                    }
                    break;
                
                case PizzaType.MeatZZa:

                    Console.WriteLine("\tCHOOSE YOUR CRUST");
                    Console.WriteLine("1- ORIGINAL HAND TOSSED");
                    Console.WriteLine("2- CRUNCHY THIN CRUST");
                    int option2 = Convert.ToInt32(Console.ReadLine());
                    switch (option2)
                    {
                        case 1:
                            this.Bread = "ORIGINAL HAND TOSSED";
                            break;
                        case 2:
                            this.Bread = "CRUNCHY THIN CRUST";
                            break;
                    }
                    break;
            }
        }
        public void SetSizeInch(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Veggie:

                    Console.WriteLine("\tCHOOSE YOUR SIZE");
                    Console.WriteLine("1- Small (10\")");
                    Console.WriteLine("2- Medium (12\")");
                    Console.WriteLine("3- Large (14\")");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            this.SizeInch = "Small (10\")";
                            break;
                        case 2:
                            this.SizeInch = "Medium (12\")";
                            break;
                        case 3:
                            this.SizeInch = "Large (14\")";
                            break;
                    }
                    break;

                case PizzaType.Hawaiian:

                    Console.WriteLine("\tCHOOSE YOUR SIZE");
                    Console.WriteLine("1- Small (10\")");
                    Console.WriteLine("2- Medium (12\")");
                    Console.WriteLine("3- Large (14\")");
                    int option1 = Convert.ToInt32(Console.ReadLine());
                    switch (option1)
                    {
                        case 1:
                            this.SizeInch = "Small (10\")";
                            break;
                        case 2:
                            this.SizeInch = "Medium (12\")";
                            break;
                        case 3:
                            this.SizeInch = "Large (14\")";
                            break;
                    }
                    break;

                case PizzaType.MeatZZa:

                    Console.WriteLine("\tCHOOSE YOUR SIZE");
                    Console.WriteLine("1- Small (10\")");
                    Console.WriteLine("2- Medium (12\")");
                    Console.WriteLine("3- Large (14\")");
                    int option2 = Convert.ToInt32(Console.ReadLine());
                    switch (option2)
                    {
                        case 1:
                            this.SizeInch = "Small (10\")";
                            break;
                        case 2:
                            this.SizeInch = "Medium (12\")";
                            break;
                        case 3:
                            this.SizeInch = "Large (14\")";
                            break;
                    }
                    break;
            }
        }
        public void SetSauce(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Veggie:

                    Console.WriteLine("\tCHOOSE A SAUCE");
                    Console.WriteLine("1- Pizza Sauce");
                    Console.WriteLine("2- BBQ Sauce");
                    Console.WriteLine("3- Garlic Parmesan Sauce");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            this.Sauce = "Pizza Sauce";
                            break;
                        case 2:
                            this.Sauce = "BBQ Sauce";
                            break;
                        case 3:
                            this.Sauce = "Garlic Parmesan Sauce";
                            break;
                    }
                    break;

                case PizzaType.Hawaiian:

                    Console.WriteLine("\tCHOOSE A SAUCE");
                    Console.WriteLine("1- Pizza Sauce");
                    Console.WriteLine("2- BBQ Sauce");
                    Console.WriteLine("3- Garlic Parmesan Sauce");
                    int option1 = Convert.ToInt32(Console.ReadLine());
                    switch (option1)
                    {
                        case 1:
                            this.Sauce = "Pizza Sauce";
                            break;
                        case 2:
                            this.Sauce = "BBQ Sauce";
                            break;
                        case 3:
                            this.Sauce = "Garlic Parmesan Sauce";
                            break;
                    }
                    break;

                case PizzaType.MeatZZa:

                    Console.WriteLine("\tCHOOSE A SAUCE");
                    Console.WriteLine("1- Pizza Sauce");
                    Console.WriteLine("2- BBQ Sauce");
                    Console.WriteLine("3- Garlic Parmesan Sauce");
                    int option2 = Convert.ToInt32(Console.ReadLine());
                    switch (option2)
                    {
                        case 1:
                            this.Sauce = "Pizza Sauce";
                            break;
                        case 2:
                            this.Sauce = "BBQ Sauce";
                            break;
                        case 3:
                            this.Sauce = "Garlic Parmesan Sauce";
                            break;
                    }
                    break;
            }

        }
        public void SetCheese(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Veggie:

                    Console.WriteLine("\tCHOOSE A CHEESE");
                    Console.WriteLine("1- Light");
                    Console.WriteLine("2- Normal");
                    Console.WriteLine("3- Extra");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            this.Cheese = "Light";
                            break;
                        case 2:
                            this.Cheese = "Normal";
                            break;
                        case 3:
                            this.Cheese = "Extra";
                            break;
                    }
                    break;

                case PizzaType.Hawaiian:

                    Console.WriteLine("\tCHOOSE A CHEESE");
                    Console.WriteLine("1- Light");
                    Console.WriteLine("2- Normal");
                    Console.WriteLine("3- Extra");
                    int option1 = Convert.ToInt32(Console.ReadLine());
                    switch (option1)
                    {
                        case 1:
                            this.Cheese = "Light";
                            break;
                        case 2:
                            this.Cheese = "Normal";
                            break;
                        case 3:
                            this.Cheese = "Extra";
                            break;
                    }
                    break;

                case PizzaType.MeatZZa:

                    Console.WriteLine("\tCHOOSE A CHEESE");
                    Console.WriteLine("1- Light");
                    Console.WriteLine("2- Normal");
                    Console.WriteLine("3- Extra");
                    int option2 = Convert.ToInt32(Console.ReadLine());
                    switch (option2)
                    {
                        case 1:
                            this.Cheese = "Light";
                            break;
                        case 2:
                            this.Cheese = "Normal";
                            break;
                        case 3:
                            this.Cheese = "Extra";
                            break;
                    }
                    break;
            }
        }
        public void SetProtein(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Veggie:

                    this.Protein = "N/A";
                    break;

                case PizzaType.Hawaiian:

                    Console.WriteLine("\tCHOOSE MEATS");
                    Console.WriteLine("1- Chicken");
                    Console.WriteLine("2- Ham");
                    Console.WriteLine("3- Pepperoni");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            this.Protein = "Chicken";
                            break;
                        case 2:
                            this.Protein = "Ham";
                            break;
                        case 3:
                            this.Protein = "Pepperoni";
                            break;
                    }
                    break;

                case PizzaType.MeatZZa:
                    
                    Console.WriteLine("\tCHOOSE MEATS");
                    Console.WriteLine("1- Chicken");
                    Console.WriteLine("2- Ham");
                    Console.WriteLine("3- Pepperoni");
                    int option1 = Convert.ToInt32(Console.ReadLine());
                    switch (option1)
                    {
                        case 1:
                            this.Protein = "Chicken";
                            break;
                        case 2:
                            this.Protein = "Ham";
                            break;
                        case 3:
                            this.Protein = "Pepperoni";
                            break;
                    }

                    break;
            }
        }
        public void SetVegetable(PizzaType pizzaType)
        {
            char ans;
            switch (pizzaType)
            {
                case PizzaType.Veggie:
                    do
                    {
                        Console.WriteLine("\tCHOOSE Vegetables");
                        Console.WriteLine("1- Black Olives");
                        Console.WriteLine("2- Green Pepper");
                        Console.WriteLine("3- Mushroom");
                        Console.WriteLine("4- Onion");
                        Console.WriteLine("5- Tomatoes");
                        Console.WriteLine("6- Jalapeno Peppers");
                        Console.WriteLine("7- Select All");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                this.Vegetable = "Black Olives";
                                Toppings.Add(this.Vegetable);
                                break;

                            case 2:
                                this.Vegetable = "Green Pepper";
                                Toppings.Add(this.Vegetable);
                                break;

                            case 3:
                                this.Vegetable = "Mushroom";
                                Toppings.Add(this.Vegetable);
                                break;

                            case 4:
                                this.Vegetable = "Onion";
                                Toppings.Add(this.Vegetable);
                                break;

                            case 5:
                                this.Vegetable = "Tomatoes";
                                Toppings.Add(this.Vegetable);
                                break;

                            case 6:
                                this.Vegetable = "Jalapeno Peppers";
                                Toppings.Add(this.Vegetable);
                                break;

                            case 7:
                                for (int i = 0; i < items.Count; i++)
                                {
                                    Toppings.Add(items[i]);
                                }
                                break;
                        }
                        Console.WriteLine("Would you like to Add more toppings? Press (Y, N)");
                        ans = Convert.ToChar(Console.ReadLine().ToLower());
                    } while (ans == 'y');
                      
                    break;

                case PizzaType.Hawaiian:

                    do
                    {
                        Console.WriteLine("\tCHOOSE Vegetables");
                        Console.WriteLine("1- Black Olives");
                        Console.WriteLine("2- Green Pepper");
                        Console.WriteLine("3- Mushroom");
                        Console.WriteLine("4- Onion");
                        Console.WriteLine("5- Tomatoes");
                        Console.WriteLine("6- Jalapeno Peppers");
                        Console.WriteLine("7- Select All");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                this.Vegetable = "Black Olives";
                                Toppings.Add(this.Vegetable);
                                break;

                            case 2:
                                this.Vegetable = "Green Pepper";
                                Toppings.Add(this.Vegetable);
                                break;

                            case 3:
                                this.Vegetable = "Mushroom";
                                Toppings.Add(this.Vegetable);
                                break;

                            case 4:
                                this.Vegetable = "Onion";
                                Toppings.Add(this.Vegetable);
                                break;

                            case 5:
                                this.Vegetable = "Tomatoes";
                                Toppings.Add(this.Vegetable);
                                break;

                            case 6:
                                this.Vegetable = "Jalapeno Peppers";
                                Toppings.Add(this.Vegetable);
                                break;
                            
                            case 7:
                                for (int i = 0; i < items.Count; i++)
                                {
                                    Toppings.Add(items[i]);
                                }
                                break;
                        }
                        Console.WriteLine("Would you like to Add more toppings? Press (Y, N)");
                        ans = Convert.ToChar(Console.ReadLine().ToLower());
                    } while (ans == 'y');

                    break;

                case PizzaType.MeatZZa:

                    do
                    {
                        Console.WriteLine("\tCHOOSE Vegetables");
                        Console.WriteLine("1- Black Olives");
                        Console.WriteLine("2- Green Pepper");
                        Console.WriteLine("3- Mushroom");
                        Console.WriteLine("4- Onion");
                        Console.WriteLine("5- Tomatoes");
                        Console.WriteLine("6- Jalapeno Peppers");
                        Console.WriteLine("7- Select All");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                this.Vegetable = "Black Olives";
                                Toppings.Add(this.Vegetable);
                                break;

                            case 2:
                                this.Vegetable = "Green Pepper";
                                Toppings.Add(this.Vegetable);
                                break;

                            case 3:
                                this.Vegetable = "Mushroom";
                                Toppings.Add(this.Vegetable);
                                break;

                            case 4:
                                this.Vegetable = "Onion";
                                Toppings.Add(this.Vegetable);
                                break;

                            case 5:
                                this.Vegetable = "Tomatoes";
                                Toppings.Add(this.Vegetable);
                                break;

                            case 6:
                                this.Vegetable = "Jalapeno Peppers";
                                Toppings.Add(this.Vegetable);
                                break;
                            
                            case 7:
                                for (int i = 0; i < items.Count; i++)
                                {
                                    Toppings.Add(items[i]);
                                }
                                break;
                        }
                        Console.WriteLine("Would you like to Add more toppings? Press (Y, N)");
                        ans = Convert.ToChar(Console.ReadLine().ToLower());
                    } while (ans == 'y');
                    break;
            }
        }
        public void SetPizzaName(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Veggie:
                    this.PizzaName = "Veggie";
                    break;
                case PizzaType.Hawaiian:
                    this.PizzaName = "Hawaiian";
                    break;
                case PizzaType.MeatZZa:
                    this.PizzaName = "MeatZZa";
                    break;
                default:
                    break;
            }

        }




        public string GetDescription()
        {
            return Description;
        }
        public string GetBread()
        {
            return Bread;
        }
        public string GetSize()
        {
            return SizeInch;
        }
        public string GetSauce()
        {
            return Sauce;
        }
        public string GetCheese()
        {
            return Cheese;
        }
        public string GetProtein()
        {
            return Protein;
        }
        public string GetVegetable()
        {
            string Topping = string.Join(", ", Toppings);
            return Topping;
        }
        public string GetPizzaName()
        {
            return PizzaName;
        }


        public void Display()
        {
            Console.WriteLine($"Pizza Name: {GetPizzaName()}");
            Console.WriteLine("======================================");
            Console.WriteLine($"Bread: {GetBread()}");
            Console.WriteLine($"Sauce: {GetSauce()}");
            Console.WriteLine($"SizeInch: {GetSize()}");
            Console.WriteLine($"Cheese: {GetCheese()}");
            Console.WriteLine($"Protein: {GetProtein()}");
            Console.WriteLine($"Vegetable: {GetVegetable()}\n");
            Console.WriteLine($"Description: {GetDescription()}\n");

        }
    }
}
