using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float smoothing = 100;
    public float speed = 3;
    private Vector2 targetPos = new Vector2(0, 0);
    private Rigidbody2D rigidboody;
    private Animator animator;
    // Use this for initialization
    void Start()
    {
        rigidboody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal")*speed * Time.deltaTime;
        float v = Input.GetAxisRaw("Vertical")*speed * Time.deltaTime;
        targetPos += new Vector2(h, v);
        rigidboody.MovePosition(Vector2.Lerp(transform.position, targetPos, smoothing * Time.deltaTime));
		if (Input.GetKey(KeyCode.UpArrow)) { animator.SetTrigger("Up"); }
        if (Input.GetKey(KeyCode.DownArrow)) { animator.SetTrigger("Down"); }
        if (Input.GetKey(KeyCode.LeftArrow)) { animator.SetTrigger("Left"); }
        if (Input.GetKey(KeyCode.RightArrow)) { animator.SetTrigger("Right"); }
       
    }
   
}
