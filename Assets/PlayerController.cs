using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    bool _attack = false;
    [SerializeField]GameObject attackEffect;

    float horizontalKey;
    Rigidbody2D rb;

    [SerializeField]
    float _runSpeed = 4.0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        attackEffect.SetActive(false);
    }
    private void Update()
    {
        Move();
    }
    public void Attack()
    {
        StartCoroutine(AttackDelay());

    }


    private void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            if(_attack == true) {
                CoinManager.coin += CoinManager.addCoin;
                Destroy(col.gameObject);
                EnemyController.enemyCount--;
            }
        }
    }


    private void Move()
    {
        horizontalKey = Input.GetAxis("Horizontal");
        if (horizontalKey > 0)
        {
            rb.velocity = new Vector2(_runSpeed, rb.velocity.y);
        }
        else if (horizontalKey < 0)
        {
            rb.velocity = new Vector2(-_runSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }

    IEnumerator AttackDelay()
    {
        _attack = true;
        attackEffect.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        _attack = false;
        attackEffect.SetActive(false);
    }

}
