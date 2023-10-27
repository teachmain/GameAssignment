using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContorl : MonoBehaviour
{
    public float scalerX = 500;
    public float scalerY = 500;
    public GameObject player;
    public float angleOfX;
    public float angleOfY;
    float distance = 5;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        angleOfX=0;
        angleOfY=0;
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * scalerX;
        float MouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * scalerY;
        angleOfX -= MouseY;
        angleOfY += MouseX;
        if(angleOfY>360){
            angleOfY -= 360;
        }
        if(angleOfX<0){
            angleOfY += 360;
        }

        angleOfX = Mathf.Clamp(angleOfX,-10,90);
        transform.rotation=Quaternion.Euler(angleOfX,angleOfY,0);
        Vector3 offset;
        offset.x = Mathf.Cos((-90-angleOfY)/180 * Mathf.PI) * distance *Mathf.Cos(angleOfX/180 * MathF.PI);
        offset.y = distance *Mathf.Sin(angleOfX/180 * MathF.PI);
        offset.z = Mathf.Sin((-90-angleOfY)/180 * Mathf.PI) * distance *Mathf.Cos(angleOfX/180 * MathF.PI);
        transform.position=player.transform.position+offset;
    }
        
}
