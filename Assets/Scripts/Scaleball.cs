using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaleball : MonoBehaviour
{
    public GameObject wristR;
    public GameObject wristL;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dist = Math.Abs(Vector3.Distance(wristL.transform.position, wristR.transform.position));
        Vector3 newScale = new Vector3(dist/2, dist/2, dist/2);
        transform.localScale = newScale;
    }
}
