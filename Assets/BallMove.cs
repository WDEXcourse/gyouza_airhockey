using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMove : MonoBehaviour
{
    public Rigidbody rb;
    public Text ScoreText;
    private int Score = 0;
    private int Score2 = 0;

    public Text ScoreText2;
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
            

        }
        if (transform.position.x < -13)
        {
            Score+=1;
            ScoreText.text = "score" + Score.ToString();
            transform.position = Startposition;
        }

        if(transform.position.x > 14)
        {
            Score += 1;
            ScoreText2.text = "score2" + Score.ToString();
            transform.position = Startposition;
        }












    }













}
