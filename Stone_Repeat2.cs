﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone_Repeat2 : MonoBehaviour {

    public GameObject stone;

    float span = 1.0f;
    float delta = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //1秒ごとに火の玉を落とす
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(stone) as GameObject;
            int px = Random.Range(30, 39);
            go.transform.position = new Vector3(px, 15, 0);
        }
    }
}
