using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraPosition : MonoBehaviour
{
    public Camera MainCamera;
    void Start()
    {
        MainCamera.transform.position = new Vector3(0, 2.5f, 0);
        //MainCamera.transform.Rotate(Vector3.up, 79);    
    }
    
}
