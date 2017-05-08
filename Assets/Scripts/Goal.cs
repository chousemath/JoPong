using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour {

	public Text currScore;
	public Transform paddleObj;
	public GameObject ballPrefab;
	private GameObject ballObj;
	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
		currScore.text = score.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		ballObj = GameObject.FindGameObjectWithTag ("Ball");
		currScore.text = score.ToString (); 
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Ball") {
			score++;
			Destroy (ballObj);
			(Instantiate (ballPrefab, new Vector3 (paddleObj.transform.position.x + 12, paddleObj.transform.position.y, 0), Quaternion.identity) as GameObject).transform.parent = paddleObj;
		}
	}
}
