using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallSizeSelect : MonoBehaviour
{
    public GameObject playerball;
    public Dropdown playerSize;
    private float size = 1.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeSize()
    {
        switch (playerSize.value)
        {
            case 1:
                size = 1.0f;
                break;
            case 2:
                size = 2.0f;
                break;
            case 3:
                size = 3.0f;
                break;
            default:
                size = 1.0f;
                break;
        }

        
        playerball.transform.localScale = new Vector3(size, size, size);
        
        playerball.transform.localPosition = new Vector3(playerball.transform.localPosition.x, 0.5f * size, playerball.transform.localPosition.z);
    }
}
