using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

    public GameObject textGameObject;

    float randomNumber = 0.0f;

    Color[] Colors = { Color.yellow, Color.red, Color.gray, Color.blue, Color.magenta, Color.black };

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
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            randomNumber = Random.Range(0.0f, 100.0f);
            if(randomNumber <= 70.0f)
            {
                DoAction(eAction.ADDNAME);
                Debug.Log("AddName");
            }
            else if(randomNumber <= 80.0f)
            {
                DoAction(eAction.PLAYSOUND);
                Debug.Log("PlaySound");
            }
            else if(randomNumber <= 90.0f)
            {
                DoAction(eAction.CHANGEBACKGROUND);
                Debug.Log("ChangeBG");
            }
            else
            {
                //DO NOthing
                DoAction(eAction.NOTHING);
                Debug.Log("Nothing");
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
                break;
            case eAction.NOTHING:
                break;
            default:
                break;
        }
    }
}
