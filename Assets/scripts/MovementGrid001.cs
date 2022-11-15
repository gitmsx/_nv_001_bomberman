using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementGrid001 : MonoBehaviour
{

    public float speed = 1; 
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mov = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * speed; mov = Vector3.ClampMagnitude(mov, speed);
        
        if (mov != Vector3.zero)
        {
            rb.MovePosition(transform.position + mov * Time.deltaTime); rb.MoveRotation(Quaternion.LookRotation(mov));
        }
    }

}


