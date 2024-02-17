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
        float caloriesSum = 0;
        string ingredientsString = "";
        foreach(JsonObjectIngredients i in ingredients){
            foreach(JsonObjectCalories c in caloriesTableList){
                if(i.ingredientName == c.IngredientName){
                    float m = i.ingredientQuantity/100;
                    caloriesSum += c.Claories * m;
                }
            }
            ingredientsString = $"{ingredientsString} {i.ingredientName} {i.ingredientQuantity} \n";
        }
;
        string representString = $"{_type} {title}\n {ingredientsString} Calories per serve: {caloriesSum/serves}";
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