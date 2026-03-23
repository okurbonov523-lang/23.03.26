// List<int> numbers = new List<int>{5,2,9,1,7};
// int max = numbers[0];
// for(int i=1; i<numbers.Count; i++)
// {
//     if(numbers[i] > max) max = numbers[i];
// }
// System.Console.WriteLine("Max number: "+ max);

// Task-2

// List<int> numbers = new List<int>{ 5, 2, 9, 1, 7 };
// int min = numbers[0];
// for(int i=0; i<numbers.Count; i++)
// {
//     if(numbers[i]<min) min = numbers[i];
// }
// System.Console.WriteLine($"Min number: {min}");

// Task-3
// List<int> numbers = new List<int>{1,6,8,3,10};
// int count = 0;
// foreach(var b in numbers)
// {
//     if(b > 5) count++;
// }
// System.Console.WriteLine($"Count: {count}");

// Task-4
// List<int> numbers = new List<int>{1,2,3,4};
// System.Console.Write("Reversed: ");
// for(int i=numbers.Count-1; i>=0; i--)
// {
//     System.Console.Write(numbers[i]+" ");
// }

// Task-5

// List<int> numbers = new List<int>{1,2,3,4,5};
// numbers.RemoveAll(b=> b<3);
// foreach(var s in numbers)
// {
//     System.Console.Write(s+" ");
// }

// Task-6

// List<string> words = new List<string>{"hello", "world"};
// for(int i=0; i<words.Count; i++)
// {
//     words[i] = words[i].ToUpper();
// }
// foreach(var word in words)
// {
//     System.Console.Write(word+" ");
// }

// Task-7
// List<string> words = new List<string>{"hi", "programming", "code"};
// string longest = words[0];
// foreach(string word in words)
// {
//     if(word.Length>longest.Length) longest = word;
// }
// System.Console.WriteLine(longest);

// Task-8
// List<string> words = new List<string>{ "apple", "banana", "avocado" };
// int count = 0;
// foreach(string word in words)
// {
//     if (word.StartsWith("a"))
//     {
//         count++;
//     }
// }
// System.Console.WriteLine(count);

// Task-9
// List<string> words = new List<string>{ "zebra", "apple", "cat" };
// words.Sort();
// foreach(var b in words)
// {
//     System.Console.Write(b+ " ");
// }

// Task-10
// List<string> words = new List<string>{ "hello", "world" };
// bool exists = words.Contains("helloa");
// System.Console.WriteLine(exists);

// Task-11

// List<Student> students = new List<Student>();
// students.Add(new Student {Id = 1, Name = "Yahyo", Age = 17});
// students.Add(new Student {Id = 2, Name = "Abdullo", Age = 18});
// students.Add(new Student {Id = 3, Name = "Ratrik", Age = 20});
// students.Add(new Student {Id = 4, Name = "Aatrik", Age = 16});
// foreach(var student in students)
// {
//     System.Console.Write(student.Name+ " ");
// }
// System.Console.WriteLine("\n");

// // Task-12
// List<Student> olderThan18 = new List<Student>();
// foreach(var b in students)
// {
//     if (b.Age > 18)
//     {
//         olderThan18.Add(b);
//     }
// }

// System.Console.WriteLine("\n");
// Student oldest = students[0];
// for(int i=0; i<students.Count; i++)
// {
//     if(students[i].Age > oldest.Age) oldest = students[i];
// }
// System.Console.WriteLine(oldest.Name+ " "+ oldest.Age);
// System.Console.WriteLine("\n");

// for(int i=0; i<students.Count; i++)
// {
//     students[i].Age++;
// }
// foreach(var b in students)
// {
//     System.Console.Write(b.Name+ " "+ b.Age);
// }
// System.Console.WriteLine("\n");

// for(int i=0; i<students.Count-1; i++)
// {
//     if(students[i].Age< 16)
//     {
//         students.RemoveAt(i);
//     }
// }
// foreach(var b in students)
// {
//     System.Console.Write(b.Name+ " "+ b.Age);
// }

// class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int Age { get; set; }
// }

