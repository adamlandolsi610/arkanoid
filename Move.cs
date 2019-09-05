using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 15f;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horisontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.left * horizontal * speed;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
