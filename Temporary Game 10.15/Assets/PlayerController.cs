using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 2.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(moveHorizontal, 0.0f, moveVertical) * speed);
    }

[RequireComponent(typeof(Rigidbody))]
public class Jump : MonoBehaviour
{
    public float jumpSpeed = 5f;
    public bool isGrounded;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ("Ground") && isGrounded == false)
        {
            isGrounded = true;
        }
    }
    void Update()
    {
        if (Input.GetKey("q") || Input.GetMouseButton(0) && isGrounded)
        {
            rb.AddForce(new Vector3(0, 2, 0) * jumpSpeed, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
    public class DestroyByContact : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Boundary")
            {
                return;
            }
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}