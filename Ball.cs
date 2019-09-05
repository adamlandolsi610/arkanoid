using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Text Scoretext;
    public int score;
    public float speed = 30f;
    float hitfactore(Vector2 BallPosition, Vector2 RacketPosision, float RacketHeight)
    {
        return (BallPosition.x = RacketPosision.x) / RacketHeight;
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
         if(collision.gameObject.name=="racket")
        {
            float x = hitfactore(transform.position,
                                   collision.transform.position,
                                    collision.collider.bounds.size.x);
            Vector2 direction = new Vector2(x, 1).normalized;
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
        if (collision.gameObject.tag == "yellowblock")
        {
            score++;
            Scoretext.text = score.ToString();
        }

    }




    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
