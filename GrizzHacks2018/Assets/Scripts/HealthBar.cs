using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : CharacterStats {

    [SerializeField]
    private Image content;

    [SerializeField]
    private float fillAmount;

    private Player player;
    private int[] stats;
    private int currentHp;
    private int maxHp;

    

	// Use this for initialization
	protected override void Start () {
        player = new Player();
        stats = player.getCharStats();
        currentHp = stats[4];
        maxHp = stats[0];
	}
	
	// Update is called once per frame
	protected override void Update () {
        HandleBar();
	}

    private void HandleBar()
    {
        //content.fillAmount = HpValue(currentHp, maxHp);
        content.fillAmount = fillAmount;
    }

    private float HpValue(int currHp, int maxHp)
    {
        return currHp / maxHp;
    }
}
