using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationTurret : MonoBehaviour
    
{
    [SerializeField]
    GameObject spawn;

    float mousePositionX;
    float mousePositionY;
    Vector2 mousePosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            
            Debug.Log(Input.mousePosition);

            transform.position = Input.mousePosition;



        }

    }
}
