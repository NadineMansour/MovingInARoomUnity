using UnityEngine;
using System.Collections;

public class AJController : MonoBehaviour {
	private Animator animator;
	private float speed = 3.0f;
	private Rigidbody rb;
	private bool walkForward, suspendMove;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
		walkForward = false;

		if (Input.GetKey("w") && !suspendMove){
			//Walk forward
			walkForward = true;
			transform.Translate (0, 0, Input.GetAxis("Vertical")*2*Time.deltaTime);
		}
		

		if (Input.GetKey("d")){
			//rotate clockwise
			transform.Rotate(Vector3.up * 50 * Time.deltaTime);
			walkForward = true;
		}
		

		if (Input.GetKey("a")){
			//rotate anti-clockwise
			transform.Rotate(Vector3.up * -50 * Time.deltaTime);
			walkForward = true;
		}
		

		animator.SetBool("walkForward", walkForward );
	}

	void OnCollisionEnter (Collision col){
		if (col.gameObject.CompareTag("wall") || col.gameObject.CompareTag("furniture")){
			suspendMove = true;
		}
	}

	void OnCollisionExit (Collision col){
		if (col.gameObject.CompareTag("wall") || col.gameObject.CompareTag("furniture")){
			suspendMove = false;
		}
	}
}
