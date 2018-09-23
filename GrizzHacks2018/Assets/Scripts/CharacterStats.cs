using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterStats : Character {
    protected int[] charStats;
    
    protected override void Start()
    {
        base.Start();
        charStats = new int[5];
    }
    /*
    protected override void Update()
    {
        base.Update();
    }
    */

    protected void SetCharStats(int health, int attack, int defence, int battleSpeed)
    {
        charStats[0] = health;
        charStats[1] = attack;
        charStats[2] = defence;
        charStats[3] = battleSpeed;
        charStats[4] = health;
    }

    public void SetCurrHP(int hp)
    {
        charStats[4] = hp;
    }
    public void SetAttack(int attack)
    {
        charStats[1] = attack;
    }
    public void SetDefence(int defence)
    {
        charStats[2] = defence;
    }
    public void SetSpeed(int battleSpeed)
    {
        charStats[3] = battleSpeed;
    }
    public int[] getCharStats()
    {
        return charStats;
    }

}