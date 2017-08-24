using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PathInput : MonoBehaviour {

    public InputField input;
    public string path = " ";

    // Use this for initialization
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            input.gameObject.SetActive(true);
        }

    }
    public void get()
    {
        path = input.text;
        input.gameObject.SetActive(false);
    }

}
