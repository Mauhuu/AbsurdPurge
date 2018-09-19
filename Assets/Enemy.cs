using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed;
    public float stoppingDistance;
    public float retreatDistance;

    public Transform player;
    public Rigidbody2D rb;
    public float pushForce = 5;

    // Use this for initialization
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        } else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        } else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
        
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Wall"))
        {
            rb.AddForce(Vector2.up * pushForce, mode: ForceMode2D.Impulse);
        }
        if (col.gameObject.tag.Equals("BottomWall"))
        {
            rb.AddForce(Vector2.up * pushForce, mode: ForceMode2D.Impulse);
        }
        if (col.gameObject.tag.Equals("TopWall"))
        {
            rb.AddForce(Vector2.down * pushForce, mode: ForceMode2D.Impulse);
        }
        if (col.gameObject.tag.Equals("BorderWallL"))
        {
            rb.AddForce(Vector2.right * pushForce, mode: ForceMode2D.Impulse);
        }
        if (col.gameObject.tag.Equals("BorderWallR"))
        {
            rb.AddForce(Vector2.left * pushForce, mode: ForceMode2D.Impulse);
        }

    }
}
