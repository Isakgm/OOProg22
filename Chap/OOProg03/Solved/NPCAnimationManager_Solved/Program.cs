﻿
int noOfNPCs = 5000;

TestOriginal();
// TestFlyweight();
// TestRevised();

/// <summary>
/// Test original NPC generation.
/// NB: Will use about 0,1 MB per NPC.
/// </summary>
void TestOriginal()
{
    INPCFactory npcFac = new NPCFactory();
    List<INPC> allNPCs = CreateNPCs(npcFac);
    AnimateAll(allNPCs);
    DoneWithTest("(original)");
}

/// <summary>
/// Test flyweight NPC generation.
/// Note that the test deviates significantly from the original
/// test, since we need to store EX/IN-states separately.
/// </summary>
void TestFlyweight()
{
    NPCFlyweightFactory npcFwFac = new NPCFlyweightFactory();
    List<NPCExState> allNPCExStates = CreateNPCExStates(npcFwFac);
    List<NPCFlyweight> allNPCFlyweights = CreateNPCFlyweights(npcFwFac, allNPCExStates);
    AnimateAllFlyweight(allNPCExStates, allNPCFlyweights);
    DoneWithTest("(flyweight w/o revised)");
}

/// <summary>
/// Test revised NPC generation.
/// Note that this test is identical to the original test
/// (expect that a different factory is used), since the
/// revised NPC class also implements INPC.
/// </summary>
void TestRevised()
{
    INPCFactory npcFac = new NPCRevisedFactory();
    List<INPC> allNPCRevised = CreateNPCs(npcFac);
    AnimateAll(allNPCRevised);
    DoneWithTest("(flyweight with revised)");
}

List<INPC> CreateNPCs(INPCFactory npcFac)
{
    List<INPC> all = new List<INPC>();
    for (int i = 0; i < noOfNPCs; i++)
    {
        all.Add(npcFac.Create());
    }
    return all;
}

List<NPCExState> CreateNPCExStates(NPCFlyweightFactory npcFwFac)
{
    List<NPCExState> all = new List<NPCExState>();
    for (int i = 0; i < noOfNPCs; i++)
    {
        all.Add(npcFwFac.CreateExState());
    }
    return all;
}

List<NPCFlyweight> CreateNPCFlyweights(NPCFlyweightFactory npcFwFac, List<NPCExState> allNPCExStates)
{
    List<NPCFlyweight> all = new List<NPCFlyweight>();
    foreach (NPCExState exState in allNPCExStates)
    {
        all.Add(npcFwFac.CreateFlyWeight(exState.TypeOfNPC));
    }
    return all;
}

void AnimateAll(List<INPC> all)
{
    foreach (INPC npc in all)
    {
        npc.Animate();
    }
}

void AnimateAllFlyweight(List<NPCExState> allNPCExStates, List<NPCFlyweight> allNPCFlyweights)
{
    for (int i = 0; i < allNPCFlyweights.Count; i++)
    {
        allNPCFlyweights[i].Animate(allNPCExStates[i]);
    }
}

void DoneWithTest(string testDesc)
{
    Console.WriteLine();
    Console.WriteLine($"Using {testDesc} creation strategy");
    Console.WriteLine($"Created and Animated {noOfNPCs} NPCs");
    Console.WriteLine();
}
