using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public GameObject effectImpact;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D hit) {
        if (hit.CompareTag("Block")) {
            Enemy enemy = hit.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            //Instantiate(effectImpact, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
