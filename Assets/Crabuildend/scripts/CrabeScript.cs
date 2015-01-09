using UnityEngine;
using System.Collections;

public class CrabeScript : MonoBehaviour {

	public Vector2 speed = new Vector2(2,0);
	public int clickBeforeMove = 4;
	private int nbClick = 0;
	private Vector2 movement;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
			nbClick++;
		if (nbClick >= clickBeforeMove) {
			movement = new Vector2(speed.x,speed.y);
		}
		
	}

	void FixedUpdate()
	{
		rigidbody2D.velocity = movement;
	}
}
