using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public List<Material> materials = new List<Material>();
    Renderer rend;
    private int colorindex = 0;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[0];
    }

    // Update is called once per frame
    void Update()
    {
        rend.sharedMaterial = materials[colorindex];
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WristL") && colorindex < 5)
        {
            colorindex++;
        }
        if(other.CompareTag("WristR") && colorindex > 0){
            colorindex--;
        }
    }
}
