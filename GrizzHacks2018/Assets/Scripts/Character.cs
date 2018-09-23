using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour {

    protected Vector2 direction;
    protected SpriteRenderer spriteRenderer;
    protected Animator anim;
    protected float speed = 1;

    [SerializeField]
    private float game_clock = 1;

    // Use this for initialization
    protected virtual void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	protected virtual void Update () {
        MoveChar();
	}

    private void MoveChar()
    {
        if (direction.x < 0)
            spriteRenderer.flipX = true;
        if (direction.x > 0)
            spriteRenderer.flipX = false;
        transform.Translate(direction * Time.deltaTime * game_clock * speed);
    }
}
