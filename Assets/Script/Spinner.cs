using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] [Range(0,1)] float speed_of_spinning=0.5f;
    [SerializeField] bool  prawo_true=true;
      int direction_of_spining;

    void Start()
    {
      if(prawo_true==true) {
          direction_of_spining=1;
      }
      else {direction_of_spining=-1;
      }
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,speed_of_spinning*direction_of_spining,0);
    }
}
