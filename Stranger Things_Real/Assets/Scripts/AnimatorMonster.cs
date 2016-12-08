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

		// Navigate the Demogorgon
		bool walkforward = Input.GetKey("up"); // Detects if the up key is pressed 
		bool walkbackward = Input.GetKey("down"); // Detects if the down key is pressed 
		bool walkright = Input.GetKey("right"); // Detects if the right key is pressed 
		bool walkleft = Input.GetKey ("left"); // Detects if the left key is pressed 

		if (walkforward) {
			animator.SetBool ("WalkForward", true); // Move forward 
			monster.transform.Translate (0, 0, 0.06f);
		} else {
			animator.SetBool ("WalkForward", false);
		}

		if (walkbackward) {
			animator.SetBool ("WalkBackward", true); // Move backward
			monster.transform.Translate (0, 0, -0.06f);
		} else {
			animator.SetBool ("WalkBackward", false);
		}

		if (walkright) {
			animator.SetBool ("WalkRight", true); // Move right
			monster.transform.Translate (0.06f, 0, 0);
		} else {
			animator.SetBool ("WalkRight", false);
		}

		if (walkleft) {
			animator.SetBool ("WalkLeft", true); // Move left 
			monster.transform.Translate (-0.06f, 0, 0);
		} else {
			animator.SetBool ("WalkLeft", false);
		}

		// Specific Demogorgon actions
		bool attack = Input.GetKey("return"); // Detects if the enter key is pressed 
		bool spawn = Input.GetKey("s"); // Detects if the s key is pressed  

		if (attack) {
			animator.SetBool ("Attack", true); // Attack
		} else {
			animator.SetBool ("Attack", false);
		}

		if (spawn) {
			animator.SetBool ("Spawn", true); // Climb up from the ground
		} else {
			animator.SetBool ("Spawn", false);
		}
	}
}
			
