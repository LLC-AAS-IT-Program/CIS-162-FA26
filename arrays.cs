// ARRAYS
// Used to store multiple values


// CREATING ARRAYS
// Create arrays with a set number of empty values
int[] scores = new int[5];
string[] fruits = new string[10];

// Create arrays with a set of values
int[] grades = new int[8] {93, 85, 62, 74, 88, 97, 79, 83}; // Number of values must equal the length of the array
string[] employees = new string[4] {"Mark", "Sara", "Doug", "Charles"};


// INDEXES
// Use the index to access items inside the array (remember: index starts at 0!)
Console.WriteLine(employees[2]); // Outputs "Doug"

// Can also use index to change a value in the array
employees[1] = "Joseph";
Console.WriteLine(employees[1]); // Outputs "Joseph"

// Index from the end (index starts at 1)
Console.WriteLine(employees[^1]); // Outputs "Charles

// Grab a range of values from an array
// Makes a copy of the array; changes made to og array does not affect the copied array
// Inclues the beginning index but DOES NOT include the ending index
int[] firstThreeGrades = grades[0..3]; // New array is [93, 85, 62]

// Can omit the beginning index or ending index (or both)
int[] firstFiveGrades = grades[..5]; // New array is [93, 85, 62, 74, 88]
int[] lastTwoGrades = grades[6..]; // New array is [79, 83]


// LOOPING THROUGH ARRAYS
// Can use a for loop and a foreach loop to loop through values in an array
// Downside of foreach loop is that you lose the index

// for loop
for (int i = 0; i < employees.Length; i++)
{
    Console.WriteLine($"Employee #{i + 1}: {employees[i]}"); // Use i as the index to access values
}

// foreach loop
foreach (string employee in employees)
{
    Console.WriteLine(employee);
}
