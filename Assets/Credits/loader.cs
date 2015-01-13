using UnityEngine;
using System.Collections;

public class loader : MonoBehaviour {


    public float timeBeforeNextScene = 60.0f;
    private float time = 0.0f;

    public int numberOfClicsBeforeNextScene = 100;
    private int currentNbOfCLics = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;

		if (BigRedButton.Instance.Pressed || Input.GetKeyDown(KeyCode.Space))
            ++currentNbOfCLics;

        if (time >= timeBeforeNextScene || currentNbOfCLics >= numberOfClicsBeforeNextScene)
        {
            Application.LoadLevel(3);
        }
	
	}
}
