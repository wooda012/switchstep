using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
	public AudioSource switchSound;
	public UnityEngine.Events.UnityEvent switchColor;
    // Start is called before the first frame update
    void Start()
    {
        //switchSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)){
        	switchColor.Invoke();
        	switchSound.Play();
        }
    }
}
