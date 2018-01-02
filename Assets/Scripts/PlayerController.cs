using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        if (moveHorizontal > 0.5f || moveHorizontal < -0.5f){
            transform.Translate(new Vector3(moveHorizontal * moveSpeed * Time.deltaTime, 0f, 0f));
        } 
        if (moveVertical > 0.5f || moveVertical < -0.5f){
            transform.Translate(new Vector3(0f, moveVertical * moveSpeed * Time.deltaTime, 0f));
        } 


	}
}
