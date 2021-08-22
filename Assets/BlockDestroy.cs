using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BlockDestroy : MonoBehaviour
{
    public Text ScoreText;
    private int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")

        {

            Score++;
            ScoreText.text = "score" + Score.ToString();
            Destroy(this.gameObject);





        }


         















    }



















}