// Task-16

// List<DateTime> dates = new List<DateTime>();
// dates.Add(new DateTime(2024, 3, 20));
// dates.Add(new DateTime(2025, 1, 15));
// dates.Add(new DateTime(2023, 12, 10));
// dates.Add(new DateTime(2024, 6, 5));
// dates.Add(DateTime.Now.AddDays(-3));
// dates.Add(DateTime.Now.AddDays(5));
// dates.Add(DateTime.Now.AddDays(-10));

// foreach (var d in dates)
// {
//     Console.WriteLine(d.ToShortDateString());
// }
// Console.WriteLine();

// // Task-16
// DateTime today = DateTime.Today;
// for (int i = 0; i < dates.Count; i++)
// {
//     if (dates[i] > today)
//     {
//         Console.WriteLine(dates[i].ToShortDateString());
//     }
// }
// Console.WriteLine();

// //    Task-17
// DateTime oldest = dates[0];
// for (int i = 1; i < dates.Count; i++)
// {
//     if (dates[i] < oldest)
//     {
//         oldest = dates[i];
//     }
// }
// Console.WriteLine(oldest.ToShortDateString());
// Console.WriteLine();

// // Task-18
// for (int i = 0; i < dates.Count - 1; i++)
// {
//     for (int j = i + 1; j < dates.Count; j++)
//     {
//         if (dates[i] < dates[j])
//         {
//             DateTime temp = dates[i];
//             dates[i] = dates[j];
//             dates[j] = temp;
//         }
//     }
// }
// foreach (var d in dates)
// {
//     Console.WriteLine(d.ToShortDateString());
// }
// Console.WriteLine();

// //    Task-19
// DateTime sevenDaysAgo = today.AddDays(-7);
// int count = 0;
// for (int i = 0; i < dates.Count; i++)
// {
//     if (dates[i] >= sevenDaysAgo && dates[i] <= today)
//     {
//         count++;
//         Console.WriteLine(dates[i].ToShortDateString());
//     }
// }
// Console.WriteLine($"Count: {count}");
// Console.WriteLine();

// // Task-20
// List<string> result = new List<string>();
// for (int i = 0; i < dates.Count; i++)
// {
//     result.Add(dates[i].ToString("yyyy-MM-dd"));
// }
// foreach (var s in result)
// {
//     Console.WriteLine(s);
// }

//  ==================== HomeTask ========================

// // ========== TASK 1 ==========
// Console.WriteLine("=== TASK 1 ===");
// List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
// int sum = 0;
// for (int i = 0; i < numbers.Count; i++)
// {
//     sum = sum + numbers[i];
// }
// Console.WriteLine("The sum of all the elements in the list is: " + sum);
// Console.WriteLine();

// // ========== TASK 2 ==========
// Console.WriteLine("=== TASK 2 ===");
// List<string> words = new List<string> { "hello", "world", "!" };
// string concat = "";
// for (int i = 0; i < words.Count; i++)
// {
//     concat = concat + words[i];
//     if (i < words.Count - 1)
//     {
//         concat = concat + " ";
//     }
// }
// Console.WriteLine("The concatenated string is: " + concat);
// Console.WriteLine();

// // ========== TASK 3 ==========
// Console.WriteLine("=== TASK 3 ===");
// List<DateTime> dates = new List<DateTime>();
// dates.Add(new DateTime(2020, 10, 1));
// dates.Add(new DateTime(2022, 8, 15));
// dates.Add(new DateTime(2021, 4, 28));

// // Сорт кардан ба тартиби афзоиш (дастӣ)
// for (int i = 0; i < dates.Count - 1; i++)
// {
//     for (int j = i + 1; j < dates.Count; j++)
//     {
//         if (dates[i] > dates[j])
//         {
//             DateTime temp = dates[i];
//             dates[i] = dates[j];
//             dates[j] = temp;
//         }
//     }
// }

// Console.WriteLine("The sorted dates are:");
// for (int i = 0; i < dates.Count; i++)
// {
//     Console.WriteLine(dates[i].ToString("dd/MM/yyyy"));
// }
// Console.WriteLine();

