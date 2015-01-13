using UnityEngine;
using System;
using System.Collections;

public class CharacterControls : MonoBehaviour {
	public float leftSpeed;
	public float downSpeed;
	public float jumpHeight;
	
	bool falling = false;
	bool jumping = false;
	Vector3 jumpStart;
	
	CameraControls cameraControls;
	
	void Start(){
		cameraControls = GameObject.Find("Main Camera").GetComponent<CameraControls>();
	}
	void Update () {
		if(falling){
			cameraControls.distance += (new Vector3(0,-6.5f,-10) - cameraControls.distance)*.02f;
			transform.position += new Vector3(0,-downSpeed*Time.deltaTime,0);
		}
		else{
			if((BigRedButton.Instance.Pressed || Input.GetKeyDown("space")) && !jumping)
				StartCoroutine(jump());
		}
		transform.position += new Vector3(leftSpeed*Time.deltaTime,0,0);
	}
	IEnumerator jump(){
		jumping = true;
		jumpStart = transform.position;
		GetComponent<AudioSource>().Play();
		GetComponent<Animator>().SetBool("jumping",true);
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
		GetComponent<Animator>().SetBool("jumping",false);
		jumping = false;
	}
	IEnumerator endLevel(){
		yield return new WaitForSeconds(5);
		Application.LoadLevel("Scene 2");
	}
	void OnTriggerEnter2D(Collider2D c){
		if(c.gameObject.name=="Level End"){
			falling = true;
			GetComponent<Animator>().SetBool("falling",true);
			GameObject.Find("WalkingSound").GetComponent<AudioSource>().Stop();
			AudioSource[] shits = c.gameObject.GetComponents<AudioSource>();
			foreach(AudioSource truc in shits)
				truc.Play();
			cameraControls.ignoreY = false;
			StartCoroutine(endLevel());
		}
	}
}
