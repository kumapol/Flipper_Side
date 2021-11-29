using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mover : MonoBehaviour
{

    [SerializeField]  float speed=12f;
  

    void Start()
    {
        SendInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        Moveplayer();
    }

    void SendInstructions()
    {
        Debug.Log("You controll player with arrows");

    }

    void Moveplayer()
    {
        float xValue=Input.GetAxis("Horizontal")*speed*Time.deltaTime;
        float zValue=Input.GetAxis("Vertical")*speed*Time.deltaTime;
        transform.Translate(xValue,0,zValue);
    }



}
