using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PleyerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 2000;
    public float InputOfX;
    public float InputOfY;
    public Rigidbody body;
    public Transform Camera;
    Vector3 MoveForce;
    bool canJump = true;
    float InputOfJump = 0;
    bool needJump = false;
    void Start()
    {   body.drag = 0f;
        //body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        InputOfX = Input.GetAxisRaw("Horizontal");
        InputOfY = Input.GetAxisRaw("Vertical");
        InputOfJump = Input.GetAxisRaw("Jump");
        if(InputOfJump > 0 && OnGround() && canJump){
            needJump = true;
        }
    }
    void FixedUpdate(){
        Vector3 target;
        target = Camera.transform.forward * InputOfY + Camera.transform.right * InputOfX;
        target.y = 0;
        target = target.normalized;
        if(InputOfX !=0 || InputOfY!=0){
            MoveForce = transform.forward;
        }else{
            MoveForce = new Vector3(0f,0f,0f);
        }

        MoveForce.y = 0;
        MoveForce = MoveForce.normalized;
        if(OnGround()){        
            body.AddForce(MoveForce* moveSpeed ,ForceMode.Force);
        }
        Vector3 currentSpeed = body.velocity;
        if(currentSpeed.sqrMagnitude > 9f && OnGround()){
            body.velocity = currentSpeed.normalized * 3f;
        }
        if(needJump){
            body.AddForce(new Vector3(0f,200f,0f),ForceMode.Impulse);
            needJump = false;
        }

        Vector3 rota =  Vector3.Cross(transform.forward,target);
        body.angularVelocity = rota * 30;
 
        
    }
    bool OnGround(){
        if(transform.position.y < 1.01){
            return true;
        }else{
            return false;
        }
    }
}
