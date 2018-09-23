using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour {

    protected Vector3 direction;
    protected SpriteRenderer spriteRenderer;
    protected Animator anim;
    protected float speed = 1;
    protected Vector3 newPos;
    protected Vector3 oldPos;

    [SerializeField]
    private float game_clock = 1;

    // Use this for initialization
    protected virtual void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        newPos = transform.position;
        oldPos = transform.position;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        MoveChar();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        print("Hit something. Going back to (" + oldPos.x + ", " + oldPos.y + ")");
        newPos = oldPos;
        transform.position = oldPos;
    }

    private void MoveChar()
    {
        if (newPos != transform.position)
        {
            if (newPos.x - transform.position.x < 0)
                spriteRenderer.flipX = true;
            else if (newPos.x - transform.position.x > 0)
                spriteRenderer.flipX = false;

            transform.position = Vector3.MoveTowards(transform.position, newPos, Time.deltaTime * speed);
        }
    }
}
