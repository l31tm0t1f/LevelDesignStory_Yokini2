using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour

    
{
    public Animation hingehere;

    public bool doorisopen;
    // Start is called before the first frame update
    void Start()
    {
        doorisopen = false;
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E) && doorisopen == false)
        {

            hingehere.Play();
            doorisopen = true;
        }
    }
}