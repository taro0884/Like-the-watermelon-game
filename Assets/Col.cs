using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Col : MonoBehaviour
{
    public GameObject banana;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {

        Vector3 hitPos = collision.contacts[0].point;
        Destroy(gameObject);
        Debug.Log("ê⁄êG ê⁄êGà íu"+hitPos);
        Instantiate(banana, hitPos, Quaternion.identity);
    }
}
