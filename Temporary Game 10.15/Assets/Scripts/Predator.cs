﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Predator : MonoBehaviour
{
    public Transform target;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDir = Vector3.Normalize(target.position - transform.position);
        rb.AddForce(targetDir * 1f); //This makes the attack speed of basic AI enemies normalized so that they don't suddenly go super sonic speeds and they go toward the player
    }

    /*void OnCollisionEnter(Collision colReport)
    {
        if (colReport.gameObject.CompareTag("Player"))
        {
            Destroy(colReport.gameObject);
        }
        // This part is what makes things disappear on contact
    }*/
}
