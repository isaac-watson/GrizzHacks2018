using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackProjectile : MonoBehaviour {

    
    private float decay = 6f;
    Vector3 newPos;
	// Use this for initialization
	void Start () {
        
        gameObject.SetActive(false);
        
	}
	
	// Update is called once per frame
	void Update () {
        MoveRight();
    }

    private void MoveRight()
    {
        if (transform.position == newPos)
            RemoveProjectile();
        newPos = new Vector3(3f, 0.89f, 0);
        transform.position = Vector3.MoveTowards(transform.position, newPos, Time.deltaTime * decay);
        
        
    }

    private void RemoveProjectile()
    {
        gameObject.SetActive(false);
    }

}
