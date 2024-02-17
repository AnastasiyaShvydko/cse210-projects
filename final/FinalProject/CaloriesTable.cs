public class CaloriesTable{

    List<JsonObjectCalories> caloriesTableList =  new List<JsonObjectCalories>{};


    public List<JsonObjectCalories> CreateList(){
        JsonObjectCalories  beef = new JsonObjectCalories("beef", 200);
        JsonObjectCalories  apple = new JsonObjectCalories("apple", 50);
        caloriesTableList.Add(beef);
        caloriesTableList.Add(apple);

        return caloriesTableList;

    }
}