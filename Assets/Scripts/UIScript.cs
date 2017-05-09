using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

	public Button lightsButton;
	public GameObject[] lights;

	void Start () {
		Button lightsBtn = lightsButton.GetComponent<Button>();
		lightsBtn.onClick.AddListener(actionLights);

		lights = GameObject.FindGameObjectsWithTag("RoomLight");
	}
	
	void actionLights () {

		foreach(GameObject light in lights){
			float intensity = light.GetComponent<Light> ().intensity;

			if (intensity == 0) {
				light.GetComponent<Light> ().intensity = 2.64f;
			} else {
				light.GetComponent<Light> ().intensity = 0;
			}
		}
	}
}
