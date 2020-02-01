using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBlock : MonoBehaviour
{
    int moveSpeed = 5;

    private Vector2 startPos;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            /*while(){
                 transform.position += transform.up * moveSpeed * Time.deltaTime;
            }*/
        }
        if(Input.GetKey(KeyCode.A))
        {
           // target  = gameObject.transform.position + (-1) * transform.right * moveSpeed * Time.deltaTime;
            //MovePosition(Vector2.MoveTowards(transform.position, moveSpeed));
        }
        if(Input.GetKey(KeyCode.S))
        {
            
        }
        if(Input.GetKey(KeyCode.D))
        {
            
        }
    }
}
