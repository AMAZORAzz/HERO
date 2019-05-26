using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lost_Enemy2 : MonoBehaviour {

    

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        //敵キャラがy軸―6になったら敵キャラが消える
		if(transform.position.y<-6)
        {
            Destroy(gameObject);
        }
	}

    
}
