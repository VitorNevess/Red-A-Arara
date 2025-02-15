﻿using UnityEngine;

public class DanoController : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        var macacoController = transform.parent.gameObject.GetComponent<MacacoController>();

        if (collision2D.gameObject.CompareTag(TagsConstants.Player))
        {
            if (!macacoController.isJump)
            {
                Destroy(transform.parent.gameObject);
            }
            else
            {
                macacoController.playerScript.PlayerDie();
            }
        }
    }
}
