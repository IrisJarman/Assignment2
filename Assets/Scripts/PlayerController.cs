using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private int count;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Set the count to zero 
        count = 0;

        SetCountText();

        // Set the text property of the Win Text UI to an empty string, making the 'You Win' (game over message) blank
        winTextObject.SetActive(false);
    }
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;

    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * KeepData.PlayingSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count >= 12)
        {
            // Set the text value of your 'winText'
            winTextObject.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
