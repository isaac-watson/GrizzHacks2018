using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleMenuSelector : MonoBehaviour {

    //arrowPos = 0 means option 1 of menu, arrowPos = 1 means option 2 of menu
    private int arrowPos = 1;
    private bool playerTurn;
    private float decay = 1.33f;
    public GameObject ball;
    
    //private GameObject slimeObject;
   // private GameObject playerObject;
    //private int[] slime;
    private int[] player; 
	// Use this for initialization
	void Start () {
        playerTurn = true;
        //slime = PlayerData.GetEnemyStats();
        player = PlayerData.GetPlayerStats();

       /* if (slimeObject == null)
            slimeObject = GameObject.FindWithTag("Enemy");
        if (playerObject == null)
            playerObject = GameObject.FindWithTag("Player");*/
       //slime = GetComponentInChildren<SlimeEnemy>();
       //player = GetComponent<Player>(); 

        //slime = new SlimeEnemy();
        // player = new Player();
        //print("Slime with hp:" + slime.getCharStats()[4]); //Slime curr hp
    }
	// Update is called once per frame
	void Update () {

        if (decay >= 0)
        {
            decay -= Time.deltaTime;
            
        }
       else {
            getMenuInput();
            
        }
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
          

            
        }
    }
    private void getMenuInput()
    {
        int[] slime = PlayerData.GetEnemyStats();
        //GameObject projectile = gameObject.transform.Find("ball_0").gameObject;

        if (Input.GetKeyDown(KeyCode.A) && arrowPos == 1)
        {
            //projectile.SetActive(true);
            GameObject attackBall = GameObject.Instantiate(ball);
            attackBall.transform.position = new Vector3(-4.03f, 1.23f, 0);
            print("YOU dealt " + PlayerData.GetPlayerStats()[1] + "damage");

            slime[4] -= PlayerData.GetPlayerStats()[1];
            PlayerData.SetEnemyStats(slime);
            playerTurn = false;

            print("slime hp: " + PlayerData.GetEnemyStats()[4]);
            if (slime[4] > 0)
                EnemyTurn();
            else
                SceneManager.LoadScene(sceneName: "map2");
        }
        else if (Input.GetKey(KeyCode.A) && arrowPos == -1)
        {
            print("collided");
            SceneManager.LoadScene(sceneName: "map2");
        }
    }

    private void EnemyTurn()
    {
        player[4] -= (PlayerData.GetEnemyStats()[1] - PlayerData.GetPlayerStats()[2]);
        PlayerData.SetPlayerStats(player);
        print("enemy dealt: " + PlayerData.GetEnemyStats()[1] + "damage");
        print("your hp: " + player[4]);
        if (player[4] > 0)
        {
            playerTurn = true;
            decay = 1.33f;
        }
        else
            SceneManager.LoadScene(sceneName: "map2");
    }

}
