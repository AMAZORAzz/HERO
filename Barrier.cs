using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //岩ステージに出てくる敵キャラのガード判定を消す
        Destroy(gameObject);
	}
}
