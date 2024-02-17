public class JsonObjectCalories{
    public string IngredientName { get; set; }

    public float Claories { get; set; }

   public JsonObjectCalories(string ingredientName,float calories ){
    IngredientName = ingredientName;
    Claories = calories;
   }
}
