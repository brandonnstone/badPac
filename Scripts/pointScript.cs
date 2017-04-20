using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointScript : MonoBehaviour {
	void OnCollisionEnter(Collision co) {
    if (co.gameObject.name == "Player") {
      Destroy(gameObject);
    }
	}
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}
