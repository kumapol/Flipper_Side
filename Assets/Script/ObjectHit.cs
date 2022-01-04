using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
 
 
  public  void OnCollisionEnter(Collision other) {
          
           GetComponent<MeshRenderer>().material.color=Color.red;
           StartCoroutine(Uderzenie());
  }
  
IEnumerator Uderzenie(){
 yield return new WaitForSeconds(1);
  GetComponent<MeshRenderer>().material.color=Color.green;
}
  
  void Update()
    {
     
      
    }
}
