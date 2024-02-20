using System.Text.Json;
public class Main{
    double _bmr = 0;
    List<Recipe> _userRecipe = new List<Recipe>();
    List<string> ingredientList = new List<string>();

    List<JsonObjectRecipe> userRecipeList = new List<JsonObjectRecipe>();

   


    public void Start(){
        DisplayGreetingMessage();
        string answer = "";
        while(answer != "7"){
            DisplayUserBMR();
            Console.WriteLine("Please choose what would you like to do:\n");
            DisplayUserInterface();
            answer = Console.ReadLine();
            if(answer == "1"){
                CreateRecipe();
            }
            if(answer == "2"){
                DisplayRecipe();
            }
            if(answer == "3"){
                SaveRecipe();
            }
            if(answer == "4"){
                LoadRecipe();
            }
            if(answer == "5"){
                CreateMealPlan();
            }
            if(answer == "6"){
                CalculateBMR();
            }
            if(answer == "7"){
                Console.WriteLine("Good bye!");
            }
        }

       

    }

    public void DisplayUserBMR(){
        if (_bmr == 0){
                Console.WriteLine($"Your bmr: unknown\n");
        }
        else{
            Console.WriteLine($"Your bmr: {_bmr}\n");
        }
    }

    public void DisplayUserInterface(){
       
        List<string> userMenu = new List<string>();
        userMenu.Add("Add new recipe");
        userMenu.Add("Display recipes");
        userMenu.Add("Save recipe");
        userMenu.Add("Load from Recipe's Book");
        userMenu.Add("Creat personal Meal Plan");
        userMenu.Add("Calculate Basal Metabolic Rate");
        userMenu.Add("Quit");

        foreach(string s in userMenu){
            Console.WriteLine($"{userMenu.IndexOf(s) + 1}. {s}");
        }
    }

    public void DisplayGreetingMessage(){
        Console.WriteLine("Welcome to the Recipe's Book App!\n");
    }

    public void CreateRecipe(){
        Console.WriteLine("What type of recipe you would like to add?");
        ListTypesOfRecipies();
        string userType = Console.ReadLine();
        if(userType == "1"){
            string title = UserRecipeTitle();
            string description = UserRecipeDescription();
            int serves = Convert.ToInt32(UserRecipeServe());
            bool isVegetarian = UserRecipeIsVegetarian();
            List<JsonObjectIngredients> ingredients = UserRecipeIngredients();
            BreakfastRecipe newbreakfastRecipe = new BreakfastRecipe(title,description,serves,isVegetarian,ingredients);
            _userRecipe.Add(newbreakfastRecipe);
            

        }
        if(userType == "2"){
            string title = UserRecipeTitle();
            string description = UserRecipeDescription();
            int serves = Convert.ToInt32(UserRecipeServe());
            bool isVegetarian = UserRecipeIsVegetarian();
            List<JsonObjectIngredients> ingredients = UserRecipeIngredients();
            LunchRecipe newlunchRecipe = new LunchRecipe(title,description,serves,isVegetarian,ingredients);
            _userRecipe.Add(newlunchRecipe);

        }
        if(userType == "3"){
            string title = UserRecipeTitle();
            string description = UserRecipeDescription();
            int serves = Convert.ToInt32(UserRecipeServe());
            bool isVegetarian = UserRecipeIsVegetarian();
            List<JsonObjectIngredients> ingredients = UserRecipeIngredients();
            DinnerRecipe newdinnerRecipe = new DinnerRecipe(title,description,serves,isVegetarian,ingredients);
            _userRecipe.Add(newdinnerRecipe);

        }
        if(userType == "4"){
            string title = UserRecipeTitle();
            string description = UserRecipeDescription();
            int serves = Convert.ToInt32(UserRecipeServe());
            bool isVegetarian = UserRecipeIsVegetarian();
            List<JsonObjectIngredients> ingredients = UserRecipeIngredients();
            DessertRecipe newdessertRecipe = new DessertRecipe(title,description,serves,isVegetarian,ingredients);
            _userRecipe.Add(newdessertRecipe);

        }

        
       
    }

    public void DisplayRecipe(){
        foreach(Recipe r in _userRecipe){
            Console.WriteLine(r.GetDetailsRecipe());
        }
    }

    public void SaveRecipe(){
        List<JsonObjectRecipe> _recipeList = new List<JsonObjectRecipe>{};
        LoadRecipe();
        foreach(Recipe r in _userRecipe){
           _recipeList.Add(r.GetJsonRecipe());
        }
        
       
            string json =  JsonSerializer.Serialize(_recipeList);
            using (StreamWriter outputFile = new StreamWriter("recipe.txt")){
            outputFile.WriteLine(json);
           // outputFile.WriteLine(fileString);
            outputFile.Flush();

        }
        _userRecipe.Clear();
    }

