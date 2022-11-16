//var names = new string[10];
//var sortAsend = new string[10];
//var sortDescend = new string[10];
//string temp;
//var dupeList = new bool[5];
//Boolean hasFound = false;

//Console.WriteLine("Enter 10 Names : ");
//for (int i = 0; i < names.Length; i++)
//{
//	names[i] = Console.ReadLine();
//}

//Ascending();
//Descending();
//Search();
//Length();
//Split();
//Duplicate();

//void Ascending()
//{

//    for (int i = 0; i < names.Length; i++)
//    {
//        for (int j = i + 1; j < names.Length; j++)
//        {
//            if (names[i][0] > names[j][0])
//            {
//                temp = names[i];
//                names[i] = names[j];
//                names[j] = temp;
//            }
//        }
//    }
//    Console.WriteLine("Names in Ascending Order :");

//    for (int j = 0; j < names.Length; j++)
//    {
//        Console.WriteLine(names[j]);
//    }
//}
//void Descending()
//{

//for (int i = 0; i < names.Length; i++)
//{
//    for (int j = i + 1; j < names.Length; j++)
//    {
//        if (names[i][0] < names[j][0])
//        {
//            temp = names[i];
//            names[i] = names[j];
//            names[j] = temp;
//        }
//    }

//}
//Console.WriteLine("Names in Descending Order : ");

//for (int j = 0; j < names.Length; j++)
//{
//    Console.WriteLine(names[j]);
//}
//}
//void Search()
//{
//Console.WriteLine("Enter Name to search : ");
//temp = Console.ReadLine();
//for (int i = 0; i < names.Length; i++)
//{
//    if (names[i] == temp)
//    {
//        Console.WriteLine("Element Found at position : " + i);
//        hasFound = true;
//        break;
//    }
//}
//if (!hasFound)
//{
//    Console.WriteLine("Element Not Found");

//}
//}

//void Length()
//{
//    foreach (var item in names)
//    {
//        Console.WriteLine($"Length of {item} is {item.Length}");
//    }
//}

//void Split()
//{
//    Console.WriteLine("Names having First and last name :");

//    foreach (var item in names)
//    {
//        for (int i = 0; i < item.Length; i++)
//        {
//            if (item[i] == ' ')
//            {
//                Console.Write($"First name of {item} is : ");
//                for (int j = 0; j < i; j++)
//                {
//                    Console.Write(item[j]);
//                }
//                Console.WriteLine();
//                Console.Write($"Last name of {item} is : ");
//                for (int j = i + 1; j < item.Length; j++)
//                {
//                    Console.Write(item[j]);
//                }
//                Console.WriteLine();

//            }
//        }
//    }
//}

//void Duplicate()
//{
//Console.WriteLine("Duplicate names are : ");

//for (int i = 0; i < names.Length; i++)
//{
//    for (int j = 0; j < names.Length; j++)
//    {
//        if (names[i] == names[j] && i != j && dupeList[i] == false)
//        {
//            Console.WriteLine($" {names[i]} ");

//            dupeList[i] = true;
//            dupeList[j] = true;
//        }
//    }
//}
//}

//--------------------------------------------------------------

//Console.WriteLine("Enter the flight fare");
//double fare = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter booking time in railway time");
//int time = int.Parse(Console.ReadLine());
//if(time >=600 && time <= 900)
//{
//    fare = fare + (fare * 0.1);
//    Console.WriteLine("fare is:"+ fare);    
//}
//else if(time >=900 && time <= 1700)
//{
//    fare = fare + (fare * 0.2);
//    Console.WriteLine("fare is:"+fare);
//}
//else if(time>=1700 && time <= 2100)
//{
//    fare = fare + (fare * 0.07);
//    Console.WriteLine("fare is:" + fare);
//}
//else if(time <= 2300 && time <=600)
//{
//    fare = fare + (fare * 0.05);
//    Console.WriteLine("fare is:" + fare);
//}


//-----------------------------------------------------------


//int[] arr = new int[10];
//int temp = 0;
//bool Found = false;

//Console.WriteLine("enter the flight fares");
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = int.Parse(Console.ReadLine());
//}

//Ascending();
//Descending();
//Search();
//min();
//max();
//duplicate();

//void Search()
//{
//    Console.WriteLine("Enter fare to search : ");
//    temp = int.Parse(Console.ReadLine());
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] == temp)
//        {
//            Console.WriteLine("Element Found at position : " + i);
//            Found = true;
//            break;
//        }
//    }
//    if (!Found)
//    {
//        Console.WriteLine("Element Not Found");

//    }
//}
//void Ascending()
//{

//    for (int i = 0; i < arr.Length - 1; i++)
//    {
//        for (int j = i + 1; j < arr.Length; j++)
//        {
//            if (arr[i] > arr[j])
//            {
//                temp = arr[i];
//                arr[i] = arr[j];
//                arr[j] = temp;
//            }
//        }
//    }
//    Console.WriteLine("sorted array is:");
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item);
//    }
//}

//void Descending()
//{
//    for (int i = 0; i <= arr.Length - 1; i++)
//    {
//        for (int j = i + 1; j < arr.Length; j++)
//        {
//            if (arr[i] < arr[j])
//            {
//                temp = arr[i];
//                arr[i] = arr[j];
//                arr[j] = temp;
//            }
//        }
//    }
//    Console.WriteLine(" Descending Order : ");

