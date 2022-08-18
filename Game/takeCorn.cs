using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeCorn : MonoBehaviour
{
    [SerializeField] cornNumber cornN;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "corn")
        {
            Destroy(other.gameObject);
            if(gameObject.name== "kombainPlayer") cornN.Corn++;
                        
        }
    }



}
