public abstract class Recipe{
    private string _title;

    private string _description;


    private int _serves;

   private bool _isVegetarian;

   private List<JsonObjectIngredients> _ingredients = new List<JsonObjectIngredients>{};

   


public Recipe(string title, string description, int serves, bool isVegetarian,List<JsonObjectIngredients> ingredients ){
    _title = title;
    _description = description;
    _isVegetarian = isVegetarian;
    _serves = serves;
    _ingredients = ingredients;

}

public abstract string GetDetailsRecipe();

public abstract JsonObjectRecipe GetJsonRecipe();

public string GetTitle(){
return _title;
}
public string GetDescription(){
return _description;
}

public bool GetIsVegetarian(){
return _isVegetarian;
}
public int GetServes(){
return _serves;
}
public List<JsonObjectIngredients> GetIngredients(){
return _ingredients;
}

}
