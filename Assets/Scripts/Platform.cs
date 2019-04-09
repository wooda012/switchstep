using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
	public bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        if(!isActive){
        	for (int i = 0; i < transform.childCount; i++){
    		transform.GetChild(i).gameObject.SetActive(false);
    		}
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeState(){
    	if(isActive){
    		for (int i = 0; i < transform.childCount; i++){
    		transform.GetChild(i).gameObject.SetActive(false);
    		isActive = false;
    		}
    	}
    	else{
    		for (int i = 0; i < transform.childCount; i++){
    		transform.GetChild(i).gameObject.SetActive(true);
    		isActive = true;
    		}
    	}
    }
}
