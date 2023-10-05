
public class Warrior
{
    private string _name;
    private int _level;

    public Warrior(string name, int level)
    {
        _name = name;
        _level = 1;
    }

    public string Name
    {
        get { return _name; }
    }
    public int Level
    {
        get { return _level; }
    }

    public int LevelUp()
    {
        return _level = Level + 1;
    }
}
