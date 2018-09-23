using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour {

    protected Vector2 direction;
    protected SpriteRenderer spriteRenderer;
    protected Animator anim;
    protected float speed = 1;
    protected float startTime;
    protected bool inProcessOfMoving = false;
    protected Vector2 lastSafeLocation, lastSafeDirection, nextSafeLocation;

    [SerializeField]
    private float game_clock = 1;

    // Use this for initialization
    protected virtual void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        nextSafeLocation = transform.position;
    }
	
	// Update is called once per frame
	protected virtual void Update () {
        MoveChar();
	}

    private void MoveChar()
    {
        if (!inProcessOfMoving && direction != Vector2.zero)
        {
            inProcessOfMoving = true;
            lastSafeLocation = (Vector2)transform.position;
            nextSafeLocation = (Vector2)transform.position + direction;
            lastSafeDirection = direction;
            if (direction.x < 0)
                spriteRenderer.flipX = true;
            if (direction.x > 0)
                spriteRenderer.flipX = false;
            startTime = Time.realtimeSinceStartup;
        }
        if (Time.realtimeSinceStartup - startTime < 1 / speed)
        {
            transform.Translate(Time.deltaTime * lastSafeDirection * speed);
        }
        else
        {
            transform.SetPositionAndRotation(nextSafeLocation, transform.rotation);
            lastSafeDirection = Vector2.zero;
            inProcessOfMoving = false;
        }
    }
}
