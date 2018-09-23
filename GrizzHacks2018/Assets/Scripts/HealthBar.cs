using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    [SerializeField]
    protected Image content;

    [SerializeField]
    protected float fillAmount;

    //private Player player;
    //private GameObject playerObject;
    protected int[] stats;
    protected float currentHp;
    protected float maxHp;

	// Update is called once per frame
	protected virtual void Update () {
        stats = PlayerData.GetPlayerStats();
        currentHp = stats[4];
        maxHp = stats[0];
        HandleBar();
       // print(HpValue(currentHp, maxHp));
	}

    protected void HandleBar()
    {
        content.fillAmount = HpValue(currentHp, maxHp);
       // content.fillAmount = fillAmount;
    }

    private float HpValue(float currHp, float maxHp)
    {
            return (float)(currHp / maxHp);
        
    }
}
