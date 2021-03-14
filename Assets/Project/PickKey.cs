using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickKey : MonoBehaviour
{
    public Component doorcolliderhere;
    public GameObject keygone;
    public bool hasthekey;                                                  // new boolean
    // Start is called before the first frame update
    void Start()
    {
        hasthekey = false;                                                  // player does NOT have a key
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            keygone.SetActive(false);                                       // hides the object (key from the table)
            doorcolliderhere.GetComponent<BoxCollider>().enabled = true;    // enables collider (door / plant)
            hasthekey = true;                                               // player has the object (key / axe)
        }
    }
}
