using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class texteditor : MonoBehaviour
{
    public string textValue;
    public Text textElement;

    // Start is called before the first frame update
    void Start()
    {
        textElement.text = textValue;
    }

    // Update is called once per frame
    void Update()
    {
        textElement.color = new Color(
                textElement.color.r, 
                textElement.color.g, 
                textElement.color.b, 
                1f);
        //fader(1f);
    }
    
    void fader(float faderspeed)
    {
        while (textElement.color.a < 1.0f)
        {
            print("text a["+textElement.color.a+"]");
            print("Time.deltaTime["+Time.deltaTime+"]");
            print("faderspeed["+faderspeed+"]");
            print("next a["+(textElement.color.a + (Time.deltaTime / faderspeed))+"]");


            textElement.color = new Color(
                textElement.color.r, 
                textElement.color.g, 
                textElement.color.b, 
                textElement.color.a + (Time.deltaTime / faderspeed));
        }
    }
}
