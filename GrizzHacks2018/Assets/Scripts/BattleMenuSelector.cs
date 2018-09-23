using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleMenuSelector : MonoBehaviour {

    //arrowPos = 0 means option 1 of menu, arrowPos = 1 means option 2 of menu
    private int arrowPos = 1;
    private Vector2 arrow;
    private bool playerTurn;
    private SlimeEnemy slime;
    private Player player;
	// Use this for initialization
	void Start () {
        playerTurn = true;
        arrow = transform.position;
        slime = new SlimeEnemy();
        player = new Player();
        print("Slime with hp:" + slime.getCharStats()[4]); //Slime curr hp
	}
	
	// Update is called once per frame
	void Update () {
        GetInput();
	}
    private void GetInput()
    {
        if (playerTurn == true)
        {
            if (Input.GetKey(KeyCode.LeftArrow) && arrowPos == -1)
            {
                transform.Translate(arrowPos * 5, 0, 0);
                arrowPos = 1;
            }
            if (Input.GetKey(KeyCode.RightArrow) && arrowPos == 1)
            {
                transform.Translate(arrowPos * 5, 0, 0);
                arrowPos = -1;

            }
            if (Input.GetKey(KeyCode.A) && arrowPos == 1)
            {
                print("hit for "+ slime.getCharStats()[4]);
                slime.SetCurrHP(slime.getCharStats()[4] - player.getCharStats()[1]);
                playerTurn = false;
                enemyTurn();
            } else if(Input.GetKey(KeyCode.A) && arrowPos == 1)
            {
                print("you run away");
            }
        }
    }

    private void enemyTurn()
    {

        print("enemy hit");
        playerTurn = true;
    }
}
