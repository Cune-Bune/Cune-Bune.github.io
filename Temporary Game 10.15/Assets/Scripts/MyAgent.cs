using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MyAgent : MonoBehaviour
{
    NavMeshAgent steve;
    public Vector3 dest;//destination where steve goes
    // Start is called before the first frame update
    void Start()
    {
        steve = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        steve.destination = dest; //steve's destination is now dest
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit = new RaycastHit();
            Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(laser, out hit, 10000f))
            {
                Debug.Log("Hit something! The " + hit.transform.gameObject.name + " didn't like that.");
                dest = hit.point;
            }
        }
    }
    /*else
    {
      Input.GetMouseButton(1); Input.GetMouseButton(2);
    }*/
//}
}
