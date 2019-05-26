using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //溶岩ステージの火の玉のギミックがy軸-5になったら消える
        transform.Translate(0, -0.1f, 0);
        if(transform.position.y<-5)
        {
            Destroy(gameObject);
        }
	}
}
