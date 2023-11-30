using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBullet : MonoBehaviour
{
    public GameObject bullet;
    public Transform spwanPoint;
    public float fireSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabble = GetComponent<XRGrabInteractable>();
        grabble.activated.AddListener(FireBullets);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireBullets(ActivateEventArgs arg)
    {
        GameObject spwanedBullet = Instantiate(bullet);
        spwanedBullet.transform.position = spwanPoint.position;
        spwanedBullet.GetComponent<Rigidbody>().velocity = spwanPoint.forward * fireSpeed;
        Destroy(spwanedBullet, 5);
    }
}
