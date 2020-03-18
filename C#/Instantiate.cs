using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
   
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    [SerializeField] float x;
    [SerializeField] float y;
    [SerializeField] float z;
   
    void Start(){
      
         Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
    }

    
}
