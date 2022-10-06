using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Movimientos : MonoBehaviour
{
    public float Gameobject;
    public float speedMultiplier;
    public float jumpForce;
    public bool canJump;
    public float datosDelChoque;
    public TMP_Text canvasText;
    public GameObject winPanel;
    public int totalItems;
    public float speed;
    public int itemsCollected = 0;


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-speedMultiplier * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(speedMultiplier * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0f, 0f, speedMultiplier * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0f, 0f, -speedMultiplier * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0f, speedMultiplier * Time.deltaTime, 0f);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            Destroy(collision.gameObject);
            itemsCollected++; // le sumo uno
            UpdateUI();

            if (itemsCollected == totalItems)
            {

                Debug.Log("Ganaste");
                winPanel.SetActive(true);
                speedMultiplier = 0;
                jumpForce = 0;
            }
        }

    }
    private void Start()
    {
        totalItems = GameObject.FindGameObjectsWithTag("Item").Length;
        
        winPanel.SetActive(false);
        Debug.Log($"Balls: {itemsCollected}/{totalItems}");
        UpdateUI();
    }

    
    private void UpdateUI()
    {

        canvasText.text = $"Balls: {itemsCollected}/{totalItems}";
     
    }

   








}
