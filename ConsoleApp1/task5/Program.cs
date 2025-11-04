// Creating my date of birth
DateTime dob = new DateTime(2006,04,19,23,05,02);
 
 //Creating the current Date time
 
 DateTimeOffset Current =  DateTimeOffset.Now;

 
 // Calculating my real age at present time
 TimeSpan ageSpan = Current -dob;
double ageInYear = ageSpan.TotalDays/365.24219;
int age = Convert.ToInt32(ageInYear);


// Print Date of birth , current time and age
Console.WriteLine($"Date of Birth:{dob}");
Console.WriteLine($"Current date and time:{Current}");
Console.WriteLine($"Current age:{age}");

// adding 10 days in my birthdate

DateTime addeddays = dob.AddDays(10);
Console.WriteLine($"Added days in birth date:{addeddays}");
