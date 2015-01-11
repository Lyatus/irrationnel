using UnityEngine;
using System.Collections;

public class CrabeScript : MonoBehaviour {

	public Vector2 speed = new Vector2(2,0);
	public int clickBeforeMove = 4;
	private int nbClick = 0;
	private Vector2 movement;
    private Animator animator;
    private AudioSource audioSource;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
			nbClick++;
		if (nbClick == clickBeforeMove) {
			movement = new Vector2(speed.x,speed.y);
            animator.SetBool("Moving", true);
            audioSource.Play();
		}
		
	}

	void FixedUpdate()
	{
		rigidbody2D.velocity = movement;
	}
}
