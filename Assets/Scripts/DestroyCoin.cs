using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoin : MonoBehaviour
{
     public bool isDestroyed;
	
     void OnCollisionEnter(Collision coll){
     if(!coll.gameObject.GetComponent<DestroyCoin>().isDestroyed) {
         isDestroyed = true;
         Destroy(gameObject);
     }
     }
}

 
 