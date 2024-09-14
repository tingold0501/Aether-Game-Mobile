using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private static Player _instance;
    private float _speed = 5f;
    private float _hp = 100f;
    private float _exp = 100f;
    private int _level = 1;
    private int _coin = 0;
    private float _mana = 100f;

    public static Player Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Player();
            }
            return _instance;
        }
    }

    public float Speed
    {
        get
        {
            return _speed;
        }

        set
        {
            _speed = value;
        }
    }

    public float Hp
    {
        get
        {
            return _hp;
        }

        set
        {
            _hp = value;
        }
    }

    public float Exp
    {
        get
        {
            return _exp;
        }

        set
        {
            _exp = value;
        }
    }

    public int Level
    {
        get
        {
            return _level;
        }   

        set
        {
            _level = value;
        }
    }

    public int Coin
    {
        get
        {
            return _coin;
        }

        set
        {
            _coin = value;
        }
    }

    public float Mana
    {
        get
        {
            return _mana;
        }

        set
        {
            _mana = value;
        }
    }

    public void AddCoin(int coin)
    {
        _coin += coin;
    }

    public void AddExp(float exp)
    {
        _exp += exp;
    }

    public void AddMana(float mana)
    {
        _mana += mana;
    }

    public void AddHp(float hp)
    {
        _hp += hp;
    }

    public void AddLevel(int level)
    {
        _level += level;
    }

    public void AddSpeed(float speed)
    {
        _speed += speed;
    }

    public void Reset()
    {
        _speed = 5f;
        _hp = 100f;
        _exp = 0f;
        _level = 1;
        _coin = 0;
        _mana = 100f;
    }
    public void Die()
    {
        _speed = 0f;
        _hp = 0f;
        _exp = 0f;
        _level = 0;
        _coin = 0;
        _mana = 0f;
    }
}
