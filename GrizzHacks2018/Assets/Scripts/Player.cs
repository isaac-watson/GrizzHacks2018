using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character {



	// Use this for initialization
	protected virtual void Start () {
        base.Start();
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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction += Vector2.right;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            direction *= 2;
        }

        if(direction == Vector2.zero)
        {
            anim.Play("idle");
        }
        else
            anim.Play("run");
    }
}
