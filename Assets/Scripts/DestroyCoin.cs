using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoin : MonoBehaviour
{
     void OnCollisionEnter(Collision collision){
          Destroy(collision.collider.gameObject);
          Destroy(gameObject);
          }
}
