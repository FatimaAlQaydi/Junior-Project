using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the ammo collides with a wall or other obstacle
        if (other.gameObject.CompareTag("Wall") || other.gameObject.CompareTag("Obstacle"))
        {
            // Remove the ammo object
            Destroy(gameObject);
        }
    }

}
