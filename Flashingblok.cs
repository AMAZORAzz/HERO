using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashingblok : MonoBehaviour {

    public GameObject blok;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //消えるブロックの消える時間
            Destroy(gameObject,5);
	}
}
