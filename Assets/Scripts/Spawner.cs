using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   public GameObject bullet;

   private void spawn_bullet() {
        Vector2 currentPosition = transform.position;
        GameObject test = GameObject.Instantiate(bullet, currentPosition, Quaternion.identity) as GameObject;
        test.AddComponent<Bullet>();
   }

    void Start() {
        spawn_bullet();
    }
   
}
