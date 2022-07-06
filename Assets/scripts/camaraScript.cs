using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraScript : MonoBehaviour
{
    Vector3 camPos;
    float time = 0;
    public float camSpeed;
    bool move = false;

    void Start()
    {
        camPos = this.transform.position;

       // transform.position = new Vector3(0, 0 ,-1);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;


        if(move == false)
        {
   
                transform.position += new Vector3(camSpeed, 0, 0);
            
        }

        if(time >= 2)
        {
            move = true;
        }
    }
}
