﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate1 : MonoBehaviour {

    public float speed = 70f;

	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.back, speed * Time.deltaTime);
	}
}
