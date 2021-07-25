using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2script : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, 500, ForceMode.Impulse);
        }

        if(Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -500, ForceMode.Impulse);
        }






    }







}