//    for (int j = 0; j < arr.Length; j++)
//    {
//        Console.WriteLine(arr[j]);
//    }
//}

//void min()
//{
//    int min = arr[0];
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] < min)
//        {
//            min = arr[i];
//        }
//    }
//    Console.WriteLine("Smallest element is" + min);
//}

//void max()
//{
//    int max = arr[0];
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] > max)
//        {
//            max = arr[i];
//        }
//    }
//    Console.WriteLine("Largest element is" + max);
//}

//void duplicate()
//{
//    var dupeList = new bool[5];
//    Console.WriteLine("Duplicate fares are : ");

//    for (int i = 0; i < arr.Length; i++)
//    {
//        for (int j = 0; j < arr.Length; j++)
//        {
//            if (arr[i] == arr[j] && i != j && dupeList[i] == false)
//            {
//                Console.WriteLine($" {arr[i]} ");

//                dupeList[i] = true;
//                dupeList[j] = true;
//            }
//        }
//    }
//}


//---------------------------------------------------------------------



//Console.WriteLine("Enter your Date of Birth.");
//DateOnly dob = DateOnly.Parse(Console.ReadLine());
//Console.WriteLine(dob);



//Console.WriteLine("Enter the today's date");
//DateOnly today = DateOnly.Parse(Console.ReadLine());



//var day = today.DayNumber - dob.DayNumber;



//int hours = day * 24;
//Console.WriteLine($" Age in Hours: {hours}");



//int weeks = day / 7;
//Console.WriteLine($" Age in Weeks: {weeks}");



//int months = day / 30;
//Console.WriteLine($" Age in Months: {months}");



//int years = day / 365;
//Console.WriteLine($" Age in years: {years}");



//int Year = dob.Year;
////Console.WriteLine(DateOfYear);



//if (!(Year % 100 == 0))
//{
//    if (Year % 4 == 0)
//    {
//        Console.WriteLine("Year of Birth is a leap Year.");
//    }
//    Console.WriteLine(" Year of Birth is Not a Leap Year.");
//}
//else
//{
//    Console.WriteLine(" Year of Birth is Not a leap year.");
//}


//----------------------------------------------------------------------



//int[] fare = new int[10];
//Console.WriteLine("Enter the flight fare");
//for (int i = 0; i < fare.Length; i += 2)
//{
//    fare[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine(fare[0]);
//Console.WriteLine(fare[2]);


//------------------------------------------------------------------------


//Console.WriteLine("Enter Passenger Name");
//string name = Console.ReadLine();
//Console.WriteLine("Enter total miles travelled");
//int miles = int.Parse(Console.ReadLine());
//if(miles>100000 )
//{
//    Console.WriteLine("50 frequent flyer points awarded");
//}
//else if(miles>50000)
//{
//    Console.WriteLine("30 frequent flyer points awarded");
//}
//else if(miles>20000)
//{
//    Console.WriteLine("20 frequent flyer points awarded");
//}
//else if(miles>10000)
//{
//    Console.WriteLine("10 frequent flyer points awarded");
//}


//-------------------------------------------------------------


//int[] fare = new int[5];
//Console.WriteLine("Enter the flight fare");
//for (int i = 0; i < fare.Length; i++)
//{
//    fare[i] = int.Parse(Console.ReadLine());
//}
//string[] dest = new string[5];
//Console.WriteLine("Enter the destination");
//for (int i = 0; i < dest.Length; i++)
//{
//    dest[i] = Console.ReadLine();
//}
//Console.WriteLine("Enter the number");
//int n = int.Parse(Console.ReadLine());
//for(int i = 0; i < fare.Length; i++)
//{
//    if(i==n)
//    {
//        Console.WriteLine("fare is: " + fare[i]);
//        Console.WriteLine("Destination is: " + dest[i]);
//    }
//}


//-------------------------------------------------------------------


//Console.WriteLine("Enter date of birth");
//DateOnly dob = DateOnly.Parse(Console.ReadLine());
//Console.WriteLine(dob);
//var today = DateTime.Today;
//var a =(today.Year*100+today.Month)*100;    
//var b =(dob.Year*100+dob.Month)*100+dob.Day;
//Console.WriteLine(( (a - b) / 10000));


//----------------------------------------------------------


//DateOnly[] dob = new DateOnly[3];
//int[] date = new int[3];
//int[] Age = new int[3];
//DateOnly dateb;
//Console.WriteLine("Enter your Date of Birth ");
//for (int i = 0; i < dob.Length; i++)
//{
//    dob[i] = DateOnly.Parse(Console.ReadLine());
//}

//int today = DateTime.Now.Year;

//for (int i = 0; i < dob.Length; i++)
//{
//    date[i] = dob[i].Year;
//}

//for (int i = 0; i < dob.Length; i++)
//{
//    Age[i] = today - date[i];
//}



//for (int i = 0; i < Age.Length; i++)
//{
//    if (Age[i] < 10)
//    {
//        Console.WriteLine("Kid");
//    }
//    else if (Age[i] > 10 && Age[i] < 30)
//    {
//        Console.WriteLine("Youth");
//    }
//    else if (Age[i] > 30 && Age[i] < 60)
//    {
//        Console.WriteLine("Adult");
//    }
//    else
//    {
//        Console.WriteLine("Older");
//    }
//}


//-----------------------------------------------------------
