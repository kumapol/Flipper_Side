using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dropper : MonoBehaviour
{
    float time_pased;
    [SerializeField] float time_to_fall=5f;
    MeshRenderer renderer ;
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
   renderer= GetComponent<MeshRenderer>();
   renderer.enabled=false;

rigidbody= GetComponent<Rigidbody>();
  rigidbody.useGravity=false;
    }

    // Update is called once per frame
    void Update()
    {
        time_pased=Time.time;
        if (time_pased>time_to_fall)
        {
        renderer.enabled=true;
         rigidbody.useGravity=true;
        }
    }
}
