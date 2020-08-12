using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rigitbody;
    public float jumpForce;
    public float speed;

    private void Update() 
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rigitbody.velocity = new Vector2(0, 0);
        rigitbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

    }

}
