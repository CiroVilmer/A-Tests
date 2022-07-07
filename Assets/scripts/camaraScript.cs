using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camaraScript : MonoBehaviour
{
    Vector3 camPos;
    float time = 0;
    public float camSpeed;
    bool move = false;
    bool textGrouth = false;
    public Text title;
    public GameObject titleGM;
    public GameObject playBtn;

    void Start()
    {
        camPos = this.transform.position;
        titleGM.SetActive(false);
        playBtn.SetActive(false);
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
            titleGM.SetActive(true);
            
            if(textGrouth == false)
            {
                title.fontSize += 1;
                if (title.fontSize == 24)
                {
                    textGrouth = true;
                    playBtn.SetActive(true);
                }
            }
        }
    }
}
