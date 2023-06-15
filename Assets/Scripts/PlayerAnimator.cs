using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private PlayerController player; //Ustawiam player, aby z niego wyci¹gn¹c metodê IsWalking.
    private const string IS_JUMPING = "IsJumping"; // Jest to w pewnym stopniu zabezpieczenie, by przy SetBool dobrze wpisaæ nazwê.
    private Animator animator;




    private void Awake()
    {
        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        animator.SetBool(IS_JUMPING, player.IsJumping());
    }
}
