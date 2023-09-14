
double netPriceBook = 30;
double netPriceDVD = 50;
double netPriceGame = 100;

int noOfBooksInOrder = 10;
int noOfDVDsInOrder = 0;
int noOfGamesInOrder = 9;

double totalNetPrice = netPriceBook * noOfBooksInOrder + 
                       netPriceDVD * noOfDVDsInOrder + 
                       netPriceGame * noOfGamesInOrder;

// SO#1
bool receiveSpecialOffer1 = totalNetPrice > 1000;

// SO#2
bool receiveSpecialOffer2 = noOfBooksInOrder > noOfGamesInOrder;

// SO#3
bool receiveSpecialOffer3 = noOfGamesInOrder >= 10 || noOfDVDsInOrder >= 10 || noOfBooksInOrder >= 10;

// SO#4
bool receiveSpecialOffer4 = noOfDVDsInOrder > 10 && noOfDVDsInOrder < 20 || noOfGamesInOrder >= 5;

bool receiveEkstraSpecialOfferCase1 = receiveSpecialOffer1 && receiveSpecialOffer2 && !receiveSpecialOffer3 && !receiveSpecialOffer4;
bool receiveEkstraSpecialOfferCase2 = receiveSpecialOffer1 && !receiveSpecialOffer2 && receiveSpecialOffer3 && !receiveSpecialOffer4;
bool receiveEkstraSpecialOfferCase3 = !receiveSpecialOffer1 && receiveSpecialOffer2 && receiveSpecialOffer3 && !receiveSpecialOffer4;
bool receiveEkstraSpecialOfferCase4 = receiveSpecialOffer1 && !receiveSpecialOffer2 && !receiveSpecialOffer3 && receiveSpecialOffer4;
bool receiveEkstraSpecialOfferCase5 = !receiveSpecialOffer1 && receiveSpecialOffer2 && !receiveSpecialOffer3 && receiveSpecialOffer4;
bool receiveEkstraSpecialOfferCase6 = !receiveSpecialOffer1 && !receiveSpecialOffer2 && receiveSpecialOffer3 && receiveSpecialOffer4;

bool receiveEkstraSpecialOffer = receiveEkstraSpecialOfferCase1 || receiveEkstraSpecialOfferCase2 || receiveEkstraSpecialOfferCase3 
                                 || receiveEkstraSpecialOfferCase4 || receiveEkstraSpecialOfferCase5 || receiveEkstraSpecialOfferCase6;

Console.WriteLine($"You ordered {noOfBooksInOrder} books, " +
                  $"{noOfDVDsInOrder} DVDs and " +
                  $"{noOfGamesInOrder} games");

Console.WriteLine($"You qualify for special offer #1 : {receiveSpecialOffer1}");
Console.WriteLine($"You qualify for special offer #2 : {receiveSpecialOffer2}");
Console.WriteLine($"You qualify for special offer #3 : {receiveSpecialOffer3}");
Console.WriteLine($"You qualify for special offer #4 : {receiveSpecialOffer4}");
Console.WriteLine($"You qualify for special offer #5 : {receiveEkstraSpecialOffer}");
