using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int health = 100;
    private int attack = 10;
    private float speed = 5f;
    private string name = "Player";
    private int level = 1;
    private int exp = 0;
    private int power = 0;
    private float rotation = 0f;

    public int Health { get => health; set => health = value; }
    public int Attack { get => attack; set => attack = value; }
    public float Speed { get => speed; set => speed = value; }
    public string Name { get => name; set => name = value; }
    public int Level { get => level; set => level = value; }
    public int Exp { get => exp; set => exp = value; }
    public int Power { get => power; set => power = value; }

    public float Rotation { get => rotation; set => rotation = value; }

    public Player(int health, int attack, float speed, string name, int level, int exp, int power, float rotation)
    {
        this.Health = health;
        this.Attack = attack;
        this.Speed = speed;
        this.Name = name;
        this.Level = level;
        this.Exp = exp;
        this.Power = power;
        this.Rotation = rotation;
    }

    public Player()
    {
        this.Health = 100;
        this.Attack = 10;
        this.Speed = 5f;
        this.Name = "Player";
        this.Level = 1;
        this.Exp = 0;
        this.Power = 0;
        this.Rotation = 2f;
    }

    public void TakeDamage(int damage)
    {
        this.Health -= damage;
    }
    public void TakeExp(int exp)
    {
        this.Exp += exp;
    }
    public void TakePower(int power)
    {
        this.Power += power;
    }
    public void LevelUp()
    {
        this.Level += 1;
    }
    public void AddHealth(int health)
    {
        this.Health += health;
    }
    public void AddAttack(int attack)
    {
        this.Attack += attack;
    }
    public void AddSpeed(float speed)
    {
        this.Speed += speed;
    }
}
