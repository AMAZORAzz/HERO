using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lost_Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //無限湧きする敵キャラが6秒後に消える
        Destroy(gameObject, 6);
    }
}
