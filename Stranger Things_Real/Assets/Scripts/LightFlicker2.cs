using UnityEngine;
using System.Collections;

public class LightFlicker2 : MonoBehaviour {

	public Light directional_light;

	// Use this for initialization
	void Start () {
		
	}

	void Flicker() {
		if ( Random.value > 0.9 ) //a random chance
		{
			if (directional_light.enabled) //if the light is on...
			{
				directional_light.enabled = false;; //turn it off
			}
			else
			{
				directional_light.enabled = true; //turn it on
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		Flicker();
	}
}
