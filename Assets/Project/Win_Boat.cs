using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win_Boat : MonoBehaviour
{

    public GameObject UIObject_boat3;                                 // Text before finding the key

    // Start is called before the first frame update
    void Start()
    {
        UIObject_boat3.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            UIObject_boat3.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            UIObject_boat3.SetActive(false);
        }
    }
}
