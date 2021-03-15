using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWaterRise_script : MonoBehaviour
{
    public GameObject ObjectToMove;
    public Vector3 moveDirection;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        // ObjectToMove.transform.position = +moveDirection;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
