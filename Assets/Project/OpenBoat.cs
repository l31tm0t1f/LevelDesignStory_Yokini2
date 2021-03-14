using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBoat : MonoBehaviour
{
    public GameObject boatopenerhere; // select the blocking trigger box

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
            Destroy(boatopenerhere);
    }
}