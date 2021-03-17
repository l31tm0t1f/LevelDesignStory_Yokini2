using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickJacket : MonoBehaviour
{  
    public Component boatopenerhere;
    public GameObject jacketgone;
    public bool hasthejacket;
    // Start is called before the first frame update
    void Start()
    {
        hasthejacket = false;                                                  // player does NOT have an axe
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            jacketgone.SetActive(false);
            boatopenerhere.GetComponent<BoxCollider>().enabled = false;
            hasthejacket = true;
        }
    }
}