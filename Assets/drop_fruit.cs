using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop_fruit : MonoBehaviour
{
    public GameObject fruit;


    public GameObject fruit1;
    public GameObject fruit2;
    public GameObject fruit3;
    public GameObject fruit4;
    public GameObject fruit5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = Input.mousePosition;
        cameraPosition.z = 10.0f;
        Vector2 fruitpos = Camera.main.ScreenToWorldPoint(cameraPosition);
        //Vector2 fruitpos = transform.position;
        //fruitpos.x = Input.mousePosition.x;
        //fruitpos.y = 820.0f;

        this.transform.position = fruitpos;

        if (Input.GetMouseButtonDown(0))
        {
            if (GameManager.next[0] == 1)
            {
                Debug.Log("種："+fruitpos );
                Instantiate(fruit1, fruitpos, Quaternion.identity);
            }
            else if (GameManager.next[0] == 2)
            {
                Debug.Log("かぼちゃ" + fruitpos);
                Instantiate(fruit2, fruitpos, Quaternion.identity);
            }
            else if (GameManager.next[0] == 3)
            {
                Debug.Log("花" + fruitpos);
                Instantiate(fruit3, fruitpos, Quaternion.identity);
            }
            else if (GameManager.next[0] == 4)
            {
                Debug.Log("タルト" + fruitpos);
                Instantiate(fruit4, fruitpos, Quaternion.identity);
            }
            else if (GameManager.next[0] == 5)
            {
                Debug.Log("ライスコロッケ" + fruitpos);
                Instantiate(fruit5, fruitpos, Quaternion.identity);
            }
        }
    }
}
