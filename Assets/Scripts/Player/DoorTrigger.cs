using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public AudioClip audioClip;

    [SerializeField] AudioSource audioSource;
    public GameObject door;
    
     float moveSpeed = 2f;
    
    float lowerHeight = -7f;


    private bool isOpening = false;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOpening = true; 
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            audioSource.PlayOneShot(audioClip);
        }
    }

    private void Update()
    {
        if (isOpening)
        {
            float step = moveSpeed * Time.deltaTime;
            door.transform.position = Vector3.MoveTowards(door.transform.position, new Vector3(door.transform.position.x, lowerHeight, door.transform.position.z), step);
            if (door.transform.position.y <= lowerHeight)
            {
                isOpening = false;  
            }
        }
    }
}

