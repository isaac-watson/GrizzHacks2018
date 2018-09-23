using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackProjectile : MonoBehaviour {

    
    private float decay = 3f;
    Vector3 oldPos;
    Vector3 newPos;
    Animator anim;
	// Use this for initialization
	void Start () {
        
        //gameObject.SetActive(false);

        
	}

    void OnEnable()
    {
        transform.position.Set(0.88f, 0.89f, 0);
        anim = GetComponent<Animator>();
        anim.Play("projectile");
    }
	
	// Update is called once per frame
	void Update () {
        
            MoveRight();
    }

    private void MoveRight()
    {
        if (transform.position == newPos)
            RemoveProjectile();
        oldPos = transform.position;
        newPos = new Vector3(3f, 0.89f, 0);
        transform.position = Vector3.MoveTowards(transform.position, newPos, Time.deltaTime * decay);
        
        
    }

    private void RemoveProjectile()
    {
        
    
        gameObject.SetActive(false);

    }

}
