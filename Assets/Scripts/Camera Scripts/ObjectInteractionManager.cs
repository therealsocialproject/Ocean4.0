using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager
{
    public List<GameObject> objects;
    
    public ObjectManager(){
        objects = new List<GameObject> ();
    }

    public List<GameObject> GetObject(){
        return objects;
    }

    public void AddObject(GameObject item)
    {
        objects.Add(item);
    }

    public void SendDestionation(Camera cam)
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(objects.Count > 0) {
            foreach (GameObject item in objects) {

                var controller = item.GetComponent<PlayerScript>();

                if (Physics.Raycast(ray, out hit))
                {
                    controller.agent.SetDestination(hit.point);
                }
            }
            Debug.Log("Sending Destination...");
        } else
        {
            Debug.Log("No objects");
        }
    }
    public void removeObject(GameObject item)
    {
        objects.Remove(item);
    }
    public void ClearObjects()
    {
        foreach (GameObject item in objects) { 
            var script = item.GetComponent<PlayerScript>();
            script.selected = false;
        }
        objects.Clear();
    }
}


public class ObjectInteractionManager : MonoBehaviour
{
    public Camera cam;
    ObjectManager manager;
    void Start()
    {
        manager = new ObjectManager();
    }
     // Update is called once per frame
    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Mouse Clicked");
            Physics.Raycast(ray, out hit);
            if(hit.transform.gameObject.name == "Player")
            {
                Debug.Log("Player found");
                hit.transform.SendMessage("ClickedOn");
                
                var player = hit.transform.gameObject.GetComponent<PlayerScript>();
                Debug.Log(player.selected + "Player selected");
                if (player.selected)
                {
                    Debug.Log("Object ADDED");
                    manager.AddObject(hit.transform.gameObject);
                } else
                {
                    Debug.Log("Object REMOVED ");
                    manager.removeObject(hit.transform.gameObject);
                }
            }
            else
            {
                manager.SendDestionation(cam);
            }
        }
        else if(Input.GetMouseButtonDown(0)){
            manager.ClearObjects();
        }
        
        //Check if the mouse ray is hitting an object whilst clicking
        //if so add the object to the array


    }
}
