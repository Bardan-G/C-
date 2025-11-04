 // Creating the list of fav fruits
 List<String> favfruits = new List<string>()
 {
     "apple",
     "orange",
     "banana"
 } ;
 
 // adding new fruit
 favfruits.Add("Graps");
 
 // removing fruits
 favfruits.Remove("apple");
 
 //print fruits using foreach loop

 foreach (string fruit in favfruits)
 {
     Console.WriteLine(fruit);
 }
 
 // Creating new Dictionary 
 
 Dictionary<int,string> dictionary = new Dictionary<int,string>();
 dictionary.Add(1,"apple");
 dictionary.Add(2,"orange");
 dictionary.Add(3,"banana");
 
 // adding new fruits
 dictionary.Add(4,"Pineapple");
 
 //Print all the key value pair
 
 foreach (KeyValuePair <int,string> entry in dictionary)
 {
 Console.WriteLine($"Id: {entry.Key},Name:{entry.Value}");
 }