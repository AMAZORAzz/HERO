using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Move : MonoBehaviour {
    int count = 0;
    private AudioSource sound01;
    // Use this for initialization
    void Start () {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        sound01 = audioSources[0];
    }
	
	// Update is called once per frame
	void Update () {
        count++;
        if(count == 30)
            sound01.PlayOneShot(sound01.clip);
        if (count == 450 || Input.GetKeyDown("joystick button 7"))
            SceneManager.LoadScene("Attack");
    }
}
