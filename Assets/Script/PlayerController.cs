using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmountLeft = 1f;
    [SerializeField] float torqueAmountRight = 1f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;
    SurfaceEffector2D surfaceEffector2D;
    Rigidbody2D rgbd2d;
    bool canMove= true;
    void Start()
    {
        rgbd2d=GetComponent<Rigidbody2D>();
        surfaceEffector2D=FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
    }

    public void DisableControls()
    {
        canMove=false;
    }
    private void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            surfaceEffector2D.speed=boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed=baseSpeed;
        }
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rgbd2d.AddTorque(torqueAmountLeft);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rgbd2d.AddTorque(torqueAmountRight);
        }
    }
}
