using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	private float Speed = 10.0f;

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody>().AddForce(
			(transform.forward + transform.right) * Speed,
			ForceMode.VelocityChange);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
