using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    float timer;
    float waitingTime;
    public Transform curPos;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        waitingTime = 0.02f;
    }
    void Update()
    {
       // timer += Time.deltaTime;

       // if (timer > waitingTime)
       // {
      //      curPos.Translate(0,0,400);
      //      timer = 0;
      //  }
      //  curPos.Translate(0, 0, -400);
    }
}
