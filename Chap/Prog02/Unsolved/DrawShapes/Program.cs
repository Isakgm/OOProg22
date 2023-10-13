

// SHAPE A (10 stars in a single row)
//
// **********
//
for (int i = 0; i <= 10; i++)
{
    DrawingTool.DrawOneStar();
}

Console.WriteLine();
// SHAPE B (5 stars in a single row, separated by spaces)
//
// * * * * * 
//

for (int i = 0; i <= 5; i++)
{
    DrawingTool.DrawOneStar();
    DrawingTool.DrawOneSpace();
}

Console.WriteLine();
// SHAPE C  (10 rows of 10 stars each)
//
// **********
// **********
// **********
// **********
// **********
// **********
// **********
// **********
// **********
// **********
//

for (int i = 0; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++) { 
    DrawingTool.DrawOneStar();
    
}
    DrawingTool.StartNewLine();
}

Console.WriteLine();
// SHAPE D (a triangle, I guess...)
//
// *
// **
// ***
// ****
// *****
// ******
// *******
// ********
// *********
// **********
//
for (int i = 0; i <= 10; i++)
{
    
    for (int j = i; j >= 0; j = j - 1)
    {
        DrawingTool.DrawOneStar();

    }
    DrawingTool.StartNewLine();
    
}

Console.WriteLine();
// SHAPE E (X)
//
// *        *
//  *      * 
//   *    *   
//    *  *    
//     **     
//     **     
//    *  *    
//   *    *   
//  *      * 
// *        *


for (int i = 0; i <= 10; i++)
{
    DrawingTool.DrawOneStar();

    for (int j = i; j >= 0; j = j - 1)
    {
        
        DrawingTool.DrawOneSpace();

    }
    
    DrawingTool.StartNewLine();
    

}