using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour
{
    [SerializeField] float steerSpeed =  15f;
    [SerializeField] float moveSpeed = 7f;


    void Start()
    {
      
    }
      

    void Update()
    {
       float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
       float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime ;
       transform.Rotate(0 , 0 , -steerAmount ); //ใส่ f ดพราะว่า 0.1 เป็นfloat
       transform.Translate( 0 , moveAmount, 0);
    }

}