using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CibleController : MonoBehaviour
{
    [SerializeField] private Transform spawnPointTransform;
    [SerializeField] private Transform CibleHolderTransform;


    

    
    // Update is called once per frame
    void Start()
    {
        
            Vector3 posGO = spawnPointTransform.position;
            for (int i = 0; i < 4; i++)
            {
                Vector3 newPos = posGO + new Vector3(i*3f,0f, 0f);
            
                Instantiate(Resources.Load("Cible"),
                    newPos,
                    Quaternion.Euler(0,90,0),
                    CibleHolderTransform);
            }
            

            
    }

    

    
}
           

