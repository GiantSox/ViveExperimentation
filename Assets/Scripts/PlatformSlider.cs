using UnityEngine;
using System.Collections;

public class PlatformSlider : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		//transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
		transform.Translate (new Vector3 (-1, 0, 0) * Time.deltaTime);
	}
}
