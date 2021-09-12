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
    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
            
            ScoreText.text = "1Pscore:" + Score.ToString();
            transform.position = Startposition;
        }

        if(transform.position.x > 14)
        {
            
            Score2 += 1;
           
            ScoreText2.text = "2Pscore:" + Score2.ToString();
            transform.position = Startposition;
            Debug.Log(Score2);
        }
         if(Score < Score2)
         {
            Score - Score2 > 5
                  ||
            Score2 - Score > 5
         }
              
            
            











    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Goal")
        {
            audioSource.PlayOneShot(sound1);
        }















    }












}
