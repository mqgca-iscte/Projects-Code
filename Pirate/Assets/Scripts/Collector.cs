using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    private int SmallMoneyCounter;
    [SerializeField] private Text coins_number;

    private void Start()
    {
        SmallMoneyCounter = 0;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Money"))
        {
            Destroy(collider.gameObject);
            SmallMoneyCounter++;
            coins_number.text = "Coins : " + SmallMoneyCounter;
        }
    }
}
