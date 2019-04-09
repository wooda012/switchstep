using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
	void OnTriggerEnter(Collider other){
		int i = Application.loadedLevel;
		Application.LoadLevel(i+1);
	}
}
