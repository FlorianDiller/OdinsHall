using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public void TextChange(string dialogue)
    {
        GameObject.Find("Canvas").transform.Find("Text").GetComponent<Text>().enabled = true;
        GameObject.Find("Canvas").transform.Find("Panel").GetComponent<Image>().enabled = true;
        GameObject.Find("Canvas").transform.Find("Text").GetComponent<Text>().text = dialogue;
    }
    
}
