
public class Player 
{
    private float _speed = 5f;
    private float _hp = 100f;
    private float _exp = 0f;
    private float _mana = 100f;
    private float _coins = 0f;
    private float _damage = 10f;
    private string _name = "Player";

    public float Speed { get => _speed; set => _speed = value; }
    public float Hp { get => _hp; set => _hp = value; }
    public float Exp { get => _exp; set => _exp = value; }
    public float Mana { get => _mana; set => _mana = value; }
    public float Coins { get => _coins; set => _coins = value; }
    public float Damage { get => _damage; set => _damage = value; }
    public string Name { get => _name; set => _name = value; }

    public Player(float speed, float hp, float exp, float mana, float coins, float damage, string name)
    {
        _speed = speed;
        _hp = hp;
        _exp = exp;
        _mana = mana;
        _coins = coins;
        _damage = damage;
        _name = name;
    }

    public Player()
    {
        _speed = 5f;
        _hp = 100f;
        _exp = 0f;
        _mana = 100f;
        _coins = 0f;
        _damage = 10f;
        _name = "Player";
    }
}
