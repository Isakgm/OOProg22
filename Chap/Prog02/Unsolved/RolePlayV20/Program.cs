
NumberGenerator theNumberGenerator = new NumberGenerator();
BattleLog theLog = new BattleLog();

Hero theHero = new Hero(theNumberGenerator, theLog, 1000, 1, 2);
Beast theBeast = new Beast(theNumberGenerator, theLog);



// Now battle...How do we do that (Hint: You need a loop)

while (!theHero.Dead && !theBeast.Dead)
{
    int damageByHero = theHero.DealDamage();

    
    theBeast.ReceiveDamage(damageByHero);

    int damageByBeast = theBeast.DealDamage();
    theHero.ReceiveDamage(damageByBeast);
}

theLog.PrintLog();
