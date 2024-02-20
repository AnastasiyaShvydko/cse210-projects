public class BreakfastRecipe:Recipe{
    string _type = "Breakfast";

    public BreakfastRecipe(string title, string description,int serves, bool isVegetarian, List<JsonObjectIngredients> ingredients ):base(title, description, serves, isVegetarian,ingredients){

    }
  public override string GetDetailsRecipe(){
        string title = GetTitle();
        int serves = GetServes();
        List<JsonObjectIngredients> ingredients = GetIngredients();
        CaloriesTable caloriesTable = new CaloriesTable();
        List<JsonObjectCalories> caloriesTableList = caloriesTable.CreateList();
        double caloriesSum = 0;
        string ingredientsString = "";
        foreach(JsonObjectIngredients i in ingredients){
            foreach(JsonObjectCalories c in caloriesTableList){
                if(i.ingredientName == c.IngredientName){
                    double m = i.ingredientQuantity/100.0;
                    caloriesSum += c.Claories * m;
                    //  Console.WriteLine(c.Claories);
                    //   Console.WriteLine(m);
                    //    Console.WriteLine(i.ingredientQuantity);
                }
            }
            ingredientsString = $"{ingredientsString} {i.ingredientName} {i.ingredientQuantity} \n";
        }
;
        string representString = $"{_type}\n{title}\n{ingredientsString} \nCalories per serve: {Math.Round(caloriesSum/serves)}";
       
            return representString;
    }

    public override JsonObjectRecipe GetJsonRecipe(){
        string title = GetTitle();
        string description = GetDescription();
        int serves = GetServes();
        bool isVegetarian = GetIsVegetarian();
        List<JsonObjectIngredients> ingredients = GetIngredients();


        //string recipeJSON  = $"{\"type\" : \"{_type}\" }";

//title:'{title}','description':'{description}','serves':'{serves}','isVegetarian':'{isVegetarian}' ";
        JsonObjectRecipe recipeJSON = new JsonObjectRecipe{
            type = _type,
            title = title,
            description = description,
            serves = serves,
            isVeg = isVegetarian,
            ingredients = ingredients

        };
        return recipeJSON;
    }
    
}