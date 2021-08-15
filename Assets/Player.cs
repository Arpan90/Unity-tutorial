using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    // Start is called before the first frame update
    void Start(){

    }

    public float speed = 10;

    // Update is called once per frame
    void Update(){
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0 , Input.GetAxisRaw("Vertical") );
        Vector3 direction = input.normalized; 
        Vector3 velocity = direction * speed;
        Vector3 moveAmount = velocity * Time.deltaTime; // deltaTime is the time difference between 2 frames

        // transform.position += moveAmount; 
        transform.Translate(moveAmount); // the more common way to do this 
    }
}
