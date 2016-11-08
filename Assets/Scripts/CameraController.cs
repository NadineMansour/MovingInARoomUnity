using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 positionOffset;
	private Vector3 rotationOffset;
	// Use this for initialization
	void Start () {
		positionOffset = player.transform.position - transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w")){
			transform.position =  new Vector3(player.transform.position.x-positionOffset.x,transform.position.y,player.transform.position.z-positionOffset.z);
		}
		if(Input.GetKey("a")||Input.GetKey("d")){
			
		}
	}
}
