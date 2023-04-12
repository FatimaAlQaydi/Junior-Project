using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintDecalScript : MonoBehaviour
{
    public Material decalMaterial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Bullet"))
    {
        ContactPoint2D[] contacts = other.contacts;

        if (contacts.Length > 0)
        {
            ContactPoint2D contact = contacts[0];
            GameObject decal = new GameObject();
            decal.transform.position = contact.point + contact.normal * 0.01f; // add a small offset so the decal doesn't intersect with the wall
            decal.transform.rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
            decal.transform.parent = transform;
            SpriteRenderer renderer = decal.AddComponent<SpriteRenderer>();
            renderer.sortingLayerName = "Foreground"; // set the layer to be on top of the wall sprite
            Texture2D decalTexture = decalMaterial.mainTexture as Texture2D;
            Sprite decalSprite = Sprite.Create(decalTexture, new Rect(0, 0, decalTexture.width, decalTexture.height), Vector2.one * 0.5f);
            renderer.sprite = decalSprite;
        }
    }
    }
}
