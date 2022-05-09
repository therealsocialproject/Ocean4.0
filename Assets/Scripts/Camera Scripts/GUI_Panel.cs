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
        GUI.Box (new Rect (0,Screen.height - 50,100,50), "Bottom-left");
        GUI.Box (new Rect (Screen.width - 100,Screen.height - 50,100,50), "Bottom-right");
    }

}