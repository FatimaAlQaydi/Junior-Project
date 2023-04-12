using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyBullet : MonoBehaviour
{
    public float lifetime = 2f;

    GameObject impactEffect;
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        print("Bullet collide: " + other.gameObject.tag);
        // Destroy the bullet when it collides with the wall
        if (other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
