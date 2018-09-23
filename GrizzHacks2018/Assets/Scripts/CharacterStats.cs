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
        charStats[0] = health; //maxHealth
        charStats[1] = attack;
        charStats[2] = defence;
        charStats[3] = battleSpeed;
        charStats[4] = health; //currentHealth
    }
    public int[] GetCharStats()
    {
        return charStats;
    }

}