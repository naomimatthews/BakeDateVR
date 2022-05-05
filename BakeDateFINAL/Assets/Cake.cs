using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using System;

public class Cake : MonoBehaviour
{
    [SerializeField] public GameObject rightMilk;
    [SerializeField] public GameObject rightChocolate;
    [SerializeField] public GameObject rightCream;
    [SerializeField] public GameObject pourMilk;

    [SerializeField] public GameObject finalCake;

    public TextMeshProUGUI ingredientsText;

    public int ingredients = 0;

    // Start is called before the first frame update
    void Start()
    {
        finalCake.SetActive(false);
        rightMilk.SetActive(true);
        rightChocolate.SetActive(true);
        rightCream.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        ingredientsText.SetText("Ingredients: " + ingredients);

        Debug.Log(ingredients);

        if (ingredients == 3)
        {
            finalCake.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ingredients")
        {
            ingredients++;
            Destroy(collision.gameObject);
        }
    }
}
