/* Screen.width & Screen.height layout 1.0 */
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GUI_Panel : MonoBehaviour 
{
            
    void OnGUI()
    {
        /* GUI.Box (new Rect (0,0,100,50), "Top-left"); */
        GUI.Box (new Rect (Screen.width - 100,0,100,50), "Top-right");
        GUI.Box (new Rect (0,Screen.height - 80,750,80), "Bottom-left Unit Hotkeys");
        GUI.Box (new Rect (Screen.width - 150,Screen.height - 100,150,100), "Bottom-right quick orders");
    }

}