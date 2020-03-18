using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musictrans : MonoBehaviour
{
    // Start is called before the first frame update
    private static musictrans instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);


        }
        else
        {
            Destroy(gameObject);
        }

    }
}
    
