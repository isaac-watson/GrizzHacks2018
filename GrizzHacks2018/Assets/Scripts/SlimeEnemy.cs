using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeEnemy : CharacterStats {

    private int hp = 15;
    private int att = 1;
    private int def = 0;
    private int battleSpeed = 1;
	// Use this for initialization
	protected override void Start () {
        base.Start();
        SetCharStats(hp, att, def, battleSpeed);
	}
	
	// Update is called once per frame
	protected override void Update () {
		
	}
}
