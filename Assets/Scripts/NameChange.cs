using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameChange : MonoBehaviour
{
    GameObject Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public string newString()
    {
        Text = GameObject.Find("ScoreText");
        Text.GetComponent<Text>().text = Text.GetComponent<Text>().text;
        return Text.GetComponent<Text>().text;
    }
}
