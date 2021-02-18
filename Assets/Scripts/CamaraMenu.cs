using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Ray myray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitinfo;

        if (Physics.Raycast(myray, out hitinfo) && Input.GetMouseButtonDown(0) && hitinfo.collider.CompareTag("movile")) {
            hitinfo.collider.GetComponent<Rigidbody>().AddForce(-hitinfo.normal* 5, ForceMode.Impulse);
        }
        
    }
}
