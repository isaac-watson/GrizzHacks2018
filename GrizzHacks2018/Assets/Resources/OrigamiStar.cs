﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrigamiStar : MonoBehaviour {
    public float speed = 10f;
    // Use this for initialization
    void Start() {

    }
    // Update is called once per frame
    void Update () {
        RotateLeft();	
	}
    void RotateLeft() {
        transform.Rotate(Vector3.forward * -90);
    }
}
