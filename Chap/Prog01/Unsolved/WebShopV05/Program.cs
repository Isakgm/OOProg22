
double netPriceBook = 30;
double netPriceDVD = 50;
double netPriceGame = 100;
double tax = 0.1;
int shipping = 49;
double creditFee = 0.02;

int noOfBooksInOrder = 8;
int noOfDVDsInOrder = 3;
int noOfGamesInOrder = 2;

double netPriceAllItems = (netPriceBook * noOfBooksInOrder) + (netPriceDVD * noOfDVDsInOrder) + (netPriceGame * noOfGamesInOrder);

double taxOnItems = netPriceAllItems * tax; 

double creditFeeAllItems = (netPriceAllItems + shipping + taxOnItems) * creditFee;

double totalPrice = netPriceAllItems + taxOnItems + creditFeeAllItems + shipping; // This variable should contain the total price for the order


Console.WriteLine($"You ordered {noOfBooksInOrder} books, " +
                  $"{noOfDVDsInOrder} DVDs and " +
                  $"{noOfGamesInOrder} games");
Console.WriteLine($"Total cost including tax, shipping and credit card fee: {totalPrice} kr.");

