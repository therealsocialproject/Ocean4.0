using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour
{

    public Camera cam;
    public NavMeshAgent agent;
    private bool _selected;
    public bool selected { 
        get 
        { 
            return _selected; 
        }
        set
        {
            _selected = value;
            var renderer = GetComponent<Renderer>();
            renderer.materials[0].color = (selected)? Color.blue: Color.red;
        }
    
    }
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    // Update is called once per frame
    void Update()
    {
    }

    void ClickedOn()
    {
        selected = !selected;
    }
}