using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnImpact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
{
Destroy(other.gameObject);
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
