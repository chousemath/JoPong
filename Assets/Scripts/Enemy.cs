using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float speed = 8F;
	private float xLimit = 49F;
	private const float lowerY = -25F;
	private const float upperY = 25F;
	private Vector3 targetPos;
	private GameObject ballObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ballObj = GameObject.FindGameObjectWithTag ("Ball");
		if (ballObj != null) {
			targetPos = Vector3.Lerp (gameObject.transform.position, ballObj.transform.position, Time.deltaTime * speed);
			gameObject.transform.position = new Vector3 (xLimit, Mathf.Clamp(targetPos.y, lowerY, upperY), 0);
		}
	}
}
