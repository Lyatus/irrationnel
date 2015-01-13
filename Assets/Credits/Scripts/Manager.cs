using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

    public GameObject textGameObject;

    public AudioClip[] sounds;

    float randomNumber = 0.0f;

    Color[] Colors = { Color.yellow, Color.red, Color.gray, Color.blue, Color.magenta, Color.black };

    AudioSource audio;

    public float timerKeyNotPressed = 10.0f;
    float time = 0.0f;
    bool keyNotPressed = false;

    enum eAction
    {
        NOTHING,
        ADDNAME,
        CHANGEBACKGROUND,
        PLAYSOUND
    }

	// Use this for initialization
	void Start () 
    {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
    {
		if (BigRedButton.Instance.Pressed || Input.GetKeyDown(KeyCode.Space))
        {
            time = 0.0f;
            randomNumber = Random.Range(0.0f, 100.0f);
            if(randomNumber <= 70.0f)
            {
                DoAction(eAction.ADDNAME);
            }
            else if(randomNumber <= 80.0f)
            {
                DoAction(eAction.PLAYSOUND);
            }
            else if(randomNumber <= 90.0f)
            {
                DoAction(eAction.CHANGEBACKGROUND);
            }
            else
            {
                DoAction(eAction.NOTHING);
            }
        }


        time += Time.deltaTime;
        if (time >= timerKeyNotPressed)
        {
            time = 0.0f;
            randomNumber = Random.Range(0.0f, 100.0f);
            if (randomNumber <= 70.0f)
            {
                DoAction(eAction.ADDNAME);
            }
            else if (randomNumber <= 80.0f)
            {
                DoAction(eAction.PLAYSOUND);
            }
            else if (randomNumber <= 90.0f)
            {
                DoAction(eAction.CHANGEBACKGROUND);
            }
            else
            {
                DoAction(eAction.NOTHING);
            }

        }


	}


    void DoAction(eAction action)
    {
        switch (action)
        {
            case eAction.ADDNAME:
                GameObject.Instantiate(textGameObject);
                break;
            case eAction.CHANGEBACKGROUND:
                Camera.main.backgroundColor = Colors[Random.Range(0, Colors.Length)];
                break;
            case eAction.PLAYSOUND:
                audio.PlayOneShot(sounds[Random.Range(0, sounds.Length)]);
                break;
            case eAction.NOTHING:
                break;
            default:
                break;
        }
    }
}
