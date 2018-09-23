using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CharacterStats {


    private int hp = 30;
    private int att = 1;
    private int def = 0;
    private int battleSpeed = 1;

    [SerializeField]
    private bool inBattle = true;

    // Use this for initialization
    protected override void Start () {
        base.Start();
        SetCharStats(hp, att, def, battleSpeed);

    }
	
	// Update is called once per frame
	protected override void Update () {
        GetInput();
        base.Update();
	}

    private void GetInput()
    {
        if (inBattle == false)
        {
            if (Input.GetKey(KeyCode.UpArrow) && newPos == transform.position)
            {
                newPos += Vector3.up;
                oldPos = transform.position;
            }
            else if (Input.GetKey(KeyCode.DownArrow) && newPos == transform.position)
            {
                newPos += Vector3.down;
                oldPos = transform.position;
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && newPos == transform.position)
            {
                newPos += Vector3.left;
                oldPos = transform.position;
            }
            else if (Input.GetKey(KeyCode.RightArrow) && newPos == transform.position)
            {
                newPos += Vector3.right;
                oldPos = transform.position;
            }

            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = 6;
            }
            else
            {
                speed = 4;
            }

            if (newPos == transform.position)
            {
                anim.Play("idle");
            }
            else
                anim.Play("run");
        }
    }
}
