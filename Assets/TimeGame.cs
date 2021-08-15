using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGame : MonoBehaviour{

    float roundStartDelayTime = 3; 
    float roundStartTime;
    int waitTime; // ints and floats are initalized to 0 by default.
    bool roundStarted; // bools are initialized to false by default.
    // Start is called before the first frame update
    void Start(){ // inherited from MonoBehaviour class.
        // Foo(5); // displaying method overloading
        // Foo(5f);
        print("Press spacebar when you think that the allotted time is up"); // inherited from the MonoBehaviour class.
        Invoke("SetNewRandomTime", roundStartDelayTime); // inherited from MonoBehaviour class.
    }

    // Update is called once per frame
    void Update(){ // inherited from MonoBehaviour class.
        if(Input.GetKeyDown(KeyCode.Space) && roundStarted){
             InputReceived();
        }
    }

    void InputReceived(){
        roundStarted = false;
        float playerWaitTime = Time.time - roundStartTime;
        float error = Mathf.Abs(waitTime - playerWaitTime);

        print( "You waited for: " + playerWaitTime + " seconds. That is off by " + error + " seconds. " + GenerateMessage(error) );
        Invoke("SetNewRandomTime", roundStartDelayTime);
    }

    string GenerateMessage(float error){
        string message = "";
        if(error <  0.15f){
            message = "Outstanding!";
        }
        else if(error < .75f){
            message = "Exceeds expectations";
        }
        else if(error < 1.25f){
            message = "Acceptable";
        }
        else if(error < 1.75f){
            message = "Poor";
        }
        else{
            message = "Dreadful";
        }

        return message; 
    }

    void SetNewRandomTime(){
        waitTime = Random.Range(5, 21); // Random.Range() has method overloading for int and float values.
        roundStartTime = Time.time;
        print("Wait Time: " +  waitTime);
        roundStarted = true;
    }

    // void Foo(int x){
    //     print("Integer: " + x);
    // }

    // void Foo(float x){
    //     print("Float: " + x);
    // }
}
