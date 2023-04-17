using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeTransforms : MonoBehaviour
{
    public Vector3 Velocidade;
    public Vector3 Giro;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // V = S/t
        transform.position += Velocidade;
    }
}
