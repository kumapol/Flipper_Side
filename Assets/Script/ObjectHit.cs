using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
 
 
  public  void OnCollisionEnter(Collision other) {
    if(other.gameObject.tag=="Player"){
    GetComponent<MeshRenderer>().material.color=Color.red;
    StartCoroutine(Uderzenie());
    gameObject.tag="Hit";
    }
  }
  
IEnumerator Uderzenie(){
 yield return new WaitForSeconds(1);
  GetComponent<MeshRenderer>().material.color=Color.green;
}
  
  void Update()
    {
     
      
    }
}
