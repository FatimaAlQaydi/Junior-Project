using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyWall : MonoBehaviour
{

    public bool isSticky = false;
    public Sprite stickySprite;
    public float stickTime = 2f;
    private SpriteRenderer sr;


    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("StickyBullet"))
        {
            isSticky = true;
            sr.sprite = stickySprite;
            Invoke("MakeUnsticky", stickTime);
        }
    }

    void MakeUnsticky()
    {
        isSticky = false;
        sr.sprite = null;
    }
}


