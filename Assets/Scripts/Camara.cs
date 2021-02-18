using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camara : MonoBehaviour
{

    public int kills;
    public Text texto;
    public AudioClip pistolazo;
    private AudioSource source;
    public AudioClip pistola;
    public AudioClip pajaro;
    public Slider slider;
    public AudioClip ohNo;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        kills = 0;
        texto.text = "Score: 0";
        
    }

    // Update is called once per frame
    void Update()
    {

        Ray myray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f));
        RaycastHit hitinfo;
        Debug.DrawRay(myray.origin, myray.direction * 20, Color.red );
        if (Input.GetMouseButtonDown(0)) {
            source.volume = 1f;
            source.clip = pistola;
            source.Play();
        }

        if(slider)
        {
            AdjustVolume(slider.value);
        }
        


        if (Physics.Raycast(myray, out hitinfo) && Input.GetMouseButtonDown(0) && hitinfo.collider.CompareTag("target"))
        {

            Destroy(hitinfo.collider.gameObject);
            kills++;
            texto.text = "Score: " + kills;
            source.volume = 1f;
            source.clip = pajaro;
            source.Play();
            
        }

        if (Physics.Raycast(myray, out hitinfo) && Input.GetMouseButtonDown(0) && hitinfo.collider.CompareTag("DIE"))
        {

            source.clip = ohNo;
            source.volume = 0.2f;
            source.Play();

        }

        void AdjustVolume (float newVolume)
        {
            AudioListener.volume = newVolume;
        }

    }
}
