using UnityEngine;
using System.Collections;

public class LightFlicker : MonoBehaviour {

	public GameObject light;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if ( Random.value > 0.9 ) //a random chance
		{
			if ( light.activeInHierarchy ) //if the light is on...
			{
				light.SetActive(false); //turn it off
			}
			else
			{
				light.SetActive(true); //turn it on
			}
		}
	}
}
