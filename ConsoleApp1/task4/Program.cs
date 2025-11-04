// single dimenstation array having 5 numbers

int [] favnumb = {2,4,6,8,10};
Array.Sort(favnumb);
foreach (int i in favnumb)
{
}


// resvering the shorted array
Array.Reverse(favnumb);
foreach (int i in favnumb)
{
}

// printing all the element using for loop 
for (int i = 0; i < favnumb.Length; i++)
{
    Console.WriteLine(favnumb[i]);
}

// using array.indexof 
int postion = Array.IndexOf(favnumb,2);
Console.WriteLine($"postion:{postion}");