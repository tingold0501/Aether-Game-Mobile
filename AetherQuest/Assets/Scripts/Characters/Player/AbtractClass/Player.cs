using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private string _name;
    private int _health;
    private int _mana;
    private int _level;
    private int _exp;
    private float _speed;
    private float _damage;
    private float _rotationSpeed;

    public Player(string name, int health, int mana, int level, int exp, float speed, float damage)
    {
        _name = name;
        _health = health;
        _mana = mana;
        _level = level;
        _exp = exp;
        _speed = speed;
        _damage = damage;
    }
    public float RotationSpeed
    {
        get
        {
            return _rotationSpeed;
        }

        set
        {
            _rotationSpeed = value;
        }
    }

    public string Name
    {
        get
        {
            return _name;
        }

        set
        {
            _name = value;
        }
    }

    public int Health
    {
        get
        {
            return _health;
        }

        set
        {
            _health = value;
        }
    }

    public int Mana
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

    public int Exp
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

    public float Damage
    {
        get
        {
            return _damage;
        }

        set
        {
            _damage = value;
        }
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }

    public void TakeMana(int mana)
    {
        _mana -= mana;
    }
    public void TakeExp(int exp)
    {
        _exp += exp;
    }

    public void TakeLevel(int level)
    {
        _level += level;
    }

    public void TakeSpeed(float speed)
    {
        _speed += speed;
    }



}
