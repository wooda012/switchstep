using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
	public Transform player;
	public Transform respawnPoint;
	public AudioSource respawnSound;

	void Start(){
		//respawnSound = GetComponent<AudioSource>();
	}

	void OnTriggerEnter(Collider other){
		player.transform.position = respawnPoint.transform.position;
		respawnSound.Play();
	}
}
