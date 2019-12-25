using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   private bool is_active;
   public GameObject bullet;

   void Awake() {
   }

    void Start() {
        Vector2 currentPosition = new Vector2(1, 1);
        GameObject test = GameObject.Instantiate(bullet, currentPosition, Quaternion.identity) as GameObject;
        test.AddComponent<Bullet>();
    }
   
}
