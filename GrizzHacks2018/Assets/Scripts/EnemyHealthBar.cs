using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : HealthBar {

    // Update is called once per frame
     protected override void Update () {
        stats = PlayerData.GetEnemyStats();
        currentHp = stats[4];
        maxHp = stats[0];
        HandleBar();
    }

}
