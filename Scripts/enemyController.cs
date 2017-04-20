﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {
	public Transform target;
  public float speed;

	void FixedUpdate() {
    float step = speed * Time.deltaTime;
    transform.position = Vector3.MoveTowards(transform.position, target.position, step);
  }
}
