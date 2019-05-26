using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashing2 : MonoBehaviour
{

    public GameObject blok;
    public GameObject blok2;
    public GameObject blok3;
    public GameObject blok4;
    public GameObject blok5;
    float span = 3.0f;
    float delta = 0;
    float blokcount = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ラスト面にある消えるブロックがblokcountの数値で順番に出る
        this.delta += Time.deltaTime;
        if (this.delta > this.span && blokcount == 0)
        {
            //blokcountが0の時にblokを出す
            this.delta = 0;
            GameObject go = Instantiate(blok) as GameObject;
            //blokcountを一つ増やして次のblokを出す
            blokcount++;
        }
        if (this.delta > this.span && blokcount == 1)
        {
            //blokcountが1の時にblok2を出す
            this.delta = 0;
            GameObject go = Instantiate(blok2) as GameObject;
            blokcount++;
        }
        if (this.delta > this.span && blokcount == 2)
        {
            //blokcountが2の時にblok3を出す
            this.delta = 0;
            GameObject go = Instantiate(blok3) as GameObject;
            blokcount++;
        }
        if (this.delta > this.span && blokcount == 3)
        {
            //blokcountが3の時にblok4を出す
            this.delta = 0;
            GameObject go = Instantiate(blok4) as GameObject;
            blokcount++;
        }
        if (this.delta > this.span && blokcount == 4)
        {
            //blokcountが4の時にblok5を出す
            this.delta = 0;
            GameObject go = Instantiate(blok5) as GameObject;
            //blokcountを0に初期化する
            blokcount = 0;
        }
    }
}
