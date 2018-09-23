using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CharacterStats {


    private int hp = 30;
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
        getInput();
        base.Update();
	}

    private void getInput()
    {
        direction = Vector2.zero;

        if(Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector2.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += Vector2.down;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction += Vector2.left;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direction += Vector2.right;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            direction *= 2;
            speed = 6;
        }
        else
        {
            speed = 4;
        }

        if(direction == Vector2.zero)
        if(lastSafeDirection == Vector2.zero && direction == Vector2.zero)
        {
            anim.Play("idle");
        }
        else
            anim.Play("run");
    }
}
