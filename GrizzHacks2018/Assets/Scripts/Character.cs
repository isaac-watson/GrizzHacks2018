using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour {

    protected Vector2 direction;

    [SerializeField]
    private float speed = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	protected virtual void Update () {
        moveChar();
	}

    private void moveChar()
    {
        transform.Translate(direction * Time.deltaTime * speed);
    }
}
