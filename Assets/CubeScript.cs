using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour{

    public Transform sphereTransform; 

    // Start is called before the first frame update
    void Start() {
        sphereTransform.parent = transform; // this makes cube object the parent of sphere object.

        // sphereTransform.localScale = new Vector3(2,2,2);
        sphereTransform.localScale = Vector3.one * 2; // shorthand for the above commented code.
    }

    // Update is called once per frame
    void Update(){
        // transform.eulerAngles += new Vector3(0, 1, 0) * 180 * Time.deltaTime;
        // transform.eulerAngles += Vector3.up * 180 * Time.deltaTime; // shorthand for the above commented code. 
                                                                       // Note that Vector3.up is a static property, or in other words you don't need a specific "Vector3 object" to reference it,
                                                                       // hence the new keyword is not used here.
                                                    

        // transform.Rotate(Vector3.up * 180 * Time.deltaTime, Space.Self); // cube rotates in local space(like in earlier commented out code). If no 2nd parameter is mentioned, Space.Self is default
        transform.Rotate(Vector3.up * 180 * Time.deltaTime, Space.World); // cube rotates in global space

        transform.Translate(Vector3.forward * Time.deltaTime * 7, Space.World); // here too the Space.World or Space.Self parameter can be added. Space.Self is default

        if(Input.GetKeyDown(KeyCode.Space)){
            // sphereTransform.position = Vector3.zero; // resets the sphere to global(0,0,0) position on every spacebar press.
            sphereTransform.localPosition = Vector3.zero; // resets the sphere to local(0,0,0) aka parent position on every spacebar press.
        }
    }
}
// “The main thing is to keep the main thing the main thing”
// — Stephen Covey

// Next video: 
// https://www.youtube.com/watch?v=B0aGFBo_Ki0&list=PLFt_AvWsXl0fnA91TcmkRyhhixX9CO3Lw&index=11