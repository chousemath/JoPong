using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public float paddleSpeed = 1.5F;
	public Vector3 playerPos;
	private const float lowerX = -49F;
	private const float upperX = -33F;
	private const float lowerY = -25F;
	private const float upperY = 25F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float yPos = gameObject.transform.position.y + Input.GetAxis("Vertical") * paddleSpeed;
		float xPos = gameObject.transform.position.x + Input.GetAxis ("Horizontal") * paddleSpeed;
		playerPos = new Vector3(Mathf.Clamp(xPos, lowerX, upperX), Mathf.Clamp(yPos, lowerY, upperY), 0);
		gameObject.transform.position = playerPos;
	}
}
