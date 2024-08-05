using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    public bool Activate;
    public bool Local;
    public Vector3 Rot;
    void Update()
    {
        if (!Activate) return;
        if (Local)
            transform.localEulerAngles += Rot * Time.deltaTime;
        else transform.eulerAngles += Rot * Time.deltaTime;
    }
}
