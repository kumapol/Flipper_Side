using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] int Score;
    [SerializeField] int minus_scire_on_collision;
    [SerializeField] int bumped=0;

   public void OnCollisionEnter(Collision other)
{
    if((other.gameObject.tag!="Plane")&& (other.gameObject.tag!="Hit"))  //anty plane scorer
    { 
        Score=Score - minus_scire_on_collision;
    bumped++;
 Debug.Log("Your Score is now only "+ Score);
 Debug.Log("Your bumped into things this many times "+bumped );
 }

   
}

}
