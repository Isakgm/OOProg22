
public class Warrior
{
    #region Instance fields
    private string _name;
    private int _level;
    private int _health;
    #endregion

    #region Constructor
    public Warrior(string name, int health)
    {
        _name = name;
        _level = 1;
        _health = health;
    }
    #endregion

    #region Properties
    public string Name
    {
        get { return _name; }
    }

    public bool Dead
    {
        get { return _health <= 0; }
    }

    public int Health
    {
        get { return _health; }
    }

    public int Level
    {
        get { return _level; }
    }
    #endregion

    #region Methods
    public void LevelUp()
    {
        _level = _level + 1;
    }
   public void HealthDown()
    {
        _health = _health - 1;
    }
    #endregion
}
