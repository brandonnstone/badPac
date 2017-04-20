﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate() {
		float moveHoriz = Input.GetAxis("Horizontal");
		float moveVert = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHoriz, 0.0f, moveVert);

		rb.AddForce(movement * speed);
	}
}