// // ========== TASK 4 ==========
// Console.WriteLine("=== TASK 4 ===");
// List<double> numbers2 = new List<double> { 3.5, 2.7, 6.9, 1.2 };
// double total = 0;
// for (int i = 0; i < numbers2.Count; i++)
// {
//     total = total + numbers2[i];
// }
// double average = total / numbers2.Count;
// Console.WriteLine("The average value of all the elements in the list is: " + average);
// Console.WriteLine();

// // ========== TASK 5 ==========
// Console.WriteLine("=== TASK 5 ===");
// List<int> numbers3 = new List<int> { 1, 2, 3, 4, 5 };
// List<int> evenNumbers = new List<int>();
// for (int i = 0; i < numbers3.Count; i++)
// {
//     if (numbers3[i] % 2 == 0)
//     {
//         evenNumbers.Add(numbers3[i]);
//     }
// }
// Console.WriteLine("The filtered numbers are:");
// for (int i = 0; i < evenNumbers.Count; i++)
// {
//     Console.WriteLine(evenNumbers[i]);
// }
// Console.WriteLine();

// // ========== TASK 6 ==========
// Console.WriteLine("=== TASK 6 ===");
// List<bool> values = new List<bool> { true, true, true };
// bool allTrue = true;
// for (int i = 0; i < values.Count; i++)
// {
//     if (values[i] == false)
//     {
//         allTrue = false;
//         break;
//     }
// }
// Console.WriteLine("Are all the values in the list true? " + allTrue);
// Console.WriteLine();

// // ========== TASK 7 ==========
// Console.WriteLine("=== TASK 7 ===");
// List<int> nums = new List<int> { 10, 20, 30, 40, 50 };
// Console.Write("Before removing: ");
// for (int i = 0; i < nums.Count; i++)
// {
//     Console.Write(nums[i] + " ");
// }
// Console.WriteLine();

// // Remove element at index 2 (30)
// nums.RemoveAt(2);

// Console.Write("After removing element at index 2: ");
// for (int i = 0; i < nums.Count; i++)
// {
//     Console.Write(nums[i] + " ");
// }
// Console.WriteLine();

// // Remove element with value 40
// nums.Remove(40);

// Console.Write("After removing element with value 40: ");
// for (int i = 0; i < nums.Count; i++)
// {
//     Console.Write(nums[i] + " ");
// }
// Console.WriteLine();
// Console.WriteLine();

// // ========== TASK 8 ==========
// Console.WriteLine("=== TASK 8 ===");
// List<int> searchList = new List<int> { 5, 12, 7, 9, 3, 15 };
// int searchValue = 7;
// int foundIndex = -1;
// for (int i = 0; i < searchList.Count; i++)
// {
//     if (searchList[i] == searchValue)
//     {
//         foundIndex = i;
//         break;
//     }
// }

// if (foundIndex != -1)
// {
//     Console.WriteLine($"Value {searchValue} found at index {foundIndex}");
// }
// else
// {
//     Console.WriteLine($"Value {searchValue} not found");
// }
// Console.WriteLine();

// // ========== TASK 9 ==========
// Console.WriteLine("=== TASK 9 ===");
// List<string> items = new List<string>();
// items.Add("Apple");
// items.Add("Banana");
// items.Add("Cherry");
// items.Add("Date");

// Console.Write("List items: ");
// for (int i = 0; i < items.Count; i++)
// {
//     Console.Write(items[i] + " ");
// }
// Console.WriteLine();
// Console.WriteLine();

// // ========== TASK 10 ==========
// Console.WriteLine("=== TASK 10 ===");
// List<int> randomNumbers = new List<int>();
// Random rand = new Random();
// for (int i = 0; i < 10; i++)
// {
//     int num = rand.Next(1, 101);
//     randomNumbers.Add(num);
// }

// Console.Write("Random numbers: ");
// for (int i = 0; i < randomNumbers.Count; i++)
// {
//     Console.Write(randomNumbers[i] + " ");
// }
// Console.WriteLine();

