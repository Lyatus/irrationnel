using UnityEngine;
using System;
using System.Collections;

public class CharacterControls : MonoBehaviour {
	public float leftSpeed;
	public float jumpHeight;
	
	bool jumping = false;
	Vector3 jumpStart;
	
	void Update () {
		if(Input.GetKeyDown("space") && !jumping)
			StartCoroutine(jump());
		transform.position += new Vector3(leftSpeed*Time.deltaTime,0,0);
	}
	IEnumerator jump(){
		jumping = true;
		jumpStart = transform.position;
		while(true){
			Vector3 newPosition = transform.position;
			newPosition.y = -Mathf.Pow((newPosition.x-jumpStart.x)+Mathf.Sqrt(jumpHeight),2)+jumpHeight+jumpStart.y;
			if(newPosition.y<jumpStart.y){
				newPosition.y = jumpStart.y;
				transform.position = newPosition;
				break;
			}
			else transform.position = newPosition;
			yield return 0;
		}
		jumping = false;
	}
	void OnTriggerEnter2D(Collider2D c){
		if(c.gameObject.name=="Level End")
			Application.LoadLevel("Scene 2");
		else Debug.Log("what should we do when we lose?");
	}
}
