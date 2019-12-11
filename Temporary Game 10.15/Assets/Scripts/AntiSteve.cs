using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AntiSteve : MonoBehaviour
{
    NavMeshAgent joe;
    // Start is called before the first frame update
    void Start()
    {
        joe = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider triggerReport) // this will store information on collider trigger
    {
        Debug.Log("TRIGGER ENTERED");
        if (triggerReport.name == "Steve") { //this checks the name of whatever thing entered the trigger zone. in this case steve.

            Debug.Log("ENEMY SPOTTED");
            joe.destination = triggerReport.transform.position;//JOE MURDERS STEVE
        } 
    }
}
