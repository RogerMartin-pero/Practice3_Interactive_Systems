using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMenu : MonoBehaviour
{
   public GameObject pickups;
   public GameObject scalingball;
   public GameObject colorchange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PickMenu"))
        {
            pickups.SetActive(true);
            pickups.transform.GetChild(0).gameObject.SetActive(true);
            pickups.transform.GetChild(1).gameObject.SetActive(true);
            pickups.transform.GetChild(2).gameObject.SetActive(true);
            scalingball.SetActive(false);
            colorchange.SetActive(false);
        }
        if (other.CompareTag("ScaleMenu"))
        {
            pickups.SetActive(false);
            colorchange.SetActive(false);
            scalingball.SetActive(true);
        }
        if (other.CompareTag("ColorMenu"))
        {
            pickups.SetActive(false);
            scalingball.SetActive(false);
            colorchange.SetActive(true);
        }
    }
}
