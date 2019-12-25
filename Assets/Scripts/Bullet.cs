using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   private Rigidbody2D rb;

    public GameObject enemy_base;
    private Vector2 destination = new Vector2(1.2f, 2);

    public void Set_destination(Vector2 dest) {
        destination = dest;
    }

    public Vector2 Get_destination(){
        return destination;
    }
   void Awake(){
       rb = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
       rb.bodyType = RigidbodyType2D.Kinematic;
   }

   void Start(){
        rb.velocity = destination;
   }
}
