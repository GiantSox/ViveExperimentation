using UnityEngine;
using System.Collections;

public class Ballmove : MonoBehaviour {
	private Rigidbody rb;

	public float speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate () {
		Vector3 movement = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		rb.AddForce (speed * movement);
	}
}
