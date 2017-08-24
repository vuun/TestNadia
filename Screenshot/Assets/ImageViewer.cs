using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class ImageViewer : MonoBehaviour {

    string filename;

    void Start()
    {
        var directory = new DirectoryInfo("C:\\Users\\vuun\\Desktop");
        var load_filename = directory.GetFiles("*screen_2048x2048*.png*", SearchOption.AllDirectories).OrderByDescending(f => f.LastWriteTime).First();
        Debug.Log(load_filename);
        filename = load_filename.ToString();
    }
    void OnGUI()
    {
        if (filename != null)
        {
            Texture2D LTexture = LoadPNG(filename);
            GUI.DrawTexture(new Rect(0f, 0f, Screen.width, Screen.height), LTexture);
        }
    }

    public static Texture2D LoadPNG(string filePath)
    {
        
        Texture2D tex = null;
        byte[] fileData;

        if (File.Exists(filePath))
        {
            fileData = File.ReadAllBytes(filePath);
            tex = new Texture2D(2, 2);
            tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
        }
        return tex;
    }
}
