using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D),typeof(TouchingDirections))]
public class Knight : MonoBehaviour
{
    public float walkSpeed = 3f;
    Rigidbody2D rb;
    TouchingDirections touchingDirections;
    public enum WalkableDirections {Right, Left }

    private WalkableDirections _walkDirection;
    private Vector2 walkDirectionVector = Vector2.right;

    public WalkableDirections WalkDirection {  
        get { return _walkDirection; }
        set {
            if (_walkDirection != value)
            {
                gameObject.transform.localScale = new Vector2(gameObject.transform.localScale.x * -1, gameObject.transform.localScale.y);

                if(value == WalkableDirections.Right)
                {
                    walkDirectionVector = Vector2.right;
                } else if (value == WalkableDirections.Left)
                {
                    walkDirectionVector = Vector2.left;
                }
            }
            
            _walkDirection = value; }
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        touchingDirections = GetComponent<TouchingDirections>();
    }
    private void FixedUpdate()
    {
        if(touchingDirections.IsGrounded && touchingDirections.IsOnWall)
        {
            FlipDirection();
        }
        rb.velocity = new Vector2(walkSpeed * walkDirectionVector.x, rb.velocity.y);
    }

    private void FlipDirection()
    {
        if(WalkDirection == WalkableDirections.Right) 
        {
            WalkDirection = WalkableDirections.Left;
        } else if (WalkDirection == WalkableDirections.Left)
        {
            WalkDirection = WalkableDirections.Right;
        }
        else
        {
            Debug.LogError("Huong di hien tai chua dc set gia tri hop ly ben trai hoac ben phai");
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
