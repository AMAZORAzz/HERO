﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageS_Goal : MonoBehaviour {

    //風のステージのゴール判定
    int count1 = Tu_Boss.count1;
    

    public static bool isClear4 = false;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Dr.Shadow")
        {
            //ゴールに主人公が触れるとcountが増えてクリア判定になる。countが4になるとラストステージに行ける
            Tu_Boss.count1++;
            isClear4 = true;
            
        }
    }
}
