using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeEnemy : CharacterStats {

    private int hp = 10;
    private int att = 2;
    private int def = 0;
    private int battleSpeed = 1;
	// Use this for initialization
	protected override void Start () {
        base.Start();
        SetCharStats(hp, att, def, battleSpeed);
        if (PlayerData.GetEnemyInit() == false)
        {
            PlayerData.SetEnemyStats(charStats);
            PlayerData.SetEnemyInit();
        }
    }
	
	// Update is called once per frame
	protected override void Update () {
		
	}
}
