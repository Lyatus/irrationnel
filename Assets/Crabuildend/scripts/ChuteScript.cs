using UnityEngine;
using System.Collections;

public class ChuteScript : MonoBehaviour {

    public Vector2 speed = new Vector2(0, -3);
    private Vector2 movement;
	// Use this for initialization
	void Start () {
        movement = new Vector2(speed.x, speed.y);
        Invoke("StopMovement", 10);
        GetComponent<Animator>().SetBool("falling", true);
	}

    void StopMovement()
    {
            movement = new Vector2(0, 0);
    }
	// Update is called once per frame
	void FixedUpdate () {
        rigidbody2D.velocity = movement;
	}
}
