using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour

    
{
    public Animation hingehere;
    public GameObject hasthekey;
    public bool doorisopen;
    private PickKey pickkey_script;
    // public bool hasthekey;
    // Start is called before the first frame update
    void Start()
    {
        doorisopen = false;
        pickkey_script = hasthekey.GetComponent<PickKey>();     // get hasthekey value
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E) && doorisopen == false && hasthekey == true)
        {

            hingehere.Play();
            doorisopen = true;
        }
    }
}