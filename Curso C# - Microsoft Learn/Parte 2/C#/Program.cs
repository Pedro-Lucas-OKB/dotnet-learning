/* Random dice = new Random();
int roll = dice.Next(5, 7);
Console.WriteLine(roll);

int result = new Random().Next(1, 100);
Console.WriteLine(result);
 */

/* Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("Dados triplos com mesmo resultado! 6 pontos extras");
        total += 6;
    }else {
        Console.WriteLine("2 dados com mesmo resultado! 2 pontos extras");
        total += 2;
    }
}



if (total >= 15) {
    Console.WriteLine("You win!");
}else {
    Console.WriteLine("You lose!");
} */

/* int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine($"O maior valor é {largerValue}"); */

/* Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

Console.WriteLine($"Days = {daysUntilExpiration}");

if(daysUntilExpiration == 0) {
    Console.WriteLine($"Your subscription has expired.");
}else if(daysUntilExpiration == 1) {
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day!");
}else if(daysUntilExpiration <= 5) {
    discountPercentage = 10;
    Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days.");
}else if (daysUntilExpiration <= 10) {
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if(discountPercentage > 0) {
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
} */

///// Matrizes /////
/* string[] fraudulentOrderIDs = new string[3];
//string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process."); */
/* string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names) {
    Console.WriteLine(name);
} */

string[] fraudulentOrderIDs = { "B123",  "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;

foreach (var item in inventory) {
    sum += item;
    bin++;
    Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");

foreach (var id in fraudulentOrderIDs) {
    if (id.StartsWith('B')) {
        Console.WriteLine(id);
    }
}