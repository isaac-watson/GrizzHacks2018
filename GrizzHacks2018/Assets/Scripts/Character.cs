using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour {

    protected Vector2 direction;
    SpriteRenderer renderer;
    protected Animator anim;

    [SerializeField]
    protected float speed = 2;

	// Use this for initialization
	protected virtual void Start () {
        renderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	protected virtual void Update () {
        moveChar();
	}

    private void moveChar()
    {
        if (direction.x < 0)
            renderer.flipX = true;
        if (direction.x > 0)
            renderer.flipX = false;
        transform.Translate(direction * Time.deltaTime * speed);
    }
}
