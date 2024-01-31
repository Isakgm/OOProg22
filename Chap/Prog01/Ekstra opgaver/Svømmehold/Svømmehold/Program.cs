// See https://aka.ms/new-console-template for more information
using Svømmehold;


Member m1 = new Member();
Member m2 = new Member(2, "Karl", "12345678", 2020);


Team team = new Team(47, 2, 12, "Mandag");
team.EnrollMember(m1);
team.EnrollMember(m2);

try
{
    team.EnrollMember(m1);

}
catch(ArgumentOutOfRangeException aoore)
{
    Console.WriteLine(aoore.Message);
}

Console.WriteLine(team);

List<Member> members = team.GetAllMembers();

foreach (Member m in members)
{
    Console.WriteLine(m);
}