    public void LoadRecipe(){
        _userRecipe.Clear();
        using (StreamReader outputFile = new StreamReader("recipe.txt")){
        string text = outputFile.ReadToEnd();
        userRecipeList = JsonSerializer.Deserialize<List<JsonObjectRecipe>>(text);
        foreach(JsonObjectRecipe j in userRecipeList){
            string title = j.title;
            string description = j.description;
            int serves = Convert.ToInt32(j.serves);
            bool isVegetarian = j.isVeg;
            List<JsonObjectIngredients> ingredients = j.ingredients;
            if(j.type == "Breakfast"){
                BreakfastRecipe newbreakfastRecipe = new BreakfastRecipe(title,description,serves,isVegetarian,ingredients);
                _userRecipe.Add(newbreakfastRecipe);
            }
            if(j.type == "Lunch"){
                LunchRecipe newlunchRecipe = new LunchRecipe(title,description,serves,isVegetarian,ingredients);
                _userRecipe.Add(newlunchRecipe);
            }
            if(j.type == "Dinner"){
                DinnerRecipe newdinnerRecipe = new DinnerRecipe(title,description,serves,isVegetarian,ingredients);
                _userRecipe.Add(newdinnerRecipe);
            } 
            if(j.type == "Dessert"){
                DessertRecipe newdessertRecipe = new DessertRecipe(title,description,serves,isVegetarian,ingredients);
                _userRecipe.Add(newdessertRecipe);
            }
            
        }}
    }


    public void CreateMealPlan(){   
        _userRecipe.Clear();
        LoadRecipe();
        List<string> breakfastList = new List<string>();
        List<string> lunchList = new List<string>();
        List<string> dinnerList = new List<string>();
        List<string> dessertList = new List<string>();

        foreach(Recipe r in _userRecipe){
            if(r.GetType().ToString() == "BreakfastRecipe"){
                breakfastList.Add(r.GetDetailsRecipe());
            }
            if(r.GetType().ToString() == "LunchRecipe"){
                lunchList.Add(r.GetDetailsRecipe());

            }
            if(r.GetType().ToString() == "DinnerRecipe"){
                dinnerList.Add(r.GetDetailsRecipe());

            }
            if(r.GetType().ToString() == "DessertRecipe"){
                dessertList.Add(r.GetDetailsRecipe());
  
            }
        }
        List<String> mealPLan = new List<String>();
       
            Random randomGenerator = new Random();
            int randomIndexBreakfast = randomGenerator.Next(0, breakfastList.Count - 1 );
            int randomIndexLunch = randomGenerator.Next(0, lunchList.Count - 1);
            int randomIndexDinner= randomGenerator.Next(0, dinnerList.Count - 1);
            int randomIndexDessert= randomGenerator.Next(0, dessertList.Count - 1);
            mealPLan.Add(breakfastList[randomIndexBreakfast]);
            mealPLan.Add(lunchList[randomIndexLunch]);
            mealPLan.Add(dinnerList[randomIndexDinner]);
            mealPLan.Add(dessertList[randomIndexDessert]);
            foreach(String mp in mealPLan){
                Console.WriteLine(mp);
            }

        
        }

    public void CalculateBMR(){
        Console.WriteLine("Please enter your weight in kg");
        string weight = Console.ReadLine();
        Console.WriteLine("Please enter your height in cm");
        string height = Console.ReadLine();
        Console.WriteLine("Please enter your age");
        string age = Console.ReadLine();
        Console.WriteLine("Please enter your gender");
        string gender = Console.ReadLine();
        BMRcalculator newCalculator = new BMRcalculator(Convert.ToDouble(weight), Convert.ToDouble(height), Convert.ToInt32(age),gender);
        Console.WriteLine($"Your Basal Metabolic Rate is {newCalculator.calculateBMR()} calories");
        _bmr = newCalculator.calculateBMR();
        }



    public void ListTypesOfRecipies(){
        List<string> types = new List<string>();
        types.Add("Breakfast");
        types.Add("Lunch");
        types.Add("Dinner");
        types.Add("Dessert");
        foreach(string t in types){
            Console.WriteLine($"{types.IndexOf(t) + 1}. {t}");
        }
    }

    public string UserRecipeTitle(){
        Console.WriteLine("What is a title of your recipe?");
        string userRecipeTitle = Console.ReadLine();
        return userRecipeTitle;
    }
     public string UserRecipeDescription(){
        Console.WriteLine("Please enter description?");
        string userRecipeDescription = Console.ReadLine();
        return userRecipeDescription;
    } 
    public string UserRecipeServe(){
        Console.WriteLine("Please enter serve");
        string userRecipeServe = Console.ReadLine();
        return userRecipeServe;
    } 
    public bool UserRecipeIsVegetarian(){
        Console.WriteLine("Is this recipe for Vegetarian? yes/no");
        string userRecipeIsVegetarian = Console.ReadLine();
        if(userRecipeIsVegetarian.ToLower() == "yes"){
            return true;
        }
        else{
            return false;
        }
    }
      public List<JsonObjectIngredients> UserRecipeIngredients(){
        string userEnded = "";
        List<JsonObjectIngredients> ingredientList = new List<JsonObjectIngredients>();
        
        while(userEnded != "yes"){
            
            Console.WriteLine("Please enter ingerdient:");
            string ingredientName = Console.ReadLine();
            Console.WriteLine("Please enter the quantity of ingerdient:");
            string ingerdientQuantity = Console.ReadLine();
            Console.WriteLine("Did you enter all ingredients");
            userEnded = Console.ReadLine();
            //string ingredientDetails = $"Ingredient: {ingredientName}, Quantity: {ingerdientQuantity}";
            JsonObjectIngredients newingredient = new JsonObjectIngredients{
                ingredientName = ingredientName,
                ingredientQuantity = Convert.ToInt32(ingerdientQuantity)
            };
            ingredientList.Add(newingredient);
            
            
        }
        return ingredientList;
        
    } 
}

