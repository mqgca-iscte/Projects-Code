using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPoint : MonoBehaviour
{
    [SerializeField] private GameObject[] stoppoints;
    private int currentStopPoint = 0;
    private float Xline = 0f;
    private SpriteRenderer sprite;
    [SerializeField] private float speed = 2f;
    private bool True_or_false;

    private void Start()
    {
        True_or_false = true;
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
// float Xline = Input.GetAxisRaw("Horizontal");
        if (Vector2.Distance(stoppoints[currentStopPoint].transform.position, transform.position) < .1f)
        {
            currentStopPoint++;
            if (currentStopPoint >= stoppoints.Length)
            {
                currentStopPoint = 0;
            }
                sprite.flipX = True_or_false;
              True_or_false = !True_or_false;
            }
        transform.position = Vector2.MoveTowards(transform.position, stoppoints[currentStopPoint].transform.position, Time.deltaTime * speed);
    }
}
