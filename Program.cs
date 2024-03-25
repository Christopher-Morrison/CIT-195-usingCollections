using System;
using System.Collections;
using System.Collections.Generic;

namespace usingCollections
{

    class Program
    {
        static void Main(string[] args)
        {
            // using Queue<T>
            Console.WriteLine("\nQueue<T>\n");
            Queue<string> chiliRecipes = new Queue<string>();
            chiliRecipes.Enqueue("Mom's Homemade Chili");
            chiliRecipes.Enqueue("Creamy Crockpot White Chicken Chili");
            chiliRecipes.Enqueue("NYT Chili");
            chiliRecipes.Enqueue("Award Winning Southern Soul Chili");
            chiliRecipes.Enqueue("Cowboy Chili");

            if (chiliRecipes.Contains("Award Winning Southern Soul Chili")){
                Console.WriteLine("Yes, we have Award Winning Southern Soul Chili.");
            }

            Console.WriteLine($"Removed: {chiliRecipes.Dequeue()}");
            Console.WriteLine($"Total Items left: {chiliRecipes.Count}");
            foreach ( string recipe in chiliRecipes){
                Console.WriteLine(recipe + " Recipe");
            }


            // using priorityQueue<T>
            Console.WriteLine("\nPriorityQueue<T>\n");  
             PriorityQueue<string, int> soupRecipes = new PriorityQueue<string, int>();
             soupRecipes.Enqueue("Yuba Dinner Chicken Noodle Soup", 3);
             soupRecipes.Enqueue("Mom's Green Split Pea Soup", 5);
             soupRecipes.Enqueue("Janet's Broccoli Chedar Soup",2);
             soupRecipes.Enqueue("My Beef Stew",1);
             soupRecipes.Enqueue("Creamy Beer Cheese Soup",4);
             // remove elements by highest priority
             for (int i=1; i<=5; i++){
                 Console.WriteLine($"#{i}: {soupRecipes.Dequeue()}");
             }

            // using Stack<T>
            Console.WriteLine("\nStack<T>\n");
            Stack<string>grillRecipes = new Stack<string>();
            grillRecipes.Push("Blackened Salmon");
            grillRecipes.Push("Hamburgers");
            grillRecipes.Push("Brats");
            grillRecipes.Push("Grilled Lettuce");
            grillRecipes.Push("Grilled Zucchini");

            if(grillRecipes.Contains("Brats")){
                Console.WriteLine($"Yes, the stack has brats.");
            }
            Console.WriteLine($"Removing: {grillRecipes.Pop()}");
            Console.WriteLine($"Number of remaining items: {grillRecipes.Count}");
            foreach ( string recipe in grillRecipes){
                Console.WriteLine(recipe);
            }


            // using LinkedList<T>
            Console.WriteLine("\nLinkedList<T>\n");
            LinkedList<string> casseroleRecipes = new LinkedList<string>();
            casseroleRecipes.AddFirst("Greenbean Casserole");
            casseroleRecipes.AddLast("Spinach Artichoke Casserole");
            casseroleRecipes.AddLast("Chicken and Dumplings Casserole");
            casseroleRecipes.AddLast("Campbells Pork and Rice Casserole");
            casseroleRecipes.AddLast("Scalped Potatoes");

            Console.WriteLine("First item: " + casseroleRecipes.First());
            Console.WriteLine("Last Item: " + casseroleRecipes.Last());
            LinkedListNode<string> insertLocation = casseroleRecipes.Find("Chicken and Dumplings Casserole");
            casseroleRecipes.AddAfter(insertLocation, "Quiche");
            Console.WriteLine("Removing Greenbean Casserole because nobody likes it.");
            casseroleRecipes.Remove("Greenbean Casserole");
            Console.WriteLine($"Total recipes remaining: {casseroleRecipes.Count()}");
            foreach ( string recipe in casseroleRecipes) {
                Console.WriteLine(recipe );
            }


            // using Dictionary <TKey, TValue>
            Console.WriteLine("\nDictionary<Tkey, TValue>\n");
            Dictionary<int, string> howToBuildABurger = new Dictionary<int, string>();
            howToBuildABurger.Add(1, "Toasted buns");
            howToBuildABurger.Add(2, "Copious amouts of mayonaise");
            howToBuildABurger.Add(3, "One Thick Trucker Onion");
            howToBuildABurger.Add(4, "Sliced dill pickles");
            howToBuildABurger.Add(5, "Extra strong blue cheese");
            var keys = howToBuildABurger.Keys;
            var values = howToBuildABurger.Values;
            Console.WriteLine("Keys: ");
            foreach ( int key in keys ) { Console.WriteLine(key); }
            Console.WriteLine("Values: ");
            foreach (string val in values) { Console.WriteLine(val); }
            Console.WriteLine("Key, value pairs: ");
            foreach (var step in howToBuildABurger)
            {
                Console.WriteLine($"Key: {step.Key}, Value: {step.Value}");
            }
            Console.WriteLine("Removing trucker onion because its too big for some.");
            howToBuildABurger.Remove(3);
            Console.WriteLine($"Total steps remaining: {howToBuildABurger.Count()}");


            // using SortedList<Tkey,TValue>
            Console.WriteLine("\nSortedList<Tkey, TValue>\n");
            SortedList<string, string> dessertRecipes = new SortedList<string, string>();
            dessertRecipes.Add("Pie", "keylime");
            dessertRecipes.Add("Pastry", "Grandma's Apple Squares");
            dessertRecipes.Add("Brownie", "Dad's brownies");
            dessertRecipes.Add("Cake", "Grandma's Carrot Cake");
            dessertRecipes.Add("Cookies", "My No-bake Cookies");
            Console.WriteLine("---------\nEnter your own dessert!\nWhat category of dessert is it? (cookie vs cake)\n---------");
            bool validInput = false;
            while (!validInput)
            {
                var userKey = Console.ReadLine();
                if (dessertRecipes.ContainsKey(userKey)){
                    Console.WriteLine("That category has already been used. Try again!");
                }
                else
                {
                    Console.WriteLine("What is the name of this dessert?");
                    dessertRecipes.Add(userKey, Console.ReadLine());
                    validInput = true;
                }
            }
            Console.WriteLine("Here is the complete list:\n-----------------------");
            foreach(var recipe in dessertRecipes) { Console.WriteLine($"{recipe.Key}, {recipe.Value}"); }
            Console.WriteLine("---------\nChoose one dessert to remove\n---------");
            bool removedKey = false;
            while (!removedKey){
                var removeKey = Console.ReadLine();
                if (!dessertRecipes.ContainsKey(removeKey)) {
                    Console.WriteLine("That isn't an option, please try again. Remember, case sensitive.");
                }
                else { 
                    dessertRecipes.Remove(removeKey);
                    removedKey = true;
                }
            }
            Console.WriteLine("Here is the complete list:\n-----------------------");
            foreach (var recipe in dessertRecipes) { Console.WriteLine($"{recipe.Key}, {recipe.Value}"); }

            // using HashSet<T>
            Console.WriteLine("\nHashSet<T>\n");
            HashSet <string> pantryIngredients = new HashSet<string>();
            pantryIngredients.Add("Flour");
            pantryIngredients.Add("Sugar");
            pantryIngredients.Add("Chocolate Chips");
            pantryIngredients.Add("Coarse Salt");
            pantryIngredients.Add("Brown Sugar");

            HashSet<string> cupboardIngredients = new HashSet<string>();
            cupboardIngredients.Add("Butter");
            cupboardIngredients.Add("Fine Salt");
            cupboardIngredients.Add("Rosemary");
            cupboardIngredients.Add("Pepper");
            cupboardIngredients.Add("Bread");

            HashSet<string> fridgeIngredients = new HashSet<string>();
            fridgeIngredients.Add("Butter");
            fridgeIngredients.Add("Milk");
            fridgeIngredients.Add("Eggs");
            fridgeIngredients.Add("Yogurt");
            fridgeIngredients.Add("Bread");

            pantryIngredients.UnionWith(cupboardIngredients);
            Console.WriteLine("Cupboard ingredients and Pantry Ingredients:");
            foreach (var ingredient in pantryIngredients)
            {
                Console.WriteLine(ingredient);
            }
            HashSet<string> overlapIngredients = new HashSet<string>();
            foreach (var ingredient in fridgeIngredients)
            {
                if (pantryIngredients.Contains(ingredient))
                {
                    overlapIngredients.Add (ingredient);
                }
            }
            Console.WriteLine("Overlap between fridge and pantry ingredients: ");
            foreach (var overlap in overlapIngredients) { Console.WriteLine(overlap); }


            // using List<T>
            Console.WriteLine("\nList<T>\n");
            List<string> fishRecipes = new List<string>();
            fishRecipes.Add("Lemmon Pepper Cod");
            fishRecipes.Add("Grilled Blackened Salmon");
            fishRecipes.Add("Baked Brown Sugar Salmon");
            fishRecipes.Add("Pan Fried Perch");
            fishRecipes.Add("Pan Fried Smelt");
            Console.WriteLine("How many more fish recipes would you like to add? (must be at least 3)");
            int addRecipes = int.Parse(Console.ReadLine());
            while (addRecipes <3) { 
                Console.WriteLine("Please use a number 3 or greater");
                addRecipes = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= addRecipes; i++) 
            {
                Console.WriteLine($"Recipe #{i}: ");
                fishRecipes.Add (Console.ReadLine());
            }
            fishRecipes.Sort();
            Console.WriteLine("Recipes Sorted Alphabetically: ");
            foreach (var recipe in fishRecipes) { Console.WriteLine(recipe);}

            Console.WriteLine($"Removing Last Item: {fishRecipes[fishRecipes.Count - 1]}");
            fishRecipes.RemoveAt(fishRecipes.Count - 1);
            fishRecipes.Reverse();
            Console.WriteLine("Recipes Decending Alphabetically: ");
            foreach (var recipe in fishRecipes) { Console.WriteLine(recipe); }


        }
    }
}
