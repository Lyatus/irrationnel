using UnityEngine;
using System.Collections;

public class CameraControls : MonoBehaviour {
	public GameObject followee;
	public Vector3 distance;
	public bool ignoreX;
	public bool ignoreY;
	public bool ignoreZ;
	
	// Update is called once per frame
	void OnPreCull () {
		Vector3 newPosition = transform.position;
		if(!ignoreX) newPosition.x = followee.transform.position.x + distance.x;
		if(!ignoreY) newPosition.y = followee.transform.position.y + distance.y;
		if(!ignoreZ) newPosition.z = followee.transform.position.z + distance.z;
		transform.position = newPosition;
	}
}
