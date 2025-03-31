using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerPanes : MonoBehaviour
{
    public GameObject manos;

    private GameObject Panes = null;

    private void OnTriggerStay(Collider other)
    {
        void Update()
        {
            if (Panes != null)
            {
                if (Input.GetKey(KeyCode.R))
                {
                    other.GetComponent<Rigidbody>().useGravity = true;
                    other.GetComponent<Rigidbody>().isKinematic = false;

                    Panes.gameObject.transform.SetParent(null);
                }
            }
        }   
        
        if (other.gameObject.CompareTag("pan"))
        {
            if (Input.GetKey("d") && Panes==null)
            {
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = manos.transform.position;
                other.gameObject.transform.SetParent(manos.gameObject.transform);
            }
        }
    }
}