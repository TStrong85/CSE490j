using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public GameObject player;
    public float openDistance = 5;
    public float openAngle = 80;
    public float openSpeed = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null) {
            float distance = Vector3.Distance(player.transform.position, transform.position);
            if (distance <= openDistance) {
                if (transform.eulerAngles.y < openAngle) {
                    transform.eulerAngles += Vector3.up * openSpeed * Time.deltaTime;
                    if (transform.eulerAngles.y > openAngle) {
                        transform.eulerAngles = Vector3.up * openAngle;
                    }
                }
            } else {
                transform.eulerAngles = Vector3.zero;
            }
        }
    }
}
