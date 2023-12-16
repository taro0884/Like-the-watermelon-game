using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class nextimage_script : MonoBehaviour
{
    public Sprite image1;
    public Sprite image2;
    public Sprite image3;
    public Sprite image4;
    public Sprite image5;
    private Image image;

    // Start is called before the first frame update
    void Start()
    {
        //this.gameObject.SetActive(false);
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.next[1] == 1){
            image.sprite = image1;
        }
        else if(GameManager.next[1] == 2){
            image.sprite = image2;
        }
        else if(GameManager.next[1] == 3){
            image.sprite = image3;
        }
        else if(GameManager.next[1] == 4){
            image.sprite = image4;
        }
        else if(GameManager.next[1] == 5) {
            image.sprite = image5;
        }

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    // ‰æ‘œ‚ğØ‚è‘Ö‚¦‚Ü‚·
        //    this.gameObject.SetActive(true);
        //    image.sprite = image1;
        //}
    }
}
