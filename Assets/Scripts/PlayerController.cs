using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 5f;

    private Animator anim;

    private bool playerMoving;
    private Vector2 lastMove;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        playerMoving = false;

        if (moveHorizontal > 0.5f || moveHorizontal < -0.5f){
            transform.Translate(new Vector3(moveHorizontal * moveSpeed * Time.deltaTime, 0f, 0f));
            playerMoving = true;
            lastMove = new Vector2(moveHorizontal, 0f); 
        } 
        if (moveVertical > 0.5f || moveVertical < -0.5f){
            transform.Translate(new Vector3(0f, moveVertical * moveSpeed * Time.deltaTime, 0f));
            playerMoving = true;
            lastMove = new Vector2(0f, moveVertical); 
        }


        anim.SetFloat("MoveX", moveHorizontal);
        anim.SetFloat("MoveY", moveVertical);
        anim.SetBool("PlayerMoving",playerMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);
	}
}
