using UnityEngine;
using System.Collections;

public class TextManager : MonoBehaviour
{
    GUIText myText;

    private float speed = 20.0f;

    private Vector2 direction;

    float timer = 0.0f;
    float timeBeforeDie = 0.0f;

    bool changeSize = false;

    bool shrink = false;
    // Use this for initialization
    void Start()
    {
        timeBeforeDie = Random.Range(10.0f, 30.0f);

        myText = this.GetComponent<GUIText>();
        myText.text = GenerateText();
        myText.fontSize = Random.Range(10, 100);
        myText.font.material.color = new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255));


        changeSize = Random.Range(0.0f, 100.0f) > 80.0f ? true : false;
        if (changeSize)
        {
            shrink = Random.Range(0.0f, 100.0f) > 50.0f ? true : false;
        }

        bool insideScreen = Random.Range(0.0f, 100.0f) > 50.0f ? true : false;

        if (insideScreen)
        {
            myText.transform.position = new Vector2(Random.Range(0.0f, Screen.width) / Screen.width, Random.Range(0.0f, Screen.height) / Screen.height);
            direction = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
        }
        else
        {
            bool up = Random.Range(0.0f, 100.0f) > 50.0f ? true : false;

            if (up)
            {
                direction = new Vector2(0.0f, 1.0f);
                myText.transform.position = new Vector2(Random.Range(0.0f, Screen.width) / Screen.width, 0.0f);
            }
            else
            {
                direction = new Vector2(0.0f, -1.0f);
                myText.transform.position = new Vector2(Random.Range(0.0f, Screen.width) / Screen.width, 1.0f);
            }
        }
        speed = Random.Range(0.01f, 0.15f);
    }

    // Update is called once per frame
    void Update()
    {
        myText.transform.Translate(direction.x * speed * Time.deltaTime,
                                   direction.y * speed * Time.deltaTime,
                                   0);

        if (changeSize)
        {
            if (!shrink)
            {
                if (myText.fontSize < 300)
                {
                    float fontSize = myText.fontSize;
                    fontSize *= 1.1f;
                    myText.fontSize = (int)fontSize;
                }
            }
            else if(shrink)
            {
                if (myText.fontSize > 1)
                {
                    float fontSize = myText.fontSize;
                    fontSize *= 0.999f;
                    myText.fontSize = (int)fontSize;
                }
            }
            
                
        }

        timer += Time.deltaTime;

        if (timer >= timeBeforeDie)
        {
            Destroy(this.gameObject);
        }
    }


    string GenerateText()
    {
        bool useAName = Random.Range(0.0f, 100.0f) > 10.0f ? true : false;


        string myString = "";

        string[] names = {  "Nom 1",
                            "Nom 2",
                            "Dolphn",
                            "Guillasdfume Passdftor",
                            "Unfio",
                            "Pausdfsdfsl Gesdfrst",
                            "REKCUFREHTOM DAB",
                            "Cartmanbraaaah",
                            "Not you",
                            "Maybe you",
                            "Cyrilla Mosdsddsfsby",
                            "Mosby Cyril",
                            "Lucsdfsdfien Casdftonhnet",
                            "Dali",
                            "THE MATRIX",
                            "Salut ça va ?",
                            "cc tu veux voir ma ",
                            "J'aime beaucoup les patates",
                            "les grosses patates",
                            "le plastique c'est fantastique",
                            "c'est vrai ça",
                            "Chabrior",
                            "Le temps des rires oubliés",
                            "Mon petit oiseau sur un oranger",
                            "Ta mère c'est ton père",
                            "L'ombre tortueuse du crépuscule",
                            "des madeleines",
                            "Lady Day",
                            "Les surricates de la mort",
                            "Un lapin mort",
                            "Mon chat bourré",
                            "la géothermie",
                            "Megan Fox",
                            "Olly le clodo",
                            "Un mec sans doigt",
                            "Tacos Man",
                            "Lamasticot",
                            "Ta mère",
                            "Ton père",
                            "Toutes les perruches du mondes",
                            "Probablement toi",
                            "Athuaricd",
                            "btie",
                            "Eimnem",
                            "Hitler"

                         };

        if (useAName)
        {
            myString = names[Random.Range(0, names.Length)];
        }
        else//Generate a random string
        {
            int randomSize = Random.Range(1, 20);
            myString += (char)Random.Range((int)'A', (int)'Z');
            for(int i = 0; i < randomSize;++i)
            {
                myString += (char)Random.Range((int)'a', (int)'z');

                bool addSpace = Random.Range(0.0f, 100.0f) > 90.0f ? true : false;
                if (addSpace)
                     myString += " " ;
            }
            
        }

        return myString;
    }
}
