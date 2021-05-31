using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEnemy : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    GameManager mymanager;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        mymanager = GameObject.Find("GameManager").GetComponent<GameManager>();

        if (other.gameObject.CompareTag("built"))
        {
            Destroy(this.gameObject);
            GameData.GameScore += 5;
            mymanager.Score();
        }
    }

    private void Update()
    {
        if(this.gameObject.transform.position.y<-7)
        {
            Debug.Log("etnered");
            Destroy(this.gameObject);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("HERE");
        if(collision.gameObject.tag == "destroy")
        {
            Debug.Log("HERE");
            Destroy(this.gameObject);
        }
    }
}
