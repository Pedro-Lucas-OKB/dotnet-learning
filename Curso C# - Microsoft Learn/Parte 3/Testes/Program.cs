/* string nome1 = "Pedro  ";
string nome2 = "      PEDRO";

Console.WriteLine(nome1.ToLower().Trim());
Console.WriteLine(nome2.ToLower().Trim());
Console.WriteLine(nome1.ToLower().Trim() == nome2.ToLower().Trim()); */

/* string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow")); */

/* int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}"); */

//Console.WriteLine($"{(new Random().Next(0, 2) == 1? "Heads" : "Tails")}");

/* string permission = "Admin|Manager";
int level = 56;

string message = "";

if (permission.Contains("Admin") && (level > 55)) {
    message = "Welcome, Super Admin user.";

} else if (permission.Contains("Admin") && (level <= 55)) {
    message = "Welcome, Admin user.";

} else if (permission.Contains("Manager") && (level >= 20)) {
    message = "Contact an Admin for access.";

} else {
    message = "You do not have sufficient privileges.";
}

Console.WriteLine(message); */

/* int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}"); */

/* // SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0]) {
    case "01":
        type = "Sweat shirt";
        break;
    
    case "02":
        type = "T-shirt";
        break;
    
    case "03":
        type = "Sweat pants";
        break;
    
    default:
        type = "Other";
        break;
}

switch (product[1]) {
    case "BL":
        color = "Black";
        break;
    
    case "MN":
        color = "Maroon";
        break;
    
    default:
        color = "White";
        break;
}

size = product[2] switch
{
    "S" => "Small",
    "M" => "Medium",
    "L" => "Large",
    _ => "One Size Fits All",
};

Console.WriteLine($"Product: {size} {color} {type}"); */

/* for (int i = 1; i <= 100; i++) {
    if ((i % 3 == 0) && (i % 5 == 0)) 
        System.Console.WriteLine($"{i} FizzBuzz");
    
    else if (i % 3 == 0)
        System.Console.WriteLine($"{i} Fizz");
    
    else if (i % 5 == 0)
        System.Console.WriteLine($"{i} Buzz");
    
    else 
        System.Console.WriteLine(i);
} */
/* int current;
do {
   current = new Random().Next(1, 11); 
   System.Console.WriteLine(current);
} while (current != 7); */

///////////// DESAFIO /////////////

/* int heroIntegrity = 10;
int monsterIntegrity = 10;
Random damage = new Random();

do {
    int attack = damage.Next(1, 11);
    monsterIntegrity -= attack;
    System.Console.WriteLine($"The hero attacks with {attack} damage! Monster integrity = {monsterIntegrity}");

    if (monsterIntegrity > 0) {
        attack = damage.Next(1, 11);
        heroIntegrity -= attack;
        System.Console.WriteLine($"The monster attacks the hero with {attack} damage! Hero integrity = {heroIntegrity}");
    } else {
        break;
    }
} while (heroIntegrity > 0);

if (heroIntegrity > 0) 
    System.Console.WriteLine("The winner is the hero!");
else
    System.Console.WriteLine("The monster defeated the hero!"); */

///////////// PROJETO 1 /////////////
/* int numericValue = 0;
bool validNumber = false;
string? inputValue;

System.Console.Write("Please enter an integer value between 5 and 10: ");

do {
    inputValue = Console.ReadLine();
    if (inputValue != null) {
        validNumber = int.TryParse(inputValue, out numericValue);

        if (!validNumber) {
            System.Console.WriteLine("Please enter a valid value!");
        }else if (numericValue < 5 || numericValue > 10) {
            System.Console.Write($"You entered {numericValue}. Please enter an integer value between 5 and 10!");
        }
    }
} while (numericValue < 5 || numericValue > 10);

System.Console.WriteLine($"The entry value ({numericValue}) was valid!"); */

///////////// PROJETO 2 /////////////
/* bool validInput = false;
string? inputRoleName;
string role = "";
System.Console.Write("Please enter your role name (Administrator, Manager or User): ");

do {
    inputRoleName = Console.ReadLine();

    if(inputRoleName != null) {
        role = inputRoleName.Trim().ToLower();

        switch (role) {
            case "administrator":
                validInput = true;
                break;

            case "manager":
                validInput = true;
                break;

            case "user":
                validInput = true;
                break;
            
            default:
                System.Console.WriteLine($"The role name that you entered, \"{inputRoleName}\" is not valid. Enter your role name (Administrator, Manager, or User)");
                break;
        }
    }
} while (validInput != true);

System.Console.WriteLine($"Your input value ({inputRoleName}]) has been accepted."); */

///////////// PROJETO 3 /////////////

int periodLocation = -1;

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach (var value in myStrings) {
    string myString = value;
    
    do {
        periodLocation = myString.IndexOf('.');
        
        if (periodLocation != -1) 
            Console.WriteLine(myString.Remove(periodLocation));
        else 
            Console.WriteLine(myString);

        myString = myString.Substring(periodLocation + 1).TrimStart();

    } while (periodLocation != -1);
}