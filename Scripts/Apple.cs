using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    

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

        if (other.tag == "Player")
        {
            FindObjectOfType<AudioManager>().PlaySound("PickUpApples");
            PlayerManager.numberOfApples += 1;
            Destroy(gameObject);

        }
    }

}
