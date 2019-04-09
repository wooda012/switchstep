using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
	public float speed = 10.0F;
	public float jumpHeight = 2F;
	public LayerMask ground;
	public Transform feet;
	private Rigidbody rbody;
	public AudioSource jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        rbody = GetComponent<Rigidbody>();
        //jumpSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    	float translation = Input.GetAxis("Vertical") * speed;
    	float strafe = Input.GetAxis("Horizontal") * speed;
    	translation *= Time.deltaTime;
    	strafe *= Time.deltaTime;

    	transform.Translate(strafe, 0, translation);

    	bool isGrounded = Physics.CheckSphere(feet.position, 0.2f, ground, QueryTriggerInteraction.Ignore);
		if(Input.GetButtonDown("Jump") && isGrounded) {
			rbody.AddForce(Vector3.up * Mathf.Sqrt(jumpHeight * -2f * Physics.gravity.y), ForceMode.Impulse);
			jumpSound.Play();
		}
        
    }
}
