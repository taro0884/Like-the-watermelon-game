using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keepfruit_script : MonoBehaviour
{
    public Sprite image1;
    public Sprite image2;
    public Sprite image3;
    public Sprite image4;
    public Sprite image5;
    private Vector3 mousePos;

    private Image keepfruit_image;

    // Start is called before the first frame update
    void Start()
    {
        keepfruit_image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = Input.mousePosition.x;
        pos.y = 820.0f;

        //Vector3 cameraPosition = Input.mousePosition;
        //cameraPosition.z = 10.0f;
        //cameraPosition.y = 400.0f;
        //Vector2 pos = Camera.main.ScreenToWorldPoint(cameraPosition);

        this.transform.position = pos;

        if (GameManager.next[0] == 1)
        {
            keepfruit_image.sprite = image1;
        }
        else if (GameManager.next[0] == 2)
        {
            keepfruit_image.sprite = image2;
        }
        else if (GameManager.next[0] == 3)
        {
            keepfruit_image.sprite = image3;
        }
        else if (GameManager.next[0] == 4)
        {
            keepfruit_image.sprite = image4;
        }
        else if (GameManager.next[0] == 5)
        {
            keepfruit_image.sprite = image5;
        }

        //if (Input.GetMouseButtonDown(0))
        //{
        //
        //}

        //Transform myTransform = this.transform;

        //Vector2 pos = myTransform.position;
        //pos.x = mousePos.x;
        //pos.y = 200f;

        //myTransform.position = pos;
        //transform.position = Input.mousePosition;

        //Vector3 mousePos = Input.mousePosition;
        //screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(mousePos);
        //gameObject.transform.position = screenToWorldPointPosition;
    }
}
