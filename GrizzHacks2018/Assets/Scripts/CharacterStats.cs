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

    protected void SetCurrHP(int hp)
    {
        charStats[4] = hp;
    }
    protected void SetAttack(int attack)
    {
        charStats[1] = attack;
    }
    protected void SetDefence(int defence)
    {
        charStats[2] = defence;
    }
    protected void SetSpeed(int battleSpeed)
    {
        charStats[3] = battleSpeed;
    }

}