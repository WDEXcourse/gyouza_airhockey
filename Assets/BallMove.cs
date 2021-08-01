using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public Rigidbody rb;

    public Vector3 Startposition;


    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(45, 0, 0, ForceMode.Impulse);
		Startposition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -20)
        {
            transform.position = Startposition;

        }

















    }













}
