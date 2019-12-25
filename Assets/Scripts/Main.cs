using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
    public GameObject spawner;


    private void add_spawner(Vector2 pos){
        spawner = GameObject.Instantiate(spawner, pos, Quaternion.identity) as GameObject;
    }
    private void check_pointer_click(){
        if(Input.GetMouseButtonDown(0)){
            Vector2 clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            add_spawner(clickPos);
        }
    }
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        check_pointer_click();
    }
}
