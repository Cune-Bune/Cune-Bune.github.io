using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Jump : MonoBehaviour
{
    public bool isGrounded;
    public bool canWalljump;
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
        if (col.gameObject.tag == ("Jumpable") && canWalljump == false)
        {
            canWalljump = true;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
            isGrounded = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && canWalljump)
        {
            rb.AddForce(new Vector3(4, 7, 0), ForceMode.Impulse);
            isGrounded = false;
        }
    }
}