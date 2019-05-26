using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop_Magu : MonoBehaviour {
    int count = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //countが4になったら無限湧きする敵キャラが倒れる
		if(count==4)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        //敵キャラが主人公が撃つ弾に当たったらcountが増える
        if (col.gameObject.tag == "Bullet")
        {
            count++;
        }
    }
}
