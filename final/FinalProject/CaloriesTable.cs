public class CaloriesTable{

    List<JsonObjectCalories> caloriesTableList =  new List<JsonObjectCalories>{};


    public List<JsonObjectCalories> CreateList(){
        JsonObjectCalories  beef = new JsonObjectCalories("beef", 200);
        JsonObjectCalories  apple = new JsonObjectCalories("apple", 50);
        JsonObjectCalories  oat = new JsonObjectCalories("oat", 350);
        JsonObjectCalories  milk = new JsonObjectCalories("milk", 50);
        JsonObjectCalories  almond = new JsonObjectCalories("almond", 600);
        JsonObjectCalories  mashrooms = new JsonObjectCalories("mashrooms", 25);
        JsonObjectCalories  butter = new JsonObjectCalories("butter", 650);
        JsonObjectCalories  onion = new JsonObjectCalories("onion", 40);
        JsonObjectCalories  garlic = new JsonObjectCalories("garlic", 150);
        JsonObjectCalories  cheese = new JsonObjectCalories("cheese", 340);
        JsonObjectCalories  flour = new JsonObjectCalories("flour", 350);
        JsonObjectCalories  egg = new JsonObjectCalories("egg", 160);
        JsonObjectCalories  sugar = new JsonObjectCalories("sugar", 400);
        JsonObjectCalories  tomato = new JsonObjectCalories("tomato", 50);
        JsonObjectCalories  salami = new JsonObjectCalories("salami", 400);
        JsonObjectCalories  noodles = new JsonObjectCalories("noodles", 320);
        JsonObjectCalories  carrot = new JsonObjectCalories("carrot", 40);

        caloriesTableList.Add(beef);
        caloriesTableList.Add(apple);
        caloriesTableList.Add(oat);
        caloriesTableList.Add(milk);
        caloriesTableList.Add(almond);
        caloriesTableList.Add(mashrooms);
        caloriesTableList.Add(butter);
        caloriesTableList.Add(onion);
        caloriesTableList.Add(garlic);
        caloriesTableList.Add(cheese);
        caloriesTableList.Add(flour);
        caloriesTableList.Add(egg);
        caloriesTableList.Add(sugar);  
        caloriesTableList.Add(tomato);
        caloriesTableList.Add(salami);
        caloriesTableList.Add(noodles);
        caloriesTableList.Add(carrot);
        return caloriesTableList;

    }
}