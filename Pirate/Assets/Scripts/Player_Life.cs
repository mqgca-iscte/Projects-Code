using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Life : MonoBehaviour
{
    private Animator a;
    private Rigidbody2D rigid;
    // Start is called before the first frame update
    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        a = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collison)
    {
        if (collison.gameObject.CompareTag("Enemy") || collison.gameObject.CompareTag("Fall"))
            {
            Die();
        }
    }

    private void Die()
    {
        rigid.bodyType = RigidbodyType2D.Static;
        a.SetTrigger("death");
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
