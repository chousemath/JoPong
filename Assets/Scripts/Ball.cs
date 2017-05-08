using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float ballVelocity = 3000F;
	private Rigidbody rb;
	private bool isPlay;
	private int randInt;

	// Use this for initialization
	void Awake () {
		rb = gameObject.GetComponent<Rigidbody> ();
		randInt = Random.Range (1, 3);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && !isPlay) {
			transform.parent = null;
			isPlay = true;
			rb.isKinematic = false;
			if (randInt == 1) {
				rb.AddForce (new Vector3 (ballVelocity, ballVelocity, 0));
			} else if (randInt == 2) {
				rb.AddForce (new Vector3 (-ballVelocity, -ballVelocity, 0));
			}
		}
	}
}
