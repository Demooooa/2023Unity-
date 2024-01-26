using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AndroidCallManager : MonoBehaviour
{
    public Text MessageText;
    // Start is called before the first frame update
    void Start()
    {
        MessageText=GameObject.Find("Text (Legacy)").GetComponent<Text>();

    }

    public void PrintAndroidMessage(string message)
    {
        var text=MessageText.text;
        text = $"{message}\r\n";
        MessageText.text = text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
