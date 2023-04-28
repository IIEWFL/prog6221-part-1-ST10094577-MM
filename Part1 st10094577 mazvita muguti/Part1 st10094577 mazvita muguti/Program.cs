using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_st10094577_mazvita_muguti
{
    internal class Program
    {
        private static object quantity;
        private static string name;

        class Step
        {
            public string description;
        }


        class Recipe
        {
            private List<Ingredient> ingredients;
            private List<Step> steps;
            private int number;
            private static string input;

            public Recipe()
            {
                ingredients = new List<Ingredient>();
                steps = new List<Step>();
            }
            public void AddIngredient(string name, double quantity, string unit)
            {
                Ingredient ingredient = new Ingredient(name, quantity, number, unit);
                ingredients.Add(ingredient);

                Console.WriteLine();

            }
            public void AddStep(string description)
            {
                steps.Add(new Step { description = description });
            }
            public void Clear()
            {
                ingredients.Clear();
                steps.Clear();
            }
            public void Scale(double factor)
            {
                foreach (Ingredient ingredient in ingredients)
                {
                    ingredient.Quantity *= factor;
                }
            }
            public void Print()
            {
                Console.WriteLine("Ingredients:");
                foreach (Ingredient ingredient in ingredients)
                {
                    Console.WriteLine("{0}{1}{2}", ingredient.Quantity, ingredient.Unit, ingredient.Name);
                }
                Console.WriteLine("\nSteps:");
                for (int i = 0; i < steps.Count; i++)
                {
                    Console.WriteLine("{0}.{1}", i + 1, steps[i].description);
                }
            }


            class Ingredients
            {
                string rname;
                string name;
                double quantity;
                string unit;
                int number;
                private object quantity1;
                private string number1;

                public Ingredients(string name, object quantity1, string number1, string unit)
                {
                    this.name = name;
                    this.quantity1 = quantity1;
                    this.number1 = number1;
                    this.unit = unit;
                }

                public string Number { get; internal set; }
                public double Quantity { get; internal set; }
                public string Unit { get; internal set; }
                public string Name { get; internal set; }
            }

            static void Main(string[] args)
            {
                Recipe recipe = new Recipe();

                Console.WriteLine("Enter the name of recipe:");
                string rname = Console.ReadLine();



                //store ingredients in a memory
                List<Ingredients> ingredients = new
                    List<Ingredients>();

                while (true)
                {
                    //prompt user for number of ingredients
                    Console.Write("Enter the number of ingredients:");
                    int numIngredients = int.Parse(Console.ReadLine());

                    for (int i = 0; i < numIngredients; i++)
                    {
                        Console.WriteLine("Enter the name of ingredient {0}:", i + 1);
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter the quantity of ingredient {0}:", i + 1);
                        double quantity = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter unit of measurement of ingredient {0}:", i + 1);
                        string unit = Console.ReadLine();
                        recipe.AddIngredient(name, quantity, unit);

                    }
                    Console.WriteLine("Enter the number of steps:");
                    int numSteps = int.Parse(Console.ReadLine());

                    for (int i = 0; i < numSteps; i++)
                    {
                        Console.WriteLine("Enter step {0}:", i + 1);
                        string description = Console.ReadLine();

                        recipe.AddStep(description);
                    }
                    Console.WriteLine("\nRecipe:" + rname);
                    recipe.Print();

                    while (true)
                    {
                        Console.WriteLine($"Enter '1' to scale recipe \n '2' reset the quantities \n'3' to clear data \n'4'to exit");
                        string input = Console.ReadLine();

                        if (input == "1")
                        {
                            Console.WriteLine("Enter the scaling factor:");
                            double factor = double.Parse(Console.ReadLine());
                            recipe.Scale(factor);
                            recipe.Print();
                        }
                        else if (input == "2")
                        {
                            recipe.Print();
                        }
                        else if (input == "3")
                        {
                            recipe.Clear();
                            break;

                        }
                        else if (input == "4")
                        {
                            return;

                        }
                    }
                }
            }




            class Ingredient
            {
                public string Name { get; set; }
                public double Quantity { get; set; }
                public int Number { get; set; }
                public string Unit { get; set; }

                public Ingredient(string name, double quantity, int number, string unit)
                {
                    Name = name;
                    Quantity = quantity;
                    Number = number;
                    Unit = unit;
                }
            }
        }
    }
}

