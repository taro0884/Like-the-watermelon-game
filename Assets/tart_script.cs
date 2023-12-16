using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tart_script : MonoBehaviour
{
    //GameObject nextfruit2 = GameManager.fruit2;
    public GameObject fruit5;
    bool flag = true;
    private AudioSource audioSource;
    [SerializeField] private AudioClip se;

    // Start is called before the first frame update
    private void Start()
    {
        flag = true;
        audioSource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "tart")

            foreach (ContactPoint2D point in collision.contacts)
            {
                Vector3 hitPos = (Vector3)point.point;
                //Debug.Log(hitPos);
                Destroy(gameObject);

                if (this.flag == true && collision.gameObject.GetComponent<seed_script>().flag == true)
                {
                    this.flag = false;
                    AudioSource.PlayClipAtPoint(se, hitPos);
                    Instantiate(fruit5, hitPos, Quaternion.identity);
                    GameManager.score += 20;
                }
            }
        //Vector3 hitPos = 

        //Debug.Log("OnCollisionEnter2D: " + collision.gameObject.name);
        //Instantiate(fruit2, hitPos, Quaternion.identity);
    }

}
