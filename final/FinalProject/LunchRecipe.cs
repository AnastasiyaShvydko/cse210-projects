public class LunchRecipe:Recipe{
    string _type = "Lunch";

    public LunchRecipe(string title, string description,int serves, bool isVegetarian, List<JsonObjectIngredients> ingredients ):base(title, description, serves, isVegetarian,ingredients){

    }
     public override string GetDetailsRecipe(){
        string title = GetTitle();
        string representString = $"{_type}{title}";
            return representString;
    }

    public override JsonObjectRecipe GetJsonRecipe(){
        string title = GetTitle();
        string description = GetDescription();
        int serves = GetServes();
        bool isVegetarian = GetIsVegetarian();
        List<JsonObjectIngredients> ingredients = GetIngredients();

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