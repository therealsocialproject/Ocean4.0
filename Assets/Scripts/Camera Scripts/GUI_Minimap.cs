using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_Minimap : MonoBehaviour
{
    public Texture2D icon;
    
    void OnGUI () 
    {
        if (GUI.Button (new Rect (Screen.width - 100, 0, 100, 70), icon)) 
        {
            print ("Expand Mini-Map");
        }
    
        if (GUI.Button (new Rect (Screen.width - 100, 70, 100, 50), "Mini-Map")) 
        {
            print ("Expand Mini-Map");
        }
    }
}
