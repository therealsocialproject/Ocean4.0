using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_Minimap : MonoBehaviour
{
    public Texture2D icon;
    
    void OnGUI () 
    {
        if (GUI.Button (new Rect (10,10, 100, 50), icon)) 
        {
            print ("Expand Mini-Map");
        }
    
        if (GUI.Button (new Rect (10,70, 100, 20), "Mini-Map")) 
        {
            print ("Expand Mini-Map");
        }
    }
}
