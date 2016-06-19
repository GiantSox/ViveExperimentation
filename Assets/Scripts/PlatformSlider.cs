using UnityEngine;
using System.Collections;

public class PlatformSlider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
		transform.Translate (new Vector3 (1, 0, 0) * Time.deltaTime)
	}
}
