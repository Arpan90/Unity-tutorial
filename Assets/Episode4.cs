using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Episode4 : MonoBehaviour{

    // int frameCount = 0;

    // Start is called before the first frame update
    void Start(){
    //    int x = 0;
       float dst = GetDistanceBetweenTwoPoints(0,5,10,15);
       print("Distance between the points is: " + dst);
    }

    // Update is called once per frame
    void Update(){
        // frameCount += 1;
        print("Update");
        // print("Frame Count is: " +  frameCount); 
    }

    float GetDistanceBetweenTwoPoints(float x1, float y1, float x2, float y2){
        float dx = x2 - x1;
        float dy = y2 - y1;
        float dist = Mathf.Sqrt(dx * dx + dy * dy); 
        return dist; 
    }
}
