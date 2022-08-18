using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCombainControll : MonoBehaviour
{
      static public float speed = 11f;
    private void Start()
    {
        gameObject.GetComponent<FollowPath>().speed = speed;
    }
}
