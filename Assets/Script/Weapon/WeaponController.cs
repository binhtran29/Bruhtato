using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public float rotationSpeed;
    protected float angle;
    
    [SerializeField] private PlayerController player;
    public Animator anim;
    
    private Vector3 movement;

    private void Start()
    {
        
    }

    private void Update()
    {
        Movement();
        if(player.stats.hp <= 0)
            Despawn();
    }

    private void Movement()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        
        Vector2 move = new Vector2(movement.x, movement.y);
        move.Normalize();

        transform.position = player.transform.position;
        if(movement.x > 0) transform.localScale = new Vector3(1, -1, 1);
        else if(movement.x < 0) transform.localScale = new Vector3(1, 1, 1);

        if (move != Vector2.zero)
        {
            angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg * rotationSpeed;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }

    private void Despawn()
    { 
        Destroy(this.gameObject);
    }
}
