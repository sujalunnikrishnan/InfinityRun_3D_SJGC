using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float jumbForce = 0;
    bool canJumb = true;

    void Awake ()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)  && canJumb)
        {
            //Jumb - adding force to up direction and Impulse will help for more force with less force

            rb.AddForce(Vector3.up * jumbForce);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            canJumb = true;
        }
    }
   private void OnCollisionExit(Collision collision)
   {
        if (collision.gameObject.tag == "Ground")
        {
            canJumb = false;
        }
   }
}
