using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject reference;
    public float rotation = 20f;
    public float velocity = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject) {
        reference.transform.Rotate(0, rotation * Time.deltaTime, 0);
        transform.Rotate(0, 30 * Time.deltaTime, 0);
        transform.position += reference.transform.forward * velocity * Time.deltaTime;
        transform.position += new Vector3(0,Mathf.Sin(Time.time) * Time.deltaTime,0);
        }



    }
}
