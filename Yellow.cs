using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 public class Yellow : MonoBehaviour
{
    public Text scoretext;
    public int score;

     void OnCollisionEnter2D(Collision2D collision)
    {
       

        Destroy(gameObject);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
