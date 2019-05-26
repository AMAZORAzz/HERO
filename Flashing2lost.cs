using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashing2lost : MonoBehaviour {
    public GameObject blok;
    float span = 5.0f;
    float delta = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(blok) as GameObject;
        }
    }
}
