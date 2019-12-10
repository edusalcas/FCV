using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charController : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 4f;
    [SerializeField]
    float smoothnessFactor;
    [SerializeField]
    private Text coinText;

    private int coinCount = 0;

    Vector3 forward, right;
    Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (keyMoves())
        {
            anim.SetInteger("Condicion", 1);
            Move();
        } else
        {
            anim.SetInteger("Condicion", 0);
        }
    }

    private bool keyMoves()
    {
        return Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W);
    }

    void Move()
    {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;

        Vector3 direction = new Vector3(Input.GetAxis("Horizontalkey"), 0, Input.GetAxis("Verticalkey"));
        Vector3 rightMovement = right * moveSpeed * Time.deltaTime * Input.GetAxis("Horizontalkey");
        Vector3 upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxis("Verticalkey");

        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);
        transform.forward = Vector3.Slerp(transform.forward, heading, smoothnessFactor);
        transform.position += rightMovement;
        transform.position += upMovement;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            coinCount++;
            coinText.text = coinCount.ToString();
        }
    }
}
