using UnityEngine;
using System.Collections;

public class AnimatorMonster : MonoBehaviour {

	//Initialize variable 
	public GameObject monster;
	Animator animator;

	void Start () {
		// Grab the animator component 
		animator = GetComponent<Animator> ();
	}

	void Update () {

		// Detect if the space bar is down
		// Grab the space bar input
		// If the space bar is down, transition to the moving animation 
		// Set the condition boolean to true 
		// If the space bar is up, set the condition boolean to false

		bool keydown = Input.GetKey("space"); // Detects if the spacebar is down
		bool keyup = Input.GetKeyUp("space"); // Detects if the spacebar is up
		bool attack = Input.GetKey("return"); // Detects if the enter key is down
		bool spawn = Input.GetKey("s"); // Detects if the s key is down 

		if (keydown) {
			animator.SetBool ("WalkForward", true);
			monster.transform.Translate (0, 0, 0.06f);
		} else if (keyup) {
			animator.SetBool ("WalkForward", false);
		}

		if (attack) {
			animator.SetBool ("Attack", true);
		} else {
			animator.SetBool ("Attack", false);
		}

		if (spawn) {
			animator.SetBool ("Spawn", true);
		} else {
			animator.SetBool ("Spawn", false);
		}
	}
}
			
