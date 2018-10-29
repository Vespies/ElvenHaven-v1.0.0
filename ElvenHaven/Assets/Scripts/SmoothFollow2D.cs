﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow2D : MonoBehaviour {
    public Transform target;
    public float smoothing = 5.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 newPos =new Vector3(target.position.x, target.position.y, transform.position.z);
        transform.position =Vector3.Lerp(transform.position, newPos, (smoothing *0.001f ));
    }
}
