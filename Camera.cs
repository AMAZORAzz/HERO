using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);

        if(transform.position.x<-10)
        {
            transform.position = new Vector3(-10, player.transform.position.y, -10);
        }

        if (transform.position.x >=300)
        {
            transform.position = new Vector3(300, player.transform.position.y, -10);
        }

        if (transform.position.y<=0)
        {
            transform.position = new Vector3(player.transform.position.x, 0, -10);
        }
	}
}
