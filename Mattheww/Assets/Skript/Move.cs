using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public float speed = 2f;

    Rigidbody2D rigidbody2d;

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            rigidbody2d.velocity = new Vector2(speed * -1, rigidbody2d.velocity.y);
        if (Input.GetKey(KeyCode.RightArrow))
            rigidbody2d.velocity = new Vector2(speed, rigidbody2d.velocity.y);
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
       
        if (other.gameObject.CompareTag("enemy"))
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(1);
        }
    }
}
