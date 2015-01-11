using UnityEngine;
using System.Collections;

public class BuildingScript : MonoBehaviour {

	private Transform[] childs;
	private int pos = 1;
	private int maxSize;
    private AudioSource audioSource;
	void Start () {
		childs = GetComponentsInChildren<Transform>();
		maxSize = childs.Length;
		foreach (Transform ts in childs) {
			ts.renderer.enabled = false;
		}
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space") && pos < maxSize)
        {
			childs[pos].renderer.enabled = true;
			childs[pos+1].renderer.enabled = true;
			childs[pos+1].particleSystem.Play();
            audioSource.Play();
			pos+=2;
		}
	}
}
