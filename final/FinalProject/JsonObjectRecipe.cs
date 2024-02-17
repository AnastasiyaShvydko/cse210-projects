public class JsonObjectRecipe{
    public string type { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public int serves { get; set; }
    public bool isVeg { get; set; }

    public List<JsonObjectIngredients> ingredients { get; set; }
}