using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{ 

    Animator Robot;                                  //設定名稱

    private void Start()
    {
        Robot = GetComponent<Animator>();            //抓取Animator
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))         //按下space攻擊
        {
            Robot.SetTrigger("toBigAttack");
        }

        if(Input.GetKey(KeyCode.R))                  //按下R奔跑
        {
            Robot.SetBool("toRun", true);
        }
        else                                         //放開停下奔跑
        {
            Robot.SetBool("toRun", false);
        }

        //優化寫法

        //if(Input.GetKeyDown(KeyCode.Space)) Robot.SetTrigger("toBigAttack");

        //Robot.SetBool("toRun", Input.GetKey(KeyCode.R));
    }
}
