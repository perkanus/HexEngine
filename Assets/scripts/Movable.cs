﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour {

    public Vector3 destination;
    float speed = 2;

	// Use this for initialization
	void Start () {
        destination = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 dir = destination - transform.position;
        Vector3 velocity = dir.normalized * speed * Time.deltaTime;

        velocity = Vector3.ClampMagnitude(velocity, dir.magnitude);

        transform.Translate(velocity);
	}
}
